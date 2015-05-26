using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FHIRUK.Resources;
using System.IO;

namespace fhirtestdatagen
{
    public partial class FormFHIRTestDatGen : Form
    {
        private static Int32 PATIENT_COUNT = 10;

        private static String FILE_GPS = @"..\..\lists\sds.gppractices.txt";
        private static String FILE_PCTS = @"..\..\lists\sds.pcts.txt";
        private static String FILE_TRUSTS = @"..\..\lists\sds.nhstrust.txt";
        private static String FILE_INDEPENDENTS = @"..\..\lists\sds.independent.txt";

        private List<SDSConfigNodeLines> gpItems = new List<SDSConfigNodeLines>();
        private List<SDSConfigNode> gpKeyValueObjects = new List<SDSConfigNode>();

        private ListViewColumnSorter lvwColumnSorter = null;

        HumanNameGenerator genNames = null;
        AddressGenerator genAddresses = null;

        public FormFHIRTestDatGen()
        {
            InitializeComponent();
        }
        
        private void butGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PATIENT_COUNT; i++)
            {
                Patient patient = GeneratePatient();
                AddPatientToList(patient);
            }
        }

        private Patient GeneratePatient()
        {
            Patient patient = new Patient();

            GenerateIdentifier(patient);
            GenerateName(patient);
            GenerateTelecom(patient);
            GenerateDOB(patient);
            GenerateAddress(patient);
            GenerateMaritalStatus(patient);
            GenerateMultiBirth(patient);
            GenerateContact(patient);

            return patient;
        }

        private void GenerateIdentifier(Patient patient)
        {
            patient.Identifier = IdentifierGenerator.GetRandomIdentifiers();
        }

        private void GenerateName(Patient patient)
        {
            EnumGender gender;

            patient.Name = genNames.GetRandomNames(out gender);

            patient.Gender = gender;
        }

        private void GenerateTelecom(Patient patient)
        {
            String familyName = patient.Name[0].Family[0];
            patient.Telecom = TelecomGenerator.GetRandomContacts(familyName);
        }

        private void GenerateDOB(Patient patient)
        {
            Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());

            Int32 year = randomGenerator.Next(1920, 2015);
            Int32 month = randomGenerator.Next(0, 12) + 1;
            Int32 day;
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    day = randomGenerator.Next(0, 30) + 1;
                    break;
                case 2:
                    day = randomGenerator.Next(0, 28) + 1;
                    break;
                default:
                    day = randomGenerator.Next(0, 31) + 1;
                    break;
            }

            patient.BirthDate = new DateTime(year, month, day);
        }

        private void GenerateAddress(Patient patient)
        {
            patient.Address = genAddresses.GetRandomAddresses(EnumAddressUse.home); 
        }

        private void GenerateMaritalStatus(Patient patient)
        {
            patient.MaritalStatus = MaritalStatusGenerator.GetRandomMaritalStatus(patient.BirthDate);
        }

        private void GenerateMultiBirth(Patient patient)
        {
            Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());
            // 90% single births, 9% twins. 1%triplets
            Int32 r = randomGenerator.Next(0, 100);
            if (r < 90)
                patient.MultipleBirth = 1;
            else if (r < 99)
                patient.MultipleBirth = 2;
            else
                patient.MultipleBirth = 3;
        }

        private void GenerateContact(Patient patient)
        {
            patient.Contact = new PatientContactGenerator().GetRandomContacts(patient);
        }

        private void AddPatientToList(Patient patient)
        {
            if ((patient == null) || (patient.Identifier == null) || (patient.Identifier.Count < 1))
                return;

            ListViewItem item = listViewData.Items.Add(patient.Identifier.ToString());
            item.SubItems.Add(patient.Name.ToString());
            item.SubItems.Add(patient.Telecom.ToString());
            item.SubItems.Add(patient.Gender.ToString());
            item.SubItems.Add(patient.BirthDate.ToShortDateString());
            item.SubItems.Add(String.Empty);    // deceased
            item.SubItems.Add(patient.Address.ToString());
            //item.SubItems.Add(EnumConversion.MaritalStatusToString(patient.MaritalStatus));
            item.SubItems.Add(patient.MaritalStatus.ToString());
            item.SubItems.Add(patient.MultipleBirth.ToString());
            item.SubItems.Add(String.Empty);    //  photo
            item.SubItems.Add(patient.Contact.ToString());    //  photo

            item.Tag = patient;
        }

        private void FormFHIRTestDatGen_Load(object sender, EventArgs e)
        {
            genNames = new HumanNameGenerator();
            genAddresses = new AddressGenerator();
        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count == 0)
                textBoxJSON.Text = String.Empty;
            else
            {
                ListViewItem item = listViewData.SelectedItems[0];
                Patient patient = item.Tag as Patient;
                textBoxJSON.Text = patient.JSON();
            }
        }

        private void ClearListItems()
        {
            gpItems.Clear();

            listViewOrgs.BeginUpdate();
            listViewOrgs.Items.Clear();
            listViewOrgs.EndUpdate();
        }

        private void butGPs_Click(object sender, EventArgs e)
        {
            LoadandDisplaySDSFile(FILE_GPS);
        }

        private void butPCTs_Click(object sender, EventArgs e)
        {
            LoadandDisplaySDSFile(FILE_PCTS);
        }

        private void butTrusts_Click(object sender, EventArgs e)
        {
            LoadandDisplaySDSFile(FILE_TRUSTS);
        }

        private void butIndependents_Click(object sender, EventArgs e)
        {
            LoadandDisplaySDSFile(FILE_INDEPENDENTS);
        }

        private void LoadandDisplaySDSFile(String sdsFile)
        {
            toolStripStatusLabelInfo.Text = "Clearing list items...";
            ClearListItems();

            toolStripStatusLabelInfo.Text = "Reading SDS file...";
            ReadSDSFile(sdsFile);

            toolStripStatusLabelInfo.Text = "Creating configuration objects...";
            ParseConfigurationItems();

            toolStripStatusLabelInfo.Text = "Displaying organisations...";
            DisplayItems();

            toolStripStatusLabelInfo.Text = listViewOrgs.Items.Count.ToString() + " items.";
        }

        private void ReadSDSFile(String sdsFile)
        {
            SDSConfigNodeLines gpItem = new SDSConfigNodeLines();

            using (StreamReader reader = new StreamReader(sdsFile))
            {
                while (reader.EndOfStream == false)
                {
                    String line = reader.ReadLine();
                    if (String.IsNullOrEmpty(line) == false)
                    {
                        gpItem.Add(line);
                    }
                    else
                    {
                        if (gpItem.Count > 0)
                        {
                            String firstLine = gpItem[0];
                            if (firstLine.StartsWith("dn:") == false)
                            {
                                gpItem.Clear();
                            }
                            else
                            {
                                gpItems.Add(gpItem);
                                gpItem = new SDSConfigNodeLines();
                            }
                        }
                    }
                }

                reader.Close();
            }
        }

        private void ParseConfigurationItems()
        {
            gpKeyValueObjects.Clear();

            foreach (SDSConfigNodeLines gpItem in gpItems)
            {
                SDSConfigNode gpKeyValueObject = new SDSConfigNode(gpItem);

                gpKeyValueObjects.Add(gpKeyValueObject);
            }
        }

        private void DisplayItems()
        {
            listViewOrgs.BeginUpdate();

            foreach (SDSConfigNode pairs in gpKeyValueObjects)
            {
                String uniqueidentifier = pairs.GetValue("uniqueidentifier");
                String odsCode = pairs.GetValue("nhsdhsccode");
                String shaCode = pairs.GetValue("nhsshacode");
                String practiceName = pairs.GetValue("o");
                String telephonenumber = pairs.GetValue("telephonenumber");
                String postaladdress = pairs.GetValue("postaladdress");
                String postalcode = pairs.GetValue("postalcode");
                String orgTypeCode = pairs.GetValue("nhsorgtypecode");
                String fax = pairs.GetValue("facsimiletelephonenumber");

                if (practiceName != null)
                {
                    ListViewItem item = listViewOrgs.Items.Add(uniqueidentifier);
                    item.SubItems.Add(orgTypeCode);
                    item.SubItems.Add(odsCode);
                    item.SubItems.Add(shaCode);
                    item.SubItems.Add(practiceName);
                    item.SubItems.Add(telephonenumber);
                    item.SubItems.Add(fax);
                    //item.SubItems.Add(postaladdress);
                    ParsePostalAddress(item, postaladdress);
                    item.SubItems[9].Text = postalcode;


                }
            }

            listViewOrgs.EndUpdate();
        }

        private void ParsePostalAddress(ListViewItem item, String postaladdress)
        {
            String[] addressItems = postaladdress.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (addressItems.Length < 3)
            {
                if (addressItems.Length == 2)
                {
                    item.SubItems.Add("");
                    item.SubItems.Add(addressItems[0]);
                    item.SubItems.Add("");  // postcode
                    item.SubItems.Add(addressItems[1]);
                }
                else
                {
                    item.SubItems.Add(postaladdress);
                    item.SubItems.Add("");
                    item.SubItems.Add("");  // postcode
                    item.SubItems.Add("");
                }
                return;
            }

            String county = addressItems[addressItems.Length - 1].Trim();
            String town = addressItems[addressItems.Length - 2].Trim();
            String street = String.Empty;
            for (int i = 0; i < (addressItems.Length - 2); i++)
            {
                if (street != String.Empty)
                    street += ",";

                street += addressItems[i].Trim();
            }

            item.SubItems.Add(street);
            item.SubItems.Add(town);
            item.SubItems.Add("");  // postcode
            item.SubItems.Add(county);
        }

        private void listViewOrgs_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            listViewOrgs.BeginUpdate();

            this.listViewOrgs.ListViewItemSorter = lvwColumnSorter;

            this.listViewOrgs.Sort();

            this.listViewOrgs.ListViewItemSorter = null;

            listViewOrgs.EndUpdate();
        }

        private void listViewOrgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrgs.SelectedItems.Count == 0)
                textBoxJSON.Text = String.Empty;
            else
            {
                ListViewItem item = listViewOrgs.SelectedItems[0];
                Organization organization = item.Tag as Organization;
                //textBox1.Text = organization.JSON();
            }
        }
    }
}

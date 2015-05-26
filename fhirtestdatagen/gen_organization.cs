using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FHIRUK.Resources;

using System.Diagnostics;

namespace fhirtestdatagen
{
    public class OrganizationGenerator
    {
        private Organizations organizations = new Organizations();

        //private List<String> orgNames = new List<String>();
        //private String orgNamesFile = @"..\..\lists\org.names.txt";

        Random randomGenerator;

        public OrganizationGenerator()
        {
            randomGenerator = new Random(Guid.NewGuid().GetHashCode()); 
            
            //LoadOrgNamesFromFile();
        }

        public void AddOrganization(Organization org)
        {
            organizations.Add(org);
        }

/*
        private void LoadOrgNamesFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(orgNamesFile))
                {
                    while (reader.EndOfStream == false)
                    {
                        String line = reader.ReadLine();
                        line = line.Trim();
                        if (String.IsNullOrEmpty(line) == false)
                        {
                            orgNames.Add(line);
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception e)
            {
                // do something
                Debug.Write(e.Message);
            }

        }
*/

        public Organization GetRandomOrganization()
        {
            if (organizations.Count == 0)
                return null;

            Int32 index = randomGenerator.Next(0, organizations.Count);

            Organization org = organizations[index];

            return org;
#if false
            org.name = GetRandomOrgName();
            String url = GetRandomUrl(org.name);
            org.identifier = IdentifierGenerator.GetRandomIdentifiers(true, url);
            org.type = EnumOrganizationType.prov;

            return org;
#endif
        }

#if false

        private String GetRandomUrl(String orgName)
        {
            String[] items = orgName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String domainName = String.Empty;
            foreach (String item in items)
            {
                domainName += item[0];
            }
            domainName = domainName.ToLower();

            return "http://www." + domainName + ".nhs.uk";
        }

        public String GetRandomOrgName()
        {
            return orgNames[randomGenerator.Next(0, orgNames.Count)];
        }
#endif

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FHIRUK.Resources;

namespace fhirtestdatagen
{
    public class PatientGenerator
    {
        private HumanNameGenerator genNames = null;
        private AddressGenerator genAddress = null;

        public PatientGenerator()
        {
            genNames = new HumanNameGenerator();
            genAddress = new AddressGenerator();
    }

    public Patient GeneratePatient(OrganizationGenerator orgsGen)
        {
            Patient patient = new Patient();

            GenerateIdentifier(patient);
            GenerateName(patient);
            GenerateTelecom(patient);
            GenerateDOB(patient);
            GenerateAddress(patient);
            GenerateMaritalStatus(patient);
            GenerateMultiBirth(patient);
            GenerateContact(patient, orgsGen);
            GenerateCommunication(patient);
            GenerateCareProvider(patient, orgsGen);
            GenerateCareProvider(patient, orgsGen);

            return patient;
        }

        private void GenerateIdentifier(Patient patient)
        {
            patient.identifier = IdentifierGenerator.GetRandomIdentifiers();
            patient.id = patient.identifier[0].value;
        }

        private void GenerateName(Patient patient)
        {
            EnumGender gender;

            patient.name = genNames.GetRandomNames(out gender);

            patient.gender = gender;
        }

        private void GenerateTelecom(Patient patient)
        {
            String familyName = patient.name[0].family[0];
            patient.telecom = TelecomGenerator.GetRandomContacts(familyName);
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

            patient.birthDate = new DateTime(year, month, day);
        }

        private void GenerateAddress(Patient patient)
        {
            patient.address = genAddress.GetRandomAddresses(EnumAddressUse.home);
        }

        private void GenerateMaritalStatus(Patient patient)
        {
            patient.maritalStatus = MaritalStatusGenerator.GetRandomMaritalStatus(patient.birthDate);
        }

        private void GenerateMultiBirth(Patient patient)
        {
            Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());
            // 90% single births, 9% twins. 1%triplets
            Int32 r = randomGenerator.Next(0, 100);
            if (r < 90)
                patient.multipleBirth = 1;
            else if (r < 99)
                patient.multipleBirth = 2;
            else
                patient.multipleBirth = 3;
        }

        private void GenerateContact(Patient patient, OrganizationGenerator orgGen)
        {
            patient.contact = new PatientContactGenerator().GetRandomContacts(patient, orgGen);
        }

        private void GenerateCommunication(Patient patient)
        {
            patient.communication = new PatientCommunications();

            PatientCommunication comms = new PatientCommunication()
            {
                language = new CodeableConcept()
                {
                    coding = new Coding()
                    {
                        system = new Uri("urn:fhir.nhs.uk:vs/Language"),
                        code = "012",
                        display = "English"
                    },
                    text = "English"
                },
                preferred = true
            };

            patient.communication.Add(comms);
        }

        private void GenerateCareProvider(Patient patient, OrganizationGenerator orgsGen)
        {
            patient.careProvider = new References();
            // this should be either a GP practice, or a practicioner from a GP practice, or both
            // ideally, patient and careProvider postcodes should be near each other - however, in the first instance, we will just do a random thing
            Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());
            Reference provider;

            Boolean isOrganization;

            //  organisation 80% of cases
            isOrganization = randomGenerator.Next(0, 100) < 80;
            EnumGender gender;
            HumanNames practitionerName = genNames.GetRandomNames(out gender);


            if (isOrganization)
            {
                // organization
                Organization org = orgsGen.GetRandomOrganization();
                if ((org != null) && (org.identifier != null) && (org.identifier.Count > 0))
                {
                    provider  = new Reference()
                    {
                        reference = new Uri("Organization/" + org.identifier[0].value, UriKind.Relative),
                        display = org.ToString()
                    };
                }
                else
                {
                    provider  = new Reference()
                    {
                        reference = new Uri("/error", UriKind.Relative),
                        display = "Invalid Organization object."
                    };
                }
            }
            else
            {
                // practitioner
                provider = new Reference()
                {
                    reference = new Uri("Practitioner/PT" + randomGenerator.Next(0, 1000000).ToString("D6"), UriKind.Relative),
                    display = "Dr " + practitionerName[0].ToString()
                };
            }

            patient.careProvider.Add(provider);

            if (isOrganization)
            {
                // if organisation provided, also provide a practitioner in 30% of the cases
                if (randomGenerator.Next(0, 100) < 30)
                {
                    // practitioner
                    provider  = new Reference()
                    {
                        reference = new Uri("Practitioner/PT" + randomGenerator.Next(0, 1000000).ToString("D6"), UriKind.Relative),
                        display = "Dr " + practitionerName[0].ToString()
                    };
                    patient.careProvider.Add(provider );
                }
            }
        }
    }
}

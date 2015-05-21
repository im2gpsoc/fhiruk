﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHIRUK.Resources;

namespace fhirtestdatagen
{
    public class PatientContactGenerator
    {
        private Random randomGenerator;

        public PatientContactGenerator()
        {
            randomGenerator = new Random(Guid.NewGuid().GetHashCode());
        }

        public PatientContacts GetRandomContacts(Patient patient)
        {
            PatientContacts contacts = new PatientContacts();

            Int32 numOfContacts = 1;
            if (randomGenerator.Next(0, 100) >= 90)
                numOfContacts = 2;

            for (int i = 0; i < numOfContacts; i++)
            {
                PatientContact contact = GetRandomContact(patient);
                contacts.Add(contact);
            }

            return contacts;
        }
        /// <summary>
        /// Todo: for now, use a simple approach to relationships depending on age
        /// in the future, refine this approach
        /// </summary>
        /// <returns></returns>
        public PatientContact GetRandomContact(Patient patient)
        {
            PatientContact patientContact = new PatientContact();

            patientContact.Relationship = GetRandomRelationship(patient, patientContact);
            EnumGender gender;
            patientContact.Name = new HumanNameGenerator().GetRandomName(out gender);
            patientContact.Gender = gender;

            if (IsCareGiver(patientContact))
            {
                OrganizationGenerator orgGen = new OrganizationGenerator();
                patientContact.Organization = orgGen.GetRandomOrganization();
            }
            else
            {
                String familyName = patientContact.Name.Family[0];
                patientContact.Telecom = TelecomGenerator.GetRandomContacts(familyName);
            }

            return patientContact;
        }

        private Boolean IsCareGiver(PatientContact patientContact)
        {
            List<EnumPatientRelationship> relationships = patientContact.Relationship;

            foreach (EnumPatientRelationship relationship in relationships)
            {
                if (relationship == EnumPatientRelationship.caregiver)
                    return true;
            }

            return false;
        }

        private List<EnumPatientRelationship> GetRandomRelationship(Patient patient, PatientContact patientContact)
        {
            // EnumPatientRelationship = emergency, family, guardian, friend, partner, work, caregiver, agent, guarantor, owner, parent
            List<EnumPatientRelationship> relationships = new List<EnumPatientRelationship>();

            Int32 ageInYears = (new DateTime(DateTime.Now.Subtract(patient.BirthDate).Ticks).Year - 1);

            Int32 option = randomGenerator.Next(0, 100);

            if (ageInYears >= 80)
            {
                // 80% (family AND optionally emergency), 20% (caregiver AND optionally emergency)
                if (option < 80)
                    relationships.Add(EnumPatientRelationship.family);
                else
                    relationships.Add(EnumPatientRelationship.caregiver);
            }
            else if (ageInYears >= 18)
            {
                //  60% family, 30% partner, 10% friend
                if (option < 60)
                    relationships.Add(EnumPatientRelationship.family);
                else if (option < 90)
                    relationships.Add(EnumPatientRelationship.partner);
                else
                    relationships.Add(EnumPatientRelationship.friend);
            }
            else
            {
                if (option < 95)
                    relationships.Add(EnumPatientRelationship.parent);
                else
                    relationships.Add(EnumPatientRelationship.guardian);
            }

            option = randomGenerator.Next(0, 100);
            if (option < 30)
                relationships.Add(EnumPatientRelationship.emergency);

            return relationships;
        }
    }
}

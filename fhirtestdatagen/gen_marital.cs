using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FHIRUK.Resources;

namespace fhirtestdatagen
{
    public class MaritalStatusGenerator
    {
        public static EnumMaritalStatus GetRandomMaritalStatus(DateTime dob)
        {
            /*
                EnumMaritalStatus.A --> "Annulled"
                EnumMaritalStatus.D --> "Divorced"
                EnumMaritalStatus.I --> "Interlocutor"
                EnumMaritalStatus.L --> "Legally Separated"
                EnumMaritalStatus.M --> "Married"
                EnumMaritalStatus.P --> "Polygamous"
                EnumMaritalStatus.S --> "Never Married"
                EnumMaritalStatus.T --> "Domestic partner"
                EnumMaritalStatus.W --> "Widowed"
             */

            Random randomGenerator = new Random(Guid.NewGuid().GetHashCode());

            Int32 ageInYears = GetAgeInYears(dob);
            EnumMaritalStatus result = EnumMaritalStatus.S;

            if (ageInYears < 18)
            {
                result = EnumMaritalStatus.S;
            }
            else if (ageInYears < 30)
            {
                // 50% never married, 40% married, 5% domestic partner, 2% divorced, 2% legally separated, 1% widowed
                Int32 r = randomGenerator.Next(0, 100);
                if (r < 50)
                    result = EnumMaritalStatus.S;
                else if (r < 90)
                    result = EnumMaritalStatus.M;
                else if (r < 95)
                    result = EnumMaritalStatus.T;
                else if (r < 97)
                    result = EnumMaritalStatus.D;
                else if (r < 99)
                    result = EnumMaritalStatus.L;
                else
                    result = EnumMaritalStatus.W;
            }
            else if (ageInYears < 45)
            {
                // 15% never married, 40% married, 8% domestic partner, 20% divorced, 10% legally separated, 5% widowed, 
                Int32 r = randomGenerator.Next(0, 100);
                if (r < 15)
                    result = EnumMaritalStatus.S;
                else if (r < 55)
                    result = EnumMaritalStatus.M;
                else if (r < 63)
                    result = EnumMaritalStatus.T;
                else if (r < 83)
                    result = EnumMaritalStatus.D;
                else if (r < 93)
                    result = EnumMaritalStatus.L;
                else if (r < 94)
                    result = EnumMaritalStatus.A;
                else if (r < 95)
                    result = EnumMaritalStatus.I;
                else
                    result = EnumMaritalStatus.W;
            }
            else if (ageInYears < 65)
            {
                // 10% never married, 40% married, 5% domestic partner, 30% divorced, 5% legally separated, 10% widowed, 
                Int32 r = randomGenerator.Next(0, 100);
                if (r < 10)
                    result = EnumMaritalStatus.S;
                else if (r < 50)
                    result = EnumMaritalStatus.M;
                else if (r < 55)
                    result = EnumMaritalStatus.T;
                else if (r < 85)
                    result = EnumMaritalStatus.D;
                else if (r < 90)
                    result = EnumMaritalStatus.L;
                else
                    result = EnumMaritalStatus.W;
            }
            else
            {
                // 5% never married, 50% married, 3% domestic partner, 12% divorced, 30% widowed, 
                Int32 r = randomGenerator.Next(0, 100);
                if (r < 5)
                    result = EnumMaritalStatus.S;
                else if (r < 55)
                    result = EnumMaritalStatus.M;
                else if (r < 58)
                    result = EnumMaritalStatus.T;
                else if (r < 70)
                    result = EnumMaritalStatus.D;
                else
                    result = EnumMaritalStatus.W;
            }

            return result;
        }

        private static Int32 GetAgeInYears(DateTime dob)
        {
            return (new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1);
        }
    }
}

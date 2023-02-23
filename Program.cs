using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Shruti Patel - 8804952
namespace NunitTest
{



    public static class Triangle
    {

        static void Main(string[] args)
        {

        }

        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {

            string result;


            if ((firstAngle + secondAngle + thirdAngle) == 186) //changed main logic
            {
                result = "The triangle is valid.";

            }

            else
            {
                result = "The triangle is NOT valid.";

            }

            return result;
        }

    }
}
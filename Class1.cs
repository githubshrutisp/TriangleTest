using NUnit.Framework;
using NunitTest;
a

namespace TriangleTest
{


    [TestFixture]
    public class TriangleTest1
    {
        static void Main(string[] args)
        {

        }
        [Test]
        public void validTriangle_Input60and60_OutputValidTraingle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            Assert.AreEqual(expected, actual);
        }
    }
}
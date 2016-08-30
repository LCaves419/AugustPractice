using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStats result = book.ComputeStats();
            Assert.AreEqual(90, result.HighestGrade);

        }


        [TestMethod]
        public void ComputeLowestestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStats result = book.ComputeStats();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);//makes complier teat 89.5 as a float
            book.AddGrade(75);

            GradeStats result = book.ComputeStats();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);

        }
    }
}

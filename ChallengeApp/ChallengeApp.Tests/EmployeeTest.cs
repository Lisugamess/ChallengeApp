using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void RatingsInLetters_ShouldCorrectAverageLetter()
        {
            var Employee = new Employee("Adam", "Nowak", "45");

            Employee.AddGrade('A');
            Employee.AddGrade('B');
            Employee.AddGrade('C');
            Employee.AddGrade('D');
            Employee.AddGrade('E');

            var statistcis = Employee.GetStatistics();

            Assert.AreEqual('a', statistcis.AverageLetter);

        }
        [Test]
        public void ChecksIfThereAreLowercaseAndUppercaseLetterGradeAverageCorrect()
        {
            var Employee = new Employee("Adam", "Nowak", "45");

            Employee.AddGrade('A');
            Employee.AddGrade('b');
            Employee.AddGrade('c');
            Employee.AddGrade('d');
            Employee.AddGrade('E');


            var statistcis = Employee.GetStatistics();

            Assert.AreEqual('a', statistcis.AverageLetter);

        }
        [Test]
        public void ChecksIfThereAreLowercaseAndUppercaseLetterGradeMinimumCorrect()
        {
            var Employee = new Employee("Adam", "Nowak", "45");


            Employee.AddGrade('A');
            Employee.AddGrade('b');
            Employee.AddGrade('c');
            Employee.AddGrade('d');
            Employee.AddGrade('E');

            var statistcis = Employee.GetStatistics();


            Assert.AreEqual(20, statistcis.Min);
        }
        [Test]
        public void ChecksIfThereAreLowercaseAndUppercaseLetterGradeMaximumCorrect()
        {
            
            var Employee = new Employee("Adam", "Nowak", "45");

            // act
            Employee.AddGrade('A');
            Employee.AddGrade('b');
            Employee.AddGrade('c');
            Employee.AddGrade('d');
            Employee.AddGrade('E');

            var statistcis = Employee.GetStatistics();

            // assert
            Assert.AreEqual(100, statistcis.Max);
        }
    }

}


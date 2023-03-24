﻿namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void CheckStatisticMax()
        {
            var employee = new Employee("Alan", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(6, statistic.Max);
        }


        [Test]
        public void CheckStatisticMin()
        {
            var employee = new Employee("Alan", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(2.0f, statistic.Min);
        }
        [Test]
        public void CheckStatisticAverage()
        {
            var employee = new Employee("Alan", "Nowak");
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(Math.Round(4.0d), Math.Round(statistic.Average));
        }
    }
}


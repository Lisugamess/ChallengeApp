namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeTwoScors_ShuldReturnCorrectResult()
        {
            var employee1 = new Employee("Adam", "nowak", "33");
            
            employee1.AddScore(5);
            employee1.AddScore(2);
            employee1.AddScore(7);
            employee1.AddScore(-14);


            var result = employee1.Rseult;
            

            Assert.AreEqual(0, result);
        }
    }
}

namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenEmployeeTwoScors_ShuldReturnCorrectResult()
        {
            User user1 = new User("Adam", "nowak", "33");
            
            user1.AddScore(5);
            user1.AddScore(2);
            user1.AddScore(7);
            user1.AddScore(-14);


            var result = user1.Rseult;
            

            Assert.AreEqual(0, result);
        }
    }
}

using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void CheckTextStringAreNotEqual()
        {
            // arange
            string text1 = "textfirst";
            string text2 = "textsecond";
            // act
            // assert
            Assert.AreNotEqual(text1 , text2);
        }
        [Test]
        public void CheckNamesVarAreNotEqual()
        {
            // arange
            var user1 = GetUser("Eliza");
            var user2 = GetUser("Monika");
            // act
            // assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void CheckNumberIntAreEqual()
        {
            // arange
            int number1 =  1;
            int number2 = 2;
            // act
            // assert
            Assert.AreNotEqual(number1, number2);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
        [Test]
        public void CheckFloatNumberAreEqual()
        {
            // arange
            float number1 = 1.23f;
            float number2 = 1.23f;
            // act
            // assert
            Assert.AreEqual(number1, number2);
        }
    }
}

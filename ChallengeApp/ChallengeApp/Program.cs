using ChallengeApp;

User user1 = new User("Adam", "nowak", "33");
User user2 = new User("Tomasz", "nowak", "23");



user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(7);

user2.AddScore(3);
user2.AddScore(8);
user2.AddScore(6);




List<User> user = new List<User>()
{
    user1, user2, 
};

int maxResult = -1;
User userWithMaxResult = null;

foreach (var User in user)
{
    if (User.Rseult > maxResult)
    {
        userWithMaxResult = User;
    }
}
Console.WriteLine("Najwyższą liczbą ocen ma : " + userWithMaxResult.Login);
Console.WriteLine("Name:" + userWithMaxResult.Login);
Console.WriteLine("Suma punktów: " + userWithMaxResult.Rseult);

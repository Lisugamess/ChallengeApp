namespace ChallengeApp
{
    public class User
    {
        private List<int> scoer = new List<int>();
        public User(string login)
        {
            this.Login = login;
        }
        public User(string login, string password, string v)
        {
            this.Login = login;
            this.Password = password ;
        }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Rseult
        {
            get
            {
                return this.scoer.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.scoer.Add(number);
            
        }
    }
}

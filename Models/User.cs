namespace PasswordSaver.Models
{
    public class User
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Accounts = new List<Account>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
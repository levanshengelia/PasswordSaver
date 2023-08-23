namespace PasswordSaver.Models
{
    public class Account
    {
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Comment { get; set; }


        public Account(string website, string username, string password, string comment)
        {
            Website = website;
            Username = username;
            Password = password;
            Comment = comment;
        }
    }
}
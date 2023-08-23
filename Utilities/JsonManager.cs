using Newtonsoft.Json;
using System.Text.Json;
using PasswordSaver.Models;

namespace PasswordSaver.Utilities
{
    internal static class JsonManager
    {

        internal static void AddUser(string username, string password)
        {
            var userList = GetAllUsers();

            userList.Add(new User(username, SecurityUtils.GetHashValue(password)));

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(userList, options);

            File.WriteAllText(PasswordSaverConstants.UserJsonPath, jsonString);
        }

        private static List<User> GetAllUsers()
        {
            var jsonContent = File.ReadAllText(PasswordSaverConstants.UserJsonPath);

            return JsonConvert.DeserializeObject<List<User>>(jsonContent) ?? throw new NullReferenceException();
        }

        public static User? GetUser(string username, string password, bool isNewUser = true)
        {
            var userList = GetAllUsers();

            return userList.FirstOrDefault(x => x.Username == username && (isNewUser || x.Password == SecurityUtils.GetHashValue(password)));
        }

        internal static void AddUserAccount(string username, Account account)
        {
            var userList = GetAllUsers();

            var user = userList.First(x => x.Username == username);
            user.Accounts.Add(account);

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(userList, options);

            File.WriteAllText(PasswordSaverConstants.UserJsonPath, jsonString);
        }

        internal static void DeleteAccount(string username, DataGridView accountGrid)
        {
            var website = (string)accountGrid.SelectedRows[0].Cells[0].Value;

            accountGrid.Rows.Remove(accountGrid.SelectedRows[0]);

            var userList = GetAllUsers();

            var user = userList.First(x => x.Username == username);
            user.Accounts = user.Accounts.Where(x => x.Website != website).ToList();

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(userList, options);

            File.WriteAllText(PasswordSaverConstants.UserJsonPath, jsonString);
        }

        internal static string GetUsersAccountPassword(string username, string website)
        {
            var userList = GetAllUsers();

            var user = userList.First(x => x.Username == username);
            var account = user.Accounts.First(x => x.Website == website);

            return account.Password;
        }
    }
}

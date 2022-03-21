using System.Data.OleDb;

namespace accounting_property_source.Classes
{
    class Users
    {
        public bool isUserExist(string username)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Users WHERE UserName='{username}'");
        }

        public bool isRightPass(string username, string password)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Users WHERE UserName='{username}' AND PasswordUser='{password}'");
        }

        public string GetUserId(string username)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Users WHERE UserName='{username}'")[0];
        }

        public int AddUser(params string[] data)
        {
            return DataBase.QueryElement($"INSERT INTO [Users] (UserName, PasswordUser, FirstName, SecondName, ThirdName, BirhDate, AccessLevel) VALUES ('{data[0]}','{data[1]}','{data[2]}','{data[3]}','{data[4]}', '{data[5]}', {data[6]})");
        }
    }
}

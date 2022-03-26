using System.Data.OleDb;

namespace accounting_property_source.Classes
{
    class Users
    {
        //Работа с таблицей Users

        //Проверка на существовании пользователя
        public bool isUserExist(string username)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Users WHERE UserName='{username}'");
        }
        //Проверка на правильность введёного пароля для пользователя. А по факту он просто проверяет на наличие запись с таким же Username и Password
        public bool isRightPass(string username, string password)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Users WHERE UserName='{username}' AND PasswordUser='{password}'");
        }

        //Получить Id по UserName(Логину)
        public string GetUserId(string username)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Users WHERE UserName='{username}'")[0];
        }
        //Добавляем элемент в таблицу.
        public int AddUser(params string[] data)
        {
            return DataBase.QueryElement($"INSERT INTO [Users] (UserName, PasswordUser, FirstName, SecondName, ThirdName, BirhDate, AccessLevel) VALUES ('{data[0]}','{data[1]}','{data[2]}','{data[3]}','{data[4]}', '{data[5]}', {data[6]})");
        }
    }
}

using System.Collections.Generic;
using System.Data;

namespace accounting_property_source.Classes
{
    class Supplier
    {
        //Работа с таблицей Supplier(Поставщики)

        //Получаем таблицу из БД. Так же передаем 2 параметра для фильтрации, если они пустые, то ничего не фильтруется.
        public DataTable GetTable(string org, string cont)
        {
            string endQuery = "";
            if (!string.IsNullOrEmpty(org))
                endQuery += " WHERE Org LIKE '" + org + "%'";
            if (!string.IsNullOrEmpty(cont))
            {
                if (string.IsNullOrEmpty(org)) endQuery += " WHERE";
                else endQuery += " AND";
                endQuery += " Contract LIKE '" + cont + "%'";
            }
            return DataBase.GetDataTable($"SELECT Id, Org as Организация, Contract as Договор From Supplier{endQuery}");
        }

        //Получаем список Org(Организаций)
        public List<string> GetOrg()
        {
            return DataBase.GetDataInList($"SELECT Org FROM Supplier");
        }

        //Проверка на существование такой-же Org(Организации)
        public bool IsOrgExists(string org)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Supplier WHERE Org='{org}'");
        }
        //Получаем Id по Org(наименовании организации)
        public string GetId(string org)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Supplier WHERE Org = '{org}'")[0];
        }
        //Добавляем элемент в таблицу.
        public int AddElement(string org, string contract)
        {
            return DataBase.QueryElement($"INSERT INTO [Supplier] (Org, Contract) VALUES ('{org}', '{contract}')");
        }
        //Изменяем нужный элемент по Id в табице
        public int UpdateElement(string org, string contract, string idType)
        {
            return DataBase.QueryElement($"UPDATE Supplier SET Org ='{org}', Contract ='{contract}' WHERE Id={idType}");
        }
        //Удалить нужный элемент по Id
        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Supplier WHERE Id={Id}");
        }
    }
}

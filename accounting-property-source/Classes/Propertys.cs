using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting_property_source.Classes
{
    class Propertys
    {
        //Работа с таблицей Propertys(Имущество)

        //Получаем таблицу из БД. Так же передаем 2 параметра для фильтрации, если они пустые, то ничего не фильтруется.
        public DataTable GetTable(string nameproperty, string idType)
        {
            string endQuery="";
            if (!string.IsNullOrEmpty(nameproperty))
                endQuery += " AND Propertys.NameProperty LIKE '" + nameproperty+ "%'";
            if(!string.IsNullOrEmpty(idType))
                endQuery += " AND Propertys.IdTypes = " + idType;
            return DataBase.GetDataTable($"SELECT Propertys.Id,Propertys.NameProperty as Наименование, Types.NameType as Тип, Propertys.Cost as Стоимость, Users.SecondName as Сотрудник FROM Propertys, Types, Users Where Propertys.IdTypes = Types.Id AND Propertys.IdUsers = Users.Id{endQuery}");
        }

        //Поучаем NameType(типы имущества) из таблицы Types(Типы)
        public List<string> GetTypes()
        {
            return DataBase.GetDataInList($"SELECT NameType FROM Types");
        }

        //Получаем Id по NameProperty(Наименование имущества).
        public string GetId(string property)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Propertys WHERE NameProperty = '{property}'")[0];
        }

        //получаем список NameProperty(Наименование имущества)
        public List<string> GetProp()
        {
            return DataBase.GetDataInList($"SELECT NameProperty FROM Propertys");
        }

        //Получаем список Id
        public List<string> GetIds()
        {
            return DataBase.GetDataInList($"SELECT Id FROM Propertys");
        }

        //Получаем Id из таблицы Types(Типы имущества) по NameType(типу имущества).
        public string GetIdType(string typename)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Types WHERE NameType='{typename}'")[0];
        }

        //Добавляем элемент
        public int AddElement(params string[] data)
        {
            return DataBase.QueryElement($"INSERT INTO [Propertys] (NameProperty, IdTypes, Cost, IdUsers) VALUES ('{data[0]}','{data[1]}', '{data[2]}', '{data[3]}')");
        }
        //Изменяем нужный элемент по Id в табице
        public int UpdateElement(params string[] data)
        {
            return DataBase.QueryElement($"UPDATE Propertys SET NameProperty ='{data[0]}', IdTypes = '{data[1]}', Cost = '{data[2]}', IdUsers = '{data[3]}' WHERE Id={data[4]}");
        }
        //Удалить нужный элемент по Id
        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Propertys WHERE Id={Id}");
        }
    }
}

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
        public DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT Propertys.Id,Propertys.NameProperty as Наименование, Types.NameType as Тип, Propertys.Cost as Стоимость, Users.SecondName as Сотрудник FROM Propertys, Types, Users Where Propertys.IdTypes = Types.Id AND Propertys.IdUsers = Users.Id ");
        }

        public List<string> GetTypes()
        {
            return DataBase.GetDataInList($"SELECT NameType FROM Types");
        }

        public string GetId(string property)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Propertys WHERE NameProperty = '{property}'")[0];
        }

        public List<string> GetProp()
        {
            return DataBase.GetDataInList($"SELECT NameProperty FROM Propertys");
        }

        public List<string> GetIds()
        {
            return DataBase.GetDataInList($"SELECT Id FROM Propertys");
        }

        public string GetIdType(string typename)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Types WHERE NameType='{typename}'")[0];
        }

        public int AddElement(params string[] data)
        {
            return DataBase.QueryElement($"INSERT INTO [Propertys] (NameProperty, IdTypes, Cost, IdUsers) VALUES ('{data[0]}','{data[1]}', '{data[2]}', '{data[3]}')");
        }

        public int UpdateElement(params string[] data)
        {
            return DataBase.QueryElement($"UPDATE Propertys SET NameProperty ='{data[0]}', IdTypes = '{data[1]}', Cost = '{data[2]}', IdUsers = '{data[3]}' WHERE Id={data[4]}");
        }

        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Propertys WHERE Id={Id}");
        }
    }
}

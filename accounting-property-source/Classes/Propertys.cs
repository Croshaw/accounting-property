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
            return DataBase.GetDataTable($"SELECT Propertys.Id,Propertys.NameProperty as Наименование, Types.NameType as Тип FROM Propertys, Types Where Propertys.IdTypes = Types.Id ");
        }

        public List<string> GetTypes()
        {
            return DataBase.GetDataInList($"SELECT NameType FROM Types");
        }

        public string GetIdType(string typename)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Types WHERE NameType='{typename}'")[0];
        }

        public int AddElement(params string[] data)
        {
            return DataBase.QueryElement($"INSERT INTO [Propertys] (NameProperty, IdTypes) VALUES ('{data[0]}','{data[1]}')");
        }

        public int UpdateElement(params string[] data)
        {
            return DataBase.QueryElement($"UPDATE Propertys SET NameProperty ='{data[0]}', IdTypes = '{data[1]}' WHERE Id={data[2]}");
        }

        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Propertys WHERE Id={Id}");
        }
    }
}

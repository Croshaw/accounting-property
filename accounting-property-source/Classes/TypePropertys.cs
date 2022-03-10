using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting_property_source.Classes
{
    class TypePropertys
    {
        public bool isTypeExists(string nameProp)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Types WHERE NameType='{nameProp}'");
        }

        public string GetIdByName(string nameProp)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Types WHERE NameType='{nameProp}'")[0];
        }

        public int AddElement(string nameProp)
        {
            return DataBase.QueryElement($"INSERT INTO [Types] (NameType) VALUES ('{nameProp}')");
        }

        public int UpdateElement(string nameProp, string idType)
        {
            return DataBase.QueryElement($"UPDATE Types SET NameType ='{nameProp}' WHERE Id={idType}");
        }

        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Types WHERE Id={Id}");
        }
    }
}

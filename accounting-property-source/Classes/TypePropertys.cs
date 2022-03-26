using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting_property_source.Classes
{
    class TypePropertys
    {
        //Работа с таблице Types(типы имущества)

        //Проверка на существование NameType(наименования типа)
        public bool isTypeExists(string nameProp)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Types WHERE NameType='{nameProp}'");
        }

        //Получаем Id по NameType(наименованию типа)
        public string GetIdByName(string nameProp)
        {
            return DataBase.GetDataInList($"SELECT Id FROM Types WHERE NameType='{nameProp}'")[0];
        }
        //Добавляем элемент в таблицу.
        public int AddElement(string nameProp)
        {
            return DataBase.QueryElement($"INSERT INTO [Types] (NameType) VALUES ('{nameProp}')");
        }
        //Изменяем нужный элемент по Id в табице
        public int UpdateElement(string nameProp, string idType)
        {
            return DataBase.QueryElement($"UPDATE Types SET NameType ='{nameProp}' WHERE Id={idType}");
        }
        //Удалить нужный элемент по Id
        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Types WHERE Id={Id}");
        }
    }
}

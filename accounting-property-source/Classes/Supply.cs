using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting_property_source.Classes
{
    class Supply
    {
        //Работа с таблице Suppy(Поставки)

        //Получаем таблицу из БД. Так же передаем 4 параметра для фильтрации, если они пустые, то ничего не фильтруется.
        public DataTable GetTable(string org,string prop, string minDate, string maxDate)
        {
            string endQuery = "";
            if (!string.IsNullOrEmpty(org))
                endQuery += " AND Supplier.Id = " + org;
            if (!string.IsNullOrEmpty(prop))
                endQuery += " AND Propertys.Id = " + prop;
            if (minDate != null && maxDate != null)
                endQuery += $" AND Supply.DateSupply BETWEEN #{minDate}# and #{maxDate}#";
            else
            if (minDate != null)
                endQuery += $" AND Supply.DateSupply >= #{minDate}#";
            else if (maxDate != null)
                endQuery += $" AND Supply.DateSupply <= #{maxDate}#";
            return DataBase.GetDataTable($"SELECT Supply.Id, Supplier.Id, Propertys.Id, Supplier.Org as Организация, Propertys.NameProperty as Продукт, Supply.DateSupply as Дата From Supply,Supplier, Propertys WHERE Supplier.Id=Supply.IdSupplier AND Supply.IdPropertys=Propertys.Id{endQuery}");
        }
        //Добавляем элемент в таблицу.
        public int AddElement(params string[] items)
        {
            return DataBase.QueryElement($"INSERT INTO [Supply] (IdSupplier, IdPropertys, DateSupply) VALUES ('{items[0]}', '{items[1]}', '{items[2]}')");
        }
        //Изменяем нужный элемент по Id в табице
        public int UpdateElement(params string[] items)
        {
            return DataBase.QueryElement($"UPDATE Supply SET IdSupplier ='{items[0]}', IdPropertys ='{items[1]}', DateSupply = '{items[2]}' WHERE Id={items[3]}");
        }
        //Удалить нужный элемент по Id
        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Supply WHERE Id={Id}");
        }
    }
}

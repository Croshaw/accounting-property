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
        public DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT Supply.Id, Supplier.Id, Propertys.Id, Supplier.Org as Организация, Propertys.NameProperty as Продукт, Supply.DateSupply as Дата From Supply,Supplier, Propertys WHERE Supplier.Id=Supply.IdSupplier AND Supply.IdPropertys=Propertys.Id");
        }

        public int AddElement(params string[] items)
        {
            return DataBase.QueryElement($"INSERT INTO [Supply] (IdSupplier, IdPropertys, DateSupply) VALUES ('{items[0]}', '{items[1]}', '{items[2]}')");
        }

        public int UpdateElement(params string[] items)
        {
            return DataBase.QueryElement($"UPDATE Supply SET IdSupplier ='{items[0]}', IdPropertys ='{items[1]}', DateSupply = '{items[2]}' WHERE Id={items[3]}");
        }

        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Supply WHERE Id={Id}");
        }
    }
}

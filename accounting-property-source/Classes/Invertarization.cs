using System.Data;

namespace accounting_property_source.Classes
{
    class Invertarization
    {
        public DataTable GetTable()
        {
            return DataBase.GetDataTable($"SELECT Invertarization.Id, Propertys.NameProperty as Имущество, Invertarization.StatusInv as Статус, Invertarization.DateInvent as Дата FROM Invertarization, Propertys WHERE Propertys.Id = Invertarization.IdProp");
        }

        public DataTable GetTableParam(string param)
        {
            return DataBase.GetDataTable($"SELECT Propertys.NameProperty as Имущество, Invertarization.StatusInv as Статус, Invertarization.DateInvent as Дата FROM Invertarization, Propertys WHERE Propertys.Id = Invertarization.IdProp AND Invertarization.StatusInv='{param}'");
        }

        public int AddElement(params string[] items)
        {
            return DataBase.QueryElement($"INSERT INTO [Invertarization] (IdProp, StatusInv, DateInvent) VALUES ('{items[0]}', '{items[1]}', '{items[2]}')");
        }

        public int UpdateElement(params string[] items)
        {
            return DataBase.QueryElement($"UPDATE Invertarization SET IdProp='{items[0]}', StatusInv='{items[1]}', DateInvent='{items[2]}' WHERE Id={items[3]}");
        }

        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Invertarization WHERE Id={Id}");
        }

        public bool IsExists(string IdProp)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Invertarization WHERE IdProp={IdProp} AND StatusInv='Списана'");
        }

        public int GetCount(string type)
        {
            return DataBase.CountQueryElement($"SELECT COUNT(*) FROM Invertarization WHERE StatusInv='{type}'");
        }
    }
}

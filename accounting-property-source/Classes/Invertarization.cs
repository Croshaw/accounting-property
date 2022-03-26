using System.Data;

namespace accounting_property_source.Classes
{
    class Invertarization
    {
        //Работа с таблице Invertarization(Инвентаризации)

        //Получаем таблицу из БД. Так же передаем 4 параметра для фильтрации, если они пустые, то ничего не фильтруется.
        public DataTable GetTable(string prop, string status, string minDate, string maxDate)
        {
            string endQuery = "";
            if (!string.IsNullOrEmpty(prop))
                endQuery += " AND Invertarization.IdProp = " + prop;
            if (!string.IsNullOrEmpty(status))
                endQuery += " AND Invertarization.StatusInv = '" + status+"'";
            if (minDate != null && maxDate != null)
                endQuery += $" AND Invertarization.DateInvent BETWEEN #{minDate}# and #{maxDate}#";
            else
            if (minDate != null)
                endQuery += $" AND Invertarization.DateInvent >= #{minDate}#";
            else if (maxDate != null)
                endQuery += $" AND Invertarization.DateInvent <= #{maxDate}#";
            return DataBase.GetDataTable($"SELECT Invertarization.Id, Propertys.NameProperty as Имущество, Invertarization.StatusInv as Статус, Invertarization.DateInvent as Дата FROM Invertarization, Propertys WHERE Propertys.Id = Invertarization.IdProp{endQuery}");
        }

        //Добавляем элемент в таблицу.
        public int AddElement(params string[] items)
        {
            return DataBase.QueryElement($"INSERT INTO [Invertarization] (IdProp, StatusInv, DateInvent) VALUES ('{items[0]}', '{items[1]}', '{items[2]}')");
        }
        //Изменяем нужный элемент по Id в табице
        public int UpdateElement(params string[] items)
        {
            return DataBase.QueryElement($"UPDATE Invertarization SET IdProp='{items[0]}', StatusInv='{items[1]}', DateInvent='{items[2]}' WHERE Id={items[3]}");
        }
        //Удалить нужный элемент по Id
        public int DeleteElement(string Id)
        {
            return DataBase.QueryElement($"DELETE FROM Invertarization WHERE Id={Id}");
        }

        //Проверка на наличие такого же IdProp(имущества) со StatusInv(статусом) Списана. Делается для того, чтоб пользователь ничего не делал уже со списаным имуществом.
        public bool IsExists(string IdProp)
        {
            return DataBase.QueryInDataBase($"SELECT Id FROM Invertarization WHERE IdProp={IdProp} AND StatusInv='Списана'");
        }

        //Поучить кол-во записей в таблице по StatusInv(Статусу).
        public int GetCount(string type)
        {
            return DataBase.CountQueryElement($"SELECT COUNT(*) FROM Invertarization WHERE StatusInv='{type}'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace accounting_property_source.Classes
{
    class DataBase
    {
        private static OleDbConnection dbConnection = null;
        private static OleDbCommand dbCommand = null;
        private static OleDbDataAdapter dataAdapter = null;
        private static OleDbDataReader dataReader = null;
        private static string connectionString = null;

        //Строка подключения БД.
        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        //Открывает соединение с БД
        public static void OpenConnection()
        {
            if (connectionString == null) throw new ArgumentNullException("Connection string cannot be null!");
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
        }

        //Закрываем соедениение с БД, если оно открыто
        public static void CloseConnection()
        {
            if (dbConnection != null && dbConnection.State == System.Data.ConnectionState.Open)
                dbConnection.Close();
        }

        //Получаем таблицу из БД по Запросу который мы передаем в качестве параметра
        public static DataTable GetDataTable(string query)
        {
            if (query == null) throw new ArgumentNullException("Query cannot be null!");
            dataAdapter = new OleDbDataAdapter(query, dbConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds.Tables[0];
        }

        //Получаем список элементов из БД по запросу, чаще всего используем, чтобы получить 1 элемент. Пример пароль по логину.
        public static List<string> GetDataInList(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (query == null) throw new ArgumentNullException("Query cannot be null!");
            dbCommand = new OleDbCommand(query, dbConnection);
            dataReader = dbCommand.ExecuteReader();
            List<string> tempList = new List<string>();
            while (dataReader.Read())
            {
                tempList.Add(dataReader.GetValue(0).ToString());
            }    
            dataReader.Close();
            return tempList;
        }
        //Проверка есть ли запись в таблице БД
        public static bool QueryInDataBase(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (query == null) throw new ArgumentNullException("Query cannot be null!");
            bool result = false;
            dbCommand = new OleDbCommand(query, dbConnection);
            dataReader = dbCommand.ExecuteReader();
            if (dataReader.Read())
                result = true;
            dataReader.Close();
            return result;
        }

        //Для удаления, изменения и добавления элементов в БД
        public static int QueryElement(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (query == null) throw new ArgumentNullException("Query cannot be null!");

            dbCommand = new OleDbCommand(query, dbConnection);
            return dbCommand.ExecuteNonQuery();
        }

        //Для получение числа записей в таблице, по запросу
        public static int CountQueryElement(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (query == null) throw new ArgumentNullException("Query cannot be null!");

            dbCommand = new OleDbCommand(query, dbConnection);
            return Convert.ToInt32(dbCommand.ExecuteScalar());
        }
    }
}

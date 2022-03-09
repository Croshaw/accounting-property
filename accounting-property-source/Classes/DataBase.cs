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

        public static void OpenConnection()
        {
            if (connectionString == null) throw new ArgumentNullException("Connection string cannot be null!");
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
        }

        public static void CloseConnection()
        {
            if (dbConnection != null && dbConnection.State == System.Data.ConnectionState.Open)
                dbConnection.Close();
        }

        public static DataTable GetDataTable(string query)
        {
            if (query == null) throw new ArgumentNullException("Query cannot be null!");
            dataAdapter = new OleDbDataAdapter(query, dbConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds.Tables[0];
        }

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

        public static int QueryElement(string query)
        {
            if (dbConnection == null) throw new ArgumentNullException("Connection cannot be null!");
            if (query == null) throw new ArgumentNullException("Query cannot be null!");

            dbCommand = new OleDbCommand(query, dbConnection);
            return dbCommand.ExecuteNonQuery();
        }
    }
}

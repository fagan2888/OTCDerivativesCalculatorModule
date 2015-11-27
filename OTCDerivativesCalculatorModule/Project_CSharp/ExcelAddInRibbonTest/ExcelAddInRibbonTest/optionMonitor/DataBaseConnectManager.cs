using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace ExcelAddInRibbonTest
{
    public class DataBaseConnectManager
    {
        public static DbConnection DBConnection_;
        public static int ConnectStatus_;

        public static DbDataAdapter CreateDataAdapter(DbCommand dbCommand, DbConnection connection)
        {
            DbDataAdapter adapter; //we can't construct an adapter directly
            //So let's run around the block 3 times, before potentially crashing

            if (connection is System.Data.SqlClient.SqlConnection)

                adapter = new System.Data.SqlClient.SqlDataAdapter(dbCommand.CommandText, connection as SqlConnection);
            else if (connection is System.Data.OleDb.OleDbConnection)
                adapter = new System.Data.OleDb.OleDbDataAdapter(dbCommand.CommandText, connection as System.Data.OleDb.OleDbConnection);
            else if (connection is System.Data.Odbc.OdbcConnection)
                adapter = new System.Data.Odbc.OdbcDataAdapter(dbCommand.CommandText, connection as System.Data.Odbc.OdbcConnection);
            else if (connection is System.Data.SqlServerCe.SqlCeConnection)
                adapter = new System.Data.SqlServerCe.SqlCeDataAdapter(dbCommand.CommandText, connection as System.Data.SqlServerCe.SqlCeConnection);
            //TODO: Add more DbConnection kinds as they become invented
            else
            {
                throw new Exception("[CreateDataAdapter] Unknown DbConnection type: " + connection.GetType().FullName);
            }

            return adapter;
        }

        public static DbConnection ConnectionFactory(string connStr)
        {
            SqlCeConnection connection = new SqlCeConnection(connStr);

            return connection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DataBaseManager
    {
        public DataBaseManager()
        { }

        public PositionHostInfo PositionHostInfo_ { get; set; }

        public void bookPositionData()
        { 
        
        }

        public List<InstPositionInfo> loadPositionData()
        {
            DataTable tb = new DataTable();

            using (SqlCeConnection connection = new SqlCeConnection("Data Source=D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\MarketDataBase.sdf"))
            using (SqlCeCommand command = connection.CreateCommand())
            {

                command.CommandText = "SELECT KR_CODE , INST_NAME , INST_CODE , INST_TYPE , " +
                                            " BOOKED_DATE , UNBOOKED_DATE , MATURITY_DATE , " +
                                            " FILE_NAME , POSITION_NAME , COUNTERPARTY , " +
                                            " NOTIONAL , CURRENCY , FUND_CODE , FUND_NAME FROM POSITIONMASTER";
                                        

                connection.Open();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

                dataAdapter.Fill(tb);
            }

            List<InstPositionInfo> positionList = new List<InstPositionInfo>();

            DataLoader loader = new DataLoader();

            DataRow[] resultRows = tb.Select();

            foreach (DataRow item in resultRows)
	        {
                InstPositionInfo instData = new InstPositionInfo(item["KR_CODE"].ToString(),
                                                 item["INST_NAME"].ToString(),
                                                 item["INST_CODE"].ToString(),
                                                 item["INST_TYPE"].ToString(),
                                                 item["BOOKED_DATE"].ToString(),
                                                 item["UNBOOKED_DATE"].ToString(),
                                                 item["MATURITY_DATE"].ToString(),
                                                 item["FILE_NAME"].ToString(),
                                                 item["POSITION_NAME"].ToString(),
                                                 item["COUNTERPARTY"].ToString(),
                                                 item["NOTIONAL"].ToString(),
                                                 item["CURRENCY"].ToString(),
                                                 item["FUND_CODE"].ToString(),
                                                 item["FUND_NAME"].ToString()
                                                 );
                positionList.Add(instData);

	        }

            return positionList;
        }

        public ObservableCollection<PositionBookingInfoVM> loadPositionBookingInfoVM()
        {
            

            DataTable tb = new DataTable();

            using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=D:\Project File\OTCDerivativesCalculatorModule\ExcelOTCManagerAddIn\PositionMasterInformationDB.sdf"))
            using (SqlCeCommand command = connection.CreateCommand())
            {

                command.CommandText = "SELECT " +
                                        "ITEMCODE,"+
                                        "KRCODE,"+
                                        "TEAMCODE,"+
                                        "FUNDCODE,"+
                                        "BOOKID,"+
                                        "EXCELTYPE,"+
                                        "PRODUCTTYPE,"+
                                        "GROUPID,"+
                                        "GROUPSTATE,"+
                                        "ITEMNAME,"+
                                        "SHORTNAME,"+
                                        "ISSUEDATE,"+
                                        "MATURITYDATE,"+
                                        "UNDERLYING,"+
                                        "COUNTERPARTY,"+
                                        "CONTRACTTYPE,"+
                                        "NOTIONAL,"+
                                        "CURRENCY,"+
                                        "BOOKEDORDER,"+
                                        "BOOKINGSTATE,"+
                                        "BOOKINGDATE "+

                                        "FROM MASTERINFO";


                connection.Open();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

                dataAdapter.Fill(tb);
            }

            ObservableCollection<PositionBookingInfoVM> vmList = new ObservableCollection<PositionBookingInfoVM>();

            DataLoader loader = new DataLoader();

            DataRow[] resultRows = tb.Select();

            foreach (DataRow item in resultRows)
            {
                PositionBookingInfoVM positionData 
                    = new PositionBookingInfoVM(item["ITEMCODE"].ToString(),
                                                item["KRCODE"].ToString(),
                                                item["TEAMCODE"].ToString(),
                                                item["FUNDCODE"].ToString(),
                                                item["BOOKID"].ToString(),
                                                item["EXCELTYPE"].ToString(),
                                                item["PRODUCTTYPE"].ToString(),
                                                item["GROUPID"].ToString(),
                                                item["GROUPSTATE"].ToString(),
                                                item["ITEMNAME"].ToString(),
                                                item["SHORTNAME"].ToString(),
                                                item["ISSUEDATE"].ToString(),
                                                item["MATURITYDATE"].ToString(),
                                                item["UNDERLYING"].ToString(),
                                                item["COUNTERPARTY"].ToString(),
                                                item["CONTRACTTYPE"].ToString(),
                                                item["NOTIONAL"].ToString(),
                                                item["CURRENCY"].ToString(),
                                                item["BOOKEDORDER"].ToString(),
                                                item["BOOKINGSTATE"].ToString(),
                                                item["BOOKINGDATE"].ToString());

                vmList.Add(positionData);

            }

            return vmList;
        }

        public bool hasInstDB(string itemCode)
        {
            return false;
        }

        public void addInstDB(string tableName,
                              List<string> fieldName, 
                              List<string> fieldValue)
        {
            // error fieldName Count != fieldValue;
            // table의 columnNum 와 filedNameCount 는 같아야함

            int fieldNameNum = fieldName.Count;

            SqlCeConnection connection = new SqlCeConnection(@"Data Source=D:\Project File\OTCDerivativesCalculatorModule\ExcelOTCManagerAddIn\PositionMasterInformationDB.sdf");

            List<string> wrappingFieldValue = new List<string>();

            foreach (var item in fieldValue)
            {
                wrappingFieldValue.Add(QueryStr.wrapComma(item));
            }

            try
            {
                StringBuilder sb = new StringBuilder();

                DataTable tb = new DataTable();

                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                SqlCeCommand delCommand = connection.CreateCommand();

                sb.Append("INSERT INTO " + tableName + " ( ");
                
                for (int i = 0; i < fieldNameNum; i++)
			    {
                    sb.Append(fieldName[i]);

                    if (i != fieldNameNum - 1)
                    {
                        sb.Append(", ");
                    }
			    }

                sb.Append(") ");

                sb.Append("VALUES (");

                for (int i = 0; i < fieldNameNum; i++)
                {
                    sb.Append(wrappingFieldValue[i]);

                    if (i != fieldNameNum - 1)
                    {
                        sb.Append(", ");
                    }
                }

                sb.Append(") ");

                command.CommandText = sb.ToString();

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (SqlCeException e)
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : MRO DB Load");
                throw;
            }
        }

        public void addInstDB(InstPositionWrapperVM wrapperVM)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source=D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\MarketDataBase.sdf");

            try
            {

                DataTable tb = new DataTable();

                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                SqlCeCommand delCommand = connection.CreateCommand();
                //delCommand.CommandText = "DELETE FROM CORRELATION WHERE DATE ='" + ReferenceDate_.ToString("yyyyMMdd") + "'";
                //delCommand.ExecuteNonQuery();

                string KR_CODE = QueryStr.wrapComma(wrapperVM.KRCode_);
                string INST_NAME = QueryStr.wrapComma(wrapperVM.InstName_);
                string INST_CODE = QueryStr.wrapComma(wrapperVM.InstCode_);
                string BOOKED_DATE = QueryStr.wrapComma(wrapperVM.BookedDate_);
                string UNBOOKED_DATE = QueryStr.wrapComma(wrapperVM.UnBookedDate_);
                string MATURITY_DATE = QueryStr.wrapComma(wrapperVM.MaturityDate_);
                string INST_TYPE = QueryStr.wrapComma(wrapperVM.InstType_);
                string FILE_NAME = QueryStr.wrapComma(wrapperVM.FileName_);
                string POSITION_NAME = QueryStr.wrapComma(wrapperVM.PositionName_);
                string COUNTERPARTY = QueryStr.wrapComma(wrapperVM.CounterParty_);
                string NOTIONAL = QueryStr.wrapComma(wrapperVM.Notional_);
                string CURRENCY = QueryStr.wrapComma(wrapperVM.Currency_);
                string FUND_CODE = QueryStr.wrapComma(wrapperVM.FundCode_);
                string FUND_NAME = QueryStr.wrapComma(wrapperVM.FundName_);

                command.CommandText = "INSERT INTO POSITIONMASTER (KR_CODE,INST_NAME,INST_CODE,BOOKED_DATE,UNBOOKED_DATE," + 
                                      " MATURITY_DATE,INST_TYPE,FILE_NAME,POSITION_NAME,COUNTERPARTY," + 
                                      " NOTIONAL,CURRENCY,FUND_CODE,FUND_NAME) " +
                                      " VALUES (" + KR_CODE + "," +
                                                    INST_NAME + "," +
                                                    INST_CODE + "," +
                                                    BOOKED_DATE + "," +
                                                    UNBOOKED_DATE + "," +
                                                    MATURITY_DATE + "," +
                                                    INST_TYPE + "," +
                                                    FILE_NAME + "," +
                                                    POSITION_NAME + "," +
                                                    COUNTERPARTY + "," +
                                                    NOTIONAL + "," +
                                                    CURRENCY + "," +
                                                    FUND_CODE + "," +
                                                    FUND_NAME + ")";
                                                  

                    //command.ExecuteNonQuery();

                    //command.Parameters.Add("@pdate", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pcode_a", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pname_a", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pcode_b", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pname_b", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pcorr", SqlDbType.NVarChar);
                    //command.Parameters.Add("@ptype", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pvendor", SqlDbType.NVarChar);
                    //command.Parameters.Add("@pdescription", SqlDbType.NVarChar);

                    //foreach (DataRow item in tb.Rows)
                    //{
                    //    string code_a = item["STOCK_ID"].ToString();
                    //    string code_b = item["OTHER_ID"].ToString();

                    //    if (code_a != code_b)
                    //    {
                    //        command.Parameters["@pdate"].Value = item["STD_DATE"].ToString();
                    //        command.Parameters["@pcode_a"].Value = code_a;
                    //        command.Parameters["@pname_a"].Value = "null";
                    //        command.Parameters["@pcode_b"].Value = code_b;
                    //        command.Parameters["@pname_b"].Value = "null";
                    //        command.Parameters["@pcorr"].Value = item["CORR"].ToString();
                    //        command.Parameters["@ptype"].Value = "History";
                    //        command.Parameters["@pvendor"].Value = "MRO";
                    //        command.Parameters["@pdescription"].Value = "This is test";

                    //        command.ExecuteNonQuery();
                    //    }
                    //}

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (SqlCeException e)
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : MRO DB Load");
                throw;
            }
        }


    }
}

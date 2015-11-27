using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Xml;

namespace RiskMonitor
{
    public class MROPositionDataLoader
    {
        private string connStr_;
        private string todayDate_;
        //public string PositionPath_;

        //private List<string> loadedPosition_;
        private Dictionary<string, string> loadedPosition_;
        private DataSet positionDataSet_;

        //public MROPositionDataLoader(string connStr) 
        public MROPositionDataLoader(string refDate) 
        {
            this.connStr_ ="DSN=RMS_OP;UID=RM_VIEW;PWD=ahslxj1!;";
            //this.connStr_ = connStr;
            this.todayDate_ = refDate;
            //PositionPath_ = new DirectoryInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\");
            
            positionDataSet_= new DataSet("OTCDataSet");
            this.loadDataSet();


        }

        public List<string> underlyingList()
        { 
            // 이렇게 말고 이미 로드된 instrument에서 뽑아내는 걸로

            List<string> list = new List<string>();

            DataTable table = positionDataSet_.Tables["Underlying"];

            DataRow[] stock_ids = table.Select();

            foreach (DataRow row in stock_ids)
            {
                string str = row["STOCK_ID"].ToString();
                if (!list.Contains<string>(str))
                {
                    list.Add(str);
                }
            }

            return list;
        }

        private void loadDataSet() 
        {
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString = connStr_;

            try
            {
                OdbcCommand sqlCommand = new OdbcCommand();

                conn.Open();

                // ------------------------------------------ Position --------------------------------------------
                //sqlCommand.CommandText = "select KR_CD from RDW.kom_psit_inf where ( isd_fund_cd='A27212' ) and basc_dt = '" + todayDate_ + "'";
                sqlCommand.CommandText = "select KR_CODE from td_mrposition where cust_fund_code in ('A27212','A27211','A27214') and std_date = '" + todayDate_ + "'";
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

                positionDataSet_.Tables.Add("Position");
                dataAdapter.Fill(positionDataSet_.Tables["Position"]);

                // ------------------------------------------ Redemption --------------------------------------------
                sqlCommand.CommandText = "select ELS_CODE, SEQ, STRIKE_DATE, STRIKE_RATE1, REDEM_RATE1 from mro.otc_tc_mrelsredem";

                dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

                positionDataSet_.Tables.Add("Redemption");
                dataAdapter.Fill(positionDataSet_.Tables["Redemption"]);

                // ------------------------------------------ Underlying --------------------------------------------
                sqlCommand.CommandText = "select ELS_CODE, " +
                                         "STOCK_ID, " +
                                         "ROUND(BASE_PRICE,1) AS BASE_PRICE, " +
                                         "MULTIPLIER, " +
                                         "BARRIER_YN " + // ? 어다 쓰는겨?
                                         "from mro.otc_tc_mrelsstockprice";

                dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

                positionDataSet_.Tables.Add("Underlying");
                dataAdapter.Fill(positionDataSet_.Tables["Underlying"]);

                //------------------------------------------- Master --------------------------------------

                sqlCommand.CommandText = "select ELS_CODE, " +
                                         "BOND_NAME, " +
                                         "ISSUE_AMT, " +
                                         "OPTION_START_DATE, " +
                                         "DUE_DATE, " +
                                         "ROUND(BARRIER_INDEX2,0) as BARRIER_INDEX2, " +
                                         "REBATE_RATE, " +
                                         "STOCK_CNT " +
                                         "from mro.otc_tc_mrelsmaster";

                dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

                positionDataSet_.Tables.Add("ELSMaster");
                dataAdapter.Fill(positionDataSet_.Tables["ELSMaster"]);
                conn.Close();

            }
            catch (OdbcException e)
            {
                conn.Close();
            }

        }

        //public ObservableCollection<Instrument> getPosition()
        //{
        //    loadedPosition_ = new List<string>();
        //    ObservableCollection<Instrument> position = new ObservableCollection<Instrument>() ;

        //    DataTable table = positionDataSet_.Tables["Position"];

        //    foreach (DataRow row in table.Rows)
        //    {
        //        Instrument inst = this.buildInstrument(row["KR_CD"].ToString());
        //        //if (inst.Underlying_ != null)
        //        //{
        //        //    position.Add(inst);
        //        //}
        //    }


        //    return position;

        //}

        public void updateDB()
        {
            OracleDataBaseConnect conn = new OracleDataBaseConnect();
            //conn.addQuery(

        }

        public void saveFile(string directory)
        {
            int count = 0;
            
            foreach (var item in this.loadedPosition_)
            {
                string krcd = item.Key;
                string filePath = directory + krcd + "_StepDownKI.xml";
                string fileName = krcd + "_StepDownKI.xml";

                File.WriteAllText(filePath,item.Value, new UTF8Encoding(true));
                Console.WriteLine(count + " : " + fileName + " : build complete");

                count += 1;    
            }
            Console.WriteLine("total gen number : " + count);
        }

        public void makePosition()
        {
            loadedPosition_ = new Dictionary<string,string>();
            List<string> position = new List<string>();

            DataTable table = positionDataSet_.Tables["Position"];
            int count = 0;
            foreach (DataRow row in table.Rows)
            {
                count += 1;
                string krcd = row["KR_CODE"].ToString();
                string inst = this.buildInstrumentXml(krcd);
                //StreamWriter writer = File.CreateText(PositionPath_ + inst);

                loadedPosition_.Add(krcd, inst);

                //string filePath = PositionPath_ + krcd + "_StepDown.xml";
                //string fileName = krcd + "_StepDown.xml";
                ////StreamWriter writer = File.CreateText();
                //File.WriteAllText(filePath, inst, new UTF8Encoding(true));
                //Console.WriteLine(count + " : " + fileName + " : build complete");

             
                //writer.Encoding = new UTF8Encoding(true);

                //File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
                //writer.Write(inst);
                
                //writer.Close();
            }

            Console.WriteLine("total gen number : " + count);
        }

        private string buildInstrumentXml(string elsCode)
        {
            List<string> exceptionList = new List<string>();
            
            //StepDownELSInformation info = new StepDownELSInformation();
            //EquiryLinkedSecurity.ELSStepDown stepDown = new EquiryLinkedSecurity.ELSStepDown();

            //------------------------------------------- ELS_REDEM --------------------------------------

            List<DateTime> autoCallDates = new List<DateTime>();
            List<double> autoCallReturn = new List<double>();
            List<double> autoCallTrigger = new List<double>();

            List<ELSUnderlyingStock> underlyings = new List<ELSUnderlyingStock>();

            string productXml = "Error_0";

            {
                DataTable table = positionDataSet_.Tables["Redemption"];

                string selectionSqlStr = "ELS_CODE='" + elsCode + "'";

                DataRow[] rows = table.Select(selectionSqlStr, "SEQ ASC");

                if (rows.Length < 1)
                {
                    exceptionList.Add("No Exist Redemption Information of " + elsCode);
                }

                foreach (DataRow row in rows)
                {
                    string STRIKE_DATE = row["STRIKE_DATE"].ToString();

                    autoCallDates.Add(CustomFunction.StrToDate(STRIKE_DATE));

                    string STRIKE_RATE1 = row["STRIKE_RATE1"].ToString();
                    autoCallTrigger.Add(Convert.ToDouble(STRIKE_RATE1));
                    
                    string REDEM_RATE1 = row["REDEM_RATE1"].ToString();
                    autoCallReturn.Add(Convert.ToDouble(REDEM_RATE1));

                }
            }

            //------------------------------------------- Underlying --------------------------------------
            {
                DataTable table = positionDataSet_.Tables["Underlying"];

                string selectionSqlStr = "ELS_CODE='" + elsCode + "'";

                DataRow[] rows = table.Select(selectionSqlStr);

                if (rows.Length < 1)
                {
                    exceptionList.Add("No Exist Underlying Information of " + elsCode);
                }

                foreach (DataRow row in rows)
                {

                    string stock_KRCode = row["STOCK_ID"].ToString();
                    string kk = row["BASE_PRICE"].ToString();
                    double base_price = Convert.ToDouble(row["BASE_PRICE"].ToString());

                    underlyings.Add(new ELSUnderlyingStock(stock_KRCode, base_price));

                }
            }

            //------------------------------------------- Master --------------------------------------
            {
                DataTable table = positionDataSet_.Tables["ELSMaster"];

                bool barrierFlag = false;
                
                string selectionSqlStr = "ELS_CODE='" + elsCode + "'";

                DataRow[] rows = table.Select(selectionSqlStr);

                if (rows.Length < 1)
                {
                    exceptionList.Add("No Exist ELSMaster Information of " + elsCode);
                }

                foreach (DataRow row in rows)
                {
                    string ELS_CODE = row["ELS_CODE"].ToString();
                    string BOND_NAME = row["BOND_NAME"].ToString();
                    //string ISSUE_AMT = row["ISSUE_AMT"].ToString();
                    Int64 ISSUE_AMT = Convert.ToInt64(row["ISSUE_AMT"].ToString());
                    DateTime OPTION_START_DATE = DateTime.ParseExact(row["OPTION_START_DATE"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
                    DateTime DUE_DATE = DateTime.ParseExact(row["DUE_DATE"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
                    double rebateRate = Convert.ToDouble(row["REBATE_RATE"].ToString())/100;
                    int maturityYear = (DUE_DATE - OPTION_START_DATE).Days / 365;
                    
                    List<double> KIs = new List<double>();

                    double BARRIER_INDEX2 = Convert.ToDouble(row["BARRIER_INDEX2"].ToString());

                    for (int i = 0; i < underlyings.Count; i++)
                    {
                        KIs.Add(BARRIER_INDEX2);    
                    }
                    
                    productXml = InstrumentMakerTool.ELSStepDown(ELS_CODE,
                                                                BOND_NAME,
                                                                ISSUE_AMT,
                                                                underlyings,
                                                                OPTION_START_DATE,
                                                                DUE_DATE,
                                                                maturityYear,
                                                                autoCallDates,
                                                                autoCallTrigger,
                                                                rebateRate,
                                                                1,
                                                                KIs,
                                                                autoCallReturn);

                }

                

            }

            return productXml;

        }

        //public void MROMasterToXml()
        //{
        //    DataTable masterTable = positionDataSet_.Tables["ELSMaster"];
        //    DataTable redemTable = positionDataSet_.Tables["Redemption"];

        //    XmlDocument doc = new XmlDocument();

        //    //Master Information
        //    string InstName = "ELS999";
        //    long notional = 10000;



        //    List<string> unders = new List<string>();

        //    unders.Add("SK"); unders.Add("LG");

        //    //Master Information
        //    DateTime effectiveDate = new DateTime();
        //    int maturityYear = 3;

        //    int redemTenorMonth = 6;


        //    List<double> redemptionTrigger = new List<double>();

        //    redemptionTrigger.Add(0.95);
        //    redemptionTrigger.Add(0.95);
        //    redemptionTrigger.Add(0.90);
        //    redemptionTrigger.Add(0.90);
        //    redemptionTrigger.Add(0.85);
        //    redemptionTrigger.Add(0.85);

        //    int averageDays = 1;
        //    List<double> KIs = new List<double>();
        //    KIs.Add(0.55); KIs.Add(0.55);
        //    double cpnYear = 0.09;


        //    string xmlText = InstrumentMakerTool.ELSStepDown(InstName,
        //                                                   notional,
        //                                                  unders,
        //                                                  effectiveDate,
        //                                                  maturityYear,
        //                                                  redemTenorMonth,
        //                                                  redemptionTrigger,
        //                                                  averageDays,
        //                                                  KIs,
        //                                                  cpnYear);


        //    doc.LoadXml(xmlText);

        //    //doc.InnerText = MaketVM_.fileXml();

        //    doc.Save(Path_ + this.FileName_ + ".xml");
        //}

            
    }
}


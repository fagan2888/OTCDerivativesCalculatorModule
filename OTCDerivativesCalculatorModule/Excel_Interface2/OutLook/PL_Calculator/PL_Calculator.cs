using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace Excel_Interface
{
    // 한방에 죄다 로드 하고 join 해서 만든다음에 거기서부터 돌림..
    // 
    public class PL_Calculator
    {
        DateTime refDate_;
        //DateTime preDate_;

        private string connectionStr_ = EnvironmentVariable.MarketDataDBFile_;

        // 평가가격 으로 부터 새로운 ReferenceDate 의 PL 을 만들어냄
        public PL_Calculator()
        { 
        
        }

        public void excute(DateTime refDate)
        {
            this.dataLoad();
            this.doDBInsertJob();

        }

        //List<MasterInformationViewModel> masterInfoList_;
        //List<PL_Data> preDate_pl_dataLIst_;
        List<PL_Data> newDate_pl_dataList_;
        //List<Price_Data> price_dataList_;
        Dictionary<string, List<TradePLEvent>> trade_dataMap_;

        //joint 해서 데이터를 우선 맹글음.
        public void dataLoad()
        {
            bool flag = SystemVariableManager.getFlag(SystemVariable.CALCULATION_BATCH_END_FLAG);

            if (!flag)
            {
                //error를 떨궈야함..
                return;
            }

            // join query
            //SelectQueryBuilder query = new SelectQueryBuilder();
            //query.SelectFromTables("MASTERINFORMATION","POSITION_PL","CALCULATION_PRICE");

            this.newDate_pl_dataList_ = new List<PL_Data>();

            DataTable jointTB = new DataTable();

            DataRow[] resultRows = jointTB.Select();

            foreach (DataRow item in resultRows)
            {
                // trade List에 대한 정의가 필요함
                // 여기서 로드 해서 
                List<TradePLEvent> tradeList = new List<TradePLEvent>();

                PL_Data pre_pl = new PL_Data();

                pre_pl.loadFromDataRow(item);

                newDate_pl_dataList_.Add(
                    this.makePL(pre_pl, this.refDate_, tradeList));
                    
            }

        }

        // pl table 에다가 박음.
        public void doDBInsertJob()
        {

            SqlCeConnection connection = new SqlCeConnection(connectionStr_);

            try
            {

                DataTable tb = new DataTable();

                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                SqlCeCommand delCommand = connection.CreateCommand();
                //delCommand.CommandText = "DELETE FROM CORRELATION WHERE DATE ='" + ReferenceDate_.ToString("yyyy-MM-dd") + "'";
                //delCommand.ExecuteNonQuery();

                //command.CommandText = "DELETE FROM INDEXDATA WHERE NAME=" + name;
                //command.ExecuteNonQuery();

                //string itemCode = QueryStr.wrapComma(this.itemCode_);
                //string name = QueryStr.wrapComma(this.name_);
                //string notional = QueryStr.wrapComma(this.notional_);
                //string type = QueryStr.wrapComma(this.type_);
                //string tradeDate = QueryStr.wrapComma(this.tradeDate_.ToString("yyyyMMdd"));
                //string maturityDate = QueryStr.wrapComma(this.maturityDate_.ToString("yyyyMMdd"));
                //string trade_id = QueryStr.wrapComma(this.tradeID_);
                //string counterParty = QueryStr.wrapComma(this.conterParty_);
                //string export_ItemCode = QueryStr.wrapComma(this.export_ItemCode_);

                //command.CommandText = "INSERT INTO MASTERINFORMATION (ITEM_CODE , ITEM_NAME , NOTIONAL , TYPE, TRADE_DATE , MATURITY_DATE , TRADE_ID , COUNTERPARTY , EXPORT_ITEMCODE ) " +
                //                        " VALUES (" + itemCode + "," +
                //                                    name + "," +
                //                                    notional + "," +
                //                                    type + "," +
                //                                    tradeDate + "," +
                //                                    maturityDate + "," +
                //                                    trade_id + "," +
                //                                    counterParty + "," +
                //                                    export_ItemCode + ")";

                foreach (var item in this.newDate_pl_dataList_)
                {
                    command.ExecuteNonQuery();    
                }

                connection.Close();



            }
            catch (SqlCeException e)
            {
                connection.Close();
                throw;
            }

        }

        // nowPrice : 평가가격
        public PL_Data makePL(PL_Data prePL_Data, DateTime nowDate, List<TradePLEvent> teList)
        {
            PL_Data new_data = new PL_Data(nowDate);

            new_data.calculate(prePL_Data,teList);

            return new_data;

        }

    }
}

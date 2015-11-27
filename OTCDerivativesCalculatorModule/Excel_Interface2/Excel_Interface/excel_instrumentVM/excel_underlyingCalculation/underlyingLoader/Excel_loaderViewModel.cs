using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Excel_Interface
{
    public abstract class Excel_loaderViewModel
    {
        public abstract void loadDefinedSymbolFromDB();
        public abstract Control view();

        

        public static DateTime availableMarketDataDate() 
        {
            // commodity
            // 

            DateTime availableDate = DateTime.Now.AddDays(-1);

            if (availableDate.DayOfWeek == DayOfWeek.Saturday)
            {
                availableDate = availableDate.AddDays(-1);
            }
            else if (availableDate.DayOfWeek == DayOfWeek.Sunday)
            {
                availableDate = availableDate.AddDays(-2);
            }

            return availableDate;

        }

        public static DateTime availableMarketDataDate(DateTime d)
        {
            // commodity
            // 

            DateTime availableDate = d.AddDays(-1);

            if (availableDate.DayOfWeek == DayOfWeek.Saturday)
            {
                availableDate = availableDate.AddDays(-1);
            }
            else if (availableDate.DayOfWeek == DayOfWeek.Sunday)
            {
                availableDate = availableDate.AddDays(-2);
            }

            return availableDate;

        }

        public static string loadMarketData(DateTime refDate, string underType, string code)
        {
            string load = "not loaded";

            if (underType.ToUpper() == "STOCK" || underType.ToUpper() == "EQUITY" || underType.ToUpper() == "EXCEL_STOCKINDEX")
            {
                Excel_equitySymbolViewModel e_esvm = new Excel_equitySymbolViewModel();

                load = e_esvm.dataLoad(refDate, code);

            }
            else if (underType.ToUpper() == "INTERESTRATE" || underType.ToUpper() == "IR" || underType.ToUpper() == "EXCEL_INTERESTRATE")
            {
                Excel_irCurveSymbolViewModel e_ircsvm = new Excel_irCurveSymbolViewModel();

                load = e_ircsvm.dataLoad(refDate, code);

            }
            else if (underType.ToUpper() == "INDEX" || underType.ToUpper() == "EXCEL_INDEXTYPE")
            {
                Excel_indexSymbolViewModel e_isvm = new Excel_indexSymbolViewModel();

                load = e_isvm.dataLoad(refDate, code);

            }
            else
            { 
            
            }

            return load;
        }

        public static string loadMarketData(DateTime refDate, string symbol)
        {
            string load = "not loaded";

            string underType = Excel_marketDataSymbol.underType(symbol);

            Excel_marketDataSymbol e_mds = CreateSymbolViewModel(underType);

            load = e_mds.dataLoad(refDate, symbol);

            return load;
        }

        public static Excel_marketDataSymbol CreateSymbolViewModel(string underType)
        {
            if (underType.ToUpper() == "STOCK" || underType.ToUpper() == "EQUITY")
            {
                Excel_equitySymbolViewModel e_esvm = new Excel_equitySymbolViewModel();

                return e_esvm;
            }
            else if (underType.ToUpper() == "IR" || underType.ToUpper() == "INTERESTRATE")
            {

                Excel_irSymbolViewModel e_irsvm = new Excel_irSymbolViewModel();

                return e_irsvm;
            }
            else if (underType.ToUpper() == "INDEX" || underType.ToUpper() == "INDEX")
            {
                Excel_indexSymbolViewModel e_isvm = new Excel_indexSymbolViewModel();

                return e_isvm;
            }
            else if (underType.ToUpper() == "FX" || underType.ToUpper() == "FXRATE")
            {
                Excel_fxSymbolViewModel e_fsvm = new Excel_fxSymbolViewModel();

                return e_fsvm;
            }

            else
            {
                throw new NotImplementedException();
            }
        }

        public static Excel_underlyingInfoViewModel loadUnderInfo(DateTime refDate, string nameTrans)
        { 
            // nameTrans를 가지고 code를 찾음.

            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.NAME_KOR_ = (nameTrans.Trim()).ToUpper();

            dao.selectNAME_KOR(DataBaseConnectManager.ConnectionFactory("myDB"));

            // 코드를 찾아서 symbol을 로드함.

            // symbol을 통해서 type을 로드함

            // type을 통해서 symbolVM을 만들음
            
            string underType = dao.SYMBOL_TYPE_;

            Excel_marketDataSymbol e_mds = Excel_loaderViewModel.CreateSymbolViewModel(underType);

            e_mds.setFromDAO(dao);

            Excel_underlyingInfoViewModel e_uivm = e_mds.underlyingInfoVM();

            e_uivm.BasePrice_ = e_mds.dataLoad(Excel_loaderViewModel.availableMarketDataDate(refDate), e_mds.Symbol_);

            return e_uivm;
            
        }

        public static Excel_underlyingInfoViewModel loadUnderInfo2(DateTime refDate, string nameTrans)
        {
            // nameTrans를 가지고 code를 찾음.

            try
            {
                MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

                dao.SYMBOL_ = nameTrans.Trim();

                dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                // 코드를 찾아서 symbol을 로드함.

                // symbol을 통해서 type을 로드함

                // type을 통해서 symbolVM을 만들음

                string underType = dao.SYMBOL_TYPE_;

                if (underType == null)
                {
                    throw new Exception("symbol doesn't exist in symbolList : " + dao.SYMBOL_);
                }

                Excel_marketDataSymbol e_mds = Excel_loaderViewModel.CreateSymbolViewModel(underType);

                e_mds.setFromDAO(dao);

                Excel_underlyingInfoViewModel e_uivm = e_mds.underlyingInfoVM();

                e_uivm.BasePrice_ = e_mds.dataLoad(Excel_loaderViewModel.availableMarketDataDate(refDate), e_mds.Symbol_);

                return e_uivm;
            }
            catch (Exception)
            {
                throw;
            }
            

            

        }

        public static Excel_underlyingInfoViewModel loadUnderInfoWithoutBasePrice(string underSymbol)
        {
            // nameTrans를 가지고 code를 찾음.

            try
            {
                MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

                dao.SYMBOL_ = underSymbol.Trim();

                dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                // 코드를 찾아서 symbol을 로드함.

                // symbol을 통해서 type을 로드함

                // type을 통해서 symbolVM을 만들음

                string underType = dao.SYMBOL_TYPE_;

                if (underType == null)
                {
                    throw new Exception("symbol doesn't exist in symbolList : " + dao.SYMBOL_);
                }

                Excel_marketDataSymbol e_mds = Excel_loaderViewModel.CreateSymbolViewModel(underType);

                e_mds.setFromDAO(dao);

                Excel_underlyingInfoViewModel e_uivm = e_mds.underlyingInfoVM();

                return e_uivm;
            }
            catch (Exception)
            {
                throw;
            }




        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;
using System.Runtime.InteropServices;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Underlying
    {

        public Underlying()
        { 
        
        }

        private string infoParsing(string str, InfoType infoType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (infoType == InfoType.Header)
                {
                    string[] split = str.Split(';');

                    foreach (var item in split)
                    {
                        int equalCount = item.IndexOf('=');

                        if (item != "")
                        {
                            sb.Append(item.Substring(0, equalCount) + ";");
                        }

                    }

                }
                else if (infoType == InfoType.Value)
                {
                    string[] split = str.Split(';');

                    foreach (var item in split)
                    {
                        int equalCount = item.IndexOf('=');

                        if (item != "")
                        {

                            sb.Append(item.Substring(equalCount + 1, item.Length - (equalCount + 1)) + ";");
                        }

                    }
                }
                else if (infoType == InfoType.Header_Value)
                {
                    sb.Append(str);
                }
                else
                {

                }

                return sb.ToString();

            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        //public string underlyingList()
        //{
        //    try
        //    {
        //        return "set complete";
        //    }
        //    catch (Exception e)
        //    {
        //        return "add fail : " + e.Message;
        //    }
        //}

        //public string get_definedUnderlyingList()
        //{
        //    try
        //    {
        //        return "set complete";
        //    }
        //    catch (Exception e)
        //    {
        //        return "add fail : " + e.Message;
        //    }
        //}

        public string get_whole_underlying(InfoType infoType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                List<Excel_marketDataSymbol> e_mdsList = Excel_marketDataSymbol.getDefinedSymbolALL();

                foreach (var item in e_mdsList)
                {
                    sb.Append(this.infoParsing(item.vba_desciption(), infoType) + "\n");
                }

                return sb.ToString();
            }
            catch (Exception e)
            {
                return "whole underlying load fail : " + e.Message;
            }
        }

        public string find_underlying(string filter, InfoType infoType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                List<Excel_marketDataSymbol> e_mdsList = Excel_marketDataSymbol.getDefinedSymbolFiltering(filter);

                foreach (var item in e_mdsList )
	            {
                    sb.Append(this.infoParsing(item.vba_desciption(), infoType) + ";");
	            }

                //return "fild complete : " + e_mdsList.Count;
                return sb.ToString();
            }
            catch (Exception e)
            {
                return "fild fail : " + e.Message;
            }
        }

        public string get_underlyingInfo(string code, InfoType infoType)
        {
            try
            {
                Excel_marketDataSymbol e_mds = Excel_marketDataSymbol.getDefinedSymbol(code);

                Excel_underlyingInfoViewModel e_uivm = e_mds.underlyingInfoVM();

                string vba_desc = e_uivm.vba_desciption();

                return this.infoParsing(vba_desc, infoType);

            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        public string get_symbol_info(string code, InfoType infoType)
        {
            try
            {
                Excel_marketDataSymbol e_mds = Excel_marketDataSymbol.getDefinedSymbol(code);

                string vba_desc = e_mds.vba_desciption();

                return this.infoParsing(vba_desc, infoType);

            }
            catch (Exception e)
            {
                string errStr = "get schdule info fail: " + e.Message;

                return errStr;
            }
        }

        public string get_quote(DateTime refDate,string code)
        {
            try
            {
                //Excel_underlyingInfoViewModel e = Excel_loaderViewModel.loadUnderInfoWithoutBasePrice(code

                return Excel_loaderViewModel.loadMarketData(refDate, code);
            }
            catch (Exception e)
            {
                return "get quote fail : " + e.Message;
            }
        }

        public string get_quoteHistory(string code, DateTime startDate,DateTime endDate)
        {
            try
            {
                return "not implemented";
            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        public class UnitTest
        {
            private Underlying testClass_;

            public UnitTest() 
            {
                this.testClass_ = new Underlying();
            }

            public string test_find_underlying()
            {
                this.testClass_.find_underlying("",InfoType.Header_Value);
                this.testClass_.find_underlying("",InfoType.Header);
                this.testClass_.find_underlying("",InfoType.Value);

                return "";
            }


        }

//Debug.Print underlying.find_underlying(Filter, InfoType) ' 여러개 떨어짐 List로 ';'구분
//Debug.Print underlying.get_underlyingInfo(code, InfoType) '
//Debug.Print underlying.get_symbol_info(code, InfoType)
//Debug.Print underlying.get_quote(code, rDate) ' base price자리에 박음
//Debug.Print underlying.get_quoteHistory(code, startDate, endDate) ' base price자리에 박음
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Excel_Interface
{
    public class MarketDataLoader
    {

        public MarketDataLoader()
        { 
        }

        public double loadData(string code, DateTime refDate)
        {
            INDEX_DATA_Table_DAO dao = new INDEX_DATA_Table_DAO();
            
            dao.INDEX_DATE_ = refDate.ToString(StringFormat.DbDateFormat_);
            dao.INDEX_CODE_ = code;

            double result = 0.0;

            try
            {
                dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("index data load error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));
            }

            try
            {
                result = Convert.ToDouble(dao.INDEX_VALUE_);
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("data converting error , code : " + code + " date : " + refDate.ToString(StringFormat.DbDateFormat_));    
            }

            return result;
        }
        
    }
}

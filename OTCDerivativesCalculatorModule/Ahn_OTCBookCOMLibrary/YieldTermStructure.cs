using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Excel_Interface;
using System.Runtime.InteropServices;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class YieldTermStructure
    {
        //private QLNet.YieldTermStructure ql_yieldTS_;

        [ComVisible(false)]
        public Excel_yieldCurveViewModel Excel_yieldCurveViewModel_ { get; set;}

        public YieldTermStructure()
        {
            this.Excel_yieldCurveViewModel_ = new Excel_yieldCurveViewModel();
        }

        public string set_vender(string curveCode, string id, string pw)
        {
            try
            {

                return "set complete";
            }
            catch (Exception e)
            {
                return "set fail : " + e.Message;
            }
        }

        public string load(string curveCode, DateTime refDate,string venderName="local")
        {
            try
            {
                //CURVE_DATA_Table_DAO dao = new CURVE_DATA_Table_DAO();

                //dao.CURVE_DATE_ = StringConverter.dbDateTimeToDateString(refDate);
                //dao.CURVE_CODE_ = curveCode;

                //dao.selectDateCurve(DataBaseConnectManager.ConnectionFactory("myDB"));

                IRCurveMarketDataLoader loader = IRCurveMarketDataLoader.CreateMarketDataLoader(venderName);
                
                ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

                loader.load(refDate, curveCode, e_ircdvmList);

                if (e_ircdvmList.Count == 1)
                {
                    this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_
                        = e_ircdvmList[0].Excel_rateDataViewModelList_;
                }
                else if (e_ircdvmList.Count == 0)
                {
                    return "curve doesn't exist code : " + curveCode + " refDate : " + refDate.ToString(StringFormat.DbDateFormat_);
                }
                else
                {
                    return "too many curve exist : " + curveCode + " refDate : " + refDate.ToString(StringFormat.DbDateFormat_);
                }

                return "load complete";
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }

        public string save(string curveCode, DateTime refDate, string venderName = "local")
        {
            try
            {

                //Excel_irCurveLoaderViewModel e_irCurveLoader = new Excel_irCurveLoaderViewModel();

                //e_irCurveLoader.loadDefinedSymbolFromDB();

                //e_irCurveLoader.

                CURVE_DATA_Table_DAO dao = new CURVE_DATA_Table_DAO();

                dao.CURVE_DATE_= StringConverter.dbDateTimeToDateString(refDate);
                dao.CURVE_CODE_ = curveCode;
                
                foreach (var item in this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_)
                {
                    dao.TENOR_ = item.Tenor_;
                    dao.VALUE_ = item.Value_;
                    dao.CURVE_TYPE_ = item.RateType_;

                    dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
                }

                return "save complete";
            }
            catch (Exception e)
            {
                return "save fail : " + e.Message + " , " + e.Source;
            }
        }

        public string remove_Curve(string curveCode, string venderName = "local")
        {
            try
            {
                CURVE_DATA_Table_DAO dao = new CURVE_DATA_Table_DAO();

                dao.CURVE_CODE_ = curveCode;

                dao.deleteCode(DataBaseConnectManager.ConnectionFactory("myDB"));

                return "delete complete";
            }
            catch (Exception e)
            {
                return "delete fail : " + e.Message + " , " + e.Source;
            }
        }

        public string curveInfo()
        {
            try
            {
                return this.Excel_yieldCurveViewModel_.curveInfo();
            }
            catch (Exception e)
            {
                return "curveInfo fail : " + e.Message;
            }
        }

        public string set_interpolation(InterpolationEnum interpolation)
        {
            try
            {
                this.Excel_yieldCurveViewModel_.Excel_interpolationViewModel_
                    = new Excel_interpolationViewModel();

                return "load complete";
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }

        public string add_Rate(string tenor, double rate, RateTypeEnum rateType = RateTypeEnum.Spot)
        {
            try
            {
                #region CheckParameter

                // 이건 나중에 수정해야함. yield 음수의 경우 yieldcurve class 를 새로 만들어야함. quantlib을 사용안해야함.
                if ( !(rate > 0) )
                    throw new Exception("rate must be positive");

                #endregion

                if ( this.Excel_yieldCurveViewModel_.hasTenor(tenor) )
                {
                    return tenor + " is aleady exist";
                }
                else
                {
                    Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                    e_rdvm.RateType_ = rateType.ToString();
                    e_rdvm.Tenor_ = tenor;
                    e_rdvm.Value_ = rate.ToString();

                    this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_.Add(e_rdvm);

                    return "add complete";
                }
                
            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        public string remove_Rate(string tenor="ALL")
        {
            try
            {
                if (tenor.ToUpper() == "ALL")
                {
                    this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_.Clear();
                }
                else
                {

                    foreach (var item in this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_)
                    {
                        if (item.Tenor_.ToUpper() == tenor)
                        {
                            this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_.Remove(item);

                            return "remove complete";
                        }
                    }
                    
                }

                return tenor + " does not exist";
            }
            catch (Exception e)
            {
                return "remove fail : " + e.Message;
            }
        }

        public string get_curveRateData(string tenor = "")
        {
            try
            {
                foreach (var item in this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_)
                {
                    if (item.Tenor_.ToUpper() == tenor)
                    {
                        this.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_.Remove(item);

                        return item.Value_;
                    }
                }

                return tenor + " does not exist";
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }

        public string get_spotRate(DateTime d)
        {
            try
            {


                return "load complete";

            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }

        public string get_discountRate(DateTime d)
        {
            try
            {
                return "load complete";
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }

        public string get_curveList(string venderName = "local")
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                Excel_irCurveLoaderViewModel e_irCurveLoader = new Excel_irCurveLoaderViewModel();
                
                e_irCurveLoader.loadDefinedSymbolFromDB();

                foreach (var item in e_irCurveLoader.DefinedIRCurveSymbolList_)
                {
                    sb.Append(item.Symbol_);
                }

                return "load complete";
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }



    }
}

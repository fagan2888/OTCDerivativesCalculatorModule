using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class MRO_IRCurveMarketDataLoader : IRCurveMarketDataLoader
    {
        public MRO_IRCurveMarketDataLoader(string dbName)
        : base(DataBaseConnectManager.ConnectionFactory(dbName))
        {
            
        }

        public override void load(DateTime refDate, string curveCode, ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList)
        {
            TD_MRCURVE_Table_DAO dao = new TD_MRCURVE_Table_DAO();

            e_ircdvmList.Clear();

            dao.KeyColumn_RefDate_ = refDate.ToString(StringFormat.DbDateFormat_);
            dao.KeyColumn_BOND_CLASS_ID_ = curveCode;
            dao.KeyColumn_CURVE_CODE_ = "S";

            dao.select(this.conn_);

            Excel_irCurveDataViewModel e_ircdvm = new Excel_irCurveDataViewModel();

            e_ircdvm.Curve_code_ = curveCode;
            e_ircdvm.ReferenceDate_ = refDate;

            List<string> tenorList = new List<string>()
            {
                "1D",
                "3M",
                "6M",
                "9M",
                "12M",
                "18M",
                "24M",
                "30M",
                "36M",
                "48M",
                "60M",
                "84M",
                "120M",
                "180M",
                "240M",
                "360M"
            };

            List<string> valueList = new List<string>()
            {
                dao.D001_,
                dao.M003_,
                dao.M006_,
                dao.M009_,
                dao.M012_,
                dao.M018_,
                dao.M024_,
                dao.M030_,
                dao.M036_,
                dao.M048_,
                dao.M060_,
                dao.M084_,
                dao.M120_,
                dao.M180_,
                dao.M240_,
                dao.M360_

            };

            for (int i = 0; i < tenorList.Count; i++)
            {
                Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                e_rdvm.Tenor_ = tenorList[i];

                double value = Convert.ToDouble(valueList[i]) / 100.0;
                e_rdvm.Value_ = value.ToString();

                e_rdvm.RateType_ = "spot";

                if (value > 0.0)
                {
                    e_ircdvm.Excel_rateDataViewModelList_.Add(e_rdvm);
                }

            }

            e_ircdvm.tenorList_ = tenorList;

            if (e_ircdvm.Excel_rateDataViewModelList_.Count > 0)
            {
                e_ircdvmList.Add(e_ircdvm);
            }
            else
            {
                throw new Exception("curve load error , STD_DATE : " + dao.KeyColumn_RefDate_ + 
                                                      " BOND_CLASS_ID : " + dao.KeyColumn_BOND_CLASS_ID_);
            }

        }

        public override void loadInterval(DateTime startDate, DateTime endDate, string curveCode, ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList)
        {
            TD_MRCURVE_Table_DAOManager daoM = new TD_MRCURVE_Table_DAOManager();

            e_ircdvmList.Clear();

            daoM.KeyColumn_InitialDate_ = startDate.ToString(StringFormat.DbDateFormat_);
            daoM.KeyColumn_EndDate_ = endDate.ToString(StringFormat.DbDateFormat_);

            daoM.KeyColumn_BOND_CLASS_ID_ = curveCode;
            daoM.KeyColumn_CURVE_CODE_ = "S";

            daoM.selectInterval(this.conn_);

            List<string> tenorList = new List<string>()
            {
                "1D",
                "3M",
                "6M",
                "9M",
                "12M",
                "18M",
                "24M",
                "30M",
                "36M",
                "48M",
                "60M",
                "84M",
                "120M",
                "180M",
                "240M",
                "360M"
            };


            for (int i = 0; i < daoM.DAOList_.Count; i++)
			{
			    Excel_irCurveDataViewModel e_ircdvm = new Excel_irCurveDataViewModel();

                TD_MRCURVE_Table_DAO dao = daoM.DAOList_[i];

                e_ircdvm.Curve_code_ = dao.CURVE_CODE_;
                e_ircdvm.ReferenceDate_ = StringConverter.dbDateToDateTime(dao.STD_DATE_);

                List<string> valueList = new List<string>()
                {
                    dao.D001_,
                    dao.M003_,
                    dao.M006_,
                    dao.M009_,
                    dao.M012_,
                    dao.M018_,
                    dao.M024_,
                    dao.M030_,
                    dao.M036_,
                    dao.M048_,
                    dao.M060_,
                    dao.M084_,
                    dao.M120_,
                    dao.M180_,
                    dao.M240_,
                    dao.M360_

                };

                for (int j = 0; j < tenorList.Count; j++)
                {
                    Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                    e_rdvm.Tenor_ = tenorList[j];
                    double value = Convert.ToDouble(valueList[j]) / 100.0;

                    e_rdvm.Value_ = value.ToString();

                    e_rdvm.RateType_ = "spot";

                    if (value > 0.0)
                    { 
                        e_ircdvm.Excel_rateDataViewModelList_.Add(e_rdvm);
                    }

                }

                e_ircdvmList.Add(e_ircdvm);

			}

            e_ircdvmList[0].tenorList_ = tenorList;

        }

        
    }
}

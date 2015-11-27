using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Excel_Interface
{
    public class CurveManager
    {
        public enum CurveType
        {
            Yield
        };

        public CurveManager()
        {
            this.curveType_ = CurveType.Yield;
        }

        private CurveType curveType_;
        public List<string> Tenor_ { get; set; }
        public List<string> Data_ { get; set; }

        public void load(string curveID,DateTime d)
        {
            this.Tenor_ = new List<string>();
            this.Data_ = new List<string>();

            CURVETENOR_INFO_Table_DAO tenor_dao = new CURVETENOR_INFO_Table_DAO();

            tenor_dao.CURVE_CODE_ = curveID;

            tenor_dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            string[] tenor_info = tenor_dao.TENORLIST_.Split(';');

            CURVE_DATA_Table_DAO dao = new CURVE_DATA_Table_DAO();

            dao.CURVE_CODE_ = curveID;
            dao.CURVE_DATE_ = d.ToString(StringFormat.DbDateFormat_);

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            int maxLenth = Math.Min(15,tenor_info.Length);

            for (int i = 0; i < maxLenth; i++)
			{
			    this.Tenor_.Add(tenor_info[i]);
                //this.Data_.Add(dao.DataList_[i]);
			}

        }

        public QLNet.YieldTermStructure yieldTSBuild()
        {
            //QLNet.YieldTermStructure ts = new QLNet.YieldTermStructure();

            List<QLNet.Date> dates = new List<QLNet.Date>();
            List<double> yields = new List<double>();

            //ProgramVariable.ReferenceDate_.AddMonths();

            foreach (var item in this.Tenor_)
            {
                int len = item.Length;

                string periodMultiplier = item.Substring(0, len - 1);
                string period = item.Substring(len - 1, 1);

                if (periodMultiplier == "D")
                {
                    int addDays = Convert.ToInt32(period);
                    dates.Add(ProgramVariable.ReferenceDate_.AddDays(addDays));
                }
                else if (periodMultiplier == "M")
                {
                    int addMonths = Convert.ToInt32(period);
                    dates.Add(ProgramVariable.ReferenceDate_.AddMonths(addMonths));
                }
                else
                {
                    throw new Exception("unknown type tenor : " + item);
                }
            }

            foreach (var item in this.Data_)
            {
                yields.Add(Convert.ToDouble(item));
            }

            QLNet.DayCounter dc = new QLNet.Actual365Fixed();

            QLNet.InterpolatedZeroCurve<QLNet.Linear> curve = new QLNet.InterpolatedZeroCurve<QLNet.Linear>(
                dates, yields, dc, new QLNet.Linear());

            return curve;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolCalculator
{
    public class HistoryVolCalculator
    {
        public List<double> StockValueList_ { get; set; }

        public DateTime StartDate_ { get; set; }
        public DateTime EndDate_ { get; set; }

        public double VOL_ { get; set; }

        public HistoryVolCalculator()
        {
            this.StockValueList_ = new List<double>();
            this.StockValueList_.Add(0.25);
            this.StockValueList_.Add(0.28);
            this.StockValueList_.Add(0.29);

        }

        public void historyCalVol()
        {
            double sum = 0.0;

            foreach (var item in StockValueList_)
	        {
                sum += item;
	        }

            sum = sum / (double)StockValueList_.Count;

            this.VOL_ = sum;

        }
    }
}

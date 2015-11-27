using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RiskMonitor
{
    public class HistoryVolCalculator : VolCalculator
    {
        public HistoryVolCalculator()
        {
            this.ValueList_ = new List<double>();
        }

        public void historyCalVol()
        {
            this.convertReturn();

            double sum = 0.0;
            double squerSum = 0.0;
            double sampleNum = (double)ReturnValueList_.Count;
            double degreeNum = (double)ReturnValueList_.Count - 1;
            
            //foreach (var item in ReturnValueList_)
            for (int i = 0; i < ReturnValueList_.Count; i++)
            {
                double x = ReturnValueList_[i];
                sum += x;
                squerSum += x * x;
            }

            //sum = sum / (double)ValueList_.Count;
            double variance = squerSum / degreeNum - (sum / degreeNum) * (sum / degreeNum);
            this.VOL_ = Math.Sqrt(sampleNum * variance);

        }

        private void convertReturn()
        {
            ReturnValueList_ = new List<double>(ValueList_.Count - 1);
            
            for (int i = 0; i < ValueList_.Count - 1; i++)
			{
                ReturnValueList_.Add(Math.Log(ValueList_[i + 1] / ValueList_[i]));
			}
            
        }
    }
}

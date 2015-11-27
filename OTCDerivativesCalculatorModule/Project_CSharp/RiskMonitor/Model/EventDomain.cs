using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class EventDomain
    {

        private List<double> upper_;
        private List<double> lower_;

        public int Size_ { get; set; }

        public EventDomain() 
        {
        
        }

        public EventDomain(List<double> upper,
                           List<double> lower) 
        {
            this.upper_ = upper;
            this.lower_ = lower;

            Size_ = upper_.Count;
        }

        public bool eventOcc(List<double> values) 
        {
            bool occ = false;

            for (int i = 0; i < Size_; i++)
            {
                double value = values[i];

                if (value < upper_[i] && lower_[i] < value)
                {
                    occ = occ && true;
                }
            }

            return occ;
            
        }


    }
}

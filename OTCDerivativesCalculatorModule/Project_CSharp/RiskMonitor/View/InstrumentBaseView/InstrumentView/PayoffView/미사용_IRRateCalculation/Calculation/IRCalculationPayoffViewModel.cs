using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class IRCalculationPayoffViewModel : PayoffInfoViewModel
    {
        #region EffectiveDate_
        private DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion

        #region TerminationDate_
        private DateTime terminationDate_;
        public DateTime TerminationDate_
        {
            get { return this.terminationDate_; }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                    this.NotifyPropertyChanged("TerminationDate_");
                }
            }
        }
        #endregion

        public QLNet.Period Period_ { get; set; }
        public QLNet.BusinessDayConvention Conv_ { get; set; }
        public QLNet.DateGeneration.Rule DateGenRule_ { get; set; }

        public List<DateTime> PayoffDates_ { get; set; }

        public bool InArrear_ { get; set; }

        // CalculationPeriodFrequency Setting

        public List<ICoupon> CouponStream_ { get; set; }

        public QLNet.DayCounter DayCounter_ { get; set; }
        public QLNet.Calendar Calendar_ { get; set; }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion


        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            // Parameter로 넘길때 만 build 해서 사용함.
            QLNet.Schedule schedule = new QLNet.Schedule(new QLNet.Date(EffectiveDate_),
                                                         new QLNet.Date(TerminationDate_),
                                                         Period_,
                                                         Calendar_,
                                                         Conv_,
                                                         Conv_,
                                                         DateGenRule_,
                                                         false);
        }

        public override void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

    }
}

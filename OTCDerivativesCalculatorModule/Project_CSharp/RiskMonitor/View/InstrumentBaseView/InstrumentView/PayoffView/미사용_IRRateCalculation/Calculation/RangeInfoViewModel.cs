using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class RangeInfoViewModel : IXmlData
    {
        #region Low_
        private double low_;
        public double Low_
        {
            get { return this.low_; }
            set
            {
                if (this.low_ != value)
                {
                    this.low_ = value;
                    this.NotifyPropertyChanged("Low_");
                }
            }
        }
        #endregion

        #region High_
        private double high_;
        public double High_
        {
            get { return this.high_; }
            set
            {
                if (this.high_ != value)
                {
                    this.high_ = value;
                    this.NotifyPropertyChanged("High_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class IRIndexUnderViewModel : IndexUnderViewModel
    {
        
        #region Period_
        private string period_;
        public string Period_
        {
            get { return this.period_; }
            set
            {
                if (this.period_ != value)
                {
                    this.period_ = value;
                    this.NotifyPropertyChanged("Period_");
                }
            }
        }
        #endregion

        // swap , spot , zero 머 이런거 ?

        #region IRType_
        private string irType_;
        public string IRType_
        {
            get { return this.irType_; }
            set
            {
                if (this.irType_ != value)
                {
                    this.irType_ = value;
                    this.NotifyPropertyChanged("IRType_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
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

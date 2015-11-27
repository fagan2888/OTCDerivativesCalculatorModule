using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class IndexUnderViewModel : IXmlData
    {
        #region KRCode_
        protected string krCode_;
        public string KRCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KRCode_");
                }
            }
        }
        #endregion        

        #region Name_
        protected string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region BasePrice_
        protected string basePrice_;
        public string BasePrice_
        {
            get { return this.basePrice_; }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                    this.NotifyPropertyChanged("BasePrice_");
                }
            }
        }
        #endregion

        #region Type_
        protected string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode InstNode);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

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

        public static IndexUnderViewModel CreateIndexUnder(string indexType)
        {
            if (indexType == "stockIndex")
            {
                return new StockIndexUnderViewModel();
            }
            else if (indexType == "interestRate")
            {
                return new IRIndexUnderViewModel();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static IndexUnderViewModel CreateIndexUnder(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Index serial_underIndex = serial_Class as FpmlSerializedCSharp.Index;

            string indexType = serial_underIndex.Type_.ValueStr;

            return IndexUnderViewModel.CreateIndexUnder(indexType);
        }
    }
}

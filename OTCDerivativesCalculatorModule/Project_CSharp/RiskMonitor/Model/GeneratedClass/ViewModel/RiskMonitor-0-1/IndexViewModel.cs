using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class IndexViewModel : IXmlData
    {
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
        
        public IndexViewModel() { }
        
        #region Type_
        private string type_;
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
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion
        
        #region Name_
        private string name_;
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
        private string basePrice_;
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
        
        #region InterestRateIndexViewModel_
        private InterestRateIndexViewModel interestRateIndexViewModel_;
        public InterestRateIndexViewModel InterestRateIndexViewModel_
        {
            get { return this.interestRateIndexViewModel_; }
            set
            {
                if (this.interestRateIndexViewModel_ != value)
                {
                    this.interestRateIndexViewModel_ = value;
                    this.NotifyPropertyChanged("InterestRateIndexViewModel_");
                }
            }
        }
        #endregion
        
        #region StockIndexViewModel_
        private StockIndexViewModel stockIndexViewModel_;
        public StockIndexViewModel StockIndexViewModel_
        {
            get { return this.stockIndexViewModel_; }
            set
            {
                if (this.stockIndexViewModel_ != value)
                {
                    this.stockIndexViewModel_ = value;
                    this.NotifyPropertyChanged("StockIndexViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_indexType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static IndexViewModel CreateIndex(string typeStr)
        {
            if ( typeStr == "interestRateIndex")
            {
                return new InterestRateIndexViewModel();
            }
            else if ( typeStr == "stockIndex")
            {
                return new StockIndexViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


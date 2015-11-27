using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_underlyingInfoViewModel : IXmlData
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
        
        public Excel_underlyingInfoViewModel() { }
        
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
        #region Excel_stockIndexViewModel_
        private Excel_stockIndexViewModel excel_stockIndexViewModel_;
        public Excel_stockIndexViewModel Excel_stockIndexViewModel_
        {
            get { return this.excel_stockIndexViewModel_; }
            set
            {
                if (this.excel_stockIndexViewModel_ != value)
                {
                    this.excel_stockIndexViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_stockIndexViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_interestRateViewModel_
        private Excel_interestRateViewModel excel_interestRateViewModel_;
        public Excel_interestRateViewModel Excel_interestRateViewModel_
        {
            get { return this.excel_interestRateViewModel_; }
            set
            {
                if (this.excel_interestRateViewModel_ != value)
                {
                    this.excel_interestRateViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interestRateViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_underlyingInfoViewModel CreateExcel_underlyingInfo(string typeStr)
        {
            if ( typeStr == "excel_stockIndex")
            {
                return new Excel_stockIndexViewModel();
            }
            else if ( typeStr == "excel_interestRate")
            {
                return new Excel_interestRateViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


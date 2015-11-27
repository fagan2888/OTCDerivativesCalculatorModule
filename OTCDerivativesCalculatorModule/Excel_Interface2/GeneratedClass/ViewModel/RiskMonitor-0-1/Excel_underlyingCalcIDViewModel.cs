using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_underlyingCalcIDViewModel : IXmlData
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
        
        public Excel_underlyingCalcIDViewModel() { }
        
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
        
        #region CalcID_
        private string calcID_;
        public string CalcID_
        {
            get { return this.calcID_; }
            set
            {
                if (this.calcID_ != value)
                {
                    this.calcID_ = value;
                    this.NotifyPropertyChanged("CalcID_");
                }
            }
        }
        #endregion
        
        #region Excel_choiceUnderlyingCalcIDViewModel_
        private Excel_choiceUnderlyingCalcIDViewModel excel_choiceUnderlyingCalcIDViewModel_;
        public Excel_choiceUnderlyingCalcIDViewModel Excel_choiceUnderlyingCalcIDViewModel_
        {
            get { return this.excel_choiceUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_choiceUnderlyingCalcIDViewModel_ != value)
                {
                    this.excel_choiceUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_choiceUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_maximumUnderlyingCalcIDViewModel_
        private Excel_maximumUnderlyingCalcIDViewModel excel_maximumUnderlyingCalcIDViewModel_;
        public Excel_maximumUnderlyingCalcIDViewModel Excel_maximumUnderlyingCalcIDViewModel_
        {
            get { return this.excel_maximumUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_maximumUnderlyingCalcIDViewModel_ != value)
                {
                    this.excel_maximumUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_maximumUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_minimumUnderlyingCalcIDViewModel_
        private Excel_minimumUnderlyingCalcIDViewModel excel_minimumUnderlyingCalcIDViewModel_;
        public Excel_minimumUnderlyingCalcIDViewModel Excel_minimumUnderlyingCalcIDViewModel_
        {
            get { return this.excel_minimumUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_minimumUnderlyingCalcIDViewModel_ != value)
                {
                    this.excel_minimumUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_minimumUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_averageUnderlyingCalcIDViewModel_
        private Excel_averageUnderlyingCalcIDViewModel excel_averageUnderlyingCalcIDViewModel_;
        public Excel_averageUnderlyingCalcIDViewModel Excel_averageUnderlyingCalcIDViewModel_
        {
            get { return this.excel_averageUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_averageUnderlyingCalcIDViewModel_ != value)
                {
                    this.excel_averageUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_averageUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_orderUnderlyingCalcIDViewModel_
        private Excel_orderUnderlyingCalcIDViewModel excel_orderUnderlyingCalcIDViewModel_;
        public Excel_orderUnderlyingCalcIDViewModel Excel_orderUnderlyingCalcIDViewModel_
        {
            get { return this.excel_orderUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_orderUnderlyingCalcIDViewModel_ != value)
                {
                    this.excel_orderUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_orderUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_underlyingCalcIDViewModel CreateExcel_underlyingCalcID(string typeStr)
        {
            if ( typeStr == "excel_choiceUnderlyingCalcID")
            {
                return new Excel_choiceUnderlyingCalcIDViewModel();
            }
            else if ( typeStr == "excel_maximumUnderlyingCalcID")
            {
                return new Excel_maximumUnderlyingCalcIDViewModel();
            }
            else if ( typeStr == "excel_minimumUnderlyingCalcID")
            {
                return new Excel_minimumUnderlyingCalcIDViewModel();
            }
            else if ( typeStr == "excel_averageUnderlyingCalcID")
            {
                return new Excel_averageUnderlyingCalcIDViewModel();
            }
            else if ( typeStr == "excel_orderUnderlyingCalcID")
            {
                return new Excel_orderUnderlyingCalcIDViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


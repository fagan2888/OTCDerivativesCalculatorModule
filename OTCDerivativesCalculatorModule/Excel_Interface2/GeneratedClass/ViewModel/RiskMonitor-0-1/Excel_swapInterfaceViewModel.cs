using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_swapInterfaceViewModel : IXmlData
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
        
        public Excel_swapInterfaceViewModel() { }
        
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
        
        #region Excel_irsViewModel_
        private Excel_irsViewModel excel_irsViewModel_;
        public Excel_irsViewModel Excel_irsViewModel_
        {
            get { return this.excel_irsViewModel_; }
            set
            {
                if (this.excel_irsViewModel_ != value)
                {
                    this.excel_irsViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_irsViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_crsViewModel_
        private Excel_crsViewModel excel_crsViewModel_;
        public Excel_crsViewModel Excel_crsViewModel_
        {
            get { return this.excel_crsViewModel_; }
            set
            {
                if (this.excel_crsViewModel_ != value)
                {
                    this.excel_crsViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_crsViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_cdsViewModel_
        private Excel_cdsViewModel excel_cdsViewModel_;
        public Excel_cdsViewModel Excel_cdsViewModel_
        {
            get { return this.excel_cdsViewModel_; }
            set
            {
                if (this.excel_cdsViewModel_ != value)
                {
                    this.excel_cdsViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_cdsViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_structuredSwapViewModel_
        private Excel_structuredSwapViewModel excel_structuredSwapViewModel_;
        public Excel_structuredSwapViewModel Excel_structuredSwapViewModel_
        {
            get { return this.excel_structuredSwapViewModel_; }
            set
            {
                if (this.excel_structuredSwapViewModel_ != value)
                {
                    this.excel_structuredSwapViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_structuredSwapViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_swapInterfaceViewModel CreateExcel_swapInterface(string typeStr)
        {
            if ( typeStr == "excel_irs")
            {
                return new Excel_irsViewModel();
            }
            else if ( typeStr == "excel_crs")
            {
                return new Excel_crsViewModel();
            }
            else if ( typeStr == "excel_cds")
            {
                return new Excel_cdsViewModel();
            }
            else if ( typeStr == "excel_structuredSwap")
            {
                return new Excel_structuredSwapViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


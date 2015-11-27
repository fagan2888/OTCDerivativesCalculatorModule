using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_issueInfoViewModel : IXmlData
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
        
        public Excel_issueInfoViewModel() { }
        
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
        
        #region Excel_noteInfoViewModel_
        private Excel_noteInfoViewModel excel_noteInfoViewModel_;
        public Excel_noteInfoViewModel Excel_noteInfoViewModel_
        {
            get { return this.excel_noteInfoViewModel_; }
            set
            {
                if (this.excel_noteInfoViewModel_ != value)
                {
                    this.excel_noteInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_noteInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_swapInfoViewModel_
        private Excel_swapInfoViewModel excel_swapInfoViewModel_;
        public Excel_swapInfoViewModel Excel_swapInfoViewModel_
        {
            get { return this.excel_swapInfoViewModel_; }
            set
            {
                if (this.excel_swapInfoViewModel_ != value)
                {
                    this.excel_swapInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_swapLegInfoViewModel_
        private Excel_swapLegInfoViewModel excel_swapLegInfoViewModel_;
        public Excel_swapLegInfoViewModel Excel_swapLegInfoViewModel_
        {
            get { return this.excel_swapLegInfoViewModel_; }
            set
            {
                if (this.excel_swapLegInfoViewModel_ != value)
                {
                    this.excel_swapLegInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapLegInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_emptyInfoViewModel_
        private Excel_emptyInfoViewModel excel_emptyInfoViewModel_;
        public Excel_emptyInfoViewModel Excel_emptyInfoViewModel_
        {
            get { return this.excel_emptyInfoViewModel_; }
            set
            {
                if (this.excel_emptyInfoViewModel_ != value)
                {
                    this.excel_emptyInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_emptyInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_issueInfoViewModel CreateExcel_issueInfo(string typeStr)
        {
            if ( typeStr == "excel_noteInfo")
            {
                return new Excel_noteInfoViewModel();
            }
            else if ( typeStr == "excel_swapInfo")
            {
                return new Excel_swapInfoViewModel();
            }
            else if ( typeStr == "excel_swapLegInfo")
            {
                return new Excel_swapLegInfoViewModel();
            }
            else if ( typeStr == "excel_emptyInfo")
            {
                return new Excel_emptyInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


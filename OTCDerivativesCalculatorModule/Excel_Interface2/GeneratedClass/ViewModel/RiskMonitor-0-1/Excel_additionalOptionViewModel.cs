using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_additionalOptionViewModel : IXmlData
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
        
        public Excel_additionalOptionViewModel() { }
        
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
        
        #region Excel_noneOptionViewModel_
        private Excel_noneOptionViewModel excel_noneOptionViewModel_;
        public Excel_noneOptionViewModel Excel_noneOptionViewModel_
        {
            get { return this.excel_noneOptionViewModel_; }
            set
            {
                if (this.excel_noneOptionViewModel_ != value)
                {
                    this.excel_noneOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_noneOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_callableOptionViewModel_
        private Excel_callableOptionViewModel excel_callableOptionViewModel_;
        public Excel_callableOptionViewModel Excel_callableOptionViewModel_
        {
            get { return this.excel_callableOptionViewModel_; }
            set
            {
                if (this.excel_callableOptionViewModel_ != value)
                {
                    this.excel_callableOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_callableOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_puttableOptionViewModel_
        private Excel_puttableOptionViewModel excel_puttableOptionViewModel_;
        public Excel_puttableOptionViewModel Excel_puttableOptionViewModel_
        {
            get { return this.excel_puttableOptionViewModel_; }
            set
            {
                if (this.excel_puttableOptionViewModel_ != value)
                {
                    this.excel_puttableOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_puttableOptionViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_additionalOptionViewModel CreateExcel_additionalOption(string typeStr)
        {
            if ( typeStr == "excel_noneOption")
            {
                return new Excel_noneOptionViewModel();
            }
            else if ( typeStr == "excel_callableOption")
            {
                return new Excel_callableOptionViewModel();
            }
            else if ( typeStr == "excel_puttableOption")
            {
                return new Excel_puttableOptionViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


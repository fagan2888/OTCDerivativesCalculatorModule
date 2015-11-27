using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_returnCalcInfoViewModel : IXmlData
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
        
        public Excel_returnCalcInfoViewModel() { }
        
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
        
        #region Excel_constReturnCalViewModel_
        private Excel_constReturnCalViewModel excel_constReturnCalViewModel_;
        public Excel_constReturnCalViewModel Excel_constReturnCalViewModel_
        {
            get { return this.excel_constReturnCalViewModel_; }
            set
            {
                if (this.excel_constReturnCalViewModel_ != value)
                {
                    this.excel_constReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_constReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_vanillaReturnCalViewModel_
        private Excel_vanillaReturnCalViewModel excel_vanillaReturnCalViewModel_;
        public Excel_vanillaReturnCalViewModel Excel_vanillaReturnCalViewModel_
        {
            get { return this.excel_vanillaReturnCalViewModel_; }
            set
            {
                if (this.excel_vanillaReturnCalViewModel_ != value)
                {
                    this.excel_vanillaReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_returnCalcInfoViewModel CreateExcel_returnCalcInfo(string typeStr)
        {
            if ( typeStr == "excel_constReturnCal")
            {
                return new Excel_constReturnCalViewModel();
            }
            else if ( typeStr == "excel_vanillaReturnCal")
            {
                return new Excel_vanillaReturnCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


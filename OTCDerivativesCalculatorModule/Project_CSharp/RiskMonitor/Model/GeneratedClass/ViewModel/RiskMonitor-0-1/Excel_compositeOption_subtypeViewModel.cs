using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_compositeOption_subtypeViewModel : IXmlData
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
        
        public Excel_compositeOption_subtypeViewModel() { }
        
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
        
        #region Excel_vanillaCallPutViewModel_
        private Excel_vanillaCallPutViewModel excel_vanillaCallPutViewModel_;
        public Excel_vanillaCallPutViewModel Excel_vanillaCallPutViewModel_
        {
            get { return this.excel_vanillaCallPutViewModel_; }
            set
            {
                if (this.excel_vanillaCallPutViewModel_ != value)
                {
                    this.excel_vanillaCallPutViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaCallPutViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_upInOutCallViewModel_
        private Excel_upInOutCallViewModel excel_upInOutCallViewModel_;
        public Excel_upInOutCallViewModel Excel_upInOutCallViewModel_
        {
            get { return this.excel_upInOutCallViewModel_; }
            set
            {
                if (this.excel_upInOutCallViewModel_ != value)
                {
                    this.excel_upInOutCallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_upInOutCallViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_downInOutPutViewModel_
        private Excel_downInOutPutViewModel excel_downInOutPutViewModel_;
        public Excel_downInOutPutViewModel Excel_downInOutPutViewModel_
        {
            get { return this.excel_downInOutPutViewModel_; }
            set
            {
                if (this.excel_downInOutPutViewModel_ != value)
                {
                    this.excel_downInOutPutViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_downInOutPutViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_digitalCallPutViewModel_
        private Excel_digitalCallPutViewModel excel_digitalCallPutViewModel_;
        public Excel_digitalCallPutViewModel Excel_digitalCallPutViewModel_
        {
            get { return this.excel_digitalCallPutViewModel_; }
            set
            {
                if (this.excel_digitalCallPutViewModel_ != value)
                {
                    this.excel_digitalCallPutViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_digitalCallPutViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_compositeOption_subtypeViewModel CreateExcel_compositeOption_subtype(string typeStr)
        {
            if ( typeStr == "excel_vanillaCallPut")
            {
                return new Excel_vanillaCallPutViewModel();
            }
            else if ( typeStr == "excel_upInOutCall")
            {
                return new Excel_upInOutCallViewModel();
            }
            else if ( typeStr == "excel_downInOutPut")
            {
                return new Excel_downInOutPutViewModel();
            }
            else if ( typeStr == "excel_digitalCallPut")
            {
                return new Excel_digitalCallPutViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


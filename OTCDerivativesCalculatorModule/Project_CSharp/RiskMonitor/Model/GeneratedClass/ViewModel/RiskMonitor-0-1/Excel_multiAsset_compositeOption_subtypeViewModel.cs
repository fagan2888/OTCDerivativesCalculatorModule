using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_multiAsset_compositeOption_subtypeViewModel : IXmlData
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
        
        public Excel_multiAsset_compositeOption_subtypeViewModel() { }
        
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
        
        #region Excel_multiAsset_vanillaCallPutViewModel_
        private Excel_multiAsset_vanillaCallPutViewModel excel_multiAsset_vanillaCallPutViewModel_;
        public Excel_multiAsset_vanillaCallPutViewModel Excel_multiAsset_vanillaCallPutViewModel_
        {
            get { return this.excel_multiAsset_vanillaCallPutViewModel_; }
            set
            {
                if (this.excel_multiAsset_vanillaCallPutViewModel_ != value)
                {
                    this.excel_multiAsset_vanillaCallPutViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiAsset_vanillaCallPutViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiAsset_upInOutCallViewModel_
        private Excel_multiAsset_upInOutCallViewModel excel_multiAsset_upInOutCallViewModel_;
        public Excel_multiAsset_upInOutCallViewModel Excel_multiAsset_upInOutCallViewModel_
        {
            get { return this.excel_multiAsset_upInOutCallViewModel_; }
            set
            {
                if (this.excel_multiAsset_upInOutCallViewModel_ != value)
                {
                    this.excel_multiAsset_upInOutCallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiAsset_upInOutCallViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiAsset_downInOutPutViewModel_
        private Excel_multiAsset_downInOutPutViewModel excel_multiAsset_downInOutPutViewModel_;
        public Excel_multiAsset_downInOutPutViewModel Excel_multiAsset_downInOutPutViewModel_
        {
            get { return this.excel_multiAsset_downInOutPutViewModel_; }
            set
            {
                if (this.excel_multiAsset_downInOutPutViewModel_ != value)
                {
                    this.excel_multiAsset_downInOutPutViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiAsset_downInOutPutViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiAsset_digitalCallPutViewModel_
        private Excel_multiAsset_digitalCallPutViewModel excel_multiAsset_digitalCallPutViewModel_;
        public Excel_multiAsset_digitalCallPutViewModel Excel_multiAsset_digitalCallPutViewModel_
        {
            get { return this.excel_multiAsset_digitalCallPutViewModel_; }
            set
            {
                if (this.excel_multiAsset_digitalCallPutViewModel_ != value)
                {
                    this.excel_multiAsset_digitalCallPutViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiAsset_digitalCallPutViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_multiAsset_compositeOption_subtypeViewModel CreateExcel_multiAsset_compositeOption_subtype(string typeStr)
        {
            if ( typeStr == "excel_multiAsset_vanillaCallPut")
            {
                return new Excel_multiAsset_vanillaCallPutViewModel();
            }
            else if ( typeStr == "excel_multiAsset_upInOutCall")
            {
                return new Excel_multiAsset_upInOutCallViewModel();
            }
            else if ( typeStr == "excel_multiAsset_downInOutPut")
            {
                return new Excel_multiAsset_downInOutPutViewModel();
            }
            else if ( typeStr == "excel_multiAsset_digitalCallPut")
            {
                return new Excel_multiAsset_digitalCallPutViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


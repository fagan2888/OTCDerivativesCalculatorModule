using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_structuredBond_subtypeViewModel : IXmlData
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
        
        public Excel_structuredBond_subtypeViewModel() { }
        
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
        
        #region Excel_structuredBond_fixedAccrualViewModel_
        private Excel_structuredBond_fixedAccrualViewModel excel_structuredBond_fixedAccrualViewModel_;
        public Excel_structuredBond_fixedAccrualViewModel Excel_structuredBond_fixedAccrualViewModel_
        {
            get { return this.excel_structuredBond_fixedAccrualViewModel_; }
            set
            {
                if (this.excel_structuredBond_fixedAccrualViewModel_ != value)
                {
                    this.excel_structuredBond_fixedAccrualViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_structuredBond_fixedAccrualViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_structuredBond_floatingAccrualViewModel_
        private Excel_structuredBond_floatingAccrualViewModel excel_structuredBond_floatingAccrualViewModel_;
        public Excel_structuredBond_floatingAccrualViewModel Excel_structuredBond_floatingAccrualViewModel_
        {
            get { return this.excel_structuredBond_floatingAccrualViewModel_; }
            set
            {
                if (this.excel_structuredBond_floatingAccrualViewModel_ != value)
                {
                    this.excel_structuredBond_floatingAccrualViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_structuredBond_floatingAccrualViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_structuredBond_subtypeViewModel CreateExcel_structuredBond_subtype(string typeStr)
        {
            if ( typeStr == "excel_structuredBond_fixedAccrual")
            {
                return new Excel_structuredBond_fixedAccrualViewModel();
            }
            else if ( typeStr == "excel_structuredBond_floatingAccrual")
            {
                return new Excel_structuredBond_floatingAccrualViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


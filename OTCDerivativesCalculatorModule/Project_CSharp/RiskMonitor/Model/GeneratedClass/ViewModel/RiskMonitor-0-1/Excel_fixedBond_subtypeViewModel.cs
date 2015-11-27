using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_fixedBond_subtypeViewModel : IXmlData
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
        
        public Excel_fixedBond_subtypeViewModel() { }
        
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
        
        #region Excel_fixedBond_constantRateViewModel_
        private Excel_fixedBond_constantRateViewModel excel_fixedBond_constantRateViewModel_;
        public Excel_fixedBond_constantRateViewModel Excel_fixedBond_constantRateViewModel_
        {
            get { return this.excel_fixedBond_constantRateViewModel_; }
            set
            {
                if (this.excel_fixedBond_constantRateViewModel_ != value)
                {
                    this.excel_fixedBond_constantRateViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedBond_constantRateViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_fixedBond_subtypeViewModel CreateExcel_fixedBond_subtype(string typeStr)
        {
            if ( typeStr == "excel_fixedBond_constantRate")
            {
                return new Excel_fixedBond_constantRateViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


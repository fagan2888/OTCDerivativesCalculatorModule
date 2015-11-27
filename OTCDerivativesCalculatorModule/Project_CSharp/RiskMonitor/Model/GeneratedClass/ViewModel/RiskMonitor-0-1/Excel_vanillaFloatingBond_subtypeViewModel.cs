using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_vanillaFloatingBond_subtypeViewModel : IXmlData
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
        
        public Excel_vanillaFloatingBond_subtypeViewModel() { }
        
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
        
        #region Excel_vanillaFloatingBond_simpleViewModel_
        private Excel_vanillaFloatingBond_simpleViewModel excel_vanillaFloatingBond_simpleViewModel_;
        public Excel_vanillaFloatingBond_simpleViewModel Excel_vanillaFloatingBond_simpleViewModel_
        {
            get { return this.excel_vanillaFloatingBond_simpleViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingBond_simpleViewModel_ != value)
                {
                    this.excel_vanillaFloatingBond_simpleViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingBond_simpleViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_vanillaFloatingBond_subtypeViewModel CreateExcel_vanillaFloatingBond_subtype(string typeStr)
        {
            if ( typeStr == "excel_vanillaFloatingBond_simple")
            {
                return new Excel_vanillaFloatingBond_simpleViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


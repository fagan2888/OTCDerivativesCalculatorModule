using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_hifive_subtypeViewModel : IXmlData
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
        
        public Excel_hifive_subtypeViewModel() { }
        
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
        
        #region Excel_hifive_stepDown_kiViewModel_
        private Excel_hifive_stepDown_kiViewModel excel_hifive_stepDown_kiViewModel_;
        public Excel_hifive_stepDown_kiViewModel Excel_hifive_stepDown_kiViewModel_
        {
            get { return this.excel_hifive_stepDown_kiViewModel_; }
            set
            {
                if (this.excel_hifive_stepDown_kiViewModel_ != value)
                {
                    this.excel_hifive_stepDown_kiViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifive_stepDown_kiViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_hifive_subtypeViewModel CreateExcel_hifive_subtype(string typeStr)
        {
            if ( typeStr == "excel_hifive_stepDown_ki")
            {
                return new Excel_hifive_stepDown_kiViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


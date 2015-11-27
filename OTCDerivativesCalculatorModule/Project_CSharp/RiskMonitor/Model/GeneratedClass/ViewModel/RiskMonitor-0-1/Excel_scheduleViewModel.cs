using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_scheduleViewModel : IXmlData
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
        
        public Excel_scheduleViewModel() { }
        
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
        
        #region Excel_simpleCalculationViewModel_
        private Excel_simpleCalculationViewModel excel_simpleCalculationViewModel_;
        public Excel_simpleCalculationViewModel Excel_simpleCalculationViewModel_
        {
            get { return this.excel_simpleCalculationViewModel_; }
            set
            {
                if (this.excel_simpleCalculationViewModel_ != value)
                {
                    this.excel_simpleCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_simpleCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_choiceReturnCalculationViewModel_
        private Excel_choiceReturnCalculationViewModel excel_choiceReturnCalculationViewModel_;
        public Excel_choiceReturnCalculationViewModel Excel_choiceReturnCalculationViewModel_
        {
            get { return this.excel_choiceReturnCalculationViewModel_; }
            set
            {
                if (this.excel_choiceReturnCalculationViewModel_ != value)
                {
                    this.excel_choiceReturnCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_choiceReturnCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_scheduleViewModel CreateExcel_schedule(string typeStr)
        {
            if ( typeStr == "excel_simpleCalculation")
            {
                return new Excel_simpleCalculationViewModel();
            }
            else if ( typeStr == "excel_choiceReturnCalculation")
            {
                return new Excel_choiceReturnCalculationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


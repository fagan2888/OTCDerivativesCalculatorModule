using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class Excel_referenceCal_IDViewModel : IXmlData
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
        
    
        public Excel_referenceCal_IDViewModel() { }
        
    
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
        
        #region Excel_referSimpleCalculationViewModel_
        private Excel_referSimpleCalculationViewModel excel_referSimpleCalculationViewModel_;
        public Excel_referSimpleCalculationViewModel Excel_referSimpleCalculationViewModel_
        {
            get { return this.excel_referSimpleCalculationViewModel_; }
            set
            {
                if (this.excel_referSimpleCalculationViewModel_ != value)
                {
                    this.excel_referSimpleCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referSimpleCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_referenceCal_IDViewModel CreateExcel_referenceCal_ID(string typeStr)
        {
            if ( typeStr == "excel_referSimpleCalculation")
            {
                return new Excel_referSimpleCalculationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static Excel_referenceCal_IDViewModel CreateExcel_referenceCal_ID(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceCal_ID serial_Excel_referenceCal_ID = serial_Class as FpmlSerializedCSharp.Excel_referenceCal_ID;
            string typeStr = serial_Excel_referenceCal_ID.Type_.ValueStr;
            return Excel_referenceCal_IDViewModel.CreateExcel_referenceCal_ID(typeStr);
        }
        
    
    }
    
}


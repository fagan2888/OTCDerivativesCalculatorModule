using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class Excel_eventCalcViewModel : IXmlData
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
        
    
        public Excel_eventCalcViewModel() { }
        
    
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
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_eventCalcViewModel CreateExcel_eventCalc(string typeStr)
        {
            if ( typeStr == "excel_singleRangeEventCal")
            {
                return new Excel_singleRangeEventCalViewModel();
            }
            else if ( typeStr == "excel_dualRangeEventCal")
            {
                return new Excel_dualRangeEventCalViewModel();
            }
            else if ( typeStr == "excel_singleBarrierEventCal")
            {
                return new Excel_singleBarrierEventCalViewModel();
            }
            else if ( typeStr == "excel_dualBarrierEventCal")
            {
                return new Excel_dualBarrierEventCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static Excel_eventCalcViewModel CreateExcel_eventCalc(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalc serial_Excel_eventCalc = serial_Class as FpmlSerializedCSharp.Excel_eventCalc;
            string typeStr = serial_Excel_eventCalc.Type_.ValueStr;
            return Excel_eventCalcViewModel.CreateExcel_eventCalc(typeStr);
        }
        
    
    }
    
}


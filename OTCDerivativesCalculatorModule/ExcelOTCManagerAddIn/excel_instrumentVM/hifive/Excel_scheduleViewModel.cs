using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
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

        #region EventDate_
        private DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public abstract void vmBuildFromExcel_interface();
        
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
        
        public static Excel_scheduleViewModel CreateExcel_schedule(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_schedule serial_Excel_schedule = serial_Class as FpmlSerializedCSharp.Excel_schedule;
            string typeStr = serial_Excel_schedule.Type_.ValueStr;
            return Excel_scheduleViewModel.CreateExcel_schedule(typeStr);
        }
        
    
    }
    
}


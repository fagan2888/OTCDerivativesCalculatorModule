using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class Excel_interfaceViewModel : IXmlData
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
        
    
        public Excel_interfaceViewModel() { }
        
    
        #region Excel_workBookType_
        private string excel_workBookType_;
        public string Excel_workBookType_
        {
            get { return this.excel_workBookType_; }
            set
            {
                if (this.excel_workBookType_ != value)
                {
                    this.excel_workBookType_ = value;
                    this.NotifyPropertyChanged("Excel_workBookType_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_interfaceViewModel CreateExcel_interface(string typeStr)
        {
            if ( typeStr == "excel_hifive")
            {
                return new Excel_hifiveViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static Excel_interfaceViewModel CreateExcel_interface(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            string typeStr = serial_Excel_interface.Type_.ValueStr;
            return Excel_interfaceViewModel.CreateExcel_interface(typeStr);
        }
        
    
    }
    
}


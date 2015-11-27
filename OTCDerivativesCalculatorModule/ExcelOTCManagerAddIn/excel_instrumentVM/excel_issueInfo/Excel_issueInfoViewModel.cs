using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class Excel_issueInfoViewModel : IXmlData
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
        
    
        public Excel_issueInfoViewModel() { }
        
    
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
        
        #region Excel_noteInfoViewModel_
        private Excel_noteInfoViewModel excel_noteInfoViewModel_;
        public Excel_noteInfoViewModel Excel_noteInfoViewModel_
        {
            get { return this.excel_noteInfoViewModel_; }
            set
            {
                if (this.excel_noteInfoViewModel_ != value)
                {
                    this.excel_noteInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_noteInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_issueInfoViewModel CreateExcel_issueInfo(string typeStr)
        {
            if ( typeStr == "excel_noteInfo")
            {
                return new Excel_noteInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static Excel_issueInfoViewModel CreateExcel_issueInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            string typeStr = serial_Excel_issueInfo.Type_.ValueStr;
            return Excel_issueInfoViewModel.CreateExcel_issueInfo(typeStr);
        }
        
    
    }
    
}


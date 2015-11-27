using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class DateInformationViewModel : IXmlData
    {

        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion

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
        
        public DateInformationViewModel() { }
    
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
        public string choiceStr_barrierDateType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static DateInformationViewModel CreateDateInformation(string typeStr)
        {
            if ( typeStr == "dailyInterval")
            {
                return new DailyIntervalViewModel();
            }
            else if ( typeStr == "dateList")
            {
                return new DateListViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static DateInformationViewModel CreateDateInformation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DateInformation serial_DateInformation = serial_Class as FpmlSerializedCSharp.DateInformation;
            string typeStr = serial_DateInformation.Type_.ValueStr;
            return DateInformationViewModel.CreateDateInformation(typeStr);
        }
        
    
    }
    
}


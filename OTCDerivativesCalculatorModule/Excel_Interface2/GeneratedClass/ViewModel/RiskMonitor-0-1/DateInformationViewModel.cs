using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class DateInformationViewModel : IXmlData
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
        
        #region DailyIntervalViewModel_
        private DailyIntervalViewModel dailyIntervalViewModel_;
        public DailyIntervalViewModel DailyIntervalViewModel_
        {
            get { return this.dailyIntervalViewModel_; }
            set
            {
                if (this.dailyIntervalViewModel_ != value)
                {
                    this.dailyIntervalViewModel_ = value;
                    this.NotifyPropertyChanged("DailyIntervalViewModel_");
                }
            }
        }
        #endregion
        
        #region DateListViewModel_
        private DateListViewModel dateListViewModel_;
        public DateListViewModel DateListViewModel_
        {
            get { return this.dateListViewModel_; }
            set
            {
                if (this.dateListViewModel_ != value)
                {
                    this.dateListViewModel_ = value;
                    this.NotifyPropertyChanged("DateListViewModel_");
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
        
        
    
    }
    
}


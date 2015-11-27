using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class RedemptionInfoViewModel : IXmlData
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
    
        public RedemptionInfoViewModel() { }

        #region EventTriggerViewModel_
        protected ObservableCollection<EventTriggerViewModel> eventTriggerViewModel_;
        public ObservableCollection<EventTriggerViewModel> EventTriggerViewModel_
        {
            get { return this.eventTriggerViewModel_; }
            set
            {
                if (this.eventTriggerViewModel_ != value)
                {
                    this.eventTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("EventTriggerViewModel_");
                }
            }
        }
        #endregion

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
        
        public string choiceStr_redemptionType;
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
            
        public static RedemptionInfoViewModel CreateRedemptionInfo(string typeStr)
        {
            if ( typeStr == "autoCallRedem")
            {
                return new AutoCallRedemViewModel();
            }
            else if ( typeStr == "monthlyAutoCallRedem")
            {
                return new MonthlyAutoCallRedemViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static RedemptionInfoViewModel CreateRedemptionInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RedemptionInfo serial_RedemptionInfo = serial_Class as FpmlSerializedCSharp.RedemptionInfo;
            string typeStr = serial_RedemptionInfo.Type_.ValueStr;
            return RedemptionInfoViewModel.CreateRedemptionInfo(typeStr);
        }
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class RedemptionInfoViewModel : IXmlData
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
        
        public RedemptionInfoViewModel() { }
        
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
        
        #region AutoCallRedemViewModel_
        private AutoCallRedemViewModel autoCallRedemViewModel_;
        public AutoCallRedemViewModel AutoCallRedemViewModel_
        {
            get { return this.autoCallRedemViewModel_; }
            set
            {
                if (this.autoCallRedemViewModel_ != value)
                {
                    this.autoCallRedemViewModel_ = value;
                    this.NotifyPropertyChanged("AutoCallRedemViewModel_");
                }
            }
        }
        #endregion
        
        #region MonthlyAutoCallRedemViewModel_
        private MonthlyAutoCallRedemViewModel monthlyAutoCallRedemViewModel_;
        public MonthlyAutoCallRedemViewModel MonthlyAutoCallRedemViewModel_
        {
            get { return this.monthlyAutoCallRedemViewModel_; }
            set
            {
                if (this.monthlyAutoCallRedemViewModel_ != value)
                {
                    this.monthlyAutoCallRedemViewModel_ = value;
                    this.NotifyPropertyChanged("MonthlyAutoCallRedemViewModel_");
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
        
        
    
    }
    
}


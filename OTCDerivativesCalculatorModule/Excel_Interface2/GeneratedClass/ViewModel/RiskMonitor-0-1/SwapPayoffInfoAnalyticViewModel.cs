using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class SwapPayoffInfoAnalyticViewModel : IXmlData
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
        
        public SwapPayoffInfoAnalyticViewModel() { }
        
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
        
        #region InterestRateSwapPayoff_AViewModel_
        private InterestRateSwapPayoff_AViewModel interestRateSwapPayoff_AViewModel_;
        public InterestRateSwapPayoff_AViewModel InterestRateSwapPayoff_AViewModel_
        {
            get { return this.interestRateSwapPayoff_AViewModel_; }
            set
            {
                if (this.interestRateSwapPayoff_AViewModel_ != value)
                {
                    this.interestRateSwapPayoff_AViewModel_ = value;
                    this.NotifyPropertyChanged("InterestRateSwapPayoff_AViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_swapPayoffType_A;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static SwapPayoffInfoAnalyticViewModel CreateSwapPayoffInfoAnalytic(string typeStr)
        {
            if ( typeStr == "interestRateSwapPayoff_A")
            {
                return new InterestRateSwapPayoff_AViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


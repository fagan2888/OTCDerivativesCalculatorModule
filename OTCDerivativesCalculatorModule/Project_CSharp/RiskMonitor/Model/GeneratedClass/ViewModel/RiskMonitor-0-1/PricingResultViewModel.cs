using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace Excel_Interface
{
    public abstract class PricingResultViewModel : IXmlData
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
        
        public PricingResultViewModel() { }
        
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
        
        #region CommonResultViewModel_
        private CommonResultViewModel commonResultViewModel_;
        public CommonResultViewModel CommonResultViewModel_
        {
            get { return this.commonResultViewModel_; }
            set
            {
                if (this.commonResultViewModel_ != value)
                {
                    this.commonResultViewModel_ = value;
                    this.NotifyPropertyChanged("CommonResultViewModel_");
                }
            }
        }
        #endregion
        
        #region StepDownKIResultViewModel_
        private StepDownKIResultViewModel stepDownKIResultViewModel_;
        public StepDownKIResultViewModel StepDownKIResultViewModel_
        {
            get { return this.stepDownKIResultViewModel_; }
            set
            {
                if (this.stepDownKIResultViewModel_ != value)
                {
                    this.stepDownKIResultViewModel_ = value;
                    this.NotifyPropertyChanged("StepDownKIResultViewModel_");
                }
            }
        }
        #endregion
        
        #region NullResultViewModel_
        private NullResultViewModel nullResultViewModel_;
        public NullResultViewModel NullResultViewModel_
        {
            get { return this.nullResultViewModel_; }
            set
            {
                if (this.nullResultViewModel_ != value)
                {
                    this.nullResultViewModel_ = value;
                    this.NotifyPropertyChanged("NullResultViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_resultType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static PricingResultViewModel CreatePricingResult(string typeStr)
        {
            if ( typeStr == "commonResult")
            {
                return new CommonResultViewModel();
            }
            else if ( typeStr == "stepDownKIResult")
            {
                return new StepDownKIResultViewModel();
            }
            else if ( typeStr == "nullResult")
            {
                return new NullResultViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


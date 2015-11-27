using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class PricingResultViewModel : IXmlData , IUnderlyingResult
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
        
        public PricingResultViewModel() { }
    
        #region Type_
        protected string type_;
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
        
        public string choiceStr_resultType;
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public abstract UnderylingResultViewModel getUnderlyingResult();

        public static PricingResultViewModel CreatePricingResult(string typeStr)
        {
            if ( typeStr == "stepDownKIResult")
            {
                return new StepDownKIResultViewModel();
            }
            else if ( typeStr == "nullResult")
            {
                return new NullResultViewModel();
            }
            else if (typeStr == "standardCreditResult")
            {
                return new StepDownKIResultViewModel();
            }

            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static PricingResultViewModel CreatePricingResult(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PricingResult serial_PricingResult = serial_Class as FpmlSerializedCSharp.PricingResult;
            string typeStr = serial_PricingResult.Type_.ValueStr;
            return PricingResultViewModel.CreatePricingResult(typeStr);
        }


    }
    
}


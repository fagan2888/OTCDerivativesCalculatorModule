using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class PricingParameterViewModel : IXmlData , IUnderlyingPara
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
        
        public PricingParameterViewModel() { }
        
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
        
        #region MethodViewModel_
        private MethodViewModel methodViewModel_;
        public MethodViewModel MethodViewModel_
        {
            get { return this.methodViewModel_; }
            set
            {
                if (this.methodViewModel_ != value)
                {
                    this.methodViewModel_ = value;
                    this.NotifyPropertyChanged("MethodViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_parameterType;
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);

        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public abstract Underlying_paraViewModel getUnderlyingPara();

        public abstract void loadData(FpmlSerializedCSharp.ISerialized serial_Class);
        public abstract void initializeParameter(InstrumentViewModel instrumentViewModel);

        public static PricingParameterViewModel CreatePricingParameter(string typeStr)
        {
            //if ( typeStr == "creditDefaultSwap_para")
            //{
                //return new CreditDefaultSwap_paraViewModel();
            //}
            //else 
            if ( typeStr == "stepDownKI_para")
            {
                return new StepDownKI_paraViewModel();
            }
            else if (typeStr == "standard_para")
            {
                return new Standard_paraViewModel();
            }
            else if (typeStr == "standardCredit_para")
            {
                return new StandardCredit_paraViewModel();
            }

            else
            {
                throw new NotImplementedException();
            }
        }
        
        public static PricingParameterViewModel CreatePricingParameter(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PricingParameter serial_PricingParameter = serial_Class as FpmlSerializedCSharp.PricingParameter;
            string typeStr = serial_PricingParameter.Type_.ValueStr;
            return PricingParameterViewModel.CreatePricingParameter(typeStr);
        }



    }
    
}


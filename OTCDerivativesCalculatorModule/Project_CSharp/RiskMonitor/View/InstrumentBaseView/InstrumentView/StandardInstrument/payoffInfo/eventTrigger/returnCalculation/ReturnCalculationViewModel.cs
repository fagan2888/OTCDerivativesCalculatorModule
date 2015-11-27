using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class ReturnCalculationViewModel : IXmlData
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
        
        public ReturnCalculationViewModel() { }
    
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
        
        #region PreCalculationViewModel_
        private PreCalculationViewModel preCalculationViewModel_;
        public PreCalculationViewModel PreCalculationViewModel_
        {
            get { return this.preCalculationViewModel_; }
            set
            {
                if (this.preCalculationViewModel_ != value)
                {
                    this.preCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("PreCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region PostCalculationViewModel_
        private PostCalculationViewModel postCalculationViewModel_;
        public PostCalculationViewModel PostCalculationViewModel_
        {
            get { return this.postCalculationViewModel_; }
            set
            {
                if (this.postCalculationViewModel_ != value)
                {
                    this.postCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("PostCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region RefVariable_returnValueViewModel_
        private RefVariable_returnValueViewModel refVariable_returnValueViewModel_;
        public RefVariable_returnValueViewModel RefVariable_returnValueViewModel_
        {
            get { return this.refVariable_returnValueViewModel_; }
            set
            {
                if (this.refVariable_returnValueViewModel_ != value)
                {
                    this.refVariable_returnValueViewModel_ = value;
                    this.NotifyPropertyChanged("RefVariable_returnValueViewModel_");
                }
            }
        }
        #endregion
        
        #region ResetVariableInfoViewModel_
        private ResetVariableInfoViewModel resetVariableInfoViewModel_;
        public ResetVariableInfoViewModel ResetVariableInfoViewModel_
        {
            get { return this.resetVariableInfoViewModel_; }
            set
            {
                if (this.resetVariableInfoViewModel_ != value)
                {
                    this.resetVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ResetVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
    
        public static ReturnCalculationViewModel CreateReturnCalculation(string typeStr)
        {
            if ( typeStr == "stopLossReturnCal")
            {
                return new StopLossReturnCalViewModel();
            }
            else if ( typeStr == "constReturnCal")
            {
                return new ConstReturnCalViewModel();
            }
            else if ( typeStr == "vanillaReturnCal")
            {
                return new VanillaReturnCalViewModel();
            }
            else if ( typeStr == "complex1DReturnCal")
            {
                return new Complex1DReturnCalViewModel();
            }
            else if ( typeStr == "complexNDReturnCal")
            {
                return new ComplexNDReturnCalViewModel();
            }
            else if ( typeStr == "zeroReturnCal")
            {
                return new ZeroReturnCalViewModel();
            }
            else if ( typeStr == "callPutCompositeReturnCal")
            {
                return new CallPutCompositeReturnCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static ReturnCalculationViewModel CreateReturnCalculation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            string typeStr = serial_ReturnCalculation.Type_.ValueStr;
            return ReturnCalculationViewModel.CreateReturnCalculation(typeStr);
        }
        
    
    }
    
}


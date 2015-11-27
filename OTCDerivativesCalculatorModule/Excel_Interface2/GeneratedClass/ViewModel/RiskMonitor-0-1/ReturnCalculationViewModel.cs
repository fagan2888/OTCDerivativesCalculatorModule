using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class ReturnCalculationViewModel : IXmlData
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
        
        #region StopLossReturnCalViewModel_
        private StopLossReturnCalViewModel stopLossReturnCalViewModel_;
        public StopLossReturnCalViewModel StopLossReturnCalViewModel_
        {
            get { return this.stopLossReturnCalViewModel_; }
            set
            {
                if (this.stopLossReturnCalViewModel_ != value)
                {
                    this.stopLossReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("StopLossReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region ConstReturnCalViewModel_
        private ConstReturnCalViewModel constReturnCalViewModel_;
        public ConstReturnCalViewModel ConstReturnCalViewModel_
        {
            get { return this.constReturnCalViewModel_; }
            set
            {
                if (this.constReturnCalViewModel_ != value)
                {
                    this.constReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("ConstReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaReturnCalViewModel_
        private VanillaReturnCalViewModel vanillaReturnCalViewModel_;
        public VanillaReturnCalViewModel VanillaReturnCalViewModel_
        {
            get { return this.vanillaReturnCalViewModel_; }
            set
            {
                if (this.vanillaReturnCalViewModel_ != value)
                {
                    this.vanillaReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region Complex1DReturnCalViewModel_
        private Complex1DReturnCalViewModel complex1DReturnCalViewModel_;
        public Complex1DReturnCalViewModel Complex1DReturnCalViewModel_
        {
            get { return this.complex1DReturnCalViewModel_; }
            set
            {
                if (this.complex1DReturnCalViewModel_ != value)
                {
                    this.complex1DReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("Complex1DReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region ComplexNDReturnCalViewModel_
        private ComplexNDReturnCalViewModel complexNDReturnCalViewModel_;
        public ComplexNDReturnCalViewModel ComplexNDReturnCalViewModel_
        {
            get { return this.complexNDReturnCalViewModel_; }
            set
            {
                if (this.complexNDReturnCalViewModel_ != value)
                {
                    this.complexNDReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("ComplexNDReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region ZeroReturnCalViewModel_
        private ZeroReturnCalViewModel zeroReturnCalViewModel_;
        public ZeroReturnCalViewModel ZeroReturnCalViewModel_
        {
            get { return this.zeroReturnCalViewModel_; }
            set
            {
                if (this.zeroReturnCalViewModel_ != value)
                {
                    this.zeroReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("ZeroReturnCalViewModel_");
                }
            }
        }
        #endregion
        
        #region CallPutCompositeReturnCalViewModel_
        private CallPutCompositeReturnCalViewModel callPutCompositeReturnCalViewModel_;
        public CallPutCompositeReturnCalViewModel CallPutCompositeReturnCalViewModel_
        {
            get { return this.callPutCompositeReturnCalViewModel_; }
            set
            {
                if (this.callPutCompositeReturnCalViewModel_ != value)
                {
                    this.callPutCompositeReturnCalViewModel_ = value;
                    this.NotifyPropertyChanged("CallPutCompositeReturnCalViewModel_");
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
        
        public string choiceStr_returnCalType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static ReturnCalculationViewModel CreateReturnCalculation(string typeStr)
        {
            if ( typeStr == "preCalculation")
            {
                return new PreCalculationViewModel();
            }
            else if ( typeStr == "stopLossReturnCal")
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
            else if ( typeStr == "postCalculation")
            {
                return new PostCalculationViewModel();
            }
            else if ( typeStr == "refVariable_returnValue")
            {
                return new RefVariable_returnValueViewModel();
            }
            else if ( typeStr == "resetVariableInfo")
            {
                return new ResetVariableInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


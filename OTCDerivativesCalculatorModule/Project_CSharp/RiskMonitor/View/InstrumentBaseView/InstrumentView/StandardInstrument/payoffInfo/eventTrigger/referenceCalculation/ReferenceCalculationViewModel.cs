using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class ReferenceCalculationViewModel : IXmlData
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
        
    
        public ReferenceCalculationViewModel() { }
        
    
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
        
        // 이거 사용안하기로 했는데... ㅡ.ㅡ;;; 
        #region FixingInformationViewModel_
        private FixingInformationViewModel fixingInformationViewModel_;
        public FixingInformationViewModel FixingInformationViewModel_
        {
            get { return this.fixingInformationViewModel_; }
            set
            {
                if (this.fixingInformationViewModel_ != value)
                {
                    this.fixingInformationViewModel_ = value;
                    this.NotifyPropertyChanged("FixingInformationViewModel_");
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
        
        #region RefVariable_referenceValueViewModel_
        private RefVariable_referenceValueViewModel refVariable_referenceValueViewModel_;
        public RefVariable_referenceValueViewModel RefVariable_referenceValueViewModel_
        {
            get { return this.refVariable_referenceValueViewModel_; }
            set
            {
                if (this.refVariable_referenceValueViewModel_ != value)
                {
                    this.refVariable_referenceValueViewModel_ = value;
                    this.NotifyPropertyChanged("RefVariable_referenceValueViewModel_");
                }
            }
        }
        #endregion


        //여기다 올려놓고 사용함. excel interface 때문에, 공통으로 모양만들고 나중에 date만 따로 fixing을 위해서.. 2014-02-18
        #region FixingDateInfoViewModel_
        protected FixingDateInfoViewModel fixingDateInfoViewModel_;
        public FixingDateInfoViewModel FixingDateInfoViewModel_
        {
            get { return this.fixingDateInfoViewModel_; }
            set
            {
                if (this.fixingDateInfoViewModel_ != value)
                {
                    this.fixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("FixingDateInfoViewModel_");
                }
            }
        }
        #endregion

        public string choiceStr_referenceCalType;
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);


        
        public static ReferenceCalculationViewModel CreateReferenceCalculation(string typeStr)
        {
            if ( typeStr == "choiceReferenceCal")
            {
                return new ChoiceReferenceCalViewModel();
            }
            else if ( typeStr == "identityReferenceCal")
            {
                return new IdentityReferenceCalViewModel();
            }
            else if ( typeStr == "maximumReferenceCal")
            {
                return new MaximumReferenceCalViewModel();
            }
            else if ( typeStr == "minimumReferenceCal")
            {
                return new MinimumReferenceCalViewModel();
            }
            else if ( typeStr == "refVariableReferenceCal")
            {
                return new RefVariableReferenceCalViewModel();
            }
            else if ( typeStr == "dailyReturnReferenceCal")
            {
                return new DailyReturnReferenceCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static ReferenceCalculationViewModel CreateReferenceCalculation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculation serial_ReferenceCalculation = serial_Class as FpmlSerializedCSharp.ReferenceCalculation;
            string typeStr = serial_ReferenceCalculation.Type_.ValueStr;
            return ReferenceCalculationViewModel.CreateReferenceCalculation(typeStr);
        }
        
    
    }
    
}


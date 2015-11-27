using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class ReferenceCalculationViewModel : IXmlData
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
        
        #region ChoiceReferenceCalViewModel_
        private ChoiceReferenceCalViewModel choiceReferenceCalViewModel_;
        public ChoiceReferenceCalViewModel ChoiceReferenceCalViewModel_
        {
            get { return this.choiceReferenceCalViewModel_; }
            set
            {
                if (this.choiceReferenceCalViewModel_ != value)
                {
                    this.choiceReferenceCalViewModel_ = value;
                    this.NotifyPropertyChanged("ChoiceReferenceCalViewModel_");
                }
            }
        }
        #endregion
        
        #region IdentityReferenceCalViewModel_
        private IdentityReferenceCalViewModel identityReferenceCalViewModel_;
        public IdentityReferenceCalViewModel IdentityReferenceCalViewModel_
        {
            get { return this.identityReferenceCalViewModel_; }
            set
            {
                if (this.identityReferenceCalViewModel_ != value)
                {
                    this.identityReferenceCalViewModel_ = value;
                    this.NotifyPropertyChanged("IdentityReferenceCalViewModel_");
                }
            }
        }
        #endregion
        
        #region MaximumReferenceCalViewModel_
        private MaximumReferenceCalViewModel maximumReferenceCalViewModel_;
        public MaximumReferenceCalViewModel MaximumReferenceCalViewModel_
        {
            get { return this.maximumReferenceCalViewModel_; }
            set
            {
                if (this.maximumReferenceCalViewModel_ != value)
                {
                    this.maximumReferenceCalViewModel_ = value;
                    this.NotifyPropertyChanged("MaximumReferenceCalViewModel_");
                }
            }
        }
        #endregion
        
        #region MinimumReferenceCalViewModel_
        private MinimumReferenceCalViewModel minimumReferenceCalViewModel_;
        public MinimumReferenceCalViewModel MinimumReferenceCalViewModel_
        {
            get { return this.minimumReferenceCalViewModel_; }
            set
            {
                if (this.minimumReferenceCalViewModel_ != value)
                {
                    this.minimumReferenceCalViewModel_ = value;
                    this.NotifyPropertyChanged("MinimumReferenceCalViewModel_");
                }
            }
        }
        #endregion
        
        #region RefVariableReferenceCalViewModel_
        private RefVariableReferenceCalViewModel refVariableReferenceCalViewModel_;
        public RefVariableReferenceCalViewModel RefVariableReferenceCalViewModel_
        {
            get { return this.refVariableReferenceCalViewModel_; }
            set
            {
                if (this.refVariableReferenceCalViewModel_ != value)
                {
                    this.refVariableReferenceCalViewModel_ = value;
                    this.NotifyPropertyChanged("RefVariableReferenceCalViewModel_");
                }
            }
        }
        #endregion
        
        #region DailyReturnReferenceCalViewModel_
        private DailyReturnReferenceCalViewModel dailyReturnReferenceCalViewModel_;
        public DailyReturnReferenceCalViewModel DailyReturnReferenceCalViewModel_
        {
            get { return this.dailyReturnReferenceCalViewModel_; }
            set
            {
                if (this.dailyReturnReferenceCalViewModel_ != value)
                {
                    this.dailyReturnReferenceCalViewModel_ = value;
                    this.NotifyPropertyChanged("DailyReturnReferenceCalViewModel_");
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
        
        public string choiceStr_referenceCalType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static ReferenceCalculationViewModel CreateReferenceCalculation(string typeStr)
        {
            if ( typeStr == "fixingInformation")
            {
                return new FixingInformationViewModel();
            }
            else if ( typeStr == "choiceReferenceCal")
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
            else if ( typeStr == "postCalculation")
            {
                return new PostCalculationViewModel();
            }
            else if ( typeStr == "refVariable_referenceValue")
            {
                return new RefVariable_referenceValueViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


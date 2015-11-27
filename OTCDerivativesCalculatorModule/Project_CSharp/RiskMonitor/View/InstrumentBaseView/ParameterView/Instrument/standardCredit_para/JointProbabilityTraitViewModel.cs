using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class JointProbabilityTraitViewModel : IXmlData
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
        
        public JointProbabilityTraitViewModel() { }
    
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
        
        #region NthDefaultTraitViewModel_
        private NthDefaultTraitViewModel nthDefaultTraitViewModel_;
        public NthDefaultTraitViewModel NthDefaultTraitViewModel_
        {
            get { return this.nthDefaultTraitViewModel_; }
            set
            {
                if (this.nthDefaultTraitViewModel_ != value)
                {
                    this.nthDefaultTraitViewModel_ = value;
                    this.NotifyPropertyChanged("NthDefaultTraitViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_jointType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static JointProbabilityTraitViewModel CreateJointProbabilityTrait(string typeStr)
        {
            if ( typeStr == "nthDefaultTrait")
            {
                return new NthDefaultTraitViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static JointProbabilityTraitViewModel CreateJointProbabilityTrait(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.JointProbabilityTrait serial_JointProbabilityTrait = serial_Class as FpmlSerializedCSharp.JointProbabilityTrait;
            string typeStr = serial_JointProbabilityTrait.Type_.ValueStr;
            return JointProbabilityTraitViewModel.CreateJointProbabilityTrait(typeStr);
        }
        
    
    }
    
}


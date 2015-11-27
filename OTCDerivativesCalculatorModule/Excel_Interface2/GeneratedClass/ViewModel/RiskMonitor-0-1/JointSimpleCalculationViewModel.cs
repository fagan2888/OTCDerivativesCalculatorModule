using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class JointSimpleCalculationViewModel : IXmlData
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
        
        public JointSimpleCalculationViewModel() { }
        
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
        
        #region AndSimpleCalViewModel_
        private AndSimpleCalViewModel andSimpleCalViewModel_;
        public AndSimpleCalViewModel AndSimpleCalViewModel_
        {
            get { return this.andSimpleCalViewModel_; }
            set
            {
                if (this.andSimpleCalViewModel_ != value)
                {
                    this.andSimpleCalViewModel_ = value;
                    this.NotifyPropertyChanged("AndSimpleCalViewModel_");
                }
            }
        }
        #endregion
        
        #region SingeSimpleCalViewModel_
        private SingeSimpleCalViewModel singeSimpleCalViewModel_;
        public SingeSimpleCalViewModel SingeSimpleCalViewModel_
        {
            get { return this.singeSimpleCalViewModel_; }
            set
            {
                if (this.singeSimpleCalViewModel_ != value)
                {
                    this.singeSimpleCalViewModel_ = value;
                    this.NotifyPropertyChanged("SingeSimpleCalViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_jointSimpleType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static JointSimpleCalculationViewModel CreateJointSimpleCalculation(string typeStr)
        {
            if ( typeStr == "andSimpleCal")
            {
                return new AndSimpleCalViewModel();
            }
            else if ( typeStr == "singeSimpleCal")
            {
                return new SingeSimpleCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


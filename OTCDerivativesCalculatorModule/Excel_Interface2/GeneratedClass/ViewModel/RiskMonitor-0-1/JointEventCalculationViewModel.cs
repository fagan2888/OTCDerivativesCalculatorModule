using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class JointEventCalculationViewModel : IXmlData
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
        
        public JointEventCalculationViewModel() { }
        
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
        
        #region AndEventCalViewModel_
        private AndEventCalViewModel andEventCalViewModel_;
        public AndEventCalViewModel AndEventCalViewModel_
        {
            get { return this.andEventCalViewModel_; }
            set
            {
                if (this.andEventCalViewModel_ != value)
                {
                    this.andEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("AndEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region OrEventCalViewModel_
        private OrEventCalViewModel orEventCalViewModel_;
        public OrEventCalViewModel OrEventCalViewModel_
        {
            get { return this.orEventCalViewModel_; }
            set
            {
                if (this.orEventCalViewModel_ != value)
                {
                    this.orEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("OrEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region AtLeastEventCalViewModel_
        private AtLeastEventCalViewModel atLeastEventCalViewModel_;
        public AtLeastEventCalViewModel AtLeastEventCalViewModel_
        {
            get { return this.atLeastEventCalViewModel_; }
            set
            {
                if (this.atLeastEventCalViewModel_ != value)
                {
                    this.atLeastEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("AtLeastEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region AtMostEventCalViewModel_
        private AtMostEventCalViewModel atMostEventCalViewModel_;
        public AtMostEventCalViewModel AtMostEventCalViewModel_
        {
            get { return this.atMostEventCalViewModel_; }
            set
            {
                if (this.atMostEventCalViewModel_ != value)
                {
                    this.atMostEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("AtMostEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region CountEventCalViewModel_
        private CountEventCalViewModel countEventCalViewModel_;
        public CountEventCalViewModel CountEventCalViewModel_
        {
            get { return this.countEventCalViewModel_; }
            set
            {
                if (this.countEventCalViewModel_ != value)
                {
                    this.countEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("CountEventCalViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_jointEventType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static JointEventCalculationViewModel CreateJointEventCalculation(string typeStr)
        {
            if ( typeStr == "andEventCal")
            {
                return new AndEventCalViewModel();
            }
            else if ( typeStr == "orEventCal")
            {
                return new OrEventCalViewModel();
            }
            else if ( typeStr == "atLeastEventCal")
            {
                return new AtLeastEventCalViewModel();
            }
            else if ( typeStr == "atMostEventCal")
            {
                return new AtMostEventCalViewModel();
            }
            else if ( typeStr == "countEventCal")
            {
                return new CountEventCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


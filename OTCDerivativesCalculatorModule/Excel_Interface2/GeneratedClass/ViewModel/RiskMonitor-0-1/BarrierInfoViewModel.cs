using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class BarrierInfoViewModel : IXmlData
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
        
        public BarrierInfoViewModel() { }
        
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
        
        #region ConstDualBarrierInfoViewModel_
        private ConstDualBarrierInfoViewModel constDualBarrierInfoViewModel_;
        public ConstDualBarrierInfoViewModel ConstDualBarrierInfoViewModel_
        {
            get { return this.constDualBarrierInfoViewModel_; }
            set
            {
                if (this.constDualBarrierInfoViewModel_ != value)
                {
                    this.constDualBarrierInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ConstDualBarrierInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ConstLowerBarrierInfoViewModel_
        private ConstLowerBarrierInfoViewModel constLowerBarrierInfoViewModel_;
        public ConstLowerBarrierInfoViewModel ConstLowerBarrierInfoViewModel_
        {
            get { return this.constLowerBarrierInfoViewModel_; }
            set
            {
                if (this.constLowerBarrierInfoViewModel_ != value)
                {
                    this.constLowerBarrierInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ConstLowerBarrierInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ConstUpperBarrierInfoViewModel_
        private ConstUpperBarrierInfoViewModel constUpperBarrierInfoViewModel_;
        public ConstUpperBarrierInfoViewModel ConstUpperBarrierInfoViewModel_
        {
            get { return this.constUpperBarrierInfoViewModel_; }
            set
            {
                if (this.constUpperBarrierInfoViewModel_ != value)
                {
                    this.constUpperBarrierInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ConstUpperBarrierInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_barrierType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static BarrierInfoViewModel CreateBarrierInfo(string typeStr)
        {
            if ( typeStr == "constDualBarrierInfo")
            {
                return new ConstDualBarrierInfoViewModel();
            }
            else if ( typeStr == "constLowerBarrierInfo")
            {
                return new ConstLowerBarrierInfoViewModel();
            }
            else if ( typeStr == "constUpperBarrierInfo")
            {
                return new ConstUpperBarrierInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


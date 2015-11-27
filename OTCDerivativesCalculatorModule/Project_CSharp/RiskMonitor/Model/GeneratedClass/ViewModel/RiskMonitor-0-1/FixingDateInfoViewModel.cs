using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class FixingDateInfoViewModel : IXmlData
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
        
        public FixingDateInfoViewModel() { }
        
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
        
        #region FixedFixingDateInfoViewModel_
        private FixedFixingDateInfoViewModel fixedFixingDateInfoViewModel_;
        public FixedFixingDateInfoViewModel FixedFixingDateInfoViewModel_
        {
            get { return this.fixedFixingDateInfoViewModel_; }
            set
            {
                if (this.fixedFixingDateInfoViewModel_ != value)
                {
                    this.fixedFixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("FixedFixingDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region RefVariableFixingDateInfoViewModel_
        private RefVariableFixingDateInfoViewModel refVariableFixingDateInfoViewModel_;
        public RefVariableFixingDateInfoViewModel RefVariableFixingDateInfoViewModel_
        {
            get { return this.refVariableFixingDateInfoViewModel_; }
            set
            {
                if (this.refVariableFixingDateInfoViewModel_ != value)
                {
                    this.refVariableFixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("RefVariableFixingDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region NullFixingDateInfoViewModel_
        private NullFixingDateInfoViewModel nullFixingDateInfoViewModel_;
        public NullFixingDateInfoViewModel NullFixingDateInfoViewModel_
        {
            get { return this.nullFixingDateInfoViewModel_; }
            set
            {
                if (this.nullFixingDateInfoViewModel_ != value)
                {
                    this.nullFixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("NullFixingDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_fixingDateType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static FixingDateInfoViewModel CreateFixingDateInfo(string typeStr)
        {
            if ( typeStr == "fixedFixingDateInfo")
            {
                return new FixedFixingDateInfoViewModel();
            }
            else if ( typeStr == "refVariableFixingDateInfo")
            {
                return new RefVariableFixingDateInfoViewModel();
            }
            else if ( typeStr == "nullFixingDateInfo")
            {
                return new NullFixingDateInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class FixingDateInfoViewModel : IXmlData
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
        
        public static FixingDateInfoViewModel CreateFixingDateInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixingDateInfo serial_FixingDateInfo = serial_Class as FpmlSerializedCSharp.FixingDateInfo;
            string typeStr = serial_FixingDateInfo.Type_.ValueStr;
            return FixingDateInfoViewModel.CreateFixingDateInfo(typeStr);
        }
        
    
    }
    
}


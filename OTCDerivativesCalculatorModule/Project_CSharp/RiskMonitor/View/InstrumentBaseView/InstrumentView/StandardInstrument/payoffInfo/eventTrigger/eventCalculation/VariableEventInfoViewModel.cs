using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class VariableEventInfoViewModel : IXmlData
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
        
    
        public VariableEventInfoViewModel() { }
        
    
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
        
        #region NullVariableEventInfoViewModel_
        private NullVariableEventInfoViewModel nullVariableEventInfoViewModel_;
        public NullVariableEventInfoViewModel NullVariableEventInfoViewModel_
        {
            get { return this.nullVariableEventInfoViewModel_; }
            set
            {
                if (this.nullVariableEventInfoViewModel_ != value)
                {
                    this.nullVariableEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("NullVariableEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region OverWriteVariableEventInfoViewModel_
        private OverWriteVariableEventInfoViewModel overWriteVariableEventInfoViewModel_;
        public OverWriteVariableEventInfoViewModel OverWriteVariableEventInfoViewModel_
        {
            get { return this.overWriteVariableEventInfoViewModel_; }
            set
            {
                if (this.overWriteVariableEventInfoViewModel_ != value)
                {
                    this.overWriteVariableEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("OverWriteVariableEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_variableEventInfoType;
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static VariableEventInfoViewModel CreateVariableEventInfo(string typeStr)
        {
            if ( typeStr == "nullVariableEventInfo")
            {
                return new NullVariableEventInfoViewModel();
            }
            else if ( typeStr == "overWriteVariableEventInfo")
            {
                return new OverWriteVariableEventInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static VariableEventInfoViewModel CreateVariableEventInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableEventInfo serial_VariableEventInfo = serial_Class as FpmlSerializedCSharp.VariableEventInfo;
            string typeStr = serial_VariableEventInfo.Type_.ValueStr;
            return VariableEventInfoViewModel.CreateVariableEventInfo(typeStr);
        }
        
    
    }
    
}


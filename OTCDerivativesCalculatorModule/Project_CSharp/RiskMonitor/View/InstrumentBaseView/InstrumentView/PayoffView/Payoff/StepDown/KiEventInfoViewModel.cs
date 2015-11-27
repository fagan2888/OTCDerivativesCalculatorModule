using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class KiEventInfoViewModel : IXmlData
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
    
        public KiEventInfoViewModel() { }
    
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
        
        #region ConstKiTriggerViewModel_
        private ConstKiTriggerViewModel constKiTriggerViewModel_;
        public ConstKiTriggerViewModel ConstKiTriggerViewModel_
        {
            get { return this.constKiTriggerViewModel_; }
            set
            {
                if (this.constKiTriggerViewModel_ != value)
                {
                    this.constKiTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("ConstKiTriggerViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_kiType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static KiEventInfoViewModel CreateKiEventInfo(string typeStr)
        {
            if ( typeStr == "constKiTrigger")
            {
                return new ConstKiTriggerViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static KiEventInfoViewModel CreateKiEventInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.KiEventInfo serial_KiEventInfo = serial_Class as FpmlSerializedCSharp.KiEventInfo;
            string typeStr = serial_KiEventInfo.Type_.ValueStr;
            return KiEventInfoViewModel.CreateKiEventInfo(typeStr);
        }
        
    
    }
    
}


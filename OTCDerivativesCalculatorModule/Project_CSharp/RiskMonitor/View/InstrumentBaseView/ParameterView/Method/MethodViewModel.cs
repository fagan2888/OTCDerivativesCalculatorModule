using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class MethodViewModel : IXmlData
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
        
        public MethodViewModel() { }
    
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
        
        #region MonteViewModel_
        private MonteViewModel monteViewModel_;
        public MonteViewModel MonteViewModel_
        {
            get { return this.monteViewModel_; }
            set
            {
                if (this.monteViewModel_ != value)
                {
                    this.monteViewModel_ = value;
                    this.NotifyPropertyChanged("MonteViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_methodType;
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
    
        public static MethodViewModel CreateMethod(string typeStr)
        {
            if ( typeStr == "monte")
            {
                return new MonteViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static MethodViewModel CreateMethod(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Method serial_Method = serial_Class as FpmlSerializedCSharp.Method;
            string typeStr = serial_Method.Type_.ValueStr;
            return MethodViewModel.CreateMethod(typeStr);
        }
        
    
    }
    
}


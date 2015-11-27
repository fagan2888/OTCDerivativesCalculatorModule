using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class ReferenceCurveViewModel : IXmlData
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
    
        public ReferenceCurveViewModel() { }
    
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
        
        public string choiceStr_tsType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static ReferenceCurveViewModel CreateReferenceCurve(string typeStr)
        {
            if ( typeStr == "cdsSpreadTermstructure")
            {
                return new CdsSpreadTermstructureViewModel();
            }
            else if ( typeStr == "yieldTermstructure")
            {
                return new YieldTermstructureViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static ReferenceCurveViewModel CreateReferenceCurve(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCurve serial_ReferenceCurve = serial_Class as FpmlSerializedCSharp.ReferenceCurve;
            string typeStr = serial_ReferenceCurve.Type_.ValueStr;
            return ReferenceCurveViewModel.CreateReferenceCurve(typeStr);
        }
        
    
    }
    
}


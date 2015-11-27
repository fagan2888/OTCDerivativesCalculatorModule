using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class ReferenceCurveViewModel : IXmlData
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
        
        public ReferenceCurveViewModel() { }
        
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
        
        #region CdsSpreadTermstructureViewModel_
        private CdsSpreadTermstructureViewModel cdsSpreadTermstructureViewModel_;
        public CdsSpreadTermstructureViewModel CdsSpreadTermstructureViewModel_
        {
            get { return this.cdsSpreadTermstructureViewModel_; }
            set
            {
                if (this.cdsSpreadTermstructureViewModel_ != value)
                {
                    this.cdsSpreadTermstructureViewModel_ = value;
                    this.NotifyPropertyChanged("CdsSpreadTermstructureViewModel_");
                }
            }
        }
        #endregion
        
        #region YieldTermstructureViewModel_
        private YieldTermstructureViewModel yieldTermstructureViewModel_;
        public YieldTermstructureViewModel YieldTermstructureViewModel_
        {
            get { return this.yieldTermstructureViewModel_; }
            set
            {
                if (this.yieldTermstructureViewModel_ != value)
                {
                    this.yieldTermstructureViewModel_ = value;
                    this.NotifyPropertyChanged("YieldTermstructureViewModel_");
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
        
        
    
    }
    
}


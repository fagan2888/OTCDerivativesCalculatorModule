using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceObligationViewModel : IXmlData
    {
        #region View_
        private Control view_;
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
        
    
        public ReferenceObligationViewModel() { }
        
    
        #region BondViewModel_
        private BondViewModel bondViewModel_;
        public BondViewModel BondViewModel_
        {
            get { return this.bondViewModel_; }
            set
            {
                if (this.bondViewModel_ != value)
                {
                    this.bondViewModel_ = value;
                    this.NotifyPropertyChanged("BondViewModel_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceObligation serial_ReferenceObligation = serial_Class as FpmlSerializedCSharp.ReferenceObligation;
        
            FpmlSerializedCSharp.Bond serial_bond = serial_ReferenceObligation.Bond_;
            this.bondViewModel_ = new BondViewModel();
            this.bondViewModel_.setFromSerial(serial_bond);
            
            this.view_ = new ReferenceObligationView();
            this.view_.DataContext = this;
        }
    
    }
    
}


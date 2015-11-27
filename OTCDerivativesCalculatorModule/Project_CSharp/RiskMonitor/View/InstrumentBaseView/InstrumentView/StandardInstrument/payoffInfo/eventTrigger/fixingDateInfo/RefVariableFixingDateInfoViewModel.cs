using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class RefVariableFixingDateInfoViewModel : FixingDateInfoViewModel
    {
        
    
        public RefVariableFixingDateInfoViewModel() { }
        
    
        #region RefDateName_
        private string refDateName_;
        public string RefDateName_
        {
            get { return this.refDateName_; }
            set
            {
                if (this.refDateName_ != value)
                {
                    this.refDateName_ = value;
                    this.NotifyPropertyChanged("RefDateName_");
                }
            }
        }
        #endregion
        
        #region AutoCallFlag_
        private string autoCallFlag_;
        public string AutoCallFlag_
        {
            get { return this.autoCallFlag_; }
            set
            {
                if (this.autoCallFlag_ != value)
                {
                    this.autoCallFlag_ = value;
                    this.NotifyPropertyChanged("AutoCallFlag_");
                }
            }
        }
        #endregion
        
        #region AutoCallFixingDate_
        private string autoCallFixingDate_;
        public string AutoCallFixingDate_
        {
            get { return this.autoCallFixingDate_; }
            set
            {
                if (this.autoCallFixingDate_ != value)
                {
                    this.autoCallFixingDate_ = value;
                    this.NotifyPropertyChanged("AutoCallFixingDate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("fixingDateInfo");
                xmlWriter.WriteElementString("type" , "refVariableFixingDateInfo");
                xmlWriter.WriteStartElement("refVariableFixingDateInfo");
                    xmlWriter.WriteElementString("refDateName" , this.refDateName_);
                    
                    xmlWriter.WriteElementString("autoCallFlag" , this.autoCallFlag_);
                    
                    xmlWriter.WriteElementString("autoCallFixingDate" , this.autoCallFixingDate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixingDateInfo serial_FixingDateInfo = serial_Class as FpmlSerializedCSharp.FixingDateInfo;
            FpmlSerializedCSharp.RefVariableFixingDateInfo serial_RefVariableFixingDateInfo = serial_FixingDateInfo.RefVariableFixingDateInfo_;
        
            this.refDateName_ = serial_RefVariableFixingDateInfo.RefDateName_.ValueStr;
            
            this.autoCallFlag_ = serial_RefVariableFixingDateInfo.AutoCallFlag_.ValueStr;
            
            this.autoCallFixingDate_ = serial_RefVariableFixingDateInfo.AutoCallFixingDate_.ValueStr;
            
           //this.view_ = new RefVariableFixingDateInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


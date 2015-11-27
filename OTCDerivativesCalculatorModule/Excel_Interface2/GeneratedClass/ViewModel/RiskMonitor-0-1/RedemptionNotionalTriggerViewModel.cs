using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RedemptionNotionalTriggerViewModel : EventTriggeViewModel
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
        
        public RedemptionNotionalTriggerViewModel() { }
        
        #region PayoffDateInfoViewModel_
        private PayoffDateInfoViewModel payoffDateInfoViewModel_;
        public PayoffDateInfoViewModel PayoffDateInfoViewModel_
        {
            get { return this.payoffDateInfoViewModel_; }
            set
            {
                if (this.payoffDateInfoViewModel_ != value)
                {
                    this.payoffDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region RedemptionAmount_
        private string redemptionAmount_;
        public string RedemptionAmount_
        {
            get { return this.redemptionAmount_; }
            set
            {
                if (this.redemptionAmount_ != value)
                {
                    this.redemptionAmount_ = value;
                    this.NotifyPropertyChanged("RedemptionAmount_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigge");
                xmlWriter.WriteElementString("excel_type" , "redemptionNotionalTrigger");
                xmlWriter.WriteStartElement("redemptionNotionalTrigger");
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("redemptionAmount" , this.redemptionAmount_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new RedemptionNotionalTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigge serial_EventTrigge = serial_Class as FpmlSerializedCSharp.EventTrigge;
            FpmlSerializedCSharp.RedemptionNotionalTrigger serial_RedemptionNotionalTrigger = serial_EventTrigge.RedemptionNotionalTrigger_;
        
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_RedemptionNotionalTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.redemptionAmount_ = serial_RedemptionNotionalTrigger.RedemptionAmount_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


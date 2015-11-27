using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class AutoCallConstReturnTriggerViewModel : EventTriggerViewModel
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
        
        public AutoCallConstReturnTriggerViewModel() { }
        
        #region DateOrder_
        private string dateOrder_;
        public string DateOrder_
        {
            get { return this.dateOrder_; }
            set
            {
                if (this.dateOrder_ != value)
                {
                    this.dateOrder_ = value;
                    this.NotifyPropertyChanged("DateOrder_");
                }
            }
        }
        #endregion
        
        #region FixingDateInfoViewModel_
        private FixingDateInfoViewModel fixingDateInfoViewModel_;
        public FixingDateInfoViewModel FixingDateInfoViewModel_
        {
            get { return this.fixingDateInfoViewModel_; }
            set
            {
                if (this.fixingDateInfoViewModel_ != value)
                {
                    this.fixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("FixingDateInfoViewModel_");
                }
            }
        }
        #endregion
        
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
        
        #region Trigger_
        private string trigger_;
        public string Trigger_
        {
            get { return this.trigger_; }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                    this.NotifyPropertyChanged("Trigger_");
                }
            }
        }
        #endregion
        
        #region Return_
        private string return_;
        public string Return_
        {
            get { return this.return_; }
            set
            {
                if (this.return_ != value)
                {
                    this.return_ = value;
                    this.NotifyPropertyChanged("Return_");
                }
            }
        }
        #endregion
        
        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
                }
            }
        }
        #endregion
        
        #region IsExpired_
        private string isExpired_;
        public string IsExpired_
        {
            get { return this.isExpired_; }
            set
            {
                if (this.isExpired_ != value)
                {
                    this.isExpired_ = value;
                    this.NotifyPropertyChanged("IsExpired_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger");
                xmlWriter.WriteElementString("excel_type" , "autoCallConstReturnTrigger");
                xmlWriter.WriteStartElement("autoCallConstReturnTrigger");
                    xmlWriter.WriteElementString("dateOrder" , this.dateOrder_);
                    
                    fixingDateInfoViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("trigger" , this.trigger_);
                    
                    xmlWriter.WriteElementString("return" , this.return_);
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
                    xmlWriter.WriteElementString("isExpired" , this.isExpired_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new AutoCallConstReturnTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.AutoCallConstReturnTrigger serial_AutoCallConstReturnTrigger = serial_EventTrigger.AutoCallConstReturnTrigger_;
        
            this.dateOrder_ = serial_AutoCallConstReturnTrigger.DateOrder_.ValueStr;
            
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_AutoCallConstReturnTrigger.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Excel_type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_AutoCallConstReturnTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.trigger_ = serial_AutoCallConstReturnTrigger.Trigger_.ValueStr;
            
            this.return_ = serial_AutoCallConstReturnTrigger.Return_.ValueStr;
            
            this.averageDays_ = serial_AutoCallConstReturnTrigger.AverageDays_.ValueStr;
            
            this.isExpired_ = serial_AutoCallConstReturnTrigger.IsExpired_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}


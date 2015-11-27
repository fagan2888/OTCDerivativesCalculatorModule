using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class VanillaCouponTriggerViewModel : EventTriggerViewModel
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
        
        public VanillaCouponTriggerViewModel() { }
        
        #region Gearing_
        private string gearing_;
        public string Gearing_
        {
            get { return this.gearing_; }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                    this.NotifyPropertyChanged("Gearing_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
                }
            }
        }
        #endregion
        
        #region ReturnCalculationViewModel_
        private ReturnCalculationViewModel returnCalculationViewModel_;
        public ReturnCalculationViewModel ReturnCalculationViewModel_
        {
            get { return this.returnCalculationViewModel_; }
            set
            {
                if (this.returnCalculationViewModel_ != value)
                {
                    this.returnCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationViewModel_");
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
                xmlWriter.WriteElementString("type" , "vanillaCouponTrigger");
                xmlWriter.WriteStartElement("vanillaCouponTrigger");
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                    returnCalculationViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new VanillaCouponTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.VanillaCouponTrigger serial_VanillaCouponTrigger = serial_EventTrigger.VanillaCouponTrigger_;
        
            this.gearing_ = serial_VanillaCouponTrigger.Gearing_.ValueStr;
            
            this.spread_ = serial_VanillaCouponTrigger.Spread_.ValueStr;
            
            FpmlSerializedCSharp.ReturnCalculation serial_returnCalculation = serial_VanillaCouponTrigger.ReturnCalculation_;
            string returnCalculationtype = serial_returnCalculation.Excel_type_.ValueStr;
            this.returnCalculationViewModel_ = ReturnCalculationViewModel.CreateReturnCalculation(returnCalculationtype);
            this.returnCalculationViewModel_.setFromSerial(serial_returnCalculation);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_VanillaCouponTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.isExpired_ = serial_VanillaCouponTrigger.IsExpired_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}


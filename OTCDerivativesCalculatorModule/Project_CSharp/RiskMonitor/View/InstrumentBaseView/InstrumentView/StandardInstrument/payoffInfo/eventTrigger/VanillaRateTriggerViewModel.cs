using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class VanillaRateTriggerViewModel : EventTriggerViewModel
    {
        public VanillaRateTriggerViewModel() { }
        
    
        #region DayCounter_
        private string dayCounter_;
        public string DayCounter_
        {
            get { return this.dayCounter_; }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                    this.NotifyPropertyChanged("DayCounter_");
                }
            }
        }
        #endregion
        
        #region CalculationStartDate_
        private string calculationStartDate_;
        public string CalculationStartDate_
        {
            get { return this.calculationStartDate_; }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                    this.NotifyPropertyChanged("CalculationStartDate_");
                }
            }
        }
        #endregion
        
        #region CalculationEndDate_
        private string calculationEndDate_;
        public string CalculationEndDate_
        {
            get { return this.calculationEndDate_; }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                    this.NotifyPropertyChanged("CalculationEndDate_");
                }
            }
        }
        #endregion
        
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
        
        #region ReferenceCalculationInfoViewModel_
        private ReferenceCalculationInfoViewModel referenceCalculationInfoViewModel_;
        public ReferenceCalculationInfoViewModel ReferenceCalculationInfoViewModel_
        {
            get { return this.referenceCalculationInfoViewModel_; }
            set
            {
                if (this.referenceCalculationInfoViewModel_ != value)
                {
                    this.referenceCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCalculationInfoViewModel_");
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger");
                xmlWriter.WriteElementString("type" , "vanillaRateTrigger");
                xmlWriter.WriteStartElement("vanillaRateTrigger");
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("calculationStartDate" , this.calculationStartDate_);
                    
                    xmlWriter.WriteElementString("calculationEndDate" , this.calculationEndDate_);
                    
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.VanillaRateTrigger serial_VanillaRateTrigger = serial_EventTrigger.VanillaRateTrigger_;
        
            this.dayCounter_ = serial_VanillaRateTrigger.DayCounter_.ValueStr;
            
            this.calculationStartDate_ = serial_VanillaRateTrigger.CalculationStartDate_.ValueStr;
            
            this.calculationEndDate_ = serial_VanillaRateTrigger.CalculationEndDate_.ValueStr;
            
            this.gearing_ = serial_VanillaRateTrigger.Gearing_.ValueStr;
            
            this.spread_ = serial_VanillaRateTrigger.Spread_.ValueStr;
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_VanillaRateTrigger.ReferenceCalculationInfo_;
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_VanillaRateTrigger.PayoffDateInfo_;
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
           //this.view_ = new VanillaRateTriggerView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectReferenceCalculationInfoInfo_
            //private string selectReferenceCalculationInfoInfo_;
            //public string SelectReferenceCalculationInfoInfo_
            //{
            //    get { return this.selectReferenceCalculationInfoInfo_; }
            //    set
            //    {
            //        if (this.selectReferenceCalculationInfoInfo_ != value)
            //        {
            //            this.selectReferenceCalculationInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectReferenceCalculationInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectReferenceCalculationInfoInfo(string typeStr)
            //{
            //    this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectPayoffDateInfoInfo_
            //private string selectPayoffDateInfoInfo_;
            //public string SelectPayoffDateInfoInfo_
            //{
            //    get { return this.selectPayoffDateInfoInfo_; }
            //    set
            //    {
            //        if (this.selectPayoffDateInfoInfo_ != value)
            //        {
            //            this.selectPayoffDateInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectPayoffDateInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectPayoffDateInfoInfo(string typeStr)
            //{
            //    this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}


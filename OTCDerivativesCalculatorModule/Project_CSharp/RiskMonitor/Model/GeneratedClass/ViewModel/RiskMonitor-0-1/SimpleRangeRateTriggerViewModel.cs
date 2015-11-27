using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeRateTriggerViewModel : EventTriggerViewModel
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
        
        public SimpleRangeRateTriggerViewModel() { }
        
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
        private DateTime calculationStartDate_;
        public DateTime CalculationStartDate_
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
        private DateTime calculationEndDate_;
        public DateTime CalculationEndDate_
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
        
        #region SimpleRangeEventListViewModel_
        private SimpleRangeEventListViewModel simpleRangeEventListViewModel_;
        public SimpleRangeEventListViewModel SimpleRangeEventListViewModel_
        {
            get { return this.simpleRangeEventListViewModel_; }
            set
            {
                if (this.simpleRangeEventListViewModel_ != value)
                {
                    this.simpleRangeEventListViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeEventListViewModel_");
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
                xmlWriter.WriteElementString("type" , "simpleRangeRateTrigger");
                xmlWriter.WriteStartElement("simpleRangeRateTrigger");
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("calculationStartDate" , StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    
                    xmlWriter.WriteElementString("calculationEndDate" , StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    simpleRangeEventListViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new SimpleRangeRateTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.SimpleRangeRateTrigger serial_SimpleRangeRateTrigger = serial_EventTrigger.SimpleRangeRateTrigger_;
        
            this.dayCounter_ = serial_SimpleRangeRateTrigger.DayCounter_.ValueStr;
            
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_SimpleRangeRateTrigger.CalculationStartDate_.ValueStr);
            
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_SimpleRangeRateTrigger.CalculationEndDate_.ValueStr);
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_SimpleRangeRateTrigger.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.SimpleRangeEventList serial_simpleRangeEventList = serial_SimpleRangeRateTrigger.SimpleRangeEventList_;
            string simpleRangeEventListtype = serial_simpleRangeEventList.Excel_type_.ValueStr;
            this.simpleRangeEventListViewModel_ = SimpleRangeEventListViewModel.CreateSimpleRangeEventList(simpleRangeEventListtype);
            this.simpleRangeEventListViewModel_.setFromSerial(serial_simpleRangeEventList);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_SimpleRangeRateTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}


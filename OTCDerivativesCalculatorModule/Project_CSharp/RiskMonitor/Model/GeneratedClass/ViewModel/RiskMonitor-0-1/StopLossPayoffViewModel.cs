using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StopLossPayoffViewModel : PayoffInfoViewModel
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
        
        public StopLossPayoffViewModel() { }
        
        #region EventTriggerListViewModel_
        private EventTriggerListViewModel eventTriggerListViewModel_;
        public EventTriggerListViewModel EventTriggerListViewModel_
        {
            get { return this.eventTriggerListViewModel_; }
            set
            {
                if (this.eventTriggerListViewModel_ != value)
                {
                    this.eventTriggerListViewModel_ = value;
                    this.NotifyPropertyChanged("EventTriggerListViewModel_");
                }
            }
        }
        #endregion
        
        #region BarrierInfoViewModel_
        private BarrierInfoViewModel barrierInfoViewModel_;
        public BarrierInfoViewModel BarrierInfoViewModel_
        {
            get { return this.barrierInfoViewModel_; }
            set
            {
                if (this.barrierInfoViewModel_ != value)
                {
                    this.barrierInfoViewModel_ = value;
                    this.NotifyPropertyChanged("BarrierInfoViewModel_");
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("type" , "stopLossPayoff");
                xmlWriter.WriteStartElement("stopLossPayoff");
                    eventTriggerListViewModel_.buildXml(xmlWriter);
                    
                    barrierInfoViewModel_.buildXml(xmlWriter);
                    
                    returnCalculationViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new StopLossPayoffView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.StopLossPayoff serial_StopLossPayoff = serial_PayoffInfo.StopLossPayoff_;
        
            FpmlSerializedCSharp.EventTriggerList serial_eventTriggerList = serial_StopLossPayoff.EventTriggerList_;
            string eventTriggerListtype = serial_eventTriggerList.Excel_type_.ValueStr;
            this.eventTriggerListViewModel_ = EventTriggerListViewModel.CreateEventTriggerList(eventTriggerListtype);
            this.eventTriggerListViewModel_.setFromSerial(serial_eventTriggerList);
            
            FpmlSerializedCSharp.BarrierInfo serial_barrierInfo = serial_StopLossPayoff.BarrierInfo_;
            string barrierInfotype = serial_barrierInfo.Excel_type_.ValueStr;
            this.barrierInfoViewModel_ = BarrierInfoViewModel.CreateBarrierInfo(barrierInfotype);
            this.barrierInfoViewModel_.setFromSerial(serial_barrierInfo);
            
            FpmlSerializedCSharp.ReturnCalculation serial_returnCalculation = serial_StopLossPayoff.ReturnCalculation_;
            string returnCalculationtype = serial_returnCalculation.Excel_type_.ValueStr;
            this.returnCalculationViewModel_ = ReturnCalculationViewModel.CreateReturnCalculation(returnCalculationtype);
            this.returnCalculationViewModel_.setFromSerial(serial_returnCalculation);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_StopLossPayoff.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}


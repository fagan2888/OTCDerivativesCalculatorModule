using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class AutoTerminationTriggerViewModel : IXmlData
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
        
    
        public AutoTerminationTriggerViewModel() 
        {
            this.eventCalculationInfoViewModel_ = new EventCalculationInfoViewModel();
        }
        
    
        #region EventCalculationInfoViewModel_
        private EventCalculationInfoViewModel eventCalculationInfoViewModel_;
        public EventCalculationInfoViewModel EventCalculationInfoViewModel_
        {
            get { return this.eventCalculationInfoViewModel_; }
            set
            {
                if (this.eventCalculationInfoViewModel_ != value)
                {
                    this.eventCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("EventCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ReturnCalculationInfoViewModel_
        private ReturnCalculationInfoViewModel returnCalculationInfoViewModel_;
        public ReturnCalculationInfoViewModel ReturnCalculationInfoViewModel_
        {
            get { return this.returnCalculationInfoViewModel_; }
            set
            {
                if (this.returnCalculationInfoViewModel_ != value)
                {
                    this.returnCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationInfoViewModel_");
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("autoTerminationTrigger");
                eventCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                returnCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.AutoTerminationTrigger serial_AutoTerminationTrigger = serial_Class as FpmlSerializedCSharp.AutoTerminationTrigger;
        
            FpmlSerializedCSharp.EventCalculationInfo serial_eventCalculationInfo = serial_AutoTerminationTrigger.EventCalculationInfo_;
            this.eventCalculationInfoViewModel_.setFromSerial(serial_eventCalculationInfo);
            
            FpmlSerializedCSharp.ReturnCalculationInfo serial_returnCalculationInfo = serial_AutoTerminationTrigger.ReturnCalculationInfo_;
            this.returnCalculationInfoViewModel_.setFromSerial(serial_returnCalculationInfo);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_AutoTerminationTrigger.PayoffDateInfo_;
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            //this.view_ = new AutoTerminationTriggerView();
            //this.view_.DataContext = this;
        }
        
        
    
            //#region SelectEventCalculationInfoInfo_
            //private string selectEventCalculationInfoInfo_;
            //public string SelectEventCalculationInfoInfo_
            //{
            //    get { return this.selectEventCalculationInfoInfo_; }
            //    set
            //    {
            //        if (this.selectEventCalculationInfoInfo_ != value)
            //        {
            //            this.selectEventCalculationInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectEventCalculationInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectEventCalculationInfoInfo(string typeStr)
            //{
            //    this.eventCalculationInfoViewModel_ = EventCalculationInfoViewModel.CreateEventCalculationInfo(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectReturnCalculationInfoInfo_
            //private string selectReturnCalculationInfoInfo_;
            //public string SelectReturnCalculationInfoInfo_
            //{
            //    get { return this.selectReturnCalculationInfoInfo_; }
            //    set
            //    {
            //        if (this.selectReturnCalculationInfoInfo_ != value)
            //        {
            //            this.selectReturnCalculationInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectReturnCalculationInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectReturnCalculationInfoInfo(string typeStr)
            //{
            //    this.returnCalculationInfoViewModel_ = ReturnCalculationInfoViewModel.CreateReturnCalculationInfo(typeStr);
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


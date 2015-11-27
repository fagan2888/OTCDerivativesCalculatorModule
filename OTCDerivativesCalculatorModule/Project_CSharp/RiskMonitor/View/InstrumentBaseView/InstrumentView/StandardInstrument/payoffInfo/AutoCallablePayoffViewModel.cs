using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class AutoCallablePayoffViewModel : PayoffInfoViewModel
    {
    
        public AutoCallablePayoffViewModel() { }

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

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("type" , "autoCallablePayoff");
                xmlWriter.WriteStartElement("autoCallablePayoff");

                    //eventTriggerListViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.AutoCallablePayoff serial_AutoCallablePayoff = serial_PayoffInfo.AutoCallablePayoff_;
        
            FpmlSerializedCSharp.EventTriggerList serial_eventTriggerList = serial_AutoCallablePayoff.EventTriggerList_;
            this.eventTriggerListViewModel_.setFromSerial(serial_eventTriggerList);
            
           //this.view_ = new AutoCallablePayoffView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectEventTriggerListInfo_
            //private string selectEventTriggerListInfo_;
            //public string SelectEventTriggerListInfo_
            //{
            //    get { return this.selectEventTriggerListInfo_; }
            //    set
            //    {
            //        if (this.selectEventTriggerListInfo_ != value)
            //        {
            //            this.selectEventTriggerListInfo_ = value;
            //            this.NotifyPropertyChanged("SelectEventTriggerListInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectEventTriggerListInfo(string typeStr)
            //{
            //    this.eventTriggerListViewModel_ = EventTriggerListViewModel.CreateEventTriggerList(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}


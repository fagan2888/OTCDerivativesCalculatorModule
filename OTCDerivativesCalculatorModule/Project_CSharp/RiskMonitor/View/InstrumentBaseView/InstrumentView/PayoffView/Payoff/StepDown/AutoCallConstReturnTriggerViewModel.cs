using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class AutoCallConstReturnTriggerViewModel : EventTriggerViewModel
    {
    
        public AutoCallConstReturnTriggerViewModel() 
        {
            this.type_ = "AutoCallConstReturnTrigger";
        }
    
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
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger");
                xmlWriter.WriteElementString("type" , "autoCallConstReturnTrigger");
                xmlWriter.WriteStartElement("autoCallConstReturnTrigger");
                    xmlWriter.WriteElementString("dateOrder" , this.dateOrder_);
                    
                    xmlWriter.WriteElementString("date" , this.date_);
                    
                    xmlWriter.WriteElementString("trigger" , this.trigger_);
                    
                    xmlWriter.WriteElementString("return" , this.return_);
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
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
            FpmlSerializedCSharp.AutoCallConstReturnTrigger serial_AutoCallConstReturnTrigger = serial_EventTrigger.AutoCallConstReturnTrigger_;
        
            this.dateOrder_ = serial_AutoCallConstReturnTrigger.DateOrder_.ValueStr;
            this.date_ = serial_AutoCallConstReturnTrigger.Date_.ValueStr;
            this.trigger_ = serial_AutoCallConstReturnTrigger.Trigger_.ValueStr;
            this.return_ = serial_AutoCallConstReturnTrigger.Return_.ValueStr;
            this.averageDays_ = serial_AutoCallConstReturnTrigger.AverageDays_.ValueStr;

            this.description_ = "IF DailyReturn >= " + 100 * Convert.ToDouble(this.trigger_) + "% Then " + 100 * Convert.ToDouble(this.return_) + "%";

            this.view_ = new AutoCallConstReturnTriggerView();
            this.view_.DataContext = this;
        }

        public override void descriptionUpdate()
        {
            this.description_ = "IF DailyReturn >= " + 100 * Convert.ToDouble(this.trigger_) + "% Then " + 100 * Convert.ToDouble(this.return_) + "%";
        }
    }
    
}


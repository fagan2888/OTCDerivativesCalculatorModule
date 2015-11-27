using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceEventCalViewModel : EventCalculationViewModel
    {
        
    
        public ReferenceEventCalViewModel() { }
        
    
        #region RefName_
        private string refName_;
        public string RefName_
        {
            get { return this.refName_; }
            set
            {
                if (this.refName_ != value)
                {
                    this.refName_ = value;
                    this.NotifyPropertyChanged("RefName_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventCalculation");
                xmlWriter.WriteElementString("type" , "referenceEventCal");
                xmlWriter.WriteStartElement("referenceEventCal");
                    xmlWriter.WriteElementString("refName" , this.refName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculation serial_EventCalculation = serial_Class as FpmlSerializedCSharp.EventCalculation;
            FpmlSerializedCSharp.ReferenceEventCal serial_ReferenceEventCal = serial_EventCalculation.ReferenceEventCal_;
        
            this.refName_ = serial_ReferenceEventCal.RefName_.ValueStr;
            
       //     //this.view_ = new ReferenceEventCalView();
//this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


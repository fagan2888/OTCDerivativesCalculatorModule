using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ConstNonKiTriggerViewModel : NonKiEventInfoViewModel
    {
    
        public ConstNonKiTriggerViewModel() { }
    
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
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("nonKiEventInfo");
                xmlWriter.WriteElementString("type" , "constNonKiTrigger");
                xmlWriter.WriteStartElement("constNonKiTrigger");
                    xmlWriter.WriteElementString("return" , this.return_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.NonKiEventInfo serial_NonKiEventInfo = serial_Class as FpmlSerializedCSharp.NonKiEventInfo;
            FpmlSerializedCSharp.ConstNonKiTrigger serial_ConstNonKiTrigger = serial_NonKiEventInfo.ConstNonKiTrigger_;
        
            this.return_ = serial_ConstNonKiTrigger.Return_.ValueStr;
            
            this.view_ = new ConstNonKiTriggerView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class NullVariableEventInfoViewModel : VariableEventInfoViewModel
    {
    
        public NullVariableEventInfoViewModel() { }
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("variableEventInfo");
                xmlWriter.WriteElementString("type" , "nullVariableEventInfo");
                xmlWriter.WriteStartElement("nullVariableEventInfo");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableEventInfo serial_VariableEventInfo = serial_Class as FpmlSerializedCSharp.VariableEventInfo;
            FpmlSerializedCSharp.NullVariableEventInfo serial_NullVariableEventInfo = serial_VariableEventInfo.NullVariableEventInfo_;
        
           //this.view_ = new NullVariableEventInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


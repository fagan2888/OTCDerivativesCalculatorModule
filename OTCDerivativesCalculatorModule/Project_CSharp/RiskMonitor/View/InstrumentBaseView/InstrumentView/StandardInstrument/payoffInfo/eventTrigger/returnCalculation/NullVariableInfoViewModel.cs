using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class NullVariableInfoViewModel : VariableInfoViewModel
    {
        public NullVariableInfoViewModel() { }
        
    
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("variableInfo");
                xmlWriter.WriteElementString("type" , "nullVariableInfo");
                xmlWriter.WriteStartElement("nullVariableInfo");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableInfo serial_VariableInfo = serial_Class as FpmlSerializedCSharp.VariableInfo;
            FpmlSerializedCSharp.NullVariableInfo serial_NullVariableInfo = serial_VariableInfo.NullVariableInfo_;
        
           //this.view_ = new NullVariableInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


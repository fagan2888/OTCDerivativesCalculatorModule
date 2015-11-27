using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ZeroReturnCalViewModel : ReturnCalculationViewModel
    {
        public ZeroReturnCalViewModel() { }
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("returnCalculation");
                xmlWriter.WriteElementString("type" , "zeroReturnCal");
                xmlWriter.WriteStartElement("zeroReturnCal");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            FpmlSerializedCSharp.ZeroReturnCal serial_ZeroReturnCal = serial_ReturnCalculation.ZeroReturnCal_;
        
           //this.view_ = new ZeroReturnCalView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


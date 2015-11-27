using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class NullFixingDateInfoViewModel : FixingDateInfoViewModel
    {
   
    
        public NullFixingDateInfoViewModel() { }
        
    
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("fixingDateInfo");
                xmlWriter.WriteElementString("type" , "nullFixingDateInfo");
                xmlWriter.WriteStartElement("nullFixingDateInfo");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixingDateInfo serial_FixingDateInfo = serial_Class as FpmlSerializedCSharp.FixingDateInfo;
            FpmlSerializedCSharp.NullFixingDateInfo serial_NullFixingDateInfo = serial_FixingDateInfo.NullFixingDateInfo_;
        
            ////this.view_ = new NullFixingDateInfoView();
           // this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


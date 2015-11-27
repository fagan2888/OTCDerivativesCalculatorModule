using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class GridCalculationStartViewModel : MessageBodyViewModel
    {
        public GridCalculationStartViewModel() { }
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
                xmlWriter.WriteElementString("msg_type", "gridCalculationStart");
                xmlWriter.WriteStartElement("gridCalculationStart");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        //public override Control view()
        //{
        //    Control v = new GridCalculationStartView();
        //    v.DataContext = this;
        //    return v;
        //}
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.GridCalculationStart serial_GridCalculationStart = serial_MessageBody.GridCalculationStart_;
        
        }
        
        
    
        
    
        
    
    }
    
}


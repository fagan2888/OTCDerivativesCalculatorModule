using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class MaturityNotificationViewModel : MessageBodyViewModel
    {
        public MaturityNotificationViewModel() { }
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
            xmlWriter.WriteElementString("msg_type", "maturityNotification");
                xmlWriter.WriteStartElement("maturityNotification");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        //public override Control view()
        //{
        //    Control v = new MaturityNotificationView();
        //    v.DataContext = this;
        //    return v;
        //}
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.MaturityNotification serial_MaturityNotification = serial_MessageBody.MaturityNotification_;
        
        }
        
        
    
        
    
        
    
    }
    
}


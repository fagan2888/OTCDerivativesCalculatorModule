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
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
        public GridCalculationStartViewModel() { }
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
                xmlWriter.WriteElementString("excel_type" , "gridCalculationStart");
                xmlWriter.WriteStartElement("gridCalculationStart");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new GridCalculationStartView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.GridCalculationStart serial_GridCalculationStart = serial_MessageBody.GridCalculationStart_;
        
        }
        
        
    
        
    
        
    
    }
    
}


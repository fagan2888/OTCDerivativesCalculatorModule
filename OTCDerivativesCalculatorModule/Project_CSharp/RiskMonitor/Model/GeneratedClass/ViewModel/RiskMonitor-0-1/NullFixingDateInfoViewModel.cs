using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class NullFixingDateInfoViewModel : FixingDateInfoViewModel
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
        
        public override Control view()
        {
            Control v = new NullFixingDateInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixingDateInfo serial_FixingDateInfo = serial_Class as FpmlSerializedCSharp.FixingDateInfo;
            FpmlSerializedCSharp.NullFixingDateInfo serial_NullFixingDateInfo = serial_FixingDateInfo.NullFixingDateInfo_;
        
        }
        
        
    
        
    
        
    
    }
    
}


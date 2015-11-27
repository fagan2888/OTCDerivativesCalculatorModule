using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_identityEventCalViewModel : Excel_eventCalcInfoViewModel
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
        
        public Excel_identityEventCalViewModel() { }
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("type" , "excel_identityEventCal");
                xmlWriter.WriteStartElement("excel_identityEventCal");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_identityEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_Excel_eventCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo;
            FpmlSerializedCSharp.Excel_identityEventCal serial_Excel_identityEventCal = serial_Excel_eventCalcInfo.Excel_identityEventCal_;
        
        }
        
        
    
        
    
        
    
    }
    
}


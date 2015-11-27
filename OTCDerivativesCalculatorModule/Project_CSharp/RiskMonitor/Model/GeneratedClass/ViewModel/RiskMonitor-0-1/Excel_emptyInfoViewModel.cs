using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_emptyInfoViewModel : Excel_issueInfoViewModel
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
        
        public Excel_emptyInfoViewModel() { }
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_issueInfo");
                xmlWriter.WriteElementString("type" , "excel_emptyInfo");
                xmlWriter.WriteStartElement("excel_emptyInfo");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_emptyInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            FpmlSerializedCSharp.Excel_emptyInfo serial_Excel_emptyInfo = serial_Excel_issueInfo.Excel_emptyInfo_;
        
        }
        
        
    
        
    
        
    
    }
    
}


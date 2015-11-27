using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_structuredBond_floatingAccrualViewModel : Excel_structuredBond_subtypeViewModel
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
        
        public Excel_structuredBond_floatingAccrualViewModel() { }
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_structuredBond_subtype");
                xmlWriter.WriteElementString("type" , "excel_structuredBond_floatingAccrual");
                xmlWriter.WriteStartElement("excel_structuredBond_floatingAccrual");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_structuredBond_floatingAccrualView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_structuredBond_subtype serial_Excel_structuredBond_subtype = serial_Class as FpmlSerializedCSharp.Excel_structuredBond_subtype;
            FpmlSerializedCSharp.Excel_structuredBond_floatingAccrual serial_Excel_structuredBond_floatingAccrual = serial_Excel_structuredBond_subtype.Excel_structuredBond_floatingAccrual_;
        
        }
        
        
    
        
    
        
    
    }
    
}


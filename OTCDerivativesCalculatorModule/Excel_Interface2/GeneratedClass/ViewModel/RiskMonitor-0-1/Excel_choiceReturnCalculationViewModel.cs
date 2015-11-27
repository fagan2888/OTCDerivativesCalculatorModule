using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_choiceReturnCalculationViewModel : Excel_scheduleViewModel
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
        
        public Excel_choiceReturnCalculationViewModel() { }
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_schedule");
                xmlWriter.WriteElementString("excel_type" , "excel_choiceReturnCalculation");
                xmlWriter.WriteStartElement("excel_choiceReturnCalculation");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_choiceReturnCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_schedule serial_Excel_schedule = serial_Class as FpmlSerializedCSharp.Excel_schedule;
            FpmlSerializedCSharp.Excel_choiceReturnCalculation serial_Excel_choiceReturnCalculation = serial_Excel_schedule.Excel_choiceReturnCalculation_;
        
        }
        
        
    
        
    
        
    
    }
    
}


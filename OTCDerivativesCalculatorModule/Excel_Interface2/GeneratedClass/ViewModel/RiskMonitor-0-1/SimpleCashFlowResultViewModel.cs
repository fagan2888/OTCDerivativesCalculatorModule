using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleCashFlowResultViewModel : CashFlowInfoResultViewModel
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
        
        public SimpleCashFlowResultViewModel() { }
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("cashFlowInfoResult");
                xmlWriter.WriteElementString("excel_type" , "simpleCashFlowResult");
                xmlWriter.WriteStartElement("simpleCashFlowResult");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new SimpleCashFlowResultView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CashFlowInfoResult serial_CashFlowInfoResult = serial_Class as FpmlSerializedCSharp.CashFlowInfoResult;
            FpmlSerializedCSharp.SimpleCashFlowResult serial_SimpleCashFlowResult = serial_CashFlowInfoResult.SimpleCashFlowResult_;
        
        }
        
        
    
        
    
        
    
    }
    
}


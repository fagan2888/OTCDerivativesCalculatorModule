using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CalculationAgentViewModel : IXmlData
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
        
        public CalculationAgentViewModel() { }
        
        #region CalculationAgentParty_
        private string calculationAgentParty_;
        public string CalculationAgentParty_
        {
            get { return this.calculationAgentParty_; }
            set
            {
                if (this.calculationAgentParty_ != value)
                {
                    this.calculationAgentParty_ = value;
                    this.NotifyPropertyChanged("CalculationAgentParty_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "calculationAgent");
                xmlWriter.WriteStartElement("calculationAgent");
                    xmlWriter.WriteElementString("calculationAgentParty" , this.calculationAgentParty_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CalculationAgentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CalculationAgent serial_CalculationAgent = serial_Class as FpmlSerializedCSharp.CalculationAgent;
        
            this.calculationAgentParty_ = serial_CalculationAgent.CalculationAgentParty_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ConstReturnCalViewModel : ReturnCalculationViewModel
    {
        public ConstReturnCalViewModel() { }
    
        #region ConstReturn_
        private string constReturn_;
        public string ConstReturn_
        {
            get { return this.constReturn_; }
            set
            {
                if (this.constReturn_ != value)
                {
                    this.constReturn_ = value;
                    this.NotifyPropertyChanged("ConstReturn_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("returnCalculation");
                xmlWriter.WriteElementString("type" , "constReturnCal");
                xmlWriter.WriteStartElement("constReturnCal");
                    xmlWriter.WriteElementString("constReturn" , this.constReturn_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            FpmlSerializedCSharp.ConstReturnCal serial_ConstReturnCal = serial_ReturnCalculation.ConstReturnCal_;
        
            this.constReturn_ = serial_ConstReturnCal.ConstReturn_.ValueStr;
            
           //this.view_ = new ConstReturnCalView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


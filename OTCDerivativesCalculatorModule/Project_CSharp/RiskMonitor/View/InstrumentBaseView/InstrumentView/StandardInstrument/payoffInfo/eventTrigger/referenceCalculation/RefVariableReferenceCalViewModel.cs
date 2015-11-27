using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class RefVariableReferenceCalViewModel : ReferenceCalculationViewModel
    {
        public RefVariableReferenceCalViewModel() { }
        
    
        #region RefName_
        private string refName_;
        public string RefName_
        {
            get { return this.refName_; }
            set
            {
                if (this.refName_ != value)
                {
                    this.refName_ = value;
                    this.NotifyPropertyChanged("RefName_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("referenceCalculation");
                xmlWriter.WriteElementString("type" , "refVariableReferenceCal");
                xmlWriter.WriteStartElement("refVariableReferenceCal");
                    xmlWriter.WriteElementString("refName" , this.refName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculation serial_ReferenceCalculation = serial_Class as FpmlSerializedCSharp.ReferenceCalculation;
            FpmlSerializedCSharp.RefVariableReferenceCal serial_RefVariableReferenceCal = serial_ReferenceCalculation.RefVariableReferenceCal_;
        
            this.refName_ = serial_RefVariableReferenceCal.RefName_.ValueStr;
            
           //this.view_ = new RefVariableReferenceCalView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


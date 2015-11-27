using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class MaximumOper1DViewModel : Operator1DViewModel
    {
        public MaximumOper1DViewModel() { }
    
        #region ConstValue_
        private string constValue_;
        public string ConstValue_
        {
            get { return this.constValue_; }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                    this.NotifyPropertyChanged("ConstValue_");
                }
            }
        }
        #endregion
        
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
            xmlWriter.WriteStartElement("operator1D");
                xmlWriter.WriteElementString("type" , "maximumOper1D");
                xmlWriter.WriteStartElement("maximumOper1D");
                    xmlWriter.WriteElementString("constValue" , this.constValue_);
                    
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
            FpmlSerializedCSharp.Operator1D serial_Operator1D = serial_Class as FpmlSerializedCSharp.Operator1D;
            FpmlSerializedCSharp.MaximumOper1D serial_MaximumOper1D = serial_Operator1D.MaximumOper1D_;
        
            this.constValue_ = serial_MaximumOper1D.ConstValue_.ValueStr;
            
            this.refName_ = serial_MaximumOper1D.RefName_.ValueStr;
            
           //this.view_ = new MaximumOper1DView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


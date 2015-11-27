using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class OverWriteVariableEventInfoViewModel : VariableEventInfoViewModel
    {
    
        public OverWriteVariableEventInfoViewModel() { }
        
    
        #region UsingRefVarName_
        private string usingRefVarName_;
        public string UsingRefVarName_
        {
            get { return this.usingRefVarName_; }
            set
            {
                if (this.usingRefVarName_ != value)
                {
                    this.usingRefVarName_ = value;
                    this.NotifyPropertyChanged("UsingRefVarName_");
                }
            }
        }
        #endregion
        
        #region RefInstanceName_
        private string refInstanceName_;
        public string RefInstanceName_
        {
            get { return this.refInstanceName_; }
            set
            {
                if (this.refInstanceName_ != value)
                {
                    this.refInstanceName_ = value;
                    this.NotifyPropertyChanged("RefInstanceName_");
                }
            }
        }
        #endregion
        
        #region InitialTF_
        private string initialTF_;
        public string InitialTF_
        {
            get { return this.initialTF_; }
            set
            {
                if (this.initialTF_ != value)
                {
                    this.initialTF_ = value;
                    this.NotifyPropertyChanged("InitialTF_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("variableEventInfo");
                xmlWriter.WriteElementString("type" , "overWriteVariableEventInfo");
                xmlWriter.WriteStartElement("overWriteVariableEventInfo");
                    xmlWriter.WriteElementString("usingRefVarName" , this.usingRefVarName_);
                    
                    xmlWriter.WriteElementString("refInstanceName" , this.refInstanceName_);
                    
                    xmlWriter.WriteElementString("initialTF" , this.initialTF_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableEventInfo serial_VariableEventInfo = serial_Class as FpmlSerializedCSharp.VariableEventInfo;
            FpmlSerializedCSharp.OverWriteVariableEventInfo serial_OverWriteVariableEventInfo = serial_VariableEventInfo.OverWriteVariableEventInfo_;
        
            this.usingRefVarName_ = serial_OverWriteVariableEventInfo.UsingRefVarName_.ValueStr;
            
            this.refInstanceName_ = serial_OverWriteVariableEventInfo.RefInstanceName_.ValueStr;
            
            this.initialTF_ = serial_OverWriteVariableEventInfo.InitialTF_.ValueStr;
            
           //this.view_ = new OverWriteVariableEventInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


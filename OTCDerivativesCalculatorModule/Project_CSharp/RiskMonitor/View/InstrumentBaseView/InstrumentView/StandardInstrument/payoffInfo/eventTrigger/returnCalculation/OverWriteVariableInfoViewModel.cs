using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class OverWriteVariableInfoViewModel : VariableInfoViewModel
    {
    
        public OverWriteVariableInfoViewModel() { }
        
    
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
        
        #region Save_
        private string save_;
        public string Save_
        {
            get { return this.save_; }
            set
            {
                if (this.save_ != value)
                {
                    this.save_ = value;
                    this.NotifyPropertyChanged("Save_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("variableInfo");
                xmlWriter.WriteElementString("type" , "overWriteVariableInfo");
                xmlWriter.WriteStartElement("overWriteVariableInfo");
                    xmlWriter.WriteElementString("usingRefVarName" , this.usingRefVarName_);
                    
                    xmlWriter.WriteElementString("refInstanceName" , this.refInstanceName_);
                    
                    xmlWriter.WriteElementString("save" , this.save_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableInfo serial_VariableInfo = serial_Class as FpmlSerializedCSharp.VariableInfo;
            FpmlSerializedCSharp.OverWriteVariableInfo serial_OverWriteVariableInfo = serial_VariableInfo.OverWriteVariableInfo_;
        
            this.usingRefVarName_ = serial_OverWriteVariableInfo.UsingRefVarName_.ValueStr;
            
            this.refInstanceName_ = serial_OverWriteVariableInfo.RefInstanceName_.ValueStr;
            
            this.save_ = serial_OverWriteVariableInfo.Save_.ValueStr;
            
           //this.view_ = new OverWriteVariableInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}


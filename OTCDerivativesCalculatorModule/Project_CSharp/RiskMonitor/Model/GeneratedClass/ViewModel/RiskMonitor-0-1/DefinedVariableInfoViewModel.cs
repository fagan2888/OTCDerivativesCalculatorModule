using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DefinedVariableInfoViewModel : VariableInfoViewModel
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
        
        public DefinedVariableInfoViewModel() { }
        
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("variableInfo");
                xmlWriter.WriteElementString("type" , "definedVariableInfo");
                xmlWriter.WriteStartElement("definedVariableInfo");
                    xmlWriter.WriteElementString("refInstanceName" , this.refInstanceName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new DefinedVariableInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableInfo serial_VariableInfo = serial_Class as FpmlSerializedCSharp.VariableInfo;
            FpmlSerializedCSharp.DefinedVariableInfo serial_DefinedVariableInfo = serial_VariableInfo.DefinedVariableInfo_;
        
            this.refInstanceName_ = serial_DefinedVariableInfo.RefInstanceName_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}


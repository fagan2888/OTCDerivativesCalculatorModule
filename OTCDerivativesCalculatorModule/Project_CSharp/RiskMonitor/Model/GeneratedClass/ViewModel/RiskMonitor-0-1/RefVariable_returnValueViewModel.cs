using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RefVariable_returnValueViewModel : IXmlData
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
        
        public RefVariable_returnValueViewModel() { }
        
        #region VariableInfoViewModel_
        private VariableInfoViewModel variableInfoViewModel_;
        public VariableInfoViewModel VariableInfoViewModel_
        {
            get { return this.variableInfoViewModel_; }
            set
            {
                if (this.variableInfoViewModel_ != value)
                {
                    this.variableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("VariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "refVariable_returnValue");
                xmlWriter.WriteStartElement("refVariable_returnValue");
                    variableInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RefVariable_returnValueView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RefVariable_returnValue serial_RefVariable_returnValue = serial_Class as FpmlSerializedCSharp.RefVariable_returnValue;
        
            FpmlSerializedCSharp.VariableInfo serial_variableInfo = serial_RefVariable_returnValue.VariableInfo_;
            string variableInfotype = serial_variableInfo.Excel_type_.ValueStr;
            this.variableInfoViewModel_ = VariableInfoViewModel.CreateVariableInfo(variableInfotype);
            this.variableInfoViewModel_.setFromSerial(serial_variableInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


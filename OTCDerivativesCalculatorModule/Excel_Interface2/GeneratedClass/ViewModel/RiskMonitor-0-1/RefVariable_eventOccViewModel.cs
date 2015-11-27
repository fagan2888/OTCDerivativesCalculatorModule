using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RefVariable_eventOccViewModel : IXmlData
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
        
        public RefVariable_eventOccViewModel() { }
        
        #region VariableEventInfoViewModel_
        private VariableEventInfoViewModel variableEventInfoViewModel_;
        public VariableEventInfoViewModel VariableEventInfoViewModel_
        {
            get { return this.variableEventInfoViewModel_; }
            set
            {
                if (this.variableEventInfoViewModel_ != value)
                {
                    this.variableEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("VariableEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "refVariable_eventOcc");
                xmlWriter.WriteStartElement("refVariable_eventOcc");
                    variableEventInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RefVariable_eventOccView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RefVariable_eventOcc serial_RefVariable_eventOcc = serial_Class as FpmlSerializedCSharp.RefVariable_eventOcc;
        
            FpmlSerializedCSharp.VariableEventInfo serial_variableEventInfo = serial_RefVariable_eventOcc.VariableEventInfo_;
            string variableEventInfotype = serial_variableEventInfo.Excel_type_.ValueStr;
            this.variableEventInfoViewModel_ = VariableEventInfoViewModel.CreateVariableEventInfo(variableEventInfotype);
            this.variableEventInfoViewModel_.setFromSerial(serial_variableEventInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


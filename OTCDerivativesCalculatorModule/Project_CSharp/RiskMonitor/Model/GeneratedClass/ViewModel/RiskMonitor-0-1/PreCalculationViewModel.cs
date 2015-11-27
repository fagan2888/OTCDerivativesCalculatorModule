using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PreCalculationViewModel : IXmlData
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
        
        public PreCalculationViewModel() { }
        
        #region VariableCalListViewModel_
        private VariableCalListViewModel variableCalListViewModel_;
        public VariableCalListViewModel VariableCalListViewModel_
        {
            get { return this.variableCalListViewModel_; }
            set
            {
                if (this.variableCalListViewModel_ != value)
                {
                    this.variableCalListViewModel_ = value;
                    this.NotifyPropertyChanged("VariableCalListViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "preCalculation");
                xmlWriter.WriteStartElement("preCalculation");
                    variableCalListViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new PreCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PreCalculation serial_PreCalculation = serial_Class as FpmlSerializedCSharp.PreCalculation;
        
            FpmlSerializedCSharp.VariableCalList serial_variableCalList = serial_PreCalculation.VariableCalList_;
            string variableCalListtype = serial_variableCalList.Excel_type_.ValueStr;
            this.variableCalListViewModel_ = VariableCalListViewModel.CreateVariableCalList(variableCalListtype);
            this.variableCalListViewModel_.setFromSerial(serial_variableCalList);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


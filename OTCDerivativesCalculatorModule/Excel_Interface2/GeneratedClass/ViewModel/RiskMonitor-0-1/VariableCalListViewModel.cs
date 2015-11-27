using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class VariableCalListViewModel : IXmlData
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
        
        public VariableCalListViewModel() { }
        
        #region VariableCalculationViewModel_
        private VariableCalculationViewModel variableCalculationViewModel_;
        public VariableCalculationViewModel VariableCalculationViewModel_
        {
            get { return this.variableCalculationViewModel_; }
            set
            {
                if (this.variableCalculationViewModel_ != value)
                {
                    this.variableCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("VariableCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "variableCalList");
                xmlWriter.WriteStartElement("variableCalList");
                    variableCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new VariableCalListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableCalList serial_VariableCalList = serial_Class as FpmlSerializedCSharp.VariableCalList;
        
            FpmlSerializedCSharp.VariableCalculation serial_variableCalculation = serial_VariableCalList.VariableCalculation_;
            string variableCalculationtype = serial_variableCalculation.Excel_type_.ValueStr;
            this.variableCalculationViewModel_ = VariableCalculationViewModel.CreateVariableCalculation(variableCalculationtype);
            this.variableCalculationViewModel_.setFromSerial(serial_variableCalculation);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


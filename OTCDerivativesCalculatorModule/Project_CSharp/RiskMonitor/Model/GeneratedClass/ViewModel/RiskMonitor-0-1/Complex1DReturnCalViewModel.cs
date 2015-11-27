using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Complex1DReturnCalViewModel : ReturnCalculationViewModel
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
        
        public Complex1DReturnCalViewModel() { }
        
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("returnCalculation");
                xmlWriter.WriteElementString("type" , "complex1DReturnCal");
                xmlWriter.WriteStartElement("complex1DReturnCal");
                    variableCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Complex1DReturnCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            FpmlSerializedCSharp.Complex1DReturnCal serial_Complex1DReturnCal = serial_ReturnCalculation.Complex1DReturnCal_;
        
            FpmlSerializedCSharp.VariableCalculation serial_variableCalculation = serial_Complex1DReturnCal.VariableCalculation_;
            string variableCalculationtype = serial_variableCalculation.Excel_type_.ValueStr;
            this.variableCalculationViewModel_ = VariableCalculationViewModel.CreateVariableCalculation(variableCalculationtype);
            this.variableCalculationViewModel_.setFromSerial(serial_variableCalculation);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


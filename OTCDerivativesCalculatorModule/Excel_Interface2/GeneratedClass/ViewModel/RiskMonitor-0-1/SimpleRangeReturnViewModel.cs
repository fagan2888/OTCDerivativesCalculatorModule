using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeReturnViewModel : IXmlData
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
        
        public SimpleRangeReturnViewModel() { }
        
        #region SimpleRangeEventCalViewModel_
        private SimpleRangeEventCalViewModel simpleRangeEventCalViewModel_;
        public SimpleRangeEventCalViewModel SimpleRangeEventCalViewModel_
        {
            get { return this.simpleRangeEventCalViewModel_; }
            set
            {
                if (this.simpleRangeEventCalViewModel_ != value)
                {
                    this.simpleRangeEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region ReturnCalculationViewModel_
        private ReturnCalculationViewModel returnCalculationViewModel_;
        public ReturnCalculationViewModel ReturnCalculationViewModel_
        {
            get { return this.returnCalculationViewModel_; }
            set
            {
                if (this.returnCalculationViewModel_ != value)
                {
                    this.returnCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "simpleRangeReturn");
                xmlWriter.WriteStartElement("simpleRangeReturn");
                    simpleRangeEventCalViewModel_.buildXml(xmlWriter);
                    
                    returnCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new SimpleRangeReturnView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.SimpleRangeReturn serial_SimpleRangeReturn = serial_Class as FpmlSerializedCSharp.SimpleRangeReturn;
        
            FpmlSerializedCSharp.SimpleRangeEventCal serial_simpleRangeEventCal = serial_SimpleRangeReturn.SimpleRangeEventCal_;
            string simpleRangeEventCaltype = serial_simpleRangeEventCal.Excel_type_.ValueStr;
            this.simpleRangeEventCalViewModel_ = SimpleRangeEventCalViewModel.CreateSimpleRangeEventCal(simpleRangeEventCaltype);
            this.simpleRangeEventCalViewModel_.setFromSerial(serial_simpleRangeEventCal);
            
            FpmlSerializedCSharp.ReturnCalculation serial_returnCalculation = serial_SimpleRangeReturn.ReturnCalculation_;
            string returnCalculationtype = serial_returnCalculation.Excel_type_.ValueStr;
            this.returnCalculationViewModel_ = ReturnCalculationViewModel.CreateReturnCalculation(returnCalculationtype);
            this.returnCalculationViewModel_.setFromSerial(serial_returnCalculation);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}


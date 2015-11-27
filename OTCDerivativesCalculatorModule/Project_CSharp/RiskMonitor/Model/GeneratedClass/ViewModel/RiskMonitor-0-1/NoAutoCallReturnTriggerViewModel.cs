using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class NoAutoCallReturnTriggerViewModel : IXmlData
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
        
        public NoAutoCallReturnTriggerViewModel() { }
        
        #region PayoffDateInfoViewModel_
        private PayoffDateInfoViewModel payoffDateInfoViewModel_;
        public PayoffDateInfoViewModel PayoffDateInfoViewModel_
        {
            get { return this.payoffDateInfoViewModel_; }
            set
            {
                if (this.payoffDateInfoViewModel_ != value)
                {
                    this.payoffDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffDateInfoViewModel_");
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
                xmlWriter.WriteElementString("type" , "noAutoCallReturnTrigger");
                xmlWriter.WriteStartElement("noAutoCallReturnTrigger");
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new NoAutoCallReturnTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.NoAutoCallReturnTrigger serial_NoAutoCallReturnTrigger = serial_Class as FpmlSerializedCSharp.NoAutoCallReturnTrigger;
        
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_NoAutoCallReturnTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            FpmlSerializedCSharp.ReturnCalculation serial_returnCalculation = serial_NoAutoCallReturnTrigger.ReturnCalculation_;
            string returnCalculationtype = serial_returnCalculation.Excel_type_.ValueStr;
            this.returnCalculationViewModel_ = ReturnCalculationViewModel.CreateReturnCalculation(returnCalculationtype);
            this.returnCalculationViewModel_.setFromSerial(serial_returnCalculation);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}


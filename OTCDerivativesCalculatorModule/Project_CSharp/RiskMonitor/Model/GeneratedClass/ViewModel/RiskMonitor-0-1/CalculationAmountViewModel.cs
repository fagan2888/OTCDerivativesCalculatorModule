using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CalculationAmountViewModel : IXmlData
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
        
        public CalculationAmountViewModel() { }
        
        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion
        
        #region Amount_
        private string amount_;
        public string Amount_
        {
            get { return this.amount_; }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                    this.NotifyPropertyChanged("Amount_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "calculationAmount");
                xmlWriter.WriteStartElement("calculationAmount");
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("amount" , this.amount_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CalculationAmountView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CalculationAmount serial_CalculationAmount = serial_Class as FpmlSerializedCSharp.CalculationAmount;
        
            this.currency_ = serial_CalculationAmount.Currency_.ValueStr;
            
            this.amount_ = serial_CalculationAmount.Amount_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}


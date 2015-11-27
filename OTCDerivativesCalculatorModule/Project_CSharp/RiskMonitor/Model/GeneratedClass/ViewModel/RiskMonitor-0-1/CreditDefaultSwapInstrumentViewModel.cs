using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CreditDefaultSwapInstrumentViewModel : IXmlData
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
        
        public CreditDefaultSwapInstrumentViewModel() { }
        
        #region CreditDefaultSwapViewModel_
        private CreditDefaultSwapViewModel creditDefaultSwapViewModel_;
        public CreditDefaultSwapViewModel CreditDefaultSwapViewModel_
        {
            get { return this.creditDefaultSwapViewModel_; }
            set
            {
                if (this.creditDefaultSwapViewModel_ != value)
                {
                    this.creditDefaultSwapViewModel_ = value;
                    this.NotifyPropertyChanged("CreditDefaultSwapViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "creditDefaultSwapInstrument");
                xmlWriter.WriteStartElement("creditDefaultSwapInstrument");
                    creditDefaultSwapViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CreditDefaultSwapInstrumentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CreditDefaultSwapInstrument serial_CreditDefaultSwapInstrument = serial_Class as FpmlSerializedCSharp.CreditDefaultSwapInstrument;
        
            FpmlSerializedCSharp.CreditDefaultSwap serial_creditDefaultSwap = serial_CreditDefaultSwapInstrument.CreditDefaultSwap_;
            string creditDefaultSwaptype = serial_creditDefaultSwap.Excel_type_.ValueStr;
            this.creditDefaultSwapViewModel_ = CreditDefaultSwapViewModel.CreateCreditDefaultSwap(creditDefaultSwaptype);
            this.creditDefaultSwapViewModel_.setFromSerial(serial_creditDefaultSwap);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


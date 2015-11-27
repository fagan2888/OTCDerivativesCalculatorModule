using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RecieveSwapPart_AViewModel : IXmlData
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
        
        public RecieveSwapPart_AViewModel() { }
        
        #region PayoffInfoViewModel_
        private PayoffInfoViewModel payoffInfoViewModel_;
        public PayoffInfoViewModel PayoffInfoViewModel_
        {
            get { return this.payoffInfoViewModel_; }
            set
            {
                if (this.payoffInfoViewModel_ != value)
                {
                    this.payoffInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "recieveSwapPart_A");
                xmlWriter.WriteStartElement("recieveSwapPart_A");
                    payoffInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RecieveSwapPart_AView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RecieveSwapPart_A serial_RecieveSwapPart_A = serial_Class as FpmlSerializedCSharp.RecieveSwapPart_A;
        
            FpmlSerializedCSharp.PayoffInfo serial_payoffInfo = serial_RecieveSwapPart_A.PayoffInfo_;
            string payoffInfotype = serial_payoffInfo.Excel_type_.ValueStr;
            this.payoffInfoViewModel_ = PayoffInfoViewModel.CreatePayoffInfo(payoffInfotype);
            this.payoffInfoViewModel_.setFromSerial(serial_payoffInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CouponPartViewModel : IXmlData
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
        
        public CouponPartViewModel() { }
        
        #region PayRecieve_
        private string payRecieve_;
        public string PayRecieve_
        {
            get { return this.payRecieve_; }
            set
            {
                if (this.payRecieve_ != value)
                {
                    this.payRecieve_ = value;
                    this.NotifyPropertyChanged("PayRecieve_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "couponPart");
                xmlWriter.WriteStartElement("couponPart");
                    xmlWriter.WriteElementString("payRecieve" , this.payRecieve_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CouponPartView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponPart serial_CouponPart = serial_Class as FpmlSerializedCSharp.CouponPart;
        
            this.payRecieve_ = serial_CouponPart.PayRecieve_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}


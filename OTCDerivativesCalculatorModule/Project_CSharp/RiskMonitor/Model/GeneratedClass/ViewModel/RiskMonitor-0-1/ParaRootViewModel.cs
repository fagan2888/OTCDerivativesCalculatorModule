using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ParaRootViewModel : IXmlData
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
        
        public ParaRootViewModel() { }
        
        #region PricingViewModel_
        private PricingViewModel pricingViewModel_;
        public PricingViewModel PricingViewModel_
        {
            get { return this.pricingViewModel_; }
            set
            {
                if (this.pricingViewModel_ != value)
                {
                    this.pricingViewModel_ = value;
                    this.NotifyPropertyChanged("PricingViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "paraRoot");
                xmlWriter.WriteStartElement("paraRoot");
                    pricingViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ParaRootView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ParaRoot serial_ParaRoot = serial_Class as FpmlSerializedCSharp.ParaRoot;
        
            FpmlSerializedCSharp.Pricing serial_pricing = serial_ParaRoot.Pricing_;
            string pricingtype = serial_pricing.Excel_type_.ValueStr;
            this.pricingViewModel_ = PricingViewModel.CreatePricing(pricingtype);
            this.pricingViewModel_.setFromSerial(serial_pricing);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}


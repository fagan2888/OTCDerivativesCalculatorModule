using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ProductInnerXmlViewModel : IXmlData
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
        
        public ProductInnerXmlViewModel() { }
        
        #region InstrumentViewModel_
        private InstrumentViewModel instrumentViewModel_;
        public InstrumentViewModel InstrumentViewModel_
        {
            get { return this.instrumentViewModel_; }
            set
            {
                if (this.instrumentViewModel_ != value)
                {
                    this.instrumentViewModel_ = value;
                    this.NotifyPropertyChanged("InstrumentViewModel_");
                }
            }
        }
        #endregion
        
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
        
        #region HisoryDataViewModel_
        private HisoryDataViewModel hisoryDataViewModel_;
        public HisoryDataViewModel HisoryDataViewModel_
        {
            get { return this.hisoryDataViewModel_; }
            set
            {
                if (this.hisoryDataViewModel_ != value)
                {
                    this.hisoryDataViewModel_ = value;
                    this.NotifyPropertyChanged("HisoryDataViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "productInnerXml");
                xmlWriter.WriteStartElement("productInnerXml");
                    instrumentViewModel_.buildXml(xmlWriter);
                    
                    pricingViewModel_.buildXml(xmlWriter);
                    
                    hisoryDataViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ProductInnerXmlView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ProductInnerXml serial_ProductInnerXml = serial_Class as FpmlSerializedCSharp.ProductInnerXml;
        
            FpmlSerializedCSharp.Instrument serial_instrument = serial_ProductInnerXml.Instrument_;
            string instrumenttype = serial_instrument.Excel_type_.ValueStr;
            this.instrumentViewModel_ = InstrumentViewModel.CreateInstrument(instrumenttype);
            this.instrumentViewModel_.setFromSerial(serial_instrument);
            
            FpmlSerializedCSharp.Pricing serial_pricing = serial_ProductInnerXml.Pricing_;
            string pricingtype = serial_pricing.Excel_type_.ValueStr;
            this.pricingViewModel_ = PricingViewModel.CreatePricing(pricingtype);
            this.pricingViewModel_.setFromSerial(serial_pricing);
            
            FpmlSerializedCSharp.HisoryData serial_hisoryData = serial_ProductInnerXml.HisoryData_;
            string hisoryDatatype = serial_hisoryData.Excel_type_.ValueStr;
            this.hisoryDataViewModel_ = HisoryDataViewModel.CreateHisoryData(hisoryDatatype);
            this.hisoryDataViewModel_.setFromSerial(serial_hisoryData);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ProductInnerXml : ISerialized
    {
        public ProductInnerXml() { }
        public ProductInnerXml(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode instrumentNode = xmlNode.SelectSingleNode("instrument");
            
            if (instrumentNode != null)
            {
                if (instrumentNode.Attributes["href"] != null || instrumentNode.Attributes["id"] != null) 
                {
                    if (instrumentNode.Attributes["id"] != null) 
                    {
                        instrumentIDRef_ = instrumentNode.Attributes["id"].Value;
                        Instrument ob = new Instrument(instrumentNode);
                        IDManager.SetID(instrumentIDRef_, ob);
                    }
                    else if (instrumentNode.Attributes["href"] != null)
                    {
                        instrumentIDRef_ = instrumentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instrument_ = new Instrument(instrumentNode);
                    }
                }
                else
                {
                    instrument_ = new Instrument(instrumentNode);
                }
            }
            
        
            XmlNode pricingNode = xmlNode.SelectSingleNode("pricing");
            
            if (pricingNode != null)
            {
                if (pricingNode.Attributes["href"] != null || pricingNode.Attributes["id"] != null) 
                {
                    if (pricingNode.Attributes["id"] != null) 
                    {
                        pricingIDRef_ = pricingNode.Attributes["id"].Value;
                        Pricing ob = new Pricing(pricingNode);
                        IDManager.SetID(pricingIDRef_, ob);
                    }
                    else if (pricingNode.Attributes["href"] != null)
                    {
                        pricingIDRef_ = pricingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricing_ = new Pricing(pricingNode);
                    }
                }
                else
                {
                    pricing_ = new Pricing(pricingNode);
                }
            }
            
        
            XmlNode hisoryDataNode = xmlNode.SelectSingleNode("hisoryData");
            
            if (hisoryDataNode != null)
            {
                if (hisoryDataNode.Attributes["href"] != null || hisoryDataNode.Attributes["id"] != null) 
                {
                    if (hisoryDataNode.Attributes["id"] != null) 
                    {
                        hisoryDataIDRef_ = hisoryDataNode.Attributes["id"].Value;
                        HisoryData ob = new HisoryData(hisoryDataNode);
                        IDManager.SetID(hisoryDataIDRef_, ob);
                    }
                    else if (hisoryDataNode.Attributes["href"] != null)
                    {
                        hisoryDataIDRef_ = hisoryDataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hisoryData_ = new HisoryData(hisoryDataNode);
                    }
                }
                else
                {
                    hisoryData_ = new HisoryData(hisoryDataNode);
                }
            }
            
        
        }
        
    
        #region Instrument_
        private Instrument instrument_;
        public Instrument Instrument_
        {
            get
            {
                if (this.instrument_ != null)
                {
                    return this.instrument_; 
                }
                else if (this.instrumentIDRef_ != null)
                {
                    instrument_ = IDManager.getID(instrumentIDRef_) as Instrument;
                    return this.instrument_; 
                }
                else
                {
                    throw new Exception( "instrument_Node no exist!");
                }
            }
            set
            {
                if (this.instrument_ != value)
                {
                    this.instrument_ = value;
                }
            }
        }
        #endregion
        
        public string instrumentIDRef_ { get; set; }
        #region Pricing_
        private Pricing pricing_;
        public Pricing Pricing_
        {
            get
            {
                if (this.pricing_ != null)
                {
                    return this.pricing_; 
                }
                else if (this.pricingIDRef_ != null)
                {
                    pricing_ = IDManager.getID(pricingIDRef_) as Pricing;
                    return this.pricing_; 
                }
                else
                {
                    throw new Exception( "pricing_Node no exist!");
                }
            }
            set
            {
                if (this.pricing_ != value)
                {
                    this.pricing_ = value;
                }
            }
        }
        #endregion
        
        public string pricingIDRef_ { get; set; }
        #region HisoryData_
        private HisoryData hisoryData_;
        public HisoryData HisoryData_
        {
            get
            {
                if (this.hisoryData_ != null)
                {
                    return this.hisoryData_; 
                }
                else if (this.hisoryDataIDRef_ != null)
                {
                    hisoryData_ = IDManager.getID(hisoryDataIDRef_) as HisoryData;
                    return this.hisoryData_; 
                }
                else
                {
                    throw new Exception( "hisoryData_Node no exist!");
                }
            }
            set
            {
                if (this.hisoryData_ != value)
                {
                    this.hisoryData_ = value;
                }
            }
        }
        #endregion
        
        public string hisoryDataIDRef_ { get; set; }
        
    
        
    
    }
    
}


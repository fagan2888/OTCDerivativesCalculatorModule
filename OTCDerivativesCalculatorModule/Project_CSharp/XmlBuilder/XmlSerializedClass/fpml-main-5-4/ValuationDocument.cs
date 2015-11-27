using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ValuationDocument : DataDocument
    {
        public ValuationDocument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode marketNode = xmlNode.SelectSingleNode("market");
            
            if (marketNode != null)
            {
                if (marketNode.Attributes["href"] != null || marketNode.Attributes["id"] != null) 
                {
                    if (marketNode.Attributes["id"] != null) 
                    {
                        marketIDRef_ = marketNode.Attributes["id"].Value;
                        Market ob = new Market(marketNode);
                        IDManager.SetID(marketIDRef_, ob);
                    }
                    else if (marketNode.Attributes["href"] != null)
                    {
                        marketIDRef_ = marketNode.Attributes["href"].Value;
                    }
                    else
                    {
                        market_ = new Market(marketNode);
                    }
                }
                else
                {
                    market_ = new Market(marketNode);
                }
            }
            
        
            XmlNode valuationSetNode = xmlNode.SelectSingleNode("valuationSet");
            
            if (valuationSetNode != null)
            {
                if (valuationSetNode.Attributes["href"] != null || valuationSetNode.Attributes["id"] != null) 
                {
                    if (valuationSetNode.Attributes["id"] != null) 
                    {
                        valuationSetIDRef_ = valuationSetNode.Attributes["id"].Value;
                        ValuationSet ob = new ValuationSet(valuationSetNode);
                        IDManager.SetID(valuationSetIDRef_, ob);
                    }
                    else if (valuationSetNode.Attributes["href"] != null)
                    {
                        valuationSetIDRef_ = valuationSetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationSet_ = new ValuationSet(valuationSetNode);
                    }
                }
                else
                {
                    valuationSet_ = new ValuationSet(valuationSetNode);
                }
            }
            
        
        }
        
    
        #region Market_
        private Market market_;
        public Market Market_
        {
            get
            {
                if (this.market_ != null)
                {
                    return this.market_; 
                }
                else if (this.marketIDRef_ != null)
                {
                    market_ = IDManager.getID(marketIDRef_) as Market;
                    return this.market_; 
                }
                else
                {
                      return this.market_; 
                }
            }
            set
            {
                if (this.market_ != value)
                {
                    this.market_ = value;
                }
            }
        }
        #endregion
        
        public string marketIDRef_ { get; set; }
        #region ValuationSet_
        private ValuationSet valuationSet_;
        public ValuationSet ValuationSet_
        {
            get
            {
                if (this.valuationSet_ != null)
                {
                    return this.valuationSet_; 
                }
                else if (this.valuationSetIDRef_ != null)
                {
                    valuationSet_ = IDManager.getID(valuationSetIDRef_) as ValuationSet;
                    return this.valuationSet_; 
                }
                else
                {
                      return this.valuationSet_; 
                }
            }
            set
            {
                if (this.valuationSet_ != value)
                {
                    this.valuationSet_ = value;
                }
            }
        }
        #endregion
        
        public string valuationSetIDRef_ { get; set; }
        
    
        
    
    }
    
}


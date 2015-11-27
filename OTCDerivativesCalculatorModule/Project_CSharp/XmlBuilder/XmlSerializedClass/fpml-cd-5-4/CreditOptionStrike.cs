using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditOptionStrike : ISerialized
    {
        public CreditOptionStrike(XmlNode xmlNode)
        {
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeDecimal(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeDecimal(spreadNode);
                }
            }
            
        
            XmlNode priceNode = xmlNode.SelectSingleNode("price");
            
            if (priceNode != null)
            {
                if (priceNode.Attributes["href"] != null || priceNode.Attributes["id"] != null) 
                {
                    if (priceNode.Attributes["id"] != null) 
                    {
                        priceIDRef_ = priceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(priceNode);
                        IDManager.SetID(priceIDRef_, ob);
                    }
                    else if (priceNode.Attributes["href"] != null)
                    {
                        priceIDRef_ = priceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        price_ = new XsdTypeDecimal(priceNode);
                    }
                }
                else
                {
                    price_ = new XsdTypeDecimal(priceNode);
                }
            }
            
        
            XmlNode strikeReferenceNode = xmlNode.SelectSingleNode("strikeReference");
            
            if (strikeReferenceNode != null)
            {
                if (strikeReferenceNode.Attributes["href"] != null || strikeReferenceNode.Attributes["id"] != null) 
                {
                    if (strikeReferenceNode.Attributes["id"] != null) 
                    {
                        strikeReferenceIDRef_ = strikeReferenceNode.Attributes["id"].Value;
                        FixedRateReference ob = new FixedRateReference(strikeReferenceNode);
                        IDManager.SetID(strikeReferenceIDRef_, ob);
                    }
                    else if (strikeReferenceNode.Attributes["href"] != null)
                    {
                        strikeReferenceIDRef_ = strikeReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeReference_ = new FixedRateReference(strikeReferenceNode);
                    }
                }
                else
                {
                    strikeReference_ = new FixedRateReference(strikeReferenceNode);
                }
            }
            
        
        }
        
    
        #region Spread_
        private XsdTypeDecimal spread_;
        public XsdTypeDecimal Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeDecimal;
                    return this.spread_; 
                }
                else
                {
                      return this.spread_; 
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region Price_
        private XsdTypeDecimal price_;
        public XsdTypeDecimal Price_
        {
            get
            {
                if (this.price_ != null)
                {
                    return this.price_; 
                }
                else if (this.priceIDRef_ != null)
                {
                    price_ = IDManager.getID(priceIDRef_) as XsdTypeDecimal;
                    return this.price_; 
                }
                else
                {
                      return this.price_; 
                }
            }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                }
            }
        }
        #endregion
        
        public string priceIDRef_ { get; set; }
        #region StrikeReference_
        private FixedRateReference strikeReference_;
        public FixedRateReference StrikeReference_
        {
            get
            {
                if (this.strikeReference_ != null)
                {
                    return this.strikeReference_; 
                }
                else if (this.strikeReferenceIDRef_ != null)
                {
                    strikeReference_ = IDManager.getID(strikeReferenceIDRef_) as FixedRateReference;
                    return this.strikeReference_; 
                }
                else
                {
                      return this.strikeReference_; 
                }
            }
            set
            {
                if (this.strikeReference_ != value)
                {
                    this.strikeReference_ = value;
                }
            }
        }
        #endregion
        
        public string strikeReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DeClear : ISerialized
    {
        public DeClear(XmlNode xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            if (tradeIdentifierNodeList != null)
            {
                this.tradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in tradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(tradeIdentifierIDRef_, tradeIdentifier_[tradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode reasonNode = xmlNode.SelectSingleNode("reason");
            
            if (reasonNode != null)
            {
                if (reasonNode.Attributes["href"] != null || reasonNode.Attributes["id"] != null) 
                {
                    if (reasonNode.Attributes["id"] != null) 
                    {
                        reasonIDRef_ = reasonNode.Attributes["id"].Value;
                        DeclearReason ob = new DeclearReason(reasonNode);
                        IDManager.SetID(reasonIDRef_, ob);
                    }
                    else if (reasonNode.Attributes["href"] != null)
                    {
                        reasonIDRef_ = reasonNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reason_ = new DeclearReason(reasonNode);
                    }
                }
                else
                {
                    reason_ = new DeclearReason(reasonNode);
                }
            }
            
        
        }
        
    
        #region TradeIdentifier_
        private List<PartyTradeIdentifier> tradeIdentifier_;
        public List<PartyTradeIdentifier> TradeIdentifier_
        {
            get
            {
                if (this.tradeIdentifier_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else if (this.tradeIdentifierIDRef_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else
                {
                      return this.tradeIdentifier_; 
                }
            }
            set
            {
                if (this.tradeIdentifier_ != value)
                {
                    this.tradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierIDRef_ { get; set; }
        #region EffectiveDate_
        private XsdTypeDate effectiveDate_;
        public XsdTypeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region Reason_
        private DeclearReason reason_;
        public DeclearReason Reason_
        {
            get
            {
                if (this.reason_ != null)
                {
                    return this.reason_; 
                }
                else if (this.reasonIDRef_ != null)
                {
                    reason_ = IDManager.getID(reasonIDRef_) as DeclearReason;
                    return this.reason_; 
                }
                else
                {
                      return this.reason_; 
                }
            }
            set
            {
                if (this.reason_ != value)
                {
                    this.reason_ = value;
                }
            }
        }
        #endregion
        
        public string reasonIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VersionedTradeId : ISerialized
    {
        public VersionedTradeId(XmlNode xmlNode)
        {
            XmlNode tradeIdNode = xmlNode.SelectSingleNode("tradeId");
            
            if (tradeIdNode != null)
            {
                if (tradeIdNode.Attributes["href"] != null || tradeIdNode.Attributes["id"] != null) 
                {
                    if (tradeIdNode.Attributes["id"] != null) 
                    {
                        tradeIdIDRef_ = tradeIdNode.Attributes["id"].Value;
                        TradeId ob = new TradeId(tradeIdNode);
                        IDManager.SetID(tradeIdIDRef_, ob);
                    }
                    else if (tradeIdNode.Attributes["href"] != null)
                    {
                        tradeIdIDRef_ = tradeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeId_ = new TradeId(tradeIdNode);
                    }
                }
                else
                {
                    tradeId_ = new TradeId(tradeIdNode);
                }
            }
            
        
            XmlNode versionNode = xmlNode.SelectSingleNode("version");
            
            if (versionNode != null)
            {
                if (versionNode.Attributes["href"] != null || versionNode.Attributes["id"] != null) 
                {
                    if (versionNode.Attributes["id"] != null) 
                    {
                        versionIDRef_ = versionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(versionNode);
                        IDManager.SetID(versionIDRef_, ob);
                    }
                    else if (versionNode.Attributes["href"] != null)
                    {
                        versionIDRef_ = versionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        version_ = new XsdTypeNonNegativeInteger(versionNode);
                    }
                }
                else
                {
                    version_ = new XsdTypeNonNegativeInteger(versionNode);
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
                        IdentifiedDate ob = new IdentifiedDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                }
            }
            
        
        }
        
    
        #region TradeId_
        private TradeId tradeId_;
        public TradeId TradeId_
        {
            get
            {
                if (this.tradeId_ != null)
                {
                    return this.tradeId_; 
                }
                else if (this.tradeIdIDRef_ != null)
                {
                    tradeId_ = IDManager.getID(tradeIdIDRef_) as TradeId;
                    return this.tradeId_; 
                }
                else
                {
                      return this.tradeId_; 
                }
            }
            set
            {
                if (this.tradeId_ != value)
                {
                    this.tradeId_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdIDRef_ { get; set; }
        #region Version_
        private XsdTypeNonNegativeInteger version_;
        public XsdTypeNonNegativeInteger Version_
        {
            get
            {
                if (this.version_ != null)
                {
                    return this.version_; 
                }
                else if (this.versionIDRef_ != null)
                {
                    version_ = IDManager.getID(versionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.version_; 
                }
                else
                {
                      return this.version_; 
                }
            }
            set
            {
                if (this.version_ != value)
                {
                    this.version_ = value;
                }
            }
        }
        #endregion
        
        public string versionIDRef_ { get; set; }
        #region EffectiveDate_
        private IdentifiedDate effectiveDate_;
        public IdentifiedDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as IdentifiedDate;
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
        
    
        
    
    }
    
}


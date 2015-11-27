using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConvertibleBond : Bond
    {
        public ConvertibleBond(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode underlyingEquityNode = xmlNode.SelectSingleNode("underlyingEquity");
            
            if (underlyingEquityNode != null)
            {
                if (underlyingEquityNode.Attributes["href"] != null || underlyingEquityNode.Attributes["id"] != null) 
                {
                    if (underlyingEquityNode.Attributes["id"] != null) 
                    {
                        underlyingEquityIDRef_ = underlyingEquityNode.Attributes["id"].Value;
                        EquityAsset ob = new EquityAsset(underlyingEquityNode);
                        IDManager.SetID(underlyingEquityIDRef_, ob);
                    }
                    else if (underlyingEquityNode.Attributes["href"] != null)
                    {
                        underlyingEquityIDRef_ = underlyingEquityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingEquity_ = new EquityAsset(underlyingEquityNode);
                    }
                }
                else
                {
                    underlyingEquity_ = new EquityAsset(underlyingEquityNode);
                }
            }
            
        
            XmlNode redemptionDateNode = xmlNode.SelectSingleNode("redemptionDate");
            
            if (redemptionDateNode != null)
            {
                if (redemptionDateNode.Attributes["href"] != null || redemptionDateNode.Attributes["id"] != null) 
                {
                    if (redemptionDateNode.Attributes["id"] != null) 
                    {
                        redemptionDateIDRef_ = redemptionDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(redemptionDateNode);
                        IDManager.SetID(redemptionDateIDRef_, ob);
                    }
                    else if (redemptionDateNode.Attributes["href"] != null)
                    {
                        redemptionDateIDRef_ = redemptionDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        redemptionDate_ = new XsdTypeDate(redemptionDateNode);
                    }
                }
                else
                {
                    redemptionDate_ = new XsdTypeDate(redemptionDateNode);
                }
            }
            
        
        }
        
    
        #region UnderlyingEquity_
        private EquityAsset underlyingEquity_;
        public EquityAsset UnderlyingEquity_
        {
            get
            {
                if (this.underlyingEquity_ != null)
                {
                    return this.underlyingEquity_; 
                }
                else if (this.underlyingEquityIDRef_ != null)
                {
                    underlyingEquity_ = IDManager.getID(underlyingEquityIDRef_) as EquityAsset;
                    return this.underlyingEquity_; 
                }
                else
                {
                      return this.underlyingEquity_; 
                }
            }
            set
            {
                if (this.underlyingEquity_ != value)
                {
                    this.underlyingEquity_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingEquityIDRef_ { get; set; }
        #region RedemptionDate_
        private XsdTypeDate redemptionDate_;
        public XsdTypeDate RedemptionDate_
        {
            get
            {
                if (this.redemptionDate_ != null)
                {
                    return this.redemptionDate_; 
                }
                else if (this.redemptionDateIDRef_ != null)
                {
                    redemptionDate_ = IDManager.getID(redemptionDateIDRef_) as XsdTypeDate;
                    return this.redemptionDate_; 
                }
                else
                {
                      return this.redemptionDate_; 
                }
            }
            set
            {
                if (this.redemptionDate_ != value)
                {
                    this.redemptionDate_ = value;
                }
            }
        }
        #endregion
        
        public string redemptionDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


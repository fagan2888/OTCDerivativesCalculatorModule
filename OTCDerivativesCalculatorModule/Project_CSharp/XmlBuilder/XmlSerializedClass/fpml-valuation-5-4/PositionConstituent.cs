using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PositionConstituent : ISerialized
    {
        public PositionConstituent(XmlNode xmlNode)
        {
            XmlNode tradeNode = xmlNode.SelectSingleNode("trade");
            
            if (tradeNode != null)
            {
                if (tradeNode.Attributes["href"] != null || tradeNode.Attributes["id"] != null) 
                {
                    if (tradeNode.Attributes["id"] != null) 
                    {
                        tradeIDRef_ = tradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(tradeNode);
                        IDManager.SetID(tradeIDRef_, ob);
                    }
                    else if (tradeNode.Attributes["href"] != null)
                    {
                        tradeIDRef_ = tradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trade_ = new Trade(tradeNode);
                    }
                }
                else
                {
                    trade_ = new Trade(tradeNode);
                }
            }
            
        
            XmlNode positionVersionReferenceNode = xmlNode.SelectSingleNode("positionVersionReference");
            
            if (positionVersionReferenceNode != null)
            {
                if (positionVersionReferenceNode.Attributes["href"] != null || positionVersionReferenceNode.Attributes["id"] != null) 
                {
                    if (positionVersionReferenceNode.Attributes["id"] != null) 
                    {
                        positionVersionReferenceIDRef_ = positionVersionReferenceNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(positionVersionReferenceNode);
                        IDManager.SetID(positionVersionReferenceIDRef_, ob);
                    }
                    else if (positionVersionReferenceNode.Attributes["href"] != null)
                    {
                        positionVersionReferenceIDRef_ = positionVersionReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        positionVersionReference_ = new XsdTypePositiveInteger(positionVersionReferenceNode);
                    }
                }
                else
                {
                    positionVersionReference_ = new XsdTypePositiveInteger(positionVersionReferenceNode);
                }
            }
            
        
            XmlNode tradeReferenceNode = xmlNode.SelectSingleNode("tradeReference");
            
            if (tradeReferenceNode != null)
            {
                if (tradeReferenceNode.Attributes["href"] != null || tradeReferenceNode.Attributes["id"] != null) 
                {
                    if (tradeReferenceNode.Attributes["id"] != null) 
                    {
                        tradeReferenceIDRef_ = tradeReferenceNode.Attributes["id"].Value;
                        PartyTradeIdentifiers ob = new PartyTradeIdentifiers(tradeReferenceNode);
                        IDManager.SetID(tradeReferenceIDRef_, ob);
                    }
                    else if (tradeReferenceNode.Attributes["href"] != null)
                    {
                        tradeReferenceIDRef_ = tradeReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeReference_ = new PartyTradeIdentifiers(tradeReferenceNode);
                    }
                }
                else
                {
                    tradeReference_ = new PartyTradeIdentifiers(tradeReferenceNode);
                }
            }
            
        
        }
        
    
        #region Trade_
        private Trade trade_;
        public Trade Trade_
        {
            get
            {
                if (this.trade_ != null)
                {
                    return this.trade_; 
                }
                else if (this.tradeIDRef_ != null)
                {
                    trade_ = IDManager.getID(tradeIDRef_) as Trade;
                    return this.trade_; 
                }
                else
                {
                      return this.trade_; 
                }
            }
            set
            {
                if (this.trade_ != value)
                {
                    this.trade_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIDRef_ { get; set; }
        #region PositionVersionReference_
        private XsdTypePositiveInteger positionVersionReference_;
        public XsdTypePositiveInteger PositionVersionReference_
        {
            get
            {
                if (this.positionVersionReference_ != null)
                {
                    return this.positionVersionReference_; 
                }
                else if (this.positionVersionReferenceIDRef_ != null)
                {
                    positionVersionReference_ = IDManager.getID(positionVersionReferenceIDRef_) as XsdTypePositiveInteger;
                    return this.positionVersionReference_; 
                }
                else
                {
                      return this.positionVersionReference_; 
                }
            }
            set
            {
                if (this.positionVersionReference_ != value)
                {
                    this.positionVersionReference_ = value;
                }
            }
        }
        #endregion
        
        public string positionVersionReferenceIDRef_ { get; set; }
        #region TradeReference_
        private PartyTradeIdentifiers tradeReference_;
        public PartyTradeIdentifiers TradeReference_
        {
            get
            {
                if (this.tradeReference_ != null)
                {
                    return this.tradeReference_; 
                }
                else if (this.tradeReferenceIDRef_ != null)
                {
                    tradeReference_ = IDManager.getID(tradeReferenceIDRef_) as PartyTradeIdentifiers;
                    return this.tradeReference_; 
                }
                else
                {
                      return this.tradeReference_; 
                }
            }
            set
            {
                if (this.tradeReference_ != value)
                {
                    this.tradeReference_ = value;
                }
            }
        }
        #endregion
        
        public string tradeReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


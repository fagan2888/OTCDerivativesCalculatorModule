using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettlementProvision : ISerialized
    {
        public SettlementProvision(XmlNode xmlNode)
        {
            XmlNode settlementCurrencyNode = xmlNode.SelectSingleNode("settlementCurrency");
            
            if (settlementCurrencyNode != null)
            {
                if (settlementCurrencyNode.Attributes["href"] != null || settlementCurrencyNode.Attributes["id"] != null) 
                {
                    if (settlementCurrencyNode.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(settlementCurrencyNode);
                        IDManager.SetID(settlementCurrencyIDRef_, ob);
                    }
                    else if (settlementCurrencyNode.Attributes["href"] != null)
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementCurrency_ = new Currency(settlementCurrencyNode);
                    }
                }
                else
                {
                    settlementCurrency_ = new Currency(settlementCurrencyNode);
                }
            }
            
        
            XmlNode nonDeliverableSettlementNode = xmlNode.SelectSingleNode("nonDeliverableSettlement");
            
            if (nonDeliverableSettlementNode != null)
            {
                if (nonDeliverableSettlementNode.Attributes["href"] != null || nonDeliverableSettlementNode.Attributes["id"] != null) 
                {
                    if (nonDeliverableSettlementNode.Attributes["id"] != null) 
                    {
                        nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode.Attributes["id"].Value;
                        NonDeliverableSettlement ob = new NonDeliverableSettlement(nonDeliverableSettlementNode);
                        IDManager.SetID(nonDeliverableSettlementIDRef_, ob);
                    }
                    else if (nonDeliverableSettlementNode.Attributes["href"] != null)
                    {
                        nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonDeliverableSettlement_ = new NonDeliverableSettlement(nonDeliverableSettlementNode);
                    }
                }
                else
                {
                    nonDeliverableSettlement_ = new NonDeliverableSettlement(nonDeliverableSettlementNode);
                }
            }
            
        
        }
        
    
        #region SettlementCurrency_
        private Currency settlementCurrency_;
        public Currency SettlementCurrency_
        {
            get
            {
                if (this.settlementCurrency_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else if (this.settlementCurrencyIDRef_ != null)
                {
                    settlementCurrency_ = IDManager.getID(settlementCurrencyIDRef_) as Currency;
                    return this.settlementCurrency_; 
                }
                else
                {
                      return this.settlementCurrency_; 
                }
            }
            set
            {
                if (this.settlementCurrency_ != value)
                {
                    this.settlementCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string settlementCurrencyIDRef_ { get; set; }
        #region NonDeliverableSettlement_
        private NonDeliverableSettlement nonDeliverableSettlement_;
        public NonDeliverableSettlement NonDeliverableSettlement_
        {
            get
            {
                if (this.nonDeliverableSettlement_ != null)
                {
                    return this.nonDeliverableSettlement_; 
                }
                else if (this.nonDeliverableSettlementIDRef_ != null)
                {
                    nonDeliverableSettlement_ = IDManager.getID(nonDeliverableSettlementIDRef_) as NonDeliverableSettlement;
                    return this.nonDeliverableSettlement_; 
                }
                else
                {
                      return this.nonDeliverableSettlement_; 
                }
            }
            set
            {
                if (this.nonDeliverableSettlement_ != value)
                {
                    this.nonDeliverableSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string nonDeliverableSettlementIDRef_ { get; set; }
        
    
        
    
    }
    
}


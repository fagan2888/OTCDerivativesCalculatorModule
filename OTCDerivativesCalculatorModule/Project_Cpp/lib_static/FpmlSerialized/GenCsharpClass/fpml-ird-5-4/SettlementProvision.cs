using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementProvision
    {
        public SettlementProvision(XmlNode xmlNode)
        {
            XmlNodeList settlementCurrencyNodeList = xmlNode.SelectNodes("settlementCurrency");
            if (settlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(settlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList nonDeliverableSettlementNodeList = xmlNode.SelectNodes("nonDeliverableSettlement");
            if (nonDeliverableSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonDeliverableSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonDeliverableSettlementIDRef = item.Attributes["id"].Name;
                        NonDeliverableSettlement ob = NonDeliverableSettlement();
                        IDManager.SetID(nonDeliverableSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonDeliverableSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonDeliverableSettlement = new NonDeliverableSettlement(item);
                    }
                }
            }
            
        
        }
        
    
        #region SettlementCurrency
        private Currency settlementCurrency;
        public Currency SettlementCurrency
        {
            get
            {
                if (this.settlementCurrency != null)
                {
                    return this.settlementCurrency; 
                }
                else if (this.settlementCurrencyIDRef != null)
                {
                    settlementCurrency = IDManager.getID(settlementCurrencyIDRef) as Currency;
                    return this.settlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementCurrency != value)
                {
                    this.settlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region NonDeliverableSettlement
        private NonDeliverableSettlement nonDeliverableSettlement;
        public NonDeliverableSettlement NonDeliverableSettlement
        {
            get
            {
                if (this.nonDeliverableSettlement != null)
                {
                    return this.nonDeliverableSettlement; 
                }
                else if (this.nonDeliverableSettlementIDRef != null)
                {
                    nonDeliverableSettlement = IDManager.getID(nonDeliverableSettlementIDRef) as NonDeliverableSettlement;
                    return this.nonDeliverableSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonDeliverableSettlement != value)
                {
                    this.nonDeliverableSettlement = value;
                }
            }
        }
        #endregion
        
        public string NonDeliverableSettlementIDRef { get; set; }
        
    
        
    
    }
    
}


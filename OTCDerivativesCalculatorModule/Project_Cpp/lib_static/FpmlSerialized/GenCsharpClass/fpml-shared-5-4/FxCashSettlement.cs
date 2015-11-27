using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxCashSettlement
    {
        public FxCashSettlement(XmlNode xmlNode)
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
            
        
            XmlNodeList fixingNodeList = xmlNode.SelectNodes("fixing");
            
            foreach (XmlNode item in fixingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingIDRef = item.Attributes["id"].Name;
                        List<FxFixing> ob = new List<FxFixing>();
                        ob.Add(new FxFixing(item));
                        IDManager.SetID(fixingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fixing.Add(new FxFixing(item));
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
        #region Fixing
        private List<FxFixing> fixing;
        public List<FxFixing> Fixing
        {
            get
            {
                if (this.fixing != null)
                {
                    return this.fixing; 
                }
                else if (this.fixingIDRef != null)
                {
                    fixing = IDManager.getID(fixingIDRef) as List<FxFixing>;
                    return this.fixing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixing != value)
                {
                    this.fixing = value;
                }
            }
        }
        #endregion
        
        public string FxFixingIDRef { get; set; }
        
    
        
    
    }
    
}


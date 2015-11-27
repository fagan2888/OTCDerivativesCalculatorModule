using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxCashSettlement : ISerialized
    {
        public FxCashSettlement(XmlNode xmlNode)
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
            
        
            XmlNodeList fixingNodeList = xmlNode.SelectNodes("fixing");
            
            if (fixingNodeList != null)
            {
                this.fixing_ = new List<FxFixing>();
                foreach (XmlNode item in fixingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fixingIDRef_ = item.Attributes["id"].Value;
                            fixing_.Add(new FxFixing(item));
                            IDManager.SetID(fixingIDRef_, fixing_[fixing_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fixingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fixing_.Add(new FxFixing(item));
                        }
                    }
                    else
                    {
                        fixing_.Add(new FxFixing(item));
                    }
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
        #region Fixing_
        private List<FxFixing> fixing_;
        public List<FxFixing> Fixing_
        {
            get
            {
                if (this.fixing_ != null)
                {
                    return this.fixing_; 
                }
                else if (this.fixingIDRef_ != null)
                {
                    return this.fixing_; 
                }
                else
                {
                      return this.fixing_; 
                }
            }
            set
            {
                if (this.fixing_ != value)
                {
                    this.fixing_ = value;
                }
            }
        }
        #endregion
        
        public string fixingIDRef_ { get; set; }
        
    
        
    
    }
    
}


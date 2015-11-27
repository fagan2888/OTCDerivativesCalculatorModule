using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapAmount : LegAmount
    {
        public ReturnSwapAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode cashSettlementNode = xmlNode.SelectSingleNode("cashSettlement");
            
            if (cashSettlementNode != null)
            {
                if (cashSettlementNode.Attributes["href"] != null || cashSettlementNode.Attributes["id"] != null) 
                {
                    if (cashSettlementNode.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(cashSettlementNode);
                        IDManager.SetID(cashSettlementIDRef_, ob);
                    }
                    else if (cashSettlementNode.Attributes["href"] != null)
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlement_ = new XsdTypeBoolean(cashSettlementNode);
                    }
                }
                else
                {
                    cashSettlement_ = new XsdTypeBoolean(cashSettlementNode);
                }
            }
            
        
            XmlNode optionsExchangeDividendsNode = xmlNode.SelectSingleNode("optionsExchangeDividends");
            
            if (optionsExchangeDividendsNode != null)
            {
                if (optionsExchangeDividendsNode.Attributes["href"] != null || optionsExchangeDividendsNode.Attributes["id"] != null) 
                {
                    if (optionsExchangeDividendsNode.Attributes["id"] != null) 
                    {
                        optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(optionsExchangeDividendsNode);
                        IDManager.SetID(optionsExchangeDividendsIDRef_, ob);
                    }
                    else if (optionsExchangeDividendsNode.Attributes["href"] != null)
                    {
                        optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionsExchangeDividends_ = new XsdTypeBoolean(optionsExchangeDividendsNode);
                    }
                }
                else
                {
                    optionsExchangeDividends_ = new XsdTypeBoolean(optionsExchangeDividendsNode);
                }
            }
            
        
            XmlNode additionalDividendsNode = xmlNode.SelectSingleNode("additionalDividends");
            
            if (additionalDividendsNode != null)
            {
                if (additionalDividendsNode.Attributes["href"] != null || additionalDividendsNode.Attributes["id"] != null) 
                {
                    if (additionalDividendsNode.Attributes["id"] != null) 
                    {
                        additionalDividendsIDRef_ = additionalDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(additionalDividendsNode);
                        IDManager.SetID(additionalDividendsIDRef_, ob);
                    }
                    else if (additionalDividendsNode.Attributes["href"] != null)
                    {
                        additionalDividendsIDRef_ = additionalDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalDividends_ = new XsdTypeBoolean(additionalDividendsNode);
                    }
                }
                else
                {
                    additionalDividends_ = new XsdTypeBoolean(additionalDividendsNode);
                }
            }
            
        
            XmlNode allDividendsNode = xmlNode.SelectSingleNode("allDividends");
            
            if (allDividendsNode != null)
            {
                if (allDividendsNode.Attributes["href"] != null || allDividendsNode.Attributes["id"] != null) 
                {
                    if (allDividendsNode.Attributes["id"] != null) 
                    {
                        allDividendsIDRef_ = allDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(allDividendsNode);
                        IDManager.SetID(allDividendsIDRef_, ob);
                    }
                    else if (allDividendsNode.Attributes["href"] != null)
                    {
                        allDividendsIDRef_ = allDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allDividends_ = new XsdTypeBoolean(allDividendsNode);
                    }
                }
                else
                {
                    allDividends_ = new XsdTypeBoolean(allDividendsNode);
                }
            }
            
        
        }
        
    
        #region CashSettlement_
        private XsdTypeBoolean cashSettlement_;
        public XsdTypeBoolean CashSettlement_
        {
            get
            {
                if (this.cashSettlement_ != null)
                {
                    return this.cashSettlement_; 
                }
                else if (this.cashSettlementIDRef_ != null)
                {
                    cashSettlement_ = IDManager.getID(cashSettlementIDRef_) as XsdTypeBoolean;
                    return this.cashSettlement_; 
                }
                else
                {
                      return this.cashSettlement_; 
                }
            }
            set
            {
                if (this.cashSettlement_ != value)
                {
                    this.cashSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementIDRef_ { get; set; }
        #region OptionsExchangeDividends_
        private XsdTypeBoolean optionsExchangeDividends_;
        public XsdTypeBoolean OptionsExchangeDividends_
        {
            get
            {
                if (this.optionsExchangeDividends_ != null)
                {
                    return this.optionsExchangeDividends_; 
                }
                else if (this.optionsExchangeDividendsIDRef_ != null)
                {
                    optionsExchangeDividends_ = IDManager.getID(optionsExchangeDividendsIDRef_) as XsdTypeBoolean;
                    return this.optionsExchangeDividends_; 
                }
                else
                {
                      return this.optionsExchangeDividends_; 
                }
            }
            set
            {
                if (this.optionsExchangeDividends_ != value)
                {
                    this.optionsExchangeDividends_ = value;
                }
            }
        }
        #endregion
        
        public string optionsExchangeDividendsIDRef_ { get; set; }
        #region AdditionalDividends_
        private XsdTypeBoolean additionalDividends_;
        public XsdTypeBoolean AdditionalDividends_
        {
            get
            {
                if (this.additionalDividends_ != null)
                {
                    return this.additionalDividends_; 
                }
                else if (this.additionalDividendsIDRef_ != null)
                {
                    additionalDividends_ = IDManager.getID(additionalDividendsIDRef_) as XsdTypeBoolean;
                    return this.additionalDividends_; 
                }
                else
                {
                      return this.additionalDividends_; 
                }
            }
            set
            {
                if (this.additionalDividends_ != value)
                {
                    this.additionalDividends_ = value;
                }
            }
        }
        #endregion
        
        public string additionalDividendsIDRef_ { get; set; }
        #region AllDividends_
        private XsdTypeBoolean allDividends_;
        public XsdTypeBoolean AllDividends_
        {
            get
            {
                if (this.allDividends_ != null)
                {
                    return this.allDividends_; 
                }
                else if (this.allDividendsIDRef_ != null)
                {
                    allDividends_ = IDManager.getID(allDividendsIDRef_) as XsdTypeBoolean;
                    return this.allDividends_; 
                }
                else
                {
                      return this.allDividends_; 
                }
            }
            set
            {
                if (this.allDividends_ != value)
                {
                    this.allDividends_ = value;
                }
            }
        }
        #endregion
        
        public string allDividendsIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class PricingResult : ISerialized
    {
        public PricingResult() { }
        public PricingResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode cashflowNode = xmlNode.SelectSingleNode("cashflow");
            
            if (cashflowNode != null)
            {
                if (cashflowNode.Attributes["href"] != null || cashflowNode.Attributes["id"] != null) 
                {
                    if (cashflowNode.Attributes["id"] != null) 
                    {
                        cashflowIDRef_ = cashflowNode.Attributes["id"].Value;
                        Cashflow ob = new Cashflow(cashflowNode);
                        IDManager.SetID(cashflowIDRef_, ob);
                    }
                    else if (cashflowNode.Attributes["href"] != null)
                    {
                        cashflowIDRef_ = cashflowNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflow_ = new Cashflow(cashflowNode);
                    }
                }
                else
                {
                    cashflow_ = new Cashflow(cashflowNode);
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
                        XsdTypeDouble ob = new XsdTypeDouble(priceNode);
                        IDManager.SetID(priceIDRef_, ob);
                    }
                    else if (priceNode.Attributes["href"] != null)
                    {
                        priceIDRef_ = priceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        price_ = new XsdTypeDouble(priceNode);
                    }
                }
                else
                {
                    price_ = new XsdTypeDouble(priceNode);
                }
            }
            
        
            XmlNode unitPriceNode = xmlNode.SelectSingleNode("unitPrice");
            
            if (unitPriceNode != null)
            {
                if (unitPriceNode.Attributes["href"] != null || unitPriceNode.Attributes["id"] != null) 
                {
                    if (unitPriceNode.Attributes["id"] != null) 
                    {
                        unitPriceIDRef_ = unitPriceNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(unitPriceNode);
                        IDManager.SetID(unitPriceIDRef_, ob);
                    }
                    else if (unitPriceNode.Attributes["href"] != null)
                    {
                        unitPriceIDRef_ = unitPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unitPrice_ = new XsdTypeDouble(unitPriceNode);
                    }
                }
                else
                {
                    unitPrice_ = new XsdTypeDouble(unitPriceNode);
                }
            }
            
        
        }
        
    
        #region Cashflow_
        private Cashflow cashflow_;
        public Cashflow Cashflow_
        {
            get
            {
                if (this.cashflow_ != null)
                {
                    return this.cashflow_; 
                }
                else if (this.cashflowIDRef_ != null)
                {
                    cashflow_ = IDManager.getID(cashflowIDRef_) as Cashflow;
                    return this.cashflow_; 
                }
                else
                {
                      return this.cashflow_; 
                }
            }
            set
            {
                if (this.cashflow_ != value)
                {
                    this.cashflow_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowIDRef_ { get; set; }
        #region Price_
        private XsdTypeDouble price_;
        public XsdTypeDouble Price_
        {
            get
            {
                if (this.price_ != null)
                {
                    return this.price_; 
                }
                else if (this.priceIDRef_ != null)
                {
                    price_ = IDManager.getID(priceIDRef_) as XsdTypeDouble;
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
        #region UnitPrice_
        private XsdTypeDouble unitPrice_;
        public XsdTypeDouble UnitPrice_
        {
            get
            {
                if (this.unitPrice_ != null)
                {
                    return this.unitPrice_; 
                }
                else if (this.unitPriceIDRef_ != null)
                {
                    unitPrice_ = IDManager.getID(unitPriceIDRef_) as XsdTypeDouble;
                    return this.unitPrice_; 
                }
                else
                {
                      return this.unitPrice_; 
                }
            }
            set
            {
                if (this.unitPrice_ != value)
                {
                    this.unitPrice_ = value;
                }
            }
        }
        #endregion
        
        public string unitPriceIDRef_ { get; set; }
        public string choiceStr_resultType;
        
    
        
    
    }
    
}


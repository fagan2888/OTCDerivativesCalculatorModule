using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Cashflows : ISerialized
    {
        public Cashflows(XmlNode xmlNode)
        {
            XmlNode cashflowsMatchParametersNode = xmlNode.SelectSingleNode("cashflowsMatchParameters");
            
            if (cashflowsMatchParametersNode != null)
            {
                if (cashflowsMatchParametersNode.Attributes["href"] != null || cashflowsMatchParametersNode.Attributes["id"] != null) 
                {
                    if (cashflowsMatchParametersNode.Attributes["id"] != null) 
                    {
                        cashflowsMatchParametersIDRef_ = cashflowsMatchParametersNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(cashflowsMatchParametersNode);
                        IDManager.SetID(cashflowsMatchParametersIDRef_, ob);
                    }
                    else if (cashflowsMatchParametersNode.Attributes["href"] != null)
                    {
                        cashflowsMatchParametersIDRef_ = cashflowsMatchParametersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflowsMatchParameters_ = new XsdTypeBoolean(cashflowsMatchParametersNode);
                    }
                }
                else
                {
                    cashflowsMatchParameters_ = new XsdTypeBoolean(cashflowsMatchParametersNode);
                }
            }
            
        
            XmlNodeList principalExchangeNodeList = xmlNode.SelectNodes("principalExchange");
            
            if (principalExchangeNodeList != null)
            {
                this.principalExchange_ = new List<PrincipalExchange>();
                foreach (XmlNode item in principalExchangeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            principalExchangeIDRef_ = item.Attributes["id"].Value;
                            principalExchange_.Add(new PrincipalExchange(item));
                            IDManager.SetID(principalExchangeIDRef_, principalExchange_[principalExchange_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            principalExchangeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        principalExchange_.Add(new PrincipalExchange(item));
                        }
                    }
                    else
                    {
                        principalExchange_.Add(new PrincipalExchange(item));
                    }
                }
            }
            
        
            XmlNodeList paymentCalculationPeriodNodeList = xmlNode.SelectNodes("paymentCalculationPeriod");
            
            if (paymentCalculationPeriodNodeList != null)
            {
                this.paymentCalculationPeriod_ = new List<PaymentCalculationPeriod>();
                foreach (XmlNode item in paymentCalculationPeriodNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            paymentCalculationPeriodIDRef_ = item.Attributes["id"].Value;
                            paymentCalculationPeriod_.Add(new PaymentCalculationPeriod(item));
                            IDManager.SetID(paymentCalculationPeriodIDRef_, paymentCalculationPeriod_[paymentCalculationPeriod_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            paymentCalculationPeriodIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        paymentCalculationPeriod_.Add(new PaymentCalculationPeriod(item));
                        }
                    }
                    else
                    {
                        paymentCalculationPeriod_.Add(new PaymentCalculationPeriod(item));
                    }
                }
            }
            
        
        }
        
    
        #region CashflowsMatchParameters_
        private XsdTypeBoolean cashflowsMatchParameters_;
        public XsdTypeBoolean CashflowsMatchParameters_
        {
            get
            {
                if (this.cashflowsMatchParameters_ != null)
                {
                    return this.cashflowsMatchParameters_; 
                }
                else if (this.cashflowsMatchParametersIDRef_ != null)
                {
                    cashflowsMatchParameters_ = IDManager.getID(cashflowsMatchParametersIDRef_) as XsdTypeBoolean;
                    return this.cashflowsMatchParameters_; 
                }
                else
                {
                      return this.cashflowsMatchParameters_; 
                }
            }
            set
            {
                if (this.cashflowsMatchParameters_ != value)
                {
                    this.cashflowsMatchParameters_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowsMatchParametersIDRef_ { get; set; }
        #region PrincipalExchange_
        private List<PrincipalExchange> principalExchange_;
        public List<PrincipalExchange> PrincipalExchange_
        {
            get
            {
                if (this.principalExchange_ != null)
                {
                    return this.principalExchange_; 
                }
                else if (this.principalExchangeIDRef_ != null)
                {
                    return this.principalExchange_; 
                }
                else
                {
                      return this.principalExchange_; 
                }
            }
            set
            {
                if (this.principalExchange_ != value)
                {
                    this.principalExchange_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangeIDRef_ { get; set; }
        #region PaymentCalculationPeriod_
        private List<PaymentCalculationPeriod> paymentCalculationPeriod_;
        public List<PaymentCalculationPeriod> PaymentCalculationPeriod_
        {
            get
            {
                if (this.paymentCalculationPeriod_ != null)
                {
                    return this.paymentCalculationPeriod_; 
                }
                else if (this.paymentCalculationPeriodIDRef_ != null)
                {
                    return this.paymentCalculationPeriod_; 
                }
                else
                {
                      return this.paymentCalculationPeriod_; 
                }
            }
            set
            {
                if (this.paymentCalculationPeriod_ != value)
                {
                    this.paymentCalculationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string paymentCalculationPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}


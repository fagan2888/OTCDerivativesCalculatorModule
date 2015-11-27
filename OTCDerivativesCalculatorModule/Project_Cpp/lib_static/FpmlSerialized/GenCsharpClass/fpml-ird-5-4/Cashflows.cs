using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Cashflows
    {
        public Cashflows(XmlNode xmlNode)
        {
            XmlNodeList cashflowsMatchParametersNodeList = xmlNode.SelectNodes("cashflowsMatchParameters");
            if (cashflowsMatchParametersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashflowsMatchParametersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashflowsMatchParametersIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(cashflowsMatchParametersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashflowsMatchParametersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashflowsMatchParameters = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangeNodeList = xmlNode.SelectNodes("principalExchange");
            
            foreach (XmlNode item in principalExchangeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangeIDRef = item.Attributes["id"].Name;
                        List<PrincipalExchange> ob = new List<PrincipalExchange>();
                        ob.Add(new PrincipalExchange(item));
                        IDManager.SetID(principalExchangeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    principalExchange.Add(new PrincipalExchange(item));
                    }
                }
            }
            
        
            XmlNodeList paymentCalculationPeriodNodeList = xmlNode.SelectNodes("paymentCalculationPeriod");
            
            foreach (XmlNode item in paymentCalculationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentCalculationPeriodIDRef = item.Attributes["id"].Name;
                        List<PaymentCalculationPeriod> ob = new List<PaymentCalculationPeriod>();
                        ob.Add(new PaymentCalculationPeriod(item));
                        IDManager.SetID(paymentCalculationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentCalculationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    paymentCalculationPeriod.Add(new PaymentCalculationPeriod(item));
                    }
                }
            }
            
        
        }
        
    
        #region CashflowsMatchParameters
        private XsdTypeBoolean cashflowsMatchParameters;
        public XsdTypeBoolean CashflowsMatchParameters
        {
            get
            {
                if (this.cashflowsMatchParameters != null)
                {
                    return this.cashflowsMatchParameters; 
                }
                else if (this.cashflowsMatchParametersIDRef != null)
                {
                    cashflowsMatchParameters = IDManager.getID(cashflowsMatchParametersIDRef) as XsdTypeBoolean;
                    return this.cashflowsMatchParameters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashflowsMatchParameters != value)
                {
                    this.cashflowsMatchParameters = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PrincipalExchange
        private List<PrincipalExchange> principalExchange;
        public List<PrincipalExchange> PrincipalExchange
        {
            get
            {
                if (this.principalExchange != null)
                {
                    return this.principalExchange; 
                }
                else if (this.principalExchangeIDRef != null)
                {
                    principalExchange = IDManager.getID(principalExchangeIDRef) as List<PrincipalExchange>;
                    return this.principalExchange; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchange != value)
                {
                    this.principalExchange = value;
                }
            }
        }
        #endregion
        
        public string PrincipalExchangeIDRef { get; set; }
        #region PaymentCalculationPeriod
        private List<PaymentCalculationPeriod> paymentCalculationPeriod;
        public List<PaymentCalculationPeriod> PaymentCalculationPeriod
        {
            get
            {
                if (this.paymentCalculationPeriod != null)
                {
                    return this.paymentCalculationPeriod; 
                }
                else if (this.paymentCalculationPeriodIDRef != null)
                {
                    paymentCalculationPeriod = IDManager.getID(paymentCalculationPeriodIDRef) as List<PaymentCalculationPeriod>;
                    return this.paymentCalculationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentCalculationPeriod != value)
                {
                    this.paymentCalculationPeriod = value;
                }
            }
        }
        #endregion
        
        public string PaymentCalculationPeriodIDRef { get; set; }
        
    
        
    
    }
    
}


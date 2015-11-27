using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PaymentCalculationPeriod
    {
        public PaymentCalculationPeriod(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList unadjustedPaymentDateNodeList = xmlNode.SelectNodes("unadjustedPaymentDate");
            if (unadjustedPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedPaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedPaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedPaymentDateNodeList = xmlNode.SelectNodes("adjustedPaymentDate");
            if (adjustedPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedPaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedPaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodNodeList = xmlNode.SelectNodes("calculationPeriod");
            
            foreach (XmlNode item in calculationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodIDRef = item.Attributes["id"].Name;
                        List<CalculationPeriod> ob = new List<CalculationPeriod>();
                        ob.Add(new CalculationPeriod(item));
                        IDManager.SetID(calculationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    calculationPeriod.Add(new CalculationPeriod(item));
                    }
                }
            }
            
        
            XmlNodeList fixedPaymentAmountNodeList = xmlNode.SelectNodes("fixedPaymentAmount");
            if (fixedPaymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedPaymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedPaymentAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(fixedPaymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedPaymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedPaymentAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList discountFactorNodeList = xmlNode.SelectNodes("discountFactor");
            if (discountFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(discountFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList forecastPaymentAmountNodeList = xmlNode.SelectNodes("forecastPaymentAmount");
            if (forecastPaymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forecastPaymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forecastPaymentAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(forecastPaymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forecastPaymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forecastPaymentAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList presentValueAmountNodeList = xmlNode.SelectNodes("presentValueAmount");
            if (presentValueAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in presentValueAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        presentValueAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(presentValueAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        presentValueAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        presentValueAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedPaymentDate
        private XsdTypeDate unadjustedPaymentDate;
        public XsdTypeDate UnadjustedPaymentDate
        {
            get
            {
                if (this.unadjustedPaymentDate != null)
                {
                    return this.unadjustedPaymentDate; 
                }
                else if (this.unadjustedPaymentDateIDRef != null)
                {
                    unadjustedPaymentDate = IDManager.getID(unadjustedPaymentDateIDRef) as XsdTypeDate;
                    return this.unadjustedPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedPaymentDate != value)
                {
                    this.unadjustedPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedPaymentDate
        private XsdTypeDate adjustedPaymentDate;
        public XsdTypeDate AdjustedPaymentDate
        {
            get
            {
                if (this.adjustedPaymentDate != null)
                {
                    return this.adjustedPaymentDate; 
                }
                else if (this.adjustedPaymentDateIDRef != null)
                {
                    adjustedPaymentDate = IDManager.getID(adjustedPaymentDateIDRef) as XsdTypeDate;
                    return this.adjustedPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedPaymentDate != value)
                {
                    this.adjustedPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region CalculationPeriod
        private List<CalculationPeriod> calculationPeriod;
        public List<CalculationPeriod> CalculationPeriod
        {
            get
            {
                if (this.calculationPeriod != null)
                {
                    return this.calculationPeriod; 
                }
                else if (this.calculationPeriodIDRef != null)
                {
                    calculationPeriod = IDManager.getID(calculationPeriodIDRef) as List<CalculationPeriod>;
                    return this.calculationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriod != value)
                {
                    this.calculationPeriod = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodIDRef { get; set; }
        #region FixedPaymentAmount
        private XsdTypeDecimal fixedPaymentAmount;
        public XsdTypeDecimal FixedPaymentAmount
        {
            get
            {
                if (this.fixedPaymentAmount != null)
                {
                    return this.fixedPaymentAmount; 
                }
                else if (this.fixedPaymentAmountIDRef != null)
                {
                    fixedPaymentAmount = IDManager.getID(fixedPaymentAmountIDRef) as XsdTypeDecimal;
                    return this.fixedPaymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedPaymentAmount != value)
                {
                    this.fixedPaymentAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region DiscountFactor
        private XsdTypeDecimal discountFactor;
        public XsdTypeDecimal DiscountFactor
        {
            get
            {
                if (this.discountFactor != null)
                {
                    return this.discountFactor; 
                }
                else if (this.discountFactorIDRef != null)
                {
                    discountFactor = IDManager.getID(discountFactorIDRef) as XsdTypeDecimal;
                    return this.discountFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountFactor != value)
                {
                    this.discountFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ForecastPaymentAmount
        private Money forecastPaymentAmount;
        public Money ForecastPaymentAmount
        {
            get
            {
                if (this.forecastPaymentAmount != null)
                {
                    return this.forecastPaymentAmount; 
                }
                else if (this.forecastPaymentAmountIDRef != null)
                {
                    forecastPaymentAmount = IDManager.getID(forecastPaymentAmountIDRef) as Money;
                    return this.forecastPaymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forecastPaymentAmount != value)
                {
                    this.forecastPaymentAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region PresentValueAmount
        private Money presentValueAmount;
        public Money PresentValueAmount
        {
            get
            {
                if (this.presentValueAmount != null)
                {
                    return this.presentValueAmount; 
                }
                else if (this.presentValueAmountIDRef != null)
                {
                    presentValueAmount = IDManager.getID(presentValueAmountIDRef) as Money;
                    return this.presentValueAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.presentValueAmount != value)
                {
                    this.presentValueAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PeriodicPayment
    {
        public PeriodicPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList paymentFrequencyNodeList = xmlNode.SelectNodes("paymentFrequency");
            if (paymentFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(paymentFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentFrequency = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList firstPeriodStartDateNodeList = xmlNode.SelectNodes("firstPeriodStartDate");
            if (firstPeriodStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstPeriodStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstPeriodStartDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(firstPeriodStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstPeriodStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstPeriodStartDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList firstPaymentDateNodeList = xmlNode.SelectNodes("firstPaymentDate");
            if (firstPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstPaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(firstPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstPaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList lastRegularPaymentDateNodeList = xmlNode.SelectNodes("lastRegularPaymentDate");
            if (lastRegularPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lastRegularPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lastRegularPaymentDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(lastRegularPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lastRegularPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lastRegularPaymentDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList rollConventionNodeList = xmlNode.SelectNodes("rollConvention");
            if (rollConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rollConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rollConventionIDRef = item.Attributes["id"].Name;
                        RollConventionEnum ob = RollConventionEnum();
                        IDManager.SetID(rollConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rollConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rollConvention = new RollConventionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList fixedAmountNodeList = xmlNode.SelectNodes("fixedAmount");
            if (fixedAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(fixedAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList fixedAmountCalculationNodeList = xmlNode.SelectNodes("fixedAmountCalculation");
            if (fixedAmountCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedAmountCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedAmountCalculationIDRef = item.Attributes["id"].Name;
                        FixedAmountCalculation ob = FixedAmountCalculation();
                        IDManager.SetID(fixedAmountCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedAmountCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedAmountCalculation = new FixedAmountCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedPaymentDatesNodeList = xmlNode.SelectNodes("adjustedPaymentDates");
            
            foreach (XmlNode item in adjustedPaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedPaymentDatesIDRef = item.Attributes["id"].Name;
                        List<AdjustedPaymentDates> ob = new List<AdjustedPaymentDates>();
                        ob.Add(new AdjustedPaymentDates(item));
                        IDManager.SetID(adjustedPaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedPaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    adjustedPaymentDates.Add(new AdjustedPaymentDates(item));
                    }
                }
            }
            
        
        }
        
    
        #region PaymentFrequency
        private Period paymentFrequency;
        public Period PaymentFrequency
        {
            get
            {
                if (this.paymentFrequency != null)
                {
                    return this.paymentFrequency; 
                }
                else if (this.paymentFrequencyIDRef != null)
                {
                    paymentFrequency = IDManager.getID(paymentFrequencyIDRef) as Period;
                    return this.paymentFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentFrequency != value)
                {
                    this.paymentFrequency = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region FirstPeriodStartDate
        private XsdTypeDate firstPeriodStartDate;
        public XsdTypeDate FirstPeriodStartDate
        {
            get
            {
                if (this.firstPeriodStartDate != null)
                {
                    return this.firstPeriodStartDate; 
                }
                else if (this.firstPeriodStartDateIDRef != null)
                {
                    firstPeriodStartDate = IDManager.getID(firstPeriodStartDateIDRef) as XsdTypeDate;
                    return this.firstPeriodStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstPeriodStartDate != value)
                {
                    this.firstPeriodStartDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region FirstPaymentDate
        private XsdTypeDate firstPaymentDate;
        public XsdTypeDate FirstPaymentDate
        {
            get
            {
                if (this.firstPaymentDate != null)
                {
                    return this.firstPaymentDate; 
                }
                else if (this.firstPaymentDateIDRef != null)
                {
                    firstPaymentDate = IDManager.getID(firstPaymentDateIDRef) as XsdTypeDate;
                    return this.firstPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstPaymentDate != value)
                {
                    this.firstPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region LastRegularPaymentDate
        private XsdTypeDate lastRegularPaymentDate;
        public XsdTypeDate LastRegularPaymentDate
        {
            get
            {
                if (this.lastRegularPaymentDate != null)
                {
                    return this.lastRegularPaymentDate; 
                }
                else if (this.lastRegularPaymentDateIDRef != null)
                {
                    lastRegularPaymentDate = IDManager.getID(lastRegularPaymentDateIDRef) as XsdTypeDate;
                    return this.lastRegularPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lastRegularPaymentDate != value)
                {
                    this.lastRegularPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region RollConvention
        private RollConventionEnum rollConvention;
        public RollConventionEnum RollConvention
        {
            get
            {
                if (this.rollConvention != null)
                {
                    return this.rollConvention; 
                }
                else if (this.rollConventionIDRef != null)
                {
                    rollConvention = IDManager.getID(rollConventionIDRef) as RollConventionEnum;
                    return this.rollConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rollConvention != value)
                {
                    this.rollConvention = value;
                }
            }
        }
        #endregion
        
        public string RollConventionEnumIDRef { get; set; }
        #region FixedAmount
        private Money fixedAmount;
        public Money FixedAmount
        {
            get
            {
                if (this.fixedAmount != null)
                {
                    return this.fixedAmount; 
                }
                else if (this.fixedAmountIDRef != null)
                {
                    fixedAmount = IDManager.getID(fixedAmountIDRef) as Money;
                    return this.fixedAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedAmount != value)
                {
                    this.fixedAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region FixedAmountCalculation
        private FixedAmountCalculation fixedAmountCalculation;
        public FixedAmountCalculation FixedAmountCalculation
        {
            get
            {
                if (this.fixedAmountCalculation != null)
                {
                    return this.fixedAmountCalculation; 
                }
                else if (this.fixedAmountCalculationIDRef != null)
                {
                    fixedAmountCalculation = IDManager.getID(fixedAmountCalculationIDRef) as FixedAmountCalculation;
                    return this.fixedAmountCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedAmountCalculation != value)
                {
                    this.fixedAmountCalculation = value;
                }
            }
        }
        #endregion
        
        public string FixedAmountCalculationIDRef { get; set; }
        #region AdjustedPaymentDates
        private List<AdjustedPaymentDates> adjustedPaymentDates;
        public List<AdjustedPaymentDates> AdjustedPaymentDates
        {
            get
            {
                if (this.adjustedPaymentDates != null)
                {
                    return this.adjustedPaymentDates; 
                }
                else if (this.adjustedPaymentDatesIDRef != null)
                {
                    adjustedPaymentDates = IDManager.getID(adjustedPaymentDatesIDRef) as List<AdjustedPaymentDates>;
                    return this.adjustedPaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedPaymentDates != value)
                {
                    this.adjustedPaymentDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustedPaymentDatesIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


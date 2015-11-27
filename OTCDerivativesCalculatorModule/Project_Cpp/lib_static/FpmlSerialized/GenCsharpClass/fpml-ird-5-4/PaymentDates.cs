using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PaymentDates
    {
        public PaymentDates(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodDatesReference");
            if (calculationPeriodDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodDatesReference ob = CalculationPeriodDatesReference();
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodDatesReference = new CalculationPeriodDatesReference(item);
                    }
                }
            }
            
        
            XmlNodeList resetDatesReferenceNodeList = xmlNode.SelectNodes("resetDatesReference");
            if (resetDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetDatesReferenceIDRef = item.Attributes["id"].Name;
                        ResetDatesReference ob = ResetDatesReference();
                        IDManager.SetID(resetDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetDatesReference = new ResetDatesReference(item);
                    }
                }
            }
            
        
            XmlNodeList valuationDatesReferenceNodeList = xmlNode.SelectNodes("valuationDatesReference");
            if (valuationDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDatesReferenceIDRef = item.Attributes["id"].Name;
                        ValuationDatesReference ob = ValuationDatesReference();
                        IDManager.SetID(valuationDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDatesReference = new ValuationDatesReference(item);
                    }
                }
            }
            
        
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
                        Frequency ob = Frequency();
                        IDManager.SetID(paymentFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentFrequency = new Frequency(item);
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
            
        
            XmlNodeList payRelativeToNodeList = xmlNode.SelectNodes("payRelativeTo");
            if (payRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payRelativeToIDRef = item.Attributes["id"].Name;
                        PayRelativeToEnum ob = PayRelativeToEnum();
                        IDManager.SetID(payRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payRelativeTo = new PayRelativeToEnum(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDaysOffsetNodeList = xmlNode.SelectNodes("paymentDaysOffset");
            if (paymentDaysOffsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDaysOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDaysOffsetIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(paymentDaysOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDaysOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDaysOffset = new Offset(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesAdjustmentsNodeList = xmlNode.SelectNodes("paymentDatesAdjustments");
            if (paymentDatesAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(paymentDatesAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDatesAdjustments = new BusinessDayAdjustments(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference
        private CalculationPeriodDatesReference calculationPeriodDatesReference;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference
        {
            get
            {
                if (this.calculationPeriodDatesReference != null)
                {
                    return this.calculationPeriodDatesReference; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef != null)
                {
                    calculationPeriodDatesReference = IDManager.getID(calculationPeriodDatesReferenceIDRef) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference != value)
                {
                    this.calculationPeriodDatesReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodDatesReferenceIDRef { get; set; }
        #region ResetDatesReference
        private ResetDatesReference resetDatesReference;
        public ResetDatesReference ResetDatesReference
        {
            get
            {
                if (this.resetDatesReference != null)
                {
                    return this.resetDatesReference; 
                }
                else if (this.resetDatesReferenceIDRef != null)
                {
                    resetDatesReference = IDManager.getID(resetDatesReferenceIDRef) as ResetDatesReference;
                    return this.resetDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetDatesReference != value)
                {
                    this.resetDatesReference = value;
                }
            }
        }
        #endregion
        
        public string ResetDatesReferenceIDRef { get; set; }
        #region ValuationDatesReference
        private ValuationDatesReference valuationDatesReference;
        public ValuationDatesReference ValuationDatesReference
        {
            get
            {
                if (this.valuationDatesReference != null)
                {
                    return this.valuationDatesReference; 
                }
                else if (this.valuationDatesReferenceIDRef != null)
                {
                    valuationDatesReference = IDManager.getID(valuationDatesReferenceIDRef) as ValuationDatesReference;
                    return this.valuationDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDatesReference != value)
                {
                    this.valuationDatesReference = value;
                }
            }
        }
        #endregion
        
        public string ValuationDatesReferenceIDRef { get; set; }
        #region PaymentFrequency
        private Frequency paymentFrequency;
        public Frequency PaymentFrequency
        {
            get
            {
                if (this.paymentFrequency != null)
                {
                    return this.paymentFrequency; 
                }
                else if (this.paymentFrequencyIDRef != null)
                {
                    paymentFrequency = IDManager.getID(paymentFrequencyIDRef) as Frequency;
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
        
        public string FrequencyIDRef { get; set; }
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
        #region PayRelativeTo
        private PayRelativeToEnum payRelativeTo;
        public PayRelativeToEnum PayRelativeTo
        {
            get
            {
                if (this.payRelativeTo != null)
                {
                    return this.payRelativeTo; 
                }
                else if (this.payRelativeToIDRef != null)
                {
                    payRelativeTo = IDManager.getID(payRelativeToIDRef) as PayRelativeToEnum;
                    return this.payRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payRelativeTo != value)
                {
                    this.payRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string PayRelativeToEnumIDRef { get; set; }
        #region PaymentDaysOffset
        private Offset paymentDaysOffset;
        public Offset PaymentDaysOffset
        {
            get
            {
                if (this.paymentDaysOffset != null)
                {
                    return this.paymentDaysOffset; 
                }
                else if (this.paymentDaysOffsetIDRef != null)
                {
                    paymentDaysOffset = IDManager.getID(paymentDaysOffsetIDRef) as Offset;
                    return this.paymentDaysOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDaysOffset != value)
                {
                    this.paymentDaysOffset = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        #region PaymentDatesAdjustments
        private BusinessDayAdjustments paymentDatesAdjustments;
        public BusinessDayAdjustments PaymentDatesAdjustments
        {
            get
            {
                if (this.paymentDatesAdjustments != null)
                {
                    return this.paymentDatesAdjustments; 
                }
                else if (this.paymentDatesAdjustmentsIDRef != null)
                {
                    paymentDatesAdjustments = IDManager.getID(paymentDatesAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.paymentDatesAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDatesAdjustments != value)
                {
                    this.paymentDatesAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


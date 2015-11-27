using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityRelativePaymentDates
    {
        public CommodityRelativePaymentDates(XmlNode xmlNode)
        {
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
                        CommodityPayRelativeToEnum ob = CommodityPayRelativeToEnum();
                        IDManager.SetID(payRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payRelativeTo = new CommodityPayRelativeToEnum(item);
                    }
                }
            }
            
        
            XmlNodeList payRelativeToEventNodeList = xmlNode.SelectNodes("payRelativeToEvent");
            if (payRelativeToEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payRelativeToEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payRelativeToEventIDRef = item.Attributes["id"].Name;
                        CommodityPayRelativeToEvent ob = CommodityPayRelativeToEvent();
                        IDManager.SetID(payRelativeToEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payRelativeToEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payRelativeToEvent = new CommodityPayRelativeToEvent(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsReferenceNodeList = xmlNode.SelectNodes("calculationPeriodsReference");
            if (calculationPeriodsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsReference ob = CalculationPeriodsReference();
                        IDManager.SetID(calculationPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsReference = new CalculationPeriodsReference(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsScheduleReferenceNodeList = xmlNode.SelectNodes("calculationPeriodsScheduleReference");
            if (calculationPeriodsScheduleReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsScheduleReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsScheduleReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsScheduleReference ob = CalculationPeriodsScheduleReference();
                        IDManager.SetID(calculationPeriodsScheduleReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsScheduleReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsScheduleReference = new CalculationPeriodsScheduleReference(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodsDatesReference");
            if (calculationPeriodsDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsDatesReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsDatesReference ob = CalculationPeriodsDatesReference();
                        IDManager.SetID(calculationPeriodsDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsDatesReference = new CalculationPeriodsDatesReference(item);
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
                        DateOffset ob = DateOffset();
                        IDManager.SetID(paymentDaysOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDaysOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDaysOffset = new DateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersReferenceNodeList = xmlNode.SelectNodes("businessCentersReference");
            if (businessCentersReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef = item.Attributes["id"].Name;
                        BusinessCentersReference ob = BusinessCentersReference();
                        IDManager.SetID(businessCentersReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCentersReference = new BusinessCentersReference(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersNodeList = xmlNode.SelectNodes("businessCenters");
            if (businessCentersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersIDRef = item.Attributes["id"].Name;
                        BusinessCenters ob = BusinessCenters();
                        IDManager.SetID(businessCentersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenters = new BusinessCenters(item);
                    }
                }
            }
            
        
        }
        
    
        #region PayRelativeTo
        private CommodityPayRelativeToEnum payRelativeTo;
        public CommodityPayRelativeToEnum PayRelativeTo
        {
            get
            {
                if (this.payRelativeTo != null)
                {
                    return this.payRelativeTo; 
                }
                else if (this.payRelativeToIDRef != null)
                {
                    payRelativeTo = IDManager.getID(payRelativeToIDRef) as CommodityPayRelativeToEnum;
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
        
        public string CommodityPayRelativeToEnumIDRef { get; set; }
        #region PayRelativeToEvent
        private CommodityPayRelativeToEvent payRelativeToEvent;
        public CommodityPayRelativeToEvent PayRelativeToEvent
        {
            get
            {
                if (this.payRelativeToEvent != null)
                {
                    return this.payRelativeToEvent; 
                }
                else if (this.payRelativeToEventIDRef != null)
                {
                    payRelativeToEvent = IDManager.getID(payRelativeToEventIDRef) as CommodityPayRelativeToEvent;
                    return this.payRelativeToEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payRelativeToEvent != value)
                {
                    this.payRelativeToEvent = value;
                }
            }
        }
        #endregion
        
        public string CommodityPayRelativeToEventIDRef { get; set; }
        #region CalculationPeriodsReference
        private CalculationPeriodsReference calculationPeriodsReference;
        public CalculationPeriodsReference CalculationPeriodsReference
        {
            get
            {
                if (this.calculationPeriodsReference != null)
                {
                    return this.calculationPeriodsReference; 
                }
                else if (this.calculationPeriodsReferenceIDRef != null)
                {
                    calculationPeriodsReference = IDManager.getID(calculationPeriodsReferenceIDRef) as CalculationPeriodsReference;
                    return this.calculationPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsReference != value)
                {
                    this.calculationPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsReferenceIDRef { get; set; }
        #region CalculationPeriodsScheduleReference
        private CalculationPeriodsScheduleReference calculationPeriodsScheduleReference;
        public CalculationPeriodsScheduleReference CalculationPeriodsScheduleReference
        {
            get
            {
                if (this.calculationPeriodsScheduleReference != null)
                {
                    return this.calculationPeriodsScheduleReference; 
                }
                else if (this.calculationPeriodsScheduleReferenceIDRef != null)
                {
                    calculationPeriodsScheduleReference = IDManager.getID(calculationPeriodsScheduleReferenceIDRef) as CalculationPeriodsScheduleReference;
                    return this.calculationPeriodsScheduleReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsScheduleReference != value)
                {
                    this.calculationPeriodsScheduleReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsScheduleReferenceIDRef { get; set; }
        #region CalculationPeriodsDatesReference
        private CalculationPeriodsDatesReference calculationPeriodsDatesReference;
        public CalculationPeriodsDatesReference CalculationPeriodsDatesReference
        {
            get
            {
                if (this.calculationPeriodsDatesReference != null)
                {
                    return this.calculationPeriodsDatesReference; 
                }
                else if (this.calculationPeriodsDatesReferenceIDRef != null)
                {
                    calculationPeriodsDatesReference = IDManager.getID(calculationPeriodsDatesReferenceIDRef) as CalculationPeriodsDatesReference;
                    return this.calculationPeriodsDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsDatesReference != value)
                {
                    this.calculationPeriodsDatesReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsDatesReferenceIDRef { get; set; }
        #region PaymentDaysOffset
        private DateOffset paymentDaysOffset;
        public DateOffset PaymentDaysOffset
        {
            get
            {
                if (this.paymentDaysOffset != null)
                {
                    return this.paymentDaysOffset; 
                }
                else if (this.paymentDaysOffsetIDRef != null)
                {
                    paymentDaysOffset = IDManager.getID(paymentDaysOffsetIDRef) as DateOffset;
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
        
        public string DateOffsetIDRef { get; set; }
        #region BusinessCentersReference
        private BusinessCentersReference businessCentersReference;
        public BusinessCentersReference BusinessCentersReference
        {
            get
            {
                if (this.businessCentersReference != null)
                {
                    return this.businessCentersReference; 
                }
                else if (this.businessCentersReferenceIDRef != null)
                {
                    businessCentersReference = IDManager.getID(businessCentersReferenceIDRef) as BusinessCentersReference;
                    return this.businessCentersReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCentersReference != value)
                {
                    this.businessCentersReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersReferenceIDRef { get; set; }
        #region BusinessCenters
        private BusinessCenters businessCenters;
        public BusinessCenters BusinessCenters
        {
            get
            {
                if (this.businessCenters != null)
                {
                    return this.businessCenters; 
                }
                else if (this.businessCentersIDRef != null)
                {
                    businessCenters = IDManager.getID(businessCentersIDRef) as BusinessCenters;
                    return this.businessCenters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenters != value)
                {
                    this.businessCenters = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}


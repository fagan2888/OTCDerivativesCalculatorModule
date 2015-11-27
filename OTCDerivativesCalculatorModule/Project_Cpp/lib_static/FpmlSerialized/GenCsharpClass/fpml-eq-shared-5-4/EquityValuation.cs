using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityValuation
    {
        public EquityValuation(XmlNode xmlNode)
        {
            XmlNodeList valuationDateNodeList = xmlNode.SelectNodes("valuationDate");
            if (valuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDateIDRef = item.Attributes["id"].Name;
                        AdjustableDateOrRelativeDateSequence ob = AdjustableDateOrRelativeDateSequence();
                        IDManager.SetID(valuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDate = new AdjustableDateOrRelativeDateSequence(item);
                    }
                }
            }
            
        
            XmlNodeList valuationDatesNodeList = xmlNode.SelectNodes("valuationDates");
            if (valuationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates ob = AdjustableRelativeOrPeriodicDates();
                        IDManager.SetID(valuationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDates = new AdjustableRelativeOrPeriodicDates(item);
                    }
                }
            }
            
        
            XmlNodeList valuationTimeTypeNodeList = xmlNode.SelectNodes("valuationTimeType");
            if (valuationTimeTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationTimeTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationTimeTypeIDRef = item.Attributes["id"].Name;
                        TimeTypeEnum ob = TimeTypeEnum();
                        IDManager.SetID(valuationTimeTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationTimeTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationTimeType = new TimeTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList valuationTimeNodeList = xmlNode.SelectNodes("valuationTime");
            if (valuationTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(valuationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList futuresPriceValuationNodeList = xmlNode.SelectNodes("futuresPriceValuation");
            if (futuresPriceValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in futuresPriceValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        futuresPriceValuationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(futuresPriceValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        futuresPriceValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        futuresPriceValuation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList optionsPriceValuationNodeList = xmlNode.SelectNodes("optionsPriceValuation");
            if (optionsPriceValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionsPriceValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionsPriceValuationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(optionsPriceValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionsPriceValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionsPriceValuation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList numberOfValuationDatesNodeList = xmlNode.SelectNodes("numberOfValuationDates");
            if (numberOfValuationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfValuationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfValuationDatesIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(numberOfValuationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfValuationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfValuationDates = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList dividendValuationDatesNodeList = xmlNode.SelectNodes("dividendValuationDates");
            if (dividendValuationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendValuationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendValuationDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates ob = AdjustableRelativeOrPeriodicDates();
                        IDManager.SetID(dividendValuationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendValuationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendValuationDates = new AdjustableRelativeOrPeriodicDates(item);
                    }
                }
            }
            
        
            XmlNodeList fPVFinalPriceElectionFallbackNodeList = xmlNode.SelectNodes("fPVFinalPriceElectionFallback");
            if (fPVFinalPriceElectionFallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fPVFinalPriceElectionFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fPVFinalPriceElectionFallbackIDRef = item.Attributes["id"].Name;
                        FPVFinalPriceElectionFallbackEnum ob = FPVFinalPriceElectionFallbackEnum();
                        IDManager.SetID(fPVFinalPriceElectionFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fPVFinalPriceElectionFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fPVFinalPriceElectionFallback = new FPVFinalPriceElectionFallbackEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region ValuationDate
        private AdjustableDateOrRelativeDateSequence valuationDate;
        public AdjustableDateOrRelativeDateSequence ValuationDate
        {
            get
            {
                if (this.valuationDate != null)
                {
                    return this.valuationDate; 
                }
                else if (this.valuationDateIDRef != null)
                {
                    valuationDate = IDManager.getID(valuationDateIDRef) as AdjustableDateOrRelativeDateSequence;
                    return this.valuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDate != value)
                {
                    this.valuationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateOrRelativeDateSequenceIDRef { get; set; }
        #region ValuationDates
        private AdjustableRelativeOrPeriodicDates valuationDates;
        public AdjustableRelativeOrPeriodicDates ValuationDates
        {
            get
            {
                if (this.valuationDates != null)
                {
                    return this.valuationDates; 
                }
                else if (this.valuationDatesIDRef != null)
                {
                    valuationDates = IDManager.getID(valuationDatesIDRef) as AdjustableRelativeOrPeriodicDates;
                    return this.valuationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDates != value)
                {
                    this.valuationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDatesIDRef { get; set; }
        #region ValuationTimeType
        private TimeTypeEnum valuationTimeType;
        public TimeTypeEnum ValuationTimeType
        {
            get
            {
                if (this.valuationTimeType != null)
                {
                    return this.valuationTimeType; 
                }
                else if (this.valuationTimeTypeIDRef != null)
                {
                    valuationTimeType = IDManager.getID(valuationTimeTypeIDRef) as TimeTypeEnum;
                    return this.valuationTimeType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationTimeType != value)
                {
                    this.valuationTimeType = value;
                }
            }
        }
        #endregion
        
        public string TimeTypeEnumIDRef { get; set; }
        #region ValuationTime
        private BusinessCenterTime valuationTime;
        public BusinessCenterTime ValuationTime
        {
            get
            {
                if (this.valuationTime != null)
                {
                    return this.valuationTime; 
                }
                else if (this.valuationTimeIDRef != null)
                {
                    valuationTime = IDManager.getID(valuationTimeIDRef) as BusinessCenterTime;
                    return this.valuationTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationTime != value)
                {
                    this.valuationTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region FuturesPriceValuation
        private XsdTypeBoolean futuresPriceValuation;
        public XsdTypeBoolean FuturesPriceValuation
        {
            get
            {
                if (this.futuresPriceValuation != null)
                {
                    return this.futuresPriceValuation; 
                }
                else if (this.futuresPriceValuationIDRef != null)
                {
                    futuresPriceValuation = IDManager.getID(futuresPriceValuationIDRef) as XsdTypeBoolean;
                    return this.futuresPriceValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.futuresPriceValuation != value)
                {
                    this.futuresPriceValuation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region OptionsPriceValuation
        private XsdTypeBoolean optionsPriceValuation;
        public XsdTypeBoolean OptionsPriceValuation
        {
            get
            {
                if (this.optionsPriceValuation != null)
                {
                    return this.optionsPriceValuation; 
                }
                else if (this.optionsPriceValuationIDRef != null)
                {
                    optionsPriceValuation = IDManager.getID(optionsPriceValuationIDRef) as XsdTypeBoolean;
                    return this.optionsPriceValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionsPriceValuation != value)
                {
                    this.optionsPriceValuation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region NumberOfValuationDates
        private XsdTypeNonNegativeInteger numberOfValuationDates;
        public XsdTypeNonNegativeInteger NumberOfValuationDates
        {
            get
            {
                if (this.numberOfValuationDates != null)
                {
                    return this.numberOfValuationDates; 
                }
                else if (this.numberOfValuationDatesIDRef != null)
                {
                    numberOfValuationDates = IDManager.getID(numberOfValuationDatesIDRef) as XsdTypeNonNegativeInteger;
                    return this.numberOfValuationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfValuationDates != value)
                {
                    this.numberOfValuationDates = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        #region DividendValuationDates
        private AdjustableRelativeOrPeriodicDates dividendValuationDates;
        public AdjustableRelativeOrPeriodicDates DividendValuationDates
        {
            get
            {
                if (this.dividendValuationDates != null)
                {
                    return this.dividendValuationDates; 
                }
                else if (this.dividendValuationDatesIDRef != null)
                {
                    dividendValuationDates = IDManager.getID(dividendValuationDatesIDRef) as AdjustableRelativeOrPeriodicDates;
                    return this.dividendValuationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendValuationDates != value)
                {
                    this.dividendValuationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDatesIDRef { get; set; }
        #region FPVFinalPriceElectionFallback
        private FPVFinalPriceElectionFallbackEnum fPVFinalPriceElectionFallback;
        public FPVFinalPriceElectionFallbackEnum FPVFinalPriceElectionFallback
        {
            get
            {
                if (this.fPVFinalPriceElectionFallback != null)
                {
                    return this.fPVFinalPriceElectionFallback; 
                }
                else if (this.fPVFinalPriceElectionFallbackIDRef != null)
                {
                    fPVFinalPriceElectionFallback = IDManager.getID(fPVFinalPriceElectionFallbackIDRef) as FPVFinalPriceElectionFallbackEnum;
                    return this.fPVFinalPriceElectionFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fPVFinalPriceElectionFallback != value)
                {
                    this.fPVFinalPriceElectionFallback = value;
                }
            }
        }
        #endregion
        
        public string FPVFinalPriceElectionFallbackEnumIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


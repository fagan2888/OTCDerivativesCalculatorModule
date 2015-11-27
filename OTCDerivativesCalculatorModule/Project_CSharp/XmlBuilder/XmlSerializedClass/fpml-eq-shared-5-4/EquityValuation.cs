using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityValuation : ISerialized
    {
        public EquityValuation(XmlNode xmlNode)
        {
            XmlNode valuationDateNode = xmlNode.SelectSingleNode("valuationDate");
            
            if (valuationDateNode != null)
            {
                if (valuationDateNode.Attributes["href"] != null || valuationDateNode.Attributes["id"] != null) 
                {
                    if (valuationDateNode.Attributes["id"] != null) 
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["id"].Value;
                        AdjustableDateOrRelativeDateSequence ob = new AdjustableDateOrRelativeDateSequence(valuationDateNode);
                        IDManager.SetID(valuationDateIDRef_, ob);
                    }
                    else if (valuationDateNode.Attributes["href"] != null)
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDate_ = new AdjustableDateOrRelativeDateSequence(valuationDateNode);
                    }
                }
                else
                {
                    valuationDate_ = new AdjustableDateOrRelativeDateSequence(valuationDateNode);
                }
            }
            
        
            XmlNode valuationDatesNode = xmlNode.SelectSingleNode("valuationDates");
            
            if (valuationDatesNode != null)
            {
                if (valuationDatesNode.Attributes["href"] != null || valuationDatesNode.Attributes["id"] != null) 
                {
                    if (valuationDatesNode.Attributes["id"] != null) 
                    {
                        valuationDatesIDRef_ = valuationDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates ob = new AdjustableRelativeOrPeriodicDates(valuationDatesNode);
                        IDManager.SetID(valuationDatesIDRef_, ob);
                    }
                    else if (valuationDatesNode.Attributes["href"] != null)
                    {
                        valuationDatesIDRef_ = valuationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDates_ = new AdjustableRelativeOrPeriodicDates(valuationDatesNode);
                    }
                }
                else
                {
                    valuationDates_ = new AdjustableRelativeOrPeriodicDates(valuationDatesNode);
                }
            }
            
        
            XmlNode valuationTimeTypeNode = xmlNode.SelectSingleNode("valuationTimeType");
            
            if (valuationTimeTypeNode != null)
            {
                if (valuationTimeTypeNode.Attributes["href"] != null || valuationTimeTypeNode.Attributes["id"] != null) 
                {
                    if (valuationTimeTypeNode.Attributes["id"] != null) 
                    {
                        valuationTimeTypeIDRef_ = valuationTimeTypeNode.Attributes["id"].Value;
                        TimeTypeEnum ob = new TimeTypeEnum(valuationTimeTypeNode);
                        IDManager.SetID(valuationTimeTypeIDRef_, ob);
                    }
                    else if (valuationTimeTypeNode.Attributes["href"] != null)
                    {
                        valuationTimeTypeIDRef_ = valuationTimeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationTimeType_ = new TimeTypeEnum(valuationTimeTypeNode);
                    }
                }
                else
                {
                    valuationTimeType_ = new TimeTypeEnum(valuationTimeTypeNode);
                }
            }
            
        
            XmlNode valuationTimeNode = xmlNode.SelectSingleNode("valuationTime");
            
            if (valuationTimeNode != null)
            {
                if (valuationTimeNode.Attributes["href"] != null || valuationTimeNode.Attributes["id"] != null) 
                {
                    if (valuationTimeNode.Attributes["id"] != null) 
                    {
                        valuationTimeIDRef_ = valuationTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(valuationTimeNode);
                        IDManager.SetID(valuationTimeIDRef_, ob);
                    }
                    else if (valuationTimeNode.Attributes["href"] != null)
                    {
                        valuationTimeIDRef_ = valuationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationTime_ = new BusinessCenterTime(valuationTimeNode);
                    }
                }
                else
                {
                    valuationTime_ = new BusinessCenterTime(valuationTimeNode);
                }
            }
            
        
            XmlNode futuresPriceValuationNode = xmlNode.SelectSingleNode("futuresPriceValuation");
            
            if (futuresPriceValuationNode != null)
            {
                if (futuresPriceValuationNode.Attributes["href"] != null || futuresPriceValuationNode.Attributes["id"] != null) 
                {
                    if (futuresPriceValuationNode.Attributes["id"] != null) 
                    {
                        futuresPriceValuationIDRef_ = futuresPriceValuationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(futuresPriceValuationNode);
                        IDManager.SetID(futuresPriceValuationIDRef_, ob);
                    }
                    else if (futuresPriceValuationNode.Attributes["href"] != null)
                    {
                        futuresPriceValuationIDRef_ = futuresPriceValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        futuresPriceValuation_ = new XsdTypeBoolean(futuresPriceValuationNode);
                    }
                }
                else
                {
                    futuresPriceValuation_ = new XsdTypeBoolean(futuresPriceValuationNode);
                }
            }
            
        
            XmlNode optionsPriceValuationNode = xmlNode.SelectSingleNode("optionsPriceValuation");
            
            if (optionsPriceValuationNode != null)
            {
                if (optionsPriceValuationNode.Attributes["href"] != null || optionsPriceValuationNode.Attributes["id"] != null) 
                {
                    if (optionsPriceValuationNode.Attributes["id"] != null) 
                    {
                        optionsPriceValuationIDRef_ = optionsPriceValuationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(optionsPriceValuationNode);
                        IDManager.SetID(optionsPriceValuationIDRef_, ob);
                    }
                    else if (optionsPriceValuationNode.Attributes["href"] != null)
                    {
                        optionsPriceValuationIDRef_ = optionsPriceValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionsPriceValuation_ = new XsdTypeBoolean(optionsPriceValuationNode);
                    }
                }
                else
                {
                    optionsPriceValuation_ = new XsdTypeBoolean(optionsPriceValuationNode);
                }
            }
            
        
            XmlNode numberOfValuationDatesNode = xmlNode.SelectSingleNode("numberOfValuationDates");
            
            if (numberOfValuationDatesNode != null)
            {
                if (numberOfValuationDatesNode.Attributes["href"] != null || numberOfValuationDatesNode.Attributes["id"] != null) 
                {
                    if (numberOfValuationDatesNode.Attributes["id"] != null) 
                    {
                        numberOfValuationDatesIDRef_ = numberOfValuationDatesNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(numberOfValuationDatesNode);
                        IDManager.SetID(numberOfValuationDatesIDRef_, ob);
                    }
                    else if (numberOfValuationDatesNode.Attributes["href"] != null)
                    {
                        numberOfValuationDatesIDRef_ = numberOfValuationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfValuationDates_ = new XsdTypeNonNegativeInteger(numberOfValuationDatesNode);
                    }
                }
                else
                {
                    numberOfValuationDates_ = new XsdTypeNonNegativeInteger(numberOfValuationDatesNode);
                }
            }
            
        
            XmlNode dividendValuationDatesNode = xmlNode.SelectSingleNode("dividendValuationDates");
            
            if (dividendValuationDatesNode != null)
            {
                if (dividendValuationDatesNode.Attributes["href"] != null || dividendValuationDatesNode.Attributes["id"] != null) 
                {
                    if (dividendValuationDatesNode.Attributes["id"] != null) 
                    {
                        dividendValuationDatesIDRef_ = dividendValuationDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates ob = new AdjustableRelativeOrPeriodicDates(dividendValuationDatesNode);
                        IDManager.SetID(dividendValuationDatesIDRef_, ob);
                    }
                    else if (dividendValuationDatesNode.Attributes["href"] != null)
                    {
                        dividendValuationDatesIDRef_ = dividendValuationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendValuationDates_ = new AdjustableRelativeOrPeriodicDates(dividendValuationDatesNode);
                    }
                }
                else
                {
                    dividendValuationDates_ = new AdjustableRelativeOrPeriodicDates(dividendValuationDatesNode);
                }
            }
            
        
            XmlNode fPVFinalPriceElectionFallbackNode = xmlNode.SelectSingleNode("fPVFinalPriceElectionFallback");
            
            if (fPVFinalPriceElectionFallbackNode != null)
            {
                if (fPVFinalPriceElectionFallbackNode.Attributes["href"] != null || fPVFinalPriceElectionFallbackNode.Attributes["id"] != null) 
                {
                    if (fPVFinalPriceElectionFallbackNode.Attributes["id"] != null) 
                    {
                        fPVFinalPriceElectionFallbackIDRef_ = fPVFinalPriceElectionFallbackNode.Attributes["id"].Value;
                        FPVFinalPriceElectionFallbackEnum ob = new FPVFinalPriceElectionFallbackEnum(fPVFinalPriceElectionFallbackNode);
                        IDManager.SetID(fPVFinalPriceElectionFallbackIDRef_, ob);
                    }
                    else if (fPVFinalPriceElectionFallbackNode.Attributes["href"] != null)
                    {
                        fPVFinalPriceElectionFallbackIDRef_ = fPVFinalPriceElectionFallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fPVFinalPriceElectionFallback_ = new FPVFinalPriceElectionFallbackEnum(fPVFinalPriceElectionFallbackNode);
                    }
                }
                else
                {
                    fPVFinalPriceElectionFallback_ = new FPVFinalPriceElectionFallbackEnum(fPVFinalPriceElectionFallbackNode);
                }
            }
            
        
        }
        
    
        #region ValuationDate_
        private AdjustableDateOrRelativeDateSequence valuationDate_;
        public AdjustableDateOrRelativeDateSequence ValuationDate_
        {
            get
            {
                if (this.valuationDate_ != null)
                {
                    return this.valuationDate_; 
                }
                else if (this.valuationDateIDRef_ != null)
                {
                    valuationDate_ = IDManager.getID(valuationDateIDRef_) as AdjustableDateOrRelativeDateSequence;
                    return this.valuationDate_; 
                }
                else
                {
                      return this.valuationDate_; 
                }
            }
            set
            {
                if (this.valuationDate_ != value)
                {
                    this.valuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string valuationDateIDRef_ { get; set; }
        #region ValuationDates_
        private AdjustableRelativeOrPeriodicDates valuationDates_;
        public AdjustableRelativeOrPeriodicDates ValuationDates_
        {
            get
            {
                if (this.valuationDates_ != null)
                {
                    return this.valuationDates_; 
                }
                else if (this.valuationDatesIDRef_ != null)
                {
                    valuationDates_ = IDManager.getID(valuationDatesIDRef_) as AdjustableRelativeOrPeriodicDates;
                    return this.valuationDates_; 
                }
                else
                {
                      return this.valuationDates_; 
                }
            }
            set
            {
                if (this.valuationDates_ != value)
                {
                    this.valuationDates_ = value;
                }
            }
        }
        #endregion
        
        public string valuationDatesIDRef_ { get; set; }
        #region ValuationTimeType_
        private TimeTypeEnum valuationTimeType_;
        public TimeTypeEnum ValuationTimeType_
        {
            get
            {
                if (this.valuationTimeType_ != null)
                {
                    return this.valuationTimeType_; 
                }
                else if (this.valuationTimeTypeIDRef_ != null)
                {
                    valuationTimeType_ = IDManager.getID(valuationTimeTypeIDRef_) as TimeTypeEnum;
                    return this.valuationTimeType_; 
                }
                else
                {
                      return this.valuationTimeType_; 
                }
            }
            set
            {
                if (this.valuationTimeType_ != value)
                {
                    this.valuationTimeType_ = value;
                }
            }
        }
        #endregion
        
        public string valuationTimeTypeIDRef_ { get; set; }
        #region ValuationTime_
        private BusinessCenterTime valuationTime_;
        public BusinessCenterTime ValuationTime_
        {
            get
            {
                if (this.valuationTime_ != null)
                {
                    return this.valuationTime_; 
                }
                else if (this.valuationTimeIDRef_ != null)
                {
                    valuationTime_ = IDManager.getID(valuationTimeIDRef_) as BusinessCenterTime;
                    return this.valuationTime_; 
                }
                else
                {
                      return this.valuationTime_; 
                }
            }
            set
            {
                if (this.valuationTime_ != value)
                {
                    this.valuationTime_ = value;
                }
            }
        }
        #endregion
        
        public string valuationTimeIDRef_ { get; set; }
        #region FuturesPriceValuation_
        private XsdTypeBoolean futuresPriceValuation_;
        public XsdTypeBoolean FuturesPriceValuation_
        {
            get
            {
                if (this.futuresPriceValuation_ != null)
                {
                    return this.futuresPriceValuation_; 
                }
                else if (this.futuresPriceValuationIDRef_ != null)
                {
                    futuresPriceValuation_ = IDManager.getID(futuresPriceValuationIDRef_) as XsdTypeBoolean;
                    return this.futuresPriceValuation_; 
                }
                else
                {
                      return this.futuresPriceValuation_; 
                }
            }
            set
            {
                if (this.futuresPriceValuation_ != value)
                {
                    this.futuresPriceValuation_ = value;
                }
            }
        }
        #endregion
        
        public string futuresPriceValuationIDRef_ { get; set; }
        #region OptionsPriceValuation_
        private XsdTypeBoolean optionsPriceValuation_;
        public XsdTypeBoolean OptionsPriceValuation_
        {
            get
            {
                if (this.optionsPriceValuation_ != null)
                {
                    return this.optionsPriceValuation_; 
                }
                else if (this.optionsPriceValuationIDRef_ != null)
                {
                    optionsPriceValuation_ = IDManager.getID(optionsPriceValuationIDRef_) as XsdTypeBoolean;
                    return this.optionsPriceValuation_; 
                }
                else
                {
                      return this.optionsPriceValuation_; 
                }
            }
            set
            {
                if (this.optionsPriceValuation_ != value)
                {
                    this.optionsPriceValuation_ = value;
                }
            }
        }
        #endregion
        
        public string optionsPriceValuationIDRef_ { get; set; }
        #region NumberOfValuationDates_
        private XsdTypeNonNegativeInteger numberOfValuationDates_;
        public XsdTypeNonNegativeInteger NumberOfValuationDates_
        {
            get
            {
                if (this.numberOfValuationDates_ != null)
                {
                    return this.numberOfValuationDates_; 
                }
                else if (this.numberOfValuationDatesIDRef_ != null)
                {
                    numberOfValuationDates_ = IDManager.getID(numberOfValuationDatesIDRef_) as XsdTypeNonNegativeInteger;
                    return this.numberOfValuationDates_; 
                }
                else
                {
                      return this.numberOfValuationDates_; 
                }
            }
            set
            {
                if (this.numberOfValuationDates_ != value)
                {
                    this.numberOfValuationDates_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfValuationDatesIDRef_ { get; set; }
        #region DividendValuationDates_
        private AdjustableRelativeOrPeriodicDates dividendValuationDates_;
        public AdjustableRelativeOrPeriodicDates DividendValuationDates_
        {
            get
            {
                if (this.dividendValuationDates_ != null)
                {
                    return this.dividendValuationDates_; 
                }
                else if (this.dividendValuationDatesIDRef_ != null)
                {
                    dividendValuationDates_ = IDManager.getID(dividendValuationDatesIDRef_) as AdjustableRelativeOrPeriodicDates;
                    return this.dividendValuationDates_; 
                }
                else
                {
                      return this.dividendValuationDates_; 
                }
            }
            set
            {
                if (this.dividendValuationDates_ != value)
                {
                    this.dividendValuationDates_ = value;
                }
            }
        }
        #endregion
        
        public string dividendValuationDatesIDRef_ { get; set; }
        #region FPVFinalPriceElectionFallback_
        private FPVFinalPriceElectionFallbackEnum fPVFinalPriceElectionFallback_;
        public FPVFinalPriceElectionFallbackEnum FPVFinalPriceElectionFallback_
        {
            get
            {
                if (this.fPVFinalPriceElectionFallback_ != null)
                {
                    return this.fPVFinalPriceElectionFallback_; 
                }
                else if (this.fPVFinalPriceElectionFallbackIDRef_ != null)
                {
                    fPVFinalPriceElectionFallback_ = IDManager.getID(fPVFinalPriceElectionFallbackIDRef_) as FPVFinalPriceElectionFallbackEnum;
                    return this.fPVFinalPriceElectionFallback_; 
                }
                else
                {
                      return this.fPVFinalPriceElectionFallback_; 
                }
            }
            set
            {
                if (this.fPVFinalPriceElectionFallback_ != value)
                {
                    this.fPVFinalPriceElectionFallback_ = value;
                }
            }
        }
        #endregion
        
        public string fPVFinalPriceElectionFallbackIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


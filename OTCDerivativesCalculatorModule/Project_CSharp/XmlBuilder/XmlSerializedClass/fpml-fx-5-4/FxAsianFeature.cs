using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxAsianFeature : ISerialized
    {
        public FxAsianFeature(XmlNode xmlNode)
        {
            XmlNode primaryRateSourceNode = xmlNode.SelectSingleNode("primaryRateSource");
            
            if (primaryRateSourceNode != null)
            {
                if (primaryRateSourceNode.Attributes["href"] != null || primaryRateSourceNode.Attributes["id"] != null) 
                {
                    if (primaryRateSourceNode.Attributes["id"] != null) 
                    {
                        primaryRateSourceIDRef_ = primaryRateSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(primaryRateSourceNode);
                        IDManager.SetID(primaryRateSourceIDRef_, ob);
                    }
                    else if (primaryRateSourceNode.Attributes["href"] != null)
                    {
                        primaryRateSourceIDRef_ = primaryRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        primaryRateSource_ = new InformationSource(primaryRateSourceNode);
                    }
                }
                else
                {
                    primaryRateSource_ = new InformationSource(primaryRateSourceNode);
                }
            }
            
        
            XmlNode secondaryRateSourceNode = xmlNode.SelectSingleNode("secondaryRateSource");
            
            if (secondaryRateSourceNode != null)
            {
                if (secondaryRateSourceNode.Attributes["href"] != null || secondaryRateSourceNode.Attributes["id"] != null) 
                {
                    if (secondaryRateSourceNode.Attributes["id"] != null) 
                    {
                        secondaryRateSourceIDRef_ = secondaryRateSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(secondaryRateSourceNode);
                        IDManager.SetID(secondaryRateSourceIDRef_, ob);
                    }
                    else if (secondaryRateSourceNode.Attributes["href"] != null)
                    {
                        secondaryRateSourceIDRef_ = secondaryRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        secondaryRateSource_ = new InformationSource(secondaryRateSourceNode);
                    }
                }
                else
                {
                    secondaryRateSource_ = new InformationSource(secondaryRateSourceNode);
                }
            }
            
        
            XmlNode fixingTimeNode = xmlNode.SelectSingleNode("fixingTime");
            
            if (fixingTimeNode != null)
            {
                if (fixingTimeNode.Attributes["href"] != null || fixingTimeNode.Attributes["id"] != null) 
                {
                    if (fixingTimeNode.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(fixingTimeNode);
                        IDManager.SetID(fixingTimeIDRef_, ob);
                    }
                    else if (fixingTimeNode.Attributes["href"] != null)
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                    }
                }
                else
                {
                    fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                }
            }
            
        
            XmlNode observationScheduleNode = xmlNode.SelectSingleNode("observationSchedule");
            
            if (observationScheduleNode != null)
            {
                if (observationScheduleNode.Attributes["href"] != null || observationScheduleNode.Attributes["id"] != null) 
                {
                    if (observationScheduleNode.Attributes["id"] != null) 
                    {
                        observationScheduleIDRef_ = observationScheduleNode.Attributes["id"].Value;
                        FxAverageRateObservationSchedule ob = new FxAverageRateObservationSchedule(observationScheduleNode);
                        IDManager.SetID(observationScheduleIDRef_, ob);
                    }
                    else if (observationScheduleNode.Attributes["href"] != null)
                    {
                        observationScheduleIDRef_ = observationScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationSchedule_ = new FxAverageRateObservationSchedule(observationScheduleNode);
                    }
                }
                else
                {
                    observationSchedule_ = new FxAverageRateObservationSchedule(observationScheduleNode);
                }
            }
            
        
            XmlNodeList rateObservationNodeList = xmlNode.SelectNodes("rateObservation");
            
            if (rateObservationNodeList != null)
            {
                this.rateObservation_ = new List<FxAverageRateObservation>();
                foreach (XmlNode item in rateObservationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            rateObservationIDRef_ = item.Attributes["id"].Value;
                            rateObservation_.Add(new FxAverageRateObservation(item));
                            IDManager.SetID(rateObservationIDRef_, rateObservation_[rateObservation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            rateObservationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        rateObservation_.Add(new FxAverageRateObservation(item));
                        }
                    }
                    else
                    {
                        rateObservation_.Add(new FxAverageRateObservation(item));
                    }
                }
            }
            
        
            XmlNode rateObservationQuoteBasisNode = xmlNode.SelectSingleNode("rateObservationQuoteBasis");
            
            if (rateObservationQuoteBasisNode != null)
            {
                if (rateObservationQuoteBasisNode.Attributes["href"] != null || rateObservationQuoteBasisNode.Attributes["id"] != null) 
                {
                    if (rateObservationQuoteBasisNode.Attributes["id"] != null) 
                    {
                        rateObservationQuoteBasisIDRef_ = rateObservationQuoteBasisNode.Attributes["id"].Value;
                        StrikeQuoteBasisEnum ob = new StrikeQuoteBasisEnum(rateObservationQuoteBasisNode);
                        IDManager.SetID(rateObservationQuoteBasisIDRef_, ob);
                    }
                    else if (rateObservationQuoteBasisNode.Attributes["href"] != null)
                    {
                        rateObservationQuoteBasisIDRef_ = rateObservationQuoteBasisNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateObservationQuoteBasis_ = new StrikeQuoteBasisEnum(rateObservationQuoteBasisNode);
                    }
                }
                else
                {
                    rateObservationQuoteBasis_ = new StrikeQuoteBasisEnum(rateObservationQuoteBasisNode);
                }
            }
            
        
            XmlNode payoutFormulaNode = xmlNode.SelectSingleNode("payoutFormula");
            
            if (payoutFormulaNode != null)
            {
                if (payoutFormulaNode.Attributes["href"] != null || payoutFormulaNode.Attributes["id"] != null) 
                {
                    if (payoutFormulaNode.Attributes["id"] != null) 
                    {
                        payoutFormulaIDRef_ = payoutFormulaNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(payoutFormulaNode);
                        IDManager.SetID(payoutFormulaIDRef_, ob);
                    }
                    else if (payoutFormulaNode.Attributes["href"] != null)
                    {
                        payoutFormulaIDRef_ = payoutFormulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoutFormula_ = new XsdTypeString(payoutFormulaNode);
                    }
                }
                else
                {
                    payoutFormula_ = new XsdTypeString(payoutFormulaNode);
                }
            }
            
        
            XmlNode precisionNode = xmlNode.SelectSingleNode("precision");
            
            if (precisionNode != null)
            {
                if (precisionNode.Attributes["href"] != null || precisionNode.Attributes["id"] != null) 
                {
                    if (precisionNode.Attributes["id"] != null) 
                    {
                        precisionIDRef_ = precisionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(precisionNode);
                        IDManager.SetID(precisionIDRef_, ob);
                    }
                    else if (precisionNode.Attributes["href"] != null)
                    {
                        precisionIDRef_ = precisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        precision_ = new XsdTypeNonNegativeInteger(precisionNode);
                    }
                }
                else
                {
                    precision_ = new XsdTypeNonNegativeInteger(precisionNode);
                }
            }
            
        
        }
        
    
        #region PrimaryRateSource_
        private InformationSource primaryRateSource_;
        public InformationSource PrimaryRateSource_
        {
            get
            {
                if (this.primaryRateSource_ != null)
                {
                    return this.primaryRateSource_; 
                }
                else if (this.primaryRateSourceIDRef_ != null)
                {
                    primaryRateSource_ = IDManager.getID(primaryRateSourceIDRef_) as InformationSource;
                    return this.primaryRateSource_; 
                }
                else
                {
                      return this.primaryRateSource_; 
                }
            }
            set
            {
                if (this.primaryRateSource_ != value)
                {
                    this.primaryRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string primaryRateSourceIDRef_ { get; set; }
        #region SecondaryRateSource_
        private InformationSource secondaryRateSource_;
        public InformationSource SecondaryRateSource_
        {
            get
            {
                if (this.secondaryRateSource_ != null)
                {
                    return this.secondaryRateSource_; 
                }
                else if (this.secondaryRateSourceIDRef_ != null)
                {
                    secondaryRateSource_ = IDManager.getID(secondaryRateSourceIDRef_) as InformationSource;
                    return this.secondaryRateSource_; 
                }
                else
                {
                      return this.secondaryRateSource_; 
                }
            }
            set
            {
                if (this.secondaryRateSource_ != value)
                {
                    this.secondaryRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string secondaryRateSourceIDRef_ { get; set; }
        #region FixingTime_
        private BusinessCenterTime fixingTime_;
        public BusinessCenterTime FixingTime_
        {
            get
            {
                if (this.fixingTime_ != null)
                {
                    return this.fixingTime_; 
                }
                else if (this.fixingTimeIDRef_ != null)
                {
                    fixingTime_ = IDManager.getID(fixingTimeIDRef_) as BusinessCenterTime;
                    return this.fixingTime_; 
                }
                else
                {
                      return this.fixingTime_; 
                }
            }
            set
            {
                if (this.fixingTime_ != value)
                {
                    this.fixingTime_ = value;
                }
            }
        }
        #endregion
        
        public string fixingTimeIDRef_ { get; set; }
        #region ObservationSchedule_
        private FxAverageRateObservationSchedule observationSchedule_;
        public FxAverageRateObservationSchedule ObservationSchedule_
        {
            get
            {
                if (this.observationSchedule_ != null)
                {
                    return this.observationSchedule_; 
                }
                else if (this.observationScheduleIDRef_ != null)
                {
                    observationSchedule_ = IDManager.getID(observationScheduleIDRef_) as FxAverageRateObservationSchedule;
                    return this.observationSchedule_; 
                }
                else
                {
                      return this.observationSchedule_; 
                }
            }
            set
            {
                if (this.observationSchedule_ != value)
                {
                    this.observationSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string observationScheduleIDRef_ { get; set; }
        #region RateObservation_
        private List<FxAverageRateObservation> rateObservation_;
        public List<FxAverageRateObservation> RateObservation_
        {
            get
            {
                if (this.rateObservation_ != null)
                {
                    return this.rateObservation_; 
                }
                else if (this.rateObservationIDRef_ != null)
                {
                    return this.rateObservation_; 
                }
                else
                {
                      return this.rateObservation_; 
                }
            }
            set
            {
                if (this.rateObservation_ != value)
                {
                    this.rateObservation_ = value;
                }
            }
        }
        #endregion
        
        public string rateObservationIDRef_ { get; set; }
        #region RateObservationQuoteBasis_
        private StrikeQuoteBasisEnum rateObservationQuoteBasis_;
        public StrikeQuoteBasisEnum RateObservationQuoteBasis_
        {
            get
            {
                if (this.rateObservationQuoteBasis_ != null)
                {
                    return this.rateObservationQuoteBasis_; 
                }
                else if (this.rateObservationQuoteBasisIDRef_ != null)
                {
                    rateObservationQuoteBasis_ = IDManager.getID(rateObservationQuoteBasisIDRef_) as StrikeQuoteBasisEnum;
                    return this.rateObservationQuoteBasis_; 
                }
                else
                {
                      return this.rateObservationQuoteBasis_; 
                }
            }
            set
            {
                if (this.rateObservationQuoteBasis_ != value)
                {
                    this.rateObservationQuoteBasis_ = value;
                }
            }
        }
        #endregion
        
        public string rateObservationQuoteBasisIDRef_ { get; set; }
        #region PayoutFormula_
        private XsdTypeString payoutFormula_;
        public XsdTypeString PayoutFormula_
        {
            get
            {
                if (this.payoutFormula_ != null)
                {
                    return this.payoutFormula_; 
                }
                else if (this.payoutFormulaIDRef_ != null)
                {
                    payoutFormula_ = IDManager.getID(payoutFormulaIDRef_) as XsdTypeString;
                    return this.payoutFormula_; 
                }
                else
                {
                      return this.payoutFormula_; 
                }
            }
            set
            {
                if (this.payoutFormula_ != value)
                {
                    this.payoutFormula_ = value;
                }
            }
        }
        #endregion
        
        public string payoutFormulaIDRef_ { get; set; }
        #region Precision_
        private XsdTypeNonNegativeInteger precision_;
        public XsdTypeNonNegativeInteger Precision_
        {
            get
            {
                if (this.precision_ != null)
                {
                    return this.precision_; 
                }
                else if (this.precisionIDRef_ != null)
                {
                    precision_ = IDManager.getID(precisionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.precision_; 
                }
                else
                {
                      return this.precision_; 
                }
            }
            set
            {
                if (this.precision_ != value)
                {
                    this.precision_ = value;
                }
            }
        }
        #endregion
        
        public string precisionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxAsianFeature
    {
        public FxAsianFeature(XmlNode xmlNode)
        {
            XmlNodeList primaryRateSourceNodeList = xmlNode.SelectNodes("primaryRateSource");
            if (primaryRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in primaryRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        primaryRateSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(primaryRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        primaryRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        primaryRateSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList secondaryRateSourceNodeList = xmlNode.SelectNodes("secondaryRateSource");
            if (secondaryRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in secondaryRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        secondaryRateSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(secondaryRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        secondaryRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        secondaryRateSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList fixingTimeNodeList = xmlNode.SelectNodes("fixingTime");
            if (fixingTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(fixingTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList observationScheduleNodeList = xmlNode.SelectNodes("observationSchedule");
            if (observationScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationScheduleIDRef = item.Attributes["id"].Name;
                        FxAverageRateObservationSchedule ob = FxAverageRateObservationSchedule();
                        IDManager.SetID(observationScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationSchedule = new FxAverageRateObservationSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList rateObservationNodeList = xmlNode.SelectNodes("rateObservation");
            
            foreach (XmlNode item in rateObservationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateObservationIDRef = item.Attributes["id"].Name;
                        List<FxAverageRateObservation> ob = new List<FxAverageRateObservation>();
                        ob.Add(new FxAverageRateObservation(item));
                        IDManager.SetID(rateObservationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateObservationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    rateObservation.Add(new FxAverageRateObservation(item));
                    }
                }
            }
            
        
            XmlNodeList rateObservationQuoteBasisNodeList = xmlNode.SelectNodes("rateObservationQuoteBasis");
            if (rateObservationQuoteBasisNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateObservationQuoteBasisNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateObservationQuoteBasisIDRef = item.Attributes["id"].Name;
                        StrikeQuoteBasisEnum ob = StrikeQuoteBasisEnum();
                        IDManager.SetID(rateObservationQuoteBasisIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateObservationQuoteBasisIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateObservationQuoteBasis = new StrikeQuoteBasisEnum(item);
                    }
                }
            }
            
        
            XmlNodeList payoutFormulaNodeList = xmlNode.SelectNodes("payoutFormula");
            if (payoutFormulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payoutFormulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payoutFormulaIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(payoutFormulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payoutFormulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payoutFormula = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList precisionNodeList = xmlNode.SelectNodes("precision");
            if (precisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in precisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        precisionIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(precisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        precisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        precision = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region PrimaryRateSource
        private InformationSource primaryRateSource;
        public InformationSource PrimaryRateSource
        {
            get
            {
                if (this.primaryRateSource != null)
                {
                    return this.primaryRateSource; 
                }
                else if (this.primaryRateSourceIDRef != null)
                {
                    primaryRateSource = IDManager.getID(primaryRateSourceIDRef) as InformationSource;
                    return this.primaryRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.primaryRateSource != value)
                {
                    this.primaryRateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region SecondaryRateSource
        private InformationSource secondaryRateSource;
        public InformationSource SecondaryRateSource
        {
            get
            {
                if (this.secondaryRateSource != null)
                {
                    return this.secondaryRateSource; 
                }
                else if (this.secondaryRateSourceIDRef != null)
                {
                    secondaryRateSource = IDManager.getID(secondaryRateSourceIDRef) as InformationSource;
                    return this.secondaryRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.secondaryRateSource != value)
                {
                    this.secondaryRateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region FixingTime
        private BusinessCenterTime fixingTime;
        public BusinessCenterTime FixingTime
        {
            get
            {
                if (this.fixingTime != null)
                {
                    return this.fixingTime; 
                }
                else if (this.fixingTimeIDRef != null)
                {
                    fixingTime = IDManager.getID(fixingTimeIDRef) as BusinessCenterTime;
                    return this.fixingTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingTime != value)
                {
                    this.fixingTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region ObservationSchedule
        private FxAverageRateObservationSchedule observationSchedule;
        public FxAverageRateObservationSchedule ObservationSchedule
        {
            get
            {
                if (this.observationSchedule != null)
                {
                    return this.observationSchedule; 
                }
                else if (this.observationScheduleIDRef != null)
                {
                    observationSchedule = IDManager.getID(observationScheduleIDRef) as FxAverageRateObservationSchedule;
                    return this.observationSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationSchedule != value)
                {
                    this.observationSchedule = value;
                }
            }
        }
        #endregion
        
        public string FxAverageRateObservationScheduleIDRef { get; set; }
        #region RateObservation
        private List<FxAverageRateObservation> rateObservation;
        public List<FxAverageRateObservation> RateObservation
        {
            get
            {
                if (this.rateObservation != null)
                {
                    return this.rateObservation; 
                }
                else if (this.rateObservationIDRef != null)
                {
                    rateObservation = IDManager.getID(rateObservationIDRef) as List<FxAverageRateObservation>;
                    return this.rateObservation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateObservation != value)
                {
                    this.rateObservation = value;
                }
            }
        }
        #endregion
        
        public string FxAverageRateObservationIDRef { get; set; }
        #region RateObservationQuoteBasis
        private StrikeQuoteBasisEnum rateObservationQuoteBasis;
        public StrikeQuoteBasisEnum RateObservationQuoteBasis
        {
            get
            {
                if (this.rateObservationQuoteBasis != null)
                {
                    return this.rateObservationQuoteBasis; 
                }
                else if (this.rateObservationQuoteBasisIDRef != null)
                {
                    rateObservationQuoteBasis = IDManager.getID(rateObservationQuoteBasisIDRef) as StrikeQuoteBasisEnum;
                    return this.rateObservationQuoteBasis; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateObservationQuoteBasis != value)
                {
                    this.rateObservationQuoteBasis = value;
                }
            }
        }
        #endregion
        
        public string StrikeQuoteBasisEnumIDRef { get; set; }
        #region PayoutFormula
        private XsdTypeString payoutFormula;
        public XsdTypeString PayoutFormula
        {
            get
            {
                if (this.payoutFormula != null)
                {
                    return this.payoutFormula; 
                }
                else if (this.payoutFormulaIDRef != null)
                {
                    payoutFormula = IDManager.getID(payoutFormulaIDRef) as XsdTypeString;
                    return this.payoutFormula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payoutFormula != value)
                {
                    this.payoutFormula = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region Precision
        private XsdTypeNonNegativeInteger precision;
        public XsdTypeNonNegativeInteger Precision
        {
            get
            {
                if (this.precision != null)
                {
                    return this.precision; 
                }
                else if (this.precisionIDRef != null)
                {
                    precision = IDManager.getID(precisionIDRef) as XsdTypeNonNegativeInteger;
                    return this.precision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.precision != value)
                {
                    this.precision = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriodDates : ISerialized
    {
        public CalculationPeriodDates(XmlNode xmlNode)
        {
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableDate(effectiveDateNode);
                }
            }
            
        
            XmlNode relativeEffectiveDateNode = xmlNode.SelectSingleNode("relativeEffectiveDate");
            
            if (relativeEffectiveDateNode != null)
            {
                if (relativeEffectiveDateNode.Attributes["href"] != null || relativeEffectiveDateNode.Attributes["id"] != null) 
                {
                    if (relativeEffectiveDateNode.Attributes["id"] != null) 
                    {
                        relativeEffectiveDateIDRef_ = relativeEffectiveDateNode.Attributes["id"].Value;
                        AdjustedRelativeDateOffset ob = new AdjustedRelativeDateOffset(relativeEffectiveDateNode);
                        IDManager.SetID(relativeEffectiveDateIDRef_, ob);
                    }
                    else if (relativeEffectiveDateNode.Attributes["href"] != null)
                    {
                        relativeEffectiveDateIDRef_ = relativeEffectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeEffectiveDate_ = new AdjustedRelativeDateOffset(relativeEffectiveDateNode);
                    }
                }
                else
                {
                    relativeEffectiveDate_ = new AdjustedRelativeDateOffset(relativeEffectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new AdjustableDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new AdjustableDate(terminationDateNode);
                }
            }
            
        
            XmlNode relativeTerminationDateNode = xmlNode.SelectSingleNode("relativeTerminationDate");
            
            if (relativeTerminationDateNode != null)
            {
                if (relativeTerminationDateNode.Attributes["href"] != null || relativeTerminationDateNode.Attributes["id"] != null) 
                {
                    if (relativeTerminationDateNode.Attributes["id"] != null) 
                    {
                        relativeTerminationDateIDRef_ = relativeTerminationDateNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(relativeTerminationDateNode);
                        IDManager.SetID(relativeTerminationDateIDRef_, ob);
                    }
                    else if (relativeTerminationDateNode.Attributes["href"] != null)
                    {
                        relativeTerminationDateIDRef_ = relativeTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeTerminationDate_ = new RelativeDateOffset(relativeTerminationDateNode);
                    }
                }
                else
                {
                    relativeTerminationDate_ = new RelativeDateOffset(relativeTerminationDateNode);
                }
            }
            
        
            XmlNode calculationPeriodDatesAdjustmentsNode = xmlNode.SelectSingleNode("calculationPeriodDatesAdjustments");
            
            if (calculationPeriodDatesAdjustmentsNode != null)
            {
                if (calculationPeriodDatesAdjustmentsNode.Attributes["href"] != null || calculationPeriodDatesAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesAdjustmentsNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesAdjustmentsIDRef_ = calculationPeriodDatesAdjustmentsNode.Attributes["id"].Value;
                        BusinessDayAdjustments ob = new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode);
                        IDManager.SetID(calculationPeriodDatesAdjustmentsIDRef_, ob);
                    }
                    else if (calculationPeriodDatesAdjustmentsNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesAdjustmentsIDRef_ = calculationPeriodDatesAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDatesAdjustments_ = new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode);
                    }
                }
                else
                {
                    calculationPeriodDatesAdjustments_ = new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode);
                }
            }
            
        
            XmlNode firstPeriodStartDateNode = xmlNode.SelectSingleNode("firstPeriodStartDate");
            
            if (firstPeriodStartDateNode != null)
            {
                if (firstPeriodStartDateNode.Attributes["href"] != null || firstPeriodStartDateNode.Attributes["id"] != null) 
                {
                    if (firstPeriodStartDateNode.Attributes["id"] != null) 
                    {
                        firstPeriodStartDateIDRef_ = firstPeriodStartDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(firstPeriodStartDateNode);
                        IDManager.SetID(firstPeriodStartDateIDRef_, ob);
                    }
                    else if (firstPeriodStartDateNode.Attributes["href"] != null)
                    {
                        firstPeriodStartDateIDRef_ = firstPeriodStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstPeriodStartDate_ = new AdjustableDate(firstPeriodStartDateNode);
                    }
                }
                else
                {
                    firstPeriodStartDate_ = new AdjustableDate(firstPeriodStartDateNode);
                }
            }
            
        
            XmlNode firstRegularPeriodStartDateNode = xmlNode.SelectSingleNode("firstRegularPeriodStartDate");
            
            if (firstRegularPeriodStartDateNode != null)
            {
                if (firstRegularPeriodStartDateNode.Attributes["href"] != null || firstRegularPeriodStartDateNode.Attributes["id"] != null) 
                {
                    if (firstRegularPeriodStartDateNode.Attributes["id"] != null) 
                    {
                        firstRegularPeriodStartDateIDRef_ = firstRegularPeriodStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstRegularPeriodStartDateNode);
                        IDManager.SetID(firstRegularPeriodStartDateIDRef_, ob);
                    }
                    else if (firstRegularPeriodStartDateNode.Attributes["href"] != null)
                    {
                        firstRegularPeriodStartDateIDRef_ = firstRegularPeriodStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstRegularPeriodStartDate_ = new XsdTypeDate(firstRegularPeriodStartDateNode);
                    }
                }
                else
                {
                    firstRegularPeriodStartDate_ = new XsdTypeDate(firstRegularPeriodStartDateNode);
                }
            }
            
        
            XmlNode firstCompoundingPeriodEndDateNode = xmlNode.SelectSingleNode("firstCompoundingPeriodEndDate");
            
            if (firstCompoundingPeriodEndDateNode != null)
            {
                if (firstCompoundingPeriodEndDateNode.Attributes["href"] != null || firstCompoundingPeriodEndDateNode.Attributes["id"] != null) 
                {
                    if (firstCompoundingPeriodEndDateNode.Attributes["id"] != null) 
                    {
                        firstCompoundingPeriodEndDateIDRef_ = firstCompoundingPeriodEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstCompoundingPeriodEndDateNode);
                        IDManager.SetID(firstCompoundingPeriodEndDateIDRef_, ob);
                    }
                    else if (firstCompoundingPeriodEndDateNode.Attributes["href"] != null)
                    {
                        firstCompoundingPeriodEndDateIDRef_ = firstCompoundingPeriodEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstCompoundingPeriodEndDate_ = new XsdTypeDate(firstCompoundingPeriodEndDateNode);
                    }
                }
                else
                {
                    firstCompoundingPeriodEndDate_ = new XsdTypeDate(firstCompoundingPeriodEndDateNode);
                }
            }
            
        
            XmlNode lastRegularPeriodEndDateNode = xmlNode.SelectSingleNode("lastRegularPeriodEndDate");
            
            if (lastRegularPeriodEndDateNode != null)
            {
                if (lastRegularPeriodEndDateNode.Attributes["href"] != null || lastRegularPeriodEndDateNode.Attributes["id"] != null) 
                {
                    if (lastRegularPeriodEndDateNode.Attributes["id"] != null) 
                    {
                        lastRegularPeriodEndDateIDRef_ = lastRegularPeriodEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(lastRegularPeriodEndDateNode);
                        IDManager.SetID(lastRegularPeriodEndDateIDRef_, ob);
                    }
                    else if (lastRegularPeriodEndDateNode.Attributes["href"] != null)
                    {
                        lastRegularPeriodEndDateIDRef_ = lastRegularPeriodEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lastRegularPeriodEndDate_ = new XsdTypeDate(lastRegularPeriodEndDateNode);
                    }
                }
                else
                {
                    lastRegularPeriodEndDate_ = new XsdTypeDate(lastRegularPeriodEndDateNode);
                }
            }
            
        
            XmlNode stubPeriodTypeNode = xmlNode.SelectSingleNode("stubPeriodType");
            
            if (stubPeriodTypeNode != null)
            {
                if (stubPeriodTypeNode.Attributes["href"] != null || stubPeriodTypeNode.Attributes["id"] != null) 
                {
                    if (stubPeriodTypeNode.Attributes["id"] != null) 
                    {
                        stubPeriodTypeIDRef_ = stubPeriodTypeNode.Attributes["id"].Value;
                        StubPeriodTypeEnum ob = new StubPeriodTypeEnum(stubPeriodTypeNode);
                        IDManager.SetID(stubPeriodTypeIDRef_, ob);
                    }
                    else if (stubPeriodTypeNode.Attributes["href"] != null)
                    {
                        stubPeriodTypeIDRef_ = stubPeriodTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubPeriodType_ = new StubPeriodTypeEnum(stubPeriodTypeNode);
                    }
                }
                else
                {
                    stubPeriodType_ = new StubPeriodTypeEnum(stubPeriodTypeNode);
                }
            }
            
        
            XmlNode calculationPeriodFrequencyNode = xmlNode.SelectSingleNode("calculationPeriodFrequency");
            
            if (calculationPeriodFrequencyNode != null)
            {
                if (calculationPeriodFrequencyNode.Attributes["href"] != null || calculationPeriodFrequencyNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodFrequencyNode.Attributes["id"] != null) 
                    {
                        calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode.Attributes["id"].Value;
                        CalculationPeriodFrequency ob = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                        IDManager.SetID(calculationPeriodFrequencyIDRef_, ob);
                    }
                    else if (calculationPeriodFrequencyNode.Attributes["href"] != null)
                    {
                        calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodFrequency_ = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                    }
                }
                else
                {
                    calculationPeriodFrequency_ = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                }
            }
            
        
        }
        
    
        #region EffectiveDate_
        private AdjustableDate effectiveDate_;
        public AdjustableDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region RelativeEffectiveDate_
        private AdjustedRelativeDateOffset relativeEffectiveDate_;
        public AdjustedRelativeDateOffset RelativeEffectiveDate_
        {
            get
            {
                if (this.relativeEffectiveDate_ != null)
                {
                    return this.relativeEffectiveDate_; 
                }
                else if (this.relativeEffectiveDateIDRef_ != null)
                {
                    relativeEffectiveDate_ = IDManager.getID(relativeEffectiveDateIDRef_) as AdjustedRelativeDateOffset;
                    return this.relativeEffectiveDate_; 
                }
                else
                {
                      return this.relativeEffectiveDate_; 
                }
            }
            set
            {
                if (this.relativeEffectiveDate_ != value)
                {
                    this.relativeEffectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string relativeEffectiveDateIDRef_ { get; set; }
        #region TerminationDate_
        private AdjustableDate terminationDate_;
        public AdjustableDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as AdjustableDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
        #region RelativeTerminationDate_
        private RelativeDateOffset relativeTerminationDate_;
        public RelativeDateOffset RelativeTerminationDate_
        {
            get
            {
                if (this.relativeTerminationDate_ != null)
                {
                    return this.relativeTerminationDate_; 
                }
                else if (this.relativeTerminationDateIDRef_ != null)
                {
                    relativeTerminationDate_ = IDManager.getID(relativeTerminationDateIDRef_) as RelativeDateOffset;
                    return this.relativeTerminationDate_; 
                }
                else
                {
                      return this.relativeTerminationDate_; 
                }
            }
            set
            {
                if (this.relativeTerminationDate_ != value)
                {
                    this.relativeTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string relativeTerminationDateIDRef_ { get; set; }
        #region CalculationPeriodDatesAdjustments_
        private BusinessDayAdjustments calculationPeriodDatesAdjustments_;
        public BusinessDayAdjustments CalculationPeriodDatesAdjustments_
        {
            get
            {
                if (this.calculationPeriodDatesAdjustments_ != null)
                {
                    return this.calculationPeriodDatesAdjustments_; 
                }
                else if (this.calculationPeriodDatesAdjustmentsIDRef_ != null)
                {
                    calculationPeriodDatesAdjustments_ = IDManager.getID(calculationPeriodDatesAdjustmentsIDRef_) as BusinessDayAdjustments;
                    return this.calculationPeriodDatesAdjustments_; 
                }
                else
                {
                      return this.calculationPeriodDatesAdjustments_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesAdjustments_ != value)
                {
                    this.calculationPeriodDatesAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesAdjustmentsIDRef_ { get; set; }
        #region FirstPeriodStartDate_
        private AdjustableDate firstPeriodStartDate_;
        public AdjustableDate FirstPeriodStartDate_
        {
            get
            {
                if (this.firstPeriodStartDate_ != null)
                {
                    return this.firstPeriodStartDate_; 
                }
                else if (this.firstPeriodStartDateIDRef_ != null)
                {
                    firstPeriodStartDate_ = IDManager.getID(firstPeriodStartDateIDRef_) as AdjustableDate;
                    return this.firstPeriodStartDate_; 
                }
                else
                {
                      return this.firstPeriodStartDate_; 
                }
            }
            set
            {
                if (this.firstPeriodStartDate_ != value)
                {
                    this.firstPeriodStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstPeriodStartDateIDRef_ { get; set; }
        #region FirstRegularPeriodStartDate_
        private XsdTypeDate firstRegularPeriodStartDate_;
        public XsdTypeDate FirstRegularPeriodStartDate_
        {
            get
            {
                if (this.firstRegularPeriodStartDate_ != null)
                {
                    return this.firstRegularPeriodStartDate_; 
                }
                else if (this.firstRegularPeriodStartDateIDRef_ != null)
                {
                    firstRegularPeriodStartDate_ = IDManager.getID(firstRegularPeriodStartDateIDRef_) as XsdTypeDate;
                    return this.firstRegularPeriodStartDate_; 
                }
                else
                {
                      return this.firstRegularPeriodStartDate_; 
                }
            }
            set
            {
                if (this.firstRegularPeriodStartDate_ != value)
                {
                    this.firstRegularPeriodStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstRegularPeriodStartDateIDRef_ { get; set; }
        #region FirstCompoundingPeriodEndDate_
        private XsdTypeDate firstCompoundingPeriodEndDate_;
        public XsdTypeDate FirstCompoundingPeriodEndDate_
        {
            get
            {
                if (this.firstCompoundingPeriodEndDate_ != null)
                {
                    return this.firstCompoundingPeriodEndDate_; 
                }
                else if (this.firstCompoundingPeriodEndDateIDRef_ != null)
                {
                    firstCompoundingPeriodEndDate_ = IDManager.getID(firstCompoundingPeriodEndDateIDRef_) as XsdTypeDate;
                    return this.firstCompoundingPeriodEndDate_; 
                }
                else
                {
                      return this.firstCompoundingPeriodEndDate_; 
                }
            }
            set
            {
                if (this.firstCompoundingPeriodEndDate_ != value)
                {
                    this.firstCompoundingPeriodEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstCompoundingPeriodEndDateIDRef_ { get; set; }
        #region LastRegularPeriodEndDate_
        private XsdTypeDate lastRegularPeriodEndDate_;
        public XsdTypeDate LastRegularPeriodEndDate_
        {
            get
            {
                if (this.lastRegularPeriodEndDate_ != null)
                {
                    return this.lastRegularPeriodEndDate_; 
                }
                else if (this.lastRegularPeriodEndDateIDRef_ != null)
                {
                    lastRegularPeriodEndDate_ = IDManager.getID(lastRegularPeriodEndDateIDRef_) as XsdTypeDate;
                    return this.lastRegularPeriodEndDate_; 
                }
                else
                {
                      return this.lastRegularPeriodEndDate_; 
                }
            }
            set
            {
                if (this.lastRegularPeriodEndDate_ != value)
                {
                    this.lastRegularPeriodEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string lastRegularPeriodEndDateIDRef_ { get; set; }
        #region StubPeriodType_
        private StubPeriodTypeEnum stubPeriodType_;
        public StubPeriodTypeEnum StubPeriodType_
        {
            get
            {
                if (this.stubPeriodType_ != null)
                {
                    return this.stubPeriodType_; 
                }
                else if (this.stubPeriodTypeIDRef_ != null)
                {
                    stubPeriodType_ = IDManager.getID(stubPeriodTypeIDRef_) as StubPeriodTypeEnum;
                    return this.stubPeriodType_; 
                }
                else
                {
                      return this.stubPeriodType_; 
                }
            }
            set
            {
                if (this.stubPeriodType_ != value)
                {
                    this.stubPeriodType_ = value;
                }
            }
        }
        #endregion
        
        public string stubPeriodTypeIDRef_ { get; set; }
        #region CalculationPeriodFrequency_
        private CalculationPeriodFrequency calculationPeriodFrequency_;
        public CalculationPeriodFrequency CalculationPeriodFrequency_
        {
            get
            {
                if (this.calculationPeriodFrequency_ != null)
                {
                    return this.calculationPeriodFrequency_; 
                }
                else if (this.calculationPeriodFrequencyIDRef_ != null)
                {
                    calculationPeriodFrequency_ = IDManager.getID(calculationPeriodFrequencyIDRef_) as CalculationPeriodFrequency;
                    return this.calculationPeriodFrequency_; 
                }
                else
                {
                      return this.calculationPeriodFrequency_; 
                }
            }
            set
            {
                if (this.calculationPeriodFrequency_ != value)
                {
                    this.calculationPeriodFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodFrequencyIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


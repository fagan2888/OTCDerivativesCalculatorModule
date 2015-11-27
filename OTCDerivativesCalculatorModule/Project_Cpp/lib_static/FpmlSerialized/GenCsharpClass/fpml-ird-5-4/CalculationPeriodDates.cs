using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriodDates
    {
        public CalculationPeriodDates(XmlNode xmlNode)
        {
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList relativeEffectiveDateNodeList = xmlNode.SelectNodes("relativeEffectiveDate");
            if (relativeEffectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeEffectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeEffectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustedRelativeDateOffset ob = AdjustedRelativeDateOffset();
                        IDManager.SetID(relativeEffectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeEffectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeEffectiveDate = new AdjustedRelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList terminationDateNodeList = xmlNode.SelectNodes("terminationDate");
            if (terminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(terminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminationDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList relativeTerminationDateNodeList = xmlNode.SelectNodes("relativeTerminationDate");
            if (relativeTerminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeTerminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeTerminationDateIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(relativeTerminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeTerminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeTerminationDate = new RelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodDatesAdjustmentsNodeList = xmlNode.SelectNodes("calculationPeriodDatesAdjustments");
            if (calculationPeriodDatesAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodDatesAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(calculationPeriodDatesAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodDatesAdjustments = new BusinessDayAdjustments(item);
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
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(firstPeriodStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstPeriodStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstPeriodStartDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList firstRegularPeriodStartDateNodeList = xmlNode.SelectNodes("firstRegularPeriodStartDate");
            if (firstRegularPeriodStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstRegularPeriodStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstRegularPeriodStartDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(firstRegularPeriodStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstRegularPeriodStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstRegularPeriodStartDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList firstCompoundingPeriodEndDateNodeList = xmlNode.SelectNodes("firstCompoundingPeriodEndDate");
            if (firstCompoundingPeriodEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstCompoundingPeriodEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstCompoundingPeriodEndDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(firstCompoundingPeriodEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstCompoundingPeriodEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstCompoundingPeriodEndDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList lastRegularPeriodEndDateNodeList = xmlNode.SelectNodes("lastRegularPeriodEndDate");
            if (lastRegularPeriodEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lastRegularPeriodEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lastRegularPeriodEndDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(lastRegularPeriodEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lastRegularPeriodEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lastRegularPeriodEndDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList stubPeriodTypeNodeList = xmlNode.SelectNodes("stubPeriodType");
            if (stubPeriodTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubPeriodTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubPeriodTypeIDRef = item.Attributes["id"].Name;
                        StubPeriodTypeEnum ob = StubPeriodTypeEnum();
                        IDManager.SetID(stubPeriodTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubPeriodTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubPeriodType = new StubPeriodTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodFrequencyNodeList = xmlNode.SelectNodes("calculationPeriodFrequency");
            if (calculationPeriodFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodFrequencyIDRef = item.Attributes["id"].Name;
                        CalculationPeriodFrequency ob = CalculationPeriodFrequency();
                        IDManager.SetID(calculationPeriodFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodFrequency = new CalculationPeriodFrequency(item);
                    }
                }
            }
            
        
        }
        
    
        #region EffectiveDate
        private AdjustableDate effectiveDate;
        public AdjustableDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as AdjustableDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region RelativeEffectiveDate
        private AdjustedRelativeDateOffset relativeEffectiveDate;
        public AdjustedRelativeDateOffset RelativeEffectiveDate
        {
            get
            {
                if (this.relativeEffectiveDate != null)
                {
                    return this.relativeEffectiveDate; 
                }
                else if (this.relativeEffectiveDateIDRef != null)
                {
                    relativeEffectiveDate = IDManager.getID(relativeEffectiveDateIDRef) as AdjustedRelativeDateOffset;
                    return this.relativeEffectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeEffectiveDate != value)
                {
                    this.relativeEffectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustedRelativeDateOffsetIDRef { get; set; }
        #region TerminationDate
        private AdjustableDate terminationDate;
        public AdjustableDate TerminationDate
        {
            get
            {
                if (this.terminationDate != null)
                {
                    return this.terminationDate; 
                }
                else if (this.terminationDateIDRef != null)
                {
                    terminationDate = IDManager.getID(terminationDateIDRef) as AdjustableDate;
                    return this.terminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminationDate != value)
                {
                    this.terminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region RelativeTerminationDate
        private RelativeDateOffset relativeTerminationDate;
        public RelativeDateOffset RelativeTerminationDate
        {
            get
            {
                if (this.relativeTerminationDate != null)
                {
                    return this.relativeTerminationDate; 
                }
                else if (this.relativeTerminationDateIDRef != null)
                {
                    relativeTerminationDate = IDManager.getID(relativeTerminationDateIDRef) as RelativeDateOffset;
                    return this.relativeTerminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeTerminationDate != value)
                {
                    this.relativeTerminationDate = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        #region CalculationPeriodDatesAdjustments
        private BusinessDayAdjustments calculationPeriodDatesAdjustments;
        public BusinessDayAdjustments CalculationPeriodDatesAdjustments
        {
            get
            {
                if (this.calculationPeriodDatesAdjustments != null)
                {
                    return this.calculationPeriodDatesAdjustments; 
                }
                else if (this.calculationPeriodDatesAdjustmentsIDRef != null)
                {
                    calculationPeriodDatesAdjustments = IDManager.getID(calculationPeriodDatesAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.calculationPeriodDatesAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodDatesAdjustments != value)
                {
                    this.calculationPeriodDatesAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        #region FirstPeriodStartDate
        private AdjustableDate firstPeriodStartDate;
        public AdjustableDate FirstPeriodStartDate
        {
            get
            {
                if (this.firstPeriodStartDate != null)
                {
                    return this.firstPeriodStartDate; 
                }
                else if (this.firstPeriodStartDateIDRef != null)
                {
                    firstPeriodStartDate = IDManager.getID(firstPeriodStartDateIDRef) as AdjustableDate;
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
        
        public string AdjustableDateIDRef { get; set; }
        #region FirstRegularPeriodStartDate
        private XsdTypeDate firstRegularPeriodStartDate;
        public XsdTypeDate FirstRegularPeriodStartDate
        {
            get
            {
                if (this.firstRegularPeriodStartDate != null)
                {
                    return this.firstRegularPeriodStartDate; 
                }
                else if (this.firstRegularPeriodStartDateIDRef != null)
                {
                    firstRegularPeriodStartDate = IDManager.getID(firstRegularPeriodStartDateIDRef) as XsdTypeDate;
                    return this.firstRegularPeriodStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstRegularPeriodStartDate != value)
                {
                    this.firstRegularPeriodStartDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region FirstCompoundingPeriodEndDate
        private XsdTypeDate firstCompoundingPeriodEndDate;
        public XsdTypeDate FirstCompoundingPeriodEndDate
        {
            get
            {
                if (this.firstCompoundingPeriodEndDate != null)
                {
                    return this.firstCompoundingPeriodEndDate; 
                }
                else if (this.firstCompoundingPeriodEndDateIDRef != null)
                {
                    firstCompoundingPeriodEndDate = IDManager.getID(firstCompoundingPeriodEndDateIDRef) as XsdTypeDate;
                    return this.firstCompoundingPeriodEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstCompoundingPeriodEndDate != value)
                {
                    this.firstCompoundingPeriodEndDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region LastRegularPeriodEndDate
        private XsdTypeDate lastRegularPeriodEndDate;
        public XsdTypeDate LastRegularPeriodEndDate
        {
            get
            {
                if (this.lastRegularPeriodEndDate != null)
                {
                    return this.lastRegularPeriodEndDate; 
                }
                else if (this.lastRegularPeriodEndDateIDRef != null)
                {
                    lastRegularPeriodEndDate = IDManager.getID(lastRegularPeriodEndDateIDRef) as XsdTypeDate;
                    return this.lastRegularPeriodEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lastRegularPeriodEndDate != value)
                {
                    this.lastRegularPeriodEndDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region StubPeriodType
        private StubPeriodTypeEnum stubPeriodType;
        public StubPeriodTypeEnum StubPeriodType
        {
            get
            {
                if (this.stubPeriodType != null)
                {
                    return this.stubPeriodType; 
                }
                else if (this.stubPeriodTypeIDRef != null)
                {
                    stubPeriodType = IDManager.getID(stubPeriodTypeIDRef) as StubPeriodTypeEnum;
                    return this.stubPeriodType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubPeriodType != value)
                {
                    this.stubPeriodType = value;
                }
            }
        }
        #endregion
        
        public string StubPeriodTypeEnumIDRef { get; set; }
        #region CalculationPeriodFrequency
        private CalculationPeriodFrequency calculationPeriodFrequency;
        public CalculationPeriodFrequency CalculationPeriodFrequency
        {
            get
            {
                if (this.calculationPeriodFrequency != null)
                {
                    return this.calculationPeriodFrequency; 
                }
                else if (this.calculationPeriodFrequencyIDRef != null)
                {
                    calculationPeriodFrequency = IDManager.getID(calculationPeriodFrequencyIDRef) as CalculationPeriodFrequency;
                    return this.calculationPeriodFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodFrequency != value)
                {
                    this.calculationPeriodFrequency = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodFrequencyIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


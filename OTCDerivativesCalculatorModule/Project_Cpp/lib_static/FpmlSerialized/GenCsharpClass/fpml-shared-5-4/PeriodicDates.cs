using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PeriodicDates
    {
        public PeriodicDates(XmlNode xmlNode)
        {
            XmlNodeList calculationStartDateNodeList = xmlNode.SelectNodes("calculationStartDate");
            if (calculationStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationStartDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(calculationStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationStartDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList calculationEndDateNodeList = xmlNode.SelectNodes("calculationEndDate");
            if (calculationEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationEndDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(calculationEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationEndDate = new AdjustableOrRelativeDate(item);
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
            
        
        }
        
    
        #region CalculationStartDate
        private AdjustableOrRelativeDate calculationStartDate;
        public AdjustableOrRelativeDate CalculationStartDate
        {
            get
            {
                if (this.calculationStartDate != null)
                {
                    return this.calculationStartDate; 
                }
                else if (this.calculationStartDateIDRef != null)
                {
                    calculationStartDate = IDManager.getID(calculationStartDateIDRef) as AdjustableOrRelativeDate;
                    return this.calculationStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationStartDate != value)
                {
                    this.calculationStartDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region CalculationEndDate
        private AdjustableOrRelativeDate calculationEndDate;
        public AdjustableOrRelativeDate CalculationEndDate
        {
            get
            {
                if (this.calculationEndDate != null)
                {
                    return this.calculationEndDate; 
                }
                else if (this.calculationEndDateIDRef != null)
                {
                    calculationEndDate = IDManager.getID(calculationEndDateIDRef) as AdjustableOrRelativeDate;
                    return this.calculationEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationEndDate != value)
                {
                    this.calculationEndDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
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
        
    
        
    
    }
    
}


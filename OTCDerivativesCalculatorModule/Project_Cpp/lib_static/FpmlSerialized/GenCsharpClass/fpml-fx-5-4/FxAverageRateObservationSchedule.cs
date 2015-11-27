using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxAverageRateObservationSchedule
    {
        public FxAverageRateObservationSchedule(XmlNode xmlNode)
        {
            XmlNodeList startDateNodeList = xmlNode.SelectNodes("startDate");
            if (startDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in startDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        startDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(startDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        startDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        startDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList endDateNodeList = xmlNode.SelectNodes("endDate");
            if (endDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(endDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endDate = new XsdTypeDate(item);
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
        
    
        #region StartDate
        private XsdTypeDate startDate;
        public XsdTypeDate StartDate
        {
            get
            {
                if (this.startDate != null)
                {
                    return this.startDate; 
                }
                else if (this.startDateIDRef != null)
                {
                    startDate = IDManager.getID(startDateIDRef) as XsdTypeDate;
                    return this.startDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.startDate != value)
                {
                    this.startDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region EndDate
        private XsdTypeDate endDate;
        public XsdTypeDate EndDate
        {
            get
            {
                if (this.endDate != null)
                {
                    return this.endDate; 
                }
                else if (this.endDateIDRef != null)
                {
                    endDate = IDManager.getID(endDateIDRef) as XsdTypeDate;
                    return this.endDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endDate != value)
                {
                    this.endDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
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
        
    
        
    
    }
    
}


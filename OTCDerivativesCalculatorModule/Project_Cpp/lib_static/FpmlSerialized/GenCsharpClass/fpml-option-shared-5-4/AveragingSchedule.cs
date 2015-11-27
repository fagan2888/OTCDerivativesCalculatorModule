using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AveragingSchedule
    {
        public AveragingSchedule(XmlNode xmlNode)
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
            
        
            XmlNodeList averagingPeriodFrequencyNodeList = xmlNode.SelectNodes("averagingPeriodFrequency");
            if (averagingPeriodFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingPeriodFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingPeriodFrequencyIDRef = item.Attributes["id"].Name;
                        CalculationPeriodFrequency ob = CalculationPeriodFrequency();
                        IDManager.SetID(averagingPeriodFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingPeriodFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingPeriodFrequency = new CalculationPeriodFrequency(item);
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
        #region AveragingPeriodFrequency
        private CalculationPeriodFrequency averagingPeriodFrequency;
        public CalculationPeriodFrequency AveragingPeriodFrequency
        {
            get
            {
                if (this.averagingPeriodFrequency != null)
                {
                    return this.averagingPeriodFrequency; 
                }
                else if (this.averagingPeriodFrequencyIDRef != null)
                {
                    averagingPeriodFrequency = IDManager.getID(averagingPeriodFrequencyIDRef) as CalculationPeriodFrequency;
                    return this.averagingPeriodFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingPeriodFrequency != value)
                {
                    this.averagingPeriodFrequency = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodFrequencyIDRef { get; set; }
        
    
        
    
    }
    
}


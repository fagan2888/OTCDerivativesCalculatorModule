using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ObservationSchedule
    {
        public ObservationSchedule(XmlNode xmlNode)
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
            
        
            XmlNodeList observationPeriodFrequencyNodeList = xmlNode.SelectNodes("observationPeriodFrequency");
            if (observationPeriodFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationPeriodFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationPeriodFrequencyIDRef = item.Attributes["id"].Name;
                        Frequency ob = Frequency();
                        IDManager.SetID(observationPeriodFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationPeriodFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationPeriodFrequency = new Frequency(item);
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
        #region ObservationPeriodFrequency
        private Frequency observationPeriodFrequency;
        public Frequency ObservationPeriodFrequency
        {
            get
            {
                if (this.observationPeriodFrequency != null)
                {
                    return this.observationPeriodFrequency; 
                }
                else if (this.observationPeriodFrequencyIDRef != null)
                {
                    observationPeriodFrequency = IDManager.getID(observationPeriodFrequencyIDRef) as Frequency;
                    return this.observationPeriodFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationPeriodFrequency != value)
                {
                    this.observationPeriodFrequency = value;
                }
            }
        }
        #endregion
        
        public string FrequencyIDRef { get; set; }
        
    
        
    
    }
    
}


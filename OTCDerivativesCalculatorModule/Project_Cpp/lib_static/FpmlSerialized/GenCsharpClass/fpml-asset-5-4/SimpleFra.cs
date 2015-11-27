using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SimpleFra
    {
        public SimpleFra(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList startTermNodeList = xmlNode.SelectNodes("startTerm");
            if (startTermNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in startTermNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        startTermIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(startTermIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        startTermIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        startTerm = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList endTermNodeList = xmlNode.SelectNodes("endTerm");
            if (endTermNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endTermNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endTermIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(endTermIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endTermIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endTerm = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountFractionNodeList = xmlNode.SelectNodes("dayCountFraction");
            if (dayCountFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef = item.Attributes["id"].Name;
                        DayCountFraction ob = DayCountFraction();
                        IDManager.SetID(dayCountFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCountFraction = new DayCountFraction(item);
                    }
                }
            }
            
        
        }
        
    
        #region StartTerm
        private Period startTerm;
        public Period StartTerm
        {
            get
            {
                if (this.startTerm != null)
                {
                    return this.startTerm; 
                }
                else if (this.startTermIDRef != null)
                {
                    startTerm = IDManager.getID(startTermIDRef) as Period;
                    return this.startTerm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.startTerm != value)
                {
                    this.startTerm = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region EndTerm
        private Period endTerm;
        public Period EndTerm
        {
            get
            {
                if (this.endTerm != null)
                {
                    return this.endTerm; 
                }
                else if (this.endTermIDRef != null)
                {
                    endTerm = IDManager.getID(endTermIDRef) as Period;
                    return this.endTerm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endTerm != value)
                {
                    this.endTerm = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region DayCountFraction
        private DayCountFraction dayCountFraction;
        public DayCountFraction DayCountFraction
        {
            get
            {
                if (this.dayCountFraction != null)
                {
                    return this.dayCountFraction; 
                }
                else if (this.dayCountFractionIDRef != null)
                {
                    dayCountFraction = IDManager.getID(dayCountFractionIDRef) as DayCountFraction;
                    return this.dayCountFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCountFraction != value)
                {
                    this.dayCountFraction = value;
                }
            }
        }
        #endregion
        
        public string DayCountFractionIDRef { get; set; }
        
    
        
    
    }
    
}


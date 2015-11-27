using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Lag
    {
        public Lag(XmlNode xmlNode)
        {
            XmlNodeList lagDurationNodeList = xmlNode.SelectNodes("lagDuration");
            if (lagDurationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lagDurationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lagDurationIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(lagDurationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lagDurationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lagDuration = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList firstObservationDateOffsetNodeList = xmlNode.SelectNodes("firstObservationDateOffset");
            if (firstObservationDateOffsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstObservationDateOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstObservationDateOffsetIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(firstObservationDateOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstObservationDateOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstObservationDateOffset = new Period(item);
                    }
                }
            }
            
        
        }
        
    
        #region LagDuration
        private Period lagDuration;
        public Period LagDuration
        {
            get
            {
                if (this.lagDuration != null)
                {
                    return this.lagDuration; 
                }
                else if (this.lagDurationIDRef != null)
                {
                    lagDuration = IDManager.getID(lagDurationIDRef) as Period;
                    return this.lagDuration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lagDuration != value)
                {
                    this.lagDuration = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region FirstObservationDateOffset
        private Period firstObservationDateOffset;
        public Period FirstObservationDateOffset
        {
            get
            {
                if (this.firstObservationDateOffset != null)
                {
                    return this.firstObservationDateOffset; 
                }
                else if (this.firstObservationDateOffsetIDRef != null)
                {
                    firstObservationDateOffset = IDManager.getID(firstObservationDateOffsetIDRef) as Period;
                    return this.firstObservationDateOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstObservationDateOffset != value)
                {
                    this.firstObservationDateOffset = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestCalculation
    {
        public InterestCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNodeList compoundingNodeList = xmlNode.SelectNodes("compounding");
            if (compoundingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingIDRef = item.Attributes["id"].Name;
                        Compounding ob = Compounding();
                        IDManager.SetID(compoundingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compounding = new Compounding(item);
                    }
                }
            }
            
        
            XmlNodeList interpolationMethodNodeList = xmlNode.SelectNodes("interpolationMethod");
            if (interpolationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interpolationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interpolationMethodIDRef = item.Attributes["id"].Name;
                        InterpolationMethod ob = InterpolationMethod();
                        IDManager.SetID(interpolationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interpolationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interpolationMethod = new InterpolationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList interpolationPeriodNodeList = xmlNode.SelectNodes("interpolationPeriod");
            if (interpolationPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interpolationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interpolationPeriodIDRef = item.Attributes["id"].Name;
                        InterpolationPeriodEnum ob = InterpolationPeriodEnum();
                        IDManager.SetID(interpolationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interpolationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interpolationPeriod = new InterpolationPeriodEnum(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region Compounding
        private Compounding compounding;
        public Compounding Compounding
        {
            get
            {
                if (this.compounding != null)
                {
                    return this.compounding; 
                }
                else if (this.compoundingIDRef != null)
                {
                    compounding = IDManager.getID(compoundingIDRef) as Compounding;
                    return this.compounding; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compounding != value)
                {
                    this.compounding = value;
                }
            }
        }
        #endregion
        
        public string CompoundingIDRef { get; set; }
        #region InterpolationMethod
        private InterpolationMethod interpolationMethod;
        public InterpolationMethod InterpolationMethod
        {
            get
            {
                if (this.interpolationMethod != null)
                {
                    return this.interpolationMethod; 
                }
                else if (this.interpolationMethodIDRef != null)
                {
                    interpolationMethod = IDManager.getID(interpolationMethodIDRef) as InterpolationMethod;
                    return this.interpolationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interpolationMethod != value)
                {
                    this.interpolationMethod = value;
                }
            }
        }
        #endregion
        
        public string InterpolationMethodIDRef { get; set; }
        #region InterpolationPeriod
        private InterpolationPeriodEnum interpolationPeriod;
        public InterpolationPeriodEnum InterpolationPeriod
        {
            get
            {
                if (this.interpolationPeriod != null)
                {
                    return this.interpolationPeriod; 
                }
                else if (this.interpolationPeriodIDRef != null)
                {
                    interpolationPeriod = IDManager.getID(interpolationPeriodIDRef) as InterpolationPeriodEnum;
                    return this.interpolationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interpolationPeriod != value)
                {
                    this.interpolationPeriod = value;
                }
            }
        }
        #endregion
        
        public string InterpolationPeriodEnumIDRef { get; set; }
        
    
        
    
    }
    
}


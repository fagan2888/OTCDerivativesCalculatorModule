using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Period
    {
        public Period(XmlNode xmlNode)
        {
            XmlNodeList periodMultiplierNodeList = xmlNode.SelectNodes("periodMultiplier");
            if (periodMultiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodMultiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodMultiplierIDRef = item.Attributes["id"].Name;
                        XsdTypeInteger ob = XsdTypeInteger();
                        IDManager.SetID(periodMultiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodMultiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodMultiplier = new XsdTypeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList periodNodeList = xmlNode.SelectNodes("period");
            if (periodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodIDRef = item.Attributes["id"].Name;
                        PeriodEnum ob = PeriodEnum();
                        IDManager.SetID(periodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        period = new PeriodEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region PeriodMultiplier
        private XsdTypeInteger periodMultiplier;
        public XsdTypeInteger PeriodMultiplier
        {
            get
            {
                if (this.periodMultiplier != null)
                {
                    return this.periodMultiplier; 
                }
                else if (this.periodMultiplierIDRef != null)
                {
                    periodMultiplier = IDManager.getID(periodMultiplierIDRef) as XsdTypeInteger;
                    return this.periodMultiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periodMultiplier != value)
                {
                    this.periodMultiplier = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeIntegerIDRef { get; set; }
        #region Period
        private PeriodEnum period;
        public PeriodEnum Period
        {
            get
            {
                if (this.period != null)
                {
                    return this.period; 
                }
                else if (this.periodIDRef != null)
                {
                    period = IDManager.getID(periodIDRef) as PeriodEnum;
                    return this.period; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.period != value)
                {
                    this.period = value;
                }
            }
        }
        #endregion
        
        public string PeriodEnumIDRef { get; set; }
        
    
        
    
    }
    
}


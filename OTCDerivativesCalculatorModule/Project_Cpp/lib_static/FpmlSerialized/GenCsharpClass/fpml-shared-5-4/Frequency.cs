using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Frequency
    {
        public Frequency(XmlNode xmlNode)
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
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(periodMultiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodMultiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodMultiplier = new XsdTypePositiveInteger(item);
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
                        PeriodExtendedEnum ob = PeriodExtendedEnum();
                        IDManager.SetID(periodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        period = new PeriodExtendedEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region PeriodMultiplier
        private XsdTypePositiveInteger periodMultiplier;
        public XsdTypePositiveInteger PeriodMultiplier
        {
            get
            {
                if (this.periodMultiplier != null)
                {
                    return this.periodMultiplier; 
                }
                else if (this.periodMultiplierIDRef != null)
                {
                    periodMultiplier = IDManager.getID(periodMultiplierIDRef) as XsdTypePositiveInteger;
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
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region Period
        private PeriodExtendedEnum period;
        public PeriodExtendedEnum Period
        {
            get
            {
                if (this.period != null)
                {
                    return this.period; 
                }
                else if (this.periodIDRef != null)
                {
                    period = IDManager.getID(periodIDRef) as PeriodExtendedEnum;
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
        
        public string PeriodExtendedEnumIDRef { get; set; }
        
    
        
    
    }
    
}


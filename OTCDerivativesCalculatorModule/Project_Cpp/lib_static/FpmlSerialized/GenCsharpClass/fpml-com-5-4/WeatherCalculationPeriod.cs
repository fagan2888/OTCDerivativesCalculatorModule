using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherCalculationPeriod
    {
        public WeatherCalculationPeriod(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodFirstDayNodeList = xmlNode.SelectNodes("calculationPeriodFirstDay");
            if (calculationPeriodFirstDayNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodFirstDayNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodFirstDayIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(calculationPeriodFirstDayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodFirstDayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodFirstDay = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodEndDayNodeList = xmlNode.SelectNodes("calculationPeriodEndDay");
            if (calculationPeriodEndDayNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodEndDayNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodEndDayIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(calculationPeriodEndDayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodEndDayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodEndDay = new IdentifiedDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodFirstDay
        private IdentifiedDate calculationPeriodFirstDay;
        public IdentifiedDate CalculationPeriodFirstDay
        {
            get
            {
                if (this.calculationPeriodFirstDay != null)
                {
                    return this.calculationPeriodFirstDay; 
                }
                else if (this.calculationPeriodFirstDayIDRef != null)
                {
                    calculationPeriodFirstDay = IDManager.getID(calculationPeriodFirstDayIDRef) as IdentifiedDate;
                    return this.calculationPeriodFirstDay; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodFirstDay != value)
                {
                    this.calculationPeriodFirstDay = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region CalculationPeriodEndDay
        private IdentifiedDate calculationPeriodEndDay;
        public IdentifiedDate CalculationPeriodEndDay
        {
            get
            {
                if (this.calculationPeriodEndDay != null)
                {
                    return this.calculationPeriodEndDay; 
                }
                else if (this.calculationPeriodEndDayIDRef != null)
                {
                    calculationPeriodEndDay = IDManager.getID(calculationPeriodEndDayIDRef) as IdentifiedDate;
                    return this.calculationPeriodEndDay; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodEndDay != value)
                {
                    this.calculationPeriodEndDay = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        
    
        
    
    }
    
}


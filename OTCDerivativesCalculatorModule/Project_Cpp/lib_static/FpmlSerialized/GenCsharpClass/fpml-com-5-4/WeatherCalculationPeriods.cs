using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherCalculationPeriods
    {
        public WeatherCalculationPeriods(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodNodeList = xmlNode.SelectNodes("calculationPeriod");
            
            foreach (XmlNode item in calculationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodIDRef = item.Attributes["id"].Name;
                        List<WeatherCalculationPeriod> ob = new List<WeatherCalculationPeriod>();
                        ob.Add(new WeatherCalculationPeriod(item));
                        IDManager.SetID(calculationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    calculationPeriod.Add(new WeatherCalculationPeriod(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriod
        private List<WeatherCalculationPeriod> calculationPeriod;
        public List<WeatherCalculationPeriod> CalculationPeriod
        {
            get
            {
                if (this.calculationPeriod != null)
                {
                    return this.calculationPeriod; 
                }
                else if (this.calculationPeriodIDRef != null)
                {
                    calculationPeriod = IDManager.getID(calculationPeriodIDRef) as List<WeatherCalculationPeriod>;
                    return this.calculationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriod != value)
                {
                    this.calculationPeriod = value;
                }
            }
        }
        #endregion
        
        public string WeatherCalculationPeriodIDRef { get; set; }
        
    
        
    
    }
    
}


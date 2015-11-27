using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class YieldCurve
    {
        public YieldCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList algorithmNodeList = xmlNode.SelectNodes("algorithm");
            if (algorithmNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in algorithmNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        algorithmIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(algorithmIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        algorithmIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        algorithm = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList forecastRateIndexNodeList = xmlNode.SelectNodes("forecastRateIndex");
            if (forecastRateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forecastRateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forecastRateIndexIDRef = item.Attributes["id"].Name;
                        ForecastRateIndex ob = ForecastRateIndex();
                        IDManager.SetID(forecastRateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forecastRateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forecastRateIndex = new ForecastRateIndex(item);
                    }
                }
            }
            
        
        }
        
    
        #region Algorithm
        private XsdTypeString algorithm;
        public XsdTypeString Algorithm
        {
            get
            {
                if (this.algorithm != null)
                {
                    return this.algorithm; 
                }
                else if (this.algorithmIDRef != null)
                {
                    algorithm = IDManager.getID(algorithmIDRef) as XsdTypeString;
                    return this.algorithm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.algorithm != value)
                {
                    this.algorithm = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ForecastRateIndex
        private ForecastRateIndex forecastRateIndex;
        public ForecastRateIndex ForecastRateIndex
        {
            get
            {
                if (this.forecastRateIndex != null)
                {
                    return this.forecastRateIndex; 
                }
                else if (this.forecastRateIndexIDRef != null)
                {
                    forecastRateIndex = IDManager.getID(forecastRateIndexIDRef) as ForecastRateIndex;
                    return this.forecastRateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forecastRateIndex != value)
                {
                    this.forecastRateIndex = value;
                }
            }
        }
        #endregion
        
        public string ForecastRateIndexIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxAverageRateObservation
    {
        public FxAverageRateObservation(XmlNode xmlNode)
        {
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            if (dateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        date = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList averageRateWeightingFactorNodeList = xmlNode.SelectNodes("averageRateWeightingFactor");
            if (averageRateWeightingFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averageRateWeightingFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averageRateWeightingFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(averageRateWeightingFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averageRateWeightingFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averageRateWeightingFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList rateNodeList = xmlNode.SelectNodes("rate");
            if (rateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(rateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rate = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Date
        private XsdTypeDate date;
        public XsdTypeDate Date
        {
            get
            {
                if (this.date != null)
                {
                    return this.date; 
                }
                else if (this.dateIDRef != null)
                {
                    date = IDManager.getID(dateIDRef) as XsdTypeDate;
                    return this.date; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.date != value)
                {
                    this.date = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AverageRateWeightingFactor
        private XsdTypeDecimal averageRateWeightingFactor;
        public XsdTypeDecimal AverageRateWeightingFactor
        {
            get
            {
                if (this.averageRateWeightingFactor != null)
                {
                    return this.averageRateWeightingFactor; 
                }
                else if (this.averageRateWeightingFactorIDRef != null)
                {
                    averageRateWeightingFactor = IDManager.getID(averageRateWeightingFactorIDRef) as XsdTypeDecimal;
                    return this.averageRateWeightingFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averageRateWeightingFactor != value)
                {
                    this.averageRateWeightingFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Rate
        private NonNegativeDecimal rate;
        public NonNegativeDecimal Rate
        {
            get
            {
                if (this.rate != null)
                {
                    return this.rate; 
                }
                else if (this.rateIDRef != null)
                {
                    rate = IDManager.getID(rateIDRef) as NonNegativeDecimal;
                    return this.rate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rate != value)
                {
                    this.rate = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExchangeRate
    {
        public ExchangeRate(XmlNode xmlNode)
        {
            XmlNodeList quotedCurrencyPairNodeList = xmlNode.SelectNodes("quotedCurrencyPair");
            if (quotedCurrencyPairNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotedCurrencyPairNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef = item.Attributes["id"].Name;
                        QuotedCurrencyPair ob = QuotedCurrencyPair();
                        IDManager.SetID(quotedCurrencyPairIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotedCurrencyPairIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotedCurrencyPair = new QuotedCurrencyPair(item);
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
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(rateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList spotRateNodeList = xmlNode.SelectNodes("spotRate");
            if (spotRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotRateIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(spotRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotRate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList forwardPointsNodeList = xmlNode.SelectNodes("forwardPoints");
            if (forwardPointsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forwardPointsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forwardPointsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(forwardPointsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forwardPointsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forwardPoints = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList pointValueNodeList = xmlNode.SelectNodes("pointValue");
            if (pointValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pointValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pointValueIDRef = item.Attributes["id"].Name;
                        PointValue ob = PointValue();
                        IDManager.SetID(pointValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pointValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pointValue = new PointValue(item);
                    }
                }
            }
            
        
            XmlNodeList crossRateNodeList = xmlNode.SelectNodes("crossRate");
            
            foreach (XmlNode item in crossRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        crossRateIDRef = item.Attributes["id"].Name;
                        List<CrossRate> ob = new List<CrossRate>();
                        ob.Add(new CrossRate(item));
                        IDManager.SetID(crossRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        crossRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    crossRate.Add(new CrossRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region QuotedCurrencyPair
        private QuotedCurrencyPair quotedCurrencyPair;
        public QuotedCurrencyPair QuotedCurrencyPair
        {
            get
            {
                if (this.quotedCurrencyPair != null)
                {
                    return this.quotedCurrencyPair; 
                }
                else if (this.quotedCurrencyPairIDRef != null)
                {
                    quotedCurrencyPair = IDManager.getID(quotedCurrencyPairIDRef) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotedCurrencyPair != value)
                {
                    this.quotedCurrencyPair = value;
                }
            }
        }
        #endregion
        
        public string QuotedCurrencyPairIDRef { get; set; }
        #region Rate
        private PositiveDecimal rate;
        public PositiveDecimal Rate
        {
            get
            {
                if (this.rate != null)
                {
                    return this.rate; 
                }
                else if (this.rateIDRef != null)
                {
                    rate = IDManager.getID(rateIDRef) as PositiveDecimal;
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
        
        public string PositiveDecimalIDRef { get; set; }
        #region SpotRate
        private PositiveDecimal spotRate;
        public PositiveDecimal SpotRate
        {
            get
            {
                if (this.spotRate != null)
                {
                    return this.spotRate; 
                }
                else if (this.spotRateIDRef != null)
                {
                    spotRate = IDManager.getID(spotRateIDRef) as PositiveDecimal;
                    return this.spotRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotRate != value)
                {
                    this.spotRate = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region ForwardPoints
        private XsdTypeDecimal forwardPoints;
        public XsdTypeDecimal ForwardPoints
        {
            get
            {
                if (this.forwardPoints != null)
                {
                    return this.forwardPoints; 
                }
                else if (this.forwardPointsIDRef != null)
                {
                    forwardPoints = IDManager.getID(forwardPointsIDRef) as XsdTypeDecimal;
                    return this.forwardPoints; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forwardPoints != value)
                {
                    this.forwardPoints = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PointValue
        private PointValue pointValue;
        public PointValue PointValue
        {
            get
            {
                if (this.pointValue != null)
                {
                    return this.pointValue; 
                }
                else if (this.pointValueIDRef != null)
                {
                    pointValue = IDManager.getID(pointValueIDRef) as PointValue;
                    return this.pointValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pointValue != value)
                {
                    this.pointValue = value;
                }
            }
        }
        #endregion
        
        public string PointValueIDRef { get; set; }
        #region CrossRate
        private List<CrossRate> crossRate;
        public List<CrossRate> CrossRate
        {
            get
            {
                if (this.crossRate != null)
                {
                    return this.crossRate; 
                }
                else if (this.crossRateIDRef != null)
                {
                    crossRate = IDManager.getID(crossRateIDRef) as List<CrossRate>;
                    return this.crossRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.crossRate != value)
                {
                    this.crossRate = value;
                }
            }
        }
        #endregion
        
        public string CrossRateIDRef { get; set; }
        
    
        
    
    }
    
}


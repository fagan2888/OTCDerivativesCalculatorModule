using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CrossRate
    {
        public CrossRate(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}


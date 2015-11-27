using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExchangeRate : ISerialized
    {
        public ExchangeRate(XmlNode xmlNode)
        {
            XmlNode quotedCurrencyPairNode = xmlNode.SelectSingleNode("quotedCurrencyPair");
            
            if (quotedCurrencyPairNode != null)
            {
                if (quotedCurrencyPairNode.Attributes["href"] != null || quotedCurrencyPairNode.Attributes["id"] != null) 
                {
                    if (quotedCurrencyPairNode.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["id"].Value;
                        QuotedCurrencyPair ob = new QuotedCurrencyPair(quotedCurrencyPairNode);
                        IDManager.SetID(quotedCurrencyPairIDRef_, ob);
                    }
                    else if (quotedCurrencyPairNode.Attributes["href"] != null)
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                    }
                }
                else
                {
                    quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                }
            }
            
        
            XmlNode rateNode = xmlNode.SelectSingleNode("rate");
            
            if (rateNode != null)
            {
                if (rateNode.Attributes["href"] != null || rateNode.Attributes["id"] != null) 
                {
                    if (rateNode.Attributes["id"] != null) 
                    {
                        rateIDRef_ = rateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(rateNode);
                        IDManager.SetID(rateIDRef_, ob);
                    }
                    else if (rateNode.Attributes["href"] != null)
                    {
                        rateIDRef_ = rateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rate_ = new PositiveDecimal(rateNode);
                    }
                }
                else
                {
                    rate_ = new PositiveDecimal(rateNode);
                }
            }
            
        
            XmlNode spotRateNode = xmlNode.SelectSingleNode("spotRate");
            
            if (spotRateNode != null)
            {
                if (spotRateNode.Attributes["href"] != null || spotRateNode.Attributes["id"] != null) 
                {
                    if (spotRateNode.Attributes["id"] != null) 
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(spotRateNode);
                        IDManager.SetID(spotRateIDRef_, ob);
                    }
                    else if (spotRateNode.Attributes["href"] != null)
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotRate_ = new PositiveDecimal(spotRateNode);
                    }
                }
                else
                {
                    spotRate_ = new PositiveDecimal(spotRateNode);
                }
            }
            
        
            XmlNode forwardPointsNode = xmlNode.SelectSingleNode("forwardPoints");
            
            if (forwardPointsNode != null)
            {
                if (forwardPointsNode.Attributes["href"] != null || forwardPointsNode.Attributes["id"] != null) 
                {
                    if (forwardPointsNode.Attributes["id"] != null) 
                    {
                        forwardPointsIDRef_ = forwardPointsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(forwardPointsNode);
                        IDManager.SetID(forwardPointsIDRef_, ob);
                    }
                    else if (forwardPointsNode.Attributes["href"] != null)
                    {
                        forwardPointsIDRef_ = forwardPointsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forwardPoints_ = new XsdTypeDecimal(forwardPointsNode);
                    }
                }
                else
                {
                    forwardPoints_ = new XsdTypeDecimal(forwardPointsNode);
                }
            }
            
        
            XmlNode pointValueNode = xmlNode.SelectSingleNode("pointValue");
            
            if (pointValueNode != null)
            {
                if (pointValueNode.Attributes["href"] != null || pointValueNode.Attributes["id"] != null) 
                {
                    if (pointValueNode.Attributes["id"] != null) 
                    {
                        pointValueIDRef_ = pointValueNode.Attributes["id"].Value;
                        PointValue ob = new PointValue(pointValueNode);
                        IDManager.SetID(pointValueIDRef_, ob);
                    }
                    else if (pointValueNode.Attributes["href"] != null)
                    {
                        pointValueIDRef_ = pointValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pointValue_ = new PointValue(pointValueNode);
                    }
                }
                else
                {
                    pointValue_ = new PointValue(pointValueNode);
                }
            }
            
        
            XmlNodeList crossRateNodeList = xmlNode.SelectNodes("crossRate");
            
            if (crossRateNodeList != null)
            {
                this.crossRate_ = new List<CrossRate>();
                foreach (XmlNode item in crossRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            crossRateIDRef_ = item.Attributes["id"].Value;
                            crossRate_.Add(new CrossRate(item));
                            IDManager.SetID(crossRateIDRef_, crossRate_[crossRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            crossRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        crossRate_.Add(new CrossRate(item));
                        }
                    }
                    else
                    {
                        crossRate_.Add(new CrossRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region QuotedCurrencyPair_
        private QuotedCurrencyPair quotedCurrencyPair_;
        public QuotedCurrencyPair QuotedCurrencyPair_
        {
            get
            {
                if (this.quotedCurrencyPair_ != null)
                {
                    return this.quotedCurrencyPair_; 
                }
                else if (this.quotedCurrencyPairIDRef_ != null)
                {
                    quotedCurrencyPair_ = IDManager.getID(quotedCurrencyPairIDRef_) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair_; 
                }
                else
                {
                      return this.quotedCurrencyPair_; 
                }
            }
            set
            {
                if (this.quotedCurrencyPair_ != value)
                {
                    this.quotedCurrencyPair_ = value;
                }
            }
        }
        #endregion
        
        public string quotedCurrencyPairIDRef_ { get; set; }
        #region Rate_
        private PositiveDecimal rate_;
        public PositiveDecimal Rate_
        {
            get
            {
                if (this.rate_ != null)
                {
                    return this.rate_; 
                }
                else if (this.rateIDRef_ != null)
                {
                    rate_ = IDManager.getID(rateIDRef_) as PositiveDecimal;
                    return this.rate_; 
                }
                else
                {
                      return this.rate_; 
                }
            }
            set
            {
                if (this.rate_ != value)
                {
                    this.rate_ = value;
                }
            }
        }
        #endregion
        
        public string rateIDRef_ { get; set; }
        #region SpotRate_
        private PositiveDecimal spotRate_;
        public PositiveDecimal SpotRate_
        {
            get
            {
                if (this.spotRate_ != null)
                {
                    return this.spotRate_; 
                }
                else if (this.spotRateIDRef_ != null)
                {
                    spotRate_ = IDManager.getID(spotRateIDRef_) as PositiveDecimal;
                    return this.spotRate_; 
                }
                else
                {
                      return this.spotRate_; 
                }
            }
            set
            {
                if (this.spotRate_ != value)
                {
                    this.spotRate_ = value;
                }
            }
        }
        #endregion
        
        public string spotRateIDRef_ { get; set; }
        #region ForwardPoints_
        private XsdTypeDecimal forwardPoints_;
        public XsdTypeDecimal ForwardPoints_
        {
            get
            {
                if (this.forwardPoints_ != null)
                {
                    return this.forwardPoints_; 
                }
                else if (this.forwardPointsIDRef_ != null)
                {
                    forwardPoints_ = IDManager.getID(forwardPointsIDRef_) as XsdTypeDecimal;
                    return this.forwardPoints_; 
                }
                else
                {
                      return this.forwardPoints_; 
                }
            }
            set
            {
                if (this.forwardPoints_ != value)
                {
                    this.forwardPoints_ = value;
                }
            }
        }
        #endregion
        
        public string forwardPointsIDRef_ { get; set; }
        #region PointValue_
        private PointValue pointValue_;
        public PointValue PointValue_
        {
            get
            {
                if (this.pointValue_ != null)
                {
                    return this.pointValue_; 
                }
                else if (this.pointValueIDRef_ != null)
                {
                    pointValue_ = IDManager.getID(pointValueIDRef_) as PointValue;
                    return this.pointValue_; 
                }
                else
                {
                      return this.pointValue_; 
                }
            }
            set
            {
                if (this.pointValue_ != value)
                {
                    this.pointValue_ = value;
                }
            }
        }
        #endregion
        
        public string pointValueIDRef_ { get; set; }
        #region CrossRate_
        private List<CrossRate> crossRate_;
        public List<CrossRate> CrossRate_
        {
            get
            {
                if (this.crossRate_ != null)
                {
                    return this.crossRate_; 
                }
                else if (this.crossRateIDRef_ != null)
                {
                    return this.crossRate_; 
                }
                else
                {
                      return this.crossRate_; 
                }
            }
            set
            {
                if (this.crossRate_ != value)
                {
                    this.crossRate_ = value;
                }
            }
        }
        #endregion
        
        public string crossRateIDRef_ { get; set; }
        
    
        
    
    }
    
}


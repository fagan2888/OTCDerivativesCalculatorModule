using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CrossRate : QuotedCurrencyPair
    {
        public CrossRate(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}


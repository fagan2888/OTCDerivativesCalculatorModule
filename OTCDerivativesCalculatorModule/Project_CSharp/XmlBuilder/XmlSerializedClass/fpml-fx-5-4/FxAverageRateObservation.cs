using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxAverageRateObservation : ISerialized
    {
        public FxAverageRateObservation(XmlNode xmlNode)
        {
            XmlNode dateNode = xmlNode.SelectSingleNode("date");
            
            if (dateNode != null)
            {
                if (dateNode.Attributes["href"] != null || dateNode.Attributes["id"] != null) 
                {
                    if (dateNode.Attributes["id"] != null) 
                    {
                        dateIDRef_ = dateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateNode);
                        IDManager.SetID(dateIDRef_, ob);
                    }
                    else if (dateNode.Attributes["href"] != null)
                    {
                        dateIDRef_ = dateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        date_ = new XsdTypeDate(dateNode);
                    }
                }
                else
                {
                    date_ = new XsdTypeDate(dateNode);
                }
            }
            
        
            XmlNode averageRateWeightingFactorNode = xmlNode.SelectSingleNode("averageRateWeightingFactor");
            
            if (averageRateWeightingFactorNode != null)
            {
                if (averageRateWeightingFactorNode.Attributes["href"] != null || averageRateWeightingFactorNode.Attributes["id"] != null) 
                {
                    if (averageRateWeightingFactorNode.Attributes["id"] != null) 
                    {
                        averageRateWeightingFactorIDRef_ = averageRateWeightingFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(averageRateWeightingFactorNode);
                        IDManager.SetID(averageRateWeightingFactorIDRef_, ob);
                    }
                    else if (averageRateWeightingFactorNode.Attributes["href"] != null)
                    {
                        averageRateWeightingFactorIDRef_ = averageRateWeightingFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averageRateWeightingFactor_ = new XsdTypeDecimal(averageRateWeightingFactorNode);
                    }
                }
                else
                {
                    averageRateWeightingFactor_ = new XsdTypeDecimal(averageRateWeightingFactorNode);
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
                        NonNegativeDecimal ob = new NonNegativeDecimal(rateNode);
                        IDManager.SetID(rateIDRef_, ob);
                    }
                    else if (rateNode.Attributes["href"] != null)
                    {
                        rateIDRef_ = rateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rate_ = new NonNegativeDecimal(rateNode);
                    }
                }
                else
                {
                    rate_ = new NonNegativeDecimal(rateNode);
                }
            }
            
        
        }
        
    
        #region Date_
        private XsdTypeDate date_;
        public XsdTypeDate Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
                    date_ = IDManager.getID(dateIDRef_) as XsdTypeDate;
                    return this.date_; 
                }
                else
                {
                      return this.date_; 
                }
            }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                }
            }
        }
        #endregion
        
        public string dateIDRef_ { get; set; }
        #region AverageRateWeightingFactor_
        private XsdTypeDecimal averageRateWeightingFactor_;
        public XsdTypeDecimal AverageRateWeightingFactor_
        {
            get
            {
                if (this.averageRateWeightingFactor_ != null)
                {
                    return this.averageRateWeightingFactor_; 
                }
                else if (this.averageRateWeightingFactorIDRef_ != null)
                {
                    averageRateWeightingFactor_ = IDManager.getID(averageRateWeightingFactorIDRef_) as XsdTypeDecimal;
                    return this.averageRateWeightingFactor_; 
                }
                else
                {
                      return this.averageRateWeightingFactor_; 
                }
            }
            set
            {
                if (this.averageRateWeightingFactor_ != value)
                {
                    this.averageRateWeightingFactor_ = value;
                }
            }
        }
        #endregion
        
        public string averageRateWeightingFactorIDRef_ { get; set; }
        #region Rate_
        private NonNegativeDecimal rate_;
        public NonNegativeDecimal Rate_
        {
            get
            {
                if (this.rate_ != null)
                {
                    return this.rate_; 
                }
                else if (this.rateIDRef_ != null)
                {
                    rate_ = IDManager.getID(rateIDRef_) as NonNegativeDecimal;
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
        
    
        
    
    }
    
}


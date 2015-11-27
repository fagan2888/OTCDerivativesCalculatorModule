using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DualCurrencyFeature : ISerialized
    {
        public DualCurrencyFeature(XmlNode xmlNode)
        {
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
            XmlNode fixingDateNode = xmlNode.SelectSingleNode("fixingDate");
            
            if (fixingDateNode != null)
            {
                if (fixingDateNode.Attributes["href"] != null || fixingDateNode.Attributes["id"] != null) 
                {
                    if (fixingDateNode.Attributes["id"] != null) 
                    {
                        fixingDateIDRef_ = fixingDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(fixingDateNode);
                        IDManager.SetID(fixingDateIDRef_, ob);
                    }
                    else if (fixingDateNode.Attributes["href"] != null)
                    {
                        fixingDateIDRef_ = fixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDate_ = new XsdTypeDate(fixingDateNode);
                    }
                }
                else
                {
                    fixingDate_ = new XsdTypeDate(fixingDateNode);
                }
            }
            
        
            XmlNode fixingTimeNode = xmlNode.SelectSingleNode("fixingTime");
            
            if (fixingTimeNode != null)
            {
                if (fixingTimeNode.Attributes["href"] != null || fixingTimeNode.Attributes["id"] != null) 
                {
                    if (fixingTimeNode.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(fixingTimeNode);
                        IDManager.SetID(fixingTimeIDRef_, ob);
                    }
                    else if (fixingTimeNode.Attributes["href"] != null)
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                    }
                }
                else
                {
                    fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                }
            }
            
        
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        DualCurrencyStrikePrice ob = new DualCurrencyStrikePrice(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new DualCurrencyStrikePrice(strikeNode);
                    }
                }
                else
                {
                    strike_ = new DualCurrencyStrikePrice(strikeNode);
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
                        XsdTypeDecimal ob = new XsdTypeDecimal(spotRateNode);
                        IDManager.SetID(spotRateIDRef_, ob);
                    }
                    else if (spotRateNode.Attributes["href"] != null)
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotRate_ = new XsdTypeDecimal(spotRateNode);
                    }
                }
                else
                {
                    spotRate_ = new XsdTypeDecimal(spotRateNode);
                }
            }
            
        
            XmlNode interestAtRiskNode = xmlNode.SelectSingleNode("interestAtRisk");
            
            if (interestAtRiskNode != null)
            {
                if (interestAtRiskNode.Attributes["href"] != null || interestAtRiskNode.Attributes["id"] != null) 
                {
                    if (interestAtRiskNode.Attributes["id"] != null) 
                    {
                        interestAtRiskIDRef_ = interestAtRiskNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(interestAtRiskNode);
                        IDManager.SetID(interestAtRiskIDRef_, ob);
                    }
                    else if (interestAtRiskNode.Attributes["href"] != null)
                    {
                        interestAtRiskIDRef_ = interestAtRiskNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestAtRisk_ = new XsdTypeBoolean(interestAtRiskNode);
                    }
                }
                else
                {
                    interestAtRisk_ = new XsdTypeBoolean(interestAtRiskNode);
                }
            }
            
        
        }
        
    
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region FixingDate_
        private XsdTypeDate fixingDate_;
        public XsdTypeDate FixingDate_
        {
            get
            {
                if (this.fixingDate_ != null)
                {
                    return this.fixingDate_; 
                }
                else if (this.fixingDateIDRef_ != null)
                {
                    fixingDate_ = IDManager.getID(fixingDateIDRef_) as XsdTypeDate;
                    return this.fixingDate_; 
                }
                else
                {
                      return this.fixingDate_; 
                }
            }
            set
            {
                if (this.fixingDate_ != value)
                {
                    this.fixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDateIDRef_ { get; set; }
        #region FixingTime_
        private BusinessCenterTime fixingTime_;
        public BusinessCenterTime FixingTime_
        {
            get
            {
                if (this.fixingTime_ != null)
                {
                    return this.fixingTime_; 
                }
                else if (this.fixingTimeIDRef_ != null)
                {
                    fixingTime_ = IDManager.getID(fixingTimeIDRef_) as BusinessCenterTime;
                    return this.fixingTime_; 
                }
                else
                {
                      return this.fixingTime_; 
                }
            }
            set
            {
                if (this.fixingTime_ != value)
                {
                    this.fixingTime_ = value;
                }
            }
        }
        #endregion
        
        public string fixingTimeIDRef_ { get; set; }
        #region Strike_
        private DualCurrencyStrikePrice strike_;
        public DualCurrencyStrikePrice Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as DualCurrencyStrikePrice;
                    return this.strike_; 
                }
                else
                {
                      return this.strike_; 
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
        #region SpotRate_
        private XsdTypeDecimal spotRate_;
        public XsdTypeDecimal SpotRate_
        {
            get
            {
                if (this.spotRate_ != null)
                {
                    return this.spotRate_; 
                }
                else if (this.spotRateIDRef_ != null)
                {
                    spotRate_ = IDManager.getID(spotRateIDRef_) as XsdTypeDecimal;
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
        #region InterestAtRisk_
        private XsdTypeBoolean interestAtRisk_;
        public XsdTypeBoolean InterestAtRisk_
        {
            get
            {
                if (this.interestAtRisk_ != null)
                {
                    return this.interestAtRisk_; 
                }
                else if (this.interestAtRiskIDRef_ != null)
                {
                    interestAtRisk_ = IDManager.getID(interestAtRiskIDRef_) as XsdTypeBoolean;
                    return this.interestAtRisk_; 
                }
                else
                {
                      return this.interestAtRisk_; 
                }
            }
            set
            {
                if (this.interestAtRisk_ != value)
                {
                    this.interestAtRisk_ = value;
                }
            }
        }
        #endregion
        
        public string interestAtRiskIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendPeriodDividend : DividendPeriod
    {
        public DividendPeriodDividend(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dividendNode = xmlNode.SelectSingleNode("dividend");
            
            if (dividendNode != null)
            {
                if (dividendNode.Attributes["href"] != null || dividendNode.Attributes["id"] != null) 
                {
                    if (dividendNode.Attributes["id"] != null) 
                    {
                        dividendIDRef_ = dividendNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(dividendNode);
                        IDManager.SetID(dividendIDRef_, ob);
                    }
                    else if (dividendNode.Attributes["href"] != null)
                    {
                        dividendIDRef_ = dividendNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividend_ = new NonNegativeMoney(dividendNode);
                    }
                }
                else
                {
                    dividend_ = new NonNegativeMoney(dividendNode);
                }
            }
            
        
            XmlNode multiplierNode = xmlNode.SelectSingleNode("multiplier");
            
            if (multiplierNode != null)
            {
                if (multiplierNode.Attributes["href"] != null || multiplierNode.Attributes["id"] != null) 
                {
                    if (multiplierNode.Attributes["id"] != null) 
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(multiplierNode);
                        IDManager.SetID(multiplierIDRef_, ob);
                    }
                    else if (multiplierNode.Attributes["href"] != null)
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiplier_ = new PositiveDecimal(multiplierNode);
                    }
                }
                else
                {
                    multiplier_ = new PositiveDecimal(multiplierNode);
                }
            }
            
        
        }
        
    
        #region Dividend_
        private NonNegativeMoney dividend_;
        public NonNegativeMoney Dividend_
        {
            get
            {
                if (this.dividend_ != null)
                {
                    return this.dividend_; 
                }
                else if (this.dividendIDRef_ != null)
                {
                    dividend_ = IDManager.getID(dividendIDRef_) as NonNegativeMoney;
                    return this.dividend_; 
                }
                else
                {
                      return this.dividend_; 
                }
            }
            set
            {
                if (this.dividend_ != value)
                {
                    this.dividend_ = value;
                }
            }
        }
        #endregion
        
        public string dividendIDRef_ { get; set; }
        #region Multiplier_
        private PositiveDecimal multiplier_;
        public PositiveDecimal Multiplier_
        {
            get
            {
                if (this.multiplier_ != null)
                {
                    return this.multiplier_; 
                }
                else if (this.multiplierIDRef_ != null)
                {
                    multiplier_ = IDManager.getID(multiplierIDRef_) as PositiveDecimal;
                    return this.multiplier_; 
                }
                else
                {
                      return this.multiplier_; 
                }
            }
            set
            {
                if (this.multiplier_ != value)
                {
                    this.multiplier_ = value;
                }
            }
        }
        #endregion
        
        public string multiplierIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityStrike : ISerialized
    {
        public EquityStrike(XmlNode xmlNode)
        {
            XmlNode strikePriceNode = xmlNode.SelectSingleNode("strikePrice");
            
            if (strikePriceNode != null)
            {
                if (strikePriceNode.Attributes["href"] != null || strikePriceNode.Attributes["id"] != null) 
                {
                    if (strikePriceNode.Attributes["id"] != null) 
                    {
                        strikePriceIDRef_ = strikePriceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(strikePriceNode);
                        IDManager.SetID(strikePriceIDRef_, ob);
                    }
                    else if (strikePriceNode.Attributes["href"] != null)
                    {
                        strikePriceIDRef_ = strikePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikePrice_ = new XsdTypeDecimal(strikePriceNode);
                    }
                }
                else
                {
                    strikePrice_ = new XsdTypeDecimal(strikePriceNode);
                }
            }
            
        
            XmlNode strikePercentageNode = xmlNode.SelectSingleNode("strikePercentage");
            
            if (strikePercentageNode != null)
            {
                if (strikePercentageNode.Attributes["href"] != null || strikePercentageNode.Attributes["id"] != null) 
                {
                    if (strikePercentageNode.Attributes["id"] != null) 
                    {
                        strikePercentageIDRef_ = strikePercentageNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(strikePercentageNode);
                        IDManager.SetID(strikePercentageIDRef_, ob);
                    }
                    else if (strikePercentageNode.Attributes["href"] != null)
                    {
                        strikePercentageIDRef_ = strikePercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikePercentage_ = new XsdTypeDecimal(strikePercentageNode);
                    }
                }
                else
                {
                    strikePercentage_ = new XsdTypeDecimal(strikePercentageNode);
                }
            }
            
        
            XmlNode strikeDeterminationDateNode = xmlNode.SelectSingleNode("strikeDeterminationDate");
            
            if (strikeDeterminationDateNode != null)
            {
                if (strikeDeterminationDateNode.Attributes["href"] != null || strikeDeterminationDateNode.Attributes["id"] != null) 
                {
                    if (strikeDeterminationDateNode.Attributes["id"] != null) 
                    {
                        strikeDeterminationDateIDRef_ = strikeDeterminationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(strikeDeterminationDateNode);
                        IDManager.SetID(strikeDeterminationDateIDRef_, ob);
                    }
                    else if (strikeDeterminationDateNode.Attributes["href"] != null)
                    {
                        strikeDeterminationDateIDRef_ = strikeDeterminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeDeterminationDate_ = new AdjustableOrRelativeDate(strikeDeterminationDateNode);
                    }
                }
                else
                {
                    strikeDeterminationDate_ = new AdjustableOrRelativeDate(strikeDeterminationDateNode);
                }
            }
            
        
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
            
        
        }
        
    
        #region StrikePrice_
        private XsdTypeDecimal strikePrice_;
        public XsdTypeDecimal StrikePrice_
        {
            get
            {
                if (this.strikePrice_ != null)
                {
                    return this.strikePrice_; 
                }
                else if (this.strikePriceIDRef_ != null)
                {
                    strikePrice_ = IDManager.getID(strikePriceIDRef_) as XsdTypeDecimal;
                    return this.strikePrice_; 
                }
                else
                {
                      return this.strikePrice_; 
                }
            }
            set
            {
                if (this.strikePrice_ != value)
                {
                    this.strikePrice_ = value;
                }
            }
        }
        #endregion
        
        public string strikePriceIDRef_ { get; set; }
        #region StrikePercentage_
        private XsdTypeDecimal strikePercentage_;
        public XsdTypeDecimal StrikePercentage_
        {
            get
            {
                if (this.strikePercentage_ != null)
                {
                    return this.strikePercentage_; 
                }
                else if (this.strikePercentageIDRef_ != null)
                {
                    strikePercentage_ = IDManager.getID(strikePercentageIDRef_) as XsdTypeDecimal;
                    return this.strikePercentage_; 
                }
                else
                {
                      return this.strikePercentage_; 
                }
            }
            set
            {
                if (this.strikePercentage_ != value)
                {
                    this.strikePercentage_ = value;
                }
            }
        }
        #endregion
        
        public string strikePercentageIDRef_ { get; set; }
        #region StrikeDeterminationDate_
        private AdjustableOrRelativeDate strikeDeterminationDate_;
        public AdjustableOrRelativeDate StrikeDeterminationDate_
        {
            get
            {
                if (this.strikeDeterminationDate_ != null)
                {
                    return this.strikeDeterminationDate_; 
                }
                else if (this.strikeDeterminationDateIDRef_ != null)
                {
                    strikeDeterminationDate_ = IDManager.getID(strikeDeterminationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.strikeDeterminationDate_; 
                }
                else
                {
                      return this.strikeDeterminationDate_; 
                }
            }
            set
            {
                if (this.strikeDeterminationDate_ != value)
                {
                    this.strikeDeterminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string strikeDeterminationDateIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

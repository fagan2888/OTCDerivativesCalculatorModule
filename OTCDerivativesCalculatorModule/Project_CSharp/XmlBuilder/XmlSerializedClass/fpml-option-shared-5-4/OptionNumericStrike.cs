using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionNumericStrike : ISerialized
    {
        public OptionNumericStrike(XmlNode xmlNode)
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
        public string choiceStr_0;
        
    
        
    
    }
    
}


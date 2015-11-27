using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PremiumQuote : ISerialized
    {
        public PremiumQuote(XmlNode xmlNode)
        {
            XmlNode valueNode = xmlNode.SelectSingleNode("value");
            
            if (valueNode != null)
            {
                if (valueNode.Attributes["href"] != null || valueNode.Attributes["id"] != null) 
                {
                    if (valueNode.Attributes["id"] != null) 
                    {
                        valueIDRef_ = valueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(valueNode);
                        IDManager.SetID(valueIDRef_, ob);
                    }
                    else if (valueNode.Attributes["href"] != null)
                    {
                        valueIDRef_ = valueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        value_ = new XsdTypeDecimal(valueNode);
                    }
                }
                else
                {
                    value_ = new XsdTypeDecimal(valueNode);
                }
            }
            
        
            XmlNode quoteBasisNode = xmlNode.SelectSingleNode("quoteBasis");
            
            if (quoteBasisNode != null)
            {
                if (quoteBasisNode.Attributes["href"] != null || quoteBasisNode.Attributes["id"] != null) 
                {
                    if (quoteBasisNode.Attributes["id"] != null) 
                    {
                        quoteBasisIDRef_ = quoteBasisNode.Attributes["id"].Value;
                        PremiumQuoteBasisEnum ob = new PremiumQuoteBasisEnum(quoteBasisNode);
                        IDManager.SetID(quoteBasisIDRef_, ob);
                    }
                    else if (quoteBasisNode.Attributes["href"] != null)
                    {
                        quoteBasisIDRef_ = quoteBasisNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quoteBasis_ = new PremiumQuoteBasisEnum(quoteBasisNode);
                    }
                }
                else
                {
                    quoteBasis_ = new PremiumQuoteBasisEnum(quoteBasisNode);
                }
            }
            
        
        }
        
    
        #region Value_
        private XsdTypeDecimal value_;
        public XsdTypeDecimal Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    value_ = IDManager.getID(valueIDRef_) as XsdTypeDecimal;
                    return this.value_; 
                }
                else
                {
                      return this.value_; 
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
        #region QuoteBasis_
        private PremiumQuoteBasisEnum quoteBasis_;
        public PremiumQuoteBasisEnum QuoteBasis_
        {
            get
            {
                if (this.quoteBasis_ != null)
                {
                    return this.quoteBasis_; 
                }
                else if (this.quoteBasisIDRef_ != null)
                {
                    quoteBasis_ = IDManager.getID(quoteBasisIDRef_) as PremiumQuoteBasisEnum;
                    return this.quoteBasis_; 
                }
                else
                {
                      return this.quoteBasis_; 
                }
            }
            set
            {
                if (this.quoteBasis_ != value)
                {
                    this.quoteBasis_ = value;
                }
            }
        }
        #endregion
        
        public string quoteBasisIDRef_ { get; set; }
        
    
        
    
    }
    
}


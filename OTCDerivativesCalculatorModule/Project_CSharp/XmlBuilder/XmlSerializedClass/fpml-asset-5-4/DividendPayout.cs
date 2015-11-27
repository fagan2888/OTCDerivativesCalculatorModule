using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendPayout : ISerialized
    {
        public DividendPayout(XmlNode xmlNode)
        {
            XmlNode dividendPayoutRatioNode = xmlNode.SelectSingleNode("dividendPayoutRatio");
            
            if (dividendPayoutRatioNode != null)
            {
                if (dividendPayoutRatioNode.Attributes["href"] != null || dividendPayoutRatioNode.Attributes["id"] != null) 
                {
                    if (dividendPayoutRatioNode.Attributes["id"] != null) 
                    {
                        dividendPayoutRatioIDRef_ = dividendPayoutRatioNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(dividendPayoutRatioNode);
                        IDManager.SetID(dividendPayoutRatioIDRef_, ob);
                    }
                    else if (dividendPayoutRatioNode.Attributes["href"] != null)
                    {
                        dividendPayoutRatioIDRef_ = dividendPayoutRatioNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPayoutRatio_ = new XsdTypeDecimal(dividendPayoutRatioNode);
                    }
                }
                else
                {
                    dividendPayoutRatio_ = new XsdTypeDecimal(dividendPayoutRatioNode);
                }
            }
            
        
            XmlNode dividendPayoutConditionsNode = xmlNode.SelectSingleNode("dividendPayoutConditions");
            
            if (dividendPayoutConditionsNode != null)
            {
                if (dividendPayoutConditionsNode.Attributes["href"] != null || dividendPayoutConditionsNode.Attributes["id"] != null) 
                {
                    if (dividendPayoutConditionsNode.Attributes["id"] != null) 
                    {
                        dividendPayoutConditionsIDRef_ = dividendPayoutConditionsNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(dividendPayoutConditionsNode);
                        IDManager.SetID(dividendPayoutConditionsIDRef_, ob);
                    }
                    else if (dividendPayoutConditionsNode.Attributes["href"] != null)
                    {
                        dividendPayoutConditionsIDRef_ = dividendPayoutConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPayoutConditions_ = new XsdTypeString(dividendPayoutConditionsNode);
                    }
                }
                else
                {
                    dividendPayoutConditions_ = new XsdTypeString(dividendPayoutConditionsNode);
                }
            }
            
        
            XmlNodeList dividendPaymentNodeList = xmlNode.SelectNodes("dividendPayment");
            
            if (dividendPaymentNodeList != null)
            {
                this.dividendPayment_ = new List<PendingPayment>();
                foreach (XmlNode item in dividendPaymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dividendPaymentIDRef_ = item.Attributes["id"].Value;
                            dividendPayment_.Add(new PendingPayment(item));
                            IDManager.SetID(dividendPaymentIDRef_, dividendPayment_[dividendPayment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dividendPaymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dividendPayment_.Add(new PendingPayment(item));
                        }
                    }
                    else
                    {
                        dividendPayment_.Add(new PendingPayment(item));
                    }
                }
            }
            
        
        }
        
    
        #region DividendPayoutRatio_
        private XsdTypeDecimal dividendPayoutRatio_;
        public XsdTypeDecimal DividendPayoutRatio_
        {
            get
            {
                if (this.dividendPayoutRatio_ != null)
                {
                    return this.dividendPayoutRatio_; 
                }
                else if (this.dividendPayoutRatioIDRef_ != null)
                {
                    dividendPayoutRatio_ = IDManager.getID(dividendPayoutRatioIDRef_) as XsdTypeDecimal;
                    return this.dividendPayoutRatio_; 
                }
                else
                {
                      return this.dividendPayoutRatio_; 
                }
            }
            set
            {
                if (this.dividendPayoutRatio_ != value)
                {
                    this.dividendPayoutRatio_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPayoutRatioIDRef_ { get; set; }
        #region DividendPayoutConditions_
        private XsdTypeString dividendPayoutConditions_;
        public XsdTypeString DividendPayoutConditions_
        {
            get
            {
                if (this.dividendPayoutConditions_ != null)
                {
                    return this.dividendPayoutConditions_; 
                }
                else if (this.dividendPayoutConditionsIDRef_ != null)
                {
                    dividendPayoutConditions_ = IDManager.getID(dividendPayoutConditionsIDRef_) as XsdTypeString;
                    return this.dividendPayoutConditions_; 
                }
                else
                {
                      return this.dividendPayoutConditions_; 
                }
            }
            set
            {
                if (this.dividendPayoutConditions_ != value)
                {
                    this.dividendPayoutConditions_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPayoutConditionsIDRef_ { get; set; }
        #region DividendPayment_
        private List<PendingPayment> dividendPayment_;
        public List<PendingPayment> DividendPayment_
        {
            get
            {
                if (this.dividendPayment_ != null)
                {
                    return this.dividendPayment_; 
                }
                else if (this.dividendPaymentIDRef_ != null)
                {
                    return this.dividendPayment_; 
                }
                else
                {
                      return this.dividendPayment_; 
                }
            }
            set
            {
                if (this.dividendPayment_ != value)
                {
                    this.dividendPayment_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPaymentIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


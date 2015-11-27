using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PercentageRule : PaymentRule
    {
        public PercentageRule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode paymentPercentNode = xmlNode.SelectSingleNode("paymentPercent");
            
            if (paymentPercentNode != null)
            {
                if (paymentPercentNode.Attributes["href"] != null || paymentPercentNode.Attributes["id"] != null) 
                {
                    if (paymentPercentNode.Attributes["id"] != null) 
                    {
                        paymentPercentIDRef_ = paymentPercentNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(paymentPercentNode);
                        IDManager.SetID(paymentPercentIDRef_, ob);
                    }
                    else if (paymentPercentNode.Attributes["href"] != null)
                    {
                        paymentPercentIDRef_ = paymentPercentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentPercent_ = new XsdTypeDecimal(paymentPercentNode);
                    }
                }
                else
                {
                    paymentPercent_ = new XsdTypeDecimal(paymentPercentNode);
                }
            }
            
        
            XmlNode notionalAmountReferenceNode = xmlNode.SelectSingleNode("notionalAmountReference");
            
            if (notionalAmountReferenceNode != null)
            {
                if (notionalAmountReferenceNode.Attributes["href"] != null || notionalAmountReferenceNode.Attributes["id"] != null) 
                {
                    if (notionalAmountReferenceNode.Attributes["id"] != null) 
                    {
                        notionalAmountReferenceIDRef_ = notionalAmountReferenceNode.Attributes["id"].Value;
                        NotionalAmountReference ob = new NotionalAmountReference(notionalAmountReferenceNode);
                        IDManager.SetID(notionalAmountReferenceIDRef_, ob);
                    }
                    else if (notionalAmountReferenceNode.Attributes["href"] != null)
                    {
                        notionalAmountReferenceIDRef_ = notionalAmountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmountReference_ = new NotionalAmountReference(notionalAmountReferenceNode);
                    }
                }
                else
                {
                    notionalAmountReference_ = new NotionalAmountReference(notionalAmountReferenceNode);
                }
            }
            
        
        }
        
    
        #region PaymentPercent_
        private XsdTypeDecimal paymentPercent_;
        public XsdTypeDecimal PaymentPercent_
        {
            get
            {
                if (this.paymentPercent_ != null)
                {
                    return this.paymentPercent_; 
                }
                else if (this.paymentPercentIDRef_ != null)
                {
                    paymentPercent_ = IDManager.getID(paymentPercentIDRef_) as XsdTypeDecimal;
                    return this.paymentPercent_; 
                }
                else
                {
                      return this.paymentPercent_; 
                }
            }
            set
            {
                if (this.paymentPercent_ != value)
                {
                    this.paymentPercent_ = value;
                }
            }
        }
        #endregion
        
        public string paymentPercentIDRef_ { get; set; }
        #region NotionalAmountReference_
        private NotionalAmountReference notionalAmountReference_;
        public NotionalAmountReference NotionalAmountReference_
        {
            get
            {
                if (this.notionalAmountReference_ != null)
                {
                    return this.notionalAmountReference_; 
                }
                else if (this.notionalAmountReferenceIDRef_ != null)
                {
                    notionalAmountReference_ = IDManager.getID(notionalAmountReferenceIDRef_) as NotionalAmountReference;
                    return this.notionalAmountReference_; 
                }
                else
                {
                      return this.notionalAmountReference_; 
                }
            }
            set
            {
                if (this.notionalAmountReference_ != value)
                {
                    this.notionalAmountReference_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}


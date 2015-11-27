using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExchangeTradedContract : ExchangeTraded
    {
        public ExchangeTradedContract(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode multiplierNode = xmlNode.SelectSingleNode("multiplier");
            
            if (multiplierNode != null)
            {
                if (multiplierNode.Attributes["href"] != null || multiplierNode.Attributes["id"] != null) 
                {
                    if (multiplierNode.Attributes["id"] != null) 
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(multiplierNode);
                        IDManager.SetID(multiplierIDRef_, ob);
                    }
                    else if (multiplierNode.Attributes["href"] != null)
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiplier_ = new XsdTypePositiveInteger(multiplierNode);
                    }
                }
                else
                {
                    multiplier_ = new XsdTypePositiveInteger(multiplierNode);
                }
            }
            
        
            XmlNode contractReferenceNode = xmlNode.SelectSingleNode("contractReference");
            
            if (contractReferenceNode != null)
            {
                if (contractReferenceNode.Attributes["href"] != null || contractReferenceNode.Attributes["id"] != null) 
                {
                    if (contractReferenceNode.Attributes["id"] != null) 
                    {
                        contractReferenceIDRef_ = contractReferenceNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(contractReferenceNode);
                        IDManager.SetID(contractReferenceIDRef_, ob);
                    }
                    else if (contractReferenceNode.Attributes["href"] != null)
                    {
                        contractReferenceIDRef_ = contractReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        contractReference_ = new XsdTypeString(contractReferenceNode);
                    }
                }
                else
                {
                    contractReference_ = new XsdTypeString(contractReferenceNode);
                }
            }
            
        
            XmlNode expirationDateNode = xmlNode.SelectSingleNode("expirationDate");
            
            if (expirationDateNode != null)
            {
                if (expirationDateNode.Attributes["href"] != null || expirationDateNode.Attributes["id"] != null) 
                {
                    if (expirationDateNode.Attributes["id"] != null) 
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(expirationDateNode);
                        IDManager.SetID(expirationDateIDRef_, ob);
                    }
                    else if (expirationDateNode.Attributes["href"] != null)
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                    }
                }
                else
                {
                    expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                }
            }
            
        
        }
        
    
        #region Multiplier_
        private XsdTypePositiveInteger multiplier_;
        public XsdTypePositiveInteger Multiplier_
        {
            get
            {
                if (this.multiplier_ != null)
                {
                    return this.multiplier_; 
                }
                else if (this.multiplierIDRef_ != null)
                {
                    multiplier_ = IDManager.getID(multiplierIDRef_) as XsdTypePositiveInteger;
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
        #region ContractReference_
        private XsdTypeString contractReference_;
        public XsdTypeString ContractReference_
        {
            get
            {
                if (this.contractReference_ != null)
                {
                    return this.contractReference_; 
                }
                else if (this.contractReferenceIDRef_ != null)
                {
                    contractReference_ = IDManager.getID(contractReferenceIDRef_) as XsdTypeString;
                    return this.contractReference_; 
                }
                else
                {
                      return this.contractReference_; 
                }
            }
            set
            {
                if (this.contractReference_ != value)
                {
                    this.contractReference_ = value;
                }
            }
        }
        #endregion
        
        public string contractReferenceIDRef_ { get; set; }
        #region ExpirationDate_
        private AdjustableOrRelativeDate expirationDate_;
        public AdjustableOrRelativeDate ExpirationDate_
        {
            get
            {
                if (this.expirationDate_ != null)
                {
                    return this.expirationDate_; 
                }
                else if (this.expirationDateIDRef_ != null)
                {
                    expirationDate_ = IDManager.getID(expirationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.expirationDate_; 
                }
                else
                {
                      return this.expirationDate_; 
                }
            }
            set
            {
                if (this.expirationDate_ != value)
                {
                    this.expirationDate_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


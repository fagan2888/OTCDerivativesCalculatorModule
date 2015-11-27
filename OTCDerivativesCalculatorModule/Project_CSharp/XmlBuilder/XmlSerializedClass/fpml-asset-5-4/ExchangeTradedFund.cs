using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExchangeTradedFund : ExchangeTradedCalculatedPrice
    {
        public ExchangeTradedFund(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fundManagerNode = xmlNode.SelectSingleNode("fundManager");
            
            if (fundManagerNode != null)
            {
                if (fundManagerNode.Attributes["href"] != null || fundManagerNode.Attributes["id"] != null) 
                {
                    if (fundManagerNode.Attributes["id"] != null) 
                    {
                        fundManagerIDRef_ = fundManagerNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(fundManagerNode);
                        IDManager.SetID(fundManagerIDRef_, ob);
                    }
                    else if (fundManagerNode.Attributes["href"] != null)
                    {
                        fundManagerIDRef_ = fundManagerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fundManager_ = new XsdTypeString(fundManagerNode);
                    }
                }
                else
                {
                    fundManager_ = new XsdTypeString(fundManagerNode);
                }
            }
            
        
        }
        
    
        #region FundManager_
        private XsdTypeString fundManager_;
        public XsdTypeString FundManager_
        {
            get
            {
                if (this.fundManager_ != null)
                {
                    return this.fundManager_; 
                }
                else if (this.fundManagerIDRef_ != null)
                {
                    fundManager_ = IDManager.getID(fundManagerIDRef_) as XsdTypeString;
                    return this.fundManager_; 
                }
                else
                {
                      return this.fundManager_; 
                }
            }
            set
            {
                if (this.fundManager_ != value)
                {
                    this.fundManager_ = value;
                }
            }
        }
        #endregion
        
        public string fundManagerIDRef_ { get; set; }
        
    
        
    
    }
    
}


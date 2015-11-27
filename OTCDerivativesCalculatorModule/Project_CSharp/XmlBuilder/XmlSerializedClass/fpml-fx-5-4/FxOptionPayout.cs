using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxOptionPayout : NonNegativeMoney
    {
        public FxOptionPayout(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payoutStyleNode = xmlNode.SelectSingleNode("payoutStyle");
            
            if (payoutStyleNode != null)
            {
                if (payoutStyleNode.Attributes["href"] != null || payoutStyleNode.Attributes["id"] != null) 
                {
                    if (payoutStyleNode.Attributes["id"] != null) 
                    {
                        payoutStyleIDRef_ = payoutStyleNode.Attributes["id"].Value;
                        PayoutEnum ob = new PayoutEnum(payoutStyleNode);
                        IDManager.SetID(payoutStyleIDRef_, ob);
                    }
                    else if (payoutStyleNode.Attributes["href"] != null)
                    {
                        payoutStyleIDRef_ = payoutStyleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoutStyle_ = new PayoutEnum(payoutStyleNode);
                    }
                }
                else
                {
                    payoutStyle_ = new PayoutEnum(payoutStyleNode);
                }
            }
            
        
            XmlNode settlementInformationNode = xmlNode.SelectSingleNode("settlementInformation");
            
            if (settlementInformationNode != null)
            {
                if (settlementInformationNode.Attributes["href"] != null || settlementInformationNode.Attributes["id"] != null) 
                {
                    if (settlementInformationNode.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef_ = settlementInformationNode.Attributes["id"].Value;
                        SettlementInformation ob = new SettlementInformation(settlementInformationNode);
                        IDManager.SetID(settlementInformationIDRef_, ob);
                    }
                    else if (settlementInformationNode.Attributes["href"] != null)
                    {
                        settlementInformationIDRef_ = settlementInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementInformation_ = new SettlementInformation(settlementInformationNode);
                    }
                }
                else
                {
                    settlementInformation_ = new SettlementInformation(settlementInformationNode);
                }
            }
            
        
        }
        
    
        #region PayoutStyle_
        private PayoutEnum payoutStyle_;
        public PayoutEnum PayoutStyle_
        {
            get
            {
                if (this.payoutStyle_ != null)
                {
                    return this.payoutStyle_; 
                }
                else if (this.payoutStyleIDRef_ != null)
                {
                    payoutStyle_ = IDManager.getID(payoutStyleIDRef_) as PayoutEnum;
                    return this.payoutStyle_; 
                }
                else
                {
                      return this.payoutStyle_; 
                }
            }
            set
            {
                if (this.payoutStyle_ != value)
                {
                    this.payoutStyle_ = value;
                }
            }
        }
        #endregion
        
        public string payoutStyleIDRef_ { get; set; }
        #region SettlementInformation_
        private SettlementInformation settlementInformation_;
        public SettlementInformation SettlementInformation_
        {
            get
            {
                if (this.settlementInformation_ != null)
                {
                    return this.settlementInformation_; 
                }
                else if (this.settlementInformationIDRef_ != null)
                {
                    settlementInformation_ = IDManager.getID(settlementInformationIDRef_) as SettlementInformation;
                    return this.settlementInformation_; 
                }
                else
                {
                      return this.settlementInformation_; 
                }
            }
            set
            {
                if (this.settlementInformation_ != value)
                {
                    this.settlementInformation_ = value;
                }
            }
        }
        #endregion
        
        public string settlementInformationIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PaymentDetails : ISerialized
    {
        public PaymentDetails(XmlNode xmlNode)
        {
            XmlNode paymentReferenceNode = xmlNode.SelectSingleNode("paymentReference");
            
            if (paymentReferenceNode != null)
            {
                if (paymentReferenceNode.Attributes["href"] != null || paymentReferenceNode.Attributes["id"] != null) 
                {
                    if (paymentReferenceNode.Attributes["id"] != null) 
                    {
                        paymentReferenceIDRef_ = paymentReferenceNode.Attributes["id"].Value;
                        PaymentReference ob = new PaymentReference(paymentReferenceNode);
                        IDManager.SetID(paymentReferenceIDRef_, ob);
                    }
                    else if (paymentReferenceNode.Attributes["href"] != null)
                    {
                        paymentReferenceIDRef_ = paymentReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentReference_ = new PaymentReference(paymentReferenceNode);
                    }
                }
                else
                {
                    paymentReference_ = new PaymentReference(paymentReferenceNode);
                }
            }
            
        
            XmlNodeList grossCashflowNodeList = xmlNode.SelectNodes("grossCashflow");
            
            if (grossCashflowNodeList != null)
            {
                this.grossCashflow_ = new List<GrossCashflow>();
                foreach (XmlNode item in grossCashflowNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            grossCashflowIDRef_ = item.Attributes["id"].Value;
                            grossCashflow_.Add(new GrossCashflow(item));
                            IDManager.SetID(grossCashflowIDRef_, grossCashflow_[grossCashflow_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            grossCashflowIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        grossCashflow_.Add(new GrossCashflow(item));
                        }
                    }
                    else
                    {
                        grossCashflow_.Add(new GrossCashflow(item));
                    }
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
        
    
        #region PaymentReference_
        private PaymentReference paymentReference_;
        public PaymentReference PaymentReference_
        {
            get
            {
                if (this.paymentReference_ != null)
                {
                    return this.paymentReference_; 
                }
                else if (this.paymentReferenceIDRef_ != null)
                {
                    paymentReference_ = IDManager.getID(paymentReferenceIDRef_) as PaymentReference;
                    return this.paymentReference_; 
                }
                else
                {
                      return this.paymentReference_; 
                }
            }
            set
            {
                if (this.paymentReference_ != value)
                {
                    this.paymentReference_ = value;
                }
            }
        }
        #endregion
        
        public string paymentReferenceIDRef_ { get; set; }
        #region GrossCashflow_
        private List<GrossCashflow> grossCashflow_;
        public List<GrossCashflow> GrossCashflow_
        {
            get
            {
                if (this.grossCashflow_ != null)
                {
                    return this.grossCashflow_; 
                }
                else if (this.grossCashflowIDRef_ != null)
                {
                    return this.grossCashflow_; 
                }
                else
                {
                      return this.grossCashflow_; 
                }
            }
            set
            {
                if (this.grossCashflow_ != value)
                {
                    this.grossCashflow_ = value;
                }
            }
        }
        #endregion
        
        public string grossCashflowIDRef_ { get; set; }
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


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PCDeliverableObligationCharac : ISerialized
    {
        public PCDeliverableObligationCharac(XmlNode xmlNode)
        {
            XmlNode applicableNode = xmlNode.SelectSingleNode("applicable");
            
            if (applicableNode != null)
            {
                if (applicableNode.Attributes["href"] != null || applicableNode.Attributes["id"] != null) 
                {
                    if (applicableNode.Attributes["id"] != null) 
                    {
                        applicableIDRef_ = applicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(applicableNode);
                        IDManager.SetID(applicableIDRef_, ob);
                    }
                    else if (applicableNode.Attributes["href"] != null)
                    {
                        applicableIDRef_ = applicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicable_ = new XsdTypeBoolean(applicableNode);
                    }
                }
                else
                {
                    applicable_ = new XsdTypeBoolean(applicableNode);
                }
            }
            
        
            XmlNode partialCashSettlementNode = xmlNode.SelectSingleNode("partialCashSettlement");
            
            if (partialCashSettlementNode != null)
            {
                if (partialCashSettlementNode.Attributes["href"] != null || partialCashSettlementNode.Attributes["id"] != null) 
                {
                    if (partialCashSettlementNode.Attributes["id"] != null) 
                    {
                        partialCashSettlementIDRef_ = partialCashSettlementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(partialCashSettlementNode);
                        IDManager.SetID(partialCashSettlementIDRef_, ob);
                    }
                    else if (partialCashSettlementNode.Attributes["href"] != null)
                    {
                        partialCashSettlementIDRef_ = partialCashSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partialCashSettlement_ = new XsdTypeBoolean(partialCashSettlementNode);
                    }
                }
                else
                {
                    partialCashSettlement_ = new XsdTypeBoolean(partialCashSettlementNode);
                }
            }
            
        
        }
        
    
        #region Applicable_
        private XsdTypeBoolean applicable_;
        public XsdTypeBoolean Applicable_
        {
            get
            {
                if (this.applicable_ != null)
                {
                    return this.applicable_; 
                }
                else if (this.applicableIDRef_ != null)
                {
                    applicable_ = IDManager.getID(applicableIDRef_) as XsdTypeBoolean;
                    return this.applicable_; 
                }
                else
                {
                      return this.applicable_; 
                }
            }
            set
            {
                if (this.applicable_ != value)
                {
                    this.applicable_ = value;
                }
            }
        }
        #endregion
        
        public string applicableIDRef_ { get; set; }
        #region PartialCashSettlement_
        private XsdTypeBoolean partialCashSettlement_;
        public XsdTypeBoolean PartialCashSettlement_
        {
            get
            {
                if (this.partialCashSettlement_ != null)
                {
                    return this.partialCashSettlement_; 
                }
                else if (this.partialCashSettlementIDRef_ != null)
                {
                    partialCashSettlement_ = IDManager.getID(partialCashSettlementIDRef_) as XsdTypeBoolean;
                    return this.partialCashSettlement_; 
                }
                else
                {
                      return this.partialCashSettlement_; 
                }
            }
            set
            {
                if (this.partialCashSettlement_ != value)
                {
                    this.partialCashSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string partialCashSettlementIDRef_ { get; set; }
        
    
        
    
    }
    
}


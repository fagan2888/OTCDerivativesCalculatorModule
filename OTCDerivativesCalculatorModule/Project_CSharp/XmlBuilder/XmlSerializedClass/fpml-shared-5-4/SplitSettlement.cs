using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SplitSettlement : ISerialized
    {
        public SplitSettlement(XmlNode xmlNode)
        {
            XmlNode splitSettlementAmountNode = xmlNode.SelectSingleNode("splitSettlementAmount");
            
            if (splitSettlementAmountNode != null)
            {
                if (splitSettlementAmountNode.Attributes["href"] != null || splitSettlementAmountNode.Attributes["id"] != null) 
                {
                    if (splitSettlementAmountNode.Attributes["id"] != null) 
                    {
                        splitSettlementAmountIDRef_ = splitSettlementAmountNode.Attributes["id"].Value;
                        Money ob = new Money(splitSettlementAmountNode);
                        IDManager.SetID(splitSettlementAmountIDRef_, ob);
                    }
                    else if (splitSettlementAmountNode.Attributes["href"] != null)
                    {
                        splitSettlementAmountIDRef_ = splitSettlementAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        splitSettlementAmount_ = new Money(splitSettlementAmountNode);
                    }
                }
                else
                {
                    splitSettlementAmount_ = new Money(splitSettlementAmountNode);
                }
            }
            
        
            XmlNode beneficiaryBankNode = xmlNode.SelectSingleNode("beneficiaryBank");
            
            if (beneficiaryBankNode != null)
            {
                if (beneficiaryBankNode.Attributes["href"] != null || beneficiaryBankNode.Attributes["id"] != null) 
                {
                    if (beneficiaryBankNode.Attributes["id"] != null) 
                    {
                        beneficiaryBankIDRef_ = beneficiaryBankNode.Attributes["id"].Value;
                        Routing ob = new Routing(beneficiaryBankNode);
                        IDManager.SetID(beneficiaryBankIDRef_, ob);
                    }
                    else if (beneficiaryBankNode.Attributes["href"] != null)
                    {
                        beneficiaryBankIDRef_ = beneficiaryBankNode.Attributes["href"].Value;
                    }
                    else
                    {
                        beneficiaryBank_ = new Routing(beneficiaryBankNode);
                    }
                }
                else
                {
                    beneficiaryBank_ = new Routing(beneficiaryBankNode);
                }
            }
            
        
            XmlNode beneficiaryNode = xmlNode.SelectSingleNode("beneficiary");
            
            if (beneficiaryNode != null)
            {
                if (beneficiaryNode.Attributes["href"] != null || beneficiaryNode.Attributes["id"] != null) 
                {
                    if (beneficiaryNode.Attributes["id"] != null) 
                    {
                        beneficiaryIDRef_ = beneficiaryNode.Attributes["id"].Value;
                        Routing ob = new Routing(beneficiaryNode);
                        IDManager.SetID(beneficiaryIDRef_, ob);
                    }
                    else if (beneficiaryNode.Attributes["href"] != null)
                    {
                        beneficiaryIDRef_ = beneficiaryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        beneficiary_ = new Routing(beneficiaryNode);
                    }
                }
                else
                {
                    beneficiary_ = new Routing(beneficiaryNode);
                }
            }
            
        
        }
        
    
        #region SplitSettlementAmount_
        private Money splitSettlementAmount_;
        public Money SplitSettlementAmount_
        {
            get
            {
                if (this.splitSettlementAmount_ != null)
                {
                    return this.splitSettlementAmount_; 
                }
                else if (this.splitSettlementAmountIDRef_ != null)
                {
                    splitSettlementAmount_ = IDManager.getID(splitSettlementAmountIDRef_) as Money;
                    return this.splitSettlementAmount_; 
                }
                else
                {
                      return this.splitSettlementAmount_; 
                }
            }
            set
            {
                if (this.splitSettlementAmount_ != value)
                {
                    this.splitSettlementAmount_ = value;
                }
            }
        }
        #endregion
        
        public string splitSettlementAmountIDRef_ { get; set; }
        #region BeneficiaryBank_
        private Routing beneficiaryBank_;
        public Routing BeneficiaryBank_
        {
            get
            {
                if (this.beneficiaryBank_ != null)
                {
                    return this.beneficiaryBank_; 
                }
                else if (this.beneficiaryBankIDRef_ != null)
                {
                    beneficiaryBank_ = IDManager.getID(beneficiaryBankIDRef_) as Routing;
                    return this.beneficiaryBank_; 
                }
                else
                {
                      return this.beneficiaryBank_; 
                }
            }
            set
            {
                if (this.beneficiaryBank_ != value)
                {
                    this.beneficiaryBank_ = value;
                }
            }
        }
        #endregion
        
        public string beneficiaryBankIDRef_ { get; set; }
        #region Beneficiary_
        private Routing beneficiary_;
        public Routing Beneficiary_
        {
            get
            {
                if (this.beneficiary_ != null)
                {
                    return this.beneficiary_; 
                }
                else if (this.beneficiaryIDRef_ != null)
                {
                    beneficiary_ = IDManager.getID(beneficiaryIDRef_) as Routing;
                    return this.beneficiary_; 
                }
                else
                {
                      return this.beneficiary_; 
                }
            }
            set
            {
                if (this.beneficiary_ != value)
                {
                    this.beneficiary_ = value;
                }
            }
        }
        #endregion
        
        public string beneficiaryIDRef_ { get; set; }
        
    
        
    
    }
    
}


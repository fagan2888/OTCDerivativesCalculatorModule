using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SettlementRateSource : ISerialized
    {
        public SettlementRateSource(XmlNode xmlNode)
        {
            XmlNode informationSourceNode = xmlNode.SelectSingleNode("informationSource");
            
            if (informationSourceNode != null)
            {
                if (informationSourceNode.Attributes["href"] != null || informationSourceNode.Attributes["id"] != null) 
                {
                    if (informationSourceNode.Attributes["id"] != null) 
                    {
                        informationSourceIDRef_ = informationSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(informationSourceNode);
                        IDManager.SetID(informationSourceIDRef_, ob);
                    }
                    else if (informationSourceNode.Attributes["href"] != null)
                    {
                        informationSourceIDRef_ = informationSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        informationSource_ = new InformationSource(informationSourceNode);
                    }
                }
                else
                {
                    informationSource_ = new InformationSource(informationSourceNode);
                }
            }
            
        
            XmlNode cashSettlementReferenceBanksNode = xmlNode.SelectSingleNode("cashSettlementReferenceBanks");
            
            if (cashSettlementReferenceBanksNode != null)
            {
                if (cashSettlementReferenceBanksNode.Attributes["href"] != null || cashSettlementReferenceBanksNode.Attributes["id"] != null) 
                {
                    if (cashSettlementReferenceBanksNode.Attributes["id"] != null) 
                    {
                        cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode.Attributes["id"].Value;
                        CashSettlementReferenceBanks ob = new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode);
                        IDManager.SetID(cashSettlementReferenceBanksIDRef_, ob);
                    }
                    else if (cashSettlementReferenceBanksNode.Attributes["href"] != null)
                    {
                        cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementReferenceBanks_ = new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode);
                    }
                }
                else
                {
                    cashSettlementReferenceBanks_ = new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode);
                }
            }
            
        
        }
        
    
        #region InformationSource_
        private InformationSource informationSource_;
        public InformationSource InformationSource_
        {
            get
            {
                if (this.informationSource_ != null)
                {
                    return this.informationSource_; 
                }
                else if (this.informationSourceIDRef_ != null)
                {
                    informationSource_ = IDManager.getID(informationSourceIDRef_) as InformationSource;
                    return this.informationSource_; 
                }
                else
                {
                      return this.informationSource_; 
                }
            }
            set
            {
                if (this.informationSource_ != value)
                {
                    this.informationSource_ = value;
                }
            }
        }
        #endregion
        
        public string informationSourceIDRef_ { get; set; }
        #region CashSettlementReferenceBanks_
        private CashSettlementReferenceBanks cashSettlementReferenceBanks_;
        public CashSettlementReferenceBanks CashSettlementReferenceBanks_
        {
            get
            {
                if (this.cashSettlementReferenceBanks_ != null)
                {
                    return this.cashSettlementReferenceBanks_; 
                }
                else if (this.cashSettlementReferenceBanksIDRef_ != null)
                {
                    cashSettlementReferenceBanks_ = IDManager.getID(cashSettlementReferenceBanksIDRef_) as CashSettlementReferenceBanks;
                    return this.cashSettlementReferenceBanks_; 
                }
                else
                {
                      return this.cashSettlementReferenceBanks_; 
                }
            }
            set
            {
                if (this.cashSettlementReferenceBanks_ != value)
                {
                    this.cashSettlementReferenceBanks_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementReferenceBanksIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


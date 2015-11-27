using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementRateSource
    {
        public SettlementRateSource(XmlNode xmlNode)
        {
            XmlNodeList informationSourceNodeList = xmlNode.SelectNodes("informationSource");
            if (informationSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in informationSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        informationSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(informationSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        informationSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        informationSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementReferenceBanksNodeList = xmlNode.SelectNodes("cashSettlementReferenceBanks");
            if (cashSettlementReferenceBanksNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementReferenceBanksNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementReferenceBanksIDRef = item.Attributes["id"].Name;
                        CashSettlementReferenceBanks ob = CashSettlementReferenceBanks();
                        IDManager.SetID(cashSettlementReferenceBanksIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementReferenceBanksIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementReferenceBanks = new CashSettlementReferenceBanks(item);
                    }
                }
            }
            
        
        }
        
    
        #region InformationSource
        private InformationSource informationSource;
        public InformationSource InformationSource
        {
            get
            {
                if (this.informationSource != null)
                {
                    return this.informationSource; 
                }
                else if (this.informationSourceIDRef != null)
                {
                    informationSource = IDManager.getID(informationSourceIDRef) as InformationSource;
                    return this.informationSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.informationSource != value)
                {
                    this.informationSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region CashSettlementReferenceBanks
        private CashSettlementReferenceBanks cashSettlementReferenceBanks;
        public CashSettlementReferenceBanks CashSettlementReferenceBanks
        {
            get
            {
                if (this.cashSettlementReferenceBanks != null)
                {
                    return this.cashSettlementReferenceBanks; 
                }
                else if (this.cashSettlementReferenceBanksIDRef != null)
                {
                    cashSettlementReferenceBanks = IDManager.getID(cashSettlementReferenceBanksIDRef) as CashSettlementReferenceBanks;
                    return this.cashSettlementReferenceBanks; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementReferenceBanks != value)
                {
                    this.cashSettlementReferenceBanks = value;
                }
            }
        }
        #endregion
        
        public string CashSettlementReferenceBanksIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


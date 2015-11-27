using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SplitSettlement
    {
        public SplitSettlement(XmlNode xmlNode)
        {
            XmlNodeList splitSettlementAmountNodeList = xmlNode.SelectNodes("splitSettlementAmount");
            if (splitSettlementAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in splitSettlementAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        splitSettlementAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(splitSettlementAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        splitSettlementAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        splitSettlementAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList beneficiaryBankNodeList = xmlNode.SelectNodes("beneficiaryBank");
            if (beneficiaryBankNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in beneficiaryBankNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        beneficiaryBankIDRef = item.Attributes["id"].Name;
                        Routing ob = Routing();
                        IDManager.SetID(beneficiaryBankIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        beneficiaryBankIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        beneficiaryBank = new Routing(item);
                    }
                }
            }
            
        
            XmlNodeList beneficiaryNodeList = xmlNode.SelectNodes("beneficiary");
            if (beneficiaryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in beneficiaryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        beneficiaryIDRef = item.Attributes["id"].Name;
                        Routing ob = Routing();
                        IDManager.SetID(beneficiaryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        beneficiaryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        beneficiary = new Routing(item);
                    }
                }
            }
            
        
        }
        
    
        #region SplitSettlementAmount
        private Money splitSettlementAmount;
        public Money SplitSettlementAmount
        {
            get
            {
                if (this.splitSettlementAmount != null)
                {
                    return this.splitSettlementAmount; 
                }
                else if (this.splitSettlementAmountIDRef != null)
                {
                    splitSettlementAmount = IDManager.getID(splitSettlementAmountIDRef) as Money;
                    return this.splitSettlementAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.splitSettlementAmount != value)
                {
                    this.splitSettlementAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region BeneficiaryBank
        private Routing beneficiaryBank;
        public Routing BeneficiaryBank
        {
            get
            {
                if (this.beneficiaryBank != null)
                {
                    return this.beneficiaryBank; 
                }
                else if (this.beneficiaryBankIDRef != null)
                {
                    beneficiaryBank = IDManager.getID(beneficiaryBankIDRef) as Routing;
                    return this.beneficiaryBank; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.beneficiaryBank != value)
                {
                    this.beneficiaryBank = value;
                }
            }
        }
        #endregion
        
        public string RoutingIDRef { get; set; }
        #region Beneficiary
        private Routing beneficiary;
        public Routing Beneficiary
        {
            get
            {
                if (this.beneficiary != null)
                {
                    return this.beneficiary; 
                }
                else if (this.beneficiaryIDRef != null)
                {
                    beneficiary = IDManager.getID(beneficiaryIDRef) as Routing;
                    return this.beneficiary; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.beneficiary != value)
                {
                    this.beneficiary = value;
                }
            }
        }
        #endregion
        
        public string RoutingIDRef { get; set; }
        
    
        
    
    }
    
}


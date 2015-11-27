using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CashSettlementReferenceBanks
    {
        public CashSettlementReferenceBanks(XmlNode xmlNode)
        {
            XmlNodeList referenceBankNodeList = xmlNode.SelectNodes("referenceBank");
            
            foreach (XmlNode item in referenceBankNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceBankIDRef = item.Attributes["id"].Name;
                        List<ReferenceBank> ob = new List<ReferenceBank>();
                        ob.Add(new ReferenceBank(item));
                        IDManager.SetID(referenceBankIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceBankIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    referenceBank.Add(new ReferenceBank(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceBank
        private List<ReferenceBank> referenceBank;
        public List<ReferenceBank> ReferenceBank
        {
            get
            {
                if (this.referenceBank != null)
                {
                    return this.referenceBank; 
                }
                else if (this.referenceBankIDRef != null)
                {
                    referenceBank = IDManager.getID(referenceBankIDRef) as List<ReferenceBank>;
                    return this.referenceBank; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceBank != value)
                {
                    this.referenceBank = value;
                }
            }
        }
        #endregion
        
        public string ReferenceBankIDRef { get; set; }
        
    
        
    
    }
    
}


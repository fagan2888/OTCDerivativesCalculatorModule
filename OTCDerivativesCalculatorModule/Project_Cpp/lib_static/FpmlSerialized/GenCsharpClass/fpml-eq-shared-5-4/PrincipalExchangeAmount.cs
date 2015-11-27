using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchangeAmount
    {
        public PrincipalExchangeAmount(XmlNode xmlNode)
        {
            XmlNodeList amountRelativeToNodeList = xmlNode.SelectNodes("amountRelativeTo");
            if (amountRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountRelativeToIDRef = item.Attributes["id"].Name;
                        AmountReference ob = AmountReference();
                        IDManager.SetID(amountRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amountRelativeTo = new AmountReference(item);
                    }
                }
            }
            
        
            XmlNodeList determinationMethodNodeList = xmlNode.SelectNodes("determinationMethod");
            if (determinationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determinationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(determinationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determinationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determinationMethod = new DeterminationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList principalAmountNodeList = xmlNode.SelectNodes("principalAmount");
            if (principalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(principalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region AmountRelativeTo
        private AmountReference amountRelativeTo;
        public AmountReference AmountRelativeTo
        {
            get
            {
                if (this.amountRelativeTo != null)
                {
                    return this.amountRelativeTo; 
                }
                else if (this.amountRelativeToIDRef != null)
                {
                    amountRelativeTo = IDManager.getID(amountRelativeToIDRef) as AmountReference;
                    return this.amountRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amountRelativeTo != value)
                {
                    this.amountRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string AmountReferenceIDRef { get; set; }
        #region DeterminationMethod
        private DeterminationMethod determinationMethod;
        public DeterminationMethod DeterminationMethod
        {
            get
            {
                if (this.determinationMethod != null)
                {
                    return this.determinationMethod; 
                }
                else if (this.determinationMethodIDRef != null)
                {
                    determinationMethod = IDManager.getID(determinationMethodIDRef) as DeterminationMethod;
                    return this.determinationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determinationMethod != value)
                {
                    this.determinationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        #region PrincipalAmount
        private NonNegativeMoney principalAmount;
        public NonNegativeMoney PrincipalAmount
        {
            get
            {
                if (this.principalAmount != null)
                {
                    return this.principalAmount; 
                }
                else if (this.principalAmountIDRef != null)
                {
                    principalAmount = IDManager.getID(principalAmountIDRef) as NonNegativeMoney;
                    return this.principalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalAmount != value)
                {
                    this.principalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


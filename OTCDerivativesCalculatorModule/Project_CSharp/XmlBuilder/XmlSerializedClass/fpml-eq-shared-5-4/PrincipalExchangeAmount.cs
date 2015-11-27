using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchangeAmount : ISerialized
    {
        public PrincipalExchangeAmount(XmlNode xmlNode)
        {
            XmlNode amountRelativeToNode = xmlNode.SelectSingleNode("amountRelativeTo");
            
            if (amountRelativeToNode != null)
            {
                if (amountRelativeToNode.Attributes["href"] != null || amountRelativeToNode.Attributes["id"] != null) 
                {
                    if (amountRelativeToNode.Attributes["id"] != null) 
                    {
                        amountRelativeToIDRef_ = amountRelativeToNode.Attributes["id"].Value;
                        AmountReference ob = new AmountReference(amountRelativeToNode);
                        IDManager.SetID(amountRelativeToIDRef_, ob);
                    }
                    else if (amountRelativeToNode.Attributes["href"] != null)
                    {
                        amountRelativeToIDRef_ = amountRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amountRelativeTo_ = new AmountReference(amountRelativeToNode);
                    }
                }
                else
                {
                    amountRelativeTo_ = new AmountReference(amountRelativeToNode);
                }
            }
            
        
            XmlNode determinationMethodNode = xmlNode.SelectSingleNode("determinationMethod");
            
            if (determinationMethodNode != null)
            {
                if (determinationMethodNode.Attributes["href"] != null || determinationMethodNode.Attributes["id"] != null) 
                {
                    if (determinationMethodNode.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(determinationMethodNode);
                        IDManager.SetID(determinationMethodIDRef_, ob);
                    }
                    else if (determinationMethodNode.Attributes["href"] != null)
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                    }
                }
                else
                {
                    determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                }
            }
            
        
            XmlNode principalAmountNode = xmlNode.SelectSingleNode("principalAmount");
            
            if (principalAmountNode != null)
            {
                if (principalAmountNode.Attributes["href"] != null || principalAmountNode.Attributes["id"] != null) 
                {
                    if (principalAmountNode.Attributes["id"] != null) 
                    {
                        principalAmountIDRef_ = principalAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(principalAmountNode);
                        IDManager.SetID(principalAmountIDRef_, ob);
                    }
                    else if (principalAmountNode.Attributes["href"] != null)
                    {
                        principalAmountIDRef_ = principalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalAmount_ = new NonNegativeMoney(principalAmountNode);
                    }
                }
                else
                {
                    principalAmount_ = new NonNegativeMoney(principalAmountNode);
                }
            }
            
        
        }
        
    
        #region AmountRelativeTo_
        private AmountReference amountRelativeTo_;
        public AmountReference AmountRelativeTo_
        {
            get
            {
                if (this.amountRelativeTo_ != null)
                {
                    return this.amountRelativeTo_; 
                }
                else if (this.amountRelativeToIDRef_ != null)
                {
                    amountRelativeTo_ = IDManager.getID(amountRelativeToIDRef_) as AmountReference;
                    return this.amountRelativeTo_; 
                }
                else
                {
                      return this.amountRelativeTo_; 
                }
            }
            set
            {
                if (this.amountRelativeTo_ != value)
                {
                    this.amountRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string amountRelativeToIDRef_ { get; set; }
        #region DeterminationMethod_
        private DeterminationMethod determinationMethod_;
        public DeterminationMethod DeterminationMethod_
        {
            get
            {
                if (this.determinationMethod_ != null)
                {
                    return this.determinationMethod_; 
                }
                else if (this.determinationMethodIDRef_ != null)
                {
                    determinationMethod_ = IDManager.getID(determinationMethodIDRef_) as DeterminationMethod;
                    return this.determinationMethod_; 
                }
                else
                {
                      return this.determinationMethod_; 
                }
            }
            set
            {
                if (this.determinationMethod_ != value)
                {
                    this.determinationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string determinationMethodIDRef_ { get; set; }
        #region PrincipalAmount_
        private NonNegativeMoney principalAmount_;
        public NonNegativeMoney PrincipalAmount_
        {
            get
            {
                if (this.principalAmount_ != null)
                {
                    return this.principalAmount_; 
                }
                else if (this.principalAmountIDRef_ != null)
                {
                    principalAmount_ = IDManager.getID(principalAmountIDRef_) as NonNegativeMoney;
                    return this.principalAmount_; 
                }
                else
                {
                      return this.principalAmount_; 
                }
            }
            set
            {
                if (this.principalAmount_ != value)
                {
                    this.principalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string principalAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradePrincipal : ISerialized
    {
        public InstrumentTradePrincipal(XmlNode xmlNode)
        {
            XmlNode principalAmountNode = xmlNode.SelectSingleNode("principalAmount");
            
            if (principalAmountNode != null)
            {
                if (principalAmountNode.Attributes["href"] != null || principalAmountNode.Attributes["id"] != null) 
                {
                    if (principalAmountNode.Attributes["id"] != null) 
                    {
                        principalAmountIDRef_ = principalAmountNode.Attributes["id"].Value;
                        NetAndGross ob = new NetAndGross(principalAmountNode);
                        IDManager.SetID(principalAmountIDRef_, ob);
                    }
                    else if (principalAmountNode.Attributes["href"] != null)
                    {
                        principalAmountIDRef_ = principalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalAmount_ = new NetAndGross(principalAmountNode);
                    }
                }
                else
                {
                    principalAmount_ = new NetAndGross(principalAmountNode);
                }
            }
            
        
        }
        
    
        #region PrincipalAmount_
        private NetAndGross principalAmount_;
        public NetAndGross PrincipalAmount_
        {
            get
            {
                if (this.principalAmount_ != null)
                {
                    return this.principalAmount_; 
                }
                else if (this.principalAmountIDRef_ != null)
                {
                    principalAmount_ = IDManager.getID(principalAmountIDRef_) as NetAndGross;
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
        
    
        
    
    }
    
}


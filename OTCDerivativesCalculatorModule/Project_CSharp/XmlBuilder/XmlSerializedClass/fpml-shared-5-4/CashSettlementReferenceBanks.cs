using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashSettlementReferenceBanks : ISerialized
    {
        public CashSettlementReferenceBanks(XmlNode xmlNode)
        {
            XmlNodeList referenceBankNodeList = xmlNode.SelectNodes("referenceBank");
            
            if (referenceBankNodeList != null)
            {
                this.referenceBank_ = new List<ReferenceBank>();
                foreach (XmlNode item in referenceBankNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceBankIDRef_ = item.Attributes["id"].Value;
                            referenceBank_.Add(new ReferenceBank(item));
                            IDManager.SetID(referenceBankIDRef_, referenceBank_[referenceBank_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceBankIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceBank_.Add(new ReferenceBank(item));
                        }
                    }
                    else
                    {
                        referenceBank_.Add(new ReferenceBank(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceBank_
        private List<ReferenceBank> referenceBank_;
        public List<ReferenceBank> ReferenceBank_
        {
            get
            {
                if (this.referenceBank_ != null)
                {
                    return this.referenceBank_; 
                }
                else if (this.referenceBankIDRef_ != null)
                {
                    return this.referenceBank_; 
                }
                else
                {
                      return this.referenceBank_; 
                }
            }
            set
            {
                if (this.referenceBank_ != value)
                {
                    this.referenceBank_ = value;
                }
            }
        }
        #endregion
        
        public string referenceBankIDRef_ { get; set; }
        
    
        
    
    }
    
}


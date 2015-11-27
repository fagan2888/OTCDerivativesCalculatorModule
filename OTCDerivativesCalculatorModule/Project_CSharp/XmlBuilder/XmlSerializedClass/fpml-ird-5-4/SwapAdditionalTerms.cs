using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwapAdditionalTerms : ISerialized
    {
        public SwapAdditionalTerms(XmlNode xmlNode)
        {
            XmlNode bondReferenceNode = xmlNode.SelectSingleNode("bondReference");
            
            if (bondReferenceNode != null)
            {
                if (bondReferenceNode.Attributes["href"] != null || bondReferenceNode.Attributes["id"] != null) 
                {
                    if (bondReferenceNode.Attributes["id"] != null) 
                    {
                        bondReferenceIDRef_ = bondReferenceNode.Attributes["id"].Value;
                        BondReference ob = new BondReference(bondReferenceNode);
                        IDManager.SetID(bondReferenceIDRef_, ob);
                    }
                    else if (bondReferenceNode.Attributes["href"] != null)
                    {
                        bondReferenceIDRef_ = bondReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bondReference_ = new BondReference(bondReferenceNode);
                    }
                }
                else
                {
                    bondReference_ = new BondReference(bondReferenceNode);
                }
            }
            
        
        }
        
    
        #region BondReference_
        private BondReference bondReference_;
        public BondReference BondReference_
        {
            get
            {
                if (this.bondReference_ != null)
                {
                    return this.bondReference_; 
                }
                else if (this.bondReferenceIDRef_ != null)
                {
                    bondReference_ = IDManager.getID(bondReferenceIDRef_) as BondReference;
                    return this.bondReference_; 
                }
                else
                {
                      return this.bondReference_; 
                }
            }
            set
            {
                if (this.bondReference_ != value)
                {
                    this.bondReference_ = value;
                }
            }
        }
        #endregion
        
        public string bondReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}


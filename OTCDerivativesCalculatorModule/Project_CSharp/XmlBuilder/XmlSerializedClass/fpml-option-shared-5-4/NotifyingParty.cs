using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NotifyingParty : ISerialized
    {
        public NotifyingParty(XmlNode xmlNode)
        {
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}


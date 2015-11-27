using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapBase : Product
    {
        public ReturnSwapBase(XmlNode xmlNode)
        : base(xmlNode)
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
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
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
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNode returnSwapLegNode = xmlNode.SelectSingleNode("returnSwapLeg");
            
            if (returnSwapLegNode != null)
            {
                if (returnSwapLegNode.Attributes["href"] != null || returnSwapLegNode.Attributes["id"] != null) 
                {
                    if (returnSwapLegNode.Attributes["id"] != null) 
                    {
                        returnSwapLegIDRef_ = returnSwapLegNode.Attributes["id"].Value;
                        DirectionalLeg ob = new DirectionalLeg(returnSwapLegNode);
                        IDManager.SetID(returnSwapLegIDRef_, ob);
                    }
                    else if (returnSwapLegNode.Attributes["href"] != null)
                    {
                        returnSwapLegIDRef_ = returnSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnSwapLeg_ = new DirectionalLeg(returnSwapLegNode);
                    }
                }
                else
                {
                    returnSwapLeg_ = new DirectionalLeg(returnSwapLegNode);
                }
            }
            
        
            XmlNode interestLegNode = xmlNode.SelectSingleNode("interestLeg");
            
            if (interestLegNode != null)
            {
                if (interestLegNode.Attributes["href"] != null || interestLegNode.Attributes["id"] != null) 
                {
                    if (interestLegNode.Attributes["id"] != null) 
                    {
                        interestLegIDRef_ = interestLegNode.Attributes["id"].Value;
                        InterestLeg ob = new InterestLeg(interestLegNode);
                        IDManager.SetID(interestLegIDRef_, ob);
                    }
                    else if (interestLegNode.Attributes["href"] != null)
                    {
                        interestLegIDRef_ = interestLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestLeg_ = new InterestLeg(interestLegNode);
                    }
                }
                else
                {
                    interestLeg_ = new InterestLeg(interestLegNode);
                }
            }
            
        
            XmlNode returnLegNode = xmlNode.SelectSingleNode("returnLeg");
            
            if (returnLegNode != null)
            {
                if (returnLegNode.Attributes["href"] != null || returnLegNode.Attributes["id"] != null) 
                {
                    if (returnLegNode.Attributes["id"] != null) 
                    {
                        returnLegIDRef_ = returnLegNode.Attributes["id"].Value;
                        ReturnLeg ob = new ReturnLeg(returnLegNode);
                        IDManager.SetID(returnLegIDRef_, ob);
                    }
                    else if (returnLegNode.Attributes["href"] != null)
                    {
                        returnLegIDRef_ = returnLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnLeg_ = new ReturnLeg(returnLegNode);
                    }
                }
                else
                {
                    returnLeg_ = new ReturnLeg(returnLegNode);
                }
            }
            
        
            XmlNode principalExchangeFeaturesNode = xmlNode.SelectSingleNode("principalExchangeFeatures");
            
            if (principalExchangeFeaturesNode != null)
            {
                if (principalExchangeFeaturesNode.Attributes["href"] != null || principalExchangeFeaturesNode.Attributes["id"] != null) 
                {
                    if (principalExchangeFeaturesNode.Attributes["id"] != null) 
                    {
                        principalExchangeFeaturesIDRef_ = principalExchangeFeaturesNode.Attributes["id"].Value;
                        PrincipalExchangeFeatures ob = new PrincipalExchangeFeatures(principalExchangeFeaturesNode);
                        IDManager.SetID(principalExchangeFeaturesIDRef_, ob);
                    }
                    else if (principalExchangeFeaturesNode.Attributes["href"] != null)
                    {
                        principalExchangeFeaturesIDRef_ = principalExchangeFeaturesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalExchangeFeatures_ = new PrincipalExchangeFeatures(principalExchangeFeaturesNode);
                    }
                }
                else
                {
                    principalExchangeFeatures_ = new PrincipalExchangeFeatures(principalExchangeFeaturesNode);
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
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
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
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region ReturnSwapLeg_
        private DirectionalLeg returnSwapLeg_;
        public DirectionalLeg ReturnSwapLeg_
        {
            get
            {
                if (this.returnSwapLeg_ != null)
                {
                    return this.returnSwapLeg_; 
                }
                else if (this.returnSwapLegIDRef_ != null)
                {
                    returnSwapLeg_ = IDManager.getID(returnSwapLegIDRef_) as DirectionalLeg;
                    return this.returnSwapLeg_; 
                }
                else
                {
                      return this.returnSwapLeg_; 
                }
            }
            set
            {
                if (this.returnSwapLeg_ != value)
                {
                    this.returnSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string returnSwapLegIDRef_ { get; set; }
        #region InterestLeg_
        private InterestLeg interestLeg_;
        public InterestLeg InterestLeg_
        {
            get
            {
                if (this.interestLeg_ != null)
                {
                    return this.interestLeg_; 
                }
                else if (this.interestLegIDRef_ != null)
                {
                    interestLeg_ = IDManager.getID(interestLegIDRef_) as InterestLeg;
                    return this.interestLeg_; 
                }
                else
                {
                      return this.interestLeg_; 
                }
            }
            set
            {
                if (this.interestLeg_ != value)
                {
                    this.interestLeg_ = value;
                }
            }
        }
        #endregion
        
        public string interestLegIDRef_ { get; set; }     // substitude
        #region ReturnLeg_
        private ReturnLeg returnLeg_;
        public ReturnLeg ReturnLeg_
        {
            get
            {
                if (this.returnLeg_ != null)
                {
                    return this.returnLeg_; 
                }
                else if (this.returnLegIDRef_ != null)
                {
                    returnLeg_ = IDManager.getID(returnLegIDRef_) as ReturnLeg;
                    return this.returnLeg_; 
                }
                else
                {
                      return this.returnLeg_; 
                }
            }
            set
            {
                if (this.returnLeg_ != value)
                {
                    this.returnLeg_ = value;
                }
            }
        }
        #endregion
        
        public string returnLegIDRef_ { get; set; }     // substitude
        #region PrincipalExchangeFeatures_
        private PrincipalExchangeFeatures principalExchangeFeatures_;
        public PrincipalExchangeFeatures PrincipalExchangeFeatures_
        {
            get
            {
                if (this.principalExchangeFeatures_ != null)
                {
                    return this.principalExchangeFeatures_; 
                }
                else if (this.principalExchangeFeaturesIDRef_ != null)
                {
                    principalExchangeFeatures_ = IDManager.getID(principalExchangeFeaturesIDRef_) as PrincipalExchangeFeatures;
                    return this.principalExchangeFeatures_; 
                }
                else
                {
                      return this.principalExchangeFeatures_; 
                }
            }
            set
            {
                if (this.principalExchangeFeatures_ != value)
                {
                    this.principalExchangeFeatures_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangeFeaturesIDRef_ { get; set; }
        
    
        
    
    }
    
}


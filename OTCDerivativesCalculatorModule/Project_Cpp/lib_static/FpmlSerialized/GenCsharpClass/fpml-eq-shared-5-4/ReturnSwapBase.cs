using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapBase
    {
        public ReturnSwapBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList buyerPartyReferenceNodeList = xmlNode.SelectNodes("buyerPartyReference");
            if (buyerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(buyerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList buyerAccountReferenceNodeList = xmlNode.SelectNodes("buyerAccountReference");
            if (buyerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(buyerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerPartyReferenceNodeList = xmlNode.SelectNodes("sellerPartyReference");
            if (sellerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(sellerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerAccountReferenceNodeList = xmlNode.SelectNodes("sellerAccountReference");
            if (sellerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(sellerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList returnSwapLegNodeList = xmlNode.SelectNodes("returnSwapLeg");
            if (returnSwapLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnSwapLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnSwapLegIDRef = item.Attributes["id"].Name;
                        DirectionalLeg ob = DirectionalLeg();
                        IDManager.SetID(returnSwapLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnSwapLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        returnSwapLeg = new DirectionalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList interestLegNodeList = xmlNode.SelectNodes("interestLeg");
            if (interestLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestLegIDRef = item.Attributes["id"].Name;
                        InterestLeg ob = InterestLeg();
                        IDManager.SetID(interestLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestLeg = new InterestLeg(item);
                    }
                }
            }
            
        
            XmlNodeList returnLegNodeList = xmlNode.SelectNodes("returnLeg");
            if (returnLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnLegIDRef = item.Attributes["id"].Name;
                        ReturnLeg ob = ReturnLeg();
                        IDManager.SetID(returnLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        returnLeg = new ReturnLeg(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangeFeaturesNodeList = xmlNode.SelectNodes("principalExchangeFeatures");
            if (principalExchangeFeaturesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalExchangeFeaturesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangeFeaturesIDRef = item.Attributes["id"].Name;
                        PrincipalExchangeFeatures ob = PrincipalExchangeFeatures();
                        IDManager.SetID(principalExchangeFeaturesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangeFeaturesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalExchangeFeatures = new PrincipalExchangeFeatures(item);
                    }
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference
        private PartyReference buyerPartyReference;
        public PartyReference BuyerPartyReference
        {
            get
            {
                if (this.buyerPartyReference != null)
                {
                    return this.buyerPartyReference; 
                }
                else if (this.buyerPartyReferenceIDRef != null)
                {
                    buyerPartyReference = IDManager.getID(buyerPartyReferenceIDRef) as PartyReference;
                    return this.buyerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerPartyReference != value)
                {
                    this.buyerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BuyerAccountReference
        private AccountReference buyerAccountReference;
        public AccountReference BuyerAccountReference
        {
            get
            {
                if (this.buyerAccountReference != null)
                {
                    return this.buyerAccountReference; 
                }
                else if (this.buyerAccountReferenceIDRef != null)
                {
                    buyerAccountReference = IDManager.getID(buyerAccountReferenceIDRef) as AccountReference;
                    return this.buyerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerAccountReference != value)
                {
                    this.buyerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region SellerPartyReference
        private PartyReference sellerPartyReference;
        public PartyReference SellerPartyReference
        {
            get
            {
                if (this.sellerPartyReference != null)
                {
                    return this.sellerPartyReference; 
                }
                else if (this.sellerPartyReferenceIDRef != null)
                {
                    sellerPartyReference = IDManager.getID(sellerPartyReferenceIDRef) as PartyReference;
                    return this.sellerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerPartyReference != value)
                {
                    this.sellerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SellerAccountReference
        private AccountReference sellerAccountReference;
        public AccountReference SellerAccountReference
        {
            get
            {
                if (this.sellerAccountReference != null)
                {
                    return this.sellerAccountReference; 
                }
                else if (this.sellerAccountReferenceIDRef != null)
                {
                    sellerAccountReference = IDManager.getID(sellerAccountReferenceIDRef) as AccountReference;
                    return this.sellerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerAccountReference != value)
                {
                    this.sellerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region ReturnSwapLeg
        private DirectionalLeg returnSwapLeg;
        public DirectionalLeg ReturnSwapLeg
        {
            get
            {
                if (this.returnSwapLeg != null)
                {
                    return this.returnSwapLeg; 
                }
                else if (this.returnSwapLegIDRef != null)
                {
                    returnSwapLeg = IDManager.getID(returnSwapLegIDRef) as DirectionalLeg;
                    return this.returnSwapLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.returnSwapLeg != value)
                {
                    this.returnSwapLeg = value;
                }
            }
        }
        #endregion
        
        public string DirectionalLegIDRef { get; set; }
        #region InterestLeg
        private InterestLeg interestLeg;
        public InterestLeg InterestLeg
        {
            get
            {
                if (this.interestLeg != null)
                {
                    return this.interestLeg; 
                }
                else if (this.interestLegIDRef != null)
                {
                    interestLeg = IDManager.getID(interestLegIDRef) as InterestLeg;
                    return this.interestLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestLeg != value)
                {
                    this.interestLeg = value;
                }
            }
        }
        #endregion
        
        public string InterestLegIDRef { get; set; }     // substitude
        #region ReturnLeg
        private ReturnLeg returnLeg;
        public ReturnLeg ReturnLeg
        {
            get
            {
                if (this.returnLeg != null)
                {
                    return this.returnLeg; 
                }
                else if (this.returnLegIDRef != null)
                {
                    returnLeg = IDManager.getID(returnLegIDRef) as ReturnLeg;
                    return this.returnLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.returnLeg != value)
                {
                    this.returnLeg = value;
                }
            }
        }
        #endregion
        
        public string ReturnLegIDRef { get; set; }     // substitude
        #region PrincipalExchangeFeatures
        private PrincipalExchangeFeatures principalExchangeFeatures;
        public PrincipalExchangeFeatures PrincipalExchangeFeatures
        {
            get
            {
                if (this.principalExchangeFeatures != null)
                {
                    return this.principalExchangeFeatures; 
                }
                else if (this.principalExchangeFeaturesIDRef != null)
                {
                    principalExchangeFeatures = IDManager.getID(principalExchangeFeaturesIDRef) as PrincipalExchangeFeatures;
                    return this.principalExchangeFeatures; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchangeFeatures != value)
                {
                    this.principalExchangeFeatures = value;
                }
            }
        }
        #endregion
        
        public string PrincipalExchangeFeaturesIDRef { get; set; }
        
    
        
    
    }
    
}


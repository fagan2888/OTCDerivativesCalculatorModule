using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Strike
    {
        public Strike(XmlNode xmlNode)
        {
            XmlNodeList strikeRateNodeList = xmlNode.SelectNodes("strikeRate");
            if (strikeRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikeRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList buyerNodeList = xmlNode.SelectNodes("buyer");
            if (buyerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerIDRef = item.Attributes["id"].Name;
                        IdentifiedPayerReceiver ob = IdentifiedPayerReceiver();
                        IDManager.SetID(buyerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyer = new IdentifiedPayerReceiver(item);
                    }
                }
            }
            
        
            XmlNodeList sellerNodeList = xmlNode.SelectNodes("seller");
            if (sellerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerIDRef = item.Attributes["id"].Name;
                        IdentifiedPayerReceiver ob = IdentifiedPayerReceiver();
                        IDManager.SetID(sellerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        seller = new IdentifiedPayerReceiver(item);
                    }
                }
            }
            
        
        }
        
    
        #region StrikeRate
        private XsdTypeDecimal strikeRate;
        public XsdTypeDecimal StrikeRate
        {
            get
            {
                if (this.strikeRate != null)
                {
                    return this.strikeRate; 
                }
                else if (this.strikeRateIDRef != null)
                {
                    strikeRate = IDManager.getID(strikeRateIDRef) as XsdTypeDecimal;
                    return this.strikeRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeRate != value)
                {
                    this.strikeRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Buyer
        private IdentifiedPayerReceiver buyer;
        public IdentifiedPayerReceiver Buyer
        {
            get
            {
                if (this.buyer != null)
                {
                    return this.buyer; 
                }
                else if (this.buyerIDRef != null)
                {
                    buyer = IDManager.getID(buyerIDRef) as IdentifiedPayerReceiver;
                    return this.buyer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyer != value)
                {
                    this.buyer = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedPayerReceiverIDRef { get; set; }
        #region Seller
        private IdentifiedPayerReceiver seller;
        public IdentifiedPayerReceiver Seller
        {
            get
            {
                if (this.seller != null)
                {
                    return this.seller; 
                }
                else if (this.sellerIDRef != null)
                {
                    seller = IDManager.getID(sellerIDRef) as IdentifiedPayerReceiver;
                    return this.seller; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.seller != value)
                {
                    this.seller = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedPayerReceiverIDRef { get; set; }
        
    
        
    
    }
    
}


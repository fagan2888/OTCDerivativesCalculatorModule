using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GasDelivery
    {
        public GasDelivery(XmlNode xmlNode)
        {
            XmlNodeList deliveryPointNodeList = xmlNode.SelectNodes("deliveryPoint");
            if (deliveryPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryPointIDRef = item.Attributes["id"].Name;
                        GasDeliveryPoint ob = GasDeliveryPoint();
                        IDManager.SetID(deliveryPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPoint = new GasDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList entryPointNodeList = xmlNode.SelectNodes("entryPoint");
            if (entryPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in entryPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        entryPointIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(entryPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        entryPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        entryPoint = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList withdrawalPointNodeList = xmlNode.SelectNodes("withdrawalPoint");
            if (withdrawalPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in withdrawalPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        withdrawalPointIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(withdrawalPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        withdrawalPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        withdrawalPoint = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryTypeNodeList = xmlNode.SelectNodes("deliveryType");
            if (deliveryTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryTypeIDRef = item.Attributes["id"].Name;
                        DeliveryTypeEnum ob = DeliveryTypeEnum();
                        IDManager.SetID(deliveryTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryType = new DeliveryTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList buyerHubNodeList = xmlNode.SelectNodes("buyerHub");
            if (buyerHubNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerHubNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerHubIDRef = item.Attributes["id"].Name;
                        CommodityHub ob = CommodityHub();
                        IDManager.SetID(buyerHubIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerHubIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerHub = new CommodityHub(item);
                    }
                }
            }
            
        
            XmlNodeList sellerHubNodeList = xmlNode.SelectNodes("sellerHub");
            if (sellerHubNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerHubNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerHubIDRef = item.Attributes["id"].Name;
                        CommodityHub ob = CommodityHub();
                        IDManager.SetID(sellerHubIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerHubIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerHub = new CommodityHub(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeliveryPoint
        private GasDeliveryPoint deliveryPoint;
        public GasDeliveryPoint DeliveryPoint
        {
            get
            {
                if (this.deliveryPoint != null)
                {
                    return this.deliveryPoint; 
                }
                else if (this.deliveryPointIDRef != null)
                {
                    deliveryPoint = IDManager.getID(deliveryPointIDRef) as GasDeliveryPoint;
                    return this.deliveryPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryPoint != value)
                {
                    this.deliveryPoint = value;
                }
            }
        }
        #endregion
        
        public string GasDeliveryPointIDRef { get; set; }
        #region EntryPoint
        private CommodityDeliveryPoint entryPoint;
        public CommodityDeliveryPoint EntryPoint
        {
            get
            {
                if (this.entryPoint != null)
                {
                    return this.entryPoint; 
                }
                else if (this.entryPointIDRef != null)
                {
                    entryPoint = IDManager.getID(entryPointIDRef) as CommodityDeliveryPoint;
                    return this.entryPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.entryPoint != value)
                {
                    this.entryPoint = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        #region WithdrawalPoint
        private CommodityDeliveryPoint withdrawalPoint;
        public CommodityDeliveryPoint WithdrawalPoint
        {
            get
            {
                if (this.withdrawalPoint != null)
                {
                    return this.withdrawalPoint; 
                }
                else if (this.withdrawalPointIDRef != null)
                {
                    withdrawalPoint = IDManager.getID(withdrawalPointIDRef) as CommodityDeliveryPoint;
                    return this.withdrawalPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.withdrawalPoint != value)
                {
                    this.withdrawalPoint = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        #region DeliveryType
        private DeliveryTypeEnum deliveryType;
        public DeliveryTypeEnum DeliveryType
        {
            get
            {
                if (this.deliveryType != null)
                {
                    return this.deliveryType; 
                }
                else if (this.deliveryTypeIDRef != null)
                {
                    deliveryType = IDManager.getID(deliveryTypeIDRef) as DeliveryTypeEnum;
                    return this.deliveryType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryType != value)
                {
                    this.deliveryType = value;
                }
            }
        }
        #endregion
        
        public string DeliveryTypeEnumIDRef { get; set; }
        #region BuyerHub
        private CommodityHub buyerHub;
        public CommodityHub BuyerHub
        {
            get
            {
                if (this.buyerHub != null)
                {
                    return this.buyerHub; 
                }
                else if (this.buyerHubIDRef != null)
                {
                    buyerHub = IDManager.getID(buyerHubIDRef) as CommodityHub;
                    return this.buyerHub; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerHub != value)
                {
                    this.buyerHub = value;
                }
            }
        }
        #endregion
        
        public string CommodityHubIDRef { get; set; }
        #region SellerHub
        private CommodityHub sellerHub;
        public CommodityHub SellerHub
        {
            get
            {
                if (this.sellerHub != null)
                {
                    return this.sellerHub; 
                }
                else if (this.sellerHubIDRef != null)
                {
                    sellerHub = IDManager.getID(sellerHubIDRef) as CommodityHub;
                    return this.sellerHub; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerHub != value)
                {
                    this.sellerHub = value;
                }
            }
        }
        #endregion
        
        public string CommodityHubIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


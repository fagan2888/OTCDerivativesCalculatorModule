using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GasDelivery : ISerialized
    {
        public GasDelivery(XmlNode xmlNode)
        {
            XmlNode deliveryPointNode = xmlNode.SelectSingleNode("deliveryPoint");
            
            if (deliveryPointNode != null)
            {
                if (deliveryPointNode.Attributes["href"] != null || deliveryPointNode.Attributes["id"] != null) 
                {
                    if (deliveryPointNode.Attributes["id"] != null) 
                    {
                        deliveryPointIDRef_ = deliveryPointNode.Attributes["id"].Value;
                        GasDeliveryPoint ob = new GasDeliveryPoint(deliveryPointNode);
                        IDManager.SetID(deliveryPointIDRef_, ob);
                    }
                    else if (deliveryPointNode.Attributes["href"] != null)
                    {
                        deliveryPointIDRef_ = deliveryPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPoint_ = new GasDeliveryPoint(deliveryPointNode);
                    }
                }
                else
                {
                    deliveryPoint_ = new GasDeliveryPoint(deliveryPointNode);
                }
            }
            
        
            XmlNode entryPointNode = xmlNode.SelectSingleNode("entryPoint");
            
            if (entryPointNode != null)
            {
                if (entryPointNode.Attributes["href"] != null || entryPointNode.Attributes["id"] != null) 
                {
                    if (entryPointNode.Attributes["id"] != null) 
                    {
                        entryPointIDRef_ = entryPointNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(entryPointNode);
                        IDManager.SetID(entryPointIDRef_, ob);
                    }
                    else if (entryPointNode.Attributes["href"] != null)
                    {
                        entryPointIDRef_ = entryPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entryPoint_ = new CommodityDeliveryPoint(entryPointNode);
                    }
                }
                else
                {
                    entryPoint_ = new CommodityDeliveryPoint(entryPointNode);
                }
            }
            
        
            XmlNode withdrawalPointNode = xmlNode.SelectSingleNode("withdrawalPoint");
            
            if (withdrawalPointNode != null)
            {
                if (withdrawalPointNode.Attributes["href"] != null || withdrawalPointNode.Attributes["id"] != null) 
                {
                    if (withdrawalPointNode.Attributes["id"] != null) 
                    {
                        withdrawalPointIDRef_ = withdrawalPointNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(withdrawalPointNode);
                        IDManager.SetID(withdrawalPointIDRef_, ob);
                    }
                    else if (withdrawalPointNode.Attributes["href"] != null)
                    {
                        withdrawalPointIDRef_ = withdrawalPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        withdrawalPoint_ = new CommodityDeliveryPoint(withdrawalPointNode);
                    }
                }
                else
                {
                    withdrawalPoint_ = new CommodityDeliveryPoint(withdrawalPointNode);
                }
            }
            
        
            XmlNode deliveryTypeNode = xmlNode.SelectSingleNode("deliveryType");
            
            if (deliveryTypeNode != null)
            {
                if (deliveryTypeNode.Attributes["href"] != null || deliveryTypeNode.Attributes["id"] != null) 
                {
                    if (deliveryTypeNode.Attributes["id"] != null) 
                    {
                        deliveryTypeIDRef_ = deliveryTypeNode.Attributes["id"].Value;
                        DeliveryTypeEnum ob = new DeliveryTypeEnum(deliveryTypeNode);
                        IDManager.SetID(deliveryTypeIDRef_, ob);
                    }
                    else if (deliveryTypeNode.Attributes["href"] != null)
                    {
                        deliveryTypeIDRef_ = deliveryTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryType_ = new DeliveryTypeEnum(deliveryTypeNode);
                    }
                }
                else
                {
                    deliveryType_ = new DeliveryTypeEnum(deliveryTypeNode);
                }
            }
            
        
            XmlNode buyerHubNode = xmlNode.SelectSingleNode("buyerHub");
            
            if (buyerHubNode != null)
            {
                if (buyerHubNode.Attributes["href"] != null || buyerHubNode.Attributes["id"] != null) 
                {
                    if (buyerHubNode.Attributes["id"] != null) 
                    {
                        buyerHubIDRef_ = buyerHubNode.Attributes["id"].Value;
                        CommodityHub ob = new CommodityHub(buyerHubNode);
                        IDManager.SetID(buyerHubIDRef_, ob);
                    }
                    else if (buyerHubNode.Attributes["href"] != null)
                    {
                        buyerHubIDRef_ = buyerHubNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerHub_ = new CommodityHub(buyerHubNode);
                    }
                }
                else
                {
                    buyerHub_ = new CommodityHub(buyerHubNode);
                }
            }
            
        
            XmlNode sellerHubNode = xmlNode.SelectSingleNode("sellerHub");
            
            if (sellerHubNode != null)
            {
                if (sellerHubNode.Attributes["href"] != null || sellerHubNode.Attributes["id"] != null) 
                {
                    if (sellerHubNode.Attributes["id"] != null) 
                    {
                        sellerHubIDRef_ = sellerHubNode.Attributes["id"].Value;
                        CommodityHub ob = new CommodityHub(sellerHubNode);
                        IDManager.SetID(sellerHubIDRef_, ob);
                    }
                    else if (sellerHubNode.Attributes["href"] != null)
                    {
                        sellerHubIDRef_ = sellerHubNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerHub_ = new CommodityHub(sellerHubNode);
                    }
                }
                else
                {
                    sellerHub_ = new CommodityHub(sellerHubNode);
                }
            }
            
        
        }
        
    
        #region DeliveryPoint_
        private GasDeliveryPoint deliveryPoint_;
        public GasDeliveryPoint DeliveryPoint_
        {
            get
            {
                if (this.deliveryPoint_ != null)
                {
                    return this.deliveryPoint_; 
                }
                else if (this.deliveryPointIDRef_ != null)
                {
                    deliveryPoint_ = IDManager.getID(deliveryPointIDRef_) as GasDeliveryPoint;
                    return this.deliveryPoint_; 
                }
                else
                {
                      return this.deliveryPoint_; 
                }
            }
            set
            {
                if (this.deliveryPoint_ != value)
                {
                    this.deliveryPoint_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryPointIDRef_ { get; set; }
        #region EntryPoint_
        private CommodityDeliveryPoint entryPoint_;
        public CommodityDeliveryPoint EntryPoint_
        {
            get
            {
                if (this.entryPoint_ != null)
                {
                    return this.entryPoint_; 
                }
                else if (this.entryPointIDRef_ != null)
                {
                    entryPoint_ = IDManager.getID(entryPointIDRef_) as CommodityDeliveryPoint;
                    return this.entryPoint_; 
                }
                else
                {
                      return this.entryPoint_; 
                }
            }
            set
            {
                if (this.entryPoint_ != value)
                {
                    this.entryPoint_ = value;
                }
            }
        }
        #endregion
        
        public string entryPointIDRef_ { get; set; }
        #region WithdrawalPoint_
        private CommodityDeliveryPoint withdrawalPoint_;
        public CommodityDeliveryPoint WithdrawalPoint_
        {
            get
            {
                if (this.withdrawalPoint_ != null)
                {
                    return this.withdrawalPoint_; 
                }
                else if (this.withdrawalPointIDRef_ != null)
                {
                    withdrawalPoint_ = IDManager.getID(withdrawalPointIDRef_) as CommodityDeliveryPoint;
                    return this.withdrawalPoint_; 
                }
                else
                {
                      return this.withdrawalPoint_; 
                }
            }
            set
            {
                if (this.withdrawalPoint_ != value)
                {
                    this.withdrawalPoint_ = value;
                }
            }
        }
        #endregion
        
        public string withdrawalPointIDRef_ { get; set; }
        #region DeliveryType_
        private DeliveryTypeEnum deliveryType_;
        public DeliveryTypeEnum DeliveryType_
        {
            get
            {
                if (this.deliveryType_ != null)
                {
                    return this.deliveryType_; 
                }
                else if (this.deliveryTypeIDRef_ != null)
                {
                    deliveryType_ = IDManager.getID(deliveryTypeIDRef_) as DeliveryTypeEnum;
                    return this.deliveryType_; 
                }
                else
                {
                      return this.deliveryType_; 
                }
            }
            set
            {
                if (this.deliveryType_ != value)
                {
                    this.deliveryType_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryTypeIDRef_ { get; set; }
        #region BuyerHub_
        private CommodityHub buyerHub_;
        public CommodityHub BuyerHub_
        {
            get
            {
                if (this.buyerHub_ != null)
                {
                    return this.buyerHub_; 
                }
                else if (this.buyerHubIDRef_ != null)
                {
                    buyerHub_ = IDManager.getID(buyerHubIDRef_) as CommodityHub;
                    return this.buyerHub_; 
                }
                else
                {
                      return this.buyerHub_; 
                }
            }
            set
            {
                if (this.buyerHub_ != value)
                {
                    this.buyerHub_ = value;
                }
            }
        }
        #endregion
        
        public string buyerHubIDRef_ { get; set; }
        #region SellerHub_
        private CommodityHub sellerHub_;
        public CommodityHub SellerHub_
        {
            get
            {
                if (this.sellerHub_ != null)
                {
                    return this.sellerHub_; 
                }
                else if (this.sellerHubIDRef_ != null)
                {
                    sellerHub_ = IDManager.getID(sellerHubIDRef_) as CommodityHub;
                    return this.sellerHub_; 
                }
                else
                {
                      return this.sellerHub_; 
                }
            }
            set
            {
                if (this.sellerHub_ != value)
                {
                    this.sellerHub_ = value;
                }
            }
        }
        #endregion
        
        public string sellerHubIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


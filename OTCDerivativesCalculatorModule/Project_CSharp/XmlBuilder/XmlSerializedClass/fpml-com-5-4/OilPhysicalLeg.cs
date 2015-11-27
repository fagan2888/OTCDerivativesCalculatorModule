using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OilPhysicalLeg : PhysicalSwapLeg
    {
        public OilPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode deliveryPeriodsNode = xmlNode.SelectSingleNode("deliveryPeriods");
            
            if (deliveryPeriodsNode != null)
            {
                if (deliveryPeriodsNode.Attributes["href"] != null || deliveryPeriodsNode.Attributes["id"] != null) 
                {
                    if (deliveryPeriodsNode.Attributes["id"] != null) 
                    {
                        deliveryPeriodsIDRef_ = deliveryPeriodsNode.Attributes["id"].Value;
                        CommodityDeliveryPeriods ob = new CommodityDeliveryPeriods(deliveryPeriodsNode);
                        IDManager.SetID(deliveryPeriodsIDRef_, ob);
                    }
                    else if (deliveryPeriodsNode.Attributes["href"] != null)
                    {
                        deliveryPeriodsIDRef_ = deliveryPeriodsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPeriods_ = new CommodityDeliveryPeriods(deliveryPeriodsNode);
                    }
                }
                else
                {
                    deliveryPeriods_ = new CommodityDeliveryPeriods(deliveryPeriodsNode);
                }
            }
            
        
            XmlNode oilNode = xmlNode.SelectSingleNode("oil");
            
            if (oilNode != null)
            {
                if (oilNode.Attributes["href"] != null || oilNode.Attributes["id"] != null) 
                {
                    if (oilNode.Attributes["id"] != null) 
                    {
                        oilIDRef_ = oilNode.Attributes["id"].Value;
                        OilProduct ob = new OilProduct(oilNode);
                        IDManager.SetID(oilIDRef_, ob);
                    }
                    else if (oilNode.Attributes["href"] != null)
                    {
                        oilIDRef_ = oilNode.Attributes["href"].Value;
                    }
                    else
                    {
                        oil_ = new OilProduct(oilNode);
                    }
                }
                else
                {
                    oil_ = new OilProduct(oilNode);
                }
            }
            
        
            XmlNode deliveryConditionsNode = xmlNode.SelectSingleNode("deliveryConditions");
            
            if (deliveryConditionsNode != null)
            {
                if (deliveryConditionsNode.Attributes["href"] != null || deliveryConditionsNode.Attributes["id"] != null) 
                {
                    if (deliveryConditionsNode.Attributes["id"] != null) 
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["id"].Value;
                        OilDelivery ob = new OilDelivery(deliveryConditionsNode);
                        IDManager.SetID(deliveryConditionsIDRef_, ob);
                    }
                    else if (deliveryConditionsNode.Attributes["href"] != null)
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryConditions_ = new OilDelivery(deliveryConditionsNode);
                    }
                }
                else
                {
                    deliveryConditions_ = new OilDelivery(deliveryConditionsNode);
                }
            }
            
        
            XmlNode deliveryQuantityNode = xmlNode.SelectSingleNode("deliveryQuantity");
            
            if (deliveryQuantityNode != null)
            {
                if (deliveryQuantityNode.Attributes["href"] != null || deliveryQuantityNode.Attributes["id"] != null) 
                {
                    if (deliveryQuantityNode.Attributes["id"] != null) 
                    {
                        deliveryQuantityIDRef_ = deliveryQuantityNode.Attributes["id"].Value;
                        CommodityPhysicalQuantity ob = new CommodityPhysicalQuantity(deliveryQuantityNode);
                        IDManager.SetID(deliveryQuantityIDRef_, ob);
                    }
                    else if (deliveryQuantityNode.Attributes["href"] != null)
                    {
                        deliveryQuantityIDRef_ = deliveryQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryQuantity_ = new CommodityPhysicalQuantity(deliveryQuantityNode);
                    }
                }
                else
                {
                    deliveryQuantity_ = new CommodityPhysicalQuantity(deliveryQuantityNode);
                }
            }
            
        
        }
        
    
        #region DeliveryPeriods_
        private CommodityDeliveryPeriods deliveryPeriods_;
        public CommodityDeliveryPeriods DeliveryPeriods_
        {
            get
            {
                if (this.deliveryPeriods_ != null)
                {
                    return this.deliveryPeriods_; 
                }
                else if (this.deliveryPeriodsIDRef_ != null)
                {
                    deliveryPeriods_ = IDManager.getID(deliveryPeriodsIDRef_) as CommodityDeliveryPeriods;
                    return this.deliveryPeriods_; 
                }
                else
                {
                      return this.deliveryPeriods_; 
                }
            }
            set
            {
                if (this.deliveryPeriods_ != value)
                {
                    this.deliveryPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryPeriodsIDRef_ { get; set; }
        #region Oil_
        private OilProduct oil_;
        public OilProduct Oil_
        {
            get
            {
                if (this.oil_ != null)
                {
                    return this.oil_; 
                }
                else if (this.oilIDRef_ != null)
                {
                    oil_ = IDManager.getID(oilIDRef_) as OilProduct;
                    return this.oil_; 
                }
                else
                {
                      return this.oil_; 
                }
            }
            set
            {
                if (this.oil_ != value)
                {
                    this.oil_ = value;
                }
            }
        }
        #endregion
        
        public string oilIDRef_ { get; set; }
        #region DeliveryConditions_
        private OilDelivery deliveryConditions_;
        public OilDelivery DeliveryConditions_
        {
            get
            {
                if (this.deliveryConditions_ != null)
                {
                    return this.deliveryConditions_; 
                }
                else if (this.deliveryConditionsIDRef_ != null)
                {
                    deliveryConditions_ = IDManager.getID(deliveryConditionsIDRef_) as OilDelivery;
                    return this.deliveryConditions_; 
                }
                else
                {
                      return this.deliveryConditions_; 
                }
            }
            set
            {
                if (this.deliveryConditions_ != value)
                {
                    this.deliveryConditions_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryConditionsIDRef_ { get; set; }
        #region DeliveryQuantity_
        private CommodityPhysicalQuantity deliveryQuantity_;
        public CommodityPhysicalQuantity DeliveryQuantity_
        {
            get
            {
                if (this.deliveryQuantity_ != null)
                {
                    return this.deliveryQuantity_; 
                }
                else if (this.deliveryQuantityIDRef_ != null)
                {
                    deliveryQuantity_ = IDManager.getID(deliveryQuantityIDRef_) as CommodityPhysicalQuantity;
                    return this.deliveryQuantity_; 
                }
                else
                {
                      return this.deliveryQuantity_; 
                }
            }
            set
            {
                if (this.deliveryQuantity_ != value)
                {
                    this.deliveryQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryQuantityIDRef_ { get; set; }
        
    
        
    
    }
    
}


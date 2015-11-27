using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalPhysicalLeg : PhysicalSwapLeg
    {
        public CoalPhysicalLeg(XmlNode xmlNode)
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
            
        
            XmlNode coalNode = xmlNode.SelectSingleNode("coal");
            
            if (coalNode != null)
            {
                if (coalNode.Attributes["href"] != null || coalNode.Attributes["id"] != null) 
                {
                    if (coalNode.Attributes["id"] != null) 
                    {
                        coalIDRef_ = coalNode.Attributes["id"].Value;
                        CoalProduct ob = new CoalProduct(coalNode);
                        IDManager.SetID(coalIDRef_, ob);
                    }
                    else if (coalNode.Attributes["href"] != null)
                    {
                        coalIDRef_ = coalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coal_ = new CoalProduct(coalNode);
                    }
                }
                else
                {
                    coal_ = new CoalProduct(coalNode);
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
                        CoalDelivery ob = new CoalDelivery(deliveryConditionsNode);
                        IDManager.SetID(deliveryConditionsIDRef_, ob);
                    }
                    else if (deliveryConditionsNode.Attributes["href"] != null)
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryConditions_ = new CoalDelivery(deliveryConditionsNode);
                    }
                }
                else
                {
                    deliveryConditions_ = new CoalDelivery(deliveryConditionsNode);
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
        #region Coal_
        private CoalProduct coal_;
        public CoalProduct Coal_
        {
            get
            {
                if (this.coal_ != null)
                {
                    return this.coal_; 
                }
                else if (this.coalIDRef_ != null)
                {
                    coal_ = IDManager.getID(coalIDRef_) as CoalProduct;
                    return this.coal_; 
                }
                else
                {
                      return this.coal_; 
                }
            }
            set
            {
                if (this.coal_ != value)
                {
                    this.coal_ = value;
                }
            }
        }
        #endregion
        
        public string coalIDRef_ { get; set; }
        #region DeliveryConditions_
        private CoalDelivery deliveryConditions_;
        public CoalDelivery DeliveryConditions_
        {
            get
            {
                if (this.deliveryConditions_ != null)
                {
                    return this.deliveryConditions_; 
                }
                else if (this.deliveryConditionsIDRef_ != null)
                {
                    deliveryConditions_ = IDManager.getID(deliveryConditionsIDRef_) as CoalDelivery;
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


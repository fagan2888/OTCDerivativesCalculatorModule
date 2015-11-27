using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GasPhysicalLeg : PhysicalSwapLeg
    {
        public GasPhysicalLeg(XmlNode xmlNode)
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
                        GasDeliveryPeriods ob = new GasDeliveryPeriods(deliveryPeriodsNode);
                        IDManager.SetID(deliveryPeriodsIDRef_, ob);
                    }
                    else if (deliveryPeriodsNode.Attributes["href"] != null)
                    {
                        deliveryPeriodsIDRef_ = deliveryPeriodsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPeriods_ = new GasDeliveryPeriods(deliveryPeriodsNode);
                    }
                }
                else
                {
                    deliveryPeriods_ = new GasDeliveryPeriods(deliveryPeriodsNode);
                }
            }
            
        
            XmlNode gasNode = xmlNode.SelectSingleNode("gas");
            
            if (gasNode != null)
            {
                if (gasNode.Attributes["href"] != null || gasNode.Attributes["id"] != null) 
                {
                    if (gasNode.Attributes["id"] != null) 
                    {
                        gasIDRef_ = gasNode.Attributes["id"].Value;
                        GasProduct ob = new GasProduct(gasNode);
                        IDManager.SetID(gasIDRef_, ob);
                    }
                    else if (gasNode.Attributes["href"] != null)
                    {
                        gasIDRef_ = gasNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gas_ = new GasProduct(gasNode);
                    }
                }
                else
                {
                    gas_ = new GasProduct(gasNode);
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
                        GasDelivery ob = new GasDelivery(deliveryConditionsNode);
                        IDManager.SetID(deliveryConditionsIDRef_, ob);
                    }
                    else if (deliveryConditionsNode.Attributes["href"] != null)
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryConditions_ = new GasDelivery(deliveryConditionsNode);
                    }
                }
                else
                {
                    deliveryConditions_ = new GasDelivery(deliveryConditionsNode);
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
                        GasPhysicalQuantity ob = new GasPhysicalQuantity(deliveryQuantityNode);
                        IDManager.SetID(deliveryQuantityIDRef_, ob);
                    }
                    else if (deliveryQuantityNode.Attributes["href"] != null)
                    {
                        deliveryQuantityIDRef_ = deliveryQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryQuantity_ = new GasPhysicalQuantity(deliveryQuantityNode);
                    }
                }
                else
                {
                    deliveryQuantity_ = new GasPhysicalQuantity(deliveryQuantityNode);
                }
            }
            
        
        }
        
    
        #region DeliveryPeriods_
        private GasDeliveryPeriods deliveryPeriods_;
        public GasDeliveryPeriods DeliveryPeriods_
        {
            get
            {
                if (this.deliveryPeriods_ != null)
                {
                    return this.deliveryPeriods_; 
                }
                else if (this.deliveryPeriodsIDRef_ != null)
                {
                    deliveryPeriods_ = IDManager.getID(deliveryPeriodsIDRef_) as GasDeliveryPeriods;
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
        #region Gas_
        private GasProduct gas_;
        public GasProduct Gas_
        {
            get
            {
                if (this.gas_ != null)
                {
                    return this.gas_; 
                }
                else if (this.gasIDRef_ != null)
                {
                    gas_ = IDManager.getID(gasIDRef_) as GasProduct;
                    return this.gas_; 
                }
                else
                {
                      return this.gas_; 
                }
            }
            set
            {
                if (this.gas_ != value)
                {
                    this.gas_ = value;
                }
            }
        }
        #endregion
        
        public string gasIDRef_ { get; set; }
        #region DeliveryConditions_
        private GasDelivery deliveryConditions_;
        public GasDelivery DeliveryConditions_
        {
            get
            {
                if (this.deliveryConditions_ != null)
                {
                    return this.deliveryConditions_; 
                }
                else if (this.deliveryConditionsIDRef_ != null)
                {
                    deliveryConditions_ = IDManager.getID(deliveryConditionsIDRef_) as GasDelivery;
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
        private GasPhysicalQuantity deliveryQuantity_;
        public GasPhysicalQuantity DeliveryQuantity_
        {
            get
            {
                if (this.deliveryQuantity_ != null)
                {
                    return this.deliveryQuantity_; 
                }
                else if (this.deliveryQuantityIDRef_ != null)
                {
                    deliveryQuantity_ = IDManager.getID(deliveryQuantityIDRef_) as GasPhysicalQuantity;
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


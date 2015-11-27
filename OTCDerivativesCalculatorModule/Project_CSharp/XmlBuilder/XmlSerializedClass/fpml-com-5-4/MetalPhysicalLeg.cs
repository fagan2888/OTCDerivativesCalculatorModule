using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MetalPhysicalLeg : PhysicalForwardLeg
    {
        public MetalPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode metalNode = xmlNode.SelectSingleNode("metal");
            
            if (metalNode != null)
            {
                if (metalNode.Attributes["href"] != null || metalNode.Attributes["id"] != null) 
                {
                    if (metalNode.Attributes["id"] != null) 
                    {
                        metalIDRef_ = metalNode.Attributes["id"].Value;
                        Metal ob = new Metal(metalNode);
                        IDManager.SetID(metalIDRef_, ob);
                    }
                    else if (metalNode.Attributes["href"] != null)
                    {
                        metalIDRef_ = metalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        metal_ = new Metal(metalNode);
                    }
                }
                else
                {
                    metal_ = new Metal(metalNode);
                }
            }
            
        
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
            
        
            XmlNode deliveryConditionsNode = xmlNode.SelectSingleNode("deliveryConditions");
            
            if (deliveryConditionsNode != null)
            {
                if (deliveryConditionsNode.Attributes["href"] != null || deliveryConditionsNode.Attributes["id"] != null) 
                {
                    if (deliveryConditionsNode.Attributes["id"] != null) 
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["id"].Value;
                        MetalDelivery ob = new MetalDelivery(deliveryConditionsNode);
                        IDManager.SetID(deliveryConditionsIDRef_, ob);
                    }
                    else if (deliveryConditionsNode.Attributes["href"] != null)
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryConditions_ = new MetalDelivery(deliveryConditionsNode);
                    }
                }
                else
                {
                    deliveryConditions_ = new MetalDelivery(deliveryConditionsNode);
                }
            }
            
        
            XmlNode physicalQuantityNode = xmlNode.SelectSingleNode("physicalQuantity");
            
            if (physicalQuantityNode != null)
            {
                if (physicalQuantityNode.Attributes["href"] != null || physicalQuantityNode.Attributes["id"] != null) 
                {
                    if (physicalQuantityNode.Attributes["id"] != null) 
                    {
                        physicalQuantityIDRef_ = physicalQuantityNode.Attributes["id"].Value;
                        CommodityNotionalQuantity ob = new CommodityNotionalQuantity(physicalQuantityNode);
                        IDManager.SetID(physicalQuantityIDRef_, ob);
                    }
                    else if (physicalQuantityNode.Attributes["href"] != null)
                    {
                        physicalQuantityIDRef_ = physicalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalQuantity_ = new CommodityNotionalQuantity(physicalQuantityNode);
                    }
                }
                else
                {
                    physicalQuantity_ = new CommodityNotionalQuantity(physicalQuantityNode);
                }
            }
            
        
            XmlNode physicalQuantityScheduleNode = xmlNode.SelectSingleNode("physicalQuantitySchedule");
            
            if (physicalQuantityScheduleNode != null)
            {
                if (physicalQuantityScheduleNode.Attributes["href"] != null || physicalQuantityScheduleNode.Attributes["id"] != null) 
                {
                    if (physicalQuantityScheduleNode.Attributes["id"] != null) 
                    {
                        physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode.Attributes["id"].Value;
                        CommodityPhysicalQuantitySchedule ob = new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode);
                        IDManager.SetID(physicalQuantityScheduleIDRef_, ob);
                    }
                    else if (physicalQuantityScheduleNode.Attributes["href"] != null)
                    {
                        physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalQuantitySchedule_ = new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode);
                    }
                }
                else
                {
                    physicalQuantitySchedule_ = new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode);
                }
            }
            
        
            XmlNode totalPhysicalQuantityNode = xmlNode.SelectSingleNode("totalPhysicalQuantity");
            
            if (totalPhysicalQuantityNode != null)
            {
                if (totalPhysicalQuantityNode.Attributes["href"] != null || totalPhysicalQuantityNode.Attributes["id"] != null) 
                {
                    if (totalPhysicalQuantityNode.Attributes["id"] != null) 
                    {
                        totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode.Attributes["id"].Value;
                        UnitQuantity ob = new UnitQuantity(totalPhysicalQuantityNode);
                        IDManager.SetID(totalPhysicalQuantityIDRef_, ob);
                    }
                    else if (totalPhysicalQuantityNode.Attributes["href"] != null)
                    {
                        totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        totalPhysicalQuantity_ = new UnitQuantity(totalPhysicalQuantityNode);
                    }
                }
                else
                {
                    totalPhysicalQuantity_ = new UnitQuantity(totalPhysicalQuantityNode);
                }
            }
            
        
            XmlNode conversionFactorNode = xmlNode.SelectSingleNode("conversionFactor");
            
            if (conversionFactorNode != null)
            {
                if (conversionFactorNode.Attributes["href"] != null || conversionFactorNode.Attributes["id"] != null) 
                {
                    if (conversionFactorNode.Attributes["id"] != null) 
                    {
                        conversionFactorIDRef_ = conversionFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(conversionFactorNode);
                        IDManager.SetID(conversionFactorIDRef_, ob);
                    }
                    else if (conversionFactorNode.Attributes["href"] != null)
                    {
                        conversionFactorIDRef_ = conversionFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        conversionFactor_ = new XsdTypeDecimal(conversionFactorNode);
                    }
                }
                else
                {
                    conversionFactor_ = new XsdTypeDecimal(conversionFactorNode);
                }
            }
            
        
        }
        
    
        #region Metal_
        private Metal metal_;
        public Metal Metal_
        {
            get
            {
                if (this.metal_ != null)
                {
                    return this.metal_; 
                }
                else if (this.metalIDRef_ != null)
                {
                    metal_ = IDManager.getID(metalIDRef_) as Metal;
                    return this.metal_; 
                }
                else
                {
                      return this.metal_; 
                }
            }
            set
            {
                if (this.metal_ != value)
                {
                    this.metal_ = value;
                }
            }
        }
        #endregion
        
        public string metalIDRef_ { get; set; }
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
        #region DeliveryConditions_
        private MetalDelivery deliveryConditions_;
        public MetalDelivery DeliveryConditions_
        {
            get
            {
                if (this.deliveryConditions_ != null)
                {
                    return this.deliveryConditions_; 
                }
                else if (this.deliveryConditionsIDRef_ != null)
                {
                    deliveryConditions_ = IDManager.getID(deliveryConditionsIDRef_) as MetalDelivery;
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
        #region PhysicalQuantity_
        private CommodityNotionalQuantity physicalQuantity_;
        public CommodityNotionalQuantity PhysicalQuantity_
        {
            get
            {
                if (this.physicalQuantity_ != null)
                {
                    return this.physicalQuantity_; 
                }
                else if (this.physicalQuantityIDRef_ != null)
                {
                    physicalQuantity_ = IDManager.getID(physicalQuantityIDRef_) as CommodityNotionalQuantity;
                    return this.physicalQuantity_; 
                }
                else
                {
                      return this.physicalQuantity_; 
                }
            }
            set
            {
                if (this.physicalQuantity_ != value)
                {
                    this.physicalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string physicalQuantityIDRef_ { get; set; }
        #region PhysicalQuantitySchedule_
        private CommodityPhysicalQuantitySchedule physicalQuantitySchedule_;
        public CommodityPhysicalQuantitySchedule PhysicalQuantitySchedule_
        {
            get
            {
                if (this.physicalQuantitySchedule_ != null)
                {
                    return this.physicalQuantitySchedule_; 
                }
                else if (this.physicalQuantityScheduleIDRef_ != null)
                {
                    physicalQuantitySchedule_ = IDManager.getID(physicalQuantityScheduleIDRef_) as CommodityPhysicalQuantitySchedule;
                    return this.physicalQuantitySchedule_; 
                }
                else
                {
                      return this.physicalQuantitySchedule_; 
                }
            }
            set
            {
                if (this.physicalQuantitySchedule_ != value)
                {
                    this.physicalQuantitySchedule_ = value;
                }
            }
        }
        #endregion
        
        public string physicalQuantityScheduleIDRef_ { get; set; }
        #region TotalPhysicalQuantity_
        private UnitQuantity totalPhysicalQuantity_;
        public UnitQuantity TotalPhysicalQuantity_
        {
            get
            {
                if (this.totalPhysicalQuantity_ != null)
                {
                    return this.totalPhysicalQuantity_; 
                }
                else if (this.totalPhysicalQuantityIDRef_ != null)
                {
                    totalPhysicalQuantity_ = IDManager.getID(totalPhysicalQuantityIDRef_) as UnitQuantity;
                    return this.totalPhysicalQuantity_; 
                }
                else
                {
                      return this.totalPhysicalQuantity_; 
                }
            }
            set
            {
                if (this.totalPhysicalQuantity_ != value)
                {
                    this.totalPhysicalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string totalPhysicalQuantityIDRef_ { get; set; }
        #region ConversionFactor_
        private XsdTypeDecimal conversionFactor_;
        public XsdTypeDecimal ConversionFactor_
        {
            get
            {
                if (this.conversionFactor_ != null)
                {
                    return this.conversionFactor_; 
                }
                else if (this.conversionFactorIDRef_ != null)
                {
                    conversionFactor_ = IDManager.getID(conversionFactorIDRef_) as XsdTypeDecimal;
                    return this.conversionFactor_; 
                }
                else
                {
                      return this.conversionFactor_; 
                }
            }
            set
            {
                if (this.conversionFactor_ != value)
                {
                    this.conversionFactor_ = value;
                }
            }
        }
        #endregion
        
        public string conversionFactorIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BullionPhysicalLeg : PhysicalForwardLeg
    {
        public BullionPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode bullionTypeNode = xmlNode.SelectSingleNode("bullionType");
            
            if (bullionTypeNode != null)
            {
                if (bullionTypeNode.Attributes["href"] != null || bullionTypeNode.Attributes["id"] != null) 
                {
                    if (bullionTypeNode.Attributes["id"] != null) 
                    {
                        bullionTypeIDRef_ = bullionTypeNode.Attributes["id"].Value;
                        BullionTypeEnum ob = new BullionTypeEnum(bullionTypeNode);
                        IDManager.SetID(bullionTypeIDRef_, ob);
                    }
                    else if (bullionTypeNode.Attributes["href"] != null)
                    {
                        bullionTypeIDRef_ = bullionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bullionType_ = new BullionTypeEnum(bullionTypeNode);
                    }
                }
                else
                {
                    bullionType_ = new BullionTypeEnum(bullionTypeNode);
                }
            }
            
        
            XmlNode deliveryLocationNode = xmlNode.SelectSingleNode("deliveryLocation");
            
            if (deliveryLocationNode != null)
            {
                if (deliveryLocationNode.Attributes["href"] != null || deliveryLocationNode.Attributes["id"] != null) 
                {
                    if (deliveryLocationNode.Attributes["id"] != null) 
                    {
                        deliveryLocationIDRef_ = deliveryLocationNode.Attributes["id"].Value;
                        BullionDeliveryLocation ob = new BullionDeliveryLocation(deliveryLocationNode);
                        IDManager.SetID(deliveryLocationIDRef_, ob);
                    }
                    else if (deliveryLocationNode.Attributes["href"] != null)
                    {
                        deliveryLocationIDRef_ = deliveryLocationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryLocation_ = new BullionDeliveryLocation(deliveryLocationNode);
                    }
                }
                else
                {
                    deliveryLocation_ = new BullionDeliveryLocation(deliveryLocationNode);
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
            
        
            XmlNode settlementDateNode = xmlNode.SelectSingleNode("settlementDate");
            
            if (settlementDateNode != null)
            {
                if (settlementDateNode.Attributes["href"] != null || settlementDateNode.Attributes["id"] != null) 
                {
                    if (settlementDateNode.Attributes["id"] != null) 
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(settlementDateNode);
                        IDManager.SetID(settlementDateIDRef_, ob);
                    }
                    else if (settlementDateNode.Attributes["href"] != null)
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDate_ = new AdjustableOrRelativeDate(settlementDateNode);
                    }
                }
                else
                {
                    settlementDate_ = new AdjustableOrRelativeDate(settlementDateNode);
                }
            }
            
        
        }
        
    
        #region BullionType_
        private BullionTypeEnum bullionType_;
        public BullionTypeEnum BullionType_
        {
            get
            {
                if (this.bullionType_ != null)
                {
                    return this.bullionType_; 
                }
                else if (this.bullionTypeIDRef_ != null)
                {
                    bullionType_ = IDManager.getID(bullionTypeIDRef_) as BullionTypeEnum;
                    return this.bullionType_; 
                }
                else
                {
                      return this.bullionType_; 
                }
            }
            set
            {
                if (this.bullionType_ != value)
                {
                    this.bullionType_ = value;
                }
            }
        }
        #endregion
        
        public string bullionTypeIDRef_ { get; set; }
        #region DeliveryLocation_
        private BullionDeliveryLocation deliveryLocation_;
        public BullionDeliveryLocation DeliveryLocation_
        {
            get
            {
                if (this.deliveryLocation_ != null)
                {
                    return this.deliveryLocation_; 
                }
                else if (this.deliveryLocationIDRef_ != null)
                {
                    deliveryLocation_ = IDManager.getID(deliveryLocationIDRef_) as BullionDeliveryLocation;
                    return this.deliveryLocation_; 
                }
                else
                {
                      return this.deliveryLocation_; 
                }
            }
            set
            {
                if (this.deliveryLocation_ != value)
                {
                    this.deliveryLocation_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryLocationIDRef_ { get; set; }
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
        #region SettlementDate_
        private AdjustableOrRelativeDate settlementDate_;
        public AdjustableOrRelativeDate SettlementDate_
        {
            get
            {
                if (this.settlementDate_ != null)
                {
                    return this.settlementDate_; 
                }
                else if (this.settlementDateIDRef_ != null)
                {
                    settlementDate_ = IDManager.getID(settlementDateIDRef_) as AdjustableOrRelativeDate;
                    return this.settlementDate_; 
                }
                else
                {
                      return this.settlementDate_; 
                }
            }
            set
            {
                if (this.settlementDate_ != value)
                {
                    this.settlementDate_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


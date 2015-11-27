using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityPhysicalLeg : PhysicalSwapLeg
    {
        public ElectricityPhysicalLeg(XmlNode xmlNode)
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
            
        
            XmlNodeList settlementPeriodsNodeList = xmlNode.SelectNodes("settlementPeriods");
            
            if (settlementPeriodsNodeList != null)
            {
                this.settlementPeriods_ = new List<SettlementPeriods>();
                foreach (XmlNode item in settlementPeriodsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsIDRef_ = item.Attributes["id"].Value;
                            settlementPeriods_.Add(new SettlementPeriods(item));
                            IDManager.SetID(settlementPeriodsIDRef_, settlementPeriods_[settlementPeriods_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriods_.Add(new SettlementPeriods(item));
                        }
                    }
                    else
                    {
                        settlementPeriods_.Add(new SettlementPeriods(item));
                    }
                }
            }
            
        
            XmlNode settlementPeriodsScheduleNode = xmlNode.SelectSingleNode("settlementPeriodsSchedule");
            
            if (settlementPeriodsScheduleNode != null)
            {
                if (settlementPeriodsScheduleNode.Attributes["href"] != null || settlementPeriodsScheduleNode.Attributes["id"] != null) 
                {
                    if (settlementPeriodsScheduleNode.Attributes["id"] != null) 
                    {
                        settlementPeriodsScheduleIDRef_ = settlementPeriodsScheduleNode.Attributes["id"].Value;
                        SettlementPeriodsSchedule ob = new SettlementPeriodsSchedule(settlementPeriodsScheduleNode);
                        IDManager.SetID(settlementPeriodsScheduleIDRef_, ob);
                    }
                    else if (settlementPeriodsScheduleNode.Attributes["href"] != null)
                    {
                        settlementPeriodsScheduleIDRef_ = settlementPeriodsScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementPeriodsSchedule_ = new SettlementPeriodsSchedule(settlementPeriodsScheduleNode);
                    }
                }
                else
                {
                    settlementPeriodsSchedule_ = new SettlementPeriodsSchedule(settlementPeriodsScheduleNode);
                }
            }
            
        
            XmlNode loadTypeNode = xmlNode.SelectSingleNode("loadType");
            
            if (loadTypeNode != null)
            {
                if (loadTypeNode.Attributes["href"] != null || loadTypeNode.Attributes["id"] != null) 
                {
                    if (loadTypeNode.Attributes["id"] != null) 
                    {
                        loadTypeIDRef_ = loadTypeNode.Attributes["id"].Value;
                        LoadTypeEnum ob = new LoadTypeEnum(loadTypeNode);
                        IDManager.SetID(loadTypeIDRef_, ob);
                    }
                    else if (loadTypeNode.Attributes["href"] != null)
                    {
                        loadTypeIDRef_ = loadTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        loadType_ = new LoadTypeEnum(loadTypeNode);
                    }
                }
                else
                {
                    loadType_ = new LoadTypeEnum(loadTypeNode);
                }
            }
            
        
            XmlNode electricityNode = xmlNode.SelectSingleNode("electricity");
            
            if (electricityNode != null)
            {
                if (electricityNode.Attributes["href"] != null || electricityNode.Attributes["id"] != null) 
                {
                    if (electricityNode.Attributes["id"] != null) 
                    {
                        electricityIDRef_ = electricityNode.Attributes["id"].Value;
                        ElectricityProduct ob = new ElectricityProduct(electricityNode);
                        IDManager.SetID(electricityIDRef_, ob);
                    }
                    else if (electricityNode.Attributes["href"] != null)
                    {
                        electricityIDRef_ = electricityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        electricity_ = new ElectricityProduct(electricityNode);
                    }
                }
                else
                {
                    electricity_ = new ElectricityProduct(electricityNode);
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
                        ElectricityDelivery ob = new ElectricityDelivery(deliveryConditionsNode);
                        IDManager.SetID(deliveryConditionsIDRef_, ob);
                    }
                    else if (deliveryConditionsNode.Attributes["href"] != null)
                    {
                        deliveryConditionsIDRef_ = deliveryConditionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryConditions_ = new ElectricityDelivery(deliveryConditionsNode);
                    }
                }
                else
                {
                    deliveryConditions_ = new ElectricityDelivery(deliveryConditionsNode);
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
                        ElectricityPhysicalQuantity ob = new ElectricityPhysicalQuantity(deliveryQuantityNode);
                        IDManager.SetID(deliveryQuantityIDRef_, ob);
                    }
                    else if (deliveryQuantityNode.Attributes["href"] != null)
                    {
                        deliveryQuantityIDRef_ = deliveryQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryQuantity_ = new ElectricityPhysicalQuantity(deliveryQuantityNode);
                    }
                }
                else
                {
                    deliveryQuantity_ = new ElectricityPhysicalQuantity(deliveryQuantityNode);
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
        #region SettlementPeriods_
        private List<SettlementPeriods> settlementPeriods_;
        public List<SettlementPeriods> SettlementPeriods_
        {
            get
            {
                if (this.settlementPeriods_ != null)
                {
                    return this.settlementPeriods_; 
                }
                else if (this.settlementPeriodsIDRef_ != null)
                {
                    return this.settlementPeriods_; 
                }
                else
                {
                      return this.settlementPeriods_; 
                }
            }
            set
            {
                if (this.settlementPeriods_ != value)
                {
                    this.settlementPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsIDRef_ { get; set; }
        #region SettlementPeriodsSchedule_
        private SettlementPeriodsSchedule settlementPeriodsSchedule_;
        public SettlementPeriodsSchedule SettlementPeriodsSchedule_
        {
            get
            {
                if (this.settlementPeriodsSchedule_ != null)
                {
                    return this.settlementPeriodsSchedule_; 
                }
                else if (this.settlementPeriodsScheduleIDRef_ != null)
                {
                    settlementPeriodsSchedule_ = IDManager.getID(settlementPeriodsScheduleIDRef_) as SettlementPeriodsSchedule;
                    return this.settlementPeriodsSchedule_; 
                }
                else
                {
                      return this.settlementPeriodsSchedule_; 
                }
            }
            set
            {
                if (this.settlementPeriodsSchedule_ != value)
                {
                    this.settlementPeriodsSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsScheduleIDRef_ { get; set; }
        #region LoadType_
        private LoadTypeEnum loadType_;
        public LoadTypeEnum LoadType_
        {
            get
            {
                if (this.loadType_ != null)
                {
                    return this.loadType_; 
                }
                else if (this.loadTypeIDRef_ != null)
                {
                    loadType_ = IDManager.getID(loadTypeIDRef_) as LoadTypeEnum;
                    return this.loadType_; 
                }
                else
                {
                      return this.loadType_; 
                }
            }
            set
            {
                if (this.loadType_ != value)
                {
                    this.loadType_ = value;
                }
            }
        }
        #endregion
        
        public string loadTypeIDRef_ { get; set; }
        #region Electricity_
        private ElectricityProduct electricity_;
        public ElectricityProduct Electricity_
        {
            get
            {
                if (this.electricity_ != null)
                {
                    return this.electricity_; 
                }
                else if (this.electricityIDRef_ != null)
                {
                    electricity_ = IDManager.getID(electricityIDRef_) as ElectricityProduct;
                    return this.electricity_; 
                }
                else
                {
                      return this.electricity_; 
                }
            }
            set
            {
                if (this.electricity_ != value)
                {
                    this.electricity_ = value;
                }
            }
        }
        #endregion
        
        public string electricityIDRef_ { get; set; }
        #region DeliveryConditions_
        private ElectricityDelivery deliveryConditions_;
        public ElectricityDelivery DeliveryConditions_
        {
            get
            {
                if (this.deliveryConditions_ != null)
                {
                    return this.deliveryConditions_; 
                }
                else if (this.deliveryConditionsIDRef_ != null)
                {
                    deliveryConditions_ = IDManager.getID(deliveryConditionsIDRef_) as ElectricityDelivery;
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
        private ElectricityPhysicalQuantity deliveryQuantity_;
        public ElectricityPhysicalQuantity DeliveryQuantity_
        {
            get
            {
                if (this.deliveryQuantity_ != null)
                {
                    return this.deliveryQuantity_; 
                }
                else if (this.deliveryQuantityIDRef_ != null)
                {
                    deliveryQuantity_ = IDManager.getID(deliveryQuantityIDRef_) as ElectricityPhysicalQuantity;
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


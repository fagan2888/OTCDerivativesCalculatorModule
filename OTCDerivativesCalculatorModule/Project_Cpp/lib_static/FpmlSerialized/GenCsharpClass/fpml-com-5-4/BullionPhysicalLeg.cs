using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BullionPhysicalLeg
    {
        public BullionPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList bullionTypeNodeList = xmlNode.SelectNodes("bullionType");
            if (bullionTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bullionTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bullionTypeIDRef = item.Attributes["id"].Name;
                        BullionTypeEnum ob = BullionTypeEnum();
                        IDManager.SetID(bullionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bullionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bullionType = new BullionTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryLocationNodeList = xmlNode.SelectNodes("deliveryLocation");
            if (deliveryLocationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryLocationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryLocationIDRef = item.Attributes["id"].Name;
                        BullionDeliveryLocation ob = BullionDeliveryLocation();
                        IDManager.SetID(deliveryLocationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryLocationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryLocation = new BullionDeliveryLocation(item);
                    }
                }
            }
            
        
            XmlNodeList physicalQuantityNodeList = xmlNode.SelectNodes("physicalQuantity");
            if (physicalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalQuantityIDRef = item.Attributes["id"].Name;
                        CommodityNotionalQuantity ob = CommodityNotionalQuantity();
                        IDManager.SetID(physicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalQuantity = new CommodityNotionalQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList physicalQuantityScheduleNodeList = xmlNode.SelectNodes("physicalQuantitySchedule");
            if (physicalQuantityScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalQuantityScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalQuantityScheduleIDRef = item.Attributes["id"].Name;
                        CommodityPhysicalQuantitySchedule ob = CommodityPhysicalQuantitySchedule();
                        IDManager.SetID(physicalQuantityScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalQuantityScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalQuantitySchedule = new CommodityPhysicalQuantitySchedule(item);
                    }
                }
            }
            
        
            XmlNodeList totalPhysicalQuantityNodeList = xmlNode.SelectNodes("totalPhysicalQuantity");
            if (totalPhysicalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in totalPhysicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        totalPhysicalQuantityIDRef = item.Attributes["id"].Name;
                        UnitQuantity ob = UnitQuantity();
                        IDManager.SetID(totalPhysicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        totalPhysicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        totalPhysicalQuantity = new UnitQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList settlementDateNodeList = xmlNode.SelectNodes("settlementDate");
            if (settlementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(settlementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region BullionType
        private BullionTypeEnum bullionType;
        public BullionTypeEnum BullionType
        {
            get
            {
                if (this.bullionType != null)
                {
                    return this.bullionType; 
                }
                else if (this.bullionTypeIDRef != null)
                {
                    bullionType = IDManager.getID(bullionTypeIDRef) as BullionTypeEnum;
                    return this.bullionType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bullionType != value)
                {
                    this.bullionType = value;
                }
            }
        }
        #endregion
        
        public string BullionTypeEnumIDRef { get; set; }
        #region DeliveryLocation
        private BullionDeliveryLocation deliveryLocation;
        public BullionDeliveryLocation DeliveryLocation
        {
            get
            {
                if (this.deliveryLocation != null)
                {
                    return this.deliveryLocation; 
                }
                else if (this.deliveryLocationIDRef != null)
                {
                    deliveryLocation = IDManager.getID(deliveryLocationIDRef) as BullionDeliveryLocation;
                    return this.deliveryLocation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryLocation != value)
                {
                    this.deliveryLocation = value;
                }
            }
        }
        #endregion
        
        public string BullionDeliveryLocationIDRef { get; set; }
        #region PhysicalQuantity
        private CommodityNotionalQuantity physicalQuantity;
        public CommodityNotionalQuantity PhysicalQuantity
        {
            get
            {
                if (this.physicalQuantity != null)
                {
                    return this.physicalQuantity; 
                }
                else if (this.physicalQuantityIDRef != null)
                {
                    physicalQuantity = IDManager.getID(physicalQuantityIDRef) as CommodityNotionalQuantity;
                    return this.physicalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalQuantity != value)
                {
                    this.physicalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region PhysicalQuantitySchedule
        private CommodityPhysicalQuantitySchedule physicalQuantitySchedule;
        public CommodityPhysicalQuantitySchedule PhysicalQuantitySchedule
        {
            get
            {
                if (this.physicalQuantitySchedule != null)
                {
                    return this.physicalQuantitySchedule; 
                }
                else if (this.physicalQuantityScheduleIDRef != null)
                {
                    physicalQuantitySchedule = IDManager.getID(physicalQuantityScheduleIDRef) as CommodityPhysicalQuantitySchedule;
                    return this.physicalQuantitySchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalQuantitySchedule != value)
                {
                    this.physicalQuantitySchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityPhysicalQuantityScheduleIDRef { get; set; }
        #region TotalPhysicalQuantity
        private UnitQuantity totalPhysicalQuantity;
        public UnitQuantity TotalPhysicalQuantity
        {
            get
            {
                if (this.totalPhysicalQuantity != null)
                {
                    return this.totalPhysicalQuantity; 
                }
                else if (this.totalPhysicalQuantityIDRef != null)
                {
                    totalPhysicalQuantity = IDManager.getID(totalPhysicalQuantityIDRef) as UnitQuantity;
                    return this.totalPhysicalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.totalPhysicalQuantity != value)
                {
                    this.totalPhysicalQuantity = value;
                }
            }
        }
        #endregion
        
        public string UnitQuantityIDRef { get; set; }
        #region SettlementDate
        private AdjustableOrRelativeDate settlementDate;
        public AdjustableOrRelativeDate SettlementDate
        {
            get
            {
                if (this.settlementDate != null)
                {
                    return this.settlementDate; 
                }
                else if (this.settlementDateIDRef != null)
                {
                    settlementDate = IDManager.getID(settlementDateIDRef) as AdjustableOrRelativeDate;
                    return this.settlementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementDate != value)
                {
                    this.settlementDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


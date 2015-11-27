using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityPhysicalLeg
    {
        public ElectricityPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList deliveryPeriodsNodeList = xmlNode.SelectNodes("deliveryPeriods");
            if (deliveryPeriodsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryPeriodsIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPeriods ob = CommodityDeliveryPeriods();
                        IDManager.SetID(deliveryPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPeriods = new CommodityDeliveryPeriods(item);
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsNodeList = xmlNode.SelectNodes("settlementPeriods");
            
            foreach (XmlNode item in settlementPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriods> ob = new List<SettlementPeriods>();
                        ob.Add(new SettlementPeriods(item));
                        IDManager.SetID(settlementPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriods.Add(new SettlementPeriods(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsScheduleNodeList = xmlNode.SelectNodes("settlementPeriodsSchedule");
            if (settlementPeriodsScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementPeriodsScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsScheduleIDRef = item.Attributes["id"].Name;
                        SettlementPeriodsSchedule ob = SettlementPeriodsSchedule();
                        IDManager.SetID(settlementPeriodsScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementPeriodsSchedule = new SettlementPeriodsSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList loadTypeNodeList = xmlNode.SelectNodes("loadType");
            if (loadTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in loadTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        loadTypeIDRef = item.Attributes["id"].Name;
                        LoadTypeEnum ob = LoadTypeEnum();
                        IDManager.SetID(loadTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        loadTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        loadType = new LoadTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList electricityNodeList = xmlNode.SelectNodes("electricity");
            if (electricityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in electricityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        electricityIDRef = item.Attributes["id"].Name;
                        ElectricityProduct ob = ElectricityProduct();
                        IDManager.SetID(electricityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        electricityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        electricity = new ElectricityProduct(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryConditionsNodeList = xmlNode.SelectNodes("deliveryConditions");
            if (deliveryConditionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryConditionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryConditionsIDRef = item.Attributes["id"].Name;
                        ElectricityDelivery ob = ElectricityDelivery();
                        IDManager.SetID(deliveryConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryConditions = new ElectricityDelivery(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryQuantityNodeList = xmlNode.SelectNodes("deliveryQuantity");
            if (deliveryQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryQuantityIDRef = item.Attributes["id"].Name;
                        ElectricityPhysicalQuantity ob = ElectricityPhysicalQuantity();
                        IDManager.SetID(deliveryQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryQuantity = new ElectricityPhysicalQuantity(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeliveryPeriods
        private CommodityDeliveryPeriods deliveryPeriods;
        public CommodityDeliveryPeriods DeliveryPeriods
        {
            get
            {
                if (this.deliveryPeriods != null)
                {
                    return this.deliveryPeriods; 
                }
                else if (this.deliveryPeriodsIDRef != null)
                {
                    deliveryPeriods = IDManager.getID(deliveryPeriodsIDRef) as CommodityDeliveryPeriods;
                    return this.deliveryPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryPeriods != value)
                {
                    this.deliveryPeriods = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPeriodsIDRef { get; set; }
        #region SettlementPeriods
        private List<SettlementPeriods> settlementPeriods;
        public List<SettlementPeriods> SettlementPeriods
        {
            get
            {
                if (this.settlementPeriods != null)
                {
                    return this.settlementPeriods; 
                }
                else if (this.settlementPeriodsIDRef != null)
                {
                    settlementPeriods = IDManager.getID(settlementPeriodsIDRef) as List<SettlementPeriods>;
                    return this.settlementPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriods != value)
                {
                    this.settlementPeriods = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsIDRef { get; set; }
        #region SettlementPeriodsSchedule
        private SettlementPeriodsSchedule settlementPeriodsSchedule;
        public SettlementPeriodsSchedule SettlementPeriodsSchedule
        {
            get
            {
                if (this.settlementPeriodsSchedule != null)
                {
                    return this.settlementPeriodsSchedule; 
                }
                else if (this.settlementPeriodsScheduleIDRef != null)
                {
                    settlementPeriodsSchedule = IDManager.getID(settlementPeriodsScheduleIDRef) as SettlementPeriodsSchedule;
                    return this.settlementPeriodsSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsSchedule != value)
                {
                    this.settlementPeriodsSchedule = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsScheduleIDRef { get; set; }
        #region LoadType
        private LoadTypeEnum loadType;
        public LoadTypeEnum LoadType
        {
            get
            {
                if (this.loadType != null)
                {
                    return this.loadType; 
                }
                else if (this.loadTypeIDRef != null)
                {
                    loadType = IDManager.getID(loadTypeIDRef) as LoadTypeEnum;
                    return this.loadType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.loadType != value)
                {
                    this.loadType = value;
                }
            }
        }
        #endregion
        
        public string LoadTypeEnumIDRef { get; set; }
        #region Electricity
        private ElectricityProduct electricity;
        public ElectricityProduct Electricity
        {
            get
            {
                if (this.electricity != null)
                {
                    return this.electricity; 
                }
                else if (this.electricityIDRef != null)
                {
                    electricity = IDManager.getID(electricityIDRef) as ElectricityProduct;
                    return this.electricity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.electricity != value)
                {
                    this.electricity = value;
                }
            }
        }
        #endregion
        
        public string ElectricityProductIDRef { get; set; }
        #region DeliveryConditions
        private ElectricityDelivery deliveryConditions;
        public ElectricityDelivery DeliveryConditions
        {
            get
            {
                if (this.deliveryConditions != null)
                {
                    return this.deliveryConditions; 
                }
                else if (this.deliveryConditionsIDRef != null)
                {
                    deliveryConditions = IDManager.getID(deliveryConditionsIDRef) as ElectricityDelivery;
                    return this.deliveryConditions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryConditions != value)
                {
                    this.deliveryConditions = value;
                }
            }
        }
        #endregion
        
        public string ElectricityDeliveryIDRef { get; set; }
        #region DeliveryQuantity
        private ElectricityPhysicalQuantity deliveryQuantity;
        public ElectricityPhysicalQuantity DeliveryQuantity
        {
            get
            {
                if (this.deliveryQuantity != null)
                {
                    return this.deliveryQuantity; 
                }
                else if (this.deliveryQuantityIDRef != null)
                {
                    deliveryQuantity = IDManager.getID(deliveryQuantityIDRef) as ElectricityPhysicalQuantity;
                    return this.deliveryQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryQuantity != value)
                {
                    this.deliveryQuantity = value;
                }
            }
        }
        #endregion
        
        public string ElectricityPhysicalQuantityIDRef { get; set; }
        
    
        
    
    }
    
}


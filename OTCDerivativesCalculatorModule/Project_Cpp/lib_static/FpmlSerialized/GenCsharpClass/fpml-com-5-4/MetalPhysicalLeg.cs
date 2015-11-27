using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MetalPhysicalLeg
    {
        public MetalPhysicalLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList metalNodeList = xmlNode.SelectNodes("metal");
            if (metalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in metalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        metalIDRef = item.Attributes["id"].Name;
                        Metal ob = Metal();
                        IDManager.SetID(metalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        metalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        metal = new Metal(item);
                    }
                }
            }
            
        
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
                        MetalDelivery ob = MetalDelivery();
                        IDManager.SetID(deliveryConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryConditions = new MetalDelivery(item);
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
            
        
            XmlNodeList conversionFactorNodeList = xmlNode.SelectNodes("conversionFactor");
            if (conversionFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in conversionFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        conversionFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(conversionFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        conversionFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        conversionFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Metal
        private Metal metal;
        public Metal Metal
        {
            get
            {
                if (this.metal != null)
                {
                    return this.metal; 
                }
                else if (this.metalIDRef != null)
                {
                    metal = IDManager.getID(metalIDRef) as Metal;
                    return this.metal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.metal != value)
                {
                    this.metal = value;
                }
            }
        }
        #endregion
        
        public string MetalIDRef { get; set; }
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
        #region DeliveryConditions
        private MetalDelivery deliveryConditions;
        public MetalDelivery DeliveryConditions
        {
            get
            {
                if (this.deliveryConditions != null)
                {
                    return this.deliveryConditions; 
                }
                else if (this.deliveryConditionsIDRef != null)
                {
                    deliveryConditions = IDManager.getID(deliveryConditionsIDRef) as MetalDelivery;
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
        
        public string MetalDeliveryIDRef { get; set; }
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
        #region ConversionFactor
        private XsdTypeDecimal conversionFactor;
        public XsdTypeDecimal ConversionFactor
        {
            get
            {
                if (this.conversionFactor != null)
                {
                    return this.conversionFactor; 
                }
                else if (this.conversionFactorIDRef != null)
                {
                    conversionFactor = IDManager.getID(conversionFactorIDRef) as XsdTypeDecimal;
                    return this.conversionFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.conversionFactor != value)
                {
                    this.conversionFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


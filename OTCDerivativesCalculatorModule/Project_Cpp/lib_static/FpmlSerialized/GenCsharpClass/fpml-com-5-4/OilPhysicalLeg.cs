using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OilPhysicalLeg
    {
        public OilPhysicalLeg(XmlNode xmlNode)
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
            
        
            XmlNodeList oilNodeList = xmlNode.SelectNodes("oil");
            if (oilNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in oilNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        oilIDRef = item.Attributes["id"].Name;
                        OilProduct ob = OilProduct();
                        IDManager.SetID(oilIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        oilIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        oil = new OilProduct(item);
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
                        OilDelivery ob = OilDelivery();
                        IDManager.SetID(deliveryConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryConditions = new OilDelivery(item);
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
                        CommodityPhysicalQuantity ob = CommodityPhysicalQuantity();
                        IDManager.SetID(deliveryQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryQuantity = new CommodityPhysicalQuantity(item);
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
        #region Oil
        private OilProduct oil;
        public OilProduct Oil
        {
            get
            {
                if (this.oil != null)
                {
                    return this.oil; 
                }
                else if (this.oilIDRef != null)
                {
                    oil = IDManager.getID(oilIDRef) as OilProduct;
                    return this.oil; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.oil != value)
                {
                    this.oil = value;
                }
            }
        }
        #endregion
        
        public string OilProductIDRef { get; set; }
        #region DeliveryConditions
        private OilDelivery deliveryConditions;
        public OilDelivery DeliveryConditions
        {
            get
            {
                if (this.deliveryConditions != null)
                {
                    return this.deliveryConditions; 
                }
                else if (this.deliveryConditionsIDRef != null)
                {
                    deliveryConditions = IDManager.getID(deliveryConditionsIDRef) as OilDelivery;
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
        
        public string OilDeliveryIDRef { get; set; }
        #region DeliveryQuantity
        private CommodityPhysicalQuantity deliveryQuantity;
        public CommodityPhysicalQuantity DeliveryQuantity
        {
            get
            {
                if (this.deliveryQuantity != null)
                {
                    return this.deliveryQuantity; 
                }
                else if (this.deliveryQuantityIDRef != null)
                {
                    deliveryQuantity = IDManager.getID(deliveryQuantityIDRef) as CommodityPhysicalQuantity;
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
        
        public string CommodityPhysicalQuantityIDRef { get; set; }
        
    
        
    
    }
    
}


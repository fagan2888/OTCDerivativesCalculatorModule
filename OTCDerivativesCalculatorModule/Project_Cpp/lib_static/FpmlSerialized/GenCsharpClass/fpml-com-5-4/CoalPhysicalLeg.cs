using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalPhysicalLeg
    {
        public CoalPhysicalLeg(XmlNode xmlNode)
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
            
        
            XmlNodeList coalNodeList = xmlNode.SelectNodes("coal");
            if (coalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coalIDRef = item.Attributes["id"].Name;
                        CoalProduct ob = CoalProduct();
                        IDManager.SetID(coalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coal = new CoalProduct(item);
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
                        CoalDelivery ob = CoalDelivery();
                        IDManager.SetID(deliveryConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryConditions = new CoalDelivery(item);
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
        #region Coal
        private CoalProduct coal;
        public CoalProduct Coal
        {
            get
            {
                if (this.coal != null)
                {
                    return this.coal; 
                }
                else if (this.coalIDRef != null)
                {
                    coal = IDManager.getID(coalIDRef) as CoalProduct;
                    return this.coal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coal != value)
                {
                    this.coal = value;
                }
            }
        }
        #endregion
        
        public string CoalProductIDRef { get; set; }
        #region DeliveryConditions
        private CoalDelivery deliveryConditions;
        public CoalDelivery DeliveryConditions
        {
            get
            {
                if (this.deliveryConditions != null)
                {
                    return this.deliveryConditions; 
                }
                else if (this.deliveryConditionsIDRef != null)
                {
                    deliveryConditions = IDManager.getID(deliveryConditionsIDRef) as CoalDelivery;
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
        
        public string CoalDeliveryIDRef { get; set; }
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


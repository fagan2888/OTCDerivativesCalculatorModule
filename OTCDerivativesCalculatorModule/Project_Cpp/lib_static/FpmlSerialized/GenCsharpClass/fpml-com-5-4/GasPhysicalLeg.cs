using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GasPhysicalLeg
    {
        public GasPhysicalLeg(XmlNode xmlNode)
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
                        GasDeliveryPeriods ob = GasDeliveryPeriods();
                        IDManager.SetID(deliveryPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPeriods = new GasDeliveryPeriods(item);
                    }
                }
            }
            
        
            XmlNodeList gasNodeList = xmlNode.SelectNodes("gas");
            if (gasNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in gasNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        gasIDRef = item.Attributes["id"].Name;
                        GasProduct ob = GasProduct();
                        IDManager.SetID(gasIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        gasIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        gas = new GasProduct(item);
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
                        GasDelivery ob = GasDelivery();
                        IDManager.SetID(deliveryConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryConditions = new GasDelivery(item);
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
                        GasPhysicalQuantity ob = GasPhysicalQuantity();
                        IDManager.SetID(deliveryQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryQuantity = new GasPhysicalQuantity(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeliveryPeriods
        private GasDeliveryPeriods deliveryPeriods;
        public GasDeliveryPeriods DeliveryPeriods
        {
            get
            {
                if (this.deliveryPeriods != null)
                {
                    return this.deliveryPeriods; 
                }
                else if (this.deliveryPeriodsIDRef != null)
                {
                    deliveryPeriods = IDManager.getID(deliveryPeriodsIDRef) as GasDeliveryPeriods;
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
        
        public string GasDeliveryPeriodsIDRef { get; set; }
        #region Gas
        private GasProduct gas;
        public GasProduct Gas
        {
            get
            {
                if (this.gas != null)
                {
                    return this.gas; 
                }
                else if (this.gasIDRef != null)
                {
                    gas = IDManager.getID(gasIDRef) as GasProduct;
                    return this.gas; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.gas != value)
                {
                    this.gas = value;
                }
            }
        }
        #endregion
        
        public string GasProductIDRef { get; set; }
        #region DeliveryConditions
        private GasDelivery deliveryConditions;
        public GasDelivery DeliveryConditions
        {
            get
            {
                if (this.deliveryConditions != null)
                {
                    return this.deliveryConditions; 
                }
                else if (this.deliveryConditionsIDRef != null)
                {
                    deliveryConditions = IDManager.getID(deliveryConditionsIDRef) as GasDelivery;
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
        
        public string GasDeliveryIDRef { get; set; }
        #region DeliveryQuantity
        private GasPhysicalQuantity deliveryQuantity;
        public GasPhysicalQuantity DeliveryQuantity
        {
            get
            {
                if (this.deliveryQuantity != null)
                {
                    return this.deliveryQuantity; 
                }
                else if (this.deliveryQuantityIDRef != null)
                {
                    deliveryQuantity = IDManager.getID(deliveryQuantityIDRef) as GasPhysicalQuantity;
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
        
        public string GasPhysicalQuantityIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalDelivery
    {
        public CoalDelivery(XmlNode xmlNode)
        {
            XmlNodeList deliveryPointNodeList = xmlNode.SelectNodes("deliveryPoint");
            if (deliveryPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryPointIDRef = item.Attributes["id"].Name;
                        CoalDeliveryPoint ob = CoalDeliveryPoint();
                        IDManager.SetID(deliveryPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPoint = new CoalDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryAtSourceNodeList = xmlNode.SelectNodes("deliveryAtSource");
            if (deliveryAtSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryAtSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryAtSourceIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(deliveryAtSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryAtSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryAtSource = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList quantityVariationAdjustmentNodeList = xmlNode.SelectNodes("quantityVariationAdjustment");
            if (quantityVariationAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityVariationAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityVariationAdjustmentIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(quantityVariationAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityVariationAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantityVariationAdjustment = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList transportationEquipmentNodeList = xmlNode.SelectNodes("transportationEquipment");
            if (transportationEquipmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transportationEquipmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transportationEquipmentIDRef = item.Attributes["id"].Name;
                        CoalTransportationEquipment ob = CoalTransportationEquipment();
                        IDManager.SetID(transportationEquipmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transportationEquipmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transportationEquipment = new CoalTransportationEquipment(item);
                    }
                }
            }
            
        
            XmlNodeList riskNodeList = xmlNode.SelectNodes("risk");
            if (riskNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in riskNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        riskIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryRisk ob = CommodityDeliveryRisk();
                        IDManager.SetID(riskIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        riskIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        risk = new CommodityDeliveryRisk(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeliveryPoint
        private CoalDeliveryPoint deliveryPoint;
        public CoalDeliveryPoint DeliveryPoint
        {
            get
            {
                if (this.deliveryPoint != null)
                {
                    return this.deliveryPoint; 
                }
                else if (this.deliveryPointIDRef != null)
                {
                    deliveryPoint = IDManager.getID(deliveryPointIDRef) as CoalDeliveryPoint;
                    return this.deliveryPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryPoint != value)
                {
                    this.deliveryPoint = value;
                }
            }
        }
        #endregion
        
        public string CoalDeliveryPointIDRef { get; set; }
        #region DeliveryAtSource
        private XsdTypeBoolean deliveryAtSource;
        public XsdTypeBoolean DeliveryAtSource
        {
            get
            {
                if (this.deliveryAtSource != null)
                {
                    return this.deliveryAtSource; 
                }
                else if (this.deliveryAtSourceIDRef != null)
                {
                    deliveryAtSource = IDManager.getID(deliveryAtSourceIDRef) as XsdTypeBoolean;
                    return this.deliveryAtSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryAtSource != value)
                {
                    this.deliveryAtSource = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region QuantityVariationAdjustment
        private XsdTypeBoolean quantityVariationAdjustment;
        public XsdTypeBoolean QuantityVariationAdjustment
        {
            get
            {
                if (this.quantityVariationAdjustment != null)
                {
                    return this.quantityVariationAdjustment; 
                }
                else if (this.quantityVariationAdjustmentIDRef != null)
                {
                    quantityVariationAdjustment = IDManager.getID(quantityVariationAdjustmentIDRef) as XsdTypeBoolean;
                    return this.quantityVariationAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantityVariationAdjustment != value)
                {
                    this.quantityVariationAdjustment = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region TransportationEquipment
        private CoalTransportationEquipment transportationEquipment;
        public CoalTransportationEquipment TransportationEquipment
        {
            get
            {
                if (this.transportationEquipment != null)
                {
                    return this.transportationEquipment; 
                }
                else if (this.transportationEquipmentIDRef != null)
                {
                    transportationEquipment = IDManager.getID(transportationEquipmentIDRef) as CoalTransportationEquipment;
                    return this.transportationEquipment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transportationEquipment != value)
                {
                    this.transportationEquipment = value;
                }
            }
        }
        #endregion
        
        public string CoalTransportationEquipmentIDRef { get; set; }
        #region Risk
        private CommodityDeliveryRisk risk;
        public CommodityDeliveryRisk Risk
        {
            get
            {
                if (this.risk != null)
                {
                    return this.risk; 
                }
                else if (this.riskIDRef != null)
                {
                    risk = IDManager.getID(riskIDRef) as CommodityDeliveryRisk;
                    return this.risk; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.risk != value)
                {
                    this.risk = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryRiskIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


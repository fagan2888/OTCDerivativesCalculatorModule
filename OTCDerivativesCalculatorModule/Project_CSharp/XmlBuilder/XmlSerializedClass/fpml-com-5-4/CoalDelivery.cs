using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalDelivery : ISerialized
    {
        public CoalDelivery(XmlNode xmlNode)
        {
            XmlNode deliveryPointNode = xmlNode.SelectSingleNode("deliveryPoint");
            
            if (deliveryPointNode != null)
            {
                if (deliveryPointNode.Attributes["href"] != null || deliveryPointNode.Attributes["id"] != null) 
                {
                    if (deliveryPointNode.Attributes["id"] != null) 
                    {
                        deliveryPointIDRef_ = deliveryPointNode.Attributes["id"].Value;
                        CoalDeliveryPoint ob = new CoalDeliveryPoint(deliveryPointNode);
                        IDManager.SetID(deliveryPointIDRef_, ob);
                    }
                    else if (deliveryPointNode.Attributes["href"] != null)
                    {
                        deliveryPointIDRef_ = deliveryPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPoint_ = new CoalDeliveryPoint(deliveryPointNode);
                    }
                }
                else
                {
                    deliveryPoint_ = new CoalDeliveryPoint(deliveryPointNode);
                }
            }
            
        
            XmlNode deliveryAtSourceNode = xmlNode.SelectSingleNode("deliveryAtSource");
            
            if (deliveryAtSourceNode != null)
            {
                if (deliveryAtSourceNode.Attributes["href"] != null || deliveryAtSourceNode.Attributes["id"] != null) 
                {
                    if (deliveryAtSourceNode.Attributes["id"] != null) 
                    {
                        deliveryAtSourceIDRef_ = deliveryAtSourceNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(deliveryAtSourceNode);
                        IDManager.SetID(deliveryAtSourceIDRef_, ob);
                    }
                    else if (deliveryAtSourceNode.Attributes["href"] != null)
                    {
                        deliveryAtSourceIDRef_ = deliveryAtSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryAtSource_ = new XsdTypeBoolean(deliveryAtSourceNode);
                    }
                }
                else
                {
                    deliveryAtSource_ = new XsdTypeBoolean(deliveryAtSourceNode);
                }
            }
            
        
            XmlNode quantityVariationAdjustmentNode = xmlNode.SelectSingleNode("quantityVariationAdjustment");
            
            if (quantityVariationAdjustmentNode != null)
            {
                if (quantityVariationAdjustmentNode.Attributes["href"] != null || quantityVariationAdjustmentNode.Attributes["id"] != null) 
                {
                    if (quantityVariationAdjustmentNode.Attributes["id"] != null) 
                    {
                        quantityVariationAdjustmentIDRef_ = quantityVariationAdjustmentNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(quantityVariationAdjustmentNode);
                        IDManager.SetID(quantityVariationAdjustmentIDRef_, ob);
                    }
                    else if (quantityVariationAdjustmentNode.Attributes["href"] != null)
                    {
                        quantityVariationAdjustmentIDRef_ = quantityVariationAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quantityVariationAdjustment_ = new XsdTypeBoolean(quantityVariationAdjustmentNode);
                    }
                }
                else
                {
                    quantityVariationAdjustment_ = new XsdTypeBoolean(quantityVariationAdjustmentNode);
                }
            }
            
        
            XmlNode transportationEquipmentNode = xmlNode.SelectSingleNode("transportationEquipment");
            
            if (transportationEquipmentNode != null)
            {
                if (transportationEquipmentNode.Attributes["href"] != null || transportationEquipmentNode.Attributes["id"] != null) 
                {
                    if (transportationEquipmentNode.Attributes["id"] != null) 
                    {
                        transportationEquipmentIDRef_ = transportationEquipmentNode.Attributes["id"].Value;
                        CoalTransportationEquipment ob = new CoalTransportationEquipment(transportationEquipmentNode);
                        IDManager.SetID(transportationEquipmentIDRef_, ob);
                    }
                    else if (transportationEquipmentNode.Attributes["href"] != null)
                    {
                        transportationEquipmentIDRef_ = transportationEquipmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transportationEquipment_ = new CoalTransportationEquipment(transportationEquipmentNode);
                    }
                }
                else
                {
                    transportationEquipment_ = new CoalTransportationEquipment(transportationEquipmentNode);
                }
            }
            
        
            XmlNode riskNode = xmlNode.SelectSingleNode("risk");
            
            if (riskNode != null)
            {
                if (riskNode.Attributes["href"] != null || riskNode.Attributes["id"] != null) 
                {
                    if (riskNode.Attributes["id"] != null) 
                    {
                        riskIDRef_ = riskNode.Attributes["id"].Value;
                        CommodityDeliveryRisk ob = new CommodityDeliveryRisk(riskNode);
                        IDManager.SetID(riskIDRef_, ob);
                    }
                    else if (riskNode.Attributes["href"] != null)
                    {
                        riskIDRef_ = riskNode.Attributes["href"].Value;
                    }
                    else
                    {
                        risk_ = new CommodityDeliveryRisk(riskNode);
                    }
                }
                else
                {
                    risk_ = new CommodityDeliveryRisk(riskNode);
                }
            }
            
        
        }
        
    
        #region DeliveryPoint_
        private CoalDeliveryPoint deliveryPoint_;
        public CoalDeliveryPoint DeliveryPoint_
        {
            get
            {
                if (this.deliveryPoint_ != null)
                {
                    return this.deliveryPoint_; 
                }
                else if (this.deliveryPointIDRef_ != null)
                {
                    deliveryPoint_ = IDManager.getID(deliveryPointIDRef_) as CoalDeliveryPoint;
                    return this.deliveryPoint_; 
                }
                else
                {
                      return this.deliveryPoint_; 
                }
            }
            set
            {
                if (this.deliveryPoint_ != value)
                {
                    this.deliveryPoint_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryPointIDRef_ { get; set; }
        #region DeliveryAtSource_
        private XsdTypeBoolean deliveryAtSource_;
        public XsdTypeBoolean DeliveryAtSource_
        {
            get
            {
                if (this.deliveryAtSource_ != null)
                {
                    return this.deliveryAtSource_; 
                }
                else if (this.deliveryAtSourceIDRef_ != null)
                {
                    deliveryAtSource_ = IDManager.getID(deliveryAtSourceIDRef_) as XsdTypeBoolean;
                    return this.deliveryAtSource_; 
                }
                else
                {
                      return this.deliveryAtSource_; 
                }
            }
            set
            {
                if (this.deliveryAtSource_ != value)
                {
                    this.deliveryAtSource_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryAtSourceIDRef_ { get; set; }
        #region QuantityVariationAdjustment_
        private XsdTypeBoolean quantityVariationAdjustment_;
        public XsdTypeBoolean QuantityVariationAdjustment_
        {
            get
            {
                if (this.quantityVariationAdjustment_ != null)
                {
                    return this.quantityVariationAdjustment_; 
                }
                else if (this.quantityVariationAdjustmentIDRef_ != null)
                {
                    quantityVariationAdjustment_ = IDManager.getID(quantityVariationAdjustmentIDRef_) as XsdTypeBoolean;
                    return this.quantityVariationAdjustment_; 
                }
                else
                {
                      return this.quantityVariationAdjustment_; 
                }
            }
            set
            {
                if (this.quantityVariationAdjustment_ != value)
                {
                    this.quantityVariationAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string quantityVariationAdjustmentIDRef_ { get; set; }
        #region TransportationEquipment_
        private CoalTransportationEquipment transportationEquipment_;
        public CoalTransportationEquipment TransportationEquipment_
        {
            get
            {
                if (this.transportationEquipment_ != null)
                {
                    return this.transportationEquipment_; 
                }
                else if (this.transportationEquipmentIDRef_ != null)
                {
                    transportationEquipment_ = IDManager.getID(transportationEquipmentIDRef_) as CoalTransportationEquipment;
                    return this.transportationEquipment_; 
                }
                else
                {
                      return this.transportationEquipment_; 
                }
            }
            set
            {
                if (this.transportationEquipment_ != value)
                {
                    this.transportationEquipment_ = value;
                }
            }
        }
        #endregion
        
        public string transportationEquipmentIDRef_ { get; set; }
        #region Risk_
        private CommodityDeliveryRisk risk_;
        public CommodityDeliveryRisk Risk_
        {
            get
            {
                if (this.risk_ != null)
                {
                    return this.risk_; 
                }
                else if (this.riskIDRef_ != null)
                {
                    risk_ = IDManager.getID(riskIDRef_) as CommodityDeliveryRisk;
                    return this.risk_; 
                }
                else
                {
                      return this.risk_; 
                }
            }
            set
            {
                if (this.risk_ != value)
                {
                    this.risk_ = value;
                }
            }
        }
        #endregion
        
        public string riskIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityDelivery : ISerialized
    {
        public ElectricityDelivery(XmlNode xmlNode)
        {
            XmlNode deliveryPointNode = xmlNode.SelectSingleNode("deliveryPoint");
            
            if (deliveryPointNode != null)
            {
                if (deliveryPointNode.Attributes["href"] != null || deliveryPointNode.Attributes["id"] != null) 
                {
                    if (deliveryPointNode.Attributes["id"] != null) 
                    {
                        deliveryPointIDRef_ = deliveryPointNode.Attributes["id"].Value;
                        ElectricityDeliveryPoint ob = new ElectricityDeliveryPoint(deliveryPointNode);
                        IDManager.SetID(deliveryPointIDRef_, ob);
                    }
                    else if (deliveryPointNode.Attributes["href"] != null)
                    {
                        deliveryPointIDRef_ = deliveryPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPoint_ = new ElectricityDeliveryPoint(deliveryPointNode);
                    }
                }
                else
                {
                    deliveryPoint_ = new ElectricityDeliveryPoint(deliveryPointNode);
                }
            }
            
        
            XmlNode deliveryTypeNode = xmlNode.SelectSingleNode("deliveryType");
            
            if (deliveryTypeNode != null)
            {
                if (deliveryTypeNode.Attributes["href"] != null || deliveryTypeNode.Attributes["id"] != null) 
                {
                    if (deliveryTypeNode.Attributes["id"] != null) 
                    {
                        deliveryTypeIDRef_ = deliveryTypeNode.Attributes["id"].Value;
                        ElectricityDeliveryType ob = new ElectricityDeliveryType(deliveryTypeNode);
                        IDManager.SetID(deliveryTypeIDRef_, ob);
                    }
                    else if (deliveryTypeNode.Attributes["href"] != null)
                    {
                        deliveryTypeIDRef_ = deliveryTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryType_ = new ElectricityDeliveryType(deliveryTypeNode);
                    }
                }
                else
                {
                    deliveryType_ = new ElectricityDeliveryType(deliveryTypeNode);
                }
            }
            
        
            XmlNode transmissionContingencyNode = xmlNode.SelectSingleNode("transmissionContingency");
            
            if (transmissionContingencyNode != null)
            {
                if (transmissionContingencyNode.Attributes["href"] != null || transmissionContingencyNode.Attributes["id"] != null) 
                {
                    if (transmissionContingencyNode.Attributes["id"] != null) 
                    {
                        transmissionContingencyIDRef_ = transmissionContingencyNode.Attributes["id"].Value;
                        ElectricityTransmissionContingency ob = new ElectricityTransmissionContingency(transmissionContingencyNode);
                        IDManager.SetID(transmissionContingencyIDRef_, ob);
                    }
                    else if (transmissionContingencyNode.Attributes["href"] != null)
                    {
                        transmissionContingencyIDRef_ = transmissionContingencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transmissionContingency_ = new ElectricityTransmissionContingency(transmissionContingencyNode);
                    }
                }
                else
                {
                    transmissionContingency_ = new ElectricityTransmissionContingency(transmissionContingencyNode);
                }
            }
            
        
            XmlNode deliveryZoneNode = xmlNode.SelectSingleNode("deliveryZone");
            
            if (deliveryZoneNode != null)
            {
                if (deliveryZoneNode.Attributes["href"] != null || deliveryZoneNode.Attributes["id"] != null) 
                {
                    if (deliveryZoneNode.Attributes["id"] != null) 
                    {
                        deliveryZoneIDRef_ = deliveryZoneNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(deliveryZoneNode);
                        IDManager.SetID(deliveryZoneIDRef_, ob);
                    }
                    else if (deliveryZoneNode.Attributes["href"] != null)
                    {
                        deliveryZoneIDRef_ = deliveryZoneNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryZone_ = new CommodityDeliveryPoint(deliveryZoneNode);
                    }
                }
                else
                {
                    deliveryZone_ = new CommodityDeliveryPoint(deliveryZoneNode);
                }
            }
            
        
            XmlNode electingPartyReferenceNode = xmlNode.SelectSingleNode("electingPartyReference");
            
            if (electingPartyReferenceNode != null)
            {
                if (electingPartyReferenceNode.Attributes["href"] != null || electingPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (electingPartyReferenceNode.Attributes["id"] != null) 
                    {
                        electingPartyReferenceIDRef_ = electingPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(electingPartyReferenceNode);
                        IDManager.SetID(electingPartyReferenceIDRef_, ob);
                    }
                    else if (electingPartyReferenceNode.Attributes["href"] != null)
                    {
                        electingPartyReferenceIDRef_ = electingPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        electingPartyReference_ = new PartyReference(electingPartyReferenceNode);
                    }
                }
                else
                {
                    electingPartyReference_ = new PartyReference(electingPartyReferenceNode);
                }
            }
            
        
        }
        
    
        #region DeliveryPoint_
        private ElectricityDeliveryPoint deliveryPoint_;
        public ElectricityDeliveryPoint DeliveryPoint_
        {
            get
            {
                if (this.deliveryPoint_ != null)
                {
                    return this.deliveryPoint_; 
                }
                else if (this.deliveryPointIDRef_ != null)
                {
                    deliveryPoint_ = IDManager.getID(deliveryPointIDRef_) as ElectricityDeliveryPoint;
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
        #region DeliveryType_
        private ElectricityDeliveryType deliveryType_;
        public ElectricityDeliveryType DeliveryType_
        {
            get
            {
                if (this.deliveryType_ != null)
                {
                    return this.deliveryType_; 
                }
                else if (this.deliveryTypeIDRef_ != null)
                {
                    deliveryType_ = IDManager.getID(deliveryTypeIDRef_) as ElectricityDeliveryType;
                    return this.deliveryType_; 
                }
                else
                {
                      return this.deliveryType_; 
                }
            }
            set
            {
                if (this.deliveryType_ != value)
                {
                    this.deliveryType_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryTypeIDRef_ { get; set; }
        #region TransmissionContingency_
        private ElectricityTransmissionContingency transmissionContingency_;
        public ElectricityTransmissionContingency TransmissionContingency_
        {
            get
            {
                if (this.transmissionContingency_ != null)
                {
                    return this.transmissionContingency_; 
                }
                else if (this.transmissionContingencyIDRef_ != null)
                {
                    transmissionContingency_ = IDManager.getID(transmissionContingencyIDRef_) as ElectricityTransmissionContingency;
                    return this.transmissionContingency_; 
                }
                else
                {
                      return this.transmissionContingency_; 
                }
            }
            set
            {
                if (this.transmissionContingency_ != value)
                {
                    this.transmissionContingency_ = value;
                }
            }
        }
        #endregion
        
        public string transmissionContingencyIDRef_ { get; set; }
        #region DeliveryZone_
        private CommodityDeliveryPoint deliveryZone_;
        public CommodityDeliveryPoint DeliveryZone_
        {
            get
            {
                if (this.deliveryZone_ != null)
                {
                    return this.deliveryZone_; 
                }
                else if (this.deliveryZoneIDRef_ != null)
                {
                    deliveryZone_ = IDManager.getID(deliveryZoneIDRef_) as CommodityDeliveryPoint;
                    return this.deliveryZone_; 
                }
                else
                {
                      return this.deliveryZone_; 
                }
            }
            set
            {
                if (this.deliveryZone_ != value)
                {
                    this.deliveryZone_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryZoneIDRef_ { get; set; }
        #region ElectingPartyReference_
        private PartyReference electingPartyReference_;
        public PartyReference ElectingPartyReference_
        {
            get
            {
                if (this.electingPartyReference_ != null)
                {
                    return this.electingPartyReference_; 
                }
                else if (this.electingPartyReferenceIDRef_ != null)
                {
                    electingPartyReference_ = IDManager.getID(electingPartyReferenceIDRef_) as PartyReference;
                    return this.electingPartyReference_; 
                }
                else
                {
                      return this.electingPartyReference_; 
                }
            }
            set
            {
                if (this.electingPartyReference_ != value)
                {
                    this.electingPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string electingPartyReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


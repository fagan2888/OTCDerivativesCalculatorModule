using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityDelivery
    {
        public ElectricityDelivery(XmlNode xmlNode)
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
                        ElectricityDeliveryPoint ob = ElectricityDeliveryPoint();
                        IDManager.SetID(deliveryPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPoint = new ElectricityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryTypeNodeList = xmlNode.SelectNodes("deliveryType");
            if (deliveryTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryTypeIDRef = item.Attributes["id"].Name;
                        ElectricityDeliveryType ob = ElectricityDeliveryType();
                        IDManager.SetID(deliveryTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryType = new ElectricityDeliveryType(item);
                    }
                }
            }
            
        
            XmlNodeList transmissionContingencyNodeList = xmlNode.SelectNodes("transmissionContingency");
            if (transmissionContingencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transmissionContingencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transmissionContingencyIDRef = item.Attributes["id"].Name;
                        ElectricityTransmissionContingency ob = ElectricityTransmissionContingency();
                        IDManager.SetID(transmissionContingencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transmissionContingencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transmissionContingency = new ElectricityTransmissionContingency(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryZoneNodeList = xmlNode.SelectNodes("deliveryZone");
            if (deliveryZoneNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryZoneNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryZoneIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(deliveryZoneIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryZoneIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryZone = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList electingPartyReferenceNodeList = xmlNode.SelectNodes("electingPartyReference");
            if (electingPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in electingPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        electingPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(electingPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        electingPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        electingPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeliveryPoint
        private ElectricityDeliveryPoint deliveryPoint;
        public ElectricityDeliveryPoint DeliveryPoint
        {
            get
            {
                if (this.deliveryPoint != null)
                {
                    return this.deliveryPoint; 
                }
                else if (this.deliveryPointIDRef != null)
                {
                    deliveryPoint = IDManager.getID(deliveryPointIDRef) as ElectricityDeliveryPoint;
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
        
        public string ElectricityDeliveryPointIDRef { get; set; }
        #region DeliveryType
        private ElectricityDeliveryType deliveryType;
        public ElectricityDeliveryType DeliveryType
        {
            get
            {
                if (this.deliveryType != null)
                {
                    return this.deliveryType; 
                }
                else if (this.deliveryTypeIDRef != null)
                {
                    deliveryType = IDManager.getID(deliveryTypeIDRef) as ElectricityDeliveryType;
                    return this.deliveryType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryType != value)
                {
                    this.deliveryType = value;
                }
            }
        }
        #endregion
        
        public string ElectricityDeliveryTypeIDRef { get; set; }
        #region TransmissionContingency
        private ElectricityTransmissionContingency transmissionContingency;
        public ElectricityTransmissionContingency TransmissionContingency
        {
            get
            {
                if (this.transmissionContingency != null)
                {
                    return this.transmissionContingency; 
                }
                else if (this.transmissionContingencyIDRef != null)
                {
                    transmissionContingency = IDManager.getID(transmissionContingencyIDRef) as ElectricityTransmissionContingency;
                    return this.transmissionContingency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transmissionContingency != value)
                {
                    this.transmissionContingency = value;
                }
            }
        }
        #endregion
        
        public string ElectricityTransmissionContingencyIDRef { get; set; }
        #region DeliveryZone
        private CommodityDeliveryPoint deliveryZone;
        public CommodityDeliveryPoint DeliveryZone
        {
            get
            {
                if (this.deliveryZone != null)
                {
                    return this.deliveryZone; 
                }
                else if (this.deliveryZoneIDRef != null)
                {
                    deliveryZone = IDManager.getID(deliveryZoneIDRef) as CommodityDeliveryPoint;
                    return this.deliveryZone; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryZone != value)
                {
                    this.deliveryZone = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        #region ElectingPartyReference
        private PartyReference electingPartyReference;
        public PartyReference ElectingPartyReference
        {
            get
            {
                if (this.electingPartyReference != null)
                {
                    return this.electingPartyReference; 
                }
                else if (this.electingPartyReferenceIDRef != null)
                {
                    electingPartyReference = IDManager.getID(electingPartyReferenceIDRef) as PartyReference;
                    return this.electingPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.electingPartyReference != value)
                {
                    this.electingPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


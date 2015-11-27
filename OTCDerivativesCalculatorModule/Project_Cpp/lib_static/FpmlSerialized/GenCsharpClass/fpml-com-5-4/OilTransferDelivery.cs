using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OilTransferDelivery
    {
        public OilTransferDelivery(XmlNode xmlNode)
        {
            XmlNodeList applicableNodeList = xmlNode.SelectNodes("applicable");
            if (applicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(applicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicable = new XsdTypeBoolean(item);
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
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(deliveryLocationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryLocationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryLocation = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
        }
        
    
        #region Applicable
        private XsdTypeBoolean applicable;
        public XsdTypeBoolean Applicable
        {
            get
            {
                if (this.applicable != null)
                {
                    return this.applicable; 
                }
                else if (this.applicableIDRef != null)
                {
                    applicable = IDManager.getID(applicableIDRef) as XsdTypeBoolean;
                    return this.applicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicable != value)
                {
                    this.applicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DeliveryLocation
        private CommodityDeliveryPoint deliveryLocation;
        public CommodityDeliveryPoint DeliveryLocation
        {
            get
            {
                if (this.deliveryLocation != null)
                {
                    return this.deliveryLocation; 
                }
                else if (this.deliveryLocationIDRef != null)
                {
                    deliveryLocation = IDManager.getID(deliveryLocationIDRef) as CommodityDeliveryPoint;
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
        
        public string CommodityDeliveryPointIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OilTransferDelivery : ISerialized
    {
        public OilTransferDelivery(XmlNode xmlNode)
        {
            XmlNode applicableNode = xmlNode.SelectSingleNode("applicable");
            
            if (applicableNode != null)
            {
                if (applicableNode.Attributes["href"] != null || applicableNode.Attributes["id"] != null) 
                {
                    if (applicableNode.Attributes["id"] != null) 
                    {
                        applicableIDRef_ = applicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(applicableNode);
                        IDManager.SetID(applicableIDRef_, ob);
                    }
                    else if (applicableNode.Attributes["href"] != null)
                    {
                        applicableIDRef_ = applicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicable_ = new XsdTypeBoolean(applicableNode);
                    }
                }
                else
                {
                    applicable_ = new XsdTypeBoolean(applicableNode);
                }
            }
            
        
            XmlNode deliveryLocationNode = xmlNode.SelectSingleNode("deliveryLocation");
            
            if (deliveryLocationNode != null)
            {
                if (deliveryLocationNode.Attributes["href"] != null || deliveryLocationNode.Attributes["id"] != null) 
                {
                    if (deliveryLocationNode.Attributes["id"] != null) 
                    {
                        deliveryLocationIDRef_ = deliveryLocationNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(deliveryLocationNode);
                        IDManager.SetID(deliveryLocationIDRef_, ob);
                    }
                    else if (deliveryLocationNode.Attributes["href"] != null)
                    {
                        deliveryLocationIDRef_ = deliveryLocationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryLocation_ = new CommodityDeliveryPoint(deliveryLocationNode);
                    }
                }
                else
                {
                    deliveryLocation_ = new CommodityDeliveryPoint(deliveryLocationNode);
                }
            }
            
        
        }
        
    
        #region Applicable_
        private XsdTypeBoolean applicable_;
        public XsdTypeBoolean Applicable_
        {
            get
            {
                if (this.applicable_ != null)
                {
                    return this.applicable_; 
                }
                else if (this.applicableIDRef_ != null)
                {
                    applicable_ = IDManager.getID(applicableIDRef_) as XsdTypeBoolean;
                    return this.applicable_; 
                }
                else
                {
                      return this.applicable_; 
                }
            }
            set
            {
                if (this.applicable_ != value)
                {
                    this.applicable_ = value;
                }
            }
        }
        #endregion
        
        public string applicableIDRef_ { get; set; }
        #region DeliveryLocation_
        private CommodityDeliveryPoint deliveryLocation_;
        public CommodityDeliveryPoint DeliveryLocation_
        {
            get
            {
                if (this.deliveryLocation_ != null)
                {
                    return this.deliveryLocation_; 
                }
                else if (this.deliveryLocationIDRef_ != null)
                {
                    deliveryLocation_ = IDManager.getID(deliveryLocationIDRef_) as CommodityDeliveryPoint;
                    return this.deliveryLocation_; 
                }
                else
                {
                      return this.deliveryLocation_; 
                }
            }
            set
            {
                if (this.deliveryLocation_ != value)
                {
                    this.deliveryLocation_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryLocationIDRef_ { get; set; }
        
    
        
    
    }
    
}


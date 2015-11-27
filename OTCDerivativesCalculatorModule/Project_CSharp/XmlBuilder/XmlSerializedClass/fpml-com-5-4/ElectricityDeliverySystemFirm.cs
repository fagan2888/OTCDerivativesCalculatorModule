using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliverySystemFirm : ISerialized
    {
        public ElectricityDeliverySystemFirm(XmlNode xmlNode)
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
            
        
            XmlNode systemNode = xmlNode.SelectSingleNode("system");
            
            if (systemNode != null)
            {
                if (systemNode.Attributes["href"] != null || systemNode.Attributes["id"] != null) 
                {
                    if (systemNode.Attributes["id"] != null) 
                    {
                        systemIDRef_ = systemNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(systemNode);
                        IDManager.SetID(systemIDRef_, ob);
                    }
                    else if (systemNode.Attributes["href"] != null)
                    {
                        systemIDRef_ = systemNode.Attributes["href"].Value;
                    }
                    else
                    {
                        system_ = new CommodityDeliveryPoint(systemNode);
                    }
                }
                else
                {
                    system_ = new CommodityDeliveryPoint(systemNode);
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
        #region System_
        private CommodityDeliveryPoint system_;
        public CommodityDeliveryPoint System_
        {
            get
            {
                if (this.system_ != null)
                {
                    return this.system_; 
                }
                else if (this.systemIDRef_ != null)
                {
                    system_ = IDManager.getID(systemIDRef_) as CommodityDeliveryPoint;
                    return this.system_; 
                }
                else
                {
                      return this.system_; 
                }
            }
            set
            {
                if (this.system_ != value)
                {
                    this.system_ = value;
                }
            }
        }
        #endregion
        
        public string systemIDRef_ { get; set; }
        
    
        
    
    }
    
}


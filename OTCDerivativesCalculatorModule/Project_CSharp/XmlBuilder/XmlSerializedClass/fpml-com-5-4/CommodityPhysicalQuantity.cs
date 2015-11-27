using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalQuantity : CommodityPhysicalQuantityBase
    {
        public CommodityPhysicalQuantity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode physicalQuantityNode = xmlNode.SelectSingleNode("physicalQuantity");
            
            if (physicalQuantityNode != null)
            {
                if (physicalQuantityNode.Attributes["href"] != null || physicalQuantityNode.Attributes["id"] != null) 
                {
                    if (physicalQuantityNode.Attributes["id"] != null) 
                    {
                        physicalQuantityIDRef_ = physicalQuantityNode.Attributes["id"].Value;
                        CommodityNotionalQuantity ob = new CommodityNotionalQuantity(physicalQuantityNode);
                        IDManager.SetID(physicalQuantityIDRef_, ob);
                    }
                    else if (physicalQuantityNode.Attributes["href"] != null)
                    {
                        physicalQuantityIDRef_ = physicalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalQuantity_ = new CommodityNotionalQuantity(physicalQuantityNode);
                    }
                }
                else
                {
                    physicalQuantity_ = new CommodityNotionalQuantity(physicalQuantityNode);
                }
            }
            
        
            XmlNode physicalQuantityScheduleNode = xmlNode.SelectSingleNode("physicalQuantitySchedule");
            
            if (physicalQuantityScheduleNode != null)
            {
                if (physicalQuantityScheduleNode.Attributes["href"] != null || physicalQuantityScheduleNode.Attributes["id"] != null) 
                {
                    if (physicalQuantityScheduleNode.Attributes["id"] != null) 
                    {
                        physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode.Attributes["id"].Value;
                        CommodityPhysicalQuantitySchedule ob = new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode);
                        IDManager.SetID(physicalQuantityScheduleIDRef_, ob);
                    }
                    else if (physicalQuantityScheduleNode.Attributes["href"] != null)
                    {
                        physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalQuantitySchedule_ = new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode);
                    }
                }
                else
                {
                    physicalQuantitySchedule_ = new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode);
                }
            }
            
        
            XmlNode totalPhysicalQuantityNode = xmlNode.SelectSingleNode("totalPhysicalQuantity");
            
            if (totalPhysicalQuantityNode != null)
            {
                if (totalPhysicalQuantityNode.Attributes["href"] != null || totalPhysicalQuantityNode.Attributes["id"] != null) 
                {
                    if (totalPhysicalQuantityNode.Attributes["id"] != null) 
                    {
                        totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode.Attributes["id"].Value;
                        UnitQuantity ob = new UnitQuantity(totalPhysicalQuantityNode);
                        IDManager.SetID(totalPhysicalQuantityIDRef_, ob);
                    }
                    else if (totalPhysicalQuantityNode.Attributes["href"] != null)
                    {
                        totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        totalPhysicalQuantity_ = new UnitQuantity(totalPhysicalQuantityNode);
                    }
                }
                else
                {
                    totalPhysicalQuantity_ = new UnitQuantity(totalPhysicalQuantityNode);
                }
            }
            
        
        }
        
    
        #region PhysicalQuantity_
        private CommodityNotionalQuantity physicalQuantity_;
        public CommodityNotionalQuantity PhysicalQuantity_
        {
            get
            {
                if (this.physicalQuantity_ != null)
                {
                    return this.physicalQuantity_; 
                }
                else if (this.physicalQuantityIDRef_ != null)
                {
                    physicalQuantity_ = IDManager.getID(physicalQuantityIDRef_) as CommodityNotionalQuantity;
                    return this.physicalQuantity_; 
                }
                else
                {
                      return this.physicalQuantity_; 
                }
            }
            set
            {
                if (this.physicalQuantity_ != value)
                {
                    this.physicalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string physicalQuantityIDRef_ { get; set; }
        #region PhysicalQuantitySchedule_
        private CommodityPhysicalQuantitySchedule physicalQuantitySchedule_;
        public CommodityPhysicalQuantitySchedule PhysicalQuantitySchedule_
        {
            get
            {
                if (this.physicalQuantitySchedule_ != null)
                {
                    return this.physicalQuantitySchedule_; 
                }
                else if (this.physicalQuantityScheduleIDRef_ != null)
                {
                    physicalQuantitySchedule_ = IDManager.getID(physicalQuantityScheduleIDRef_) as CommodityPhysicalQuantitySchedule;
                    return this.physicalQuantitySchedule_; 
                }
                else
                {
                      return this.physicalQuantitySchedule_; 
                }
            }
            set
            {
                if (this.physicalQuantitySchedule_ != value)
                {
                    this.physicalQuantitySchedule_ = value;
                }
            }
        }
        #endregion
        
        public string physicalQuantityScheduleIDRef_ { get; set; }
        #region TotalPhysicalQuantity_
        private UnitQuantity totalPhysicalQuantity_;
        public UnitQuantity TotalPhysicalQuantity_
        {
            get
            {
                if (this.totalPhysicalQuantity_ != null)
                {
                    return this.totalPhysicalQuantity_; 
                }
                else if (this.totalPhysicalQuantityIDRef_ != null)
                {
                    totalPhysicalQuantity_ = IDManager.getID(totalPhysicalQuantityIDRef_) as UnitQuantity;
                    return this.totalPhysicalQuantity_; 
                }
                else
                {
                      return this.totalPhysicalQuantity_; 
                }
            }
            set
            {
                if (this.totalPhysicalQuantity_ != value)
                {
                    this.totalPhysicalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string totalPhysicalQuantityIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


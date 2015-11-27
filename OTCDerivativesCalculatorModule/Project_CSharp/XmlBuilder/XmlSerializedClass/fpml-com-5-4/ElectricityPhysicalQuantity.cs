using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityPhysicalQuantity : CommodityPhysicalQuantityBase
    {
        public ElectricityPhysicalQuantity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList physicalQuantityNodeList = xmlNode.SelectNodes("physicalQuantity");
            
            if (physicalQuantityNodeList != null)
            {
                this.physicalQuantity_ = new List<ElectricityPhysicalDeliveryQuantity>();
                foreach (XmlNode item in physicalQuantityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            physicalQuantityIDRef_ = item.Attributes["id"].Value;
                            physicalQuantity_.Add(new ElectricityPhysicalDeliveryQuantity(item));
                            IDManager.SetID(physicalQuantityIDRef_, physicalQuantity_[physicalQuantity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            physicalQuantityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        physicalQuantity_.Add(new ElectricityPhysicalDeliveryQuantity(item));
                        }
                    }
                    else
                    {
                        physicalQuantity_.Add(new ElectricityPhysicalDeliveryQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList physicalQuantityScheduleNodeList = xmlNode.SelectNodes("physicalQuantitySchedule");
            
            if (physicalQuantityScheduleNodeList != null)
            {
                this.physicalQuantitySchedule_ = new List<ElectricityPhysicalDeliveryQuantitySchedule>();
                foreach (XmlNode item in physicalQuantityScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            physicalQuantityScheduleIDRef_ = item.Attributes["id"].Value;
                            physicalQuantitySchedule_.Add(new ElectricityPhysicalDeliveryQuantitySchedule(item));
                            IDManager.SetID(physicalQuantityScheduleIDRef_, physicalQuantitySchedule_[physicalQuantitySchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            physicalQuantityScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        physicalQuantitySchedule_.Add(new ElectricityPhysicalDeliveryQuantitySchedule(item));
                        }
                    }
                    else
                    {
                        physicalQuantitySchedule_.Add(new ElectricityPhysicalDeliveryQuantitySchedule(item));
                    }
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
        private List<ElectricityPhysicalDeliveryQuantity> physicalQuantity_;
        public List<ElectricityPhysicalDeliveryQuantity> PhysicalQuantity_
        {
            get
            {
                if (this.physicalQuantity_ != null)
                {
                    return this.physicalQuantity_; 
                }
                else if (this.physicalQuantityIDRef_ != null)
                {
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
        private List<ElectricityPhysicalDeliveryQuantitySchedule> physicalQuantitySchedule_;
        public List<ElectricityPhysicalDeliveryQuantitySchedule> PhysicalQuantitySchedule_
        {
            get
            {
                if (this.physicalQuantitySchedule_ != null)
                {
                    return this.physicalQuantitySchedule_; 
                }
                else if (this.physicalQuantityScheduleIDRef_ != null)
                {
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


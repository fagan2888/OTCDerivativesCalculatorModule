using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GasPhysicalQuantity : CommodityPhysicalQuantityBase
    {
        public GasPhysicalQuantity(XmlNode xmlNode)
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
            
        
            XmlNodeList minPhysicalQuantityNodeList = xmlNode.SelectNodes("minPhysicalQuantity");
            
            if (minPhysicalQuantityNodeList != null)
            {
                this.minPhysicalQuantity_ = new List<CommodityNotionalQuantity>();
                foreach (XmlNode item in minPhysicalQuantityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            minPhysicalQuantityIDRef_ = item.Attributes["id"].Value;
                            minPhysicalQuantity_.Add(new CommodityNotionalQuantity(item));
                            IDManager.SetID(minPhysicalQuantityIDRef_, minPhysicalQuantity_[minPhysicalQuantity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            minPhysicalQuantityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        minPhysicalQuantity_.Add(new CommodityNotionalQuantity(item));
                        }
                    }
                    else
                    {
                        minPhysicalQuantity_.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList maxPhysicalQuantityNodeList = xmlNode.SelectNodes("maxPhysicalQuantity");
            
            if (maxPhysicalQuantityNodeList != null)
            {
                this.maxPhysicalQuantity_ = new List<CommodityNotionalQuantity>();
                foreach (XmlNode item in maxPhysicalQuantityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            maxPhysicalQuantityIDRef_ = item.Attributes["id"].Value;
                            maxPhysicalQuantity_.Add(new CommodityNotionalQuantity(item));
                            IDManager.SetID(maxPhysicalQuantityIDRef_, maxPhysicalQuantity_[maxPhysicalQuantity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            maxPhysicalQuantityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        maxPhysicalQuantity_.Add(new CommodityNotionalQuantity(item));
                        }
                    }
                    else
                    {
                        maxPhysicalQuantity_.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNode electingPartyNode = xmlNode.SelectSingleNode("electingParty");
            
            if (electingPartyNode != null)
            {
                if (electingPartyNode.Attributes["href"] != null || electingPartyNode.Attributes["id"] != null) 
                {
                    if (electingPartyNode.Attributes["id"] != null) 
                    {
                        electingPartyIDRef_ = electingPartyNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(electingPartyNode);
                        IDManager.SetID(electingPartyIDRef_, ob);
                    }
                    else if (electingPartyNode.Attributes["href"] != null)
                    {
                        electingPartyIDRef_ = electingPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        electingParty_ = new PartyReference(electingPartyNode);
                    }
                }
                else
                {
                    electingParty_ = new PartyReference(electingPartyNode);
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
        #region MinPhysicalQuantity_
        private List<CommodityNotionalQuantity> minPhysicalQuantity_;
        public List<CommodityNotionalQuantity> MinPhysicalQuantity_
        {
            get
            {
                if (this.minPhysicalQuantity_ != null)
                {
                    return this.minPhysicalQuantity_; 
                }
                else if (this.minPhysicalQuantityIDRef_ != null)
                {
                    return this.minPhysicalQuantity_; 
                }
                else
                {
                      return this.minPhysicalQuantity_; 
                }
            }
            set
            {
                if (this.minPhysicalQuantity_ != value)
                {
                    this.minPhysicalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string minPhysicalQuantityIDRef_ { get; set; }
        #region MaxPhysicalQuantity_
        private List<CommodityNotionalQuantity> maxPhysicalQuantity_;
        public List<CommodityNotionalQuantity> MaxPhysicalQuantity_
        {
            get
            {
                if (this.maxPhysicalQuantity_ != null)
                {
                    return this.maxPhysicalQuantity_; 
                }
                else if (this.maxPhysicalQuantityIDRef_ != null)
                {
                    return this.maxPhysicalQuantity_; 
                }
                else
                {
                      return this.maxPhysicalQuantity_; 
                }
            }
            set
            {
                if (this.maxPhysicalQuantity_ != value)
                {
                    this.maxPhysicalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string maxPhysicalQuantityIDRef_ { get; set; }
        #region ElectingParty_
        private PartyReference electingParty_;
        public PartyReference ElectingParty_
        {
            get
            {
                if (this.electingParty_ != null)
                {
                    return this.electingParty_; 
                }
                else if (this.electingPartyIDRef_ != null)
                {
                    electingParty_ = IDManager.getID(electingPartyIDRef_) as PartyReference;
                    return this.electingParty_; 
                }
                else
                {
                      return this.electingParty_; 
                }
            }
            set
            {
                if (this.electingParty_ != value)
                {
                    this.electingParty_ = value;
                }
            }
        }
        #endregion
        
        public string electingPartyIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


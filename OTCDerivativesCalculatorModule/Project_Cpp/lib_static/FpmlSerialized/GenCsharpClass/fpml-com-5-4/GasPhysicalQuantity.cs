using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GasPhysicalQuantity
    {
        public GasPhysicalQuantity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList physicalQuantityNodeList = xmlNode.SelectNodes("physicalQuantity");
            if (physicalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalQuantityIDRef = item.Attributes["id"].Name;
                        CommodityNotionalQuantity ob = CommodityNotionalQuantity();
                        IDManager.SetID(physicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalQuantity = new CommodityNotionalQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList physicalQuantityScheduleNodeList = xmlNode.SelectNodes("physicalQuantitySchedule");
            if (physicalQuantityScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalQuantityScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalQuantityScheduleIDRef = item.Attributes["id"].Name;
                        CommodityPhysicalQuantitySchedule ob = CommodityPhysicalQuantitySchedule();
                        IDManager.SetID(physicalQuantityScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalQuantityScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalQuantitySchedule = new CommodityPhysicalQuantitySchedule(item);
                    }
                }
            }
            
        
            XmlNodeList totalPhysicalQuantityNodeList = xmlNode.SelectNodes("totalPhysicalQuantity");
            if (totalPhysicalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in totalPhysicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        totalPhysicalQuantityIDRef = item.Attributes["id"].Name;
                        UnitQuantity ob = UnitQuantity();
                        IDManager.SetID(totalPhysicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        totalPhysicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        totalPhysicalQuantity = new UnitQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList minPhysicalQuantityNodeList = xmlNode.SelectNodes("minPhysicalQuantity");
            
            foreach (XmlNode item in minPhysicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minPhysicalQuantityIDRef = item.Attributes["id"].Name;
                        List<CommodityNotionalQuantity> ob = new List<CommodityNotionalQuantity>();
                        ob.Add(new CommodityNotionalQuantity(item));
                        IDManager.SetID(minPhysicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minPhysicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    minPhysicalQuantity.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList maxPhysicalQuantityNodeList = xmlNode.SelectNodes("maxPhysicalQuantity");
            
            foreach (XmlNode item in maxPhysicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maxPhysicalQuantityIDRef = item.Attributes["id"].Name;
                        List<CommodityNotionalQuantity> ob = new List<CommodityNotionalQuantity>();
                        ob.Add(new CommodityNotionalQuantity(item));
                        IDManager.SetID(maxPhysicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maxPhysicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    maxPhysicalQuantity.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList electingPartyNodeList = xmlNode.SelectNodes("electingParty");
            if (electingPartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in electingPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        electingPartyIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(electingPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        electingPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        electingParty = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region PhysicalQuantity
        private CommodityNotionalQuantity physicalQuantity;
        public CommodityNotionalQuantity PhysicalQuantity
        {
            get
            {
                if (this.physicalQuantity != null)
                {
                    return this.physicalQuantity; 
                }
                else if (this.physicalQuantityIDRef != null)
                {
                    physicalQuantity = IDManager.getID(physicalQuantityIDRef) as CommodityNotionalQuantity;
                    return this.physicalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalQuantity != value)
                {
                    this.physicalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region PhysicalQuantitySchedule
        private CommodityPhysicalQuantitySchedule physicalQuantitySchedule;
        public CommodityPhysicalQuantitySchedule PhysicalQuantitySchedule
        {
            get
            {
                if (this.physicalQuantitySchedule != null)
                {
                    return this.physicalQuantitySchedule; 
                }
                else if (this.physicalQuantityScheduleIDRef != null)
                {
                    physicalQuantitySchedule = IDManager.getID(physicalQuantityScheduleIDRef) as CommodityPhysicalQuantitySchedule;
                    return this.physicalQuantitySchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalQuantitySchedule != value)
                {
                    this.physicalQuantitySchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityPhysicalQuantityScheduleIDRef { get; set; }
        #region TotalPhysicalQuantity
        private UnitQuantity totalPhysicalQuantity;
        public UnitQuantity TotalPhysicalQuantity
        {
            get
            {
                if (this.totalPhysicalQuantity != null)
                {
                    return this.totalPhysicalQuantity; 
                }
                else if (this.totalPhysicalQuantityIDRef != null)
                {
                    totalPhysicalQuantity = IDManager.getID(totalPhysicalQuantityIDRef) as UnitQuantity;
                    return this.totalPhysicalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.totalPhysicalQuantity != value)
                {
                    this.totalPhysicalQuantity = value;
                }
            }
        }
        #endregion
        
        public string UnitQuantityIDRef { get; set; }
        #region MinPhysicalQuantity
        private List<CommodityNotionalQuantity> minPhysicalQuantity;
        public List<CommodityNotionalQuantity> MinPhysicalQuantity
        {
            get
            {
                if (this.minPhysicalQuantity != null)
                {
                    return this.minPhysicalQuantity; 
                }
                else if (this.minPhysicalQuantityIDRef != null)
                {
                    minPhysicalQuantity = IDManager.getID(minPhysicalQuantityIDRef) as List<CommodityNotionalQuantity>;
                    return this.minPhysicalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minPhysicalQuantity != value)
                {
                    this.minPhysicalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region MaxPhysicalQuantity
        private List<CommodityNotionalQuantity> maxPhysicalQuantity;
        public List<CommodityNotionalQuantity> MaxPhysicalQuantity
        {
            get
            {
                if (this.maxPhysicalQuantity != null)
                {
                    return this.maxPhysicalQuantity; 
                }
                else if (this.maxPhysicalQuantityIDRef != null)
                {
                    maxPhysicalQuantity = IDManager.getID(maxPhysicalQuantityIDRef) as List<CommodityNotionalQuantity>;
                    return this.maxPhysicalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maxPhysicalQuantity != value)
                {
                    this.maxPhysicalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region ElectingParty
        private PartyReference electingParty;
        public PartyReference ElectingParty
        {
            get
            {
                if (this.electingParty != null)
                {
                    return this.electingParty; 
                }
                else if (this.electingPartyIDRef != null)
                {
                    electingParty = IDManager.getID(electingPartyIDRef) as PartyReference;
                    return this.electingParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.electingParty != value)
                {
                    this.electingParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


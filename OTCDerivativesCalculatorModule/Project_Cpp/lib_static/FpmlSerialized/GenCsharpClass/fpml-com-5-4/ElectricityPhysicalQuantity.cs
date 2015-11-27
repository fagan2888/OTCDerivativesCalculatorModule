using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityPhysicalQuantity
    {
        public ElectricityPhysicalQuantity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList physicalQuantityNodeList = xmlNode.SelectNodes("physicalQuantity");
            
            foreach (XmlNode item in physicalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalQuantityIDRef = item.Attributes["id"].Name;
                        List<ElectricityPhysicalDeliveryQuantity> ob = new List<ElectricityPhysicalDeliveryQuantity>();
                        ob.Add(new ElectricityPhysicalDeliveryQuantity(item));
                        IDManager.SetID(physicalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    physicalQuantity.Add(new ElectricityPhysicalDeliveryQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList physicalQuantityScheduleNodeList = xmlNode.SelectNodes("physicalQuantitySchedule");
            
            foreach (XmlNode item in physicalQuantityScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalQuantityScheduleIDRef = item.Attributes["id"].Name;
                        List<ElectricityPhysicalDeliveryQuantitySchedule> ob = new List<ElectricityPhysicalDeliveryQuantitySchedule>();
                        ob.Add(new ElectricityPhysicalDeliveryQuantitySchedule(item));
                        IDManager.SetID(physicalQuantityScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalQuantityScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    physicalQuantitySchedule.Add(new ElectricityPhysicalDeliveryQuantitySchedule(item));
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
            
        
        }
        
    
        #region PhysicalQuantity
        private List<ElectricityPhysicalDeliveryQuantity> physicalQuantity;
        public List<ElectricityPhysicalDeliveryQuantity> PhysicalQuantity
        {
            get
            {
                if (this.physicalQuantity != null)
                {
                    return this.physicalQuantity; 
                }
                else if (this.physicalQuantityIDRef != null)
                {
                    physicalQuantity = IDManager.getID(physicalQuantityIDRef) as List<ElectricityPhysicalDeliveryQuantity>;
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
        
        public string ElectricityPhysicalDeliveryQuantityIDRef { get; set; }
        #region PhysicalQuantitySchedule
        private List<ElectricityPhysicalDeliveryQuantitySchedule> physicalQuantitySchedule;
        public List<ElectricityPhysicalDeliveryQuantitySchedule> PhysicalQuantitySchedule
        {
            get
            {
                if (this.physicalQuantitySchedule != null)
                {
                    return this.physicalQuantitySchedule; 
                }
                else if (this.physicalQuantityScheduleIDRef != null)
                {
                    physicalQuantitySchedule = IDManager.getID(physicalQuantityScheduleIDRef) as List<ElectricityPhysicalDeliveryQuantitySchedule>;
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
        
        public string ElectricityPhysicalDeliveryQuantityScheduleIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}


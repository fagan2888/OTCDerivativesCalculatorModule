using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GasDeliveryPeriods
    {
        public GasDeliveryPeriods(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList supplyStartTimeNodeList = xmlNode.SelectNodes("supplyStartTime");
            if (supplyStartTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in supplyStartTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        supplyStartTimeIDRef = item.Attributes["id"].Name;
                        PrevailingTime ob = PrevailingTime();
                        IDManager.SetID(supplyStartTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        supplyStartTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        supplyStartTime = new PrevailingTime(item);
                    }
                }
            }
            
        
            XmlNodeList supplyEndTimeNodeList = xmlNode.SelectNodes("supplyEndTime");
            if (supplyEndTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in supplyEndTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        supplyEndTimeIDRef = item.Attributes["id"].Name;
                        PrevailingTime ob = PrevailingTime();
                        IDManager.SetID(supplyEndTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        supplyEndTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        supplyEndTime = new PrevailingTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region SupplyStartTime
        private PrevailingTime supplyStartTime;
        public PrevailingTime SupplyStartTime
        {
            get
            {
                if (this.supplyStartTime != null)
                {
                    return this.supplyStartTime; 
                }
                else if (this.supplyStartTimeIDRef != null)
                {
                    supplyStartTime = IDManager.getID(supplyStartTimeIDRef) as PrevailingTime;
                    return this.supplyStartTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.supplyStartTime != value)
                {
                    this.supplyStartTime = value;
                }
            }
        }
        #endregion
        
        public string PrevailingTimeIDRef { get; set; }
        #region SupplyEndTime
        private PrevailingTime supplyEndTime;
        public PrevailingTime SupplyEndTime
        {
            get
            {
                if (this.supplyEndTime != null)
                {
                    return this.supplyEndTime; 
                }
                else if (this.supplyEndTimeIDRef != null)
                {
                    supplyEndTime = IDManager.getID(supplyEndTimeIDRef) as PrevailingTime;
                    return this.supplyEndTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.supplyEndTime != value)
                {
                    this.supplyEndTime = value;
                }
            }
        }
        #endregion
        
        public string PrevailingTimeIDRef { get; set; }
        
    
        
    
    }
    
}


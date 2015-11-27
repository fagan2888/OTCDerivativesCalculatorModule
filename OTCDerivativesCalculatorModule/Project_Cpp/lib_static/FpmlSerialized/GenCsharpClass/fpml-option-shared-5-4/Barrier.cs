using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Barrier
    {
        public Barrier(XmlNode xmlNode)
        {
            XmlNodeList barrierCapNodeList = xmlNode.SelectNodes("barrierCap");
            if (barrierCapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in barrierCapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        barrierCapIDRef = item.Attributes["id"].Name;
                        TriggerEvent ob = TriggerEvent();
                        IDManager.SetID(barrierCapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        barrierCapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        barrierCap = new TriggerEvent(item);
                    }
                }
            }
            
        
            XmlNodeList barrierFloorNodeList = xmlNode.SelectNodes("barrierFloor");
            if (barrierFloorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in barrierFloorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        barrierFloorIDRef = item.Attributes["id"].Name;
                        TriggerEvent ob = TriggerEvent();
                        IDManager.SetID(barrierFloorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        barrierFloorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        barrierFloor = new TriggerEvent(item);
                    }
                }
            }
            
        
        }
        
    
        #region BarrierCap
        private TriggerEvent barrierCap;
        public TriggerEvent BarrierCap
        {
            get
            {
                if (this.barrierCap != null)
                {
                    return this.barrierCap; 
                }
                else if (this.barrierCapIDRef != null)
                {
                    barrierCap = IDManager.getID(barrierCapIDRef) as TriggerEvent;
                    return this.barrierCap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.barrierCap != value)
                {
                    this.barrierCap = value;
                }
            }
        }
        #endregion
        
        public string TriggerEventIDRef { get; set; }
        #region BarrierFloor
        private TriggerEvent barrierFloor;
        public TriggerEvent BarrierFloor
        {
            get
            {
                if (this.barrierFloor != null)
                {
                    return this.barrierFloor; 
                }
                else if (this.barrierFloorIDRef != null)
                {
                    barrierFloor = IDManager.getID(barrierFloorIDRef) as TriggerEvent;
                    return this.barrierFloor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.barrierFloor != value)
                {
                    this.barrierFloor = value;
                }
            }
        }
        #endregion
        
        public string TriggerEventIDRef { get; set; }
        
    
        
    
    }
    
}


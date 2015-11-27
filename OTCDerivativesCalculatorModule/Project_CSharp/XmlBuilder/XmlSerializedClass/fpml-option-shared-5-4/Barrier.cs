using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Barrier : ISerialized
    {
        public Barrier(XmlNode xmlNode)
        {
            XmlNode barrierCapNode = xmlNode.SelectSingleNode("barrierCap");
            
            if (barrierCapNode != null)
            {
                if (barrierCapNode.Attributes["href"] != null || barrierCapNode.Attributes["id"] != null) 
                {
                    if (barrierCapNode.Attributes["id"] != null) 
                    {
                        barrierCapIDRef_ = barrierCapNode.Attributes["id"].Value;
                        TriggerEvent ob = new TriggerEvent(barrierCapNode);
                        IDManager.SetID(barrierCapIDRef_, ob);
                    }
                    else if (barrierCapNode.Attributes["href"] != null)
                    {
                        barrierCapIDRef_ = barrierCapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierCap_ = new TriggerEvent(barrierCapNode);
                    }
                }
                else
                {
                    barrierCap_ = new TriggerEvent(barrierCapNode);
                }
            }
            
        
            XmlNode barrierFloorNode = xmlNode.SelectSingleNode("barrierFloor");
            
            if (barrierFloorNode != null)
            {
                if (barrierFloorNode.Attributes["href"] != null || barrierFloorNode.Attributes["id"] != null) 
                {
                    if (barrierFloorNode.Attributes["id"] != null) 
                    {
                        barrierFloorIDRef_ = barrierFloorNode.Attributes["id"].Value;
                        TriggerEvent ob = new TriggerEvent(barrierFloorNode);
                        IDManager.SetID(barrierFloorIDRef_, ob);
                    }
                    else if (barrierFloorNode.Attributes["href"] != null)
                    {
                        barrierFloorIDRef_ = barrierFloorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierFloor_ = new TriggerEvent(barrierFloorNode);
                    }
                }
                else
                {
                    barrierFloor_ = new TriggerEvent(barrierFloorNode);
                }
            }
            
        
        }
        
    
        #region BarrierCap_
        private TriggerEvent barrierCap_;
        public TriggerEvent BarrierCap_
        {
            get
            {
                if (this.barrierCap_ != null)
                {
                    return this.barrierCap_; 
                }
                else if (this.barrierCapIDRef_ != null)
                {
                    barrierCap_ = IDManager.getID(barrierCapIDRef_) as TriggerEvent;
                    return this.barrierCap_; 
                }
                else
                {
                      return this.barrierCap_; 
                }
            }
            set
            {
                if (this.barrierCap_ != value)
                {
                    this.barrierCap_ = value;
                }
            }
        }
        #endregion
        
        public string barrierCapIDRef_ { get; set; }
        #region BarrierFloor_
        private TriggerEvent barrierFloor_;
        public TriggerEvent BarrierFloor_
        {
            get
            {
                if (this.barrierFloor_ != null)
                {
                    return this.barrierFloor_; 
                }
                else if (this.barrierFloorIDRef_ != null)
                {
                    barrierFloor_ = IDManager.getID(barrierFloorIDRef_) as TriggerEvent;
                    return this.barrierFloor_; 
                }
                else
                {
                      return this.barrierFloor_; 
                }
            }
            set
            {
                if (this.barrierFloor_ != value)
                {
                    this.barrierFloor_ = value;
                }
            }
        }
        #endregion
        
        public string barrierFloorIDRef_ { get; set; }
        
    
        
    
    }
    
}


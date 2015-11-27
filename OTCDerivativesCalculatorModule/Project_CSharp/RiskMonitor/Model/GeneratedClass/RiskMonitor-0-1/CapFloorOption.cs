using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CapFloorOption : ISerialized
    {
        public CapFloorOption() { }
        public CapFloorOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode capOptionNode = xmlNode.SelectSingleNode("capOption");
            
            if (capOptionNode != null)
            {
                if (capOptionNode.Attributes["href"] != null || capOptionNode.Attributes["id"] != null) 
                {
                    if (capOptionNode.Attributes["id"] != null) 
                    {
                        capOptionIDRef_ = capOptionNode.Attributes["id"].Value;
                        CapOption ob = new CapOption(capOptionNode);
                        IDManager.SetID(capOptionIDRef_, ob);
                    }
                    else if (capOptionNode.Attributes["href"] != null)
                    {
                        capOptionIDRef_ = capOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        capOption_ = new CapOption(capOptionNode);
                    }
                }
                else
                {
                    capOption_ = new CapOption(capOptionNode);
                }
            }
            
        
            XmlNode floorOptionNode = xmlNode.SelectSingleNode("floorOption");
            
            if (floorOptionNode != null)
            {
                if (floorOptionNode.Attributes["href"] != null || floorOptionNode.Attributes["id"] != null) 
                {
                    if (floorOptionNode.Attributes["id"] != null) 
                    {
                        floorOptionIDRef_ = floorOptionNode.Attributes["id"].Value;
                        FloorOption ob = new FloorOption(floorOptionNode);
                        IDManager.SetID(floorOptionIDRef_, ob);
                    }
                    else if (floorOptionNode.Attributes["href"] != null)
                    {
                        floorOptionIDRef_ = floorOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floorOption_ = new FloorOption(floorOptionNode);
                    }
                }
                else
                {
                    floorOption_ = new FloorOption(floorOptionNode);
                }
            }
            
        
        }
        
    
        #region CapOption_
        private CapOption capOption_;
        public CapOption CapOption_
        {
            get
            {
                if (this.capOption_ != null)
                {
                    return this.capOption_; 
                }
                else if (this.capOptionIDRef_ != null)
                {
                    capOption_ = IDManager.getID(capOptionIDRef_) as CapOption;
                    return this.capOption_; 
                }
                else
                {
                    throw new Exception( "capOption_Node no exist!");
                }
            }
            set
            {
                if (this.capOption_ != value)
                {
                    this.capOption_ = value;
                }
            }
        }
        #endregion
        
        public string capOptionIDRef_ { get; set; }
        #region FloorOption_
        private FloorOption floorOption_;
        public FloorOption FloorOption_
        {
            get
            {
                if (this.floorOption_ != null)
                {
                    return this.floorOption_; 
                }
                else if (this.floorOptionIDRef_ != null)
                {
                    floorOption_ = IDManager.getID(floorOptionIDRef_) as FloorOption;
                    return this.floorOption_; 
                }
                else
                {
                    throw new Exception( "floorOption_Node no exist!");
                }
            }
            set
            {
                if (this.floorOption_ != value)
                {
                    this.floorOption_ = value;
                }
            }
        }
        #endregion
        
        public string floorOptionIDRef_ { get; set; }
        
    
        
    
    }
    
}


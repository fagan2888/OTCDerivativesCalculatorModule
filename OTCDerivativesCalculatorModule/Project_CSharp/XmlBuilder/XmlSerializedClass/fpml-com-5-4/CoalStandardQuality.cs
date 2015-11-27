using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalStandardQuality : ISerialized
    {
        public CoalStandardQuality(XmlNode xmlNode)
        {
            XmlNode moistureNode = xmlNode.SelectSingleNode("moisture");
            
            if (moistureNode != null)
            {
                if (moistureNode.Attributes["href"] != null || moistureNode.Attributes["id"] != null) 
                {
                    if (moistureNode.Attributes["id"] != null) 
                    {
                        moistureIDRef_ = moistureNode.Attributes["id"].Value;
                        CoalAttributePercentage ob = new CoalAttributePercentage(moistureNode);
                        IDManager.SetID(moistureIDRef_, ob);
                    }
                    else if (moistureNode.Attributes["href"] != null)
                    {
                        moistureIDRef_ = moistureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        moisture_ = new CoalAttributePercentage(moistureNode);
                    }
                }
                else
                {
                    moisture_ = new CoalAttributePercentage(moistureNode);
                }
            }
            
        
            XmlNode ashNode = xmlNode.SelectSingleNode("ash");
            
            if (ashNode != null)
            {
                if (ashNode.Attributes["href"] != null || ashNode.Attributes["id"] != null) 
                {
                    if (ashNode.Attributes["id"] != null) 
                    {
                        ashIDRef_ = ashNode.Attributes["id"].Value;
                        CoalAttributePercentage ob = new CoalAttributePercentage(ashNode);
                        IDManager.SetID(ashIDRef_, ob);
                    }
                    else if (ashNode.Attributes["href"] != null)
                    {
                        ashIDRef_ = ashNode.Attributes["href"].Value;
                    }
                    else
                    {
                        ash_ = new CoalAttributePercentage(ashNode);
                    }
                }
                else
                {
                    ash_ = new CoalAttributePercentage(ashNode);
                }
            }
            
        
            XmlNode sulfurNode = xmlNode.SelectSingleNode("sulfur");
            
            if (sulfurNode != null)
            {
                if (sulfurNode.Attributes["href"] != null || sulfurNode.Attributes["id"] != null) 
                {
                    if (sulfurNode.Attributes["id"] != null) 
                    {
                        sulfurIDRef_ = sulfurNode.Attributes["id"].Value;
                        CoalAttributePercentage ob = new CoalAttributePercentage(sulfurNode);
                        IDManager.SetID(sulfurIDRef_, ob);
                    }
                    else if (sulfurNode.Attributes["href"] != null)
                    {
                        sulfurIDRef_ = sulfurNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sulfur_ = new CoalAttributePercentage(sulfurNode);
                    }
                }
                else
                {
                    sulfur_ = new CoalAttributePercentage(sulfurNode);
                }
            }
            
        
            XmlNode SO2Node = xmlNode.SelectSingleNode("SO2");
            
            if (SO2Node != null)
            {
                if (SO2Node.Attributes["href"] != null || SO2Node.Attributes["id"] != null) 
                {
                    if (SO2Node.Attributes["id"] != null) 
                    {
                        SO2IDRef_ = SO2Node.Attributes["id"].Value;
                        CoalAttributePercentage ob = new CoalAttributePercentage(SO2Node);
                        IDManager.SetID(SO2IDRef_, ob);
                    }
                    else if (SO2Node.Attributes["href"] != null)
                    {
                        SO2IDRef_ = SO2Node.Attributes["href"].Value;
                    }
                    else
                    {
                        SO2_ = new CoalAttributePercentage(SO2Node);
                    }
                }
                else
                {
                    SO2_ = new CoalAttributePercentage(SO2Node);
                }
            }
            
        
            XmlNode volatileNode = xmlNode.SelectSingleNode("volatile");
            
            if (volatileNode != null)
            {
                if (volatileNode.Attributes["href"] != null || volatileNode.Attributes["id"] != null) 
                {
                    if (volatileNode.Attributes["id"] != null) 
                    {
                        volatileIDRef_ = volatileNode.Attributes["id"].Value;
                        CoalAttributePercentage ob = new CoalAttributePercentage(volatileNode);
                        IDManager.SetID(volatileIDRef_, ob);
                    }
                    else if (volatileNode.Attributes["href"] != null)
                    {
                        volatileIDRef_ = volatileNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatile_ = new CoalAttributePercentage(volatileNode);
                    }
                }
                else
                {
                    volatile_ = new CoalAttributePercentage(volatileNode);
                }
            }
            
        
            XmlNode BTUperLBNode = xmlNode.SelectSingleNode("BTUperLB");
            
            if (BTUperLBNode != null)
            {
                if (BTUperLBNode.Attributes["href"] != null || BTUperLBNode.Attributes["id"] != null) 
                {
                    if (BTUperLBNode.Attributes["id"] != null) 
                    {
                        BTUperLBIDRef_ = BTUperLBNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(BTUperLBNode);
                        IDManager.SetID(BTUperLBIDRef_, ob);
                    }
                    else if (BTUperLBNode.Attributes["href"] != null)
                    {
                        BTUperLBIDRef_ = BTUperLBNode.Attributes["href"].Value;
                    }
                    else
                    {
                        BTUperLB_ = new CoalAttributeDecimal(BTUperLBNode);
                    }
                }
                else
                {
                    BTUperLB_ = new CoalAttributeDecimal(BTUperLBNode);
                }
            }
            
        
            XmlNode topSizeNode = xmlNode.SelectSingleNode("topSize");
            
            if (topSizeNode != null)
            {
                if (topSizeNode.Attributes["href"] != null || topSizeNode.Attributes["id"] != null) 
                {
                    if (topSizeNode.Attributes["id"] != null) 
                    {
                        topSizeIDRef_ = topSizeNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(topSizeNode);
                        IDManager.SetID(topSizeIDRef_, ob);
                    }
                    else if (topSizeNode.Attributes["href"] != null)
                    {
                        topSizeIDRef_ = topSizeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        topSize_ = new CoalAttributeDecimal(topSizeNode);
                    }
                }
                else
                {
                    topSize_ = new CoalAttributeDecimal(topSizeNode);
                }
            }
            
        
            XmlNode finesPassingScreenNode = xmlNode.SelectSingleNode("finesPassingScreen");
            
            if (finesPassingScreenNode != null)
            {
                if (finesPassingScreenNode.Attributes["href"] != null || finesPassingScreenNode.Attributes["id"] != null) 
                {
                    if (finesPassingScreenNode.Attributes["id"] != null) 
                    {
                        finesPassingScreenIDRef_ = finesPassingScreenNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(finesPassingScreenNode);
                        IDManager.SetID(finesPassingScreenIDRef_, ob);
                    }
                    else if (finesPassingScreenNode.Attributes["href"] != null)
                    {
                        finesPassingScreenIDRef_ = finesPassingScreenNode.Attributes["href"].Value;
                    }
                    else
                    {
                        finesPassingScreen_ = new CoalAttributeDecimal(finesPassingScreenNode);
                    }
                }
                else
                {
                    finesPassingScreen_ = new CoalAttributeDecimal(finesPassingScreenNode);
                }
            }
            
        
            XmlNode grindabilityNode = xmlNode.SelectSingleNode("grindability");
            
            if (grindabilityNode != null)
            {
                if (grindabilityNode.Attributes["href"] != null || grindabilityNode.Attributes["id"] != null) 
                {
                    if (grindabilityNode.Attributes["id"] != null) 
                    {
                        grindabilityIDRef_ = grindabilityNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(grindabilityNode);
                        IDManager.SetID(grindabilityIDRef_, ob);
                    }
                    else if (grindabilityNode.Attributes["href"] != null)
                    {
                        grindabilityIDRef_ = grindabilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        grindability_ = new CoalAttributeDecimal(grindabilityNode);
                    }
                }
                else
                {
                    grindability_ = new CoalAttributeDecimal(grindabilityNode);
                }
            }
            
        
            XmlNode ashFusionTemperatureNode = xmlNode.SelectSingleNode("ashFusionTemperature");
            
            if (ashFusionTemperatureNode != null)
            {
                if (ashFusionTemperatureNode.Attributes["href"] != null || ashFusionTemperatureNode.Attributes["id"] != null) 
                {
                    if (ashFusionTemperatureNode.Attributes["id"] != null) 
                    {
                        ashFusionTemperatureIDRef_ = ashFusionTemperatureNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(ashFusionTemperatureNode);
                        IDManager.SetID(ashFusionTemperatureIDRef_, ob);
                    }
                    else if (ashFusionTemperatureNode.Attributes["href"] != null)
                    {
                        ashFusionTemperatureIDRef_ = ashFusionTemperatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        ashFusionTemperature_ = new CoalAttributeDecimal(ashFusionTemperatureNode);
                    }
                }
                else
                {
                    ashFusionTemperature_ = new CoalAttributeDecimal(ashFusionTemperatureNode);
                }
            }
            
        
            XmlNode initialDeformationNode = xmlNode.SelectSingleNode("initialDeformation");
            
            if (initialDeformationNode != null)
            {
                if (initialDeformationNode.Attributes["href"] != null || initialDeformationNode.Attributes["id"] != null) 
                {
                    if (initialDeformationNode.Attributes["id"] != null) 
                    {
                        initialDeformationIDRef_ = initialDeformationNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(initialDeformationNode);
                        IDManager.SetID(initialDeformationIDRef_, ob);
                    }
                    else if (initialDeformationNode.Attributes["href"] != null)
                    {
                        initialDeformationIDRef_ = initialDeformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialDeformation_ = new CoalAttributeDecimal(initialDeformationNode);
                    }
                }
                else
                {
                    initialDeformation_ = new CoalAttributeDecimal(initialDeformationNode);
                }
            }
            
        
            XmlNode softeningHeightWidthNode = xmlNode.SelectSingleNode("softeningHeightWidth");
            
            if (softeningHeightWidthNode != null)
            {
                if (softeningHeightWidthNode.Attributes["href"] != null || softeningHeightWidthNode.Attributes["id"] != null) 
                {
                    if (softeningHeightWidthNode.Attributes["id"] != null) 
                    {
                        softeningHeightWidthIDRef_ = softeningHeightWidthNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(softeningHeightWidthNode);
                        IDManager.SetID(softeningHeightWidthIDRef_, ob);
                    }
                    else if (softeningHeightWidthNode.Attributes["href"] != null)
                    {
                        softeningHeightWidthIDRef_ = softeningHeightWidthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        softeningHeightWidth_ = new CoalAttributeDecimal(softeningHeightWidthNode);
                    }
                }
                else
                {
                    softeningHeightWidth_ = new CoalAttributeDecimal(softeningHeightWidthNode);
                }
            }
            
        
            XmlNode softeningHeightHalfWidthNode = xmlNode.SelectSingleNode("softeningHeightHalfWidth");
            
            if (softeningHeightHalfWidthNode != null)
            {
                if (softeningHeightHalfWidthNode.Attributes["href"] != null || softeningHeightHalfWidthNode.Attributes["id"] != null) 
                {
                    if (softeningHeightHalfWidthNode.Attributes["id"] != null) 
                    {
                        softeningHeightHalfWidthIDRef_ = softeningHeightHalfWidthNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(softeningHeightHalfWidthNode);
                        IDManager.SetID(softeningHeightHalfWidthIDRef_, ob);
                    }
                    else if (softeningHeightHalfWidthNode.Attributes["href"] != null)
                    {
                        softeningHeightHalfWidthIDRef_ = softeningHeightHalfWidthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        softeningHeightHalfWidth_ = new CoalAttributeDecimal(softeningHeightHalfWidthNode);
                    }
                }
                else
                {
                    softeningHeightHalfWidth_ = new CoalAttributeDecimal(softeningHeightHalfWidthNode);
                }
            }
            
        
            XmlNode fluidNode = xmlNode.SelectSingleNode("fluid");
            
            if (fluidNode != null)
            {
                if (fluidNode.Attributes["href"] != null || fluidNode.Attributes["id"] != null) 
                {
                    if (fluidNode.Attributes["id"] != null) 
                    {
                        fluidIDRef_ = fluidNode.Attributes["id"].Value;
                        CoalAttributeDecimal ob = new CoalAttributeDecimal(fluidNode);
                        IDManager.SetID(fluidIDRef_, ob);
                    }
                    else if (fluidNode.Attributes["href"] != null)
                    {
                        fluidIDRef_ = fluidNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fluid_ = new CoalAttributeDecimal(fluidNode);
                    }
                }
                else
                {
                    fluid_ = new CoalAttributeDecimal(fluidNode);
                }
            }
            
        
        }
        
    
        #region Moisture_
        private CoalAttributePercentage moisture_;
        public CoalAttributePercentage Moisture_
        {
            get
            {
                if (this.moisture_ != null)
                {
                    return this.moisture_; 
                }
                else if (this.moistureIDRef_ != null)
                {
                    moisture_ = IDManager.getID(moistureIDRef_) as CoalAttributePercentage;
                    return this.moisture_; 
                }
                else
                {
                      return this.moisture_; 
                }
            }
            set
            {
                if (this.moisture_ != value)
                {
                    this.moisture_ = value;
                }
            }
        }
        #endregion
        
        public string moistureIDRef_ { get; set; }
        #region Ash_
        private CoalAttributePercentage ash_;
        public CoalAttributePercentage Ash_
        {
            get
            {
                if (this.ash_ != null)
                {
                    return this.ash_; 
                }
                else if (this.ashIDRef_ != null)
                {
                    ash_ = IDManager.getID(ashIDRef_) as CoalAttributePercentage;
                    return this.ash_; 
                }
                else
                {
                      return this.ash_; 
                }
            }
            set
            {
                if (this.ash_ != value)
                {
                    this.ash_ = value;
                }
            }
        }
        #endregion
        
        public string ashIDRef_ { get; set; }
        #region Sulfur_
        private CoalAttributePercentage sulfur_;
        public CoalAttributePercentage Sulfur_
        {
            get
            {
                if (this.sulfur_ != null)
                {
                    return this.sulfur_; 
                }
                else if (this.sulfurIDRef_ != null)
                {
                    sulfur_ = IDManager.getID(sulfurIDRef_) as CoalAttributePercentage;
                    return this.sulfur_; 
                }
                else
                {
                      return this.sulfur_; 
                }
            }
            set
            {
                if (this.sulfur_ != value)
                {
                    this.sulfur_ = value;
                }
            }
        }
        #endregion
        
        public string sulfurIDRef_ { get; set; }
        #region SO2_
        private CoalAttributePercentage SO2_;
        public CoalAttributePercentage SO2_
        {
            get
            {
                if (this.SO2_ != null)
                {
                    return this.SO2_; 
                }
                else if (this.SO2IDRef_ != null)
                {
                    SO2_ = IDManager.getID(SO2IDRef_) as CoalAttributePercentage;
                    return this.SO2_; 
                }
                else
                {
                      return this.SO2_; 
                }
            }
            set
            {
                if (this.SO2_ != value)
                {
                    this.SO2_ = value;
                }
            }
        }
        #endregion
        
        public string SO2IDRef_ { get; set; }
        #region Volatile_
        private CoalAttributePercentage volatile_;
        public CoalAttributePercentage Volatile_
        {
            get
            {
                if (this.volatile_ != null)
                {
                    return this.volatile_; 
                }
                else if (this.volatileIDRef_ != null)
                {
                    volatile_ = IDManager.getID(volatileIDRef_) as CoalAttributePercentage;
                    return this.volatile_; 
                }
                else
                {
                      return this.volatile_; 
                }
            }
            set
            {
                if (this.volatile_ != value)
                {
                    this.volatile_ = value;
                }
            }
        }
        #endregion
        
        public string volatileIDRef_ { get; set; }
        #region BTUperLB_
        private CoalAttributeDecimal BTUperLB_;
        public CoalAttributeDecimal BTUperLB_
        {
            get
            {
                if (this.BTUperLB_ != null)
                {
                    return this.BTUperLB_; 
                }
                else if (this.BTUperLBIDRef_ != null)
                {
                    BTUperLB_ = IDManager.getID(BTUperLBIDRef_) as CoalAttributeDecimal;
                    return this.BTUperLB_; 
                }
                else
                {
                      return this.BTUperLB_; 
                }
            }
            set
            {
                if (this.BTUperLB_ != value)
                {
                    this.BTUperLB_ = value;
                }
            }
        }
        #endregion
        
        public string BTUperLBIDRef_ { get; set; }
        #region TopSize_
        private CoalAttributeDecimal topSize_;
        public CoalAttributeDecimal TopSize_
        {
            get
            {
                if (this.topSize_ != null)
                {
                    return this.topSize_; 
                }
                else if (this.topSizeIDRef_ != null)
                {
                    topSize_ = IDManager.getID(topSizeIDRef_) as CoalAttributeDecimal;
                    return this.topSize_; 
                }
                else
                {
                      return this.topSize_; 
                }
            }
            set
            {
                if (this.topSize_ != value)
                {
                    this.topSize_ = value;
                }
            }
        }
        #endregion
        
        public string topSizeIDRef_ { get; set; }
        #region FinesPassingScreen_
        private CoalAttributeDecimal finesPassingScreen_;
        public CoalAttributeDecimal FinesPassingScreen_
        {
            get
            {
                if (this.finesPassingScreen_ != null)
                {
                    return this.finesPassingScreen_; 
                }
                else if (this.finesPassingScreenIDRef_ != null)
                {
                    finesPassingScreen_ = IDManager.getID(finesPassingScreenIDRef_) as CoalAttributeDecimal;
                    return this.finesPassingScreen_; 
                }
                else
                {
                      return this.finesPassingScreen_; 
                }
            }
            set
            {
                if (this.finesPassingScreen_ != value)
                {
                    this.finesPassingScreen_ = value;
                }
            }
        }
        #endregion
        
        public string finesPassingScreenIDRef_ { get; set; }
        #region Grindability_
        private CoalAttributeDecimal grindability_;
        public CoalAttributeDecimal Grindability_
        {
            get
            {
                if (this.grindability_ != null)
                {
                    return this.grindability_; 
                }
                else if (this.grindabilityIDRef_ != null)
                {
                    grindability_ = IDManager.getID(grindabilityIDRef_) as CoalAttributeDecimal;
                    return this.grindability_; 
                }
                else
                {
                      return this.grindability_; 
                }
            }
            set
            {
                if (this.grindability_ != value)
                {
                    this.grindability_ = value;
                }
            }
        }
        #endregion
        
        public string grindabilityIDRef_ { get; set; }
        #region AshFusionTemperature_
        private CoalAttributeDecimal ashFusionTemperature_;
        public CoalAttributeDecimal AshFusionTemperature_
        {
            get
            {
                if (this.ashFusionTemperature_ != null)
                {
                    return this.ashFusionTemperature_; 
                }
                else if (this.ashFusionTemperatureIDRef_ != null)
                {
                    ashFusionTemperature_ = IDManager.getID(ashFusionTemperatureIDRef_) as CoalAttributeDecimal;
                    return this.ashFusionTemperature_; 
                }
                else
                {
                      return this.ashFusionTemperature_; 
                }
            }
            set
            {
                if (this.ashFusionTemperature_ != value)
                {
                    this.ashFusionTemperature_ = value;
                }
            }
        }
        #endregion
        
        public string ashFusionTemperatureIDRef_ { get; set; }
        #region InitialDeformation_
        private CoalAttributeDecimal initialDeformation_;
        public CoalAttributeDecimal InitialDeformation_
        {
            get
            {
                if (this.initialDeformation_ != null)
                {
                    return this.initialDeformation_; 
                }
                else if (this.initialDeformationIDRef_ != null)
                {
                    initialDeformation_ = IDManager.getID(initialDeformationIDRef_) as CoalAttributeDecimal;
                    return this.initialDeformation_; 
                }
                else
                {
                      return this.initialDeformation_; 
                }
            }
            set
            {
                if (this.initialDeformation_ != value)
                {
                    this.initialDeformation_ = value;
                }
            }
        }
        #endregion
        
        public string initialDeformationIDRef_ { get; set; }
        #region SofteningHeightWidth_
        private CoalAttributeDecimal softeningHeightWidth_;
        public CoalAttributeDecimal SofteningHeightWidth_
        {
            get
            {
                if (this.softeningHeightWidth_ != null)
                {
                    return this.softeningHeightWidth_; 
                }
                else if (this.softeningHeightWidthIDRef_ != null)
                {
                    softeningHeightWidth_ = IDManager.getID(softeningHeightWidthIDRef_) as CoalAttributeDecimal;
                    return this.softeningHeightWidth_; 
                }
                else
                {
                      return this.softeningHeightWidth_; 
                }
            }
            set
            {
                if (this.softeningHeightWidth_ != value)
                {
                    this.softeningHeightWidth_ = value;
                }
            }
        }
        #endregion
        
        public string softeningHeightWidthIDRef_ { get; set; }
        #region SofteningHeightHalfWidth_
        private CoalAttributeDecimal softeningHeightHalfWidth_;
        public CoalAttributeDecimal SofteningHeightHalfWidth_
        {
            get
            {
                if (this.softeningHeightHalfWidth_ != null)
                {
                    return this.softeningHeightHalfWidth_; 
                }
                else if (this.softeningHeightHalfWidthIDRef_ != null)
                {
                    softeningHeightHalfWidth_ = IDManager.getID(softeningHeightHalfWidthIDRef_) as CoalAttributeDecimal;
                    return this.softeningHeightHalfWidth_; 
                }
                else
                {
                      return this.softeningHeightHalfWidth_; 
                }
            }
            set
            {
                if (this.softeningHeightHalfWidth_ != value)
                {
                    this.softeningHeightHalfWidth_ = value;
                }
            }
        }
        #endregion
        
        public string softeningHeightHalfWidthIDRef_ { get; set; }
        #region Fluid_
        private CoalAttributeDecimal fluid_;
        public CoalAttributeDecimal Fluid_
        {
            get
            {
                if (this.fluid_ != null)
                {
                    return this.fluid_; 
                }
                else if (this.fluidIDRef_ != null)
                {
                    fluid_ = IDManager.getID(fluidIDRef_) as CoalAttributeDecimal;
                    return this.fluid_; 
                }
                else
                {
                      return this.fluid_; 
                }
            }
            set
            {
                if (this.fluid_ != value)
                {
                    this.fluid_ = value;
                }
            }
        }
        #endregion
        
        public string fluidIDRef_ { get; set; }
        
    
        
    
    }
    
}


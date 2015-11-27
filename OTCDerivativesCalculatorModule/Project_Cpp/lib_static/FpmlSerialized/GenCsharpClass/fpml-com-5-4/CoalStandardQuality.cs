using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalStandardQuality
    {
        public CoalStandardQuality(XmlNode xmlNode)
        {
            XmlNodeList moistureNodeList = xmlNode.SelectNodes("moisture");
            if (moistureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in moistureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        moistureIDRef = item.Attributes["id"].Name;
                        CoalAttributePercentage ob = CoalAttributePercentage();
                        IDManager.SetID(moistureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        moistureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        moisture = new CoalAttributePercentage(item);
                    }
                }
            }
            
        
            XmlNodeList ashNodeList = xmlNode.SelectNodes("ash");
            if (ashNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in ashNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        ashIDRef = item.Attributes["id"].Name;
                        CoalAttributePercentage ob = CoalAttributePercentage();
                        IDManager.SetID(ashIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        ashIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        ash = new CoalAttributePercentage(item);
                    }
                }
            }
            
        
            XmlNodeList sulfurNodeList = xmlNode.SelectNodes("sulfur");
            if (sulfurNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sulfurNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sulfurIDRef = item.Attributes["id"].Name;
                        CoalAttributePercentage ob = CoalAttributePercentage();
                        IDManager.SetID(sulfurIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sulfurIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sulfur = new CoalAttributePercentage(item);
                    }
                }
            }
            
        
            XmlNodeList SO2NodeList = xmlNode.SelectNodes("SO2");
            if (SO2NodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in SO2NodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        SO2IDRef = item.Attributes["id"].Name;
                        CoalAttributePercentage ob = CoalAttributePercentage();
                        IDManager.SetID(SO2IDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        SO2IDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        SO2 = new CoalAttributePercentage(item);
                    }
                }
            }
            
        
            XmlNodeList volatileNodeList = xmlNode.SelectNodes("volatile");
            if (volatileNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in volatileNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        volatileIDRef = item.Attributes["id"].Name;
                        CoalAttributePercentage ob = CoalAttributePercentage();
                        IDManager.SetID(volatileIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        volatileIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        volatile = new CoalAttributePercentage(item);
                    }
                }
            }
            
        
            XmlNodeList BTUperLBNodeList = xmlNode.SelectNodes("BTUperLB");
            if (BTUperLBNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in BTUperLBNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        BTUperLBIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(BTUperLBIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        BTUperLBIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        BTUperLB = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList topSizeNodeList = xmlNode.SelectNodes("topSize");
            if (topSizeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in topSizeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        topSizeIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(topSizeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        topSizeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        topSize = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList finesPassingScreenNodeList = xmlNode.SelectNodes("finesPassingScreen");
            if (finesPassingScreenNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in finesPassingScreenNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        finesPassingScreenIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(finesPassingScreenIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        finesPassingScreenIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        finesPassingScreen = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList grindabilityNodeList = xmlNode.SelectNodes("grindability");
            if (grindabilityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in grindabilityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        grindabilityIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(grindabilityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        grindabilityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        grindability = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList ashFusionTemperatureNodeList = xmlNode.SelectNodes("ashFusionTemperature");
            if (ashFusionTemperatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in ashFusionTemperatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        ashFusionTemperatureIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(ashFusionTemperatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        ashFusionTemperatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        ashFusionTemperature = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList initialDeformationNodeList = xmlNode.SelectNodes("initialDeformation");
            if (initialDeformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialDeformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialDeformationIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(initialDeformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialDeformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialDeformation = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList softeningHeightWidthNodeList = xmlNode.SelectNodes("softeningHeightWidth");
            if (softeningHeightWidthNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in softeningHeightWidthNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        softeningHeightWidthIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(softeningHeightWidthIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        softeningHeightWidthIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        softeningHeightWidth = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList softeningHeightHalfWidthNodeList = xmlNode.SelectNodes("softeningHeightHalfWidth");
            if (softeningHeightHalfWidthNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in softeningHeightHalfWidthNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        softeningHeightHalfWidthIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(softeningHeightHalfWidthIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        softeningHeightHalfWidthIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        softeningHeightHalfWidth = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fluidNodeList = xmlNode.SelectNodes("fluid");
            if (fluidNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fluidNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fluidIDRef = item.Attributes["id"].Name;
                        CoalAttributeDecimal ob = CoalAttributeDecimal();
                        IDManager.SetID(fluidIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fluidIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fluid = new CoalAttributeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Moisture
        private CoalAttributePercentage moisture;
        public CoalAttributePercentage Moisture
        {
            get
            {
                if (this.moisture != null)
                {
                    return this.moisture; 
                }
                else if (this.moistureIDRef != null)
                {
                    moisture = IDManager.getID(moistureIDRef) as CoalAttributePercentage;
                    return this.moisture; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.moisture != value)
                {
                    this.moisture = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributePercentageIDRef { get; set; }
        #region Ash
        private CoalAttributePercentage ash;
        public CoalAttributePercentage Ash
        {
            get
            {
                if (this.ash != null)
                {
                    return this.ash; 
                }
                else if (this.ashIDRef != null)
                {
                    ash = IDManager.getID(ashIDRef) as CoalAttributePercentage;
                    return this.ash; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.ash != value)
                {
                    this.ash = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributePercentageIDRef { get; set; }
        #region Sulfur
        private CoalAttributePercentage sulfur;
        public CoalAttributePercentage Sulfur
        {
            get
            {
                if (this.sulfur != null)
                {
                    return this.sulfur; 
                }
                else if (this.sulfurIDRef != null)
                {
                    sulfur = IDManager.getID(sulfurIDRef) as CoalAttributePercentage;
                    return this.sulfur; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sulfur != value)
                {
                    this.sulfur = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributePercentageIDRef { get; set; }
        #region SO2
        private CoalAttributePercentage SO2;
        public CoalAttributePercentage SO2
        {
            get
            {
                if (this.SO2 != null)
                {
                    return this.SO2; 
                }
                else if (this.SO2IDRef != null)
                {
                    SO2 = IDManager.getID(SO2IDRef) as CoalAttributePercentage;
                    return this.SO2; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.SO2 != value)
                {
                    this.SO2 = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributePercentageIDRef { get; set; }
        #region Volatile
        private CoalAttributePercentage volatile;
        public CoalAttributePercentage Volatile
        {
            get
            {
                if (this.volatile != null)
                {
                    return this.volatile; 
                }
                else if (this.volatileIDRef != null)
                {
                    volatile = IDManager.getID(volatileIDRef) as CoalAttributePercentage;
                    return this.volatile; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.volatile != value)
                {
                    this.volatile = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributePercentageIDRef { get; set; }
        #region BTUperLB
        private CoalAttributeDecimal BTUperLB;
        public CoalAttributeDecimal BTUperLB
        {
            get
            {
                if (this.BTUperLB != null)
                {
                    return this.BTUperLB; 
                }
                else if (this.BTUperLBIDRef != null)
                {
                    BTUperLB = IDManager.getID(BTUperLBIDRef) as CoalAttributeDecimal;
                    return this.BTUperLB; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.BTUperLB != value)
                {
                    this.BTUperLB = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region TopSize
        private CoalAttributeDecimal topSize;
        public CoalAttributeDecimal TopSize
        {
            get
            {
                if (this.topSize != null)
                {
                    return this.topSize; 
                }
                else if (this.topSizeIDRef != null)
                {
                    topSize = IDManager.getID(topSizeIDRef) as CoalAttributeDecimal;
                    return this.topSize; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.topSize != value)
                {
                    this.topSize = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region FinesPassingScreen
        private CoalAttributeDecimal finesPassingScreen;
        public CoalAttributeDecimal FinesPassingScreen
        {
            get
            {
                if (this.finesPassingScreen != null)
                {
                    return this.finesPassingScreen; 
                }
                else if (this.finesPassingScreenIDRef != null)
                {
                    finesPassingScreen = IDManager.getID(finesPassingScreenIDRef) as CoalAttributeDecimal;
                    return this.finesPassingScreen; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.finesPassingScreen != value)
                {
                    this.finesPassingScreen = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region Grindability
        private CoalAttributeDecimal grindability;
        public CoalAttributeDecimal Grindability
        {
            get
            {
                if (this.grindability != null)
                {
                    return this.grindability; 
                }
                else if (this.grindabilityIDRef != null)
                {
                    grindability = IDManager.getID(grindabilityIDRef) as CoalAttributeDecimal;
                    return this.grindability; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.grindability != value)
                {
                    this.grindability = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region AshFusionTemperature
        private CoalAttributeDecimal ashFusionTemperature;
        public CoalAttributeDecimal AshFusionTemperature
        {
            get
            {
                if (this.ashFusionTemperature != null)
                {
                    return this.ashFusionTemperature; 
                }
                else if (this.ashFusionTemperatureIDRef != null)
                {
                    ashFusionTemperature = IDManager.getID(ashFusionTemperatureIDRef) as CoalAttributeDecimal;
                    return this.ashFusionTemperature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.ashFusionTemperature != value)
                {
                    this.ashFusionTemperature = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region InitialDeformation
        private CoalAttributeDecimal initialDeformation;
        public CoalAttributeDecimal InitialDeformation
        {
            get
            {
                if (this.initialDeformation != null)
                {
                    return this.initialDeformation; 
                }
                else if (this.initialDeformationIDRef != null)
                {
                    initialDeformation = IDManager.getID(initialDeformationIDRef) as CoalAttributeDecimal;
                    return this.initialDeformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialDeformation != value)
                {
                    this.initialDeformation = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region SofteningHeightWidth
        private CoalAttributeDecimal softeningHeightWidth;
        public CoalAttributeDecimal SofteningHeightWidth
        {
            get
            {
                if (this.softeningHeightWidth != null)
                {
                    return this.softeningHeightWidth; 
                }
                else if (this.softeningHeightWidthIDRef != null)
                {
                    softeningHeightWidth = IDManager.getID(softeningHeightWidthIDRef) as CoalAttributeDecimal;
                    return this.softeningHeightWidth; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.softeningHeightWidth != value)
                {
                    this.softeningHeightWidth = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region SofteningHeightHalfWidth
        private CoalAttributeDecimal softeningHeightHalfWidth;
        public CoalAttributeDecimal SofteningHeightHalfWidth
        {
            get
            {
                if (this.softeningHeightHalfWidth != null)
                {
                    return this.softeningHeightHalfWidth; 
                }
                else if (this.softeningHeightHalfWidthIDRef != null)
                {
                    softeningHeightHalfWidth = IDManager.getID(softeningHeightHalfWidthIDRef) as CoalAttributeDecimal;
                    return this.softeningHeightHalfWidth; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.softeningHeightHalfWidth != value)
                {
                    this.softeningHeightHalfWidth = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        #region Fluid
        private CoalAttributeDecimal fluid;
        public CoalAttributeDecimal Fluid
        {
            get
            {
                if (this.fluid != null)
                {
                    return this.fluid; 
                }
                else if (this.fluidIDRef != null)
                {
                    fluid = IDManager.getID(fluidIDRef) as CoalAttributeDecimal;
                    return this.fluid; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fluid != value)
                {
                    this.fluid = value;
                }
            }
        }
        #endregion
        
        public string CoalAttributeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}


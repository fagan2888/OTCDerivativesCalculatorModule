using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingStructureValuation : Valuation
    {
        public PricingStructureValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode baseDateNode = xmlNode.SelectSingleNode("baseDate");
            
            if (baseDateNode != null)
            {
                if (baseDateNode.Attributes["href"] != null || baseDateNode.Attributes["id"] != null) 
                {
                    if (baseDateNode.Attributes["id"] != null) 
                    {
                        baseDateIDRef_ = baseDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(baseDateNode);
                        IDManager.SetID(baseDateIDRef_, ob);
                    }
                    else if (baseDateNode.Attributes["href"] != null)
                    {
                        baseDateIDRef_ = baseDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseDate_ = new IdentifiedDate(baseDateNode);
                    }
                }
                else
                {
                    baseDate_ = new IdentifiedDate(baseDateNode);
                }
            }
            
        
            XmlNode spotDateNode = xmlNode.SelectSingleNode("spotDate");
            
            if (spotDateNode != null)
            {
                if (spotDateNode.Attributes["href"] != null || spotDateNode.Attributes["id"] != null) 
                {
                    if (spotDateNode.Attributes["id"] != null) 
                    {
                        spotDateIDRef_ = spotDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(spotDateNode);
                        IDManager.SetID(spotDateIDRef_, ob);
                    }
                    else if (spotDateNode.Attributes["href"] != null)
                    {
                        spotDateIDRef_ = spotDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotDate_ = new IdentifiedDate(spotDateNode);
                    }
                }
                else
                {
                    spotDate_ = new IdentifiedDate(spotDateNode);
                }
            }
            
        
            XmlNode inputDataDateNode = xmlNode.SelectSingleNode("inputDataDate");
            
            if (inputDataDateNode != null)
            {
                if (inputDataDateNode.Attributes["href"] != null || inputDataDateNode.Attributes["id"] != null) 
                {
                    if (inputDataDateNode.Attributes["id"] != null) 
                    {
                        inputDataDateIDRef_ = inputDataDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(inputDataDateNode);
                        IDManager.SetID(inputDataDateIDRef_, ob);
                    }
                    else if (inputDataDateNode.Attributes["href"] != null)
                    {
                        inputDataDateIDRef_ = inputDataDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inputDataDate_ = new IdentifiedDate(inputDataDateNode);
                    }
                }
                else
                {
                    inputDataDate_ = new IdentifiedDate(inputDataDateNode);
                }
            }
            
        
            XmlNode endDateNode = xmlNode.SelectSingleNode("endDate");
            
            if (endDateNode != null)
            {
                if (endDateNode.Attributes["href"] != null || endDateNode.Attributes["id"] != null) 
                {
                    if (endDateNode.Attributes["id"] != null) 
                    {
                        endDateIDRef_ = endDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(endDateNode);
                        IDManager.SetID(endDateIDRef_, ob);
                    }
                    else if (endDateNode.Attributes["href"] != null)
                    {
                        endDateIDRef_ = endDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endDate_ = new IdentifiedDate(endDateNode);
                    }
                }
                else
                {
                    endDate_ = new IdentifiedDate(endDateNode);
                }
            }
            
        
            XmlNode buildDateTimeNode = xmlNode.SelectSingleNode("buildDateTime");
            
            if (buildDateTimeNode != null)
            {
                if (buildDateTimeNode.Attributes["href"] != null || buildDateTimeNode.Attributes["id"] != null) 
                {
                    if (buildDateTimeNode.Attributes["id"] != null) 
                    {
                        buildDateTimeIDRef_ = buildDateTimeNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(buildDateTimeNode);
                        IDManager.SetID(buildDateTimeIDRef_, ob);
                    }
                    else if (buildDateTimeNode.Attributes["href"] != null)
                    {
                        buildDateTimeIDRef_ = buildDateTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buildDateTime_ = new XsdTypeDateTime(buildDateTimeNode);
                    }
                }
                else
                {
                    buildDateTime_ = new XsdTypeDateTime(buildDateTimeNode);
                }
            }
            
        
        }
        
    
        #region BaseDate_
        private IdentifiedDate baseDate_;
        public IdentifiedDate BaseDate_
        {
            get
            {
                if (this.baseDate_ != null)
                {
                    return this.baseDate_; 
                }
                else if (this.baseDateIDRef_ != null)
                {
                    baseDate_ = IDManager.getID(baseDateIDRef_) as IdentifiedDate;
                    return this.baseDate_; 
                }
                else
                {
                      return this.baseDate_; 
                }
            }
            set
            {
                if (this.baseDate_ != value)
                {
                    this.baseDate_ = value;
                }
            }
        }
        #endregion
        
        public string baseDateIDRef_ { get; set; }
        #region SpotDate_
        private IdentifiedDate spotDate_;
        public IdentifiedDate SpotDate_
        {
            get
            {
                if (this.spotDate_ != null)
                {
                    return this.spotDate_; 
                }
                else if (this.spotDateIDRef_ != null)
                {
                    spotDate_ = IDManager.getID(spotDateIDRef_) as IdentifiedDate;
                    return this.spotDate_; 
                }
                else
                {
                      return this.spotDate_; 
                }
            }
            set
            {
                if (this.spotDate_ != value)
                {
                    this.spotDate_ = value;
                }
            }
        }
        #endregion
        
        public string spotDateIDRef_ { get; set; }
        #region InputDataDate_
        private IdentifiedDate inputDataDate_;
        public IdentifiedDate InputDataDate_
        {
            get
            {
                if (this.inputDataDate_ != null)
                {
                    return this.inputDataDate_; 
                }
                else if (this.inputDataDateIDRef_ != null)
                {
                    inputDataDate_ = IDManager.getID(inputDataDateIDRef_) as IdentifiedDate;
                    return this.inputDataDate_; 
                }
                else
                {
                      return this.inputDataDate_; 
                }
            }
            set
            {
                if (this.inputDataDate_ != value)
                {
                    this.inputDataDate_ = value;
                }
            }
        }
        #endregion
        
        public string inputDataDateIDRef_ { get; set; }
        #region EndDate_
        private IdentifiedDate endDate_;
        public IdentifiedDate EndDate_
        {
            get
            {
                if (this.endDate_ != null)
                {
                    return this.endDate_; 
                }
                else if (this.endDateIDRef_ != null)
                {
                    endDate_ = IDManager.getID(endDateIDRef_) as IdentifiedDate;
                    return this.endDate_; 
                }
                else
                {
                      return this.endDate_; 
                }
            }
            set
            {
                if (this.endDate_ != value)
                {
                    this.endDate_ = value;
                }
            }
        }
        #endregion
        
        public string endDateIDRef_ { get; set; }
        #region BuildDateTime_
        private XsdTypeDateTime buildDateTime_;
        public XsdTypeDateTime BuildDateTime_
        {
            get
            {
                if (this.buildDateTime_ != null)
                {
                    return this.buildDateTime_; 
                }
                else if (this.buildDateTimeIDRef_ != null)
                {
                    buildDateTime_ = IDManager.getID(buildDateTimeIDRef_) as XsdTypeDateTime;
                    return this.buildDateTime_; 
                }
                else
                {
                      return this.buildDateTime_; 
                }
            }
            set
            {
                if (this.buildDateTime_ != value)
                {
                    this.buildDateTime_ = value;
                }
            }
        }
        #endregion
        
        public string buildDateTimeIDRef_ { get; set; }
        
    
        
    
    }
    
}


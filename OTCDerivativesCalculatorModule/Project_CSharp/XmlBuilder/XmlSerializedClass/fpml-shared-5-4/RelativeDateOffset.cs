using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RelativeDateOffset : Offset
    {
        public RelativeDateOffset(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode businessDayConventionNode = xmlNode.SelectSingleNode("businessDayConvention");
            
            if (businessDayConventionNode != null)
            {
                if (businessDayConventionNode.Attributes["href"] != null || businessDayConventionNode.Attributes["id"] != null) 
                {
                    if (businessDayConventionNode.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["id"].Value;
                        BusinessDayConventionEnum ob = new BusinessDayConventionEnum(businessDayConventionNode);
                        IDManager.SetID(businessDayConventionIDRef_, ob);
                    }
                    else if (businessDayConventionNode.Attributes["href"] != null)
                    {
                        businessDayConventionIDRef_ = businessDayConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDayConvention_ = new BusinessDayConventionEnum(businessDayConventionNode);
                    }
                }
                else
                {
                    businessDayConvention_ = new BusinessDayConventionEnum(businessDayConventionNode);
                }
            }
            
        
            XmlNode businessCentersReferenceNode = xmlNode.SelectSingleNode("businessCentersReference");
            
            if (businessCentersReferenceNode != null)
            {
                if (businessCentersReferenceNode.Attributes["href"] != null || businessCentersReferenceNode.Attributes["id"] != null) 
                {
                    if (businessCentersReferenceNode.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["id"].Value;
                        BusinessCentersReference ob = new BusinessCentersReference(businessCentersReferenceNode);
                        IDManager.SetID(businessCentersReferenceIDRef_, ob);
                    }
                    else if (businessCentersReferenceNode.Attributes["href"] != null)
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                    }
                }
                else
                {
                    businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                }
            }
            
        
            XmlNode businessCentersNode = xmlNode.SelectSingleNode("businessCenters");
            
            if (businessCentersNode != null)
            {
                if (businessCentersNode.Attributes["href"] != null || businessCentersNode.Attributes["id"] != null) 
                {
                    if (businessCentersNode.Attributes["id"] != null) 
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["id"].Value;
                        BusinessCenters ob = new BusinessCenters(businessCentersNode);
                        IDManager.SetID(businessCentersIDRef_, ob);
                    }
                    else if (businessCentersNode.Attributes["href"] != null)
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenters_ = new BusinessCenters(businessCentersNode);
                    }
                }
                else
                {
                    businessCenters_ = new BusinessCenters(businessCentersNode);
                }
            }
            
        
            XmlNode dateRelativeToNode = xmlNode.SelectSingleNode("dateRelativeTo");
            
            if (dateRelativeToNode != null)
            {
                if (dateRelativeToNode.Attributes["href"] != null || dateRelativeToNode.Attributes["id"] != null) 
                {
                    if (dateRelativeToNode.Attributes["id"] != null) 
                    {
                        dateRelativeToIDRef_ = dateRelativeToNode.Attributes["id"].Value;
                        DateReference ob = new DateReference(dateRelativeToNode);
                        IDManager.SetID(dateRelativeToIDRef_, ob);
                    }
                    else if (dateRelativeToNode.Attributes["href"] != null)
                    {
                        dateRelativeToIDRef_ = dateRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateRelativeTo_ = new DateReference(dateRelativeToNode);
                    }
                }
                else
                {
                    dateRelativeTo_ = new DateReference(dateRelativeToNode);
                }
            }
            
        
            XmlNode adjustedDateNode = xmlNode.SelectSingleNode("adjustedDate");
            
            if (adjustedDateNode != null)
            {
                if (adjustedDateNode.Attributes["href"] != null || adjustedDateNode.Attributes["id"] != null) 
                {
                    if (adjustedDateNode.Attributes["id"] != null) 
                    {
                        adjustedDateIDRef_ = adjustedDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(adjustedDateNode);
                        IDManager.SetID(adjustedDateIDRef_, ob);
                    }
                    else if (adjustedDateNode.Attributes["href"] != null)
                    {
                        adjustedDateIDRef_ = adjustedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedDate_ = new IdentifiedDate(adjustedDateNode);
                    }
                }
                else
                {
                    adjustedDate_ = new IdentifiedDate(adjustedDateNode);
                }
            }
            
        
        }
        
    
        #region BusinessDayConvention_
        private BusinessDayConventionEnum businessDayConvention_;
        public BusinessDayConventionEnum BusinessDayConvention_
        {
            get
            {
                if (this.businessDayConvention_ != null)
                {
                    return this.businessDayConvention_; 
                }
                else if (this.businessDayConventionIDRef_ != null)
                {
                    businessDayConvention_ = IDManager.getID(businessDayConventionIDRef_) as BusinessDayConventionEnum;
                    return this.businessDayConvention_; 
                }
                else
                {
                      return this.businessDayConvention_; 
                }
            }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                }
            }
        }
        #endregion
        
        public string businessDayConventionIDRef_ { get; set; }
        #region BusinessCentersReference_
        private BusinessCentersReference businessCentersReference_;
        public BusinessCentersReference BusinessCentersReference_
        {
            get
            {
                if (this.businessCentersReference_ != null)
                {
                    return this.businessCentersReference_; 
                }
                else if (this.businessCentersReferenceIDRef_ != null)
                {
                    businessCentersReference_ = IDManager.getID(businessCentersReferenceIDRef_) as BusinessCentersReference;
                    return this.businessCentersReference_; 
                }
                else
                {
                      return this.businessCentersReference_; 
                }
            }
            set
            {
                if (this.businessCentersReference_ != value)
                {
                    this.businessCentersReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersReferenceIDRef_ { get; set; }
        #region BusinessCenters_
        private BusinessCenters businessCenters_;
        public BusinessCenters BusinessCenters_
        {
            get
            {
                if (this.businessCenters_ != null)
                {
                    return this.businessCenters_; 
                }
                else if (this.businessCentersIDRef_ != null)
                {
                    businessCenters_ = IDManager.getID(businessCentersIDRef_) as BusinessCenters;
                    return this.businessCenters_; 
                }
                else
                {
                      return this.businessCenters_; 
                }
            }
            set
            {
                if (this.businessCenters_ != value)
                {
                    this.businessCenters_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersIDRef_ { get; set; }
        #region DateRelativeTo_
        private DateReference dateRelativeTo_;
        public DateReference DateRelativeTo_
        {
            get
            {
                if (this.dateRelativeTo_ != null)
                {
                    return this.dateRelativeTo_; 
                }
                else if (this.dateRelativeToIDRef_ != null)
                {
                    dateRelativeTo_ = IDManager.getID(dateRelativeToIDRef_) as DateReference;
                    return this.dateRelativeTo_; 
                }
                else
                {
                      return this.dateRelativeTo_; 
                }
            }
            set
            {
                if (this.dateRelativeTo_ != value)
                {
                    this.dateRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string dateRelativeToIDRef_ { get; set; }
        #region AdjustedDate_
        private IdentifiedDate adjustedDate_;
        public IdentifiedDate AdjustedDate_
        {
            get
            {
                if (this.adjustedDate_ != null)
                {
                    return this.adjustedDate_; 
                }
                else if (this.adjustedDateIDRef_ != null)
                {
                    adjustedDate_ = IDManager.getID(adjustedDateIDRef_) as IdentifiedDate;
                    return this.adjustedDate_; 
                }
                else
                {
                      return this.adjustedDate_; 
                }
            }
            set
            {
                if (this.adjustedDate_ != value)
                {
                    this.adjustedDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


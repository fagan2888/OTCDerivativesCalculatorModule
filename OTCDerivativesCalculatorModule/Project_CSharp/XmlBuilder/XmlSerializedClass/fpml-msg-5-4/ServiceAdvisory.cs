using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ServiceAdvisory : ISerialized
    {
        public ServiceAdvisory(XmlNode xmlNode)
        {
            XmlNode categoryNode = xmlNode.SelectSingleNode("category");
            
            if (categoryNode != null)
            {
                if (categoryNode.Attributes["href"] != null || categoryNode.Attributes["id"] != null) 
                {
                    if (categoryNode.Attributes["id"] != null) 
                    {
                        categoryIDRef_ = categoryNode.Attributes["id"].Value;
                        ServiceAdvisoryCategory ob = new ServiceAdvisoryCategory(categoryNode);
                        IDManager.SetID(categoryIDRef_, ob);
                    }
                    else if (categoryNode.Attributes["href"] != null)
                    {
                        categoryIDRef_ = categoryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        category_ = new ServiceAdvisoryCategory(categoryNode);
                    }
                }
                else
                {
                    category_ = new ServiceAdvisoryCategory(categoryNode);
                }
            }
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeString(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeString(descriptionNode);
                }
            }
            
        
            XmlNode effectiveFromNode = xmlNode.SelectSingleNode("effectiveFrom");
            
            if (effectiveFromNode != null)
            {
                if (effectiveFromNode.Attributes["href"] != null || effectiveFromNode.Attributes["id"] != null) 
                {
                    if (effectiveFromNode.Attributes["id"] != null) 
                    {
                        effectiveFromIDRef_ = effectiveFromNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(effectiveFromNode);
                        IDManager.SetID(effectiveFromIDRef_, ob);
                    }
                    else if (effectiveFromNode.Attributes["href"] != null)
                    {
                        effectiveFromIDRef_ = effectiveFromNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveFrom_ = new XsdTypeDateTime(effectiveFromNode);
                    }
                }
                else
                {
                    effectiveFrom_ = new XsdTypeDateTime(effectiveFromNode);
                }
            }
            
        
            XmlNode effectiveToNode = xmlNode.SelectSingleNode("effectiveTo");
            
            if (effectiveToNode != null)
            {
                if (effectiveToNode.Attributes["href"] != null || effectiveToNode.Attributes["id"] != null) 
                {
                    if (effectiveToNode.Attributes["id"] != null) 
                    {
                        effectiveToIDRef_ = effectiveToNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(effectiveToNode);
                        IDManager.SetID(effectiveToIDRef_, ob);
                    }
                    else if (effectiveToNode.Attributes["href"] != null)
                    {
                        effectiveToIDRef_ = effectiveToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveTo_ = new XsdTypeDateTime(effectiveToNode);
                    }
                }
                else
                {
                    effectiveTo_ = new XsdTypeDateTime(effectiveToNode);
                }
            }
            
        
        }
        
    
        #region Category_
        private ServiceAdvisoryCategory category_;
        public ServiceAdvisoryCategory Category_
        {
            get
            {
                if (this.category_ != null)
                {
                    return this.category_; 
                }
                else if (this.categoryIDRef_ != null)
                {
                    category_ = IDManager.getID(categoryIDRef_) as ServiceAdvisoryCategory;
                    return this.category_; 
                }
                else
                {
                      return this.category_; 
                }
            }
            set
            {
                if (this.category_ != value)
                {
                    this.category_ = value;
                }
            }
        }
        #endregion
        
        public string categoryIDRef_ { get; set; }
        #region Description_
        private XsdTypeString description_;
        public XsdTypeString Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeString;
                    return this.description_; 
                }
                else
                {
                      return this.description_; 
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        #region EffectiveFrom_
        private XsdTypeDateTime effectiveFrom_;
        public XsdTypeDateTime EffectiveFrom_
        {
            get
            {
                if (this.effectiveFrom_ != null)
                {
                    return this.effectiveFrom_; 
                }
                else if (this.effectiveFromIDRef_ != null)
                {
                    effectiveFrom_ = IDManager.getID(effectiveFromIDRef_) as XsdTypeDateTime;
                    return this.effectiveFrom_; 
                }
                else
                {
                      return this.effectiveFrom_; 
                }
            }
            set
            {
                if (this.effectiveFrom_ != value)
                {
                    this.effectiveFrom_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveFromIDRef_ { get; set; }
        #region EffectiveTo_
        private XsdTypeDateTime effectiveTo_;
        public XsdTypeDateTime EffectiveTo_
        {
            get
            {
                if (this.effectiveTo_ != null)
                {
                    return this.effectiveTo_; 
                }
                else if (this.effectiveToIDRef_ != null)
                {
                    effectiveTo_ = IDManager.getID(effectiveToIDRef_) as XsdTypeDateTime;
                    return this.effectiveTo_; 
                }
                else
                {
                      return this.effectiveTo_; 
                }
            }
            set
            {
                if (this.effectiveTo_ != value)
                {
                    this.effectiveTo_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveToIDRef_ { get; set; }
        
    
        
    
    }
    
}


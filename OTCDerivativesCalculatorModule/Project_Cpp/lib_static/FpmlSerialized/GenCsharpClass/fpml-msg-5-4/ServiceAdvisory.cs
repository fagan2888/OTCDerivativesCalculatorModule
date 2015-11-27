using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ServiceAdvisory
    {
        public ServiceAdvisory(XmlNode xmlNode)
        {
            XmlNodeList categoryNodeList = xmlNode.SelectNodes("category");
            if (categoryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in categoryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        categoryIDRef = item.Attributes["id"].Name;
                        ServiceAdvisoryCategory ob = ServiceAdvisoryCategory();
                        IDManager.SetID(categoryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        categoryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        category = new ServiceAdvisoryCategory(item);
                    }
                }
            }
            
        
            XmlNodeList descriptionNodeList = xmlNode.SelectNodes("description");
            if (descriptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in descriptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        descriptionIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(descriptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        descriptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        description = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveFromNodeList = xmlNode.SelectNodes("effectiveFrom");
            if (effectiveFromNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveFromNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveFromIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(effectiveFromIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveFromIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveFrom = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveToNodeList = xmlNode.SelectNodes("effectiveTo");
            if (effectiveToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveToIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(effectiveToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveTo = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region Category
        private ServiceAdvisoryCategory category;
        public ServiceAdvisoryCategory Category
        {
            get
            {
                if (this.category != null)
                {
                    return this.category; 
                }
                else if (this.categoryIDRef != null)
                {
                    category = IDManager.getID(categoryIDRef) as ServiceAdvisoryCategory;
                    return this.category; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.category != value)
                {
                    this.category = value;
                }
            }
        }
        #endregion
        
        public string ServiceAdvisoryCategoryIDRef { get; set; }
        #region Description
        private XsdTypeString description;
        public XsdTypeString Description
        {
            get
            {
                if (this.description != null)
                {
                    return this.description; 
                }
                else if (this.descriptionIDRef != null)
                {
                    description = IDManager.getID(descriptionIDRef) as XsdTypeString;
                    return this.description; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region EffectiveFrom
        private XsdTypeDateTime effectiveFrom;
        public XsdTypeDateTime EffectiveFrom
        {
            get
            {
                if (this.effectiveFrom != null)
                {
                    return this.effectiveFrom; 
                }
                else if (this.effectiveFromIDRef != null)
                {
                    effectiveFrom = IDManager.getID(effectiveFromIDRef) as XsdTypeDateTime;
                    return this.effectiveFrom; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveFrom != value)
                {
                    this.effectiveFrom = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region EffectiveTo
        private XsdTypeDateTime effectiveTo;
        public XsdTypeDateTime EffectiveTo
        {
            get
            {
                if (this.effectiveTo != null)
                {
                    return this.effectiveTo; 
                }
                else if (this.effectiveToIDRef != null)
                {
                    effectiveTo = IDManager.getID(effectiveToIDRef) as XsdTypeDateTime;
                    return this.effectiveTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveTo != value)
                {
                    this.effectiveTo = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BusinessDateRange
    {
        public BusinessDateRange(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList businessDayConventionNodeList = xmlNode.SelectNodes("businessDayConvention");
            if (businessDayConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDayConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef = item.Attributes["id"].Name;
                        BusinessDayConventionEnum ob = BusinessDayConventionEnum();
                        IDManager.SetID(businessDayConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDayConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDayConvention = new BusinessDayConventionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersReferenceNodeList = xmlNode.SelectNodes("businessCentersReference");
            if (businessCentersReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef = item.Attributes["id"].Name;
                        BusinessCentersReference ob = BusinessCentersReference();
                        IDManager.SetID(businessCentersReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCentersReference = new BusinessCentersReference(item);
                    }
                }
            }
            
        
            XmlNodeList businessCentersNodeList = xmlNode.SelectNodes("businessCenters");
            if (businessCentersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCentersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCentersIDRef = item.Attributes["id"].Name;
                        BusinessCenters ob = BusinessCenters();
                        IDManager.SetID(businessCentersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCentersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenters = new BusinessCenters(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessDayConvention
        private BusinessDayConventionEnum businessDayConvention;
        public BusinessDayConventionEnum BusinessDayConvention
        {
            get
            {
                if (this.businessDayConvention != null)
                {
                    return this.businessDayConvention; 
                }
                else if (this.businessDayConventionIDRef != null)
                {
                    businessDayConvention = IDManager.getID(businessDayConventionIDRef) as BusinessDayConventionEnum;
                    return this.businessDayConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDayConvention != value)
                {
                    this.businessDayConvention = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayConventionEnumIDRef { get; set; }
        #region BusinessCentersReference
        private BusinessCentersReference businessCentersReference;
        public BusinessCentersReference BusinessCentersReference
        {
            get
            {
                if (this.businessCentersReference != null)
                {
                    return this.businessCentersReference; 
                }
                else if (this.businessCentersReferenceIDRef != null)
                {
                    businessCentersReference = IDManager.getID(businessCentersReferenceIDRef) as BusinessCentersReference;
                    return this.businessCentersReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCentersReference != value)
                {
                    this.businessCentersReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersReferenceIDRef { get; set; }
        #region BusinessCenters
        private BusinessCenters businessCenters;
        public BusinessCenters BusinessCenters
        {
            get
            {
                if (this.businessCenters != null)
                {
                    return this.businessCenters; 
                }
                else if (this.businessCentersIDRef != null)
                {
                    businessCenters = IDManager.getID(businessCentersIDRef) as BusinessCenters;
                    return this.businessCenters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenters != value)
                {
                    this.businessCenters = value;
                }
            }
        }
        #endregion
        
        public string BusinessCentersIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalAttributePercentage
    {
        public CoalAttributePercentage(XmlNode xmlNode)
        {
            XmlNodeList standardContentNodeList = xmlNode.SelectNodes("standardContent");
            if (standardContentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardContentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardContentIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(standardContentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardContentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardContent = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList rejectionLimitNodeList = xmlNode.SelectNodes("rejectionLimit");
            if (rejectionLimitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rejectionLimitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rejectionLimitIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(rejectionLimitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rejectionLimitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rejectionLimit = new RestrictedPercentage(item);
                    }
                }
            }
            
        
        }
        
    
        #region StandardContent
        private RestrictedPercentage standardContent;
        public RestrictedPercentage StandardContent
        {
            get
            {
                if (this.standardContent != null)
                {
                    return this.standardContent; 
                }
                else if (this.standardContentIDRef != null)
                {
                    standardContent = IDManager.getID(standardContentIDRef) as RestrictedPercentage;
                    return this.standardContent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardContent != value)
                {
                    this.standardContent = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region RejectionLimit
        private RestrictedPercentage rejectionLimit;
        public RestrictedPercentage RejectionLimit
        {
            get
            {
                if (this.rejectionLimit != null)
                {
                    return this.rejectionLimit; 
                }
                else if (this.rejectionLimitIDRef != null)
                {
                    rejectionLimit = IDManager.getID(rejectionLimitIDRef) as RestrictedPercentage;
                    return this.rejectionLimit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rejectionLimit != value)
                {
                    this.rejectionLimit = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


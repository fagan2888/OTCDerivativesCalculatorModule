using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BusinessCenters
    {
        public BusinessCenters(XmlNode xmlNode)
        {
            XmlNodeList businessCenterNodeList = xmlNode.SelectNodes("businessCenter");
            
            foreach (XmlNode item in businessCenterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCenterIDRef = item.Attributes["id"].Name;
                        List<BusinessCenter> ob = new List<BusinessCenter>();
                        ob.Add(new BusinessCenter(item));
                        IDManager.SetID(businessCenterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCenterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    businessCenter.Add(new BusinessCenter(item));
                    }
                }
            }
            
        
        }
        
    
        #region BusinessCenter
        private List<BusinessCenter> businessCenter;
        public List<BusinessCenter> BusinessCenter
        {
            get
            {
                if (this.businessCenter != null)
                {
                    return this.businessCenter; 
                }
                else if (this.businessCenterIDRef != null)
                {
                    businessCenter = IDManager.getID(businessCenterIDRef) as List<BusinessCenter>;
                    return this.businessCenter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenter != value)
                {
                    this.businessCenter = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        
    
        
    
    }
    
}


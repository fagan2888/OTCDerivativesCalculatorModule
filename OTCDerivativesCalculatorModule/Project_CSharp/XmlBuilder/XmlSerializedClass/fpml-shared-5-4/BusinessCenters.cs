using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BusinessCenters : ISerialized
    {
        public BusinessCenters(XmlNode xmlNode)
        {
            XmlNodeList businessCenterNodeList = xmlNode.SelectNodes("businessCenter");
            
            if (businessCenterNodeList != null)
            {
                this.businessCenter_ = new List<BusinessCenter>();
                foreach (XmlNode item in businessCenterNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            businessCenterIDRef_ = item.Attributes["id"].Value;
                            businessCenter_.Add(new BusinessCenter(item));
                            IDManager.SetID(businessCenterIDRef_, businessCenter_[businessCenter_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            businessCenterIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        businessCenter_.Add(new BusinessCenter(item));
                        }
                    }
                    else
                    {
                        businessCenter_.Add(new BusinessCenter(item));
                    }
                }
            }
            
        
        }
        
    
        #region BusinessCenter_
        private List<BusinessCenter> businessCenter_;
        public List<BusinessCenter> BusinessCenter_
        {
            get
            {
                if (this.businessCenter_ != null)
                {
                    return this.businessCenter_; 
                }
                else if (this.businessCenterIDRef_ != null)
                {
                    return this.businessCenter_; 
                }
                else
                {
                      return this.businessCenter_; 
                }
            }
            set
            {
                if (this.businessCenter_ != value)
                {
                    this.businessCenter_ = value;
                }
            }
        }
        #endregion
        
        public string businessCenterIDRef_ { get; set; }
        
    
        
    
    }
    
}


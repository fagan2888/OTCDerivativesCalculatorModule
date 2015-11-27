using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityRelativeExpirationDates : ISerialized
    {
        public CommodityRelativeExpirationDates(XmlNode xmlNode)
        {
            XmlNode expireRelativeToEventNode = xmlNode.SelectSingleNode("expireRelativeToEvent");
            
            if (expireRelativeToEventNode != null)
            {
                if (expireRelativeToEventNode.Attributes["href"] != null || expireRelativeToEventNode.Attributes["id"] != null) 
                {
                    if (expireRelativeToEventNode.Attributes["id"] != null) 
                    {
                        expireRelativeToEventIDRef_ = expireRelativeToEventNode.Attributes["id"].Value;
                        CommodityExpireRelativeToEvent ob = new CommodityExpireRelativeToEvent(expireRelativeToEventNode);
                        IDManager.SetID(expireRelativeToEventIDRef_, ob);
                    }
                    else if (expireRelativeToEventNode.Attributes["href"] != null)
                    {
                        expireRelativeToEventIDRef_ = expireRelativeToEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expireRelativeToEvent_ = new CommodityExpireRelativeToEvent(expireRelativeToEventNode);
                    }
                }
                else
                {
                    expireRelativeToEvent_ = new CommodityExpireRelativeToEvent(expireRelativeToEventNode);
                }
            }
            
        
            XmlNode expirationDateOffsetNode = xmlNode.SelectSingleNode("expirationDateOffset");
            
            if (expirationDateOffsetNode != null)
            {
                if (expirationDateOffsetNode.Attributes["href"] != null || expirationDateOffsetNode.Attributes["id"] != null) 
                {
                    if (expirationDateOffsetNode.Attributes["id"] != null) 
                    {
                        expirationDateOffsetIDRef_ = expirationDateOffsetNode.Attributes["id"].Value;
                        DateOffset ob = new DateOffset(expirationDateOffsetNode);
                        IDManager.SetID(expirationDateOffsetIDRef_, ob);
                    }
                    else if (expirationDateOffsetNode.Attributes["href"] != null)
                    {
                        expirationDateOffsetIDRef_ = expirationDateOffsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDateOffset_ = new DateOffset(expirationDateOffsetNode);
                    }
                }
                else
                {
                    expirationDateOffset_ = new DateOffset(expirationDateOffsetNode);
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
            
        
        }
        
    
        #region ExpireRelativeToEvent_
        private CommodityExpireRelativeToEvent expireRelativeToEvent_;
        public CommodityExpireRelativeToEvent ExpireRelativeToEvent_
        {
            get
            {
                if (this.expireRelativeToEvent_ != null)
                {
                    return this.expireRelativeToEvent_; 
                }
                else if (this.expireRelativeToEventIDRef_ != null)
                {
                    expireRelativeToEvent_ = IDManager.getID(expireRelativeToEventIDRef_) as CommodityExpireRelativeToEvent;
                    return this.expireRelativeToEvent_; 
                }
                else
                {
                      return this.expireRelativeToEvent_; 
                }
            }
            set
            {
                if (this.expireRelativeToEvent_ != value)
                {
                    this.expireRelativeToEvent_ = value;
                }
            }
        }
        #endregion
        
        public string expireRelativeToEventIDRef_ { get; set; }
        #region ExpirationDateOffset_
        private DateOffset expirationDateOffset_;
        public DateOffset ExpirationDateOffset_
        {
            get
            {
                if (this.expirationDateOffset_ != null)
                {
                    return this.expirationDateOffset_; 
                }
                else if (this.expirationDateOffsetIDRef_ != null)
                {
                    expirationDateOffset_ = IDManager.getID(expirationDateOffsetIDRef_) as DateOffset;
                    return this.expirationDateOffset_; 
                }
                else
                {
                      return this.expirationDateOffset_; 
                }
            }
            set
            {
                if (this.expirationDateOffset_ != value)
                {
                    this.expirationDateOffset_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateOffsetIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityRelativeExpirationDates
    {
        public CommodityRelativeExpirationDates(XmlNode xmlNode)
        {
            XmlNodeList expireRelativeToEventNodeList = xmlNode.SelectNodes("expireRelativeToEvent");
            if (expireRelativeToEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expireRelativeToEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expireRelativeToEventIDRef = item.Attributes["id"].Name;
                        CommodityExpireRelativeToEvent ob = CommodityExpireRelativeToEvent();
                        IDManager.SetID(expireRelativeToEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expireRelativeToEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expireRelativeToEvent = new CommodityExpireRelativeToEvent(item);
                    }
                }
            }
            
        
            XmlNodeList expirationDateOffsetNodeList = xmlNode.SelectNodes("expirationDateOffset");
            if (expirationDateOffsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationDateOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationDateOffsetIDRef = item.Attributes["id"].Name;
                        DateOffset ob = DateOffset();
                        IDManager.SetID(expirationDateOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDateOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDateOffset = new DateOffset(item);
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
        
    
        #region ExpireRelativeToEvent
        private CommodityExpireRelativeToEvent expireRelativeToEvent;
        public CommodityExpireRelativeToEvent ExpireRelativeToEvent
        {
            get
            {
                if (this.expireRelativeToEvent != null)
                {
                    return this.expireRelativeToEvent; 
                }
                else if (this.expireRelativeToEventIDRef != null)
                {
                    expireRelativeToEvent = IDManager.getID(expireRelativeToEventIDRef) as CommodityExpireRelativeToEvent;
                    return this.expireRelativeToEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expireRelativeToEvent != value)
                {
                    this.expireRelativeToEvent = value;
                }
            }
        }
        #endregion
        
        public string CommodityExpireRelativeToEventIDRef { get; set; }
        #region ExpirationDateOffset
        private DateOffset expirationDateOffset;
        public DateOffset ExpirationDateOffset
        {
            get
            {
                if (this.expirationDateOffset != null)
                {
                    return this.expirationDateOffset; 
                }
                else if (this.expirationDateOffsetIDRef != null)
                {
                    expirationDateOffset = IDManager.getID(expirationDateOffsetIDRef) as DateOffset;
                    return this.expirationDateOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationDateOffset != value)
                {
                    this.expirationDateOffset = value;
                }
            }
        }
        #endregion
        
        public string DateOffsetIDRef { get; set; }
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


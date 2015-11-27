using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityCorporateEvents
    {
        public EquityCorporateEvents(XmlNode xmlNode)
        {
            XmlNodeList shareForShareNodeList = xmlNode.SelectNodes("shareForShare");
            if (shareForShareNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in shareForShareNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shareForShareIDRef = item.Attributes["id"].Name;
                        ShareExtraordinaryEventEnum ob = ShareExtraordinaryEventEnum();
                        IDManager.SetID(shareForShareIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shareForShareIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        shareForShare = new ShareExtraordinaryEventEnum(item);
                    }
                }
            }
            
        
            XmlNodeList shareForOtherNodeList = xmlNode.SelectNodes("shareForOther");
            if (shareForOtherNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in shareForOtherNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shareForOtherIDRef = item.Attributes["id"].Name;
                        ShareExtraordinaryEventEnum ob = ShareExtraordinaryEventEnum();
                        IDManager.SetID(shareForOtherIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shareForOtherIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        shareForOther = new ShareExtraordinaryEventEnum(item);
                    }
                }
            }
            
        
            XmlNodeList shareForCombinedNodeList = xmlNode.SelectNodes("shareForCombined");
            if (shareForCombinedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in shareForCombinedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shareForCombinedIDRef = item.Attributes["id"].Name;
                        ShareExtraordinaryEventEnum ob = ShareExtraordinaryEventEnum();
                        IDManager.SetID(shareForCombinedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shareForCombinedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        shareForCombined = new ShareExtraordinaryEventEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region ShareForShare
        private ShareExtraordinaryEventEnum shareForShare;
        public ShareExtraordinaryEventEnum ShareForShare
        {
            get
            {
                if (this.shareForShare != null)
                {
                    return this.shareForShare; 
                }
                else if (this.shareForShareIDRef != null)
                {
                    shareForShare = IDManager.getID(shareForShareIDRef) as ShareExtraordinaryEventEnum;
                    return this.shareForShare; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shareForShare != value)
                {
                    this.shareForShare = value;
                }
            }
        }
        #endregion
        
        public string ShareExtraordinaryEventEnumIDRef { get; set; }
        #region ShareForOther
        private ShareExtraordinaryEventEnum shareForOther;
        public ShareExtraordinaryEventEnum ShareForOther
        {
            get
            {
                if (this.shareForOther != null)
                {
                    return this.shareForOther; 
                }
                else if (this.shareForOtherIDRef != null)
                {
                    shareForOther = IDManager.getID(shareForOtherIDRef) as ShareExtraordinaryEventEnum;
                    return this.shareForOther; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shareForOther != value)
                {
                    this.shareForOther = value;
                }
            }
        }
        #endregion
        
        public string ShareExtraordinaryEventEnumIDRef { get; set; }
        #region ShareForCombined
        private ShareExtraordinaryEventEnum shareForCombined;
        public ShareExtraordinaryEventEnum ShareForCombined
        {
            get
            {
                if (this.shareForCombined != null)
                {
                    return this.shareForCombined; 
                }
                else if (this.shareForCombinedIDRef != null)
                {
                    shareForCombined = IDManager.getID(shareForCombinedIDRef) as ShareExtraordinaryEventEnum;
                    return this.shareForCombined; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shareForCombined != value)
                {
                    this.shareForCombined = value;
                }
            }
        }
        #endregion
        
        public string ShareExtraordinaryEventEnumIDRef { get; set; }
        
    
        
    
    }
    
}


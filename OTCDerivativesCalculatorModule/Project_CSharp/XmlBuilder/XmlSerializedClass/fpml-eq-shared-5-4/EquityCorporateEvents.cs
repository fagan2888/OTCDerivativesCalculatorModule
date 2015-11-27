using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityCorporateEvents : ISerialized
    {
        public EquityCorporateEvents(XmlNode xmlNode)
        {
            XmlNode shareForShareNode = xmlNode.SelectSingleNode("shareForShare");
            
            if (shareForShareNode != null)
            {
                if (shareForShareNode.Attributes["href"] != null || shareForShareNode.Attributes["id"] != null) 
                {
                    if (shareForShareNode.Attributes["id"] != null) 
                    {
                        shareForShareIDRef_ = shareForShareNode.Attributes["id"].Value;
                        ShareExtraordinaryEventEnum ob = new ShareExtraordinaryEventEnum(shareForShareNode);
                        IDManager.SetID(shareForShareIDRef_, ob);
                    }
                    else if (shareForShareNode.Attributes["href"] != null)
                    {
                        shareForShareIDRef_ = shareForShareNode.Attributes["href"].Value;
                    }
                    else
                    {
                        shareForShare_ = new ShareExtraordinaryEventEnum(shareForShareNode);
                    }
                }
                else
                {
                    shareForShare_ = new ShareExtraordinaryEventEnum(shareForShareNode);
                }
            }
            
        
            XmlNode shareForOtherNode = xmlNode.SelectSingleNode("shareForOther");
            
            if (shareForOtherNode != null)
            {
                if (shareForOtherNode.Attributes["href"] != null || shareForOtherNode.Attributes["id"] != null) 
                {
                    if (shareForOtherNode.Attributes["id"] != null) 
                    {
                        shareForOtherIDRef_ = shareForOtherNode.Attributes["id"].Value;
                        ShareExtraordinaryEventEnum ob = new ShareExtraordinaryEventEnum(shareForOtherNode);
                        IDManager.SetID(shareForOtherIDRef_, ob);
                    }
                    else if (shareForOtherNode.Attributes["href"] != null)
                    {
                        shareForOtherIDRef_ = shareForOtherNode.Attributes["href"].Value;
                    }
                    else
                    {
                        shareForOther_ = new ShareExtraordinaryEventEnum(shareForOtherNode);
                    }
                }
                else
                {
                    shareForOther_ = new ShareExtraordinaryEventEnum(shareForOtherNode);
                }
            }
            
        
            XmlNode shareForCombinedNode = xmlNode.SelectSingleNode("shareForCombined");
            
            if (shareForCombinedNode != null)
            {
                if (shareForCombinedNode.Attributes["href"] != null || shareForCombinedNode.Attributes["id"] != null) 
                {
                    if (shareForCombinedNode.Attributes["id"] != null) 
                    {
                        shareForCombinedIDRef_ = shareForCombinedNode.Attributes["id"].Value;
                        ShareExtraordinaryEventEnum ob = new ShareExtraordinaryEventEnum(shareForCombinedNode);
                        IDManager.SetID(shareForCombinedIDRef_, ob);
                    }
                    else if (shareForCombinedNode.Attributes["href"] != null)
                    {
                        shareForCombinedIDRef_ = shareForCombinedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        shareForCombined_ = new ShareExtraordinaryEventEnum(shareForCombinedNode);
                    }
                }
                else
                {
                    shareForCombined_ = new ShareExtraordinaryEventEnum(shareForCombinedNode);
                }
            }
            
        
        }
        
    
        #region ShareForShare_
        private ShareExtraordinaryEventEnum shareForShare_;
        public ShareExtraordinaryEventEnum ShareForShare_
        {
            get
            {
                if (this.shareForShare_ != null)
                {
                    return this.shareForShare_; 
                }
                else if (this.shareForShareIDRef_ != null)
                {
                    shareForShare_ = IDManager.getID(shareForShareIDRef_) as ShareExtraordinaryEventEnum;
                    return this.shareForShare_; 
                }
                else
                {
                      return this.shareForShare_; 
                }
            }
            set
            {
                if (this.shareForShare_ != value)
                {
                    this.shareForShare_ = value;
                }
            }
        }
        #endregion
        
        public string shareForShareIDRef_ { get; set; }
        #region ShareForOther_
        private ShareExtraordinaryEventEnum shareForOther_;
        public ShareExtraordinaryEventEnum ShareForOther_
        {
            get
            {
                if (this.shareForOther_ != null)
                {
                    return this.shareForOther_; 
                }
                else if (this.shareForOtherIDRef_ != null)
                {
                    shareForOther_ = IDManager.getID(shareForOtherIDRef_) as ShareExtraordinaryEventEnum;
                    return this.shareForOther_; 
                }
                else
                {
                      return this.shareForOther_; 
                }
            }
            set
            {
                if (this.shareForOther_ != value)
                {
                    this.shareForOther_ = value;
                }
            }
        }
        #endregion
        
        public string shareForOtherIDRef_ { get; set; }
        #region ShareForCombined_
        private ShareExtraordinaryEventEnum shareForCombined_;
        public ShareExtraordinaryEventEnum ShareForCombined_
        {
            get
            {
                if (this.shareForCombined_ != null)
                {
                    return this.shareForCombined_; 
                }
                else if (this.shareForCombinedIDRef_ != null)
                {
                    shareForCombined_ = IDManager.getID(shareForCombinedIDRef_) as ShareExtraordinaryEventEnum;
                    return this.shareForCombined_; 
                }
                else
                {
                      return this.shareForCombined_; 
                }
            }
            set
            {
                if (this.shareForCombined_ != value)
                {
                    this.shareForCombined_ = value;
                }
            }
        }
        #endregion
        
        public string shareForCombinedIDRef_ { get; set; }
        
    
        
    
    }
    
}


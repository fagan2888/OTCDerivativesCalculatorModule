using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceInformationList : ISerialized
    {
        public ReferenceInformationList() { }
        public ReferenceInformationList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList referenceInformationNodeList = xmlNode.SelectNodes("referenceInformation");
            
            if (referenceInformationNodeList != null)
            {
                this.referenceInformation_ = new List<ReferenceInformation>();
                foreach (XmlNode item in referenceInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceInformationIDRef_ = item.Attributes["id"].Value;
                            referenceInformation_.Add(new ReferenceInformation(item));
                            IDManager.SetID(referenceInformationIDRef_, referenceInformation_[referenceInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceInformation_.Add(new ReferenceInformation(item));
                        }
                    }
                    else
                    {
                        referenceInformation_.Add(new ReferenceInformation(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceInformation_
        private List<ReferenceInformation> referenceInformation_;
        public List<ReferenceInformation> ReferenceInformation_
        {
            get
            {
                if (this.referenceInformation_ != null)
                {
                    return this.referenceInformation_; 
                }
                else if (this.referenceInformationIDRef_ != null)
                {
                    return this.referenceInformation_; 
                }
                else
                {
                    throw new Exception( "referenceInformation_Node no exist!");
                }
            }
            set
            {
                if (this.referenceInformation_ != value)
                {
                    this.referenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string referenceInformationIDRef_ { get; set; }
        
    
        
    
    }
    
}


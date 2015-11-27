using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class General_TerminationEventDetail_credit : ISerialized
    {
        public General_TerminationEventDetail_credit() { }
        public General_TerminationEventDetail_credit(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList referenceEntityNodeList = xmlNode.SelectNodes("referenceEntity");
            
            if (referenceEntityNodeList != null)
            {
                this.referenceEntity_ = new List<XsdTypeToken>();
                foreach (XmlNode item in referenceEntityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceEntityIDRef_ = item.Attributes["id"].Value;
                            referenceEntity_.Add(new XsdTypeToken(item));
                            IDManager.SetID(referenceEntityIDRef_, referenceEntity_[referenceEntity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceEntityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceEntity_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        referenceEntity_.Add(new XsdTypeToken(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceEntity_
        private List<XsdTypeToken> referenceEntity_;
        public List<XsdTypeToken> ReferenceEntity_
        {
            get
            {
                if (this.referenceEntity_ != null)
                {
                    return this.referenceEntity_; 
                }
                else if (this.referenceEntityIDRef_ != null)
                {
                    return this.referenceEntity_; 
                }
                else
                {
                    throw new Exception( "referenceEntity_Node no exist!");
                }
            }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                }
            }
        }
        #endregion
        
        public string referenceEntityIDRef_ { get; set; }
        
    
        
    
    }
    
}


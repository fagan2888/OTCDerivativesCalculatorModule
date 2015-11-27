using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LegIdentifier : ISerialized
    {
        public LegIdentifier(XmlNode xmlNode)
        {
            XmlNode legIdNode = xmlNode.SelectSingleNode("legId");
            
            if (legIdNode != null)
            {
                if (legIdNode.Attributes["href"] != null || legIdNode.Attributes["id"] != null) 
                {
                    if (legIdNode.Attributes["id"] != null) 
                    {
                        legIdIDRef_ = legIdNode.Attributes["id"].Value;
                        LegId ob = new LegId(legIdNode);
                        IDManager.SetID(legIdIDRef_, ob);
                    }
                    else if (legIdNode.Attributes["href"] != null)
                    {
                        legIdIDRef_ = legIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        legId_ = new LegId(legIdNode);
                    }
                }
                else
                {
                    legId_ = new LegId(legIdNode);
                }
            }
            
        
            XmlNode versionNode = xmlNode.SelectSingleNode("version");
            
            if (versionNode != null)
            {
                if (versionNode.Attributes["href"] != null || versionNode.Attributes["id"] != null) 
                {
                    if (versionNode.Attributes["id"] != null) 
                    {
                        versionIDRef_ = versionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(versionNode);
                        IDManager.SetID(versionIDRef_, ob);
                    }
                    else if (versionNode.Attributes["href"] != null)
                    {
                        versionIDRef_ = versionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        version_ = new XsdTypeNonNegativeInteger(versionNode);
                    }
                }
                else
                {
                    version_ = new XsdTypeNonNegativeInteger(versionNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                }
            }
            
        
        }
        
    
        #region LegId_
        private LegId legId_;
        public LegId LegId_
        {
            get
            {
                if (this.legId_ != null)
                {
                    return this.legId_; 
                }
                else if (this.legIdIDRef_ != null)
                {
                    legId_ = IDManager.getID(legIdIDRef_) as LegId;
                    return this.legId_; 
                }
                else
                {
                      return this.legId_; 
                }
            }
            set
            {
                if (this.legId_ != value)
                {
                    this.legId_ = value;
                }
            }
        }
        #endregion
        
        public string legIdIDRef_ { get; set; }
        #region Version_
        private XsdTypeNonNegativeInteger version_;
        public XsdTypeNonNegativeInteger Version_
        {
            get
            {
                if (this.version_ != null)
                {
                    return this.version_; 
                }
                else if (this.versionIDRef_ != null)
                {
                    version_ = IDManager.getID(versionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.version_; 
                }
                else
                {
                      return this.version_; 
                }
            }
            set
            {
                if (this.version_ != value)
                {
                    this.version_ = value;
                }
            }
        }
        #endregion
        
        public string versionIDRef_ { get; set; }
        #region EffectiveDate_
        private IdentifiedDate effectiveDate_;
        public IdentifiedDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as IdentifiedDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


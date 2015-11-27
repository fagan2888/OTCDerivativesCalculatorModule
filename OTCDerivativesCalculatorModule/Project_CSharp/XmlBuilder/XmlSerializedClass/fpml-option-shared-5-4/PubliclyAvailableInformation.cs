using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PubliclyAvailableInformation : ISerialized
    {
        public PubliclyAvailableInformation(XmlNode xmlNode)
        {
            XmlNode standardPublicSourcesNode = xmlNode.SelectSingleNode("standardPublicSources");
            
            if (standardPublicSourcesNode != null)
            {
                if (standardPublicSourcesNode.Attributes["href"] != null || standardPublicSourcesNode.Attributes["id"] != null) 
                {
                    if (standardPublicSourcesNode.Attributes["id"] != null) 
                    {
                        standardPublicSourcesIDRef_ = standardPublicSourcesNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(standardPublicSourcesNode);
                        IDManager.SetID(standardPublicSourcesIDRef_, ob);
                    }
                    else if (standardPublicSourcesNode.Attributes["href"] != null)
                    {
                        standardPublicSourcesIDRef_ = standardPublicSourcesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardPublicSources_ = new XsdTypeBoolean(standardPublicSourcesNode);
                    }
                }
                else
                {
                    standardPublicSources_ = new XsdTypeBoolean(standardPublicSourcesNode);
                }
            }
            
        
            XmlNodeList publicSourceNodeList = xmlNode.SelectNodes("publicSource");
            
            if (publicSourceNodeList != null)
            {
                this.publicSource_ = new List<XsdTypeString>();
                foreach (XmlNode item in publicSourceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            publicSourceIDRef_ = item.Attributes["id"].Value;
                            publicSource_.Add(new XsdTypeString(item));
                            IDManager.SetID(publicSourceIDRef_, publicSource_[publicSource_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            publicSourceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        publicSource_.Add(new XsdTypeString(item));
                        }
                    }
                    else
                    {
                        publicSource_.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNode specifiedNumberNode = xmlNode.SelectSingleNode("specifiedNumber");
            
            if (specifiedNumberNode != null)
            {
                if (specifiedNumberNode.Attributes["href"] != null || specifiedNumberNode.Attributes["id"] != null) 
                {
                    if (specifiedNumberNode.Attributes["id"] != null) 
                    {
                        specifiedNumberIDRef_ = specifiedNumberNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(specifiedNumberNode);
                        IDManager.SetID(specifiedNumberIDRef_, ob);
                    }
                    else if (specifiedNumberNode.Attributes["href"] != null)
                    {
                        specifiedNumberIDRef_ = specifiedNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        specifiedNumber_ = new XsdTypePositiveInteger(specifiedNumberNode);
                    }
                }
                else
                {
                    specifiedNumber_ = new XsdTypePositiveInteger(specifiedNumberNode);
                }
            }
            
        
        }
        
    
        #region StandardPublicSources_
        private XsdTypeBoolean standardPublicSources_;
        public XsdTypeBoolean StandardPublicSources_
        {
            get
            {
                if (this.standardPublicSources_ != null)
                {
                    return this.standardPublicSources_; 
                }
                else if (this.standardPublicSourcesIDRef_ != null)
                {
                    standardPublicSources_ = IDManager.getID(standardPublicSourcesIDRef_) as XsdTypeBoolean;
                    return this.standardPublicSources_; 
                }
                else
                {
                      return this.standardPublicSources_; 
                }
            }
            set
            {
                if (this.standardPublicSources_ != value)
                {
                    this.standardPublicSources_ = value;
                }
            }
        }
        #endregion
        
        public string standardPublicSourcesIDRef_ { get; set; }
        #region PublicSource_
        private List<XsdTypeString> publicSource_;
        public List<XsdTypeString> PublicSource_
        {
            get
            {
                if (this.publicSource_ != null)
                {
                    return this.publicSource_; 
                }
                else if (this.publicSourceIDRef_ != null)
                {
                    return this.publicSource_; 
                }
                else
                {
                      return this.publicSource_; 
                }
            }
            set
            {
                if (this.publicSource_ != value)
                {
                    this.publicSource_ = value;
                }
            }
        }
        #endregion
        
        public string publicSourceIDRef_ { get; set; }
        #region SpecifiedNumber_
        private XsdTypePositiveInteger specifiedNumber_;
        public XsdTypePositiveInteger SpecifiedNumber_
        {
            get
            {
                if (this.specifiedNumber_ != null)
                {
                    return this.specifiedNumber_; 
                }
                else if (this.specifiedNumberIDRef_ != null)
                {
                    specifiedNumber_ = IDManager.getID(specifiedNumberIDRef_) as XsdTypePositiveInteger;
                    return this.specifiedNumber_; 
                }
                else
                {
                      return this.specifiedNumber_; 
                }
            }
            set
            {
                if (this.specifiedNumber_ != value)
                {
                    this.specifiedNumber_ = value;
                }
            }
        }
        #endregion
        
        public string specifiedNumberIDRef_ { get; set; }
        
    
        
    
    }
    
}


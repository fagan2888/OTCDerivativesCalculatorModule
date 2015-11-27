using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InformationSource : ISerialized
    {
        public InformationSource(XmlNode xmlNode)
        {
            XmlNode rateSourceNode = xmlNode.SelectSingleNode("rateSource");
            
            if (rateSourceNode != null)
            {
                if (rateSourceNode.Attributes["href"] != null || rateSourceNode.Attributes["id"] != null) 
                {
                    if (rateSourceNode.Attributes["id"] != null) 
                    {
                        rateSourceIDRef_ = rateSourceNode.Attributes["id"].Value;
                        InformationProvider ob = new InformationProvider(rateSourceNode);
                        IDManager.SetID(rateSourceIDRef_, ob);
                    }
                    else if (rateSourceNode.Attributes["href"] != null)
                    {
                        rateSourceIDRef_ = rateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateSource_ = new InformationProvider(rateSourceNode);
                    }
                }
                else
                {
                    rateSource_ = new InformationProvider(rateSourceNode);
                }
            }
            
        
            XmlNode rateSourcePageNode = xmlNode.SelectSingleNode("rateSourcePage");
            
            if (rateSourcePageNode != null)
            {
                if (rateSourcePageNode.Attributes["href"] != null || rateSourcePageNode.Attributes["id"] != null) 
                {
                    if (rateSourcePageNode.Attributes["id"] != null) 
                    {
                        rateSourcePageIDRef_ = rateSourcePageNode.Attributes["id"].Value;
                        RateSourcePage ob = new RateSourcePage(rateSourcePageNode);
                        IDManager.SetID(rateSourcePageIDRef_, ob);
                    }
                    else if (rateSourcePageNode.Attributes["href"] != null)
                    {
                        rateSourcePageIDRef_ = rateSourcePageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateSourcePage_ = new RateSourcePage(rateSourcePageNode);
                    }
                }
                else
                {
                    rateSourcePage_ = new RateSourcePage(rateSourcePageNode);
                }
            }
            
        
            XmlNode rateSourcePageHeadingNode = xmlNode.SelectSingleNode("rateSourcePageHeading");
            
            if (rateSourcePageHeadingNode != null)
            {
                if (rateSourcePageHeadingNode.Attributes["href"] != null || rateSourcePageHeadingNode.Attributes["id"] != null) 
                {
                    if (rateSourcePageHeadingNode.Attributes["id"] != null) 
                    {
                        rateSourcePageHeadingIDRef_ = rateSourcePageHeadingNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(rateSourcePageHeadingNode);
                        IDManager.SetID(rateSourcePageHeadingIDRef_, ob);
                    }
                    else if (rateSourcePageHeadingNode.Attributes["href"] != null)
                    {
                        rateSourcePageHeadingIDRef_ = rateSourcePageHeadingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateSourcePageHeading_ = new XsdTypeString(rateSourcePageHeadingNode);
                    }
                }
                else
                {
                    rateSourcePageHeading_ = new XsdTypeString(rateSourcePageHeadingNode);
                }
            }
            
        
        }
        
    
        #region RateSource_
        private InformationProvider rateSource_;
        public InformationProvider RateSource_
        {
            get
            {
                if (this.rateSource_ != null)
                {
                    return this.rateSource_; 
                }
                else if (this.rateSourceIDRef_ != null)
                {
                    rateSource_ = IDManager.getID(rateSourceIDRef_) as InformationProvider;
                    return this.rateSource_; 
                }
                else
                {
                      return this.rateSource_; 
                }
            }
            set
            {
                if (this.rateSource_ != value)
                {
                    this.rateSource_ = value;
                }
            }
        }
        #endregion
        
        public string rateSourceIDRef_ { get; set; }
        #region RateSourcePage_
        private RateSourcePage rateSourcePage_;
        public RateSourcePage RateSourcePage_
        {
            get
            {
                if (this.rateSourcePage_ != null)
                {
                    return this.rateSourcePage_; 
                }
                else if (this.rateSourcePageIDRef_ != null)
                {
                    rateSourcePage_ = IDManager.getID(rateSourcePageIDRef_) as RateSourcePage;
                    return this.rateSourcePage_; 
                }
                else
                {
                      return this.rateSourcePage_; 
                }
            }
            set
            {
                if (this.rateSourcePage_ != value)
                {
                    this.rateSourcePage_ = value;
                }
            }
        }
        #endregion
        
        public string rateSourcePageIDRef_ { get; set; }
        #region RateSourcePageHeading_
        private XsdTypeString rateSourcePageHeading_;
        public XsdTypeString RateSourcePageHeading_
        {
            get
            {
                if (this.rateSourcePageHeading_ != null)
                {
                    return this.rateSourcePageHeading_; 
                }
                else if (this.rateSourcePageHeadingIDRef_ != null)
                {
                    rateSourcePageHeading_ = IDManager.getID(rateSourcePageHeadingIDRef_) as XsdTypeString;
                    return this.rateSourcePageHeading_; 
                }
                else
                {
                      return this.rateSourcePageHeading_; 
                }
            }
            set
            {
                if (this.rateSourcePageHeading_ != value)
                {
                    this.rateSourcePageHeading_ = value;
                }
            }
        }
        #endregion
        
        public string rateSourcePageHeadingIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EnvironmentalProduct : ISerialized
    {
        public EnvironmentalProduct(XmlNode xmlNode)
        {
            XmlNode productTypeNode = xmlNode.SelectSingleNode("productType");
            
            if (productTypeNode != null)
            {
                if (productTypeNode.Attributes["href"] != null || productTypeNode.Attributes["id"] != null) 
                {
                    if (productTypeNode.Attributes["id"] != null) 
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["id"].Value;
                        EnvironmentalProductTypeEnum ob = new EnvironmentalProductTypeEnum(productTypeNode);
                        IDManager.SetID(productTypeIDRef_, ob);
                    }
                    else if (productTypeNode.Attributes["href"] != null)
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productType_ = new EnvironmentalProductTypeEnum(productTypeNode);
                    }
                }
                else
                {
                    productType_ = new EnvironmentalProductTypeEnum(productTypeNode);
                }
            }
            
        
            XmlNode compliancePeriodNode = xmlNode.SelectSingleNode("compliancePeriod");
            
            if (compliancePeriodNode != null)
            {
                if (compliancePeriodNode.Attributes["href"] != null || compliancePeriodNode.Attributes["id"] != null) 
                {
                    if (compliancePeriodNode.Attributes["id"] != null) 
                    {
                        compliancePeriodIDRef_ = compliancePeriodNode.Attributes["id"].Value;
                        EnvironmentalProductComplaincePeriod ob = new EnvironmentalProductComplaincePeriod(compliancePeriodNode);
                        IDManager.SetID(compliancePeriodIDRef_, ob);
                    }
                    else if (compliancePeriodNode.Attributes["href"] != null)
                    {
                        compliancePeriodIDRef_ = compliancePeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compliancePeriod_ = new EnvironmentalProductComplaincePeriod(compliancePeriodNode);
                    }
                }
                else
                {
                    compliancePeriod_ = new EnvironmentalProductComplaincePeriod(compliancePeriodNode);
                }
            }
            
        
            XmlNodeList vintageNodeList = xmlNode.SelectNodes("vintage");
            
            if (vintageNodeList != null)
            {
                this.vintage_ = new List<XsdTypeGYear>();
                foreach (XmlNode item in vintageNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            vintageIDRef_ = item.Attributes["id"].Value;
                            vintage_.Add(new XsdTypeGYear(item));
                            IDManager.SetID(vintageIDRef_, vintage_[vintage_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            vintageIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        vintage_.Add(new XsdTypeGYear(item));
                        }
                    }
                    else
                    {
                        vintage_.Add(new XsdTypeGYear(item));
                    }
                }
            }
            
        
            XmlNode applicableLawNode = xmlNode.SelectSingleNode("applicableLaw");
            
            if (applicableLawNode != null)
            {
                if (applicableLawNode.Attributes["href"] != null || applicableLawNode.Attributes["id"] != null) 
                {
                    if (applicableLawNode.Attributes["id"] != null) 
                    {
                        applicableLawIDRef_ = applicableLawNode.Attributes["id"].Value;
                        EnvironmentalProductApplicableLaw ob = new EnvironmentalProductApplicableLaw(applicableLawNode);
                        IDManager.SetID(applicableLawIDRef_, ob);
                    }
                    else if (applicableLawNode.Attributes["href"] != null)
                    {
                        applicableLawIDRef_ = applicableLawNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicableLaw_ = new EnvironmentalProductApplicableLaw(applicableLawNode);
                    }
                }
                else
                {
                    applicableLaw_ = new EnvironmentalProductApplicableLaw(applicableLawNode);
                }
            }
            
        
            XmlNode trackingSystemNode = xmlNode.SelectSingleNode("trackingSystem");
            
            if (trackingSystemNode != null)
            {
                if (trackingSystemNode.Attributes["href"] != null || trackingSystemNode.Attributes["id"] != null) 
                {
                    if (trackingSystemNode.Attributes["id"] != null) 
                    {
                        trackingSystemIDRef_ = trackingSystemNode.Attributes["id"].Value;
                        EnvironmentalTrackingSystem ob = new EnvironmentalTrackingSystem(trackingSystemNode);
                        IDManager.SetID(trackingSystemIDRef_, ob);
                    }
                    else if (trackingSystemNode.Attributes["href"] != null)
                    {
                        trackingSystemIDRef_ = trackingSystemNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trackingSystem_ = new EnvironmentalTrackingSystem(trackingSystemNode);
                    }
                }
                else
                {
                    trackingSystem_ = new EnvironmentalTrackingSystem(trackingSystemNode);
                }
            }
            
        
        }
        
    
        #region ProductType_
        private EnvironmentalProductTypeEnum productType_;
        public EnvironmentalProductTypeEnum ProductType_
        {
            get
            {
                if (this.productType_ != null)
                {
                    return this.productType_; 
                }
                else if (this.productTypeIDRef_ != null)
                {
                    productType_ = IDManager.getID(productTypeIDRef_) as EnvironmentalProductTypeEnum;
                    return this.productType_; 
                }
                else
                {
                      return this.productType_; 
                }
            }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                }
            }
        }
        #endregion
        
        public string productTypeIDRef_ { get; set; }
        #region CompliancePeriod_
        private EnvironmentalProductComplaincePeriod compliancePeriod_;
        public EnvironmentalProductComplaincePeriod CompliancePeriod_
        {
            get
            {
                if (this.compliancePeriod_ != null)
                {
                    return this.compliancePeriod_; 
                }
                else if (this.compliancePeriodIDRef_ != null)
                {
                    compliancePeriod_ = IDManager.getID(compliancePeriodIDRef_) as EnvironmentalProductComplaincePeriod;
                    return this.compliancePeriod_; 
                }
                else
                {
                      return this.compliancePeriod_; 
                }
            }
            set
            {
                if (this.compliancePeriod_ != value)
                {
                    this.compliancePeriod_ = value;
                }
            }
        }
        #endregion
        
        public string compliancePeriodIDRef_ { get; set; }
        #region Vintage_
        private List<XsdTypeGYear> vintage_;
        public List<XsdTypeGYear> Vintage_
        {
            get
            {
                if (this.vintage_ != null)
                {
                    return this.vintage_; 
                }
                else if (this.vintageIDRef_ != null)
                {
                    return this.vintage_; 
                }
                else
                {
                      return this.vintage_; 
                }
            }
            set
            {
                if (this.vintage_ != value)
                {
                    this.vintage_ = value;
                }
            }
        }
        #endregion
        
        public string vintageIDRef_ { get; set; }
        #region ApplicableLaw_
        private EnvironmentalProductApplicableLaw applicableLaw_;
        public EnvironmentalProductApplicableLaw ApplicableLaw_
        {
            get
            {
                if (this.applicableLaw_ != null)
                {
                    return this.applicableLaw_; 
                }
                else if (this.applicableLawIDRef_ != null)
                {
                    applicableLaw_ = IDManager.getID(applicableLawIDRef_) as EnvironmentalProductApplicableLaw;
                    return this.applicableLaw_; 
                }
                else
                {
                      return this.applicableLaw_; 
                }
            }
            set
            {
                if (this.applicableLaw_ != value)
                {
                    this.applicableLaw_ = value;
                }
            }
        }
        #endregion
        
        public string applicableLawIDRef_ { get; set; }
        #region TrackingSystem_
        private EnvironmentalTrackingSystem trackingSystem_;
        public EnvironmentalTrackingSystem TrackingSystem_
        {
            get
            {
                if (this.trackingSystem_ != null)
                {
                    return this.trackingSystem_; 
                }
                else if (this.trackingSystemIDRef_ != null)
                {
                    trackingSystem_ = IDManager.getID(trackingSystemIDRef_) as EnvironmentalTrackingSystem;
                    return this.trackingSystem_; 
                }
                else
                {
                      return this.trackingSystem_; 
                }
            }
            set
            {
                if (this.trackingSystem_ != value)
                {
                    this.trackingSystem_ = value;
                }
            }
        }
        #endregion
        
        public string trackingSystemIDRef_ { get; set; }
        
    
        
    
    }
    
}


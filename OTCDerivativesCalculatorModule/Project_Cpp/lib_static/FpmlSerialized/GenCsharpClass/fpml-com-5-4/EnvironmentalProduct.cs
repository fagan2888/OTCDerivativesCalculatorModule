using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EnvironmentalProduct
    {
        public EnvironmentalProduct(XmlNode xmlNode)
        {
            XmlNodeList productTypeNodeList = xmlNode.SelectNodes("productType");
            if (productTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in productTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        productTypeIDRef = item.Attributes["id"].Name;
                        EnvironmentalProductTypeEnum ob = EnvironmentalProductTypeEnum();
                        IDManager.SetID(productTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        productTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        productType = new EnvironmentalProductTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList compliancePeriodNodeList = xmlNode.SelectNodes("compliancePeriod");
            if (compliancePeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compliancePeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compliancePeriodIDRef = item.Attributes["id"].Name;
                        EnvironmentalProductComplaincePeriod ob = EnvironmentalProductComplaincePeriod();
                        IDManager.SetID(compliancePeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compliancePeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compliancePeriod = new EnvironmentalProductComplaincePeriod(item);
                    }
                }
            }
            
        
            XmlNodeList vintageNodeList = xmlNode.SelectNodes("vintage");
            
            foreach (XmlNode item in vintageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        vintageIDRef = item.Attributes["id"].Name;
                        XsdTypeGYear ob = new XsdTypeGYear();
                        ob.Add(new XsdTypeGYear(item));
                        IDManager.SetID(vintageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        vintageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    vintage.Add(new XsdTypeGYear(item));
                    }
                }
            }
            
        
            XmlNodeList applicableLawNodeList = xmlNode.SelectNodes("applicableLaw");
            if (applicableLawNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableLawNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableLawIDRef = item.Attributes["id"].Name;
                        EnvironmentalProductApplicableLaw ob = EnvironmentalProductApplicableLaw();
                        IDManager.SetID(applicableLawIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableLawIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicableLaw = new EnvironmentalProductApplicableLaw(item);
                    }
                }
            }
            
        
            XmlNodeList trackingSystemNodeList = xmlNode.SelectNodes("trackingSystem");
            if (trackingSystemNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in trackingSystemNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        trackingSystemIDRef = item.Attributes["id"].Name;
                        EnvironmentalTrackingSystem ob = EnvironmentalTrackingSystem();
                        IDManager.SetID(trackingSystemIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        trackingSystemIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        trackingSystem = new EnvironmentalTrackingSystem(item);
                    }
                }
            }
            
        
        }
        
    
        #region ProductType
        private EnvironmentalProductTypeEnum productType;
        public EnvironmentalProductTypeEnum ProductType
        {
            get
            {
                if (this.productType != null)
                {
                    return this.productType; 
                }
                else if (this.productTypeIDRef != null)
                {
                    productType = IDManager.getID(productTypeIDRef) as EnvironmentalProductTypeEnum;
                    return this.productType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.productType != value)
                {
                    this.productType = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalProductTypeEnumIDRef { get; set; }
        #region CompliancePeriod
        private EnvironmentalProductComplaincePeriod compliancePeriod;
        public EnvironmentalProductComplaincePeriod CompliancePeriod
        {
            get
            {
                if (this.compliancePeriod != null)
                {
                    return this.compliancePeriod; 
                }
                else if (this.compliancePeriodIDRef != null)
                {
                    compliancePeriod = IDManager.getID(compliancePeriodIDRef) as EnvironmentalProductComplaincePeriod;
                    return this.compliancePeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compliancePeriod != value)
                {
                    this.compliancePeriod = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalProductComplaincePeriodIDRef { get; set; }
        #region Vintage
        private XsdTypeGYear vintage;
        public XsdTypeGYear Vintage
        {
            get
            {
                if (this.vintage != null)
                {
                    return this.vintage; 
                }
                else if (this.vintageIDRef != null)
                {
                    vintage = IDManager.getID(vintageIDRef) as XsdTypeGYear;
                    return this.vintage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.vintage != value)
                {
                    this.vintage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeGYearIDRef { get; set; }
        #region ApplicableLaw
        private EnvironmentalProductApplicableLaw applicableLaw;
        public EnvironmentalProductApplicableLaw ApplicableLaw
        {
            get
            {
                if (this.applicableLaw != null)
                {
                    return this.applicableLaw; 
                }
                else if (this.applicableLawIDRef != null)
                {
                    applicableLaw = IDManager.getID(applicableLawIDRef) as EnvironmentalProductApplicableLaw;
                    return this.applicableLaw; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicableLaw != value)
                {
                    this.applicableLaw = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalProductApplicableLawIDRef { get; set; }
        #region TrackingSystem
        private EnvironmentalTrackingSystem trackingSystem;
        public EnvironmentalTrackingSystem TrackingSystem
        {
            get
            {
                if (this.trackingSystem != null)
                {
                    return this.trackingSystem; 
                }
                else if (this.trackingSystemIDRef != null)
                {
                    trackingSystem = IDManager.getID(trackingSystemIDRef) as EnvironmentalTrackingSystem;
                    return this.trackingSystem; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trackingSystem != value)
                {
                    this.trackingSystem = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalTrackingSystemIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityMetalBrand : ISerialized
    {
        public CommodityMetalBrand(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        CommodityMetalBrandName ob = new CommodityMetalBrandName(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new CommodityMetalBrandName(nameNode);
                    }
                }
                else
                {
                    name_ = new CommodityMetalBrandName(nameNode);
                }
            }
            
        
            XmlNode brandManagerNode = xmlNode.SelectSingleNode("brandManager");
            
            if (brandManagerNode != null)
            {
                if (brandManagerNode.Attributes["href"] != null || brandManagerNode.Attributes["id"] != null) 
                {
                    if (brandManagerNode.Attributes["id"] != null) 
                    {
                        brandManagerIDRef_ = brandManagerNode.Attributes["id"].Value;
                        CommodityMetalBrandManager ob = new CommodityMetalBrandManager(brandManagerNode);
                        IDManager.SetID(brandManagerIDRef_, ob);
                    }
                    else if (brandManagerNode.Attributes["href"] != null)
                    {
                        brandManagerIDRef_ = brandManagerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        brandManager_ = new CommodityMetalBrandManager(brandManagerNode);
                    }
                }
                else
                {
                    brandManager_ = new CommodityMetalBrandManager(brandManagerNode);
                }
            }
            
        
            XmlNode countryNode = xmlNode.SelectSingleNode("country");
            
            if (countryNode != null)
            {
                if (countryNode.Attributes["href"] != null || countryNode.Attributes["id"] != null) 
                {
                    if (countryNode.Attributes["id"] != null) 
                    {
                        countryIDRef_ = countryNode.Attributes["id"].Value;
                        CountryCode ob = new CountryCode(countryNode);
                        IDManager.SetID(countryIDRef_, ob);
                    }
                    else if (countryNode.Attributes["href"] != null)
                    {
                        countryIDRef_ = countryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        country_ = new CountryCode(countryNode);
                    }
                }
                else
                {
                    country_ = new CountryCode(countryNode);
                }
            }
            
        
            XmlNode producerNode = xmlNode.SelectSingleNode("producer");
            
            if (producerNode != null)
            {
                if (producerNode.Attributes["href"] != null || producerNode.Attributes["id"] != null) 
                {
                    if (producerNode.Attributes["id"] != null) 
                    {
                        producerIDRef_ = producerNode.Attributes["id"].Value;
                        CommodityMetalProducer ob = new CommodityMetalProducer(producerNode);
                        IDManager.SetID(producerIDRef_, ob);
                    }
                    else if (producerNode.Attributes["href"] != null)
                    {
                        producerIDRef_ = producerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        producer_ = new CommodityMetalProducer(producerNode);
                    }
                }
                else
                {
                    producer_ = new CommodityMetalProducer(producerNode);
                }
            }
            
        
        }
        
    
        #region Name_
        private CommodityMetalBrandName name_;
        public CommodityMetalBrandName Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as CommodityMetalBrandName;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region BrandManager_
        private CommodityMetalBrandManager brandManager_;
        public CommodityMetalBrandManager BrandManager_
        {
            get
            {
                if (this.brandManager_ != null)
                {
                    return this.brandManager_; 
                }
                else if (this.brandManagerIDRef_ != null)
                {
                    brandManager_ = IDManager.getID(brandManagerIDRef_) as CommodityMetalBrandManager;
                    return this.brandManager_; 
                }
                else
                {
                      return this.brandManager_; 
                }
            }
            set
            {
                if (this.brandManager_ != value)
                {
                    this.brandManager_ = value;
                }
            }
        }
        #endregion
        
        public string brandManagerIDRef_ { get; set; }
        #region Country_
        private CountryCode country_;
        public CountryCode Country_
        {
            get
            {
                if (this.country_ != null)
                {
                    return this.country_; 
                }
                else if (this.countryIDRef_ != null)
                {
                    country_ = IDManager.getID(countryIDRef_) as CountryCode;
                    return this.country_; 
                }
                else
                {
                      return this.country_; 
                }
            }
            set
            {
                if (this.country_ != value)
                {
                    this.country_ = value;
                }
            }
        }
        #endregion
        
        public string countryIDRef_ { get; set; }
        #region Producer_
        private CommodityMetalProducer producer_;
        public CommodityMetalProducer Producer_
        {
            get
            {
                if (this.producer_ != null)
                {
                    return this.producer_; 
                }
                else if (this.producerIDRef_ != null)
                {
                    producer_ = IDManager.getID(producerIDRef_) as CommodityMetalProducer;
                    return this.producer_; 
                }
                else
                {
                      return this.producer_; 
                }
            }
            set
            {
                if (this.producer_ != value)
                {
                    this.producer_ = value;
                }
            }
        }
        #endregion
        
        public string producerIDRef_ { get; set; }
        
    
        
    
    }
    
}


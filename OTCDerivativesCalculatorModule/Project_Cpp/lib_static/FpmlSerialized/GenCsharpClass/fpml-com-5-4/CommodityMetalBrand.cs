using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityMetalBrand
    {
        public CommodityMetalBrand(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        CommodityMetalBrandName ob = CommodityMetalBrandName();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new CommodityMetalBrandName(item);
                    }
                }
            }
            
        
            XmlNodeList brandManagerNodeList = xmlNode.SelectNodes("brandManager");
            if (brandManagerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in brandManagerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brandManagerIDRef = item.Attributes["id"].Name;
                        CommodityMetalBrandManager ob = CommodityMetalBrandManager();
                        IDManager.SetID(brandManagerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brandManagerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        brandManager = new CommodityMetalBrandManager(item);
                    }
                }
            }
            
        
            XmlNodeList countryNodeList = xmlNode.SelectNodes("country");
            if (countryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in countryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        countryIDRef = item.Attributes["id"].Name;
                        CountryCode ob = CountryCode();
                        IDManager.SetID(countryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        countryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        country = new CountryCode(item);
                    }
                }
            }
            
        
            XmlNodeList producerNodeList = xmlNode.SelectNodes("producer");
            if (producerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in producerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        producerIDRef = item.Attributes["id"].Name;
                        CommodityMetalProducer ob = CommodityMetalProducer();
                        IDManager.SetID(producerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        producerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        producer = new CommodityMetalProducer(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private CommodityMetalBrandName name;
        public CommodityMetalBrandName Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as CommodityMetalBrandName;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string CommodityMetalBrandNameIDRef { get; set; }
        #region BrandManager
        private CommodityMetalBrandManager brandManager;
        public CommodityMetalBrandManager BrandManager
        {
            get
            {
                if (this.brandManager != null)
                {
                    return this.brandManager; 
                }
                else if (this.brandManagerIDRef != null)
                {
                    brandManager = IDManager.getID(brandManagerIDRef) as CommodityMetalBrandManager;
                    return this.brandManager; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brandManager != value)
                {
                    this.brandManager = value;
                }
            }
        }
        #endregion
        
        public string CommodityMetalBrandManagerIDRef { get; set; }
        #region Country
        private CountryCode country;
        public CountryCode Country
        {
            get
            {
                if (this.country != null)
                {
                    return this.country; 
                }
                else if (this.countryIDRef != null)
                {
                    country = IDManager.getID(countryIDRef) as CountryCode;
                    return this.country; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.country != value)
                {
                    this.country = value;
                }
            }
        }
        #endregion
        
        public string CountryCodeIDRef { get; set; }
        #region Producer
        private CommodityMetalProducer producer;
        public CommodityMetalProducer Producer
        {
            get
            {
                if (this.producer != null)
                {
                    return this.producer; 
                }
                else if (this.producerIDRef != null)
                {
                    producer = IDManager.getID(producerIDRef) as CommodityMetalProducer;
                    return this.producer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.producer != value)
                {
                    this.producer = value;
                }
            }
        }
        #endregion
        
        public string CommodityMetalProducerIDRef { get; set; }
        
    
        
    
    }
    
}


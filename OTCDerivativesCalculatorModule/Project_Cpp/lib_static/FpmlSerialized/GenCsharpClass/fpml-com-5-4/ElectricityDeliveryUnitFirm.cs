using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryUnitFirm
    {
        public ElectricityDeliveryUnitFirm(XmlNode xmlNode)
        {
            XmlNodeList applicableNodeList = xmlNode.SelectNodes("applicable");
            if (applicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(applicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList generationAssetNodeList = xmlNode.SelectNodes("generationAsset");
            if (generationAssetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in generationAssetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        generationAssetIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(generationAssetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        generationAssetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        generationAsset = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
        }
        
    
        #region Applicable
        private XsdTypeBoolean applicable;
        public XsdTypeBoolean Applicable
        {
            get
            {
                if (this.applicable != null)
                {
                    return this.applicable; 
                }
                else if (this.applicableIDRef != null)
                {
                    applicable = IDManager.getID(applicableIDRef) as XsdTypeBoolean;
                    return this.applicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicable != value)
                {
                    this.applicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region GenerationAsset
        private CommodityDeliveryPoint generationAsset;
        public CommodityDeliveryPoint GenerationAsset
        {
            get
            {
                if (this.generationAsset != null)
                {
                    return this.generationAsset; 
                }
                else if (this.generationAssetIDRef != null)
                {
                    generationAsset = IDManager.getID(generationAssetIDRef) as CommodityDeliveryPoint;
                    return this.generationAsset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.generationAsset != value)
                {
                    this.generationAsset = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        
    
        
    
    }
    
}


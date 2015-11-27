using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryUnitFirm : ISerialized
    {
        public ElectricityDeliveryUnitFirm(XmlNode xmlNode)
        {
            XmlNode applicableNode = xmlNode.SelectSingleNode("applicable");
            
            if (applicableNode != null)
            {
                if (applicableNode.Attributes["href"] != null || applicableNode.Attributes["id"] != null) 
                {
                    if (applicableNode.Attributes["id"] != null) 
                    {
                        applicableIDRef_ = applicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(applicableNode);
                        IDManager.SetID(applicableIDRef_, ob);
                    }
                    else if (applicableNode.Attributes["href"] != null)
                    {
                        applicableIDRef_ = applicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicable_ = new XsdTypeBoolean(applicableNode);
                    }
                }
                else
                {
                    applicable_ = new XsdTypeBoolean(applicableNode);
                }
            }
            
        
            XmlNode generationAssetNode = xmlNode.SelectSingleNode("generationAsset");
            
            if (generationAssetNode != null)
            {
                if (generationAssetNode.Attributes["href"] != null || generationAssetNode.Attributes["id"] != null) 
                {
                    if (generationAssetNode.Attributes["id"] != null) 
                    {
                        generationAssetIDRef_ = generationAssetNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(generationAssetNode);
                        IDManager.SetID(generationAssetIDRef_, ob);
                    }
                    else if (generationAssetNode.Attributes["href"] != null)
                    {
                        generationAssetIDRef_ = generationAssetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generationAsset_ = new CommodityDeliveryPoint(generationAssetNode);
                    }
                }
                else
                {
                    generationAsset_ = new CommodityDeliveryPoint(generationAssetNode);
                }
            }
            
        
        }
        
    
        #region Applicable_
        private XsdTypeBoolean applicable_;
        public XsdTypeBoolean Applicable_
        {
            get
            {
                if (this.applicable_ != null)
                {
                    return this.applicable_; 
                }
                else if (this.applicableIDRef_ != null)
                {
                    applicable_ = IDManager.getID(applicableIDRef_) as XsdTypeBoolean;
                    return this.applicable_; 
                }
                else
                {
                      return this.applicable_; 
                }
            }
            set
            {
                if (this.applicable_ != value)
                {
                    this.applicable_ = value;
                }
            }
        }
        #endregion
        
        public string applicableIDRef_ { get; set; }
        #region GenerationAsset_
        private CommodityDeliveryPoint generationAsset_;
        public CommodityDeliveryPoint GenerationAsset_
        {
            get
            {
                if (this.generationAsset_ != null)
                {
                    return this.generationAsset_; 
                }
                else if (this.generationAssetIDRef_ != null)
                {
                    generationAsset_ = IDManager.getID(generationAssetIDRef_) as CommodityDeliveryPoint;
                    return this.generationAsset_; 
                }
                else
                {
                      return this.generationAsset_; 
                }
            }
            set
            {
                if (this.generationAsset_ != value)
                {
                    this.generationAsset_ = value;
                }
            }
        }
        #endregion
        
        public string generationAssetIDRef_ { get; set; }
        
    
        
    
    }
    
}


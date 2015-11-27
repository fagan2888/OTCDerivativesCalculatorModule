using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GasProduct : ISerialized
    {
        public GasProduct(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        GasProductTypeEnum ob = new GasProductTypeEnum(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new GasProductTypeEnum(typeNode);
                    }
                }
                else
                {
                    type_ = new GasProductTypeEnum(typeNode);
                }
            }
            
        
            XmlNode calorificValueNode = xmlNode.SelectSingleNode("calorificValue");
            
            if (calorificValueNode != null)
            {
                if (calorificValueNode.Attributes["href"] != null || calorificValueNode.Attributes["id"] != null) 
                {
                    if (calorificValueNode.Attributes["id"] != null) 
                    {
                        calorificValueIDRef_ = calorificValueNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(calorificValueNode);
                        IDManager.SetID(calorificValueIDRef_, ob);
                    }
                    else if (calorificValueNode.Attributes["href"] != null)
                    {
                        calorificValueIDRef_ = calorificValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calorificValue_ = new NonNegativeDecimal(calorificValueNode);
                    }
                }
                else
                {
                    calorificValue_ = new NonNegativeDecimal(calorificValueNode);
                }
            }
            
        
            XmlNode qualityNode = xmlNode.SelectSingleNode("quality");
            
            if (qualityNode != null)
            {
                if (qualityNode.Attributes["href"] != null || qualityNode.Attributes["id"] != null) 
                {
                    if (qualityNode.Attributes["id"] != null) 
                    {
                        qualityIDRef_ = qualityNode.Attributes["id"].Value;
                        GasQuality ob = new GasQuality(qualityNode);
                        IDManager.SetID(qualityIDRef_, ob);
                    }
                    else if (qualityNode.Attributes["href"] != null)
                    {
                        qualityIDRef_ = qualityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quality_ = new GasQuality(qualityNode);
                    }
                }
                else
                {
                    quality_ = new GasQuality(qualityNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private GasProductTypeEnum type_;
        public GasProductTypeEnum Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as GasProductTypeEnum;
                    return this.type_; 
                }
                else
                {
                      return this.type_; 
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region CalorificValue_
        private NonNegativeDecimal calorificValue_;
        public NonNegativeDecimal CalorificValue_
        {
            get
            {
                if (this.calorificValue_ != null)
                {
                    return this.calorificValue_; 
                }
                else if (this.calorificValueIDRef_ != null)
                {
                    calorificValue_ = IDManager.getID(calorificValueIDRef_) as NonNegativeDecimal;
                    return this.calorificValue_; 
                }
                else
                {
                      return this.calorificValue_; 
                }
            }
            set
            {
                if (this.calorificValue_ != value)
                {
                    this.calorificValue_ = value;
                }
            }
        }
        #endregion
        
        public string calorificValueIDRef_ { get; set; }
        #region Quality_
        private GasQuality quality_;
        public GasQuality Quality_
        {
            get
            {
                if (this.quality_ != null)
                {
                    return this.quality_; 
                }
                else if (this.qualityIDRef_ != null)
                {
                    quality_ = IDManager.getID(qualityIDRef_) as GasQuality;
                    return this.quality_; 
                }
                else
                {
                      return this.quality_; 
                }
            }
            set
            {
                if (this.quality_ != value)
                {
                    this.quality_ = value;
                }
            }
        }
        #endregion
        
        public string qualityIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GasProduct
    {
        public GasProduct(XmlNode xmlNode)
        {
            XmlNodeList typeNodeList = xmlNode.SelectNodes("type");
            if (typeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in typeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        typeIDRef = item.Attributes["id"].Name;
                        GasProductTypeEnum ob = GasProductTypeEnum();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new GasProductTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList calorificValueNodeList = xmlNode.SelectNodes("calorificValue");
            if (calorificValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calorificValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calorificValueIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(calorificValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calorificValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calorificValue = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList qualityNodeList = xmlNode.SelectNodes("quality");
            if (qualityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in qualityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        qualityIDRef = item.Attributes["id"].Name;
                        GasQuality ob = GasQuality();
                        IDManager.SetID(qualityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        qualityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quality = new GasQuality(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private GasProductTypeEnum type;
        public GasProductTypeEnum Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as GasProductTypeEnum;
                    return this.type; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }
        #endregion
        
        public string GasProductTypeEnumIDRef { get; set; }
        #region CalorificValue
        private NonNegativeDecimal calorificValue;
        public NonNegativeDecimal CalorificValue
        {
            get
            {
                if (this.calorificValue != null)
                {
                    return this.calorificValue; 
                }
                else if (this.calorificValueIDRef != null)
                {
                    calorificValue = IDManager.getID(calorificValueIDRef) as NonNegativeDecimal;
                    return this.calorificValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calorificValue != value)
                {
                    this.calorificValue = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region Quality
        private GasQuality quality;
        public GasQuality Quality
        {
            get
            {
                if (this.quality != null)
                {
                    return this.quality; 
                }
                else if (this.qualityIDRef != null)
                {
                    quality = IDManager.getID(qualityIDRef) as GasQuality;
                    return this.quality; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quality != value)
                {
                    this.quality = value;
                }
            }
        }
        #endregion
        
        public string GasQualityIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


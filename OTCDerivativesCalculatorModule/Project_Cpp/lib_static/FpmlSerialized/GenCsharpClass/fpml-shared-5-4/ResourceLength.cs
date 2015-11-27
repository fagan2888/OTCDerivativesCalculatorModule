using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ResourceLength
    {
        public ResourceLength(XmlNode xmlNode)
        {
            XmlNodeList lengthUnitNodeList = xmlNode.SelectNodes("lengthUnit");
            if (lengthUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lengthUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lengthUnitIDRef = item.Attributes["id"].Name;
                        LengthUnitEnum ob = LengthUnitEnum();
                        IDManager.SetID(lengthUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lengthUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lengthUnit = new LengthUnitEnum(item);
                    }
                }
            }
            
        
            XmlNodeList lengthValueNodeList = xmlNode.SelectNodes("lengthValue");
            if (lengthValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lengthValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lengthValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(lengthValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lengthValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lengthValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region LengthUnit
        private LengthUnitEnum lengthUnit;
        public LengthUnitEnum LengthUnit
        {
            get
            {
                if (this.lengthUnit != null)
                {
                    return this.lengthUnit; 
                }
                else if (this.lengthUnitIDRef != null)
                {
                    lengthUnit = IDManager.getID(lengthUnitIDRef) as LengthUnitEnum;
                    return this.lengthUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lengthUnit != value)
                {
                    this.lengthUnit = value;
                }
            }
        }
        #endregion
        
        public string LengthUnitEnumIDRef { get; set; }
        #region LengthValue
        private XsdTypeDecimal lengthValue;
        public XsdTypeDecimal LengthValue
        {
            get
            {
                if (this.lengthValue != null)
                {
                    return this.lengthValue; 
                }
                else if (this.lengthValueIDRef != null)
                {
                    lengthValue = IDManager.getID(lengthValueIDRef) as XsdTypeDecimal;
                    return this.lengthValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lengthValue != value)
                {
                    this.lengthValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}


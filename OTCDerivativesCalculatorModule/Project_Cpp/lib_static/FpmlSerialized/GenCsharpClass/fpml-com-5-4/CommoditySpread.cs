using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommoditySpread
    {
        public CommoditySpread(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList spreadConversionFactorNodeList = xmlNode.SelectNodes("spreadConversionFactor");
            if (spreadConversionFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadConversionFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadConversionFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spreadConversionFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadConversionFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spreadConversionFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList spreadUnitNodeList = xmlNode.SelectNodes("spreadUnit");
            if (spreadUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadUnitIDRef = item.Attributes["id"].Name;
                        QuantityUnit ob = QuantityUnit();
                        IDManager.SetID(spreadUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spreadUnit = new QuantityUnit(item);
                    }
                }
            }
            
        
        }
        
    
        #region SpreadConversionFactor
        private XsdTypeDecimal spreadConversionFactor;
        public XsdTypeDecimal SpreadConversionFactor
        {
            get
            {
                if (this.spreadConversionFactor != null)
                {
                    return this.spreadConversionFactor; 
                }
                else if (this.spreadConversionFactorIDRef != null)
                {
                    spreadConversionFactor = IDManager.getID(spreadConversionFactorIDRef) as XsdTypeDecimal;
                    return this.spreadConversionFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadConversionFactor != value)
                {
                    this.spreadConversionFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region SpreadUnit
        private QuantityUnit spreadUnit;
        public QuantityUnit SpreadUnit
        {
            get
            {
                if (this.spreadUnit != null)
                {
                    return this.spreadUnit; 
                }
                else if (this.spreadUnitIDRef != null)
                {
                    spreadUnit = IDManager.getID(spreadUnitIDRef) as QuantityUnit;
                    return this.spreadUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadUnit != value)
                {
                    this.spreadUnit = value;
                }
            }
        }
        #endregion
        
        public string QuantityUnitIDRef { get; set; }
        
    
        
    
    }
    
}


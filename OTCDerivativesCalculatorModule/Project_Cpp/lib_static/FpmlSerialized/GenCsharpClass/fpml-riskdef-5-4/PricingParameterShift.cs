using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingParameterShift
    {
        public PricingParameterShift(XmlNode xmlNode)
        {
            XmlNodeList parameterReferenceNodeList = xmlNode.SelectNodes("parameterReference");
            if (parameterReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parameterReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parameterReferenceIDRef = item.Attributes["id"].Name;
                        AssetOrTermPointOrPricingStructureReference ob = AssetOrTermPointOrPricingStructureReference();
                        IDManager.SetID(parameterReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parameterReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parameterReference = new AssetOrTermPointOrPricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList shiftNodeList = xmlNode.SelectNodes("shift");
            if (shiftNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in shiftNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shiftIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(shiftIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shiftIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        shift = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList shiftUnitsNodeList = xmlNode.SelectNodes("shiftUnits");
            if (shiftUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in shiftUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shiftUnitsIDRef = item.Attributes["id"].Name;
                        PriceQuoteUnits ob = PriceQuoteUnits();
                        IDManager.SetID(shiftUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shiftUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        shiftUnits = new PriceQuoteUnits(item);
                    }
                }
            }
            
        
        }
        
    
        #region ParameterReference
        private AssetOrTermPointOrPricingStructureReference parameterReference;
        public AssetOrTermPointOrPricingStructureReference ParameterReference
        {
            get
            {
                if (this.parameterReference != null)
                {
                    return this.parameterReference; 
                }
                else if (this.parameterReferenceIDRef != null)
                {
                    parameterReference = IDManager.getID(parameterReferenceIDRef) as AssetOrTermPointOrPricingStructureReference;
                    return this.parameterReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parameterReference != value)
                {
                    this.parameterReference = value;
                }
            }
        }
        #endregion
        
        public string AssetOrTermPointOrPricingStructureReferenceIDRef { get; set; }
        #region Shift
        private XsdTypeDecimal shift;
        public XsdTypeDecimal Shift
        {
            get
            {
                if (this.shift != null)
                {
                    return this.shift; 
                }
                else if (this.shiftIDRef != null)
                {
                    shift = IDManager.getID(shiftIDRef) as XsdTypeDecimal;
                    return this.shift; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shift != value)
                {
                    this.shift = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ShiftUnits
        private PriceQuoteUnits shiftUnits;
        public PriceQuoteUnits ShiftUnits
        {
            get
            {
                if (this.shiftUnits != null)
                {
                    return this.shiftUnits; 
                }
                else if (this.shiftUnitsIDRef != null)
                {
                    shiftUnits = IDManager.getID(shiftUnitsIDRef) as PriceQuoteUnits;
                    return this.shiftUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shiftUnits != value)
                {
                    this.shiftUnits = value;
                }
            }
        }
        #endregion
        
        public string PriceQuoteUnitsIDRef { get; set; }
        
    
        
    
    }
    
}


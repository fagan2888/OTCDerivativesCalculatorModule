using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ParametricAdjustment
    {
        public ParametricAdjustment(XmlNode xmlNode)
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
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList inputUnitsNodeList = xmlNode.SelectNodes("inputUnits");
            if (inputUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inputUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inputUnitsIDRef = item.Attributes["id"].Name;
                        PriceQuoteUnits ob = PriceQuoteUnits();
                        IDManager.SetID(inputUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inputUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inputUnits = new PriceQuoteUnits(item);
                    }
                }
            }
            
        
            XmlNodeList datapointNodeList = xmlNode.SelectNodes("datapoint");
            
            foreach (XmlNode item in datapointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        datapointIDRef = item.Attributes["id"].Name;
                        List<ParametricAdjustmentPoint> ob = new List<ParametricAdjustmentPoint>();
                        ob.Add(new ParametricAdjustmentPoint(item));
                        IDManager.SetID(datapointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        datapointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    datapoint.Add(new ParametricAdjustmentPoint(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeNormalizedString name;
        public XsdTypeNormalizedString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeNormalizedString;
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
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region InputUnits
        private PriceQuoteUnits inputUnits;
        public PriceQuoteUnits InputUnits
        {
            get
            {
                if (this.inputUnits != null)
                {
                    return this.inputUnits; 
                }
                else if (this.inputUnitsIDRef != null)
                {
                    inputUnits = IDManager.getID(inputUnitsIDRef) as PriceQuoteUnits;
                    return this.inputUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inputUnits != value)
                {
                    this.inputUnits = value;
                }
            }
        }
        #endregion
        
        public string PriceQuoteUnitsIDRef { get; set; }
        #region Datapoint
        private List<ParametricAdjustmentPoint> datapoint;
        public List<ParametricAdjustmentPoint> Datapoint
        {
            get
            {
                if (this.datapoint != null)
                {
                    return this.datapoint; 
                }
                else if (this.datapointIDRef != null)
                {
                    datapoint = IDManager.getID(datapointIDRef) as List<ParametricAdjustmentPoint>;
                    return this.datapoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.datapoint != value)
                {
                    this.datapoint = value;
                }
            }
        }
        #endregion
        
        public string ParametricAdjustmentPointIDRef { get; set; }
        
    
        
    
    }
    
}


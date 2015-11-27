using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherIndex
    {
        public WeatherIndex(XmlNode xmlNode)
        {
            XmlNodeList quantityNodeList = xmlNode.SelectNodes("quantity");
            if (quantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(quantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantity = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList unitNodeList = xmlNode.SelectNodes("unit");
            if (unitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unitIDRef = item.Attributes["id"].Name;
                        QuantityUnit ob = QuantityUnit();
                        IDManager.SetID(unitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unit = new QuantityUnit(item);
                    }
                }
            }
            
        
        }
        
    
        #region Quantity
        private XsdTypeDecimal quantity;
        public XsdTypeDecimal Quantity
        {
            get
            {
                if (this.quantity != null)
                {
                    return this.quantity; 
                }
                else if (this.quantityIDRef != null)
                {
                    quantity = IDManager.getID(quantityIDRef) as XsdTypeDecimal;
                    return this.quantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantity != value)
                {
                    this.quantity = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Unit
        private QuantityUnit unit;
        public QuantityUnit Unit
        {
            get
            {
                if (this.unit != null)
                {
                    return this.unit; 
                }
                else if (this.unitIDRef != null)
                {
                    unit = IDManager.getID(unitIDRef) as QuantityUnit;
                    return this.unit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unit != value)
                {
                    this.unit = value;
                }
            }
        }
        #endregion
        
        public string QuantityUnitIDRef { get; set; }
        
    
        
    
    }
    
}


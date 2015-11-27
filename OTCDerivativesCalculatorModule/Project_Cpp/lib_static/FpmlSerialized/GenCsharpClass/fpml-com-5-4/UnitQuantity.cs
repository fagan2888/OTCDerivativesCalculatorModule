using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class UnitQuantity
    {
        public UnitQuantity(XmlNode xmlNode)
        {
            XmlNodeList quantityUnitNodeList = xmlNode.SelectNodes("quantityUnit");
            if (quantityUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityUnitIDRef = item.Attributes["id"].Name;
                        QuantityUnit ob = QuantityUnit();
                        IDManager.SetID(quantityUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantityUnit = new QuantityUnit(item);
                    }
                }
            }
            
        
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
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(quantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantity = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region QuantityUnit
        private QuantityUnit quantityUnit;
        public QuantityUnit QuantityUnit
        {
            get
            {
                if (this.quantityUnit != null)
                {
                    return this.quantityUnit; 
                }
                else if (this.quantityUnitIDRef != null)
                {
                    quantityUnit = IDManager.getID(quantityUnitIDRef) as QuantityUnit;
                    return this.quantityUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantityUnit != value)
                {
                    this.quantityUnit = value;
                }
            }
        }
        #endregion
        
        public string QuantityUnitIDRef { get; set; }
        #region Quantity
        private NonNegativeDecimal quantity;
        public NonNegativeDecimal Quantity
        {
            get
            {
                if (this.quantity != null)
                {
                    return this.quantity; 
                }
                else if (this.quantityIDRef != null)
                {
                    quantity = IDManager.getID(quantityIDRef) as NonNegativeDecimal;
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
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}


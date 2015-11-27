using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityNotionalQuantity
    {
        public CommodityNotionalQuantity(XmlNode xmlNode)
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
            
        
            XmlNodeList quantityFrequencyNodeList = xmlNode.SelectNodes("quantityFrequency");
            if (quantityFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityFrequencyIDRef = item.Attributes["id"].Name;
                        CommodityQuantityFrequency ob = CommodityQuantityFrequency();
                        IDManager.SetID(quantityFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantityFrequency = new CommodityQuantityFrequency(item);
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
        #region QuantityFrequency
        private CommodityQuantityFrequency quantityFrequency;
        public CommodityQuantityFrequency QuantityFrequency
        {
            get
            {
                if (this.quantityFrequency != null)
                {
                    return this.quantityFrequency; 
                }
                else if (this.quantityFrequencyIDRef != null)
                {
                    quantityFrequency = IDManager.getID(quantityFrequencyIDRef) as CommodityQuantityFrequency;
                    return this.quantityFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantityFrequency != value)
                {
                    this.quantityFrequency = value;
                }
            }
        }
        #endregion
        
        public string CommodityQuantityFrequencyIDRef { get; set; }
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
        
    
        
    
    }
    
}


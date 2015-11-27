using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CollateralValueAllocation
    {
        public CollateralValueAllocation(XmlNode xmlNode)
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
                        CollateralValueAllocationEnum ob = CollateralValueAllocationEnum();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new CollateralValueAllocationEnum(item);
                    }
                }
            }
            
        
            XmlNodeList valueNodeList = xmlNode.SelectNodes("value");
            
            foreach (XmlNode item in valueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueIDRef = item.Attributes["id"].Name;
                        List<Money> ob = new List<Money>();
                        ob.Add(new Money(item));
                        IDManager.SetID(valueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    value.Add(new Money(item));
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private CollateralValueAllocationEnum type;
        public CollateralValueAllocationEnum Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as CollateralValueAllocationEnum;
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
        
        public string CollateralValueAllocationEnumIDRef { get; set; }
        #region Value
        private List<Money> value;
        public List<Money> Value
        {
            get
            {
                if (this.value != null)
                {
                    return this.value; 
                }
                else if (this.valueIDRef != null)
                {
                    value = IDManager.getID(valueIDRef) as List<Money>;
                    return this.value; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}


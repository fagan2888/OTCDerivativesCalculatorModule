using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityProduct
    {
        public ElectricityProduct(XmlNode xmlNode)
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
                        ElectricityProductTypeEnum ob = ElectricityProductTypeEnum();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new ElectricityProductTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList voltageNodeList = xmlNode.SelectNodes("voltage");
            if (voltageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in voltageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        voltageIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(voltageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        voltageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        voltage = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private ElectricityProductTypeEnum type;
        public ElectricityProductTypeEnum Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as ElectricityProductTypeEnum;
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
        
        public string ElectricityProductTypeEnumIDRef { get; set; }
        #region Voltage
        private PositiveDecimal voltage;
        public PositiveDecimal Voltage
        {
            get
            {
                if (this.voltage != null)
                {
                    return this.voltage; 
                }
                else if (this.voltageIDRef != null)
                {
                    voltage = IDManager.getID(voltageIDRef) as PositiveDecimal;
                    return this.voltage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.voltage != value)
                {
                    this.voltage = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityProduct : ISerialized
    {
        public ElectricityProduct(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        ElectricityProductTypeEnum ob = new ElectricityProductTypeEnum(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new ElectricityProductTypeEnum(typeNode);
                    }
                }
                else
                {
                    type_ = new ElectricityProductTypeEnum(typeNode);
                }
            }
            
        
            XmlNode voltageNode = xmlNode.SelectSingleNode("voltage");
            
            if (voltageNode != null)
            {
                if (voltageNode.Attributes["href"] != null || voltageNode.Attributes["id"] != null) 
                {
                    if (voltageNode.Attributes["id"] != null) 
                    {
                        voltageIDRef_ = voltageNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(voltageNode);
                        IDManager.SetID(voltageIDRef_, ob);
                    }
                    else if (voltageNode.Attributes["href"] != null)
                    {
                        voltageIDRef_ = voltageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        voltage_ = new PositiveDecimal(voltageNode);
                    }
                }
                else
                {
                    voltage_ = new PositiveDecimal(voltageNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private ElectricityProductTypeEnum type_;
        public ElectricityProductTypeEnum Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as ElectricityProductTypeEnum;
                    return this.type_; 
                }
                else
                {
                      return this.type_; 
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region Voltage_
        private PositiveDecimal voltage_;
        public PositiveDecimal Voltage_
        {
            get
            {
                if (this.voltage_ != null)
                {
                    return this.voltage_; 
                }
                else if (this.voltageIDRef_ != null)
                {
                    voltage_ = IDManager.getID(voltageIDRef_) as PositiveDecimal;
                    return this.voltage_; 
                }
                else
                {
                      return this.voltage_; 
                }
            }
            set
            {
                if (this.voltage_ != value)
                {
                    this.voltage_ = value;
                }
            }
        }
        #endregion
        
        public string voltageIDRef_ { get; set; }
        
    
        
    
    }
    
}


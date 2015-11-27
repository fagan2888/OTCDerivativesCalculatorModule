using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CollateralValueAllocation : ISerialized
    {
        public CollateralValueAllocation(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        CollateralValueAllocationEnum ob = new CollateralValueAllocationEnum(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new CollateralValueAllocationEnum(typeNode);
                    }
                }
                else
                {
                    type_ = new CollateralValueAllocationEnum(typeNode);
                }
            }
            
        
            XmlNodeList valueNodeList = xmlNode.SelectNodes("value");
            
            if (valueNodeList != null)
            {
                this.value_ = new List<Money>();
                foreach (XmlNode item in valueNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            valueIDRef_ = item.Attributes["id"].Value;
                            value_.Add(new Money(item));
                            IDManager.SetID(valueIDRef_, value_[value_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            valueIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        value_.Add(new Money(item));
                        }
                    }
                    else
                    {
                        value_.Add(new Money(item));
                    }
                }
            }
            
        
        }
        
    
        #region Type_
        private CollateralValueAllocationEnum type_;
        public CollateralValueAllocationEnum Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as CollateralValueAllocationEnum;
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
        #region Value_
        private List<Money> value_;
        public List<Money> Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    return this.value_; 
                }
                else
                {
                      return this.value_; 
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
        
    
        
    
    }
    
}


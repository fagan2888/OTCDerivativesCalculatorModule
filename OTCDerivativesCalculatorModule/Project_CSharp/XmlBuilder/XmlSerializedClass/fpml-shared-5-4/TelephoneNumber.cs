using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TelephoneNumber : ISerialized
    {
        public TelephoneNumber(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        TelephoneTypeEnum ob = new TelephoneTypeEnum(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new TelephoneTypeEnum(typeNode);
                    }
                }
                else
                {
                    type_ = new TelephoneTypeEnum(typeNode);
                }
            }
            
        
            XmlNode numberNode = xmlNode.SelectSingleNode("number");
            
            if (numberNode != null)
            {
                if (numberNode.Attributes["href"] != null || numberNode.Attributes["id"] != null) 
                {
                    if (numberNode.Attributes["id"] != null) 
                    {
                        numberIDRef_ = numberNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(numberNode);
                        IDManager.SetID(numberIDRef_, ob);
                    }
                    else if (numberNode.Attributes["href"] != null)
                    {
                        numberIDRef_ = numberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        number_ = new XsdTypeString(numberNode);
                    }
                }
                else
                {
                    number_ = new XsdTypeString(numberNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private TelephoneTypeEnum type_;
        public TelephoneTypeEnum Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as TelephoneTypeEnum;
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
        #region Number_
        private XsdTypeString number_;
        public XsdTypeString Number_
        {
            get
            {
                if (this.number_ != null)
                {
                    return this.number_; 
                }
                else if (this.numberIDRef_ != null)
                {
                    number_ = IDManager.getID(numberIDRef_) as XsdTypeString;
                    return this.number_; 
                }
                else
                {
                      return this.number_; 
                }
            }
            set
            {
                if (this.number_ != value)
                {
                    this.number_ = value;
                }
            }
        }
        #endregion
        
        public string numberIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TelephoneNumber
    {
        public TelephoneNumber(XmlNode xmlNode)
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
                        TelephoneTypeEnum ob = TelephoneTypeEnum();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new TelephoneTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList numberNodeList = xmlNode.SelectNodes("number");
            if (numberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(numberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        number = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private TelephoneTypeEnum type;
        public TelephoneTypeEnum Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as TelephoneTypeEnum;
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
        
        public string TelephoneTypeEnumIDRef { get; set; }
        #region Number
        private XsdTypeString number;
        public XsdTypeString Number
        {
            get
            {
                if (this.number != null)
                {
                    return this.number; 
                }
                else if (this.numberIDRef != null)
                {
                    number = IDManager.getID(numberIDRef) as XsdTypeString;
                    return this.number; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.number != value)
                {
                    this.number = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeTimestamp
    {
        public TradeTimestamp(XmlNode xmlNode)
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
                        TimestampTypeScheme ob = TimestampTypeScheme();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new TimestampTypeScheme(item);
                    }
                }
            }
            
        
            XmlNodeList valueNodeList = xmlNode.SelectNodes("value");
            if (valueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(valueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        value = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private TimestampTypeScheme type;
        public TimestampTypeScheme Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as TimestampTypeScheme;
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
        
        public string TimestampTypeSchemeIDRef { get; set; }
        #region Value
        private XsdTypeDateTime value;
        public XsdTypeDateTime Value
        {
            get
            {
                if (this.value != null)
                {
                    return this.value; 
                }
                else if (this.valueIDRef != null)
                {
                    value = IDManager.getID(valueIDRef) as XsdTypeDateTime;
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
        
        public string XsdTypeDateTimeIDRef { get; set; }
        
    
        
    
    }
    
}


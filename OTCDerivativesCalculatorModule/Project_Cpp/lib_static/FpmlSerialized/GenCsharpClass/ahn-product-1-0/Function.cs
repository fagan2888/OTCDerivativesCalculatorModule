using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Function
    {
        public Function(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList truefalseNodeList = xmlNode.SelectNodes("truefalse");
            if (truefalseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in truefalseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        truefalseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(truefalseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        truefalseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        truefalse = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeToken name;
        public XsdTypeToken Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeToken;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Truefalse
        private XsdTypeBoolean truefalse;
        public XsdTypeBoolean Truefalse
        {
            get
            {
                if (this.truefalse != null)
                {
                    return this.truefalse; 
                }
                else if (this.truefalseIDRef != null)
                {
                    truefalse = IDManager.getID(truefalseIDRef) as XsdTypeBoolean;
                    return this.truefalse; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.truefalse != value)
                {
                    this.truefalse = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}


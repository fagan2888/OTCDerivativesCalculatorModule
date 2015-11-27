using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityIndex
    {
        public CommodityIndex(XmlNode xmlNode)
        {
            XmlNodeList codeNodeList = xmlNode.SelectNodes("code");
            if (codeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in codeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        codeIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(codeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        codeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        code = new XsdTypeToken(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList indexTypeNodeList = xmlNode.SelectNodes("indexType");
            if (indexTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexTypeIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(indexTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexType = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region Code
        private XsdTypeToken code;
        public XsdTypeToken Code
        {
            get
            {
                if (this.code != null)
                {
                    return this.code; 
                }
                else if (this.codeIDRef != null)
                {
                    code = IDManager.getID(codeIDRef) as XsdTypeToken;
                    return this.code; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.code != value)
                {
                    this.code = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
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
        #region IndexType
        private XsdTypeToken indexType;
        public XsdTypeToken IndexType
        {
            get
            {
                if (this.indexType != null)
                {
                    return this.indexType; 
                }
                else if (this.indexTypeIDRef != null)
                {
                    indexType = IDManager.getID(indexTypeIDRef) as XsdTypeToken;
                    return this.indexType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexType != value)
                {
                    this.indexType = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        
    
        
    
    }
    
}


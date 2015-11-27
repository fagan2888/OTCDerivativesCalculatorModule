using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VariableValue
    {
        public VariableValue(XmlNode xmlNode)
        {
            XmlNodeList indexRefNodeList = xmlNode.SelectNodes("indexRef");
            if (indexRefNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexRefNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexRefIDRef = item.Attributes["id"].Name;
                        IndexRef ob = IndexRef();
                        IDManager.SetID(indexRefIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexRefIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexRef = new IndexRef(item);
                    }
                }
            }
            
        
            XmlNodeList indexTimeRefNodeList = xmlNode.SelectNodes("indexTimeRef");
            if (indexTimeRefNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexTimeRefNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexTimeRefIDRef = item.Attributes["id"].Name;
                        IndexTimeRef ob = IndexTimeRef();
                        IDManager.SetID(indexTimeRefIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexTimeRefIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexTimeRef = new IndexTimeRef(item);
                    }
                }
            }
            
        
            XmlNodeList symbolNameNodeList = xmlNode.SelectNodes("symbolName");
            if (symbolNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in symbolNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        symbolNameIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(symbolNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        symbolNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        symbolName = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList constValueNodeList = xmlNode.SelectNodes("constValue");
            if (constValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDouble ob = XsdTypeDouble();
                        IDManager.SetID(constValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constValue = new XsdTypeDouble(item);
                    }
                }
            }
            
        
        }
        
    
        #region IndexRef
        private IndexRef indexRef;
        public IndexRef IndexRef
        {
            get
            {
                if (this.indexRef != null)
                {
                    return this.indexRef; 
                }
                else if (this.indexRefIDRef != null)
                {
                    indexRef = IDManager.getID(indexRefIDRef) as IndexRef;
                    return this.indexRef; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexRef != value)
                {
                    this.indexRef = value;
                }
            }
        }
        #endregion
        
        public string IndexRefIDRef { get; set; }
        #region IndexTimeRef
        private IndexTimeRef indexTimeRef;
        public IndexTimeRef IndexTimeRef
        {
            get
            {
                if (this.indexTimeRef != null)
                {
                    return this.indexTimeRef; 
                }
                else if (this.indexTimeRefIDRef != null)
                {
                    indexTimeRef = IDManager.getID(indexTimeRefIDRef) as IndexTimeRef;
                    return this.indexTimeRef; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexTimeRef != value)
                {
                    this.indexTimeRef = value;
                }
            }
        }
        #endregion
        
        public string IndexTimeRefIDRef { get; set; }
        #region SymbolName
        private XsdTypeToken symbolName;
        public XsdTypeToken SymbolName
        {
            get
            {
                if (this.symbolName != null)
                {
                    return this.symbolName; 
                }
                else if (this.symbolNameIDRef != null)
                {
                    symbolName = IDManager.getID(symbolNameIDRef) as XsdTypeToken;
                    return this.symbolName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.symbolName != value)
                {
                    this.symbolName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region ConstValue
        private XsdTypeDouble constValue;
        public XsdTypeDouble ConstValue
        {
            get
            {
                if (this.constValue != null)
                {
                    return this.constValue; 
                }
                else if (this.constValueIDRef != null)
                {
                    constValue = IDManager.getID(constValueIDRef) as XsdTypeDouble;
                    return this.constValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constValue != value)
                {
                    this.constValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDoubleIDRef { get; set; }
        public string choiceStr_paraType;
        
    
        
    
    }
    
}


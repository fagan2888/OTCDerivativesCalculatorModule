using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VariableValue : ISerialized
    {
        public VariableValue(XmlNode xmlNode)
        {
            XmlNode indexRefNode = xmlNode.SelectSingleNode("indexRef");
            
            if (indexRefNode != null)
            {
                if (indexRefNode.Attributes["href"] != null || indexRefNode.Attributes["id"] != null) 
                {
                    if (indexRefNode.Attributes["id"] != null) 
                    {
                        indexRefIDRef_ = indexRefNode.Attributes["id"].Value;
                        IndexRef ob = new IndexRef(indexRefNode);
                        IDManager.SetID(indexRefIDRef_, ob);
                    }
                    else if (indexRefNode.Attributes["href"] != null)
                    {
                        indexRefIDRef_ = indexRefNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexRef_ = new IndexRef(indexRefNode);
                    }
                }
                else
                {
                    indexRef_ = new IndexRef(indexRefNode);
                }
            }
            
        
            XmlNode indexTimeRefNode = xmlNode.SelectSingleNode("indexTimeRef");
            
            if (indexTimeRefNode != null)
            {
                if (indexTimeRefNode.Attributes["href"] != null || indexTimeRefNode.Attributes["id"] != null) 
                {
                    if (indexTimeRefNode.Attributes["id"] != null) 
                    {
                        indexTimeRefIDRef_ = indexTimeRefNode.Attributes["id"].Value;
                        IndexTimeRef ob = new IndexTimeRef(indexTimeRefNode);
                        IDManager.SetID(indexTimeRefIDRef_, ob);
                    }
                    else if (indexTimeRefNode.Attributes["href"] != null)
                    {
                        indexTimeRefIDRef_ = indexTimeRefNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexTimeRef_ = new IndexTimeRef(indexTimeRefNode);
                    }
                }
                else
                {
                    indexTimeRef_ = new IndexTimeRef(indexTimeRefNode);
                }
            }
            
        
            XmlNode symbolNameNode = xmlNode.SelectSingleNode("symbolName");
            
            if (symbolNameNode != null)
            {
                if (symbolNameNode.Attributes["href"] != null || symbolNameNode.Attributes["id"] != null) 
                {
                    if (symbolNameNode.Attributes["id"] != null) 
                    {
                        symbolNameIDRef_ = symbolNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(symbolNameNode);
                        IDManager.SetID(symbolNameIDRef_, ob);
                    }
                    else if (symbolNameNode.Attributes["href"] != null)
                    {
                        symbolNameIDRef_ = symbolNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        symbolName_ = new XsdTypeToken(symbolNameNode);
                    }
                }
                else
                {
                    symbolName_ = new XsdTypeToken(symbolNameNode);
                }
            }
            
        
            XmlNode constValueNode = xmlNode.SelectSingleNode("constValue");
            
            if (constValueNode != null)
            {
                if (constValueNode.Attributes["href"] != null || constValueNode.Attributes["id"] != null) 
                {
                    if (constValueNode.Attributes["id"] != null) 
                    {
                        constValueIDRef_ = constValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(constValueNode);
                        IDManager.SetID(constValueIDRef_, ob);
                    }
                    else if (constValueNode.Attributes["href"] != null)
                    {
                        constValueIDRef_ = constValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constValue_ = new XsdTypeDouble(constValueNode);
                    }
                }
                else
                {
                    constValue_ = new XsdTypeDouble(constValueNode);
                }
            }
            
        
        }
        
    
        #region IndexRef_
        private IndexRef indexRef_;
        public IndexRef IndexRef_
        {
            get
            {
                if (this.indexRef_ != null)
                {
                    return this.indexRef_; 
                }
                else if (this.indexRefIDRef_ != null)
                {
                    indexRef_ = IDManager.getID(indexRefIDRef_) as IndexRef;
                    return this.indexRef_; 
                }
                else
                {
                      return this.indexRef_; 
                }
            }
            set
            {
                if (this.indexRef_ != value)
                {
                    this.indexRef_ = value;
                }
            }
        }
        #endregion
        
        public string indexRefIDRef_ { get; set; }
        #region IndexTimeRef_
        private IndexTimeRef indexTimeRef_;
        public IndexTimeRef IndexTimeRef_
        {
            get
            {
                if (this.indexTimeRef_ != null)
                {
                    return this.indexTimeRef_; 
                }
                else if (this.indexTimeRefIDRef_ != null)
                {
                    indexTimeRef_ = IDManager.getID(indexTimeRefIDRef_) as IndexTimeRef;
                    return this.indexTimeRef_; 
                }
                else
                {
                      return this.indexTimeRef_; 
                }
            }
            set
            {
                if (this.indexTimeRef_ != value)
                {
                    this.indexTimeRef_ = value;
                }
            }
        }
        #endregion
        
        public string indexTimeRefIDRef_ { get; set; }
        #region SymbolName_
        private XsdTypeToken symbolName_;
        public XsdTypeToken SymbolName_
        {
            get
            {
                if (this.symbolName_ != null)
                {
                    return this.symbolName_; 
                }
                else if (this.symbolNameIDRef_ != null)
                {
                    symbolName_ = IDManager.getID(symbolNameIDRef_) as XsdTypeToken;
                    return this.symbolName_; 
                }
                else
                {
                      return this.symbolName_; 
                }
            }
            set
            {
                if (this.symbolName_ != value)
                {
                    this.symbolName_ = value;
                }
            }
        }
        #endregion
        
        public string symbolNameIDRef_ { get; set; }
        #region ConstValue_
        private XsdTypeDouble constValue_;
        public XsdTypeDouble ConstValue_
        {
            get
            {
                if (this.constValue_ != null)
                {
                    return this.constValue_; 
                }
                else if (this.constValueIDRef_ != null)
                {
                    constValue_ = IDManager.getID(constValueIDRef_) as XsdTypeDouble;
                    return this.constValue_; 
                }
                else
                {
                      return this.constValue_; 
                }
            }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                }
            }
        }
        #endregion
        
        public string constValueIDRef_ { get; set; }
        public string choiceStr_paraType;
        
    
        
    
    }
    
}


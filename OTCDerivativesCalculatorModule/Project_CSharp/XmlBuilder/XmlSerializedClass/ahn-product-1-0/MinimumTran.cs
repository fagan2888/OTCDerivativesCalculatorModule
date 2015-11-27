using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MinimumTran : ISerialized
    {
        public MinimumTran(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList variableNodeList = xmlNode.SelectNodes("variable");
            
            if (variableNodeList != null)
            {
                this.variable_ = new List<VariableValue>();
                foreach (XmlNode item in variableNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            variableIDRef_ = item.Attributes["id"].Value;
                            variable_.Add(new VariableValue(item));
                            IDManager.SetID(variableIDRef_, variable_[variable_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            variableIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        variable_.Add(new VariableValue(item));
                        }
                    }
                    else
                    {
                        variable_.Add(new VariableValue(item));
                    }
                }
            }
            
        
        }
        
    
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
        #region Variable_
        private List<VariableValue> variable_;
        public List<VariableValue> Variable_
        {
            get
            {
                if (this.variable_ != null)
                {
                    return this.variable_; 
                }
                else if (this.variableIDRef_ != null)
                {
                    return this.variable_; 
                }
                else
                {
                      return this.variable_; 
                }
            }
            set
            {
                if (this.variable_ != value)
                {
                    this.variable_ = value;
                }
            }
        }
        #endregion
        
        public string variableIDRef_ { get; set; }
        
    
        
    
    }
    
}


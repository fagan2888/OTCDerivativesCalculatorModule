using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MinimumTran
    {
        public MinimumTran(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList variableNodeList = xmlNode.SelectNodes("variable");
            
            foreach (XmlNode item in variableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        variableIDRef = item.Attributes["id"].Name;
                        List<VariableValue> ob = new List<VariableValue>();
                        ob.Add(new VariableValue(item));
                        IDManager.SetID(variableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        variableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    variable.Add(new VariableValue(item));
                    }
                }
            }
            
        
        }
        
    
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
        #region Variable
        private List<VariableValue> variable;
        public List<VariableValue> Variable
        {
            get
            {
                if (this.variable != null)
                {
                    return this.variable; 
                }
                else if (this.variableIDRef != null)
                {
                    variable = IDManager.getID(variableIDRef) as List<VariableValue>;
                    return this.variable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.variable != value)
                {
                    this.variable = value;
                }
            }
        }
        #endregion
        
        public string VariableValueIDRef { get; set; }
        
    
        
    
    }
    
}


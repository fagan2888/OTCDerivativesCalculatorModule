using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnTran
    {
        public ReturnTran(XmlNode xmlNode)
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
            
        
            XmlNodeList returnTypeNodeList = xmlNode.SelectNodes("returnType");
            if (returnTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnTypeIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(returnTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        returnType = new XsdTypeToken(item);
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
            
        
            XmlNodeList numerCalculationNodeList = xmlNode.SelectNodes("numerCalculation");
            if (numerCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numerCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numerCalculationIDRef = item.Attributes["id"].Name;
                        VariableValue ob = VariableValue();
                        IDManager.SetID(numerCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numerCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numerCalculation = new VariableValue(item);
                    }
                }
            }
            
        
            XmlNodeList denumerCalculationNodeList = xmlNode.SelectNodes("denumerCalculation");
            if (denumerCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in denumerCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        denumerCalculationIDRef = item.Attributes["id"].Name;
                        VariableValue ob = VariableValue();
                        IDManager.SetID(denumerCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        denumerCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        denumerCalculation = new VariableValue(item);
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
        #region ReturnType
        private XsdTypeToken returnType;
        public XsdTypeToken ReturnType
        {
            get
            {
                if (this.returnType != null)
                {
                    return this.returnType; 
                }
                else if (this.returnTypeIDRef != null)
                {
                    returnType = IDManager.getID(returnTypeIDRef) as XsdTypeToken;
                    return this.returnType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.returnType != value)
                {
                    this.returnType = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
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
        #region NumerCalculation
        private VariableValue numerCalculation;
        public VariableValue NumerCalculation
        {
            get
            {
                if (this.numerCalculation != null)
                {
                    return this.numerCalculation; 
                }
                else if (this.numerCalculationIDRef != null)
                {
                    numerCalculation = IDManager.getID(numerCalculationIDRef) as VariableValue;
                    return this.numerCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numerCalculation != value)
                {
                    this.numerCalculation = value;
                }
            }
        }
        #endregion
        
        public string VariableValueIDRef { get; set; }
        #region DenumerCalculation
        private VariableValue denumerCalculation;
        public VariableValue DenumerCalculation
        {
            get
            {
                if (this.denumerCalculation != null)
                {
                    return this.denumerCalculation; 
                }
                else if (this.denumerCalculationIDRef != null)
                {
                    denumerCalculation = IDManager.getID(denumerCalculationIDRef) as VariableValue;
                    return this.denumerCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.denumerCalculation != value)
                {
                    this.denumerCalculation = value;
                }
            }
        }
        #endregion
        
        public string VariableValueIDRef { get; set; }
        
    
        
    
    }
    
}


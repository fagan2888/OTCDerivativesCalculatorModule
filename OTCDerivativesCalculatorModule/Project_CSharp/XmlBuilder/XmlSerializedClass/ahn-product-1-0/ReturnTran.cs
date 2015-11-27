using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnTran : ISerialized
    {
        public ReturnTran(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode returnTypeNode = xmlNode.SelectSingleNode("returnType");
            
            if (returnTypeNode != null)
            {
                if (returnTypeNode.Attributes["href"] != null || returnTypeNode.Attributes["id"] != null) 
                {
                    if (returnTypeNode.Attributes["id"] != null) 
                    {
                        returnTypeIDRef_ = returnTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(returnTypeNode);
                        IDManager.SetID(returnTypeIDRef_, ob);
                    }
                    else if (returnTypeNode.Attributes["href"] != null)
                    {
                        returnTypeIDRef_ = returnTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnType_ = new XsdTypeToken(returnTypeNode);
                    }
                }
                else
                {
                    returnType_ = new XsdTypeToken(returnTypeNode);
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
            
        
            XmlNode numerCalculationNode = xmlNode.SelectSingleNode("numerCalculation");
            
            if (numerCalculationNode != null)
            {
                if (numerCalculationNode.Attributes["href"] != null || numerCalculationNode.Attributes["id"] != null) 
                {
                    if (numerCalculationNode.Attributes["id"] != null) 
                    {
                        numerCalculationIDRef_ = numerCalculationNode.Attributes["id"].Value;
                        VariableValue ob = new VariableValue(numerCalculationNode);
                        IDManager.SetID(numerCalculationIDRef_, ob);
                    }
                    else if (numerCalculationNode.Attributes["href"] != null)
                    {
                        numerCalculationIDRef_ = numerCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numerCalculation_ = new VariableValue(numerCalculationNode);
                    }
                }
                else
                {
                    numerCalculation_ = new VariableValue(numerCalculationNode);
                }
            }
            
        
            XmlNode denumerCalculationNode = xmlNode.SelectSingleNode("denumerCalculation");
            
            if (denumerCalculationNode != null)
            {
                if (denumerCalculationNode.Attributes["href"] != null || denumerCalculationNode.Attributes["id"] != null) 
                {
                    if (denumerCalculationNode.Attributes["id"] != null) 
                    {
                        denumerCalculationIDRef_ = denumerCalculationNode.Attributes["id"].Value;
                        VariableValue ob = new VariableValue(denumerCalculationNode);
                        IDManager.SetID(denumerCalculationIDRef_, ob);
                    }
                    else if (denumerCalculationNode.Attributes["href"] != null)
                    {
                        denumerCalculationIDRef_ = denumerCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        denumerCalculation_ = new VariableValue(denumerCalculationNode);
                    }
                }
                else
                {
                    denumerCalculation_ = new VariableValue(denumerCalculationNode);
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region ReturnType_
        private XsdTypeToken returnType_;
        public XsdTypeToken ReturnType_
        {
            get
            {
                if (this.returnType_ != null)
                {
                    return this.returnType_; 
                }
                else if (this.returnTypeIDRef_ != null)
                {
                    returnType_ = IDManager.getID(returnTypeIDRef_) as XsdTypeToken;
                    return this.returnType_; 
                }
                else
                {
                      return this.returnType_; 
                }
            }
            set
            {
                if (this.returnType_ != value)
                {
                    this.returnType_ = value;
                }
            }
        }
        #endregion
        
        public string returnTypeIDRef_ { get; set; }
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
        #region NumerCalculation_
        private VariableValue numerCalculation_;
        public VariableValue NumerCalculation_
        {
            get
            {
                if (this.numerCalculation_ != null)
                {
                    return this.numerCalculation_; 
                }
                else if (this.numerCalculationIDRef_ != null)
                {
                    numerCalculation_ = IDManager.getID(numerCalculationIDRef_) as VariableValue;
                    return this.numerCalculation_; 
                }
                else
                {
                      return this.numerCalculation_; 
                }
            }
            set
            {
                if (this.numerCalculation_ != value)
                {
                    this.numerCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string numerCalculationIDRef_ { get; set; }
        #region DenumerCalculation_
        private VariableValue denumerCalculation_;
        public VariableValue DenumerCalculation_
        {
            get
            {
                if (this.denumerCalculation_ != null)
                {
                    return this.denumerCalculation_; 
                }
                else if (this.denumerCalculationIDRef_ != null)
                {
                    denumerCalculation_ = IDManager.getID(denumerCalculationIDRef_) as VariableValue;
                    return this.denumerCalculation_; 
                }
                else
                {
                      return this.denumerCalculation_; 
                }
            }
            set
            {
                if (this.denumerCalculation_ != value)
                {
                    this.denumerCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string denumerCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}


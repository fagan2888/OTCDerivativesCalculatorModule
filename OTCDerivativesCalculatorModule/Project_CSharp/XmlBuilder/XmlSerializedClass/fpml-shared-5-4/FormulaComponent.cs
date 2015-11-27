using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FormulaComponent : ISerialized
    {
        public FormulaComponent(XmlNode xmlNode)
        {
            XmlNode componentDescriptionNode = xmlNode.SelectSingleNode("componentDescription");
            
            if (componentDescriptionNode != null)
            {
                if (componentDescriptionNode.Attributes["href"] != null || componentDescriptionNode.Attributes["id"] != null) 
                {
                    if (componentDescriptionNode.Attributes["id"] != null) 
                    {
                        componentDescriptionIDRef_ = componentDescriptionNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(componentDescriptionNode);
                        IDManager.SetID(componentDescriptionIDRef_, ob);
                    }
                    else if (componentDescriptionNode.Attributes["href"] != null)
                    {
                        componentDescriptionIDRef_ = componentDescriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        componentDescription_ = new XsdTypeString(componentDescriptionNode);
                    }
                }
                else
                {
                    componentDescription_ = new XsdTypeString(componentDescriptionNode);
                }
            }
            
        
            XmlNode formulaNode = xmlNode.SelectSingleNode("formula");
            
            if (formulaNode != null)
            {
                if (formulaNode.Attributes["href"] != null || formulaNode.Attributes["id"] != null) 
                {
                    if (formulaNode.Attributes["id"] != null) 
                    {
                        formulaIDRef_ = formulaNode.Attributes["id"].Value;
                        Formula ob = new Formula(formulaNode);
                        IDManager.SetID(formulaIDRef_, ob);
                    }
                    else if (formulaNode.Attributes["href"] != null)
                    {
                        formulaIDRef_ = formulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        formula_ = new Formula(formulaNode);
                    }
                }
                else
                {
                    formula_ = new Formula(formulaNode);
                }
            }
            
        
        }
        
    
        #region ComponentDescription_
        private XsdTypeString componentDescription_;
        public XsdTypeString ComponentDescription_
        {
            get
            {
                if (this.componentDescription_ != null)
                {
                    return this.componentDescription_; 
                }
                else if (this.componentDescriptionIDRef_ != null)
                {
                    componentDescription_ = IDManager.getID(componentDescriptionIDRef_) as XsdTypeString;
                    return this.componentDescription_; 
                }
                else
                {
                      return this.componentDescription_; 
                }
            }
            set
            {
                if (this.componentDescription_ != value)
                {
                    this.componentDescription_ = value;
                }
            }
        }
        #endregion
        
        public string componentDescriptionIDRef_ { get; set; }
        #region Formula_
        private Formula formula_;
        public Formula Formula_
        {
            get
            {
                if (this.formula_ != null)
                {
                    return this.formula_; 
                }
                else if (this.formulaIDRef_ != null)
                {
                    formula_ = IDManager.getID(formulaIDRef_) as Formula;
                    return this.formula_; 
                }
                else
                {
                      return this.formula_; 
                }
            }
            set
            {
                if (this.formula_ != value)
                {
                    this.formula_ = value;
                }
            }
        }
        #endregion
        
        public string formulaIDRef_ { get; set; }
        
    
        
    
    }
    
}


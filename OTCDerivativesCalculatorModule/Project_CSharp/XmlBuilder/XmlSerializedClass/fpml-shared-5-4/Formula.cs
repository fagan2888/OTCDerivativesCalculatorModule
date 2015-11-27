using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Formula : ISerialized
    {
        public Formula(XmlNode xmlNode)
        {
            XmlNode formulaDescriptionNode = xmlNode.SelectSingleNode("formulaDescription");
            
            if (formulaDescriptionNode != null)
            {
                if (formulaDescriptionNode.Attributes["href"] != null || formulaDescriptionNode.Attributes["id"] != null) 
                {
                    if (formulaDescriptionNode.Attributes["id"] != null) 
                    {
                        formulaDescriptionIDRef_ = formulaDescriptionNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(formulaDescriptionNode);
                        IDManager.SetID(formulaDescriptionIDRef_, ob);
                    }
                    else if (formulaDescriptionNode.Attributes["href"] != null)
                    {
                        formulaDescriptionIDRef_ = formulaDescriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        formulaDescription_ = new XsdTypeString(formulaDescriptionNode);
                    }
                }
                else
                {
                    formulaDescription_ = new XsdTypeString(formulaDescriptionNode);
                }
            }
            
        
            XmlNode mathNode = xmlNode.SelectSingleNode("math");
            
            if (mathNode != null)
            {
                if (mathNode.Attributes["href"] != null || mathNode.Attributes["id"] != null) 
                {
                    if (mathNode.Attributes["id"] != null) 
                    {
                        mathIDRef_ = mathNode.Attributes["id"].Value;
                        Math ob = new Math(mathNode);
                        IDManager.SetID(mathIDRef_, ob);
                    }
                    else if (mathNode.Attributes["href"] != null)
                    {
                        mathIDRef_ = mathNode.Attributes["href"].Value;
                    }
                    else
                    {
                        math_ = new Math(mathNode);
                    }
                }
                else
                {
                    math_ = new Math(mathNode);
                }
            }
            
        
            XmlNodeList formulaComponentNodeList = xmlNode.SelectNodes("formulaComponent");
            
            if (formulaComponentNodeList != null)
            {
                this.formulaComponent_ = new List<FormulaComponent>();
                foreach (XmlNode item in formulaComponentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            formulaComponentIDRef_ = item.Attributes["id"].Value;
                            formulaComponent_.Add(new FormulaComponent(item));
                            IDManager.SetID(formulaComponentIDRef_, formulaComponent_[formulaComponent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            formulaComponentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        formulaComponent_.Add(new FormulaComponent(item));
                        }
                    }
                    else
                    {
                        formulaComponent_.Add(new FormulaComponent(item));
                    }
                }
            }
            
        
        }
        
    
        #region FormulaDescription_
        private XsdTypeString formulaDescription_;
        public XsdTypeString FormulaDescription_
        {
            get
            {
                if (this.formulaDescription_ != null)
                {
                    return this.formulaDescription_; 
                }
                else if (this.formulaDescriptionIDRef_ != null)
                {
                    formulaDescription_ = IDManager.getID(formulaDescriptionIDRef_) as XsdTypeString;
                    return this.formulaDescription_; 
                }
                else
                {
                      return this.formulaDescription_; 
                }
            }
            set
            {
                if (this.formulaDescription_ != value)
                {
                    this.formulaDescription_ = value;
                }
            }
        }
        #endregion
        
        public string formulaDescriptionIDRef_ { get; set; }
        #region Math_
        private Math math_;
        public Math Math_
        {
            get
            {
                if (this.math_ != null)
                {
                    return this.math_; 
                }
                else if (this.mathIDRef_ != null)
                {
                    math_ = IDManager.getID(mathIDRef_) as Math;
                    return this.math_; 
                }
                else
                {
                      return this.math_; 
                }
            }
            set
            {
                if (this.math_ != value)
                {
                    this.math_ = value;
                }
            }
        }
        #endregion
        
        public string mathIDRef_ { get; set; }
        #region FormulaComponent_
        private List<FormulaComponent> formulaComponent_;
        public List<FormulaComponent> FormulaComponent_
        {
            get
            {
                if (this.formulaComponent_ != null)
                {
                    return this.formulaComponent_; 
                }
                else if (this.formulaComponentIDRef_ != null)
                {
                    return this.formulaComponent_; 
                }
                else
                {
                      return this.formulaComponent_; 
                }
            }
            set
            {
                if (this.formulaComponent_ != value)
                {
                    this.formulaComponent_ = value;
                }
            }
        }
        #endregion
        
        public string formulaComponentIDRef_ { get; set; }
        
    
        
    
    }
    
}


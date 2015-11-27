using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Formula
    {
        public Formula(XmlNode xmlNode)
        {
            XmlNodeList formulaDescriptionNodeList = xmlNode.SelectNodes("formulaDescription");
            if (formulaDescriptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in formulaDescriptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaDescriptionIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(formulaDescriptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaDescriptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        formulaDescription = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList mathNodeList = xmlNode.SelectNodes("math");
            if (mathNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mathNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mathIDRef = item.Attributes["id"].Name;
                        Math ob = Math();
                        IDManager.SetID(mathIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mathIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        math = new Math(item);
                    }
                }
            }
            
        
            XmlNodeList formulaComponentNodeList = xmlNode.SelectNodes("formulaComponent");
            
            foreach (XmlNode item in formulaComponentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaComponentIDRef = item.Attributes["id"].Name;
                        List<FormulaComponent> ob = new List<FormulaComponent>();
                        ob.Add(new FormulaComponent(item));
                        IDManager.SetID(formulaComponentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaComponentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    formulaComponent.Add(new FormulaComponent(item));
                    }
                }
            }
            
        
        }
        
    
        #region FormulaDescription
        private XsdTypeString formulaDescription;
        public XsdTypeString FormulaDescription
        {
            get
            {
                if (this.formulaDescription != null)
                {
                    return this.formulaDescription; 
                }
                else if (this.formulaDescriptionIDRef != null)
                {
                    formulaDescription = IDManager.getID(formulaDescriptionIDRef) as XsdTypeString;
                    return this.formulaDescription; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formulaDescription != value)
                {
                    this.formulaDescription = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region Math
        private Math math;
        public Math Math
        {
            get
            {
                if (this.math != null)
                {
                    return this.math; 
                }
                else if (this.mathIDRef != null)
                {
                    math = IDManager.getID(mathIDRef) as Math;
                    return this.math; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.math != value)
                {
                    this.math = value;
                }
            }
        }
        #endregion
        
        public string MathIDRef { get; set; }
        #region FormulaComponent
        private List<FormulaComponent> formulaComponent;
        public List<FormulaComponent> FormulaComponent
        {
            get
            {
                if (this.formulaComponent != null)
                {
                    return this.formulaComponent; 
                }
                else if (this.formulaComponentIDRef != null)
                {
                    formulaComponent = IDManager.getID(formulaComponentIDRef) as List<FormulaComponent>;
                    return this.formulaComponent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formulaComponent != value)
                {
                    this.formulaComponent = value;
                }
            }
        }
        #endregion
        
        public string FormulaComponentIDRef { get; set; }
        
    
        
    
    }
    
}


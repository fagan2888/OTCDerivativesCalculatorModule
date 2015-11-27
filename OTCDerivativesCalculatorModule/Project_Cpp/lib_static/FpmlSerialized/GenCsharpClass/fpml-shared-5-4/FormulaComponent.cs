using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FormulaComponent
    {
        public FormulaComponent(XmlNode xmlNode)
        {
            XmlNodeList componentDescriptionNodeList = xmlNode.SelectNodes("componentDescription");
            if (componentDescriptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in componentDescriptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        componentDescriptionIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(componentDescriptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        componentDescriptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        componentDescription = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList formulaNodeList = xmlNode.SelectNodes("formula");
            if (formulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in formulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaIDRef = item.Attributes["id"].Name;
                        Formula ob = Formula();
                        IDManager.SetID(formulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        formula = new Formula(item);
                    }
                }
            }
            
        
        }
        
    
        #region ComponentDescription
        private XsdTypeString componentDescription;
        public XsdTypeString ComponentDescription
        {
            get
            {
                if (this.componentDescription != null)
                {
                    return this.componentDescription; 
                }
                else if (this.componentDescriptionIDRef != null)
                {
                    componentDescription = IDManager.getID(componentDescriptionIDRef) as XsdTypeString;
                    return this.componentDescription; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.componentDescription != value)
                {
                    this.componentDescription = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region Formula
        private Formula formula;
        public Formula Formula
        {
            get
            {
                if (this.formula != null)
                {
                    return this.formula; 
                }
                else if (this.formulaIDRef != null)
                {
                    formula = IDManager.getID(formulaIDRef) as Formula;
                    return this.formula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formula != value)
                {
                    this.formula = value;
                }
            }
        }
        #endregion
        
        public string FormulaIDRef { get; set; }
        
    
        
    
    }
    
}


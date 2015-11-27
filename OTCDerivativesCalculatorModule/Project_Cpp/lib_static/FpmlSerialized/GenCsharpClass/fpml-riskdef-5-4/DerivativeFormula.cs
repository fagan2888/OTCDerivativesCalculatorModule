using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DerivativeFormula
    {
        public DerivativeFormula(XmlNode xmlNode)
        {
            XmlNodeList termNodeList = xmlNode.SelectNodes("term");
            if (termNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termIDRef = item.Attributes["id"].Name;
                        FormulaTerm ob = FormulaTerm();
                        IDManager.SetID(termIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        term = new FormulaTerm(item);
                    }
                }
            }
            
        
            XmlNodeList denominatorTermNodeList = xmlNode.SelectNodes("denominatorTerm");
            if (denominatorTermNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in denominatorTermNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        denominatorTermIDRef = item.Attributes["id"].Name;
                        DenominatorTerm ob = DenominatorTerm();
                        IDManager.SetID(denominatorTermIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        denominatorTermIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        denominatorTerm = new DenominatorTerm(item);
                    }
                }
            }
            
        
        }
        
    
        #region Term
        private FormulaTerm term;
        public FormulaTerm Term
        {
            get
            {
                if (this.term != null)
                {
                    return this.term; 
                }
                else if (this.termIDRef != null)
                {
                    term = IDManager.getID(termIDRef) as FormulaTerm;
                    return this.term; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.term != value)
                {
                    this.term = value;
                }
            }
        }
        #endregion
        
        public string FormulaTermIDRef { get; set; }
        #region DenominatorTerm
        private DenominatorTerm denominatorTerm;
        public DenominatorTerm DenominatorTerm
        {
            get
            {
                if (this.denominatorTerm != null)
                {
                    return this.denominatorTerm; 
                }
                else if (this.denominatorTermIDRef != null)
                {
                    denominatorTerm = IDManager.getID(denominatorTermIDRef) as DenominatorTerm;
                    return this.denominatorTerm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.denominatorTerm != value)
                {
                    this.denominatorTerm = value;
                }
            }
        }
        #endregion
        
        public string DenominatorTermIDRef { get; set; }
        
    
        
    
    }
    
}


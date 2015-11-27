using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DerivativeFormula : ISerialized
    {
        public DerivativeFormula(XmlNode xmlNode)
        {
            XmlNode termNode = xmlNode.SelectSingleNode("term");
            
            if (termNode != null)
            {
                if (termNode.Attributes["href"] != null || termNode.Attributes["id"] != null) 
                {
                    if (termNode.Attributes["id"] != null) 
                    {
                        termIDRef_ = termNode.Attributes["id"].Value;
                        FormulaTerm ob = new FormulaTerm(termNode);
                        IDManager.SetID(termIDRef_, ob);
                    }
                    else if (termNode.Attributes["href"] != null)
                    {
                        termIDRef_ = termNode.Attributes["href"].Value;
                    }
                    else
                    {
                        term_ = new FormulaTerm(termNode);
                    }
                }
                else
                {
                    term_ = new FormulaTerm(termNode);
                }
            }
            
        
            XmlNode denominatorTermNode = xmlNode.SelectSingleNode("denominatorTerm");
            
            if (denominatorTermNode != null)
            {
                if (denominatorTermNode.Attributes["href"] != null || denominatorTermNode.Attributes["id"] != null) 
                {
                    if (denominatorTermNode.Attributes["id"] != null) 
                    {
                        denominatorTermIDRef_ = denominatorTermNode.Attributes["id"].Value;
                        DenominatorTerm ob = new DenominatorTerm(denominatorTermNode);
                        IDManager.SetID(denominatorTermIDRef_, ob);
                    }
                    else if (denominatorTermNode.Attributes["href"] != null)
                    {
                        denominatorTermIDRef_ = denominatorTermNode.Attributes["href"].Value;
                    }
                    else
                    {
                        denominatorTerm_ = new DenominatorTerm(denominatorTermNode);
                    }
                }
                else
                {
                    denominatorTerm_ = new DenominatorTerm(denominatorTermNode);
                }
            }
            
        
        }
        
    
        #region Term_
        private FormulaTerm term_;
        public FormulaTerm Term_
        {
            get
            {
                if (this.term_ != null)
                {
                    return this.term_; 
                }
                else if (this.termIDRef_ != null)
                {
                    term_ = IDManager.getID(termIDRef_) as FormulaTerm;
                    return this.term_; 
                }
                else
                {
                      return this.term_; 
                }
            }
            set
            {
                if (this.term_ != value)
                {
                    this.term_ = value;
                }
            }
        }
        #endregion
        
        public string termIDRef_ { get; set; }
        #region DenominatorTerm_
        private DenominatorTerm denominatorTerm_;
        public DenominatorTerm DenominatorTerm_
        {
            get
            {
                if (this.denominatorTerm_ != null)
                {
                    return this.denominatorTerm_; 
                }
                else if (this.denominatorTermIDRef_ != null)
                {
                    denominatorTerm_ = IDManager.getID(denominatorTermIDRef_) as DenominatorTerm;
                    return this.denominatorTerm_; 
                }
                else
                {
                      return this.denominatorTerm_; 
                }
            }
            set
            {
                if (this.denominatorTerm_ != value)
                {
                    this.denominatorTerm_ = value;
                }
            }
        }
        #endregion
        
        public string denominatorTermIDRef_ { get; set; }
        
    
        
    
    }
    
}


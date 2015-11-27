using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FormulaTerm : ISerialized
    {
        public FormulaTerm(XmlNode xmlNode)
        {
            XmlNode coefficientNode = xmlNode.SelectSingleNode("coefficient");
            
            if (coefficientNode != null)
            {
                if (coefficientNode.Attributes["href"] != null || coefficientNode.Attributes["id"] != null) 
                {
                    if (coefficientNode.Attributes["id"] != null) 
                    {
                        coefficientIDRef_ = coefficientNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(coefficientNode);
                        IDManager.SetID(coefficientIDRef_, ob);
                    }
                    else if (coefficientNode.Attributes["href"] != null)
                    {
                        coefficientIDRef_ = coefficientNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coefficient_ = new XsdTypeDecimal(coefficientNode);
                    }
                }
                else
                {
                    coefficient_ = new XsdTypeDecimal(coefficientNode);
                }
            }
            
        
            XmlNodeList partialDerivativeReferenceNodeList = xmlNode.SelectNodes("partialDerivativeReference");
            
            if (partialDerivativeReferenceNodeList != null)
            {
                this.partialDerivativeReference_ = new List<PricingParameterDerivativeReference>();
                foreach (XmlNode item in partialDerivativeReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partialDerivativeReferenceIDRef_ = item.Attributes["id"].Value;
                            partialDerivativeReference_.Add(new PricingParameterDerivativeReference(item));
                            IDManager.SetID(partialDerivativeReferenceIDRef_, partialDerivativeReference_[partialDerivativeReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partialDerivativeReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partialDerivativeReference_.Add(new PricingParameterDerivativeReference(item));
                        }
                    }
                    else
                    {
                        partialDerivativeReference_.Add(new PricingParameterDerivativeReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region Coefficient_
        private XsdTypeDecimal coefficient_;
        public XsdTypeDecimal Coefficient_
        {
            get
            {
                if (this.coefficient_ != null)
                {
                    return this.coefficient_; 
                }
                else if (this.coefficientIDRef_ != null)
                {
                    coefficient_ = IDManager.getID(coefficientIDRef_) as XsdTypeDecimal;
                    return this.coefficient_; 
                }
                else
                {
                      return this.coefficient_; 
                }
            }
            set
            {
                if (this.coefficient_ != value)
                {
                    this.coefficient_ = value;
                }
            }
        }
        #endregion
        
        public string coefficientIDRef_ { get; set; }
        #region PartialDerivativeReference_
        private List<PricingParameterDerivativeReference> partialDerivativeReference_;
        public List<PricingParameterDerivativeReference> PartialDerivativeReference_
        {
            get
            {
                if (this.partialDerivativeReference_ != null)
                {
                    return this.partialDerivativeReference_; 
                }
                else if (this.partialDerivativeReferenceIDRef_ != null)
                {
                    return this.partialDerivativeReference_; 
                }
                else
                {
                      return this.partialDerivativeReference_; 
                }
            }
            set
            {
                if (this.partialDerivativeReference_ != value)
                {
                    this.partialDerivativeReference_ = value;
                }
            }
        }
        #endregion
        
        public string partialDerivativeReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VarianceAmount : CalculatedAmount
    {
        public VarianceAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode varianceNode = xmlNode.SelectSingleNode("variance");
            
            if (varianceNode != null)
            {
                if (varianceNode.Attributes["href"] != null || varianceNode.Attributes["id"] != null) 
                {
                    if (varianceNode.Attributes["id"] != null) 
                    {
                        varianceIDRef_ = varianceNode.Attributes["id"].Value;
                        Variance ob = new Variance(varianceNode);
                        IDManager.SetID(varianceIDRef_, ob);
                    }
                    else if (varianceNode.Attributes["href"] != null)
                    {
                        varianceIDRef_ = varianceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        variance_ = new Variance(varianceNode);
                    }
                }
                else
                {
                    variance_ = new Variance(varianceNode);
                }
            }
            
        
        }
        
    
        #region Variance_
        private Variance variance_;
        public Variance Variance_
        {
            get
            {
                if (this.variance_ != null)
                {
                    return this.variance_; 
                }
                else if (this.varianceIDRef_ != null)
                {
                    variance_ = IDManager.getID(varianceIDRef_) as Variance;
                    return this.variance_; 
                }
                else
                {
                      return this.variance_; 
                }
            }
            set
            {
                if (this.variance_ != value)
                {
                    this.variance_ = value;
                }
            }
        }
        #endregion
        
        public string varianceIDRef_ { get; set; }
        
    
        
    
    }
    
}


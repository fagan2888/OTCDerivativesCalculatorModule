using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CorrelationAmount : CalculatedAmount
    {
        public CorrelationAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode correlationNode = xmlNode.SelectSingleNode("correlation");
            
            if (correlationNode != null)
            {
                if (correlationNode.Attributes["href"] != null || correlationNode.Attributes["id"] != null) 
                {
                    if (correlationNode.Attributes["id"] != null) 
                    {
                        correlationIDRef_ = correlationNode.Attributes["id"].Value;
                        Correlation ob = new Correlation(correlationNode);
                        IDManager.SetID(correlationIDRef_, ob);
                    }
                    else if (correlationNode.Attributes["href"] != null)
                    {
                        correlationIDRef_ = correlationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlation_ = new Correlation(correlationNode);
                    }
                }
                else
                {
                    correlation_ = new Correlation(correlationNode);
                }
            }
            
        
        }
        
    
        #region Correlation_
        private Correlation correlation_;
        public Correlation Correlation_
        {
            get
            {
                if (this.correlation_ != null)
                {
                    return this.correlation_; 
                }
                else if (this.correlationIDRef_ != null)
                {
                    correlation_ = IDManager.getID(correlationIDRef_) as Correlation;
                    return this.correlation_; 
                }
                else
                {
                      return this.correlation_; 
                }
            }
            set
            {
                if (this.correlation_ != value)
                {
                    this.correlation_ = value;
                }
            }
        }
        #endregion
        
        public string correlationIDRef_ { get; set; }
        
    
        
    
    }
    
}


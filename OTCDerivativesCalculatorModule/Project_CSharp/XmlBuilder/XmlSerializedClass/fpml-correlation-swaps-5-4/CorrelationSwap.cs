using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CorrelationSwap : NettedSwapBase
    {
        public CorrelationSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode correlationLegNode = xmlNode.SelectSingleNode("correlationLeg");
            
            if (correlationLegNode != null)
            {
                if (correlationLegNode.Attributes["href"] != null || correlationLegNode.Attributes["id"] != null) 
                {
                    if (correlationLegNode.Attributes["id"] != null) 
                    {
                        correlationLegIDRef_ = correlationLegNode.Attributes["id"].Value;
                        CorrelationLeg ob = new CorrelationLeg(correlationLegNode);
                        IDManager.SetID(correlationLegIDRef_, ob);
                    }
                    else if (correlationLegNode.Attributes["href"] != null)
                    {
                        correlationLegIDRef_ = correlationLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationLeg_ = new CorrelationLeg(correlationLegNode);
                    }
                }
                else
                {
                    correlationLeg_ = new CorrelationLeg(correlationLegNode);
                }
            }
            
        
        }
        
    
        #region CorrelationLeg_
        private CorrelationLeg correlationLeg_;
        public CorrelationLeg CorrelationLeg_
        {
            get
            {
                if (this.correlationLeg_ != null)
                {
                    return this.correlationLeg_; 
                }
                else if (this.correlationLegIDRef_ != null)
                {
                    correlationLeg_ = IDManager.getID(correlationLegIDRef_) as CorrelationLeg;
                    return this.correlationLeg_; 
                }
                else
                {
                      return this.correlationLeg_; 
                }
            }
            set
            {
                if (this.correlationLeg_ != value)
                {
                    this.correlationLeg_ = value;
                }
            }
        }
        #endregion
        
        public string correlationLegIDRef_ { get; set; }
        
    
        
    
    }
    
}


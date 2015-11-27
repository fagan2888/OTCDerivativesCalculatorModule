using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class Pricing : ISerialized
    {
        public Pricing() { }
        public Pricing(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode evaluationTimeNode = xmlNode.SelectSingleNode("evaluationTime");
            
            if (evaluationTimeNode != null)
            {
                if (evaluationTimeNode.Attributes["href"] != null || evaluationTimeNode.Attributes["id"] != null) 
                {
                    if (evaluationTimeNode.Attributes["id"] != null) 
                    {
                        evaluationTimeIDRef_ = evaluationTimeNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(evaluationTimeNode);
                        IDManager.SetID(evaluationTimeIDRef_, ob);
                    }
                    else if (evaluationTimeNode.Attributes["href"] != null)
                    {
                        evaluationTimeIDRef_ = evaluationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        evaluationTime_ = new XsdTypeDate(evaluationTimeNode);
                    }
                }
                else
                {
                    evaluationTime_ = new XsdTypeDate(evaluationTimeNode);
                }
            }
            
        
            XmlNode pricingParameterNode = xmlNode.SelectSingleNode("pricingParameter");
            
            if (pricingParameterNode != null)
            {
                if (pricingParameterNode.Attributes["href"] != null || pricingParameterNode.Attributes["id"] != null) 
                {
                    if (pricingParameterNode.Attributes["id"] != null) 
                    {
                        pricingParameterIDRef_ = pricingParameterNode.Attributes["id"].Value;
                        PricingParameter ob = new PricingParameter(pricingParameterNode);
                        IDManager.SetID(pricingParameterIDRef_, ob);
                    }
                    else if (pricingParameterNode.Attributes["href"] != null)
                    {
                        pricingParameterIDRef_ = pricingParameterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingParameter_ = new PricingParameter(pricingParameterNode);
                    }
                }
                else
                {
                    pricingParameter_ = new PricingParameter(pricingParameterNode);
                }
            }
            
        
            XmlNode pricingResultNode = xmlNode.SelectSingleNode("pricingResult");
            
            if (pricingResultNode != null)
            {
                if (pricingResultNode.Attributes["href"] != null || pricingResultNode.Attributes["id"] != null) 
                {
                    if (pricingResultNode.Attributes["id"] != null) 
                    {
                        pricingResultIDRef_ = pricingResultNode.Attributes["id"].Value;
                        PricingResult ob = new PricingResult(pricingResultNode);
                        IDManager.SetID(pricingResultIDRef_, ob);
                    }
                    else if (pricingResultNode.Attributes["href"] != null)
                    {
                        pricingResultIDRef_ = pricingResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingResult_ = new PricingResult(pricingResultNode);
                    }
                }
                else
                {
                    pricingResult_ = new PricingResult(pricingResultNode);
                }
            }
            
        
        }
        
    
        #region EvaluationTime_
        private XsdTypeDate evaluationTime_;
        public XsdTypeDate EvaluationTime_
        {
            get
            {
                if (this.evaluationTime_ != null)
                {
                    return this.evaluationTime_; 
                }
                else if (this.evaluationTimeIDRef_ != null)
                {
                    evaluationTime_ = IDManager.getID(evaluationTimeIDRef_) as XsdTypeDate;
                    return this.evaluationTime_; 
                }
                else
                {
                      return this.evaluationTime_; 
                }
            }
            set
            {
                if (this.evaluationTime_ != value)
                {
                    this.evaluationTime_ = value;
                }
            }
        }
        #endregion
        
        public string evaluationTimeIDRef_ { get; set; }
        #region PricingParameter_
        private PricingParameter pricingParameter_;
        public PricingParameter PricingParameter_
        {
            get
            {
                if (this.pricingParameter_ != null)
                {
                    return this.pricingParameter_; 
                }
                else if (this.pricingParameterIDRef_ != null)
                {
                    pricingParameter_ = IDManager.getID(pricingParameterIDRef_) as PricingParameter;
                    return this.pricingParameter_; 
                }
                else
                {
                      return this.pricingParameter_; 
                }
            }
            set
            {
                if (this.pricingParameter_ != value)
                {
                    this.pricingParameter_ = value;
                }
            }
        }
        #endregion
        
        public string pricingParameterIDRef_ { get; set; }
        #region PricingResult_
        private PricingResult pricingResult_;
        public PricingResult PricingResult_
        {
            get
            {
                if (this.pricingResult_ != null)
                {
                    return this.pricingResult_; 
                }
                else if (this.pricingResultIDRef_ != null)
                {
                    pricingResult_ = IDManager.getID(pricingResultIDRef_) as PricingResult;
                    return this.pricingResult_; 
                }
                else
                {
                      return this.pricingResult_; 
                }
            }
            set
            {
                if (this.pricingResult_ != value)
                {
                    this.pricingResult_ = value;
                }
            }
        }
        #endregion
        
        public string pricingResultIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OilPipelineDelivery : ISerialized
    {
        public OilPipelineDelivery(XmlNode xmlNode)
        {
            XmlNode pipelineNameNode = xmlNode.SelectSingleNode("pipelineName");
            
            if (pipelineNameNode != null)
            {
                if (pipelineNameNode.Attributes["href"] != null || pipelineNameNode.Attributes["id"] != null) 
                {
                    if (pipelineNameNode.Attributes["id"] != null) 
                    {
                        pipelineNameIDRef_ = pipelineNameNode.Attributes["id"].Value;
                        CommodityPipeline ob = new CommodityPipeline(pipelineNameNode);
                        IDManager.SetID(pipelineNameIDRef_, ob);
                    }
                    else if (pipelineNameNode.Attributes["href"] != null)
                    {
                        pipelineNameIDRef_ = pipelineNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pipelineName_ = new CommodityPipeline(pipelineNameNode);
                    }
                }
                else
                {
                    pipelineName_ = new CommodityPipeline(pipelineNameNode);
                }
            }
            
        
            XmlNode withdrawalPointNode = xmlNode.SelectSingleNode("withdrawalPoint");
            
            if (withdrawalPointNode != null)
            {
                if (withdrawalPointNode.Attributes["href"] != null || withdrawalPointNode.Attributes["id"] != null) 
                {
                    if (withdrawalPointNode.Attributes["id"] != null) 
                    {
                        withdrawalPointIDRef_ = withdrawalPointNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(withdrawalPointNode);
                        IDManager.SetID(withdrawalPointIDRef_, ob);
                    }
                    else if (withdrawalPointNode.Attributes["href"] != null)
                    {
                        withdrawalPointIDRef_ = withdrawalPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        withdrawalPoint_ = new CommodityDeliveryPoint(withdrawalPointNode);
                    }
                }
                else
                {
                    withdrawalPoint_ = new CommodityDeliveryPoint(withdrawalPointNode);
                }
            }
            
        
            XmlNode entryPointNode = xmlNode.SelectSingleNode("entryPoint");
            
            if (entryPointNode != null)
            {
                if (entryPointNode.Attributes["href"] != null || entryPointNode.Attributes["id"] != null) 
                {
                    if (entryPointNode.Attributes["id"] != null) 
                    {
                        entryPointIDRef_ = entryPointNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(entryPointNode);
                        IDManager.SetID(entryPointIDRef_, ob);
                    }
                    else if (entryPointNode.Attributes["href"] != null)
                    {
                        entryPointIDRef_ = entryPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entryPoint_ = new CommodityDeliveryPoint(entryPointNode);
                    }
                }
                else
                {
                    entryPoint_ = new CommodityDeliveryPoint(entryPointNode);
                }
            }
            
        
            XmlNode deliverableByBargeNode = xmlNode.SelectSingleNode("deliverableByBarge");
            
            if (deliverableByBargeNode != null)
            {
                if (deliverableByBargeNode.Attributes["href"] != null || deliverableByBargeNode.Attributes["id"] != null) 
                {
                    if (deliverableByBargeNode.Attributes["id"] != null) 
                    {
                        deliverableByBargeIDRef_ = deliverableByBargeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(deliverableByBargeNode);
                        IDManager.SetID(deliverableByBargeIDRef_, ob);
                    }
                    else if (deliverableByBargeNode.Attributes["href"] != null)
                    {
                        deliverableByBargeIDRef_ = deliverableByBargeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliverableByBarge_ = new XsdTypeBoolean(deliverableByBargeNode);
                    }
                }
                else
                {
                    deliverableByBarge_ = new XsdTypeBoolean(deliverableByBargeNode);
                }
            }
            
        
            XmlNode riskNode = xmlNode.SelectSingleNode("risk");
            
            if (riskNode != null)
            {
                if (riskNode.Attributes["href"] != null || riskNode.Attributes["id"] != null) 
                {
                    if (riskNode.Attributes["id"] != null) 
                    {
                        riskIDRef_ = riskNode.Attributes["id"].Value;
                        CommodityDeliveryRisk ob = new CommodityDeliveryRisk(riskNode);
                        IDManager.SetID(riskIDRef_, ob);
                    }
                    else if (riskNode.Attributes["href"] != null)
                    {
                        riskIDRef_ = riskNode.Attributes["href"].Value;
                    }
                    else
                    {
                        risk_ = new CommodityDeliveryRisk(riskNode);
                    }
                }
                else
                {
                    risk_ = new CommodityDeliveryRisk(riskNode);
                }
            }
            
        
            XmlNodeList cycleNodeList = xmlNode.SelectNodes("cycle");
            
            if (cycleNodeList != null)
            {
                this.cycle_ = new List<CommodityPipelineCycle>();
                foreach (XmlNode item in cycleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            cycleIDRef_ = item.Attributes["id"].Value;
                            cycle_.Add(new CommodityPipelineCycle(item));
                            IDManager.SetID(cycleIDRef_, cycle_[cycle_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            cycleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        cycle_.Add(new CommodityPipelineCycle(item));
                        }
                    }
                    else
                    {
                        cycle_.Add(new CommodityPipelineCycle(item));
                    }
                }
            }
            
        
        }
        
    
        #region PipelineName_
        private CommodityPipeline pipelineName_;
        public CommodityPipeline PipelineName_
        {
            get
            {
                if (this.pipelineName_ != null)
                {
                    return this.pipelineName_; 
                }
                else if (this.pipelineNameIDRef_ != null)
                {
                    pipelineName_ = IDManager.getID(pipelineNameIDRef_) as CommodityPipeline;
                    return this.pipelineName_; 
                }
                else
                {
                      return this.pipelineName_; 
                }
            }
            set
            {
                if (this.pipelineName_ != value)
                {
                    this.pipelineName_ = value;
                }
            }
        }
        #endregion
        
        public string pipelineNameIDRef_ { get; set; }
        #region WithdrawalPoint_
        private CommodityDeliveryPoint withdrawalPoint_;
        public CommodityDeliveryPoint WithdrawalPoint_
        {
            get
            {
                if (this.withdrawalPoint_ != null)
                {
                    return this.withdrawalPoint_; 
                }
                else if (this.withdrawalPointIDRef_ != null)
                {
                    withdrawalPoint_ = IDManager.getID(withdrawalPointIDRef_) as CommodityDeliveryPoint;
                    return this.withdrawalPoint_; 
                }
                else
                {
                      return this.withdrawalPoint_; 
                }
            }
            set
            {
                if (this.withdrawalPoint_ != value)
                {
                    this.withdrawalPoint_ = value;
                }
            }
        }
        #endregion
        
        public string withdrawalPointIDRef_ { get; set; }
        #region EntryPoint_
        private CommodityDeliveryPoint entryPoint_;
        public CommodityDeliveryPoint EntryPoint_
        {
            get
            {
                if (this.entryPoint_ != null)
                {
                    return this.entryPoint_; 
                }
                else if (this.entryPointIDRef_ != null)
                {
                    entryPoint_ = IDManager.getID(entryPointIDRef_) as CommodityDeliveryPoint;
                    return this.entryPoint_; 
                }
                else
                {
                      return this.entryPoint_; 
                }
            }
            set
            {
                if (this.entryPoint_ != value)
                {
                    this.entryPoint_ = value;
                }
            }
        }
        #endregion
        
        public string entryPointIDRef_ { get; set; }
        #region DeliverableByBarge_
        private XsdTypeBoolean deliverableByBarge_;
        public XsdTypeBoolean DeliverableByBarge_
        {
            get
            {
                if (this.deliverableByBarge_ != null)
                {
                    return this.deliverableByBarge_; 
                }
                else if (this.deliverableByBargeIDRef_ != null)
                {
                    deliverableByBarge_ = IDManager.getID(deliverableByBargeIDRef_) as XsdTypeBoolean;
                    return this.deliverableByBarge_; 
                }
                else
                {
                      return this.deliverableByBarge_; 
                }
            }
            set
            {
                if (this.deliverableByBarge_ != value)
                {
                    this.deliverableByBarge_ = value;
                }
            }
        }
        #endregion
        
        public string deliverableByBargeIDRef_ { get; set; }
        #region Risk_
        private CommodityDeliveryRisk risk_;
        public CommodityDeliveryRisk Risk_
        {
            get
            {
                if (this.risk_ != null)
                {
                    return this.risk_; 
                }
                else if (this.riskIDRef_ != null)
                {
                    risk_ = IDManager.getID(riskIDRef_) as CommodityDeliveryRisk;
                    return this.risk_; 
                }
                else
                {
                      return this.risk_; 
                }
            }
            set
            {
                if (this.risk_ != value)
                {
                    this.risk_ = value;
                }
            }
        }
        #endregion
        
        public string riskIDRef_ { get; set; }
        #region Cycle_
        private List<CommodityPipelineCycle> cycle_;
        public List<CommodityPipelineCycle> Cycle_
        {
            get
            {
                if (this.cycle_ != null)
                {
                    return this.cycle_; 
                }
                else if (this.cycleIDRef_ != null)
                {
                    return this.cycle_; 
                }
                else
                {
                      return this.cycle_; 
                }
            }
            set
            {
                if (this.cycle_ != value)
                {
                    this.cycle_ = value;
                }
            }
        }
        #endregion
        
        public string cycleIDRef_ { get; set; }
        
    
        
    
    }
    
}


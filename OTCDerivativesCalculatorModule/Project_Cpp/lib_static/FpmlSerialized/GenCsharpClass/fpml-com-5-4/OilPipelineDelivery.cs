using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OilPipelineDelivery
    {
        public OilPipelineDelivery(XmlNode xmlNode)
        {
            XmlNodeList pipelineNameNodeList = xmlNode.SelectNodes("pipelineName");
            if (pipelineNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pipelineNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pipelineNameIDRef = item.Attributes["id"].Name;
                        CommodityPipeline ob = CommodityPipeline();
                        IDManager.SetID(pipelineNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pipelineNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pipelineName = new CommodityPipeline(item);
                    }
                }
            }
            
        
            XmlNodeList withdrawalPointNodeList = xmlNode.SelectNodes("withdrawalPoint");
            if (withdrawalPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in withdrawalPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        withdrawalPointIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(withdrawalPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        withdrawalPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        withdrawalPoint = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList entryPointNodeList = xmlNode.SelectNodes("entryPoint");
            if (entryPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in entryPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        entryPointIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(entryPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        entryPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        entryPoint = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList deliverableByBargeNodeList = xmlNode.SelectNodes("deliverableByBarge");
            if (deliverableByBargeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliverableByBargeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliverableByBargeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(deliverableByBargeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliverableByBargeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliverableByBarge = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList riskNodeList = xmlNode.SelectNodes("risk");
            if (riskNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in riskNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        riskIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryRisk ob = CommodityDeliveryRisk();
                        IDManager.SetID(riskIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        riskIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        risk = new CommodityDeliveryRisk(item);
                    }
                }
            }
            
        
            XmlNodeList cycleNodeList = xmlNode.SelectNodes("cycle");
            
            foreach (XmlNode item in cycleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cycleIDRef = item.Attributes["id"].Name;
                        List<CommodityPipelineCycle> ob = new List<CommodityPipelineCycle>();
                        ob.Add(new CommodityPipelineCycle(item));
                        IDManager.SetID(cycleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cycleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    cycle.Add(new CommodityPipelineCycle(item));
                    }
                }
            }
            
        
        }
        
    
        #region PipelineName
        private CommodityPipeline pipelineName;
        public CommodityPipeline PipelineName
        {
            get
            {
                if (this.pipelineName != null)
                {
                    return this.pipelineName; 
                }
                else if (this.pipelineNameIDRef != null)
                {
                    pipelineName = IDManager.getID(pipelineNameIDRef) as CommodityPipeline;
                    return this.pipelineName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pipelineName != value)
                {
                    this.pipelineName = value;
                }
            }
        }
        #endregion
        
        public string CommodityPipelineIDRef { get; set; }
        #region WithdrawalPoint
        private CommodityDeliveryPoint withdrawalPoint;
        public CommodityDeliveryPoint WithdrawalPoint
        {
            get
            {
                if (this.withdrawalPoint != null)
                {
                    return this.withdrawalPoint; 
                }
                else if (this.withdrawalPointIDRef != null)
                {
                    withdrawalPoint = IDManager.getID(withdrawalPointIDRef) as CommodityDeliveryPoint;
                    return this.withdrawalPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.withdrawalPoint != value)
                {
                    this.withdrawalPoint = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        #region EntryPoint
        private CommodityDeliveryPoint entryPoint;
        public CommodityDeliveryPoint EntryPoint
        {
            get
            {
                if (this.entryPoint != null)
                {
                    return this.entryPoint; 
                }
                else if (this.entryPointIDRef != null)
                {
                    entryPoint = IDManager.getID(entryPointIDRef) as CommodityDeliveryPoint;
                    return this.entryPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.entryPoint != value)
                {
                    this.entryPoint = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        #region DeliverableByBarge
        private XsdTypeBoolean deliverableByBarge;
        public XsdTypeBoolean DeliverableByBarge
        {
            get
            {
                if (this.deliverableByBarge != null)
                {
                    return this.deliverableByBarge; 
                }
                else if (this.deliverableByBargeIDRef != null)
                {
                    deliverableByBarge = IDManager.getID(deliverableByBargeIDRef) as XsdTypeBoolean;
                    return this.deliverableByBarge; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliverableByBarge != value)
                {
                    this.deliverableByBarge = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Risk
        private CommodityDeliveryRisk risk;
        public CommodityDeliveryRisk Risk
        {
            get
            {
                if (this.risk != null)
                {
                    return this.risk; 
                }
                else if (this.riskIDRef != null)
                {
                    risk = IDManager.getID(riskIDRef) as CommodityDeliveryRisk;
                    return this.risk; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.risk != value)
                {
                    this.risk = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryRiskIDRef { get; set; }
        #region Cycle
        private List<CommodityPipelineCycle> cycle;
        public List<CommodityPipelineCycle> Cycle
        {
            get
            {
                if (this.cycle != null)
                {
                    return this.cycle; 
                }
                else if (this.cycleIDRef != null)
                {
                    cycle = IDManager.getID(cycleIDRef) as List<CommodityPipelineCycle>;
                    return this.cycle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cycle != value)
                {
                    this.cycle = value;
                }
            }
        }
        #endregion
        
        public string CommodityPipelineCycleIDRef { get; set; }
        
    
        
    
    }
    
}


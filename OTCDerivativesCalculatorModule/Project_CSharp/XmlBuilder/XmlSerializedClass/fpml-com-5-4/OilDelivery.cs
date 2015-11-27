using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OilDelivery : ISerialized
    {
        public OilDelivery(XmlNode xmlNode)
        {
            XmlNode pipelineNode = xmlNode.SelectSingleNode("pipeline");
            
            if (pipelineNode != null)
            {
                if (pipelineNode.Attributes["href"] != null || pipelineNode.Attributes["id"] != null) 
                {
                    if (pipelineNode.Attributes["id"] != null) 
                    {
                        pipelineIDRef_ = pipelineNode.Attributes["id"].Value;
                        OilPipelineDelivery ob = new OilPipelineDelivery(pipelineNode);
                        IDManager.SetID(pipelineIDRef_, ob);
                    }
                    else if (pipelineNode.Attributes["href"] != null)
                    {
                        pipelineIDRef_ = pipelineNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pipeline_ = new OilPipelineDelivery(pipelineNode);
                    }
                }
                else
                {
                    pipeline_ = new OilPipelineDelivery(pipelineNode);
                }
            }
            
        
            XmlNode transferNode = xmlNode.SelectSingleNode("transfer");
            
            if (transferNode != null)
            {
                if (transferNode.Attributes["href"] != null || transferNode.Attributes["id"] != null) 
                {
                    if (transferNode.Attributes["id"] != null) 
                    {
                        transferIDRef_ = transferNode.Attributes["id"].Value;
                        OilTransferDelivery ob = new OilTransferDelivery(transferNode);
                        IDManager.SetID(transferIDRef_, ob);
                    }
                    else if (transferNode.Attributes["href"] != null)
                    {
                        transferIDRef_ = transferNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transfer_ = new OilTransferDelivery(transferNode);
                    }
                }
                else
                {
                    transfer_ = new OilTransferDelivery(transferNode);
                }
            }
            
        
            XmlNode importerOfRecordNode = xmlNode.SelectSingleNode("importerOfRecord");
            
            if (importerOfRecordNode != null)
            {
                if (importerOfRecordNode.Attributes["href"] != null || importerOfRecordNode.Attributes["id"] != null) 
                {
                    if (importerOfRecordNode.Attributes["id"] != null) 
                    {
                        importerOfRecordIDRef_ = importerOfRecordNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(importerOfRecordNode);
                        IDManager.SetID(importerOfRecordIDRef_, ob);
                    }
                    else if (importerOfRecordNode.Attributes["href"] != null)
                    {
                        importerOfRecordIDRef_ = importerOfRecordNode.Attributes["href"].Value;
                    }
                    else
                    {
                        importerOfRecord_ = new PartyReference(importerOfRecordNode);
                    }
                }
                else
                {
                    importerOfRecord_ = new PartyReference(importerOfRecordNode);
                }
            }
            
        
            XmlNode absoluteToleranceNode = xmlNode.SelectSingleNode("absoluteTolerance");
            
            if (absoluteToleranceNode != null)
            {
                if (absoluteToleranceNode.Attributes["href"] != null || absoluteToleranceNode.Attributes["id"] != null) 
                {
                    if (absoluteToleranceNode.Attributes["id"] != null) 
                    {
                        absoluteToleranceIDRef_ = absoluteToleranceNode.Attributes["id"].Value;
                        AbsoluteTolerance ob = new AbsoluteTolerance(absoluteToleranceNode);
                        IDManager.SetID(absoluteToleranceIDRef_, ob);
                    }
                    else if (absoluteToleranceNode.Attributes["href"] != null)
                    {
                        absoluteToleranceIDRef_ = absoluteToleranceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        absoluteTolerance_ = new AbsoluteTolerance(absoluteToleranceNode);
                    }
                }
                else
                {
                    absoluteTolerance_ = new AbsoluteTolerance(absoluteToleranceNode);
                }
            }
            
        
            XmlNode percentageToleranceNode = xmlNode.SelectSingleNode("percentageTolerance");
            
            if (percentageToleranceNode != null)
            {
                if (percentageToleranceNode.Attributes["href"] != null || percentageToleranceNode.Attributes["id"] != null) 
                {
                    if (percentageToleranceNode.Attributes["id"] != null) 
                    {
                        percentageToleranceIDRef_ = percentageToleranceNode.Attributes["id"].Value;
                        PercentageTolerance ob = new PercentageTolerance(percentageToleranceNode);
                        IDManager.SetID(percentageToleranceIDRef_, ob);
                    }
                    else if (percentageToleranceNode.Attributes["href"] != null)
                    {
                        percentageToleranceIDRef_ = percentageToleranceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        percentageTolerance_ = new PercentageTolerance(percentageToleranceNode);
                    }
                }
                else
                {
                    percentageTolerance_ = new PercentageTolerance(percentageToleranceNode);
                }
            }
            
        
        }
        
    
        #region Pipeline_
        private OilPipelineDelivery pipeline_;
        public OilPipelineDelivery Pipeline_
        {
            get
            {
                if (this.pipeline_ != null)
                {
                    return this.pipeline_; 
                }
                else if (this.pipelineIDRef_ != null)
                {
                    pipeline_ = IDManager.getID(pipelineIDRef_) as OilPipelineDelivery;
                    return this.pipeline_; 
                }
                else
                {
                      return this.pipeline_; 
                }
            }
            set
            {
                if (this.pipeline_ != value)
                {
                    this.pipeline_ = value;
                }
            }
        }
        #endregion
        
        public string pipelineIDRef_ { get; set; }
        #region Transfer_
        private OilTransferDelivery transfer_;
        public OilTransferDelivery Transfer_
        {
            get
            {
                if (this.transfer_ != null)
                {
                    return this.transfer_; 
                }
                else if (this.transferIDRef_ != null)
                {
                    transfer_ = IDManager.getID(transferIDRef_) as OilTransferDelivery;
                    return this.transfer_; 
                }
                else
                {
                      return this.transfer_; 
                }
            }
            set
            {
                if (this.transfer_ != value)
                {
                    this.transfer_ = value;
                }
            }
        }
        #endregion
        
        public string transferIDRef_ { get; set; }
        #region ImporterOfRecord_
        private PartyReference importerOfRecord_;
        public PartyReference ImporterOfRecord_
        {
            get
            {
                if (this.importerOfRecord_ != null)
                {
                    return this.importerOfRecord_; 
                }
                else if (this.importerOfRecordIDRef_ != null)
                {
                    importerOfRecord_ = IDManager.getID(importerOfRecordIDRef_) as PartyReference;
                    return this.importerOfRecord_; 
                }
                else
                {
                      return this.importerOfRecord_; 
                }
            }
            set
            {
                if (this.importerOfRecord_ != value)
                {
                    this.importerOfRecord_ = value;
                }
            }
        }
        #endregion
        
        public string importerOfRecordIDRef_ { get; set; }
        #region AbsoluteTolerance_
        private AbsoluteTolerance absoluteTolerance_;
        public AbsoluteTolerance AbsoluteTolerance_
        {
            get
            {
                if (this.absoluteTolerance_ != null)
                {
                    return this.absoluteTolerance_; 
                }
                else if (this.absoluteToleranceIDRef_ != null)
                {
                    absoluteTolerance_ = IDManager.getID(absoluteToleranceIDRef_) as AbsoluteTolerance;
                    return this.absoluteTolerance_; 
                }
                else
                {
                      return this.absoluteTolerance_; 
                }
            }
            set
            {
                if (this.absoluteTolerance_ != value)
                {
                    this.absoluteTolerance_ = value;
                }
            }
        }
        #endregion
        
        public string absoluteToleranceIDRef_ { get; set; }
        #region PercentageTolerance_
        private PercentageTolerance percentageTolerance_;
        public PercentageTolerance PercentageTolerance_
        {
            get
            {
                if (this.percentageTolerance_ != null)
                {
                    return this.percentageTolerance_; 
                }
                else if (this.percentageToleranceIDRef_ != null)
                {
                    percentageTolerance_ = IDManager.getID(percentageToleranceIDRef_) as PercentageTolerance;
                    return this.percentageTolerance_; 
                }
                else
                {
                      return this.percentageTolerance_; 
                }
            }
            set
            {
                if (this.percentageTolerance_ != value)
                {
                    this.percentageTolerance_ = value;
                }
            }
        }
        #endregion
        
        public string percentageToleranceIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


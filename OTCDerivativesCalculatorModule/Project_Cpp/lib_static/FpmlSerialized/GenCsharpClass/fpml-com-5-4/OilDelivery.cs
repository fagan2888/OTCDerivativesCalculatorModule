using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OilDelivery
    {
        public OilDelivery(XmlNode xmlNode)
        {
            XmlNodeList pipelineNodeList = xmlNode.SelectNodes("pipeline");
            if (pipelineNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pipelineNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pipelineIDRef = item.Attributes["id"].Name;
                        OilPipelineDelivery ob = OilPipelineDelivery();
                        IDManager.SetID(pipelineIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pipelineIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pipeline = new OilPipelineDelivery(item);
                    }
                }
            }
            
        
            XmlNodeList transferNodeList = xmlNode.SelectNodes("transfer");
            if (transferNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transferNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transferIDRef = item.Attributes["id"].Name;
                        OilTransferDelivery ob = OilTransferDelivery();
                        IDManager.SetID(transferIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transferIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transfer = new OilTransferDelivery(item);
                    }
                }
            }
            
        
            XmlNodeList importerOfRecordNodeList = xmlNode.SelectNodes("importerOfRecord");
            if (importerOfRecordNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in importerOfRecordNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        importerOfRecordIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(importerOfRecordIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        importerOfRecordIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        importerOfRecord = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList absoluteToleranceNodeList = xmlNode.SelectNodes("absoluteTolerance");
            if (absoluteToleranceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in absoluteToleranceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        absoluteToleranceIDRef = item.Attributes["id"].Name;
                        AbsoluteTolerance ob = AbsoluteTolerance();
                        IDManager.SetID(absoluteToleranceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        absoluteToleranceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        absoluteTolerance = new AbsoluteTolerance(item);
                    }
                }
            }
            
        
            XmlNodeList percentageToleranceNodeList = xmlNode.SelectNodes("percentageTolerance");
            if (percentageToleranceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in percentageToleranceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        percentageToleranceIDRef = item.Attributes["id"].Name;
                        PercentageTolerance ob = PercentageTolerance();
                        IDManager.SetID(percentageToleranceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        percentageToleranceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        percentageTolerance = new PercentageTolerance(item);
                    }
                }
            }
            
        
        }
        
    
        #region Pipeline
        private OilPipelineDelivery pipeline;
        public OilPipelineDelivery Pipeline
        {
            get
            {
                if (this.pipeline != null)
                {
                    return this.pipeline; 
                }
                else if (this.pipelineIDRef != null)
                {
                    pipeline = IDManager.getID(pipelineIDRef) as OilPipelineDelivery;
                    return this.pipeline; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pipeline != value)
                {
                    this.pipeline = value;
                }
            }
        }
        #endregion
        
        public string OilPipelineDeliveryIDRef { get; set; }
        #region Transfer
        private OilTransferDelivery transfer;
        public OilTransferDelivery Transfer
        {
            get
            {
                if (this.transfer != null)
                {
                    return this.transfer; 
                }
                else if (this.transferIDRef != null)
                {
                    transfer = IDManager.getID(transferIDRef) as OilTransferDelivery;
                    return this.transfer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transfer != value)
                {
                    this.transfer = value;
                }
            }
        }
        #endregion
        
        public string OilTransferDeliveryIDRef { get; set; }
        #region ImporterOfRecord
        private PartyReference importerOfRecord;
        public PartyReference ImporterOfRecord
        {
            get
            {
                if (this.importerOfRecord != null)
                {
                    return this.importerOfRecord; 
                }
                else if (this.importerOfRecordIDRef != null)
                {
                    importerOfRecord = IDManager.getID(importerOfRecordIDRef) as PartyReference;
                    return this.importerOfRecord; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.importerOfRecord != value)
                {
                    this.importerOfRecord = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AbsoluteTolerance
        private AbsoluteTolerance absoluteTolerance;
        public AbsoluteTolerance AbsoluteTolerance
        {
            get
            {
                if (this.absoluteTolerance != null)
                {
                    return this.absoluteTolerance; 
                }
                else if (this.absoluteToleranceIDRef != null)
                {
                    absoluteTolerance = IDManager.getID(absoluteToleranceIDRef) as AbsoluteTolerance;
                    return this.absoluteTolerance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.absoluteTolerance != value)
                {
                    this.absoluteTolerance = value;
                }
            }
        }
        #endregion
        
        public string AbsoluteToleranceIDRef { get; set; }
        #region PercentageTolerance
        private PercentageTolerance percentageTolerance;
        public PercentageTolerance PercentageTolerance
        {
            get
            {
                if (this.percentageTolerance != null)
                {
                    return this.percentageTolerance; 
                }
                else if (this.percentageToleranceIDRef != null)
                {
                    percentageTolerance = IDManager.getID(percentageToleranceIDRef) as PercentageTolerance;
                    return this.percentageTolerance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.percentageTolerance != value)
                {
                    this.percentageTolerance = value;
                }
            }
        }
        #endregion
        
        public string PercentageToleranceIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


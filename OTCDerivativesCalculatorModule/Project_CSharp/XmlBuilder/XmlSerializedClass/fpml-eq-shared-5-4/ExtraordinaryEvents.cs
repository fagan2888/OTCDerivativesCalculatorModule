using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExtraordinaryEvents : ISerialized
    {
        public ExtraordinaryEvents(XmlNode xmlNode)
        {
            XmlNode mergerEventsNode = xmlNode.SelectSingleNode("mergerEvents");
            
            if (mergerEventsNode != null)
            {
                if (mergerEventsNode.Attributes["href"] != null || mergerEventsNode.Attributes["id"] != null) 
                {
                    if (mergerEventsNode.Attributes["id"] != null) 
                    {
                        mergerEventsIDRef_ = mergerEventsNode.Attributes["id"].Value;
                        EquityCorporateEvents ob = new EquityCorporateEvents(mergerEventsNode);
                        IDManager.SetID(mergerEventsIDRef_, ob);
                    }
                    else if (mergerEventsNode.Attributes["href"] != null)
                    {
                        mergerEventsIDRef_ = mergerEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mergerEvents_ = new EquityCorporateEvents(mergerEventsNode);
                    }
                }
                else
                {
                    mergerEvents_ = new EquityCorporateEvents(mergerEventsNode);
                }
            }
            
        
            XmlNode tenderOfferNode = xmlNode.SelectSingleNode("tenderOffer");
            
            if (tenderOfferNode != null)
            {
                if (tenderOfferNode.Attributes["href"] != null || tenderOfferNode.Attributes["id"] != null) 
                {
                    if (tenderOfferNode.Attributes["id"] != null) 
                    {
                        tenderOfferIDRef_ = tenderOfferNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(tenderOfferNode);
                        IDManager.SetID(tenderOfferIDRef_, ob);
                    }
                    else if (tenderOfferNode.Attributes["href"] != null)
                    {
                        tenderOfferIDRef_ = tenderOfferNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenderOffer_ = new XsdTypeBoolean(tenderOfferNode);
                    }
                }
                else
                {
                    tenderOffer_ = new XsdTypeBoolean(tenderOfferNode);
                }
            }
            
        
            XmlNode tenderOfferEventsNode = xmlNode.SelectSingleNode("tenderOfferEvents");
            
            if (tenderOfferEventsNode != null)
            {
                if (tenderOfferEventsNode.Attributes["href"] != null || tenderOfferEventsNode.Attributes["id"] != null) 
                {
                    if (tenderOfferEventsNode.Attributes["id"] != null) 
                    {
                        tenderOfferEventsIDRef_ = tenderOfferEventsNode.Attributes["id"].Value;
                        EquityCorporateEvents ob = new EquityCorporateEvents(tenderOfferEventsNode);
                        IDManager.SetID(tenderOfferEventsIDRef_, ob);
                    }
                    else if (tenderOfferEventsNode.Attributes["href"] != null)
                    {
                        tenderOfferEventsIDRef_ = tenderOfferEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenderOfferEvents_ = new EquityCorporateEvents(tenderOfferEventsNode);
                    }
                }
                else
                {
                    tenderOfferEvents_ = new EquityCorporateEvents(tenderOfferEventsNode);
                }
            }
            
        
            XmlNode compositionOfCombinedConsiderationNode = xmlNode.SelectSingleNode("compositionOfCombinedConsideration");
            
            if (compositionOfCombinedConsiderationNode != null)
            {
                if (compositionOfCombinedConsiderationNode.Attributes["href"] != null || compositionOfCombinedConsiderationNode.Attributes["id"] != null) 
                {
                    if (compositionOfCombinedConsiderationNode.Attributes["id"] != null) 
                    {
                        compositionOfCombinedConsiderationIDRef_ = compositionOfCombinedConsiderationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(compositionOfCombinedConsiderationNode);
                        IDManager.SetID(compositionOfCombinedConsiderationIDRef_, ob);
                    }
                    else if (compositionOfCombinedConsiderationNode.Attributes["href"] != null)
                    {
                        compositionOfCombinedConsiderationIDRef_ = compositionOfCombinedConsiderationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compositionOfCombinedConsideration_ = new XsdTypeBoolean(compositionOfCombinedConsiderationNode);
                    }
                }
                else
                {
                    compositionOfCombinedConsideration_ = new XsdTypeBoolean(compositionOfCombinedConsiderationNode);
                }
            }
            
        
            XmlNode indexAdjustmentEventsNode = xmlNode.SelectSingleNode("indexAdjustmentEvents");
            
            if (indexAdjustmentEventsNode != null)
            {
                if (indexAdjustmentEventsNode.Attributes["href"] != null || indexAdjustmentEventsNode.Attributes["id"] != null) 
                {
                    if (indexAdjustmentEventsNode.Attributes["id"] != null) 
                    {
                        indexAdjustmentEventsIDRef_ = indexAdjustmentEventsNode.Attributes["id"].Value;
                        IndexAdjustmentEvents ob = new IndexAdjustmentEvents(indexAdjustmentEventsNode);
                        IDManager.SetID(indexAdjustmentEventsIDRef_, ob);
                    }
                    else if (indexAdjustmentEventsNode.Attributes["href"] != null)
                    {
                        indexAdjustmentEventsIDRef_ = indexAdjustmentEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexAdjustmentEvents_ = new IndexAdjustmentEvents(indexAdjustmentEventsNode);
                    }
                }
                else
                {
                    indexAdjustmentEvents_ = new IndexAdjustmentEvents(indexAdjustmentEventsNode);
                }
            }
            
        
            XmlNode additionalDisruptionEventsNode = xmlNode.SelectSingleNode("additionalDisruptionEvents");
            
            if (additionalDisruptionEventsNode != null)
            {
                if (additionalDisruptionEventsNode.Attributes["href"] != null || additionalDisruptionEventsNode.Attributes["id"] != null) 
                {
                    if (additionalDisruptionEventsNode.Attributes["id"] != null) 
                    {
                        additionalDisruptionEventsIDRef_ = additionalDisruptionEventsNode.Attributes["id"].Value;
                        AdditionalDisruptionEvents ob = new AdditionalDisruptionEvents(additionalDisruptionEventsNode);
                        IDManager.SetID(additionalDisruptionEventsIDRef_, ob);
                    }
                    else if (additionalDisruptionEventsNode.Attributes["href"] != null)
                    {
                        additionalDisruptionEventsIDRef_ = additionalDisruptionEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalDisruptionEvents_ = new AdditionalDisruptionEvents(additionalDisruptionEventsNode);
                    }
                }
                else
                {
                    additionalDisruptionEvents_ = new AdditionalDisruptionEvents(additionalDisruptionEventsNode);
                }
            }
            
        
            XmlNode failureToDeliverNode = xmlNode.SelectSingleNode("failureToDeliver");
            
            if (failureToDeliverNode != null)
            {
                if (failureToDeliverNode.Attributes["href"] != null || failureToDeliverNode.Attributes["id"] != null) 
                {
                    if (failureToDeliverNode.Attributes["id"] != null) 
                    {
                        failureToDeliverIDRef_ = failureToDeliverNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(failureToDeliverNode);
                        IDManager.SetID(failureToDeliverIDRef_, ob);
                    }
                    else if (failureToDeliverNode.Attributes["href"] != null)
                    {
                        failureToDeliverIDRef_ = failureToDeliverNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToDeliver_ = new XsdTypeBoolean(failureToDeliverNode);
                    }
                }
                else
                {
                    failureToDeliver_ = new XsdTypeBoolean(failureToDeliverNode);
                }
            }
            
        
            XmlNode representationsNode = xmlNode.SelectSingleNode("representations");
            
            if (representationsNode != null)
            {
                if (representationsNode.Attributes["href"] != null || representationsNode.Attributes["id"] != null) 
                {
                    if (representationsNode.Attributes["id"] != null) 
                    {
                        representationsIDRef_ = representationsNode.Attributes["id"].Value;
                        Representations ob = new Representations(representationsNode);
                        IDManager.SetID(representationsIDRef_, ob);
                    }
                    else if (representationsNode.Attributes["href"] != null)
                    {
                        representationsIDRef_ = representationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        representations_ = new Representations(representationsNode);
                    }
                }
                else
                {
                    representations_ = new Representations(representationsNode);
                }
            }
            
        
            XmlNode nationalisationOrInsolvencyNode = xmlNode.SelectSingleNode("nationalisationOrInsolvency");
            
            if (nationalisationOrInsolvencyNode != null)
            {
                if (nationalisationOrInsolvencyNode.Attributes["href"] != null || nationalisationOrInsolvencyNode.Attributes["id"] != null) 
                {
                    if (nationalisationOrInsolvencyNode.Attributes["id"] != null) 
                    {
                        nationalisationOrInsolvencyIDRef_ = nationalisationOrInsolvencyNode.Attributes["id"].Value;
                        NationalisationOrInsolvencyOrDelistingEventEnum ob = new NationalisationOrInsolvencyOrDelistingEventEnum(nationalisationOrInsolvencyNode);
                        IDManager.SetID(nationalisationOrInsolvencyIDRef_, ob);
                    }
                    else if (nationalisationOrInsolvencyNode.Attributes["href"] != null)
                    {
                        nationalisationOrInsolvencyIDRef_ = nationalisationOrInsolvencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nationalisationOrInsolvency_ = new NationalisationOrInsolvencyOrDelistingEventEnum(nationalisationOrInsolvencyNode);
                    }
                }
                else
                {
                    nationalisationOrInsolvency_ = new NationalisationOrInsolvencyOrDelistingEventEnum(nationalisationOrInsolvencyNode);
                }
            }
            
        
            XmlNode delistingNode = xmlNode.SelectSingleNode("delisting");
            
            if (delistingNode != null)
            {
                if (delistingNode.Attributes["href"] != null || delistingNode.Attributes["id"] != null) 
                {
                    if (delistingNode.Attributes["id"] != null) 
                    {
                        delistingIDRef_ = delistingNode.Attributes["id"].Value;
                        NationalisationOrInsolvencyOrDelistingEventEnum ob = new NationalisationOrInsolvencyOrDelistingEventEnum(delistingNode);
                        IDManager.SetID(delistingIDRef_, ob);
                    }
                    else if (delistingNode.Attributes["href"] != null)
                    {
                        delistingIDRef_ = delistingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        delisting_ = new NationalisationOrInsolvencyOrDelistingEventEnum(delistingNode);
                    }
                }
                else
                {
                    delisting_ = new NationalisationOrInsolvencyOrDelistingEventEnum(delistingNode);
                }
            }
            
        
            XmlNodeList relatedExchangeIdNodeList = xmlNode.SelectNodes("relatedExchangeId");
            
            if (relatedExchangeIdNodeList != null)
            {
                this.relatedExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in relatedExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            relatedExchangeIdIDRef_ = item.Attributes["id"].Value;
                            relatedExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(relatedExchangeIdIDRef_, relatedExchangeId_[relatedExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            relatedExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        relatedExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        relatedExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList optionsExchangeIdNodeList = xmlNode.SelectNodes("optionsExchangeId");
            
            if (optionsExchangeIdNodeList != null)
            {
                this.optionsExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in optionsExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            optionsExchangeIdIDRef_ = item.Attributes["id"].Value;
                            optionsExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(optionsExchangeIdIDRef_, optionsExchangeId_[optionsExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            optionsExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        optionsExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        optionsExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList specifiedExchangeIdNodeList = xmlNode.SelectNodes("specifiedExchangeId");
            
            if (specifiedExchangeIdNodeList != null)
            {
                this.specifiedExchangeId_ = new List<ExchangeId>();
                foreach (XmlNode item in specifiedExchangeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            specifiedExchangeIdIDRef_ = item.Attributes["id"].Value;
                            specifiedExchangeId_.Add(new ExchangeId(item));
                            IDManager.SetID(specifiedExchangeIdIDRef_, specifiedExchangeId_[specifiedExchangeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            specifiedExchangeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        specifiedExchangeId_.Add(new ExchangeId(item));
                        }
                    }
                    else
                    {
                        specifiedExchangeId_.Add(new ExchangeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region MergerEvents_
        private EquityCorporateEvents mergerEvents_;
        public EquityCorporateEvents MergerEvents_
        {
            get
            {
                if (this.mergerEvents_ != null)
                {
                    return this.mergerEvents_; 
                }
                else if (this.mergerEventsIDRef_ != null)
                {
                    mergerEvents_ = IDManager.getID(mergerEventsIDRef_) as EquityCorporateEvents;
                    return this.mergerEvents_; 
                }
                else
                {
                      return this.mergerEvents_; 
                }
            }
            set
            {
                if (this.mergerEvents_ != value)
                {
                    this.mergerEvents_ = value;
                }
            }
        }
        #endregion
        
        public string mergerEventsIDRef_ { get; set; }
        #region TenderOffer_
        private XsdTypeBoolean tenderOffer_;
        public XsdTypeBoolean TenderOffer_
        {
            get
            {
                if (this.tenderOffer_ != null)
                {
                    return this.tenderOffer_; 
                }
                else if (this.tenderOfferIDRef_ != null)
                {
                    tenderOffer_ = IDManager.getID(tenderOfferIDRef_) as XsdTypeBoolean;
                    return this.tenderOffer_; 
                }
                else
                {
                      return this.tenderOffer_; 
                }
            }
            set
            {
                if (this.tenderOffer_ != value)
                {
                    this.tenderOffer_ = value;
                }
            }
        }
        #endregion
        
        public string tenderOfferIDRef_ { get; set; }
        #region TenderOfferEvents_
        private EquityCorporateEvents tenderOfferEvents_;
        public EquityCorporateEvents TenderOfferEvents_
        {
            get
            {
                if (this.tenderOfferEvents_ != null)
                {
                    return this.tenderOfferEvents_; 
                }
                else if (this.tenderOfferEventsIDRef_ != null)
                {
                    tenderOfferEvents_ = IDManager.getID(tenderOfferEventsIDRef_) as EquityCorporateEvents;
                    return this.tenderOfferEvents_; 
                }
                else
                {
                      return this.tenderOfferEvents_; 
                }
            }
            set
            {
                if (this.tenderOfferEvents_ != value)
                {
                    this.tenderOfferEvents_ = value;
                }
            }
        }
        #endregion
        
        public string tenderOfferEventsIDRef_ { get; set; }
        #region CompositionOfCombinedConsideration_
        private XsdTypeBoolean compositionOfCombinedConsideration_;
        public XsdTypeBoolean CompositionOfCombinedConsideration_
        {
            get
            {
                if (this.compositionOfCombinedConsideration_ != null)
                {
                    return this.compositionOfCombinedConsideration_; 
                }
                else if (this.compositionOfCombinedConsiderationIDRef_ != null)
                {
                    compositionOfCombinedConsideration_ = IDManager.getID(compositionOfCombinedConsiderationIDRef_) as XsdTypeBoolean;
                    return this.compositionOfCombinedConsideration_; 
                }
                else
                {
                      return this.compositionOfCombinedConsideration_; 
                }
            }
            set
            {
                if (this.compositionOfCombinedConsideration_ != value)
                {
                    this.compositionOfCombinedConsideration_ = value;
                }
            }
        }
        #endregion
        
        public string compositionOfCombinedConsiderationIDRef_ { get; set; }
        #region IndexAdjustmentEvents_
        private IndexAdjustmentEvents indexAdjustmentEvents_;
        public IndexAdjustmentEvents IndexAdjustmentEvents_
        {
            get
            {
                if (this.indexAdjustmentEvents_ != null)
                {
                    return this.indexAdjustmentEvents_; 
                }
                else if (this.indexAdjustmentEventsIDRef_ != null)
                {
                    indexAdjustmentEvents_ = IDManager.getID(indexAdjustmentEventsIDRef_) as IndexAdjustmentEvents;
                    return this.indexAdjustmentEvents_; 
                }
                else
                {
                      return this.indexAdjustmentEvents_; 
                }
            }
            set
            {
                if (this.indexAdjustmentEvents_ != value)
                {
                    this.indexAdjustmentEvents_ = value;
                }
            }
        }
        #endregion
        
        public string indexAdjustmentEventsIDRef_ { get; set; }
        #region AdditionalDisruptionEvents_
        private AdditionalDisruptionEvents additionalDisruptionEvents_;
        public AdditionalDisruptionEvents AdditionalDisruptionEvents_
        {
            get
            {
                if (this.additionalDisruptionEvents_ != null)
                {
                    return this.additionalDisruptionEvents_; 
                }
                else if (this.additionalDisruptionEventsIDRef_ != null)
                {
                    additionalDisruptionEvents_ = IDManager.getID(additionalDisruptionEventsIDRef_) as AdditionalDisruptionEvents;
                    return this.additionalDisruptionEvents_; 
                }
                else
                {
                      return this.additionalDisruptionEvents_; 
                }
            }
            set
            {
                if (this.additionalDisruptionEvents_ != value)
                {
                    this.additionalDisruptionEvents_ = value;
                }
            }
        }
        #endregion
        
        public string additionalDisruptionEventsIDRef_ { get; set; }
        #region FailureToDeliver_
        private XsdTypeBoolean failureToDeliver_;
        public XsdTypeBoolean FailureToDeliver_
        {
            get
            {
                if (this.failureToDeliver_ != null)
                {
                    return this.failureToDeliver_; 
                }
                else if (this.failureToDeliverIDRef_ != null)
                {
                    failureToDeliver_ = IDManager.getID(failureToDeliverIDRef_) as XsdTypeBoolean;
                    return this.failureToDeliver_; 
                }
                else
                {
                      return this.failureToDeliver_; 
                }
            }
            set
            {
                if (this.failureToDeliver_ != value)
                {
                    this.failureToDeliver_ = value;
                }
            }
        }
        #endregion
        
        public string failureToDeliverIDRef_ { get; set; }
        #region Representations_
        private Representations representations_;
        public Representations Representations_
        {
            get
            {
                if (this.representations_ != null)
                {
                    return this.representations_; 
                }
                else if (this.representationsIDRef_ != null)
                {
                    representations_ = IDManager.getID(representationsIDRef_) as Representations;
                    return this.representations_; 
                }
                else
                {
                      return this.representations_; 
                }
            }
            set
            {
                if (this.representations_ != value)
                {
                    this.representations_ = value;
                }
            }
        }
        #endregion
        
        public string representationsIDRef_ { get; set; }
        #region NationalisationOrInsolvency_
        private NationalisationOrInsolvencyOrDelistingEventEnum nationalisationOrInsolvency_;
        public NationalisationOrInsolvencyOrDelistingEventEnum NationalisationOrInsolvency_
        {
            get
            {
                if (this.nationalisationOrInsolvency_ != null)
                {
                    return this.nationalisationOrInsolvency_; 
                }
                else if (this.nationalisationOrInsolvencyIDRef_ != null)
                {
                    nationalisationOrInsolvency_ = IDManager.getID(nationalisationOrInsolvencyIDRef_) as NationalisationOrInsolvencyOrDelistingEventEnum;
                    return this.nationalisationOrInsolvency_; 
                }
                else
                {
                      return this.nationalisationOrInsolvency_; 
                }
            }
            set
            {
                if (this.nationalisationOrInsolvency_ != value)
                {
                    this.nationalisationOrInsolvency_ = value;
                }
            }
        }
        #endregion
        
        public string nationalisationOrInsolvencyIDRef_ { get; set; }
        #region Delisting_
        private NationalisationOrInsolvencyOrDelistingEventEnum delisting_;
        public NationalisationOrInsolvencyOrDelistingEventEnum Delisting_
        {
            get
            {
                if (this.delisting_ != null)
                {
                    return this.delisting_; 
                }
                else if (this.delistingIDRef_ != null)
                {
                    delisting_ = IDManager.getID(delistingIDRef_) as NationalisationOrInsolvencyOrDelistingEventEnum;
                    return this.delisting_; 
                }
                else
                {
                      return this.delisting_; 
                }
            }
            set
            {
                if (this.delisting_ != value)
                {
                    this.delisting_ = value;
                }
            }
        }
        #endregion
        
        public string delistingIDRef_ { get; set; }
        #region RelatedExchangeId_
        private List<ExchangeId> relatedExchangeId_;
        public List<ExchangeId> RelatedExchangeId_
        {
            get
            {
                if (this.relatedExchangeId_ != null)
                {
                    return this.relatedExchangeId_; 
                }
                else if (this.relatedExchangeIdIDRef_ != null)
                {
                    return this.relatedExchangeId_; 
                }
                else
                {
                      return this.relatedExchangeId_; 
                }
            }
            set
            {
                if (this.relatedExchangeId_ != value)
                {
                    this.relatedExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string relatedExchangeIdIDRef_ { get; set; }
        #region OptionsExchangeId_
        private List<ExchangeId> optionsExchangeId_;
        public List<ExchangeId> OptionsExchangeId_
        {
            get
            {
                if (this.optionsExchangeId_ != null)
                {
                    return this.optionsExchangeId_; 
                }
                else if (this.optionsExchangeIdIDRef_ != null)
                {
                    return this.optionsExchangeId_; 
                }
                else
                {
                      return this.optionsExchangeId_; 
                }
            }
            set
            {
                if (this.optionsExchangeId_ != value)
                {
                    this.optionsExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string optionsExchangeIdIDRef_ { get; set; }
        #region SpecifiedExchangeId_
        private List<ExchangeId> specifiedExchangeId_;
        public List<ExchangeId> SpecifiedExchangeId_
        {
            get
            {
                if (this.specifiedExchangeId_ != null)
                {
                    return this.specifiedExchangeId_; 
                }
                else if (this.specifiedExchangeIdIDRef_ != null)
                {
                    return this.specifiedExchangeId_; 
                }
                else
                {
                      return this.specifiedExchangeId_; 
                }
            }
            set
            {
                if (this.specifiedExchangeId_ != value)
                {
                    this.specifiedExchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string specifiedExchangeIdIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


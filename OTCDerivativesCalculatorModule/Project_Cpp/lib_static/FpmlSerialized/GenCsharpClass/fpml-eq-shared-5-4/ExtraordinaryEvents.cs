using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExtraordinaryEvents
    {
        public ExtraordinaryEvents(XmlNode xmlNode)
        {
            XmlNodeList mergerEventsNodeList = xmlNode.SelectNodes("mergerEvents");
            if (mergerEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mergerEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mergerEventsIDRef = item.Attributes["id"].Name;
                        EquityCorporateEvents ob = EquityCorporateEvents();
                        IDManager.SetID(mergerEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mergerEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mergerEvents = new EquityCorporateEvents(item);
                    }
                }
            }
            
        
            XmlNodeList tenderOfferNodeList = xmlNode.SelectNodes("tenderOffer");
            if (tenderOfferNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenderOfferNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenderOfferIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(tenderOfferIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenderOfferIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenderOffer = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList tenderOfferEventsNodeList = xmlNode.SelectNodes("tenderOfferEvents");
            if (tenderOfferEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenderOfferEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenderOfferEventsIDRef = item.Attributes["id"].Name;
                        EquityCorporateEvents ob = EquityCorporateEvents();
                        IDManager.SetID(tenderOfferEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenderOfferEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenderOfferEvents = new EquityCorporateEvents(item);
                    }
                }
            }
            
        
            XmlNodeList compositionOfCombinedConsiderationNodeList = xmlNode.SelectNodes("compositionOfCombinedConsideration");
            if (compositionOfCombinedConsiderationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compositionOfCombinedConsiderationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compositionOfCombinedConsiderationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(compositionOfCombinedConsiderationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compositionOfCombinedConsiderationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compositionOfCombinedConsideration = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList indexAdjustmentEventsNodeList = xmlNode.SelectNodes("indexAdjustmentEvents");
            if (indexAdjustmentEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexAdjustmentEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexAdjustmentEventsIDRef = item.Attributes["id"].Name;
                        IndexAdjustmentEvents ob = IndexAdjustmentEvents();
                        IDManager.SetID(indexAdjustmentEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexAdjustmentEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexAdjustmentEvents = new IndexAdjustmentEvents(item);
                    }
                }
            }
            
        
            XmlNodeList additionalDisruptionEventsNodeList = xmlNode.SelectNodes("additionalDisruptionEvents");
            if (additionalDisruptionEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalDisruptionEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalDisruptionEventsIDRef = item.Attributes["id"].Name;
                        AdditionalDisruptionEvents ob = AdditionalDisruptionEvents();
                        IDManager.SetID(additionalDisruptionEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalDisruptionEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalDisruptionEvents = new AdditionalDisruptionEvents(item);
                    }
                }
            }
            
        
            XmlNodeList failureToDeliverNodeList = xmlNode.SelectNodes("failureToDeliver");
            if (failureToDeliverNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToDeliverNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToDeliverIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(failureToDeliverIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToDeliverIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToDeliver = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList representationsNodeList = xmlNode.SelectNodes("representations");
            if (representationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in representationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        representationsIDRef = item.Attributes["id"].Name;
                        Representations ob = Representations();
                        IDManager.SetID(representationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        representationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        representations = new Representations(item);
                    }
                }
            }
            
        
            XmlNodeList nationalisationOrInsolvencyNodeList = xmlNode.SelectNodes("nationalisationOrInsolvency");
            if (nationalisationOrInsolvencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nationalisationOrInsolvencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nationalisationOrInsolvencyIDRef = item.Attributes["id"].Name;
                        NationalisationOrInsolvencyOrDelistingEventEnum ob = NationalisationOrInsolvencyOrDelistingEventEnum();
                        IDManager.SetID(nationalisationOrInsolvencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nationalisationOrInsolvencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nationalisationOrInsolvency = new NationalisationOrInsolvencyOrDelistingEventEnum(item);
                    }
                }
            }
            
        
            XmlNodeList delistingNodeList = xmlNode.SelectNodes("delisting");
            if (delistingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in delistingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        delistingIDRef = item.Attributes["id"].Name;
                        NationalisationOrInsolvencyOrDelistingEventEnum ob = NationalisationOrInsolvencyOrDelistingEventEnum();
                        IDManager.SetID(delistingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        delistingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        delisting = new NationalisationOrInsolvencyOrDelistingEventEnum(item);
                    }
                }
            }
            
        
            XmlNodeList relatedExchangeIdNodeList = xmlNode.SelectNodes("relatedExchangeId");
            
            foreach (XmlNode item in relatedExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relatedExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(relatedExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relatedExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    relatedExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList optionsExchangeIdNodeList = xmlNode.SelectNodes("optionsExchangeId");
            
            foreach (XmlNode item in optionsExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionsExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(optionsExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionsExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    optionsExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
            XmlNodeList specifiedExchangeIdNodeList = xmlNode.SelectNodes("specifiedExchangeId");
            
            foreach (XmlNode item in specifiedExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specifiedExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(specifiedExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specifiedExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    specifiedExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region MergerEvents
        private EquityCorporateEvents mergerEvents;
        public EquityCorporateEvents MergerEvents
        {
            get
            {
                if (this.mergerEvents != null)
                {
                    return this.mergerEvents; 
                }
                else if (this.mergerEventsIDRef != null)
                {
                    mergerEvents = IDManager.getID(mergerEventsIDRef) as EquityCorporateEvents;
                    return this.mergerEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mergerEvents != value)
                {
                    this.mergerEvents = value;
                }
            }
        }
        #endregion
        
        public string EquityCorporateEventsIDRef { get; set; }
        #region TenderOffer
        private XsdTypeBoolean tenderOffer;
        public XsdTypeBoolean TenderOffer
        {
            get
            {
                if (this.tenderOffer != null)
                {
                    return this.tenderOffer; 
                }
                else if (this.tenderOfferIDRef != null)
                {
                    tenderOffer = IDManager.getID(tenderOfferIDRef) as XsdTypeBoolean;
                    return this.tenderOffer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenderOffer != value)
                {
                    this.tenderOffer = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region TenderOfferEvents
        private EquityCorporateEvents tenderOfferEvents;
        public EquityCorporateEvents TenderOfferEvents
        {
            get
            {
                if (this.tenderOfferEvents != null)
                {
                    return this.tenderOfferEvents; 
                }
                else if (this.tenderOfferEventsIDRef != null)
                {
                    tenderOfferEvents = IDManager.getID(tenderOfferEventsIDRef) as EquityCorporateEvents;
                    return this.tenderOfferEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenderOfferEvents != value)
                {
                    this.tenderOfferEvents = value;
                }
            }
        }
        #endregion
        
        public string EquityCorporateEventsIDRef { get; set; }
        #region CompositionOfCombinedConsideration
        private XsdTypeBoolean compositionOfCombinedConsideration;
        public XsdTypeBoolean CompositionOfCombinedConsideration
        {
            get
            {
                if (this.compositionOfCombinedConsideration != null)
                {
                    return this.compositionOfCombinedConsideration; 
                }
                else if (this.compositionOfCombinedConsiderationIDRef != null)
                {
                    compositionOfCombinedConsideration = IDManager.getID(compositionOfCombinedConsiderationIDRef) as XsdTypeBoolean;
                    return this.compositionOfCombinedConsideration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compositionOfCombinedConsideration != value)
                {
                    this.compositionOfCombinedConsideration = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region IndexAdjustmentEvents
        private IndexAdjustmentEvents indexAdjustmentEvents;
        public IndexAdjustmentEvents IndexAdjustmentEvents
        {
            get
            {
                if (this.indexAdjustmentEvents != null)
                {
                    return this.indexAdjustmentEvents; 
                }
                else if (this.indexAdjustmentEventsIDRef != null)
                {
                    indexAdjustmentEvents = IDManager.getID(indexAdjustmentEventsIDRef) as IndexAdjustmentEvents;
                    return this.indexAdjustmentEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexAdjustmentEvents != value)
                {
                    this.indexAdjustmentEvents = value;
                }
            }
        }
        #endregion
        
        public string IndexAdjustmentEventsIDRef { get; set; }
        #region AdditionalDisruptionEvents
        private AdditionalDisruptionEvents additionalDisruptionEvents;
        public AdditionalDisruptionEvents AdditionalDisruptionEvents
        {
            get
            {
                if (this.additionalDisruptionEvents != null)
                {
                    return this.additionalDisruptionEvents; 
                }
                else if (this.additionalDisruptionEventsIDRef != null)
                {
                    additionalDisruptionEvents = IDManager.getID(additionalDisruptionEventsIDRef) as AdditionalDisruptionEvents;
                    return this.additionalDisruptionEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalDisruptionEvents != value)
                {
                    this.additionalDisruptionEvents = value;
                }
            }
        }
        #endregion
        
        public string AdditionalDisruptionEventsIDRef { get; set; }
        #region FailureToDeliver
        private XsdTypeBoolean failureToDeliver;
        public XsdTypeBoolean FailureToDeliver
        {
            get
            {
                if (this.failureToDeliver != null)
                {
                    return this.failureToDeliver; 
                }
                else if (this.failureToDeliverIDRef != null)
                {
                    failureToDeliver = IDManager.getID(failureToDeliverIDRef) as XsdTypeBoolean;
                    return this.failureToDeliver; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToDeliver != value)
                {
                    this.failureToDeliver = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Representations
        private Representations representations;
        public Representations Representations
        {
            get
            {
                if (this.representations != null)
                {
                    return this.representations; 
                }
                else if (this.representationsIDRef != null)
                {
                    representations = IDManager.getID(representationsIDRef) as Representations;
                    return this.representations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.representations != value)
                {
                    this.representations = value;
                }
            }
        }
        #endregion
        
        public string RepresentationsIDRef { get; set; }
        #region NationalisationOrInsolvency
        private NationalisationOrInsolvencyOrDelistingEventEnum nationalisationOrInsolvency;
        public NationalisationOrInsolvencyOrDelistingEventEnum NationalisationOrInsolvency
        {
            get
            {
                if (this.nationalisationOrInsolvency != null)
                {
                    return this.nationalisationOrInsolvency; 
                }
                else if (this.nationalisationOrInsolvencyIDRef != null)
                {
                    nationalisationOrInsolvency = IDManager.getID(nationalisationOrInsolvencyIDRef) as NationalisationOrInsolvencyOrDelistingEventEnum;
                    return this.nationalisationOrInsolvency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nationalisationOrInsolvency != value)
                {
                    this.nationalisationOrInsolvency = value;
                }
            }
        }
        #endregion
        
        public string NationalisationOrInsolvencyOrDelistingEventEnumIDRef { get; set; }
        #region Delisting
        private NationalisationOrInsolvencyOrDelistingEventEnum delisting;
        public NationalisationOrInsolvencyOrDelistingEventEnum Delisting
        {
            get
            {
                if (this.delisting != null)
                {
                    return this.delisting; 
                }
                else if (this.delistingIDRef != null)
                {
                    delisting = IDManager.getID(delistingIDRef) as NationalisationOrInsolvencyOrDelistingEventEnum;
                    return this.delisting; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.delisting != value)
                {
                    this.delisting = value;
                }
            }
        }
        #endregion
        
        public string NationalisationOrInsolvencyOrDelistingEventEnumIDRef { get; set; }
        #region RelatedExchangeId
        private List<ExchangeId> relatedExchangeId;
        public List<ExchangeId> RelatedExchangeId
        {
            get
            {
                if (this.relatedExchangeId != null)
                {
                    return this.relatedExchangeId; 
                }
                else if (this.relatedExchangeIdIDRef != null)
                {
                    relatedExchangeId = IDManager.getID(relatedExchangeIdIDRef) as List<ExchangeId>;
                    return this.relatedExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relatedExchangeId != value)
                {
                    this.relatedExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        #region OptionsExchangeId
        private List<ExchangeId> optionsExchangeId;
        public List<ExchangeId> OptionsExchangeId
        {
            get
            {
                if (this.optionsExchangeId != null)
                {
                    return this.optionsExchangeId; 
                }
                else if (this.optionsExchangeIdIDRef != null)
                {
                    optionsExchangeId = IDManager.getID(optionsExchangeIdIDRef) as List<ExchangeId>;
                    return this.optionsExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionsExchangeId != value)
                {
                    this.optionsExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        #region SpecifiedExchangeId
        private List<ExchangeId> specifiedExchangeId;
        public List<ExchangeId> SpecifiedExchangeId
        {
            get
            {
                if (this.specifiedExchangeId != null)
                {
                    return this.specifiedExchangeId; 
                }
                else if (this.specifiedExchangeIdIDRef != null)
                {
                    specifiedExchangeId = IDManager.getID(specifiedExchangeIdIDRef) as List<ExchangeId>;
                    return this.specifiedExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specifiedExchangeId != value)
                {
                    this.specifiedExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


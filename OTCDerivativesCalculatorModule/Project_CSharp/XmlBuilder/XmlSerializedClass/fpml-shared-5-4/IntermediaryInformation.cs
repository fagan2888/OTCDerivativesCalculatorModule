using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IntermediaryInformation : ISerialized
    {
        public IntermediaryInformation(XmlNode xmlNode)
        {
            XmlNode routingIdsNode = xmlNode.SelectSingleNode("routingIds");
            
            if (routingIdsNode != null)
            {
                if (routingIdsNode.Attributes["href"] != null || routingIdsNode.Attributes["id"] != null) 
                {
                    if (routingIdsNode.Attributes["id"] != null) 
                    {
                        routingIdsIDRef_ = routingIdsNode.Attributes["id"].Value;
                        RoutingIds ob = new RoutingIds(routingIdsNode);
                        IDManager.SetID(routingIdsIDRef_, ob);
                    }
                    else if (routingIdsNode.Attributes["href"] != null)
                    {
                        routingIdsIDRef_ = routingIdsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        routingIds_ = new RoutingIds(routingIdsNode);
                    }
                }
                else
                {
                    routingIds_ = new RoutingIds(routingIdsNode);
                }
            }
            
        
            XmlNode routingExplicitDetailsNode = xmlNode.SelectSingleNode("routingExplicitDetails");
            
            if (routingExplicitDetailsNode != null)
            {
                if (routingExplicitDetailsNode.Attributes["href"] != null || routingExplicitDetailsNode.Attributes["id"] != null) 
                {
                    if (routingExplicitDetailsNode.Attributes["id"] != null) 
                    {
                        routingExplicitDetailsIDRef_ = routingExplicitDetailsNode.Attributes["id"].Value;
                        RoutingExplicitDetails ob = new RoutingExplicitDetails(routingExplicitDetailsNode);
                        IDManager.SetID(routingExplicitDetailsIDRef_, ob);
                    }
                    else if (routingExplicitDetailsNode.Attributes["href"] != null)
                    {
                        routingExplicitDetailsIDRef_ = routingExplicitDetailsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        routingExplicitDetails_ = new RoutingExplicitDetails(routingExplicitDetailsNode);
                    }
                }
                else
                {
                    routingExplicitDetails_ = new RoutingExplicitDetails(routingExplicitDetailsNode);
                }
            }
            
        
            XmlNode routingIdsAndExplicitDetailsNode = xmlNode.SelectSingleNode("routingIdsAndExplicitDetails");
            
            if (routingIdsAndExplicitDetailsNode != null)
            {
                if (routingIdsAndExplicitDetailsNode.Attributes["href"] != null || routingIdsAndExplicitDetailsNode.Attributes["id"] != null) 
                {
                    if (routingIdsAndExplicitDetailsNode.Attributes["id"] != null) 
                    {
                        routingIdsAndExplicitDetailsIDRef_ = routingIdsAndExplicitDetailsNode.Attributes["id"].Value;
                        RoutingIdsAndExplicitDetails ob = new RoutingIdsAndExplicitDetails(routingIdsAndExplicitDetailsNode);
                        IDManager.SetID(routingIdsAndExplicitDetailsIDRef_, ob);
                    }
                    else if (routingIdsAndExplicitDetailsNode.Attributes["href"] != null)
                    {
                        routingIdsAndExplicitDetailsIDRef_ = routingIdsAndExplicitDetailsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        routingIdsAndExplicitDetails_ = new RoutingIdsAndExplicitDetails(routingIdsAndExplicitDetailsNode);
                    }
                }
                else
                {
                    routingIdsAndExplicitDetails_ = new RoutingIdsAndExplicitDetails(routingIdsAndExplicitDetailsNode);
                }
            }
            
        
            XmlNode intermediarySequenceNumberNode = xmlNode.SelectSingleNode("intermediarySequenceNumber");
            
            if (intermediarySequenceNumberNode != null)
            {
                if (intermediarySequenceNumberNode.Attributes["href"] != null || intermediarySequenceNumberNode.Attributes["id"] != null) 
                {
                    if (intermediarySequenceNumberNode.Attributes["id"] != null) 
                    {
                        intermediarySequenceNumberIDRef_ = intermediarySequenceNumberNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(intermediarySequenceNumberNode);
                        IDManager.SetID(intermediarySequenceNumberIDRef_, ob);
                    }
                    else if (intermediarySequenceNumberNode.Attributes["href"] != null)
                    {
                        intermediarySequenceNumberIDRef_ = intermediarySequenceNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        intermediarySequenceNumber_ = new XsdTypePositiveInteger(intermediarySequenceNumberNode);
                    }
                }
                else
                {
                    intermediarySequenceNumber_ = new XsdTypePositiveInteger(intermediarySequenceNumberNode);
                }
            }
            
        
            XmlNode intermediaryPartyReferenceNode = xmlNode.SelectSingleNode("intermediaryPartyReference");
            
            if (intermediaryPartyReferenceNode != null)
            {
                if (intermediaryPartyReferenceNode.Attributes["href"] != null || intermediaryPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (intermediaryPartyReferenceNode.Attributes["id"] != null) 
                    {
                        intermediaryPartyReferenceIDRef_ = intermediaryPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(intermediaryPartyReferenceNode);
                        IDManager.SetID(intermediaryPartyReferenceIDRef_, ob);
                    }
                    else if (intermediaryPartyReferenceNode.Attributes["href"] != null)
                    {
                        intermediaryPartyReferenceIDRef_ = intermediaryPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        intermediaryPartyReference_ = new PartyReference(intermediaryPartyReferenceNode);
                    }
                }
                else
                {
                    intermediaryPartyReference_ = new PartyReference(intermediaryPartyReferenceNode);
                }
            }
            
        
        }
        
    
        #region RoutingIds_
        private RoutingIds routingIds_;
        public RoutingIds RoutingIds_
        {
            get
            {
                if (this.routingIds_ != null)
                {
                    return this.routingIds_; 
                }
                else if (this.routingIdsIDRef_ != null)
                {
                    routingIds_ = IDManager.getID(routingIdsIDRef_) as RoutingIds;
                    return this.routingIds_; 
                }
                else
                {
                      return this.routingIds_; 
                }
            }
            set
            {
                if (this.routingIds_ != value)
                {
                    this.routingIds_ = value;
                }
            }
        }
        #endregion
        
        public string routingIdsIDRef_ { get; set; }
        #region RoutingExplicitDetails_
        private RoutingExplicitDetails routingExplicitDetails_;
        public RoutingExplicitDetails RoutingExplicitDetails_
        {
            get
            {
                if (this.routingExplicitDetails_ != null)
                {
                    return this.routingExplicitDetails_; 
                }
                else if (this.routingExplicitDetailsIDRef_ != null)
                {
                    routingExplicitDetails_ = IDManager.getID(routingExplicitDetailsIDRef_) as RoutingExplicitDetails;
                    return this.routingExplicitDetails_; 
                }
                else
                {
                      return this.routingExplicitDetails_; 
                }
            }
            set
            {
                if (this.routingExplicitDetails_ != value)
                {
                    this.routingExplicitDetails_ = value;
                }
            }
        }
        #endregion
        
        public string routingExplicitDetailsIDRef_ { get; set; }
        #region RoutingIdsAndExplicitDetails_
        private RoutingIdsAndExplicitDetails routingIdsAndExplicitDetails_;
        public RoutingIdsAndExplicitDetails RoutingIdsAndExplicitDetails_
        {
            get
            {
                if (this.routingIdsAndExplicitDetails_ != null)
                {
                    return this.routingIdsAndExplicitDetails_; 
                }
                else if (this.routingIdsAndExplicitDetailsIDRef_ != null)
                {
                    routingIdsAndExplicitDetails_ = IDManager.getID(routingIdsAndExplicitDetailsIDRef_) as RoutingIdsAndExplicitDetails;
                    return this.routingIdsAndExplicitDetails_; 
                }
                else
                {
                      return this.routingIdsAndExplicitDetails_; 
                }
            }
            set
            {
                if (this.routingIdsAndExplicitDetails_ != value)
                {
                    this.routingIdsAndExplicitDetails_ = value;
                }
            }
        }
        #endregion
        
        public string routingIdsAndExplicitDetailsIDRef_ { get; set; }
        #region IntermediarySequenceNumber_
        private XsdTypePositiveInteger intermediarySequenceNumber_;
        public XsdTypePositiveInteger IntermediarySequenceNumber_
        {
            get
            {
                if (this.intermediarySequenceNumber_ != null)
                {
                    return this.intermediarySequenceNumber_; 
                }
                else if (this.intermediarySequenceNumberIDRef_ != null)
                {
                    intermediarySequenceNumber_ = IDManager.getID(intermediarySequenceNumberIDRef_) as XsdTypePositiveInteger;
                    return this.intermediarySequenceNumber_; 
                }
                else
                {
                      return this.intermediarySequenceNumber_; 
                }
            }
            set
            {
                if (this.intermediarySequenceNumber_ != value)
                {
                    this.intermediarySequenceNumber_ = value;
                }
            }
        }
        #endregion
        
        public string intermediarySequenceNumberIDRef_ { get; set; }
        #region IntermediaryPartyReference_
        private PartyReference intermediaryPartyReference_;
        public PartyReference IntermediaryPartyReference_
        {
            get
            {
                if (this.intermediaryPartyReference_ != null)
                {
                    return this.intermediaryPartyReference_; 
                }
                else if (this.intermediaryPartyReferenceIDRef_ != null)
                {
                    intermediaryPartyReference_ = IDManager.getID(intermediaryPartyReferenceIDRef_) as PartyReference;
                    return this.intermediaryPartyReference_; 
                }
                else
                {
                      return this.intermediaryPartyReference_; 
                }
            }
            set
            {
                if (this.intermediaryPartyReference_ != value)
                {
                    this.intermediaryPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string intermediaryPartyReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


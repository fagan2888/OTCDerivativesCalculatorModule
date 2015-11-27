using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IntermediaryInformation
    {
        public IntermediaryInformation(XmlNode xmlNode)
        {
            XmlNodeList routingIdsNodeList = xmlNode.SelectNodes("routingIds");
            if (routingIdsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in routingIdsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingIdsIDRef = item.Attributes["id"].Name;
                        RoutingIds ob = RoutingIds();
                        IDManager.SetID(routingIdsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingIdsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        routingIds = new RoutingIds(item);
                    }
                }
            }
            
        
            XmlNodeList routingExplicitDetailsNodeList = xmlNode.SelectNodes("routingExplicitDetails");
            if (routingExplicitDetailsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in routingExplicitDetailsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingExplicitDetailsIDRef = item.Attributes["id"].Name;
                        RoutingExplicitDetails ob = RoutingExplicitDetails();
                        IDManager.SetID(routingExplicitDetailsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingExplicitDetailsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        routingExplicitDetails = new RoutingExplicitDetails(item);
                    }
                }
            }
            
        
            XmlNodeList routingIdsAndExplicitDetailsNodeList = xmlNode.SelectNodes("routingIdsAndExplicitDetails");
            if (routingIdsAndExplicitDetailsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in routingIdsAndExplicitDetailsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        routingIdsAndExplicitDetailsIDRef = item.Attributes["id"].Name;
                        RoutingIdsAndExplicitDetails ob = RoutingIdsAndExplicitDetails();
                        IDManager.SetID(routingIdsAndExplicitDetailsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        routingIdsAndExplicitDetailsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        routingIdsAndExplicitDetails = new RoutingIdsAndExplicitDetails(item);
                    }
                }
            }
            
        
            XmlNodeList intermediarySequenceNumberNodeList = xmlNode.SelectNodes("intermediarySequenceNumber");
            if (intermediarySequenceNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in intermediarySequenceNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        intermediarySequenceNumberIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(intermediarySequenceNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        intermediarySequenceNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        intermediarySequenceNumber = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList intermediaryPartyReferenceNodeList = xmlNode.SelectNodes("intermediaryPartyReference");
            if (intermediaryPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in intermediaryPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        intermediaryPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(intermediaryPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        intermediaryPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        intermediaryPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region RoutingIds
        private RoutingIds routingIds;
        public RoutingIds RoutingIds
        {
            get
            {
                if (this.routingIds != null)
                {
                    return this.routingIds; 
                }
                else if (this.routingIdsIDRef != null)
                {
                    routingIds = IDManager.getID(routingIdsIDRef) as RoutingIds;
                    return this.routingIds; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingIds != value)
                {
                    this.routingIds = value;
                }
            }
        }
        #endregion
        
        public string RoutingIdsIDRef { get; set; }
        #region RoutingExplicitDetails
        private RoutingExplicitDetails routingExplicitDetails;
        public RoutingExplicitDetails RoutingExplicitDetails
        {
            get
            {
                if (this.routingExplicitDetails != null)
                {
                    return this.routingExplicitDetails; 
                }
                else if (this.routingExplicitDetailsIDRef != null)
                {
                    routingExplicitDetails = IDManager.getID(routingExplicitDetailsIDRef) as RoutingExplicitDetails;
                    return this.routingExplicitDetails; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingExplicitDetails != value)
                {
                    this.routingExplicitDetails = value;
                }
            }
        }
        #endregion
        
        public string RoutingExplicitDetailsIDRef { get; set; }
        #region RoutingIdsAndExplicitDetails
        private RoutingIdsAndExplicitDetails routingIdsAndExplicitDetails;
        public RoutingIdsAndExplicitDetails RoutingIdsAndExplicitDetails
        {
            get
            {
                if (this.routingIdsAndExplicitDetails != null)
                {
                    return this.routingIdsAndExplicitDetails; 
                }
                else if (this.routingIdsAndExplicitDetailsIDRef != null)
                {
                    routingIdsAndExplicitDetails = IDManager.getID(routingIdsAndExplicitDetailsIDRef) as RoutingIdsAndExplicitDetails;
                    return this.routingIdsAndExplicitDetails; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.routingIdsAndExplicitDetails != value)
                {
                    this.routingIdsAndExplicitDetails = value;
                }
            }
        }
        #endregion
        
        public string RoutingIdsAndExplicitDetailsIDRef { get; set; }
        #region IntermediarySequenceNumber
        private XsdTypePositiveInteger intermediarySequenceNumber;
        public XsdTypePositiveInteger IntermediarySequenceNumber
        {
            get
            {
                if (this.intermediarySequenceNumber != null)
                {
                    return this.intermediarySequenceNumber; 
                }
                else if (this.intermediarySequenceNumberIDRef != null)
                {
                    intermediarySequenceNumber = IDManager.getID(intermediarySequenceNumberIDRef) as XsdTypePositiveInteger;
                    return this.intermediarySequenceNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.intermediarySequenceNumber != value)
                {
                    this.intermediarySequenceNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region IntermediaryPartyReference
        private PartyReference intermediaryPartyReference;
        public PartyReference IntermediaryPartyReference
        {
            get
            {
                if (this.intermediaryPartyReference != null)
                {
                    return this.intermediaryPartyReference; 
                }
                else if (this.intermediaryPartyReferenceIDRef != null)
                {
                    intermediaryPartyReference = IDManager.getID(intermediaryPartyReferenceIDRef) as PartyReference;
                    return this.intermediaryPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.intermediaryPartyReference != value)
                {
                    this.intermediaryPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


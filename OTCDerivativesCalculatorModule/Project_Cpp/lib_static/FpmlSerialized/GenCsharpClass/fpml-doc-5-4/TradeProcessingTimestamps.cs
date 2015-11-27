using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeProcessingTimestamps
    {
        public TradeProcessingTimestamps(XmlNode xmlNode)
        {
            XmlNodeList orderEnteredNodeList = xmlNode.SelectNodes("orderEntered");
            if (orderEnteredNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in orderEnteredNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        orderEnteredIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(orderEnteredIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        orderEnteredIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        orderEntered = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList orderSubmittedNodeList = xmlNode.SelectNodes("orderSubmitted");
            if (orderSubmittedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in orderSubmittedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        orderSubmittedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(orderSubmittedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        orderSubmittedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        orderSubmitted = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList publiclyReportedNodeList = xmlNode.SelectNodes("publiclyReported");
            if (publiclyReportedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in publiclyReportedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publiclyReportedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(publiclyReportedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publiclyReportedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        publiclyReported = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList publicReportUpdatedNodeList = xmlNode.SelectNodes("publicReportUpdated");
            if (publicReportUpdatedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in publicReportUpdatedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publicReportUpdatedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(publicReportUpdatedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publicReportUpdatedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        publicReportUpdated = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList nonpubliclyReportedNodeList = xmlNode.SelectNodes("nonpubliclyReported");
            if (nonpubliclyReportedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonpubliclyReportedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonpubliclyReportedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(nonpubliclyReportedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonpubliclyReportedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonpubliclyReported = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList nonpublicReportUpdatedNodeList = xmlNode.SelectNodes("nonpublicReportUpdated");
            if (nonpublicReportUpdatedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonpublicReportUpdatedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonpublicReportUpdatedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(nonpublicReportUpdatedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonpublicReportUpdatedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonpublicReportUpdated = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList submittedForConfirmationNodeList = xmlNode.SelectNodes("submittedForConfirmation");
            if (submittedForConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in submittedForConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        submittedForConfirmationIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(submittedForConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        submittedForConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        submittedForConfirmation = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList updatedForConfirmationNodeList = xmlNode.SelectNodes("updatedForConfirmation");
            if (updatedForConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in updatedForConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        updatedForConfirmationIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(updatedForConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        updatedForConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        updatedForConfirmation = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList confirmedNodeList = xmlNode.SelectNodes("confirmed");
            if (confirmedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in confirmedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        confirmedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(confirmedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        confirmedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        confirmed = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList submittedForClearingNodeList = xmlNode.SelectNodes("submittedForClearing");
            if (submittedForClearingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in submittedForClearingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        submittedForClearingIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(submittedForClearingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        submittedForClearingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        submittedForClearing = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList updatedForClearingNodeList = xmlNode.SelectNodes("updatedForClearing");
            if (updatedForClearingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in updatedForClearingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        updatedForClearingIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(updatedForClearingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        updatedForClearingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        updatedForClearing = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList clearedNodeList = xmlNode.SelectNodes("cleared");
            if (clearedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(clearedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cleared = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList allocationsSubmittedNodeList = xmlNode.SelectNodes("allocationsSubmitted");
            if (allocationsSubmittedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationsSubmittedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationsSubmittedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(allocationsSubmittedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationsSubmittedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocationsSubmitted = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList allocationsUpdatedNodeList = xmlNode.SelectNodes("allocationsUpdated");
            if (allocationsUpdatedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationsUpdatedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationsUpdatedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(allocationsUpdatedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationsUpdatedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocationsUpdated = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList allocationsCompletedNodeList = xmlNode.SelectNodes("allocationsCompleted");
            if (allocationsCompletedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationsCompletedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationsCompletedIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(allocationsCompletedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationsCompletedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocationsCompleted = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList timestampNodeList = xmlNode.SelectNodes("timestamp");
            
            foreach (XmlNode item in timestampNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timestampIDRef = item.Attributes["id"].Name;
                        List<TradeTimestamp> ob = new List<TradeTimestamp>();
                        ob.Add(new TradeTimestamp(item));
                        IDManager.SetID(timestampIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timestampIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    timestamp.Add(new TradeTimestamp(item));
                    }
                }
            }
            
        
        }
        
    
        #region OrderEntered
        private XsdTypeDateTime orderEntered;
        public XsdTypeDateTime OrderEntered
        {
            get
            {
                if (this.orderEntered != null)
                {
                    return this.orderEntered; 
                }
                else if (this.orderEnteredIDRef != null)
                {
                    orderEntered = IDManager.getID(orderEnteredIDRef) as XsdTypeDateTime;
                    return this.orderEntered; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.orderEntered != value)
                {
                    this.orderEntered = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region OrderSubmitted
        private XsdTypeDateTime orderSubmitted;
        public XsdTypeDateTime OrderSubmitted
        {
            get
            {
                if (this.orderSubmitted != null)
                {
                    return this.orderSubmitted; 
                }
                else if (this.orderSubmittedIDRef != null)
                {
                    orderSubmitted = IDManager.getID(orderSubmittedIDRef) as XsdTypeDateTime;
                    return this.orderSubmitted; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.orderSubmitted != value)
                {
                    this.orderSubmitted = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region PubliclyReported
        private XsdTypeDateTime publiclyReported;
        public XsdTypeDateTime PubliclyReported
        {
            get
            {
                if (this.publiclyReported != null)
                {
                    return this.publiclyReported; 
                }
                else if (this.publiclyReportedIDRef != null)
                {
                    publiclyReported = IDManager.getID(publiclyReportedIDRef) as XsdTypeDateTime;
                    return this.publiclyReported; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publiclyReported != value)
                {
                    this.publiclyReported = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region PublicReportUpdated
        private XsdTypeDateTime publicReportUpdated;
        public XsdTypeDateTime PublicReportUpdated
        {
            get
            {
                if (this.publicReportUpdated != null)
                {
                    return this.publicReportUpdated; 
                }
                else if (this.publicReportUpdatedIDRef != null)
                {
                    publicReportUpdated = IDManager.getID(publicReportUpdatedIDRef) as XsdTypeDateTime;
                    return this.publicReportUpdated; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publicReportUpdated != value)
                {
                    this.publicReportUpdated = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region NonpubliclyReported
        private XsdTypeDateTime nonpubliclyReported;
        public XsdTypeDateTime NonpubliclyReported
        {
            get
            {
                if (this.nonpubliclyReported != null)
                {
                    return this.nonpubliclyReported; 
                }
                else if (this.nonpubliclyReportedIDRef != null)
                {
                    nonpubliclyReported = IDManager.getID(nonpubliclyReportedIDRef) as XsdTypeDateTime;
                    return this.nonpubliclyReported; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonpubliclyReported != value)
                {
                    this.nonpubliclyReported = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region NonpublicReportUpdated
        private XsdTypeDateTime nonpublicReportUpdated;
        public XsdTypeDateTime NonpublicReportUpdated
        {
            get
            {
                if (this.nonpublicReportUpdated != null)
                {
                    return this.nonpublicReportUpdated; 
                }
                else if (this.nonpublicReportUpdatedIDRef != null)
                {
                    nonpublicReportUpdated = IDManager.getID(nonpublicReportUpdatedIDRef) as XsdTypeDateTime;
                    return this.nonpublicReportUpdated; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonpublicReportUpdated != value)
                {
                    this.nonpublicReportUpdated = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region SubmittedForConfirmation
        private XsdTypeDateTime submittedForConfirmation;
        public XsdTypeDateTime SubmittedForConfirmation
        {
            get
            {
                if (this.submittedForConfirmation != null)
                {
                    return this.submittedForConfirmation; 
                }
                else if (this.submittedForConfirmationIDRef != null)
                {
                    submittedForConfirmation = IDManager.getID(submittedForConfirmationIDRef) as XsdTypeDateTime;
                    return this.submittedForConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.submittedForConfirmation != value)
                {
                    this.submittedForConfirmation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region UpdatedForConfirmation
        private XsdTypeDateTime updatedForConfirmation;
        public XsdTypeDateTime UpdatedForConfirmation
        {
            get
            {
                if (this.updatedForConfirmation != null)
                {
                    return this.updatedForConfirmation; 
                }
                else if (this.updatedForConfirmationIDRef != null)
                {
                    updatedForConfirmation = IDManager.getID(updatedForConfirmationIDRef) as XsdTypeDateTime;
                    return this.updatedForConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.updatedForConfirmation != value)
                {
                    this.updatedForConfirmation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region Confirmed
        private XsdTypeDateTime confirmed;
        public XsdTypeDateTime Confirmed
        {
            get
            {
                if (this.confirmed != null)
                {
                    return this.confirmed; 
                }
                else if (this.confirmedIDRef != null)
                {
                    confirmed = IDManager.getID(confirmedIDRef) as XsdTypeDateTime;
                    return this.confirmed; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.confirmed != value)
                {
                    this.confirmed = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region SubmittedForClearing
        private XsdTypeDateTime submittedForClearing;
        public XsdTypeDateTime SubmittedForClearing
        {
            get
            {
                if (this.submittedForClearing != null)
                {
                    return this.submittedForClearing; 
                }
                else if (this.submittedForClearingIDRef != null)
                {
                    submittedForClearing = IDManager.getID(submittedForClearingIDRef) as XsdTypeDateTime;
                    return this.submittedForClearing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.submittedForClearing != value)
                {
                    this.submittedForClearing = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region UpdatedForClearing
        private XsdTypeDateTime updatedForClearing;
        public XsdTypeDateTime UpdatedForClearing
        {
            get
            {
                if (this.updatedForClearing != null)
                {
                    return this.updatedForClearing; 
                }
                else if (this.updatedForClearingIDRef != null)
                {
                    updatedForClearing = IDManager.getID(updatedForClearingIDRef) as XsdTypeDateTime;
                    return this.updatedForClearing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.updatedForClearing != value)
                {
                    this.updatedForClearing = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region Cleared
        private XsdTypeDateTime cleared;
        public XsdTypeDateTime Cleared
        {
            get
            {
                if (this.cleared != null)
                {
                    return this.cleared; 
                }
                else if (this.clearedIDRef != null)
                {
                    cleared = IDManager.getID(clearedIDRef) as XsdTypeDateTime;
                    return this.cleared; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cleared != value)
                {
                    this.cleared = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region AllocationsSubmitted
        private XsdTypeDateTime allocationsSubmitted;
        public XsdTypeDateTime AllocationsSubmitted
        {
            get
            {
                if (this.allocationsSubmitted != null)
                {
                    return this.allocationsSubmitted; 
                }
                else if (this.allocationsSubmittedIDRef != null)
                {
                    allocationsSubmitted = IDManager.getID(allocationsSubmittedIDRef) as XsdTypeDateTime;
                    return this.allocationsSubmitted; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationsSubmitted != value)
                {
                    this.allocationsSubmitted = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region AllocationsUpdated
        private XsdTypeDateTime allocationsUpdated;
        public XsdTypeDateTime AllocationsUpdated
        {
            get
            {
                if (this.allocationsUpdated != null)
                {
                    return this.allocationsUpdated; 
                }
                else if (this.allocationsUpdatedIDRef != null)
                {
                    allocationsUpdated = IDManager.getID(allocationsUpdatedIDRef) as XsdTypeDateTime;
                    return this.allocationsUpdated; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationsUpdated != value)
                {
                    this.allocationsUpdated = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region AllocationsCompleted
        private XsdTypeDateTime allocationsCompleted;
        public XsdTypeDateTime AllocationsCompleted
        {
            get
            {
                if (this.allocationsCompleted != null)
                {
                    return this.allocationsCompleted; 
                }
                else if (this.allocationsCompletedIDRef != null)
                {
                    allocationsCompleted = IDManager.getID(allocationsCompletedIDRef) as XsdTypeDateTime;
                    return this.allocationsCompleted; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationsCompleted != value)
                {
                    this.allocationsCompleted = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region Timestamp
        private List<TradeTimestamp> timestamp;
        public List<TradeTimestamp> Timestamp
        {
            get
            {
                if (this.timestamp != null)
                {
                    return this.timestamp; 
                }
                else if (this.timestampIDRef != null)
                {
                    timestamp = IDManager.getID(timestampIDRef) as List<TradeTimestamp>;
                    return this.timestamp; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.timestamp != value)
                {
                    this.timestamp = value;
                }
            }
        }
        #endregion
        
        public string TradeTimestampIDRef { get; set; }
        
    
        
    
    }
    
}


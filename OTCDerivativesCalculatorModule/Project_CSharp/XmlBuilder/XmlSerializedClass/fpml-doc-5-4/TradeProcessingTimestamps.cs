using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeProcessingTimestamps : ISerialized
    {
        public TradeProcessingTimestamps(XmlNode xmlNode)
        {
            XmlNode orderEnteredNode = xmlNode.SelectSingleNode("orderEntered");
            
            if (orderEnteredNode != null)
            {
                if (orderEnteredNode.Attributes["href"] != null || orderEnteredNode.Attributes["id"] != null) 
                {
                    if (orderEnteredNode.Attributes["id"] != null) 
                    {
                        orderEnteredIDRef_ = orderEnteredNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(orderEnteredNode);
                        IDManager.SetID(orderEnteredIDRef_, ob);
                    }
                    else if (orderEnteredNode.Attributes["href"] != null)
                    {
                        orderEnteredIDRef_ = orderEnteredNode.Attributes["href"].Value;
                    }
                    else
                    {
                        orderEntered_ = new XsdTypeDateTime(orderEnteredNode);
                    }
                }
                else
                {
                    orderEntered_ = new XsdTypeDateTime(orderEnteredNode);
                }
            }
            
        
            XmlNode orderSubmittedNode = xmlNode.SelectSingleNode("orderSubmitted");
            
            if (orderSubmittedNode != null)
            {
                if (orderSubmittedNode.Attributes["href"] != null || orderSubmittedNode.Attributes["id"] != null) 
                {
                    if (orderSubmittedNode.Attributes["id"] != null) 
                    {
                        orderSubmittedIDRef_ = orderSubmittedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(orderSubmittedNode);
                        IDManager.SetID(orderSubmittedIDRef_, ob);
                    }
                    else if (orderSubmittedNode.Attributes["href"] != null)
                    {
                        orderSubmittedIDRef_ = orderSubmittedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        orderSubmitted_ = new XsdTypeDateTime(orderSubmittedNode);
                    }
                }
                else
                {
                    orderSubmitted_ = new XsdTypeDateTime(orderSubmittedNode);
                }
            }
            
        
            XmlNode publiclyReportedNode = xmlNode.SelectSingleNode("publiclyReported");
            
            if (publiclyReportedNode != null)
            {
                if (publiclyReportedNode.Attributes["href"] != null || publiclyReportedNode.Attributes["id"] != null) 
                {
                    if (publiclyReportedNode.Attributes["id"] != null) 
                    {
                        publiclyReportedIDRef_ = publiclyReportedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(publiclyReportedNode);
                        IDManager.SetID(publiclyReportedIDRef_, ob);
                    }
                    else if (publiclyReportedNode.Attributes["href"] != null)
                    {
                        publiclyReportedIDRef_ = publiclyReportedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        publiclyReported_ = new XsdTypeDateTime(publiclyReportedNode);
                    }
                }
                else
                {
                    publiclyReported_ = new XsdTypeDateTime(publiclyReportedNode);
                }
            }
            
        
            XmlNode publicReportUpdatedNode = xmlNode.SelectSingleNode("publicReportUpdated");
            
            if (publicReportUpdatedNode != null)
            {
                if (publicReportUpdatedNode.Attributes["href"] != null || publicReportUpdatedNode.Attributes["id"] != null) 
                {
                    if (publicReportUpdatedNode.Attributes["id"] != null) 
                    {
                        publicReportUpdatedIDRef_ = publicReportUpdatedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(publicReportUpdatedNode);
                        IDManager.SetID(publicReportUpdatedIDRef_, ob);
                    }
                    else if (publicReportUpdatedNode.Attributes["href"] != null)
                    {
                        publicReportUpdatedIDRef_ = publicReportUpdatedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        publicReportUpdated_ = new XsdTypeDateTime(publicReportUpdatedNode);
                    }
                }
                else
                {
                    publicReportUpdated_ = new XsdTypeDateTime(publicReportUpdatedNode);
                }
            }
            
        
            XmlNode nonpubliclyReportedNode = xmlNode.SelectSingleNode("nonpubliclyReported");
            
            if (nonpubliclyReportedNode != null)
            {
                if (nonpubliclyReportedNode.Attributes["href"] != null || nonpubliclyReportedNode.Attributes["id"] != null) 
                {
                    if (nonpubliclyReportedNode.Attributes["id"] != null) 
                    {
                        nonpubliclyReportedIDRef_ = nonpubliclyReportedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(nonpubliclyReportedNode);
                        IDManager.SetID(nonpubliclyReportedIDRef_, ob);
                    }
                    else if (nonpubliclyReportedNode.Attributes["href"] != null)
                    {
                        nonpubliclyReportedIDRef_ = nonpubliclyReportedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonpubliclyReported_ = new XsdTypeDateTime(nonpubliclyReportedNode);
                    }
                }
                else
                {
                    nonpubliclyReported_ = new XsdTypeDateTime(nonpubliclyReportedNode);
                }
            }
            
        
            XmlNode nonpublicReportUpdatedNode = xmlNode.SelectSingleNode("nonpublicReportUpdated");
            
            if (nonpublicReportUpdatedNode != null)
            {
                if (nonpublicReportUpdatedNode.Attributes["href"] != null || nonpublicReportUpdatedNode.Attributes["id"] != null) 
                {
                    if (nonpublicReportUpdatedNode.Attributes["id"] != null) 
                    {
                        nonpublicReportUpdatedIDRef_ = nonpublicReportUpdatedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(nonpublicReportUpdatedNode);
                        IDManager.SetID(nonpublicReportUpdatedIDRef_, ob);
                    }
                    else if (nonpublicReportUpdatedNode.Attributes["href"] != null)
                    {
                        nonpublicReportUpdatedIDRef_ = nonpublicReportUpdatedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonpublicReportUpdated_ = new XsdTypeDateTime(nonpublicReportUpdatedNode);
                    }
                }
                else
                {
                    nonpublicReportUpdated_ = new XsdTypeDateTime(nonpublicReportUpdatedNode);
                }
            }
            
        
            XmlNode submittedForConfirmationNode = xmlNode.SelectSingleNode("submittedForConfirmation");
            
            if (submittedForConfirmationNode != null)
            {
                if (submittedForConfirmationNode.Attributes["href"] != null || submittedForConfirmationNode.Attributes["id"] != null) 
                {
                    if (submittedForConfirmationNode.Attributes["id"] != null) 
                    {
                        submittedForConfirmationIDRef_ = submittedForConfirmationNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(submittedForConfirmationNode);
                        IDManager.SetID(submittedForConfirmationIDRef_, ob);
                    }
                    else if (submittedForConfirmationNode.Attributes["href"] != null)
                    {
                        submittedForConfirmationIDRef_ = submittedForConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        submittedForConfirmation_ = new XsdTypeDateTime(submittedForConfirmationNode);
                    }
                }
                else
                {
                    submittedForConfirmation_ = new XsdTypeDateTime(submittedForConfirmationNode);
                }
            }
            
        
            XmlNode updatedForConfirmationNode = xmlNode.SelectSingleNode("updatedForConfirmation");
            
            if (updatedForConfirmationNode != null)
            {
                if (updatedForConfirmationNode.Attributes["href"] != null || updatedForConfirmationNode.Attributes["id"] != null) 
                {
                    if (updatedForConfirmationNode.Attributes["id"] != null) 
                    {
                        updatedForConfirmationIDRef_ = updatedForConfirmationNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(updatedForConfirmationNode);
                        IDManager.SetID(updatedForConfirmationIDRef_, ob);
                    }
                    else if (updatedForConfirmationNode.Attributes["href"] != null)
                    {
                        updatedForConfirmationIDRef_ = updatedForConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        updatedForConfirmation_ = new XsdTypeDateTime(updatedForConfirmationNode);
                    }
                }
                else
                {
                    updatedForConfirmation_ = new XsdTypeDateTime(updatedForConfirmationNode);
                }
            }
            
        
            XmlNode confirmedNode = xmlNode.SelectSingleNode("confirmed");
            
            if (confirmedNode != null)
            {
                if (confirmedNode.Attributes["href"] != null || confirmedNode.Attributes["id"] != null) 
                {
                    if (confirmedNode.Attributes["id"] != null) 
                    {
                        confirmedIDRef_ = confirmedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(confirmedNode);
                        IDManager.SetID(confirmedIDRef_, ob);
                    }
                    else if (confirmedNode.Attributes["href"] != null)
                    {
                        confirmedIDRef_ = confirmedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        confirmed_ = new XsdTypeDateTime(confirmedNode);
                    }
                }
                else
                {
                    confirmed_ = new XsdTypeDateTime(confirmedNode);
                }
            }
            
        
            XmlNode submittedForClearingNode = xmlNode.SelectSingleNode("submittedForClearing");
            
            if (submittedForClearingNode != null)
            {
                if (submittedForClearingNode.Attributes["href"] != null || submittedForClearingNode.Attributes["id"] != null) 
                {
                    if (submittedForClearingNode.Attributes["id"] != null) 
                    {
                        submittedForClearingIDRef_ = submittedForClearingNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(submittedForClearingNode);
                        IDManager.SetID(submittedForClearingIDRef_, ob);
                    }
                    else if (submittedForClearingNode.Attributes["href"] != null)
                    {
                        submittedForClearingIDRef_ = submittedForClearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        submittedForClearing_ = new XsdTypeDateTime(submittedForClearingNode);
                    }
                }
                else
                {
                    submittedForClearing_ = new XsdTypeDateTime(submittedForClearingNode);
                }
            }
            
        
            XmlNode updatedForClearingNode = xmlNode.SelectSingleNode("updatedForClearing");
            
            if (updatedForClearingNode != null)
            {
                if (updatedForClearingNode.Attributes["href"] != null || updatedForClearingNode.Attributes["id"] != null) 
                {
                    if (updatedForClearingNode.Attributes["id"] != null) 
                    {
                        updatedForClearingIDRef_ = updatedForClearingNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(updatedForClearingNode);
                        IDManager.SetID(updatedForClearingIDRef_, ob);
                    }
                    else if (updatedForClearingNode.Attributes["href"] != null)
                    {
                        updatedForClearingIDRef_ = updatedForClearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        updatedForClearing_ = new XsdTypeDateTime(updatedForClearingNode);
                    }
                }
                else
                {
                    updatedForClearing_ = new XsdTypeDateTime(updatedForClearingNode);
                }
            }
            
        
            XmlNode clearedNode = xmlNode.SelectSingleNode("cleared");
            
            if (clearedNode != null)
            {
                if (clearedNode.Attributes["href"] != null || clearedNode.Attributes["id"] != null) 
                {
                    if (clearedNode.Attributes["id"] != null) 
                    {
                        clearedIDRef_ = clearedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(clearedNode);
                        IDManager.SetID(clearedIDRef_, ob);
                    }
                    else if (clearedNode.Attributes["href"] != null)
                    {
                        clearedIDRef_ = clearedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cleared_ = new XsdTypeDateTime(clearedNode);
                    }
                }
                else
                {
                    cleared_ = new XsdTypeDateTime(clearedNode);
                }
            }
            
        
            XmlNode allocationsSubmittedNode = xmlNode.SelectSingleNode("allocationsSubmitted");
            
            if (allocationsSubmittedNode != null)
            {
                if (allocationsSubmittedNode.Attributes["href"] != null || allocationsSubmittedNode.Attributes["id"] != null) 
                {
                    if (allocationsSubmittedNode.Attributes["id"] != null) 
                    {
                        allocationsSubmittedIDRef_ = allocationsSubmittedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(allocationsSubmittedNode);
                        IDManager.SetID(allocationsSubmittedIDRef_, ob);
                    }
                    else if (allocationsSubmittedNode.Attributes["href"] != null)
                    {
                        allocationsSubmittedIDRef_ = allocationsSubmittedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocationsSubmitted_ = new XsdTypeDateTime(allocationsSubmittedNode);
                    }
                }
                else
                {
                    allocationsSubmitted_ = new XsdTypeDateTime(allocationsSubmittedNode);
                }
            }
            
        
            XmlNode allocationsUpdatedNode = xmlNode.SelectSingleNode("allocationsUpdated");
            
            if (allocationsUpdatedNode != null)
            {
                if (allocationsUpdatedNode.Attributes["href"] != null || allocationsUpdatedNode.Attributes["id"] != null) 
                {
                    if (allocationsUpdatedNode.Attributes["id"] != null) 
                    {
                        allocationsUpdatedIDRef_ = allocationsUpdatedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(allocationsUpdatedNode);
                        IDManager.SetID(allocationsUpdatedIDRef_, ob);
                    }
                    else if (allocationsUpdatedNode.Attributes["href"] != null)
                    {
                        allocationsUpdatedIDRef_ = allocationsUpdatedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocationsUpdated_ = new XsdTypeDateTime(allocationsUpdatedNode);
                    }
                }
                else
                {
                    allocationsUpdated_ = new XsdTypeDateTime(allocationsUpdatedNode);
                }
            }
            
        
            XmlNode allocationsCompletedNode = xmlNode.SelectSingleNode("allocationsCompleted");
            
            if (allocationsCompletedNode != null)
            {
                if (allocationsCompletedNode.Attributes["href"] != null || allocationsCompletedNode.Attributes["id"] != null) 
                {
                    if (allocationsCompletedNode.Attributes["id"] != null) 
                    {
                        allocationsCompletedIDRef_ = allocationsCompletedNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(allocationsCompletedNode);
                        IDManager.SetID(allocationsCompletedIDRef_, ob);
                    }
                    else if (allocationsCompletedNode.Attributes["href"] != null)
                    {
                        allocationsCompletedIDRef_ = allocationsCompletedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocationsCompleted_ = new XsdTypeDateTime(allocationsCompletedNode);
                    }
                }
                else
                {
                    allocationsCompleted_ = new XsdTypeDateTime(allocationsCompletedNode);
                }
            }
            
        
            XmlNodeList timestampNodeList = xmlNode.SelectNodes("timestamp");
            
            if (timestampNodeList != null)
            {
                this.timestamp_ = new List<TradeTimestamp>();
                foreach (XmlNode item in timestampNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            timestampIDRef_ = item.Attributes["id"].Value;
                            timestamp_.Add(new TradeTimestamp(item));
                            IDManager.SetID(timestampIDRef_, timestamp_[timestamp_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            timestampIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        timestamp_.Add(new TradeTimestamp(item));
                        }
                    }
                    else
                    {
                        timestamp_.Add(new TradeTimestamp(item));
                    }
                }
            }
            
        
        }
        
    
        #region OrderEntered_
        private XsdTypeDateTime orderEntered_;
        public XsdTypeDateTime OrderEntered_
        {
            get
            {
                if (this.orderEntered_ != null)
                {
                    return this.orderEntered_; 
                }
                else if (this.orderEnteredIDRef_ != null)
                {
                    orderEntered_ = IDManager.getID(orderEnteredIDRef_) as XsdTypeDateTime;
                    return this.orderEntered_; 
                }
                else
                {
                      return this.orderEntered_; 
                }
            }
            set
            {
                if (this.orderEntered_ != value)
                {
                    this.orderEntered_ = value;
                }
            }
        }
        #endregion
        
        public string orderEnteredIDRef_ { get; set; }
        #region OrderSubmitted_
        private XsdTypeDateTime orderSubmitted_;
        public XsdTypeDateTime OrderSubmitted_
        {
            get
            {
                if (this.orderSubmitted_ != null)
                {
                    return this.orderSubmitted_; 
                }
                else if (this.orderSubmittedIDRef_ != null)
                {
                    orderSubmitted_ = IDManager.getID(orderSubmittedIDRef_) as XsdTypeDateTime;
                    return this.orderSubmitted_; 
                }
                else
                {
                      return this.orderSubmitted_; 
                }
            }
            set
            {
                if (this.orderSubmitted_ != value)
                {
                    this.orderSubmitted_ = value;
                }
            }
        }
        #endregion
        
        public string orderSubmittedIDRef_ { get; set; }
        #region PubliclyReported_
        private XsdTypeDateTime publiclyReported_;
        public XsdTypeDateTime PubliclyReported_
        {
            get
            {
                if (this.publiclyReported_ != null)
                {
                    return this.publiclyReported_; 
                }
                else if (this.publiclyReportedIDRef_ != null)
                {
                    publiclyReported_ = IDManager.getID(publiclyReportedIDRef_) as XsdTypeDateTime;
                    return this.publiclyReported_; 
                }
                else
                {
                      return this.publiclyReported_; 
                }
            }
            set
            {
                if (this.publiclyReported_ != value)
                {
                    this.publiclyReported_ = value;
                }
            }
        }
        #endregion
        
        public string publiclyReportedIDRef_ { get; set; }
        #region PublicReportUpdated_
        private XsdTypeDateTime publicReportUpdated_;
        public XsdTypeDateTime PublicReportUpdated_
        {
            get
            {
                if (this.publicReportUpdated_ != null)
                {
                    return this.publicReportUpdated_; 
                }
                else if (this.publicReportUpdatedIDRef_ != null)
                {
                    publicReportUpdated_ = IDManager.getID(publicReportUpdatedIDRef_) as XsdTypeDateTime;
                    return this.publicReportUpdated_; 
                }
                else
                {
                      return this.publicReportUpdated_; 
                }
            }
            set
            {
                if (this.publicReportUpdated_ != value)
                {
                    this.publicReportUpdated_ = value;
                }
            }
        }
        #endregion
        
        public string publicReportUpdatedIDRef_ { get; set; }
        #region NonpubliclyReported_
        private XsdTypeDateTime nonpubliclyReported_;
        public XsdTypeDateTime NonpubliclyReported_
        {
            get
            {
                if (this.nonpubliclyReported_ != null)
                {
                    return this.nonpubliclyReported_; 
                }
                else if (this.nonpubliclyReportedIDRef_ != null)
                {
                    nonpubliclyReported_ = IDManager.getID(nonpubliclyReportedIDRef_) as XsdTypeDateTime;
                    return this.nonpubliclyReported_; 
                }
                else
                {
                      return this.nonpubliclyReported_; 
                }
            }
            set
            {
                if (this.nonpubliclyReported_ != value)
                {
                    this.nonpubliclyReported_ = value;
                }
            }
        }
        #endregion
        
        public string nonpubliclyReportedIDRef_ { get; set; }
        #region NonpublicReportUpdated_
        private XsdTypeDateTime nonpublicReportUpdated_;
        public XsdTypeDateTime NonpublicReportUpdated_
        {
            get
            {
                if (this.nonpublicReportUpdated_ != null)
                {
                    return this.nonpublicReportUpdated_; 
                }
                else if (this.nonpublicReportUpdatedIDRef_ != null)
                {
                    nonpublicReportUpdated_ = IDManager.getID(nonpublicReportUpdatedIDRef_) as XsdTypeDateTime;
                    return this.nonpublicReportUpdated_; 
                }
                else
                {
                      return this.nonpublicReportUpdated_; 
                }
            }
            set
            {
                if (this.nonpublicReportUpdated_ != value)
                {
                    this.nonpublicReportUpdated_ = value;
                }
            }
        }
        #endregion
        
        public string nonpublicReportUpdatedIDRef_ { get; set; }
        #region SubmittedForConfirmation_
        private XsdTypeDateTime submittedForConfirmation_;
        public XsdTypeDateTime SubmittedForConfirmation_
        {
            get
            {
                if (this.submittedForConfirmation_ != null)
                {
                    return this.submittedForConfirmation_; 
                }
                else if (this.submittedForConfirmationIDRef_ != null)
                {
                    submittedForConfirmation_ = IDManager.getID(submittedForConfirmationIDRef_) as XsdTypeDateTime;
                    return this.submittedForConfirmation_; 
                }
                else
                {
                      return this.submittedForConfirmation_; 
                }
            }
            set
            {
                if (this.submittedForConfirmation_ != value)
                {
                    this.submittedForConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string submittedForConfirmationIDRef_ { get; set; }
        #region UpdatedForConfirmation_
        private XsdTypeDateTime updatedForConfirmation_;
        public XsdTypeDateTime UpdatedForConfirmation_
        {
            get
            {
                if (this.updatedForConfirmation_ != null)
                {
                    return this.updatedForConfirmation_; 
                }
                else if (this.updatedForConfirmationIDRef_ != null)
                {
                    updatedForConfirmation_ = IDManager.getID(updatedForConfirmationIDRef_) as XsdTypeDateTime;
                    return this.updatedForConfirmation_; 
                }
                else
                {
                      return this.updatedForConfirmation_; 
                }
            }
            set
            {
                if (this.updatedForConfirmation_ != value)
                {
                    this.updatedForConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string updatedForConfirmationIDRef_ { get; set; }
        #region Confirmed_
        private XsdTypeDateTime confirmed_;
        public XsdTypeDateTime Confirmed_
        {
            get
            {
                if (this.confirmed_ != null)
                {
                    return this.confirmed_; 
                }
                else if (this.confirmedIDRef_ != null)
                {
                    confirmed_ = IDManager.getID(confirmedIDRef_) as XsdTypeDateTime;
                    return this.confirmed_; 
                }
                else
                {
                      return this.confirmed_; 
                }
            }
            set
            {
                if (this.confirmed_ != value)
                {
                    this.confirmed_ = value;
                }
            }
        }
        #endregion
        
        public string confirmedIDRef_ { get; set; }
        #region SubmittedForClearing_
        private XsdTypeDateTime submittedForClearing_;
        public XsdTypeDateTime SubmittedForClearing_
        {
            get
            {
                if (this.submittedForClearing_ != null)
                {
                    return this.submittedForClearing_; 
                }
                else if (this.submittedForClearingIDRef_ != null)
                {
                    submittedForClearing_ = IDManager.getID(submittedForClearingIDRef_) as XsdTypeDateTime;
                    return this.submittedForClearing_; 
                }
                else
                {
                      return this.submittedForClearing_; 
                }
            }
            set
            {
                if (this.submittedForClearing_ != value)
                {
                    this.submittedForClearing_ = value;
                }
            }
        }
        #endregion
        
        public string submittedForClearingIDRef_ { get; set; }
        #region UpdatedForClearing_
        private XsdTypeDateTime updatedForClearing_;
        public XsdTypeDateTime UpdatedForClearing_
        {
            get
            {
                if (this.updatedForClearing_ != null)
                {
                    return this.updatedForClearing_; 
                }
                else if (this.updatedForClearingIDRef_ != null)
                {
                    updatedForClearing_ = IDManager.getID(updatedForClearingIDRef_) as XsdTypeDateTime;
                    return this.updatedForClearing_; 
                }
                else
                {
                      return this.updatedForClearing_; 
                }
            }
            set
            {
                if (this.updatedForClearing_ != value)
                {
                    this.updatedForClearing_ = value;
                }
            }
        }
        #endregion
        
        public string updatedForClearingIDRef_ { get; set; }
        #region Cleared_
        private XsdTypeDateTime cleared_;
        public XsdTypeDateTime Cleared_
        {
            get
            {
                if (this.cleared_ != null)
                {
                    return this.cleared_; 
                }
                else if (this.clearedIDRef_ != null)
                {
                    cleared_ = IDManager.getID(clearedIDRef_) as XsdTypeDateTime;
                    return this.cleared_; 
                }
                else
                {
                      return this.cleared_; 
                }
            }
            set
            {
                if (this.cleared_ != value)
                {
                    this.cleared_ = value;
                }
            }
        }
        #endregion
        
        public string clearedIDRef_ { get; set; }
        #region AllocationsSubmitted_
        private XsdTypeDateTime allocationsSubmitted_;
        public XsdTypeDateTime AllocationsSubmitted_
        {
            get
            {
                if (this.allocationsSubmitted_ != null)
                {
                    return this.allocationsSubmitted_; 
                }
                else if (this.allocationsSubmittedIDRef_ != null)
                {
                    allocationsSubmitted_ = IDManager.getID(allocationsSubmittedIDRef_) as XsdTypeDateTime;
                    return this.allocationsSubmitted_; 
                }
                else
                {
                      return this.allocationsSubmitted_; 
                }
            }
            set
            {
                if (this.allocationsSubmitted_ != value)
                {
                    this.allocationsSubmitted_ = value;
                }
            }
        }
        #endregion
        
        public string allocationsSubmittedIDRef_ { get; set; }
        #region AllocationsUpdated_
        private XsdTypeDateTime allocationsUpdated_;
        public XsdTypeDateTime AllocationsUpdated_
        {
            get
            {
                if (this.allocationsUpdated_ != null)
                {
                    return this.allocationsUpdated_; 
                }
                else if (this.allocationsUpdatedIDRef_ != null)
                {
                    allocationsUpdated_ = IDManager.getID(allocationsUpdatedIDRef_) as XsdTypeDateTime;
                    return this.allocationsUpdated_; 
                }
                else
                {
                      return this.allocationsUpdated_; 
                }
            }
            set
            {
                if (this.allocationsUpdated_ != value)
                {
                    this.allocationsUpdated_ = value;
                }
            }
        }
        #endregion
        
        public string allocationsUpdatedIDRef_ { get; set; }
        #region AllocationsCompleted_
        private XsdTypeDateTime allocationsCompleted_;
        public XsdTypeDateTime AllocationsCompleted_
        {
            get
            {
                if (this.allocationsCompleted_ != null)
                {
                    return this.allocationsCompleted_; 
                }
                else if (this.allocationsCompletedIDRef_ != null)
                {
                    allocationsCompleted_ = IDManager.getID(allocationsCompletedIDRef_) as XsdTypeDateTime;
                    return this.allocationsCompleted_; 
                }
                else
                {
                      return this.allocationsCompleted_; 
                }
            }
            set
            {
                if (this.allocationsCompleted_ != value)
                {
                    this.allocationsCompleted_ = value;
                }
            }
        }
        #endregion
        
        public string allocationsCompletedIDRef_ { get; set; }
        #region Timestamp_
        private List<TradeTimestamp> timestamp_;
        public List<TradeTimestamp> Timestamp_
        {
            get
            {
                if (this.timestamp_ != null)
                {
                    return this.timestamp_; 
                }
                else if (this.timestampIDRef_ != null)
                {
                    return this.timestamp_; 
                }
                else
                {
                      return this.timestamp_; 
                }
            }
            set
            {
                if (this.timestamp_ != value)
                {
                    this.timestamp_ = value;
                }
            }
        }
        #endregion
        
        public string timestampIDRef_ { get; set; }
        
    
        
    
    }
    
}


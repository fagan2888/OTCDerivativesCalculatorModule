using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PortfolioReference : PortfolioReferenceBase
    {
        public PortfolioReference(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode sequenceNumberNode = xmlNode.SelectSingleNode("sequenceNumber");
            
            if (sequenceNumberNode != null)
            {
                if (sequenceNumberNode.Attributes["href"] != null || sequenceNumberNode.Attributes["id"] != null) 
                {
                    if (sequenceNumberNode.Attributes["id"] != null) 
                    {
                        sequenceNumberIDRef_ = sequenceNumberNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(sequenceNumberNode);
                        IDManager.SetID(sequenceNumberIDRef_, ob);
                    }
                    else if (sequenceNumberNode.Attributes["href"] != null)
                    {
                        sequenceNumberIDRef_ = sequenceNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sequenceNumber_ = new XsdTypePositiveInteger(sequenceNumberNode);
                    }
                }
                else
                {
                    sequenceNumber_ = new XsdTypePositiveInteger(sequenceNumberNode);
                }
            }
            
        
            XmlNode submissionsCompleteNode = xmlNode.SelectSingleNode("submissionsComplete");
            
            if (submissionsCompleteNode != null)
            {
                if (submissionsCompleteNode.Attributes["href"] != null || submissionsCompleteNode.Attributes["id"] != null) 
                {
                    if (submissionsCompleteNode.Attributes["id"] != null) 
                    {
                        submissionsCompleteIDRef_ = submissionsCompleteNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(submissionsCompleteNode);
                        IDManager.SetID(submissionsCompleteIDRef_, ob);
                    }
                    else if (submissionsCompleteNode.Attributes["href"] != null)
                    {
                        submissionsCompleteIDRef_ = submissionsCompleteNode.Attributes["href"].Value;
                    }
                    else
                    {
                        submissionsComplete_ = new XsdTypeBoolean(submissionsCompleteNode);
                    }
                }
                else
                {
                    submissionsComplete_ = new XsdTypeBoolean(submissionsCompleteNode);
                }
            }
            
        
        }
        
    
        #region SequenceNumber_
        private XsdTypePositiveInteger sequenceNumber_;
        public XsdTypePositiveInteger SequenceNumber_
        {
            get
            {
                if (this.sequenceNumber_ != null)
                {
                    return this.sequenceNumber_; 
                }
                else if (this.sequenceNumberIDRef_ != null)
                {
                    sequenceNumber_ = IDManager.getID(sequenceNumberIDRef_) as XsdTypePositiveInteger;
                    return this.sequenceNumber_; 
                }
                else
                {
                      return this.sequenceNumber_; 
                }
            }
            set
            {
                if (this.sequenceNumber_ != value)
                {
                    this.sequenceNumber_ = value;
                }
            }
        }
        #endregion
        
        public string sequenceNumberIDRef_ { get; set; }
        #region SubmissionsComplete_
        private XsdTypeBoolean submissionsComplete_;
        public XsdTypeBoolean SubmissionsComplete_
        {
            get
            {
                if (this.submissionsComplete_ != null)
                {
                    return this.submissionsComplete_; 
                }
                else if (this.submissionsCompleteIDRef_ != null)
                {
                    submissionsComplete_ = IDManager.getID(submissionsCompleteIDRef_) as XsdTypeBoolean;
                    return this.submissionsComplete_; 
                }
                else
                {
                      return this.submissionsComplete_; 
                }
            }
            set
            {
                if (this.submissionsComplete_ != value)
                {
                    this.submissionsComplete_ = value;
                }
            }
        }
        #endregion
        
        public string submissionsCompleteIDRef_ { get; set; }
        
    
        
    
    }
    
}


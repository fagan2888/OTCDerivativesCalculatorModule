using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Exception : Message
    {
        public Exception(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode headerNode = xmlNode.SelectSingleNode("header");
            
            if (headerNode != null)
            {
                if (headerNode.Attributes["href"] != null || headerNode.Attributes["id"] != null) 
                {
                    if (headerNode.Attributes["id"] != null) 
                    {
                        headerIDRef_ = headerNode.Attributes["id"].Value;
                        ExceptionMessageHeader ob = new ExceptionMessageHeader(headerNode);
                        IDManager.SetID(headerIDRef_, ob);
                    }
                    else if (headerNode.Attributes["href"] != null)
                    {
                        headerIDRef_ = headerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        header_ = new ExceptionMessageHeader(headerNode);
                    }
                }
                else
                {
                    header_ = new ExceptionMessageHeader(headerNode);
                }
            }
            
        
            XmlNodeList validationNodeList = xmlNode.SelectNodes("validation");
            
            if (validationNodeList != null)
            {
                this.validation_ = new List<Validation>();
                foreach (XmlNode item in validationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            validationIDRef_ = item.Attributes["id"].Value;
                            validation_.Add(new Validation(item));
                            IDManager.SetID(validationIDRef_, validation_[validation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            validationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        validation_.Add(new Validation(item));
                        }
                    }
                    else
                    {
                        validation_.Add(new Validation(item));
                    }
                }
            }
            
        
            XmlNode parentCorrelationIdNode = xmlNode.SelectSingleNode("parentCorrelationId");
            
            if (parentCorrelationIdNode != null)
            {
                if (parentCorrelationIdNode.Attributes["href"] != null || parentCorrelationIdNode.Attributes["id"] != null) 
                {
                    if (parentCorrelationIdNode.Attributes["id"] != null) 
                    {
                        parentCorrelationIdIDRef_ = parentCorrelationIdNode.Attributes["id"].Value;
                        CorrelationId ob = new CorrelationId(parentCorrelationIdNode);
                        IDManager.SetID(parentCorrelationIdIDRef_, ob);
                    }
                    else if (parentCorrelationIdNode.Attributes["href"] != null)
                    {
                        parentCorrelationIdIDRef_ = parentCorrelationIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parentCorrelationId_ = new CorrelationId(parentCorrelationIdNode);
                    }
                }
                else
                {
                    parentCorrelationId_ = new CorrelationId(parentCorrelationIdNode);
                }
            }
            
        
            XmlNode correlationIdNode = xmlNode.SelectSingleNode("correlationId");
            
            if (correlationIdNode != null)
            {
                if (correlationIdNode.Attributes["href"] != null || correlationIdNode.Attributes["id"] != null) 
                {
                    if (correlationIdNode.Attributes["id"] != null) 
                    {
                        correlationIdIDRef_ = correlationIdNode.Attributes["id"].Value;
                        CorrelationId ob = new CorrelationId(correlationIdNode);
                        IDManager.SetID(correlationIdIDRef_, ob);
                    }
                    else if (correlationIdNode.Attributes["href"] != null)
                    {
                        correlationIdIDRef_ = correlationIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationId_ = new CorrelationId(correlationIdNode);
                    }
                }
                else
                {
                    correlationId_ = new CorrelationId(correlationIdNode);
                }
            }
            
        
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
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            if (reasonNodeList != null)
            {
                this.reason_ = new List<Reason>();
                foreach (XmlNode item in reasonNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            reasonIDRef_ = item.Attributes["id"].Value;
                            reason_.Add(new Reason(item));
                            IDManager.SetID(reasonIDRef_, reason_[reason_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            reasonIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        reason_.Add(new Reason(item));
                        }
                    }
                    else
                    {
                        reason_.Add(new Reason(item));
                    }
                }
            }
            
        
            XmlNode additionalDataNode = xmlNode.SelectSingleNode("additionalData");
            
            if (additionalDataNode != null)
            {
                if (additionalDataNode.Attributes["href"] != null || additionalDataNode.Attributes["id"] != null) 
                {
                    if (additionalDataNode.Attributes["id"] != null) 
                    {
                        additionalDataIDRef_ = additionalDataNode.Attributes["id"].Value;
                        AdditionalData ob = new AdditionalData(additionalDataNode);
                        IDManager.SetID(additionalDataIDRef_, ob);
                    }
                    else if (additionalDataNode.Attributes["href"] != null)
                    {
                        additionalDataIDRef_ = additionalDataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalData_ = new AdditionalData(additionalDataNode);
                    }
                }
                else
                {
                    additionalData_ = new AdditionalData(additionalDataNode);
                }
            }
            
        
        }
        
    
        #region Header_
        private ExceptionMessageHeader header_;
        public ExceptionMessageHeader Header_
        {
            get
            {
                if (this.header_ != null)
                {
                    return this.header_; 
                }
                else if (this.headerIDRef_ != null)
                {
                    header_ = IDManager.getID(headerIDRef_) as ExceptionMessageHeader;
                    return this.header_; 
                }
                else
                {
                      return this.header_; 
                }
            }
            set
            {
                if (this.header_ != value)
                {
                    this.header_ = value;
                }
            }
        }
        #endregion
        
        public string headerIDRef_ { get; set; }
        #region Validation_
        private List<Validation> validation_;
        public List<Validation> Validation_
        {
            get
            {
                if (this.validation_ != null)
                {
                    return this.validation_; 
                }
                else if (this.validationIDRef_ != null)
                {
                    return this.validation_; 
                }
                else
                {
                      return this.validation_; 
                }
            }
            set
            {
                if (this.validation_ != value)
                {
                    this.validation_ = value;
                }
            }
        }
        #endregion
        
        public string validationIDRef_ { get; set; }
        #region ParentCorrelationId_
        private CorrelationId parentCorrelationId_;
        public CorrelationId ParentCorrelationId_
        {
            get
            {
                if (this.parentCorrelationId_ != null)
                {
                    return this.parentCorrelationId_; 
                }
                else if (this.parentCorrelationIdIDRef_ != null)
                {
                    parentCorrelationId_ = IDManager.getID(parentCorrelationIdIDRef_) as CorrelationId;
                    return this.parentCorrelationId_; 
                }
                else
                {
                      return this.parentCorrelationId_; 
                }
            }
            set
            {
                if (this.parentCorrelationId_ != value)
                {
                    this.parentCorrelationId_ = value;
                }
            }
        }
        #endregion
        
        public string parentCorrelationIdIDRef_ { get; set; }
        #region CorrelationId_
        private CorrelationId correlationId_;
        public CorrelationId CorrelationId_
        {
            get
            {
                if (this.correlationId_ != null)
                {
                    return this.correlationId_; 
                }
                else if (this.correlationIdIDRef_ != null)
                {
                    correlationId_ = IDManager.getID(correlationIdIDRef_) as CorrelationId;
                    return this.correlationId_; 
                }
                else
                {
                      return this.correlationId_; 
                }
            }
            set
            {
                if (this.correlationId_ != value)
                {
                    this.correlationId_ = value;
                }
            }
        }
        #endregion
        
        public string correlationIdIDRef_ { get; set; }
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
        #region Reason_
        private List<Reason> reason_;
        public List<Reason> Reason_
        {
            get
            {
                if (this.reason_ != null)
                {
                    return this.reason_; 
                }
                else if (this.reasonIDRef_ != null)
                {
                    return this.reason_; 
                }
                else
                {
                      return this.reason_; 
                }
            }
            set
            {
                if (this.reason_ != value)
                {
                    this.reason_ = value;
                }
            }
        }
        #endregion
        
        public string reasonIDRef_ { get; set; }
        #region AdditionalData_
        private AdditionalData additionalData_;
        public AdditionalData AdditionalData_
        {
            get
            {
                if (this.additionalData_ != null)
                {
                    return this.additionalData_; 
                }
                else if (this.additionalDataIDRef_ != null)
                {
                    additionalData_ = IDManager.getID(additionalDataIDRef_) as AdditionalData;
                    return this.additionalData_; 
                }
                else
                {
                      return this.additionalData_; 
                }
            }
            set
            {
                if (this.additionalData_ != value)
                {
                    this.additionalData_ = value;
                }
            }
        }
        #endregion
        
        public string additionalDataIDRef_ { get; set; }
        
    
        
    
    }
    
}


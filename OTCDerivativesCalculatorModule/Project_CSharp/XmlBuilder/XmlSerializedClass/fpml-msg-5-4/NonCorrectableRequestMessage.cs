using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NonCorrectableRequestMessage : RequestMessage
    {
        public NonCorrectableRequestMessage(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode onBehalfOfNode = xmlNode.SelectSingleNode("onBehalfOf");
            
            if (onBehalfOfNode != null)
            {
                if (onBehalfOfNode.Attributes["href"] != null || onBehalfOfNode.Attributes["id"] != null) 
                {
                    if (onBehalfOfNode.Attributes["id"] != null) 
                    {
                        onBehalfOfIDRef_ = onBehalfOfNode.Attributes["id"].Value;
                        OnBehalfOf ob = new OnBehalfOf(onBehalfOfNode);
                        IDManager.SetID(onBehalfOfIDRef_, ob);
                    }
                    else if (onBehalfOfNode.Attributes["href"] != null)
                    {
                        onBehalfOfIDRef_ = onBehalfOfNode.Attributes["href"].Value;
                    }
                    else
                    {
                        onBehalfOf_ = new OnBehalfOf(onBehalfOfNode);
                    }
                }
                else
                {
                    onBehalfOf_ = new OnBehalfOf(onBehalfOfNode);
                }
            }
            
        
        }
        
    
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
        #region OnBehalfOf_
        private OnBehalfOf onBehalfOf_;
        public OnBehalfOf OnBehalfOf_
        {
            get
            {
                if (this.onBehalfOf_ != null)
                {
                    return this.onBehalfOf_; 
                }
                else if (this.onBehalfOfIDRef_ != null)
                {
                    onBehalfOf_ = IDManager.getID(onBehalfOfIDRef_) as OnBehalfOf;
                    return this.onBehalfOf_; 
                }
                else
                {
                      return this.onBehalfOf_; 
                }
            }
            set
            {
                if (this.onBehalfOf_ != value)
                {
                    this.onBehalfOf_ = value;
                }
            }
        }
        #endregion
        
        public string onBehalfOfIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CorrectableRequestMessage
    {
        public CorrectableRequestMessage(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList isCorrectionNodeList = xmlNode.SelectNodes("isCorrection");
            if (isCorrectionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in isCorrectionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        isCorrectionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(isCorrectionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        isCorrectionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        isCorrection = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList parentCorrelationIdNodeList = xmlNode.SelectNodes("parentCorrelationId");
            if (parentCorrelationIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parentCorrelationIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parentCorrelationIdIDRef = item.Attributes["id"].Name;
                        CorrelationId ob = CorrelationId();
                        IDManager.SetID(parentCorrelationIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parentCorrelationIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parentCorrelationId = new CorrelationId(item);
                    }
                }
            }
            
        
            XmlNodeList correlationIdNodeList = xmlNode.SelectNodes("correlationId");
            if (correlationIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correlationIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correlationIdIDRef = item.Attributes["id"].Name;
                        CorrelationId ob = CorrelationId();
                        IDManager.SetID(correlationIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correlationIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correlationId = new CorrelationId(item);
                    }
                }
            }
            
        
            XmlNodeList sequenceNumberNodeList = xmlNode.SelectNodes("sequenceNumber");
            if (sequenceNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sequenceNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sequenceNumberIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(sequenceNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sequenceNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sequenceNumber = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList onBehalfOfNodeList = xmlNode.SelectNodes("onBehalfOf");
            if (onBehalfOfNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in onBehalfOfNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        onBehalfOfIDRef = item.Attributes["id"].Name;
                        OnBehalfOf ob = OnBehalfOf();
                        IDManager.SetID(onBehalfOfIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        onBehalfOfIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        onBehalfOf = new OnBehalfOf(item);
                    }
                }
            }
            
        
        }
        
    
        #region IsCorrection
        private XsdTypeBoolean isCorrection;
        public XsdTypeBoolean IsCorrection
        {
            get
            {
                if (this.isCorrection != null)
                {
                    return this.isCorrection; 
                }
                else if (this.isCorrectionIDRef != null)
                {
                    isCorrection = IDManager.getID(isCorrectionIDRef) as XsdTypeBoolean;
                    return this.isCorrection; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.isCorrection != value)
                {
                    this.isCorrection = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ParentCorrelationId
        private CorrelationId parentCorrelationId;
        public CorrelationId ParentCorrelationId
        {
            get
            {
                if (this.parentCorrelationId != null)
                {
                    return this.parentCorrelationId; 
                }
                else if (this.parentCorrelationIdIDRef != null)
                {
                    parentCorrelationId = IDManager.getID(parentCorrelationIdIDRef) as CorrelationId;
                    return this.parentCorrelationId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parentCorrelationId != value)
                {
                    this.parentCorrelationId = value;
                }
            }
        }
        #endregion
        
        public string CorrelationIdIDRef { get; set; }
        #region CorrelationId
        private CorrelationId correlationId;
        public CorrelationId CorrelationId
        {
            get
            {
                if (this.correlationId != null)
                {
                    return this.correlationId; 
                }
                else if (this.correlationIdIDRef != null)
                {
                    correlationId = IDManager.getID(correlationIdIDRef) as CorrelationId;
                    return this.correlationId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correlationId != value)
                {
                    this.correlationId = value;
                }
            }
        }
        #endregion
        
        public string CorrelationIdIDRef { get; set; }
        #region SequenceNumber
        private XsdTypePositiveInteger sequenceNumber;
        public XsdTypePositiveInteger SequenceNumber
        {
            get
            {
                if (this.sequenceNumber != null)
                {
                    return this.sequenceNumber; 
                }
                else if (this.sequenceNumberIDRef != null)
                {
                    sequenceNumber = IDManager.getID(sequenceNumberIDRef) as XsdTypePositiveInteger;
                    return this.sequenceNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sequenceNumber != value)
                {
                    this.sequenceNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region OnBehalfOf
        private OnBehalfOf onBehalfOf;
        public OnBehalfOf OnBehalfOf
        {
            get
            {
                if (this.onBehalfOf != null)
                {
                    return this.onBehalfOf; 
                }
                else if (this.onBehalfOfIDRef != null)
                {
                    onBehalfOf = IDManager.getID(onBehalfOfIDRef) as OnBehalfOf;
                    return this.onBehalfOf; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.onBehalfOf != value)
                {
                    this.onBehalfOf = value;
                }
            }
        }
        #endregion
        
        public string OnBehalfOfIDRef { get; set; }
        
    
        
    
    }
    
}


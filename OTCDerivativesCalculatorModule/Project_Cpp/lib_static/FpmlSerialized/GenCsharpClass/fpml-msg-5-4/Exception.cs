using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Exception
    {
        public Exception(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList headerNodeList = xmlNode.SelectNodes("header");
            if (headerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in headerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        headerIDRef = item.Attributes["id"].Name;
                        ExceptionMessageHeader ob = ExceptionMessageHeader();
                        IDManager.SetID(headerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        headerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        header = new ExceptionMessageHeader(item);
                    }
                }
            }
            
        
            XmlNodeList validationNodeList = xmlNode.SelectNodes("validation");
            
            foreach (XmlNode item in validationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        validationIDRef = item.Attributes["id"].Name;
                        List<Validation> ob = new List<Validation>();
                        ob.Add(new Validation(item));
                        IDManager.SetID(validationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        validationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    validation.Add(new Validation(item));
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
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            foreach (XmlNode item in reasonNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reasonIDRef = item.Attributes["id"].Name;
                        List<Reason> ob = new List<Reason>();
                        ob.Add(new Reason(item));
                        IDManager.SetID(reasonIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reasonIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    reason.Add(new Reason(item));
                    }
                }
            }
            
        
            XmlNodeList additionalDataNodeList = xmlNode.SelectNodes("additionalData");
            if (additionalDataNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalDataNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalDataIDRef = item.Attributes["id"].Name;
                        AdditionalData ob = AdditionalData();
                        IDManager.SetID(additionalDataIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalDataIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalData = new AdditionalData(item);
                    }
                }
            }
            
        
        }
        
    
        #region Header
        private ExceptionMessageHeader header;
        public ExceptionMessageHeader Header
        {
            get
            {
                if (this.header != null)
                {
                    return this.header; 
                }
                else if (this.headerIDRef != null)
                {
                    header = IDManager.getID(headerIDRef) as ExceptionMessageHeader;
                    return this.header; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.header != value)
                {
                    this.header = value;
                }
            }
        }
        #endregion
        
        public string ExceptionMessageHeaderIDRef { get; set; }
        #region Validation
        private List<Validation> validation;
        public List<Validation> Validation
        {
            get
            {
                if (this.validation != null)
                {
                    return this.validation; 
                }
                else if (this.validationIDRef != null)
                {
                    validation = IDManager.getID(validationIDRef) as List<Validation>;
                    return this.validation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.validation != value)
                {
                    this.validation = value;
                }
            }
        }
        #endregion
        
        public string ValidationIDRef { get; set; }
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
        #region Reason
        private List<Reason> reason;
        public List<Reason> Reason
        {
            get
            {
                if (this.reason != null)
                {
                    return this.reason; 
                }
                else if (this.reasonIDRef != null)
                {
                    reason = IDManager.getID(reasonIDRef) as List<Reason>;
                    return this.reason; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reason != value)
                {
                    this.reason = value;
                }
            }
        }
        #endregion
        
        public string ReasonIDRef { get; set; }
        #region AdditionalData
        private AdditionalData additionalData;
        public AdditionalData AdditionalData
        {
            get
            {
                if (this.additionalData != null)
                {
                    return this.additionalData; 
                }
                else if (this.additionalDataIDRef != null)
                {
                    additionalData = IDManager.getID(additionalDataIDRef) as AdditionalData;
                    return this.additionalData; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalData != value)
                {
                    this.additionalData = value;
                }
            }
        }
        #endregion
        
        public string AdditionalDataIDRef { get; set; }
        
    
        
    
    }
    
}


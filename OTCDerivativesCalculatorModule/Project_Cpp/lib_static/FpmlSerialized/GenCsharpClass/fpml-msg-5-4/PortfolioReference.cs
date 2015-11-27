using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PortfolioReference
    {
        public PortfolioReference(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNodeList submissionsCompleteNodeList = xmlNode.SelectNodes("submissionsComplete");
            if (submissionsCompleteNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in submissionsCompleteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        submissionsCompleteIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(submissionsCompleteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        submissionsCompleteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        submissionsComplete = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region SubmissionsComplete
        private XsdTypeBoolean submissionsComplete;
        public XsdTypeBoolean SubmissionsComplete
        {
            get
            {
                if (this.submissionsComplete != null)
                {
                    return this.submissionsComplete; 
                }
                else if (this.submissionsCompleteIDRef != null)
                {
                    submissionsComplete = IDManager.getID(submissionsCompleteIDRef) as XsdTypeBoolean;
                    return this.submissionsComplete; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.submissionsComplete != value)
                {
                    this.submissionsComplete = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}


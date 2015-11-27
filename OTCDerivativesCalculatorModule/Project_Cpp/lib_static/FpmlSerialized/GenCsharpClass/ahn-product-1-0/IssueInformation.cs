using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IssueInformation
    {
        public IssueInformation(XmlNode xmlNode)
        {
            XmlNodeList productTypeNodeList = xmlNode.SelectNodes("productType");
            if (productTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in productTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        productTypeIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(productTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        productTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        productType = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList instrumentIDNodeList = xmlNode.SelectNodes("instrumentID");
            if (instrumentIDNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in instrumentIDNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        instrumentIDIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(instrumentIDIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        instrumentIDIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        instrumentID = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList notionalNodeList = xmlNode.SelectNodes("notional");
            if (notionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(notionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notional = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList issueDateNodeList = xmlNode.SelectNodes("issueDate");
            if (issueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in issueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        issueDateIDRef = item.Attributes["id"].Name;
                        EventDate ob = EventDate();
                        IDManager.SetID(issueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        issueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        issueDate = new EventDate(item);
                    }
                }
            }
            
        
            XmlNodeList maturityDateNodeList = xmlNode.SelectNodes("maturityDate");
            if (maturityDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maturityDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maturityDateIDRef = item.Attributes["id"].Name;
                        EventDate ob = EventDate();
                        IDManager.SetID(maturityDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maturityDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maturityDate = new EventDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region ProductType
        private XsdTypeToken productType;
        public XsdTypeToken ProductType
        {
            get
            {
                if (this.productType != null)
                {
                    return this.productType; 
                }
                else if (this.productTypeIDRef != null)
                {
                    productType = IDManager.getID(productTypeIDRef) as XsdTypeToken;
                    return this.productType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.productType != value)
                {
                    this.productType = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region InstrumentID
        private XsdTypeToken instrumentID;
        public XsdTypeToken InstrumentID
        {
            get
            {
                if (this.instrumentID != null)
                {
                    return this.instrumentID; 
                }
                else if (this.instrumentIDIDRef != null)
                {
                    instrumentID = IDManager.getID(instrumentIDIDRef) as XsdTypeToken;
                    return this.instrumentID; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.instrumentID != value)
                {
                    this.instrumentID = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Notional
        private XsdTypeDecimal notional;
        public XsdTypeDecimal Notional
        {
            get
            {
                if (this.notional != null)
                {
                    return this.notional; 
                }
                else if (this.notionalIDRef != null)
                {
                    notional = IDManager.getID(notionalIDRef) as XsdTypeDecimal;
                    return this.notional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notional != value)
                {
                    this.notional = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region IssueDate
        private EventDate issueDate;
        public EventDate IssueDate
        {
            get
            {
                if (this.issueDate != null)
                {
                    return this.issueDate; 
                }
                else if (this.issueDateIDRef != null)
                {
                    issueDate = IDManager.getID(issueDateIDRef) as EventDate;
                    return this.issueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.issueDate != value)
                {
                    this.issueDate = value;
                }
            }
        }
        #endregion
        
        public string EventDateIDRef { get; set; }
        #region MaturityDate
        private EventDate maturityDate;
        public EventDate MaturityDate
        {
            get
            {
                if (this.maturityDate != null)
                {
                    return this.maturityDate; 
                }
                else if (this.maturityDateIDRef != null)
                {
                    maturityDate = IDManager.getID(maturityDateIDRef) as EventDate;
                    return this.maturityDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maturityDate != value)
                {
                    this.maturityDate = value;
                }
            }
        }
        #endregion
        
        public string EventDateIDRef { get; set; }
        
    
        
    
    }
    
}


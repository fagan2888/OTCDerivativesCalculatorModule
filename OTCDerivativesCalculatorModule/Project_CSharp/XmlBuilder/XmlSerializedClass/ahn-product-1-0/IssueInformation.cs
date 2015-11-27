using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IssueInformation : ISerialized
    {
        public IssueInformation(XmlNode xmlNode)
        {
            XmlNode productTypeNode = xmlNode.SelectSingleNode("productType");
            
            if (productTypeNode != null)
            {
                if (productTypeNode.Attributes["href"] != null || productTypeNode.Attributes["id"] != null) 
                {
                    if (productTypeNode.Attributes["id"] != null) 
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(productTypeNode);
                        IDManager.SetID(productTypeIDRef_, ob);
                    }
                    else if (productTypeNode.Attributes["href"] != null)
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productType_ = new XsdTypeToken(productTypeNode);
                    }
                }
                else
                {
                    productType_ = new XsdTypeToken(productTypeNode);
                }
            }
            
        
            XmlNode instrumentIDNode = xmlNode.SelectSingleNode("instrumentID");
            
            if (instrumentIDNode != null)
            {
                if (instrumentIDNode.Attributes["href"] != null || instrumentIDNode.Attributes["id"] != null) 
                {
                    if (instrumentIDNode.Attributes["id"] != null) 
                    {
                        instrumentIDIDRef_ = instrumentIDNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(instrumentIDNode);
                        IDManager.SetID(instrumentIDIDRef_, ob);
                    }
                    else if (instrumentIDNode.Attributes["href"] != null)
                    {
                        instrumentIDIDRef_ = instrumentIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instrumentID_ = new XsdTypeToken(instrumentIDNode);
                    }
                }
                else
                {
                    instrumentID_ = new XsdTypeToken(instrumentIDNode);
                }
            }
            
        
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeDecimal(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeDecimal(notionalNode);
                }
            }
            
        
            XmlNode issueDateNode = xmlNode.SelectSingleNode("issueDate");
            
            if (issueDateNode != null)
            {
                if (issueDateNode.Attributes["href"] != null || issueDateNode.Attributes["id"] != null) 
                {
                    if (issueDateNode.Attributes["id"] != null) 
                    {
                        issueDateIDRef_ = issueDateNode.Attributes["id"].Value;
                        EventDate ob = new EventDate(issueDateNode);
                        IDManager.SetID(issueDateIDRef_, ob);
                    }
                    else if (issueDateNode.Attributes["href"] != null)
                    {
                        issueDateIDRef_ = issueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issueDate_ = new EventDate(issueDateNode);
                    }
                }
                else
                {
                    issueDate_ = new EventDate(issueDateNode);
                }
            }
            
        
            XmlNode maturityDateNode = xmlNode.SelectSingleNode("maturityDate");
            
            if (maturityDateNode != null)
            {
                if (maturityDateNode.Attributes["href"] != null || maturityDateNode.Attributes["id"] != null) 
                {
                    if (maturityDateNode.Attributes["id"] != null) 
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["id"].Value;
                        EventDate ob = new EventDate(maturityDateNode);
                        IDManager.SetID(maturityDateIDRef_, ob);
                    }
                    else if (maturityDateNode.Attributes["href"] != null)
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityDate_ = new EventDate(maturityDateNode);
                    }
                }
                else
                {
                    maturityDate_ = new EventDate(maturityDateNode);
                }
            }
            
        
        }
        
    
        #region ProductType_
        private XsdTypeToken productType_;
        public XsdTypeToken ProductType_
        {
            get
            {
                if (this.productType_ != null)
                {
                    return this.productType_; 
                }
                else if (this.productTypeIDRef_ != null)
                {
                    productType_ = IDManager.getID(productTypeIDRef_) as XsdTypeToken;
                    return this.productType_; 
                }
                else
                {
                      return this.productType_; 
                }
            }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                }
            }
        }
        #endregion
        
        public string productTypeIDRef_ { get; set; }
        #region InstrumentID_
        private XsdTypeToken instrumentID_;
        public XsdTypeToken InstrumentID_
        {
            get
            {
                if (this.instrumentID_ != null)
                {
                    return this.instrumentID_; 
                }
                else if (this.instrumentIDIDRef_ != null)
                {
                    instrumentID_ = IDManager.getID(instrumentIDIDRef_) as XsdTypeToken;
                    return this.instrumentID_; 
                }
                else
                {
                      return this.instrumentID_; 
                }
            }
            set
            {
                if (this.instrumentID_ != value)
                {
                    this.instrumentID_ = value;
                }
            }
        }
        #endregion
        
        public string instrumentIDIDRef_ { get; set; }
        #region Notional_
        private XsdTypeDecimal notional_;
        public XsdTypeDecimal Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeDecimal;
                    return this.notional_; 
                }
                else
                {
                      return this.notional_; 
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region IssueDate_
        private EventDate issueDate_;
        public EventDate IssueDate_
        {
            get
            {
                if (this.issueDate_ != null)
                {
                    return this.issueDate_; 
                }
                else if (this.issueDateIDRef_ != null)
                {
                    issueDate_ = IDManager.getID(issueDateIDRef_) as EventDate;
                    return this.issueDate_; 
                }
                else
                {
                      return this.issueDate_; 
                }
            }
            set
            {
                if (this.issueDate_ != value)
                {
                    this.issueDate_ = value;
                }
            }
        }
        #endregion
        
        public string issueDateIDRef_ { get; set; }
        #region MaturityDate_
        private EventDate maturityDate_;
        public EventDate MaturityDate_
        {
            get
            {
                if (this.maturityDate_ != null)
                {
                    return this.maturityDate_; 
                }
                else if (this.maturityDateIDRef_ != null)
                {
                    maturityDate_ = IDManager.getID(maturityDateIDRef_) as EventDate;
                    return this.maturityDate_; 
                }
                else
                {
                      return this.maturityDate_; 
                }
            }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                }
            }
        }
        #endregion
        
        public string maturityDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


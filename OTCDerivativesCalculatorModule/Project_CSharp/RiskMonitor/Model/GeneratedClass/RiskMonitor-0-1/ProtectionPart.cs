using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ProtectionPart : ISerialized
    {
        public ProtectionPart() { }
        public ProtectionPart(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payRecieveNode = xmlNode.SelectSingleNode("payRecieve");
            
            if (payRecieveNode != null)
            {
                if (payRecieveNode.Attributes["href"] != null || payRecieveNode.Attributes["id"] != null) 
                {
                    if (payRecieveNode.Attributes["id"] != null) 
                    {
                        payRecieveIDRef_ = payRecieveNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payRecieveNode);
                        IDManager.SetID(payRecieveIDRef_, ob);
                    }
                    else if (payRecieveNode.Attributes["href"] != null)
                    {
                        payRecieveIDRef_ = payRecieveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payRecieve_ = new XsdTypeToken(payRecieveNode);
                    }
                }
                else
                {
                    payRecieve_ = new XsdTypeToken(payRecieveNode);
                }
            }
            
        
            XmlNode referenceInformationListNode = xmlNode.SelectSingleNode("referenceInformationList");
            
            if (referenceInformationListNode != null)
            {
                if (referenceInformationListNode.Attributes["href"] != null || referenceInformationListNode.Attributes["id"] != null) 
                {
                    if (referenceInformationListNode.Attributes["id"] != null) 
                    {
                        referenceInformationListIDRef_ = referenceInformationListNode.Attributes["id"].Value;
                        ReferenceInformationList ob = new ReferenceInformationList(referenceInformationListNode);
                        IDManager.SetID(referenceInformationListIDRef_, ob);
                    }
                    else if (referenceInformationListNode.Attributes["href"] != null)
                    {
                        referenceInformationListIDRef_ = referenceInformationListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceInformationList_ = new ReferenceInformationList(referenceInformationListNode);
                    }
                }
                else
                {
                    referenceInformationList_ = new ReferenceInformationList(referenceInformationListNode);
                }
            }
            
        
            XmlNode protectionTermsNode = xmlNode.SelectSingleNode("protectionTerms");
            
            if (protectionTermsNode != null)
            {
                if (protectionTermsNode.Attributes["href"] != null || protectionTermsNode.Attributes["id"] != null) 
                {
                    if (protectionTermsNode.Attributes["id"] != null) 
                    {
                        protectionTermsIDRef_ = protectionTermsNode.Attributes["id"].Value;
                        ProtectionTerms ob = new ProtectionTerms(protectionTermsNode);
                        IDManager.SetID(protectionTermsIDRef_, ob);
                    }
                    else if (protectionTermsNode.Attributes["href"] != null)
                    {
                        protectionTermsIDRef_ = protectionTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        protectionTerms_ = new ProtectionTerms(protectionTermsNode);
                    }
                }
                else
                {
                    protectionTerms_ = new ProtectionTerms(protectionTermsNode);
                }
            }
            
        
        }
        
    
        #region PayRecieve_
        private XsdTypeToken payRecieve_;
        public XsdTypeToken PayRecieve_
        {
            get
            {
                if (this.payRecieve_ != null)
                {
                    return this.payRecieve_; 
                }
                else if (this.payRecieveIDRef_ != null)
                {
                    payRecieve_ = IDManager.getID(payRecieveIDRef_) as XsdTypeToken;
                    return this.payRecieve_; 
                }
                else
                {
                    throw new Exception( "payRecieve_Node no exist!");
                }
            }
            set
            {
                if (this.payRecieve_ != value)
                {
                    this.payRecieve_ = value;
                }
            }
        }
        #endregion
        
        public string payRecieveIDRef_ { get; set; }
        #region ReferenceInformationList_
        private ReferenceInformationList referenceInformationList_;
        public ReferenceInformationList ReferenceInformationList_
        {
            get
            {
                if (this.referenceInformationList_ != null)
                {
                    return this.referenceInformationList_; 
                }
                else if (this.referenceInformationListIDRef_ != null)
                {
                    referenceInformationList_ = IDManager.getID(referenceInformationListIDRef_) as ReferenceInformationList;
                    return this.referenceInformationList_; 
                }
                else
                {
                    throw new Exception( "referenceInformationList_Node no exist!");
                }
            }
            set
            {
                if (this.referenceInformationList_ != value)
                {
                    this.referenceInformationList_ = value;
                }
            }
        }
        #endregion
        
        public string referenceInformationListIDRef_ { get; set; }
        #region ProtectionTerms_
        private ProtectionTerms protectionTerms_;
        public ProtectionTerms ProtectionTerms_
        {
            get
            {
                if (this.protectionTerms_ != null)
                {
                    return this.protectionTerms_; 
                }
                else if (this.protectionTermsIDRef_ != null)
                {
                    protectionTerms_ = IDManager.getID(protectionTermsIDRef_) as ProtectionTerms;
                    return this.protectionTerms_; 
                }
                else
                {
                    throw new Exception( "protectionTerms_Node no exist!");
                }
            }
            set
            {
                if (this.protectionTerms_ != value)
                {
                    this.protectionTerms_ = value;
                }
            }
        }
        #endregion
        
        public string protectionTermsIDRef_ { get; set; }
        
    
        
    
    }
    
}


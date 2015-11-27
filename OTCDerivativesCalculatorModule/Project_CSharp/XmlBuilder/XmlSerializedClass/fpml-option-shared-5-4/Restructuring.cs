using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Restructuring : ISerialized
    {
        public Restructuring(XmlNode xmlNode)
        {
            XmlNode applicableNode = xmlNode.SelectSingleNode("applicable");
            
            if (applicableNode != null)
            {
                if (applicableNode.Attributes["href"] != null || applicableNode.Attributes["id"] != null) 
                {
                    if (applicableNode.Attributes["id"] != null) 
                    {
                        applicableIDRef_ = applicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(applicableNode);
                        IDManager.SetID(applicableIDRef_, ob);
                    }
                    else if (applicableNode.Attributes["href"] != null)
                    {
                        applicableIDRef_ = applicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        applicable_ = new XsdTypeBoolean(applicableNode);
                    }
                }
                else
                {
                    applicable_ = new XsdTypeBoolean(applicableNode);
                }
            }
            
        
            XmlNode restructuringTypeNode = xmlNode.SelectSingleNode("restructuringType");
            
            if (restructuringTypeNode != null)
            {
                if (restructuringTypeNode.Attributes["href"] != null || restructuringTypeNode.Attributes["id"] != null) 
                {
                    if (restructuringTypeNode.Attributes["id"] != null) 
                    {
                        restructuringTypeIDRef_ = restructuringTypeNode.Attributes["id"].Value;
                        RestructuringType ob = new RestructuringType(restructuringTypeNode);
                        IDManager.SetID(restructuringTypeIDRef_, ob);
                    }
                    else if (restructuringTypeNode.Attributes["href"] != null)
                    {
                        restructuringTypeIDRef_ = restructuringTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        restructuringType_ = new RestructuringType(restructuringTypeNode);
                    }
                }
                else
                {
                    restructuringType_ = new RestructuringType(restructuringTypeNode);
                }
            }
            
        
            XmlNode multipleHolderObligationNode = xmlNode.SelectSingleNode("multipleHolderObligation");
            
            if (multipleHolderObligationNode != null)
            {
                if (multipleHolderObligationNode.Attributes["href"] != null || multipleHolderObligationNode.Attributes["id"] != null) 
                {
                    if (multipleHolderObligationNode.Attributes["id"] != null) 
                    {
                        multipleHolderObligationIDRef_ = multipleHolderObligationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(multipleHolderObligationNode);
                        IDManager.SetID(multipleHolderObligationIDRef_, ob);
                    }
                    else if (multipleHolderObligationNode.Attributes["href"] != null)
                    {
                        multipleHolderObligationIDRef_ = multipleHolderObligationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleHolderObligation_ = new XsdTypeBoolean(multipleHolderObligationNode);
                    }
                }
                else
                {
                    multipleHolderObligation_ = new XsdTypeBoolean(multipleHolderObligationNode);
                }
            }
            
        
            XmlNode multipleCreditEventNoticesNode = xmlNode.SelectSingleNode("multipleCreditEventNotices");
            
            if (multipleCreditEventNoticesNode != null)
            {
                if (multipleCreditEventNoticesNode.Attributes["href"] != null || multipleCreditEventNoticesNode.Attributes["id"] != null) 
                {
                    if (multipleCreditEventNoticesNode.Attributes["id"] != null) 
                    {
                        multipleCreditEventNoticesIDRef_ = multipleCreditEventNoticesNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(multipleCreditEventNoticesNode);
                        IDManager.SetID(multipleCreditEventNoticesIDRef_, ob);
                    }
                    else if (multipleCreditEventNoticesNode.Attributes["href"] != null)
                    {
                        multipleCreditEventNoticesIDRef_ = multipleCreditEventNoticesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleCreditEventNotices_ = new XsdTypeBoolean(multipleCreditEventNoticesNode);
                    }
                }
                else
                {
                    multipleCreditEventNotices_ = new XsdTypeBoolean(multipleCreditEventNoticesNode);
                }
            }
            
        
        }
        
    
        #region Applicable_
        private XsdTypeBoolean applicable_;
        public XsdTypeBoolean Applicable_
        {
            get
            {
                if (this.applicable_ != null)
                {
                    return this.applicable_; 
                }
                else if (this.applicableIDRef_ != null)
                {
                    applicable_ = IDManager.getID(applicableIDRef_) as XsdTypeBoolean;
                    return this.applicable_; 
                }
                else
                {
                      return this.applicable_; 
                }
            }
            set
            {
                if (this.applicable_ != value)
                {
                    this.applicable_ = value;
                }
            }
        }
        #endregion
        
        public string applicableIDRef_ { get; set; }
        #region RestructuringType_
        private RestructuringType restructuringType_;
        public RestructuringType RestructuringType_
        {
            get
            {
                if (this.restructuringType_ != null)
                {
                    return this.restructuringType_; 
                }
                else if (this.restructuringTypeIDRef_ != null)
                {
                    restructuringType_ = IDManager.getID(restructuringTypeIDRef_) as RestructuringType;
                    return this.restructuringType_; 
                }
                else
                {
                      return this.restructuringType_; 
                }
            }
            set
            {
                if (this.restructuringType_ != value)
                {
                    this.restructuringType_ = value;
                }
            }
        }
        #endregion
        
        public string restructuringTypeIDRef_ { get; set; }
        #region MultipleHolderObligation_
        private XsdTypeBoolean multipleHolderObligation_;
        public XsdTypeBoolean MultipleHolderObligation_
        {
            get
            {
                if (this.multipleHolderObligation_ != null)
                {
                    return this.multipleHolderObligation_; 
                }
                else if (this.multipleHolderObligationIDRef_ != null)
                {
                    multipleHolderObligation_ = IDManager.getID(multipleHolderObligationIDRef_) as XsdTypeBoolean;
                    return this.multipleHolderObligation_; 
                }
                else
                {
                      return this.multipleHolderObligation_; 
                }
            }
            set
            {
                if (this.multipleHolderObligation_ != value)
                {
                    this.multipleHolderObligation_ = value;
                }
            }
        }
        #endregion
        
        public string multipleHolderObligationIDRef_ { get; set; }
        #region MultipleCreditEventNotices_
        private XsdTypeBoolean multipleCreditEventNotices_;
        public XsdTypeBoolean MultipleCreditEventNotices_
        {
            get
            {
                if (this.multipleCreditEventNotices_ != null)
                {
                    return this.multipleCreditEventNotices_; 
                }
                else if (this.multipleCreditEventNoticesIDRef_ != null)
                {
                    multipleCreditEventNotices_ = IDManager.getID(multipleCreditEventNoticesIDRef_) as XsdTypeBoolean;
                    return this.multipleCreditEventNotices_; 
                }
                else
                {
                      return this.multipleCreditEventNotices_; 
                }
            }
            set
            {
                if (this.multipleCreditEventNotices_ != value)
                {
                    this.multipleCreditEventNotices_ = value;
                }
            }
        }
        #endregion
        
        public string multipleCreditEventNoticesIDRef_ { get; set; }
        
    
        
    
    }
    
}


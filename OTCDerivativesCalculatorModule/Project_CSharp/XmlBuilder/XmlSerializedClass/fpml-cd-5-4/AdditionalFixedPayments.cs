using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdditionalFixedPayments : ISerialized
    {
        public AdditionalFixedPayments(XmlNode xmlNode)
        {
            XmlNode interestShortfallReimbursementNode = xmlNode.SelectSingleNode("interestShortfallReimbursement");
            
            if (interestShortfallReimbursementNode != null)
            {
                if (interestShortfallReimbursementNode.Attributes["href"] != null || interestShortfallReimbursementNode.Attributes["id"] != null) 
                {
                    if (interestShortfallReimbursementNode.Attributes["id"] != null) 
                    {
                        interestShortfallReimbursementIDRef_ = interestShortfallReimbursementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(interestShortfallReimbursementNode);
                        IDManager.SetID(interestShortfallReimbursementIDRef_, ob);
                    }
                    else if (interestShortfallReimbursementNode.Attributes["href"] != null)
                    {
                        interestShortfallReimbursementIDRef_ = interestShortfallReimbursementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestShortfallReimbursement_ = new XsdTypeBoolean(interestShortfallReimbursementNode);
                    }
                }
                else
                {
                    interestShortfallReimbursement_ = new XsdTypeBoolean(interestShortfallReimbursementNode);
                }
            }
            
        
            XmlNode principalShortfallReimbursementNode = xmlNode.SelectSingleNode("principalShortfallReimbursement");
            
            if (principalShortfallReimbursementNode != null)
            {
                if (principalShortfallReimbursementNode.Attributes["href"] != null || principalShortfallReimbursementNode.Attributes["id"] != null) 
                {
                    if (principalShortfallReimbursementNode.Attributes["id"] != null) 
                    {
                        principalShortfallReimbursementIDRef_ = principalShortfallReimbursementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(principalShortfallReimbursementNode);
                        IDManager.SetID(principalShortfallReimbursementIDRef_, ob);
                    }
                    else if (principalShortfallReimbursementNode.Attributes["href"] != null)
                    {
                        principalShortfallReimbursementIDRef_ = principalShortfallReimbursementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalShortfallReimbursement_ = new XsdTypeBoolean(principalShortfallReimbursementNode);
                    }
                }
                else
                {
                    principalShortfallReimbursement_ = new XsdTypeBoolean(principalShortfallReimbursementNode);
                }
            }
            
        
            XmlNode writedownReimbursementNode = xmlNode.SelectSingleNode("writedownReimbursement");
            
            if (writedownReimbursementNode != null)
            {
                if (writedownReimbursementNode.Attributes["href"] != null || writedownReimbursementNode.Attributes["id"] != null) 
                {
                    if (writedownReimbursementNode.Attributes["id"] != null) 
                    {
                        writedownReimbursementIDRef_ = writedownReimbursementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(writedownReimbursementNode);
                        IDManager.SetID(writedownReimbursementIDRef_, ob);
                    }
                    else if (writedownReimbursementNode.Attributes["href"] != null)
                    {
                        writedownReimbursementIDRef_ = writedownReimbursementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        writedownReimbursement_ = new XsdTypeBoolean(writedownReimbursementNode);
                    }
                }
                else
                {
                    writedownReimbursement_ = new XsdTypeBoolean(writedownReimbursementNode);
                }
            }
            
        
        }
        
    
        #region InterestShortfallReimbursement_
        private XsdTypeBoolean interestShortfallReimbursement_;
        public XsdTypeBoolean InterestShortfallReimbursement_
        {
            get
            {
                if (this.interestShortfallReimbursement_ != null)
                {
                    return this.interestShortfallReimbursement_; 
                }
                else if (this.interestShortfallReimbursementIDRef_ != null)
                {
                    interestShortfallReimbursement_ = IDManager.getID(interestShortfallReimbursementIDRef_) as XsdTypeBoolean;
                    return this.interestShortfallReimbursement_; 
                }
                else
                {
                      return this.interestShortfallReimbursement_; 
                }
            }
            set
            {
                if (this.interestShortfallReimbursement_ != value)
                {
                    this.interestShortfallReimbursement_ = value;
                }
            }
        }
        #endregion
        
        public string interestShortfallReimbursementIDRef_ { get; set; }
        #region PrincipalShortfallReimbursement_
        private XsdTypeBoolean principalShortfallReimbursement_;
        public XsdTypeBoolean PrincipalShortfallReimbursement_
        {
            get
            {
                if (this.principalShortfallReimbursement_ != null)
                {
                    return this.principalShortfallReimbursement_; 
                }
                else if (this.principalShortfallReimbursementIDRef_ != null)
                {
                    principalShortfallReimbursement_ = IDManager.getID(principalShortfallReimbursementIDRef_) as XsdTypeBoolean;
                    return this.principalShortfallReimbursement_; 
                }
                else
                {
                      return this.principalShortfallReimbursement_; 
                }
            }
            set
            {
                if (this.principalShortfallReimbursement_ != value)
                {
                    this.principalShortfallReimbursement_ = value;
                }
            }
        }
        #endregion
        
        public string principalShortfallReimbursementIDRef_ { get; set; }
        #region WritedownReimbursement_
        private XsdTypeBoolean writedownReimbursement_;
        public XsdTypeBoolean WritedownReimbursement_
        {
            get
            {
                if (this.writedownReimbursement_ != null)
                {
                    return this.writedownReimbursement_; 
                }
                else if (this.writedownReimbursementIDRef_ != null)
                {
                    writedownReimbursement_ = IDManager.getID(writedownReimbursementIDRef_) as XsdTypeBoolean;
                    return this.writedownReimbursement_; 
                }
                else
                {
                      return this.writedownReimbursement_; 
                }
            }
            set
            {
                if (this.writedownReimbursement_ != value)
                {
                    this.writedownReimbursement_ = value;
                }
            }
        }
        #endregion
        
        public string writedownReimbursementIDRef_ { get; set; }
        
    
        
    
    }
    
}


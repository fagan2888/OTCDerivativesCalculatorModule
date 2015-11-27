using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LoanParticipation : PCDeliverableObligationCharac
    {
        public LoanParticipation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode qualifyingParticipationSellerNode = xmlNode.SelectSingleNode("qualifyingParticipationSeller");
            
            if (qualifyingParticipationSellerNode != null)
            {
                if (qualifyingParticipationSellerNode.Attributes["href"] != null || qualifyingParticipationSellerNode.Attributes["id"] != null) 
                {
                    if (qualifyingParticipationSellerNode.Attributes["id"] != null) 
                    {
                        qualifyingParticipationSellerIDRef_ = qualifyingParticipationSellerNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(qualifyingParticipationSellerNode);
                        IDManager.SetID(qualifyingParticipationSellerIDRef_, ob);
                    }
                    else if (qualifyingParticipationSellerNode.Attributes["href"] != null)
                    {
                        qualifyingParticipationSellerIDRef_ = qualifyingParticipationSellerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        qualifyingParticipationSeller_ = new XsdTypeString(qualifyingParticipationSellerNode);
                    }
                }
                else
                {
                    qualifyingParticipationSeller_ = new XsdTypeString(qualifyingParticipationSellerNode);
                }
            }
            
        
        }
        
    
        #region QualifyingParticipationSeller_
        private XsdTypeString qualifyingParticipationSeller_;
        public XsdTypeString QualifyingParticipationSeller_
        {
            get
            {
                if (this.qualifyingParticipationSeller_ != null)
                {
                    return this.qualifyingParticipationSeller_; 
                }
                else if (this.qualifyingParticipationSellerIDRef_ != null)
                {
                    qualifyingParticipationSeller_ = IDManager.getID(qualifyingParticipationSellerIDRef_) as XsdTypeString;
                    return this.qualifyingParticipationSeller_; 
                }
                else
                {
                      return this.qualifyingParticipationSeller_; 
                }
            }
            set
            {
                if (this.qualifyingParticipationSeller_ != value)
                {
                    this.qualifyingParticipationSeller_ = value;
                }
            }
        }
        #endregion
        
        public string qualifyingParticipationSellerIDRef_ { get; set; }
        
    
        
    
    }
    
}


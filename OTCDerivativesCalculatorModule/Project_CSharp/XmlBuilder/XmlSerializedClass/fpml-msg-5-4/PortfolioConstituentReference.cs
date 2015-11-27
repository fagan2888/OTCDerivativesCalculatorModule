using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PortfolioConstituentReference : PortfolioReferenceBase
    {
        public PortfolioConstituentReference(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}


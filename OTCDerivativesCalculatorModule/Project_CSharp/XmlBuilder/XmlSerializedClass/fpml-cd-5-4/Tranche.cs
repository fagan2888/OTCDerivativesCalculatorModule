using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Tranche : ISerialized
    {
        public Tranche(XmlNode xmlNode)
        {
            XmlNode attachmentPointNode = xmlNode.SelectSingleNode("attachmentPoint");
            
            if (attachmentPointNode != null)
            {
                if (attachmentPointNode.Attributes["href"] != null || attachmentPointNode.Attributes["id"] != null) 
                {
                    if (attachmentPointNode.Attributes["id"] != null) 
                    {
                        attachmentPointIDRef_ = attachmentPointNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(attachmentPointNode);
                        IDManager.SetID(attachmentPointIDRef_, ob);
                    }
                    else if (attachmentPointNode.Attributes["href"] != null)
                    {
                        attachmentPointIDRef_ = attachmentPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        attachmentPoint_ = new XsdTypeDecimal(attachmentPointNode);
                    }
                }
                else
                {
                    attachmentPoint_ = new XsdTypeDecimal(attachmentPointNode);
                }
            }
            
        
            XmlNode exhaustionPointNode = xmlNode.SelectSingleNode("exhaustionPoint");
            
            if (exhaustionPointNode != null)
            {
                if (exhaustionPointNode.Attributes["href"] != null || exhaustionPointNode.Attributes["id"] != null) 
                {
                    if (exhaustionPointNode.Attributes["id"] != null) 
                    {
                        exhaustionPointIDRef_ = exhaustionPointNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(exhaustionPointNode);
                        IDManager.SetID(exhaustionPointIDRef_, ob);
                    }
                    else if (exhaustionPointNode.Attributes["href"] != null)
                    {
                        exhaustionPointIDRef_ = exhaustionPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exhaustionPoint_ = new XsdTypeDecimal(exhaustionPointNode);
                    }
                }
                else
                {
                    exhaustionPoint_ = new XsdTypeDecimal(exhaustionPointNode);
                }
            }
            
        
            XmlNode incurredRecoveryApplicableNode = xmlNode.SelectSingleNode("incurredRecoveryApplicable");
            
            if (incurredRecoveryApplicableNode != null)
            {
                if (incurredRecoveryApplicableNode.Attributes["href"] != null || incurredRecoveryApplicableNode.Attributes["id"] != null) 
                {
                    if (incurredRecoveryApplicableNode.Attributes["id"] != null) 
                    {
                        incurredRecoveryApplicableIDRef_ = incurredRecoveryApplicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(incurredRecoveryApplicableNode);
                        IDManager.SetID(incurredRecoveryApplicableIDRef_, ob);
                    }
                    else if (incurredRecoveryApplicableNode.Attributes["href"] != null)
                    {
                        incurredRecoveryApplicableIDRef_ = incurredRecoveryApplicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        incurredRecoveryApplicable_ = new XsdTypeBoolean(incurredRecoveryApplicableNode);
                    }
                }
                else
                {
                    incurredRecoveryApplicable_ = new XsdTypeBoolean(incurredRecoveryApplicableNode);
                }
            }
            
        
        }
        
    
        #region AttachmentPoint_
        private XsdTypeDecimal attachmentPoint_;
        public XsdTypeDecimal AttachmentPoint_
        {
            get
            {
                if (this.attachmentPoint_ != null)
                {
                    return this.attachmentPoint_; 
                }
                else if (this.attachmentPointIDRef_ != null)
                {
                    attachmentPoint_ = IDManager.getID(attachmentPointIDRef_) as XsdTypeDecimal;
                    return this.attachmentPoint_; 
                }
                else
                {
                      return this.attachmentPoint_; 
                }
            }
            set
            {
                if (this.attachmentPoint_ != value)
                {
                    this.attachmentPoint_ = value;
                }
            }
        }
        #endregion
        
        public string attachmentPointIDRef_ { get; set; }
        #region ExhaustionPoint_
        private XsdTypeDecimal exhaustionPoint_;
        public XsdTypeDecimal ExhaustionPoint_
        {
            get
            {
                if (this.exhaustionPoint_ != null)
                {
                    return this.exhaustionPoint_; 
                }
                else if (this.exhaustionPointIDRef_ != null)
                {
                    exhaustionPoint_ = IDManager.getID(exhaustionPointIDRef_) as XsdTypeDecimal;
                    return this.exhaustionPoint_; 
                }
                else
                {
                      return this.exhaustionPoint_; 
                }
            }
            set
            {
                if (this.exhaustionPoint_ != value)
                {
                    this.exhaustionPoint_ = value;
                }
            }
        }
        #endregion
        
        public string exhaustionPointIDRef_ { get; set; }
        #region IncurredRecoveryApplicable_
        private XsdTypeBoolean incurredRecoveryApplicable_;
        public XsdTypeBoolean IncurredRecoveryApplicable_
        {
            get
            {
                if (this.incurredRecoveryApplicable_ != null)
                {
                    return this.incurredRecoveryApplicable_; 
                }
                else if (this.incurredRecoveryApplicableIDRef_ != null)
                {
                    incurredRecoveryApplicable_ = IDManager.getID(incurredRecoveryApplicableIDRef_) as XsdTypeBoolean;
                    return this.incurredRecoveryApplicable_; 
                }
                else
                {
                      return this.incurredRecoveryApplicable_; 
                }
            }
            set
            {
                if (this.incurredRecoveryApplicable_ != value)
                {
                    this.incurredRecoveryApplicable_ = value;
                }
            }
        }
        #endregion
        
        public string incurredRecoveryApplicableIDRef_ { get; set; }
        
    
        
    
    }
    
}


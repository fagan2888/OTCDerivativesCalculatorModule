using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AbsoluteTolerance : ISerialized
    {
        public AbsoluteTolerance(XmlNode xmlNode)
        {
            XmlNode positiveNode = xmlNode.SelectSingleNode("positive");
            
            if (positiveNode != null)
            {
                if (positiveNode.Attributes["href"] != null || positiveNode.Attributes["id"] != null) 
                {
                    if (positiveNode.Attributes["id"] != null) 
                    {
                        positiveIDRef_ = positiveNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(positiveNode);
                        IDManager.SetID(positiveIDRef_, ob);
                    }
                    else if (positiveNode.Attributes["href"] != null)
                    {
                        positiveIDRef_ = positiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        positive_ = new XsdTypeDecimal(positiveNode);
                    }
                }
                else
                {
                    positive_ = new XsdTypeDecimal(positiveNode);
                }
            }
            
        
            XmlNode negativeNode = xmlNode.SelectSingleNode("negative");
            
            if (negativeNode != null)
            {
                if (negativeNode.Attributes["href"] != null || negativeNode.Attributes["id"] != null) 
                {
                    if (negativeNode.Attributes["id"] != null) 
                    {
                        negativeIDRef_ = negativeNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(negativeNode);
                        IDManager.SetID(negativeIDRef_, ob);
                    }
                    else if (negativeNode.Attributes["href"] != null)
                    {
                        negativeIDRef_ = negativeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        negative_ = new XsdTypeDecimal(negativeNode);
                    }
                }
                else
                {
                    negative_ = new XsdTypeDecimal(negativeNode);
                }
            }
            
        
            XmlNode unitNode = xmlNode.SelectSingleNode("unit");
            
            if (unitNode != null)
            {
                if (unitNode.Attributes["href"] != null || unitNode.Attributes["id"] != null) 
                {
                    if (unitNode.Attributes["id"] != null) 
                    {
                        unitIDRef_ = unitNode.Attributes["id"].Value;
                        QuantityUnit ob = new QuantityUnit(unitNode);
                        IDManager.SetID(unitIDRef_, ob);
                    }
                    else if (unitNode.Attributes["href"] != null)
                    {
                        unitIDRef_ = unitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unit_ = new QuantityUnit(unitNode);
                    }
                }
                else
                {
                    unit_ = new QuantityUnit(unitNode);
                }
            }
            
        
            XmlNode optionOwnerPartyReferenceNode = xmlNode.SelectSingleNode("optionOwnerPartyReference");
            
            if (optionOwnerPartyReferenceNode != null)
            {
                if (optionOwnerPartyReferenceNode.Attributes["href"] != null || optionOwnerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (optionOwnerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        optionOwnerPartyReferenceIDRef_ = optionOwnerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(optionOwnerPartyReferenceNode);
                        IDManager.SetID(optionOwnerPartyReferenceIDRef_, ob);
                    }
                    else if (optionOwnerPartyReferenceNode.Attributes["href"] != null)
                    {
                        optionOwnerPartyReferenceIDRef_ = optionOwnerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionOwnerPartyReference_ = new PartyReference(optionOwnerPartyReferenceNode);
                    }
                }
                else
                {
                    optionOwnerPartyReference_ = new PartyReference(optionOwnerPartyReferenceNode);
                }
            }
            
        
        }
        
    
        #region Positive_
        private XsdTypeDecimal positive_;
        public XsdTypeDecimal Positive_
        {
            get
            {
                if (this.positive_ != null)
                {
                    return this.positive_; 
                }
                else if (this.positiveIDRef_ != null)
                {
                    positive_ = IDManager.getID(positiveIDRef_) as XsdTypeDecimal;
                    return this.positive_; 
                }
                else
                {
                      return this.positive_; 
                }
            }
            set
            {
                if (this.positive_ != value)
                {
                    this.positive_ = value;
                }
            }
        }
        #endregion
        
        public string positiveIDRef_ { get; set; }
        #region Negative_
        private XsdTypeDecimal negative_;
        public XsdTypeDecimal Negative_
        {
            get
            {
                if (this.negative_ != null)
                {
                    return this.negative_; 
                }
                else if (this.negativeIDRef_ != null)
                {
                    negative_ = IDManager.getID(negativeIDRef_) as XsdTypeDecimal;
                    return this.negative_; 
                }
                else
                {
                      return this.negative_; 
                }
            }
            set
            {
                if (this.negative_ != value)
                {
                    this.negative_ = value;
                }
            }
        }
        #endregion
        
        public string negativeIDRef_ { get; set; }
        #region Unit_
        private QuantityUnit unit_;
        public QuantityUnit Unit_
        {
            get
            {
                if (this.unit_ != null)
                {
                    return this.unit_; 
                }
                else if (this.unitIDRef_ != null)
                {
                    unit_ = IDManager.getID(unitIDRef_) as QuantityUnit;
                    return this.unit_; 
                }
                else
                {
                      return this.unit_; 
                }
            }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                }
            }
        }
        #endregion
        
        public string unitIDRef_ { get; set; }
        #region OptionOwnerPartyReference_
        private PartyReference optionOwnerPartyReference_;
        public PartyReference OptionOwnerPartyReference_
        {
            get
            {
                if (this.optionOwnerPartyReference_ != null)
                {
                    return this.optionOwnerPartyReference_; 
                }
                else if (this.optionOwnerPartyReferenceIDRef_ != null)
                {
                    optionOwnerPartyReference_ = IDManager.getID(optionOwnerPartyReferenceIDRef_) as PartyReference;
                    return this.optionOwnerPartyReference_; 
                }
                else
                {
                      return this.optionOwnerPartyReference_; 
                }
            }
            set
            {
                if (this.optionOwnerPartyReference_ != value)
                {
                    this.optionOwnerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string optionOwnerPartyReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}


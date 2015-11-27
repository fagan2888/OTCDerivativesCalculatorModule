using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeneralTerminationEventDetail : ISerialized
    {
        public GeneralTerminationEventDetail() { }
        public GeneralTerminationEventDetail(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode general_TerminationEventDetail_creditNode = xmlNode.SelectSingleNode("general_TerminationEventDetail_credit");
            
            if (general_TerminationEventDetail_creditNode != null)
            {
                if (general_TerminationEventDetail_creditNode.Attributes["href"] != null || general_TerminationEventDetail_creditNode.Attributes["id"] != null) 
                {
                    if (general_TerminationEventDetail_creditNode.Attributes["id"] != null) 
                    {
                        general_TerminationEventDetail_creditIDRef_ = general_TerminationEventDetail_creditNode.Attributes["id"].Value;
                        General_TerminationEventDetail_credit ob = new General_TerminationEventDetail_credit(general_TerminationEventDetail_creditNode);
                        IDManager.SetID(general_TerminationEventDetail_creditIDRef_, ob);
                    }
                    else if (general_TerminationEventDetail_creditNode.Attributes["href"] != null)
                    {
                        general_TerminationEventDetail_creditIDRef_ = general_TerminationEventDetail_creditNode.Attributes["href"].Value;
                    }
                    else
                    {
                        general_TerminationEventDetail_credit_ = new General_TerminationEventDetail_credit(general_TerminationEventDetail_creditNode);
                    }
                }
                else
                {
                    general_TerminationEventDetail_credit_ = new General_TerminationEventDetail_credit(general_TerminationEventDetail_creditNode);
                }
            }
            
        
            XmlNode general_TerminationEventDetail_targetNode = xmlNode.SelectSingleNode("general_TerminationEventDetail_target");
            
            if (general_TerminationEventDetail_targetNode != null)
            {
                if (general_TerminationEventDetail_targetNode.Attributes["href"] != null || general_TerminationEventDetail_targetNode.Attributes["id"] != null) 
                {
                    if (general_TerminationEventDetail_targetNode.Attributes["id"] != null) 
                    {
                        general_TerminationEventDetail_targetIDRef_ = general_TerminationEventDetail_targetNode.Attributes["id"].Value;
                        General_TerminationEventDetail_target ob = new General_TerminationEventDetail_target(general_TerminationEventDetail_targetNode);
                        IDManager.SetID(general_TerminationEventDetail_targetIDRef_, ob);
                    }
                    else if (general_TerminationEventDetail_targetNode.Attributes["href"] != null)
                    {
                        general_TerminationEventDetail_targetIDRef_ = general_TerminationEventDetail_targetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        general_TerminationEventDetail_target_ = new General_TerminationEventDetail_target(general_TerminationEventDetail_targetNode);
                    }
                }
                else
                {
                    general_TerminationEventDetail_target_ = new General_TerminationEventDetail_target(general_TerminationEventDetail_targetNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region General_TerminationEventDetail_credit_
        private General_TerminationEventDetail_credit general_TerminationEventDetail_credit_;
        public General_TerminationEventDetail_credit General_TerminationEventDetail_credit_
        {
            get
            {
                if (this.general_TerminationEventDetail_credit_ != null)
                {
                    return this.general_TerminationEventDetail_credit_; 
                }
                else if (this.general_TerminationEventDetail_creditIDRef_ != null)
                {
                    general_TerminationEventDetail_credit_ = IDManager.getID(general_TerminationEventDetail_creditIDRef_) as General_TerminationEventDetail_credit;
                    return this.general_TerminationEventDetail_credit_; 
                }
                else
                {
                    throw new Exception( "general_TerminationEventDetail_credit_Node no exist!");
                }
            }
            set
            {
                if (this.general_TerminationEventDetail_credit_ != value)
                {
                    this.general_TerminationEventDetail_credit_ = value;
                }
            }
        }
        #endregion
        
        public string general_TerminationEventDetail_creditIDRef_ { get; set; }
        #region General_TerminationEventDetail_target_
        private General_TerminationEventDetail_target general_TerminationEventDetail_target_;
        public General_TerminationEventDetail_target General_TerminationEventDetail_target_
        {
            get
            {
                if (this.general_TerminationEventDetail_target_ != null)
                {
                    return this.general_TerminationEventDetail_target_; 
                }
                else if (this.general_TerminationEventDetail_targetIDRef_ != null)
                {
                    general_TerminationEventDetail_target_ = IDManager.getID(general_TerminationEventDetail_targetIDRef_) as General_TerminationEventDetail_target;
                    return this.general_TerminationEventDetail_target_; 
                }
                else
                {
                    throw new Exception( "general_TerminationEventDetail_target_Node no exist!");
                }
            }
            set
            {
                if (this.general_TerminationEventDetail_target_ != value)
                {
                    this.general_TerminationEventDetail_target_ = value;
                }
            }
        }
        #endregion
        
        public string general_TerminationEventDetail_targetIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


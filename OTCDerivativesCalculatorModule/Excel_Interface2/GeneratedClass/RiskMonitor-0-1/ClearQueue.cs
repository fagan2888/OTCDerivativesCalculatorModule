using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ClearQueue : ISerialized
    {
        public ClearQueue() { }
        public ClearQueue(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode actionTypeNode = xmlNode.SelectSingleNode("actionType");
            
            if (actionTypeNode != null)
            {
                if (actionTypeNode.Attributes["href"] != null || actionTypeNode.Attributes["id"] != null) 
                {
                    if (actionTypeNode.Attributes["id"] != null) 
                    {
                        actionTypeIDRef_ = actionTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(actionTypeNode);
                        IDManager.SetID(actionTypeIDRef_, ob);
                    }
                    else if (actionTypeNode.Attributes["href"] != null)
                    {
                        actionTypeIDRef_ = actionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        actionType_ = new XsdTypeToken(actionTypeNode);
                    }
                }
                else
                {
                    actionType_ = new XsdTypeToken(actionTypeNode);
                }
            }
            
        
        }
        
    
        #region ActionType_
        private XsdTypeToken actionType_;
        public XsdTypeToken ActionType_
        {
            get
            {
                if (this.actionType_ != null)
                {
                    return this.actionType_; 
                }
                else if (this.actionTypeIDRef_ != null)
                {
                    actionType_ = IDManager.getID(actionTypeIDRef_) as XsdTypeToken;
                    return this.actionType_; 
                }
                else
                {
                    throw new Exception( "actionType_Node no exist!");
                }
            }
            set
            {
                if (this.actionType_ != value)
                {
                    this.actionType_ = value;
                }
            }
        }
        #endregion
        
        public string actionTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}


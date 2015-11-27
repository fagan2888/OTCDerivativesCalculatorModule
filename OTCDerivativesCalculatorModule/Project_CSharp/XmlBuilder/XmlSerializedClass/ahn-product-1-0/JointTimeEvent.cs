using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointTimeEvent : ISerialized
    {
        public JointTimeEvent(XmlNode xmlNode)
        {
            XmlNode triggerAtleastNode = xmlNode.SelectSingleNode("triggerAtleast");
            
            if (triggerAtleastNode != null)
            {
                if (triggerAtleastNode.Attributes["href"] != null || triggerAtleastNode.Attributes["id"] != null) 
                {
                    if (triggerAtleastNode.Attributes["id"] != null) 
                    {
                        triggerAtleastIDRef_ = triggerAtleastNode.Attributes["id"].Value;
                        TriggerAtleast ob = new TriggerAtleast(triggerAtleastNode);
                        IDManager.SetID(triggerAtleastIDRef_, ob);
                    }
                    else if (triggerAtleastNode.Attributes["href"] != null)
                    {
                        triggerAtleastIDRef_ = triggerAtleastNode.Attributes["href"].Value;
                    }
                    else
                    {
                        triggerAtleast_ = new TriggerAtleast(triggerAtleastNode);
                    }
                }
                else
                {
                    triggerAtleast_ = new TriggerAtleast(triggerAtleastNode);
                }
            }
            
        
        }
        
    
        #region TriggerAtleast_
        private TriggerAtleast triggerAtleast_;
        public TriggerAtleast TriggerAtleast_
        {
            get
            {
                if (this.triggerAtleast_ != null)
                {
                    return this.triggerAtleast_; 
                }
                else if (this.triggerAtleastIDRef_ != null)
                {
                    triggerAtleast_ = IDManager.getID(triggerAtleastIDRef_) as TriggerAtleast;
                    return this.triggerAtleast_; 
                }
                else
                {
                      return this.triggerAtleast_; 
                }
            }
            set
            {
                if (this.triggerAtleast_ != value)
                {
                    this.triggerAtleast_ = value;
                }
            }
        }
        #endregion
        
        public string triggerAtleastIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Knock : ISerialized
    {
        public Knock(XmlNode xmlNode)
        {
            XmlNode knockInNode = xmlNode.SelectSingleNode("knockIn");
            
            if (knockInNode != null)
            {
                if (knockInNode.Attributes["href"] != null || knockInNode.Attributes["id"] != null) 
                {
                    if (knockInNode.Attributes["id"] != null) 
                    {
                        knockInIDRef_ = knockInNode.Attributes["id"].Value;
                        TriggerEvent ob = new TriggerEvent(knockInNode);
                        IDManager.SetID(knockInIDRef_, ob);
                    }
                    else if (knockInNode.Attributes["href"] != null)
                    {
                        knockInIDRef_ = knockInNode.Attributes["href"].Value;
                    }
                    else
                    {
                        knockIn_ = new TriggerEvent(knockInNode);
                    }
                }
                else
                {
                    knockIn_ = new TriggerEvent(knockInNode);
                }
            }
            
        
            XmlNode knockOutNode = xmlNode.SelectSingleNode("knockOut");
            
            if (knockOutNode != null)
            {
                if (knockOutNode.Attributes["href"] != null || knockOutNode.Attributes["id"] != null) 
                {
                    if (knockOutNode.Attributes["id"] != null) 
                    {
                        knockOutIDRef_ = knockOutNode.Attributes["id"].Value;
                        TriggerEvent ob = new TriggerEvent(knockOutNode);
                        IDManager.SetID(knockOutIDRef_, ob);
                    }
                    else if (knockOutNode.Attributes["href"] != null)
                    {
                        knockOutIDRef_ = knockOutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        knockOut_ = new TriggerEvent(knockOutNode);
                    }
                }
                else
                {
                    knockOut_ = new TriggerEvent(knockOutNode);
                }
            }
            
        
        }
        
    
        #region KnockIn_
        private TriggerEvent knockIn_;
        public TriggerEvent KnockIn_
        {
            get
            {
                if (this.knockIn_ != null)
                {
                    return this.knockIn_; 
                }
                else if (this.knockInIDRef_ != null)
                {
                    knockIn_ = IDManager.getID(knockInIDRef_) as TriggerEvent;
                    return this.knockIn_; 
                }
                else
                {
                      return this.knockIn_; 
                }
            }
            set
            {
                if (this.knockIn_ != value)
                {
                    this.knockIn_ = value;
                }
            }
        }
        #endregion
        
        public string knockInIDRef_ { get; set; }
        #region KnockOut_
        private TriggerEvent knockOut_;
        public TriggerEvent KnockOut_
        {
            get
            {
                if (this.knockOut_ != null)
                {
                    return this.knockOut_; 
                }
                else if (this.knockOutIDRef_ != null)
                {
                    knockOut_ = IDManager.getID(knockOutIDRef_) as TriggerEvent;
                    return this.knockOut_; 
                }
                else
                {
                      return this.knockOut_; 
                }
            }
            set
            {
                if (this.knockOut_ != value)
                {
                    this.knockOut_ = value;
                }
            }
        }
        #endregion
        
        public string knockOutIDRef_ { get; set; }
        
    
        
    
    }
    
}


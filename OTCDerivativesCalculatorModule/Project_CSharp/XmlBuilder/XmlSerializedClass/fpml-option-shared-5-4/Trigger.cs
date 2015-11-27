using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Trigger : ISerialized
    {
        public Trigger(XmlNode xmlNode)
        {
            XmlNode levelNode = xmlNode.SelectSingleNode("level");
            
            if (levelNode != null)
            {
                if (levelNode.Attributes["href"] != null || levelNode.Attributes["id"] != null) 
                {
                    if (levelNode.Attributes["id"] != null) 
                    {
                        levelIDRef_ = levelNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(levelNode);
                        IDManager.SetID(levelIDRef_, ob);
                    }
                    else if (levelNode.Attributes["href"] != null)
                    {
                        levelIDRef_ = levelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        level_ = new XsdTypeDecimal(levelNode);
                    }
                }
                else
                {
                    level_ = new XsdTypeDecimal(levelNode);
                }
            }
            
        
            XmlNode levelPercentageNode = xmlNode.SelectSingleNode("levelPercentage");
            
            if (levelPercentageNode != null)
            {
                if (levelPercentageNode.Attributes["href"] != null || levelPercentageNode.Attributes["id"] != null) 
                {
                    if (levelPercentageNode.Attributes["id"] != null) 
                    {
                        levelPercentageIDRef_ = levelPercentageNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(levelPercentageNode);
                        IDManager.SetID(levelPercentageIDRef_, ob);
                    }
                    else if (levelPercentageNode.Attributes["href"] != null)
                    {
                        levelPercentageIDRef_ = levelPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        levelPercentage_ = new XsdTypeDecimal(levelPercentageNode);
                    }
                }
                else
                {
                    levelPercentage_ = new XsdTypeDecimal(levelPercentageNode);
                }
            }
            
        
            XmlNode creditEventsNode = xmlNode.SelectSingleNode("creditEvents");
            
            if (creditEventsNode != null)
            {
                if (creditEventsNode.Attributes["href"] != null || creditEventsNode.Attributes["id"] != null) 
                {
                    if (creditEventsNode.Attributes["id"] != null) 
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["id"].Value;
                        CreditEvents ob = new CreditEvents(creditEventsNode);
                        IDManager.SetID(creditEventsIDRef_, ob);
                    }
                    else if (creditEventsNode.Attributes["href"] != null)
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEvents_ = new CreditEvents(creditEventsNode);
                    }
                }
                else
                {
                    creditEvents_ = new CreditEvents(creditEventsNode);
                }
            }
            
        
            XmlNode creditEventsReferenceNode = xmlNode.SelectSingleNode("creditEventsReference");
            
            if (creditEventsReferenceNode != null)
            {
                if (creditEventsReferenceNode.Attributes["href"] != null || creditEventsReferenceNode.Attributes["id"] != null) 
                {
                    if (creditEventsReferenceNode.Attributes["id"] != null) 
                    {
                        creditEventsReferenceIDRef_ = creditEventsReferenceNode.Attributes["id"].Value;
                        CreditEventsReference ob = new CreditEventsReference(creditEventsReferenceNode);
                        IDManager.SetID(creditEventsReferenceIDRef_, ob);
                    }
                    else if (creditEventsReferenceNode.Attributes["href"] != null)
                    {
                        creditEventsReferenceIDRef_ = creditEventsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEventsReference_ = new CreditEventsReference(creditEventsReferenceNode);
                    }
                }
                else
                {
                    creditEventsReference_ = new CreditEventsReference(creditEventsReferenceNode);
                }
            }
            
        
            XmlNode triggerTypeNode = xmlNode.SelectSingleNode("triggerType");
            
            if (triggerTypeNode != null)
            {
                if (triggerTypeNode.Attributes["href"] != null || triggerTypeNode.Attributes["id"] != null) 
                {
                    if (triggerTypeNode.Attributes["id"] != null) 
                    {
                        triggerTypeIDRef_ = triggerTypeNode.Attributes["id"].Value;
                        TriggerTypeEnum ob = new TriggerTypeEnum(triggerTypeNode);
                        IDManager.SetID(triggerTypeIDRef_, ob);
                    }
                    else if (triggerTypeNode.Attributes["href"] != null)
                    {
                        triggerTypeIDRef_ = triggerTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        triggerType_ = new TriggerTypeEnum(triggerTypeNode);
                    }
                }
                else
                {
                    triggerType_ = new TriggerTypeEnum(triggerTypeNode);
                }
            }
            
        
            XmlNode triggerTimeTypeNode = xmlNode.SelectSingleNode("triggerTimeType");
            
            if (triggerTimeTypeNode != null)
            {
                if (triggerTimeTypeNode.Attributes["href"] != null || triggerTimeTypeNode.Attributes["id"] != null) 
                {
                    if (triggerTimeTypeNode.Attributes["id"] != null) 
                    {
                        triggerTimeTypeIDRef_ = triggerTimeTypeNode.Attributes["id"].Value;
                        TriggerTimeTypeEnum ob = new TriggerTimeTypeEnum(triggerTimeTypeNode);
                        IDManager.SetID(triggerTimeTypeIDRef_, ob);
                    }
                    else if (triggerTimeTypeNode.Attributes["href"] != null)
                    {
                        triggerTimeTypeIDRef_ = triggerTimeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        triggerTimeType_ = new TriggerTimeTypeEnum(triggerTimeTypeNode);
                    }
                }
                else
                {
                    triggerTimeType_ = new TriggerTimeTypeEnum(triggerTimeTypeNode);
                }
            }
            
        
        }
        
    
        #region Level_
        private XsdTypeDecimal level_;
        public XsdTypeDecimal Level_
        {
            get
            {
                if (this.level_ != null)
                {
                    return this.level_; 
                }
                else if (this.levelIDRef_ != null)
                {
                    level_ = IDManager.getID(levelIDRef_) as XsdTypeDecimal;
                    return this.level_; 
                }
                else
                {
                      return this.level_; 
                }
            }
            set
            {
                if (this.level_ != value)
                {
                    this.level_ = value;
                }
            }
        }
        #endregion
        
        public string levelIDRef_ { get; set; }
        #region LevelPercentage_
        private XsdTypeDecimal levelPercentage_;
        public XsdTypeDecimal LevelPercentage_
        {
            get
            {
                if (this.levelPercentage_ != null)
                {
                    return this.levelPercentage_; 
                }
                else if (this.levelPercentageIDRef_ != null)
                {
                    levelPercentage_ = IDManager.getID(levelPercentageIDRef_) as XsdTypeDecimal;
                    return this.levelPercentage_; 
                }
                else
                {
                      return this.levelPercentage_; 
                }
            }
            set
            {
                if (this.levelPercentage_ != value)
                {
                    this.levelPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string levelPercentageIDRef_ { get; set; }
        #region CreditEvents_
        private CreditEvents creditEvents_;
        public CreditEvents CreditEvents_
        {
            get
            {
                if (this.creditEvents_ != null)
                {
                    return this.creditEvents_; 
                }
                else if (this.creditEventsIDRef_ != null)
                {
                    creditEvents_ = IDManager.getID(creditEventsIDRef_) as CreditEvents;
                    return this.creditEvents_; 
                }
                else
                {
                      return this.creditEvents_; 
                }
            }
            set
            {
                if (this.creditEvents_ != value)
                {
                    this.creditEvents_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventsIDRef_ { get; set; }
        #region CreditEventsReference_
        private CreditEventsReference creditEventsReference_;
        public CreditEventsReference CreditEventsReference_
        {
            get
            {
                if (this.creditEventsReference_ != null)
                {
                    return this.creditEventsReference_; 
                }
                else if (this.creditEventsReferenceIDRef_ != null)
                {
                    creditEventsReference_ = IDManager.getID(creditEventsReferenceIDRef_) as CreditEventsReference;
                    return this.creditEventsReference_; 
                }
                else
                {
                      return this.creditEventsReference_; 
                }
            }
            set
            {
                if (this.creditEventsReference_ != value)
                {
                    this.creditEventsReference_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventsReferenceIDRef_ { get; set; }
        #region TriggerType_
        private TriggerTypeEnum triggerType_;
        public TriggerTypeEnum TriggerType_
        {
            get
            {
                if (this.triggerType_ != null)
                {
                    return this.triggerType_; 
                }
                else if (this.triggerTypeIDRef_ != null)
                {
                    triggerType_ = IDManager.getID(triggerTypeIDRef_) as TriggerTypeEnum;
                    return this.triggerType_; 
                }
                else
                {
                      return this.triggerType_; 
                }
            }
            set
            {
                if (this.triggerType_ != value)
                {
                    this.triggerType_ = value;
                }
            }
        }
        #endregion
        
        public string triggerTypeIDRef_ { get; set; }
        #region TriggerTimeType_
        private TriggerTimeTypeEnum triggerTimeType_;
        public TriggerTimeTypeEnum TriggerTimeType_
        {
            get
            {
                if (this.triggerTimeType_ != null)
                {
                    return this.triggerTimeType_; 
                }
                else if (this.triggerTimeTypeIDRef_ != null)
                {
                    triggerTimeType_ = IDManager.getID(triggerTimeTypeIDRef_) as TriggerTimeTypeEnum;
                    return this.triggerTimeType_; 
                }
                else
                {
                      return this.triggerTimeType_; 
                }
            }
            set
            {
                if (this.triggerTimeType_ != value)
                {
                    this.triggerTimeType_ = value;
                }
            }
        }
        #endregion
        
        public string triggerTimeTypeIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


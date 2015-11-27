using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Trigger
    {
        public Trigger(XmlNode xmlNode)
        {
            XmlNodeList levelNodeList = xmlNode.SelectNodes("level");
            if (levelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in levelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        levelIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(levelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        levelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        level = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList levelPercentageNodeList = xmlNode.SelectNodes("levelPercentage");
            if (levelPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in levelPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        levelPercentageIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(levelPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        levelPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        levelPercentage = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventsNodeList = xmlNode.SelectNodes("creditEvents");
            if (creditEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventsIDRef = item.Attributes["id"].Name;
                        CreditEvents ob = CreditEvents();
                        IDManager.SetID(creditEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEvents = new CreditEvents(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventsReferenceNodeList = xmlNode.SelectNodes("creditEventsReference");
            if (creditEventsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventsReferenceIDRef = item.Attributes["id"].Name;
                        CreditEventsReference ob = CreditEventsReference();
                        IDManager.SetID(creditEventsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEventsReference = new CreditEventsReference(item);
                    }
                }
            }
            
        
            XmlNodeList triggerTypeNodeList = xmlNode.SelectNodes("triggerType");
            if (triggerTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerTypeIDRef = item.Attributes["id"].Name;
                        TriggerTypeEnum ob = TriggerTypeEnum();
                        IDManager.SetID(triggerTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        triggerType = new TriggerTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList triggerTimeTypeNodeList = xmlNode.SelectNodes("triggerTimeType");
            if (triggerTimeTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerTimeTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerTimeTypeIDRef = item.Attributes["id"].Name;
                        TriggerTimeTypeEnum ob = TriggerTimeTypeEnum();
                        IDManager.SetID(triggerTimeTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerTimeTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        triggerTimeType = new TriggerTimeTypeEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region Level
        private XsdTypeDecimal level;
        public XsdTypeDecimal Level
        {
            get
            {
                if (this.level != null)
                {
                    return this.level; 
                }
                else if (this.levelIDRef != null)
                {
                    level = IDManager.getID(levelIDRef) as XsdTypeDecimal;
                    return this.level; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.level != value)
                {
                    this.level = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region LevelPercentage
        private XsdTypeDecimal levelPercentage;
        public XsdTypeDecimal LevelPercentage
        {
            get
            {
                if (this.levelPercentage != null)
                {
                    return this.levelPercentage; 
                }
                else if (this.levelPercentageIDRef != null)
                {
                    levelPercentage = IDManager.getID(levelPercentageIDRef) as XsdTypeDecimal;
                    return this.levelPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.levelPercentage != value)
                {
                    this.levelPercentage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region CreditEvents
        private CreditEvents creditEvents;
        public CreditEvents CreditEvents
        {
            get
            {
                if (this.creditEvents != null)
                {
                    return this.creditEvents; 
                }
                else if (this.creditEventsIDRef != null)
                {
                    creditEvents = IDManager.getID(creditEventsIDRef) as CreditEvents;
                    return this.creditEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEvents != value)
                {
                    this.creditEvents = value;
                }
            }
        }
        #endregion
        
        public string CreditEventsIDRef { get; set; }
        #region CreditEventsReference
        private CreditEventsReference creditEventsReference;
        public CreditEventsReference CreditEventsReference
        {
            get
            {
                if (this.creditEventsReference != null)
                {
                    return this.creditEventsReference; 
                }
                else if (this.creditEventsReferenceIDRef != null)
                {
                    creditEventsReference = IDManager.getID(creditEventsReferenceIDRef) as CreditEventsReference;
                    return this.creditEventsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEventsReference != value)
                {
                    this.creditEventsReference = value;
                }
            }
        }
        #endregion
        
        public string CreditEventsReferenceIDRef { get; set; }
        #region TriggerType
        private TriggerTypeEnum triggerType;
        public TriggerTypeEnum TriggerType
        {
            get
            {
                if (this.triggerType != null)
                {
                    return this.triggerType; 
                }
                else if (this.triggerTypeIDRef != null)
                {
                    triggerType = IDManager.getID(triggerTypeIDRef) as TriggerTypeEnum;
                    return this.triggerType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.triggerType != value)
                {
                    this.triggerType = value;
                }
            }
        }
        #endregion
        
        public string TriggerTypeEnumIDRef { get; set; }
        #region TriggerTimeType
        private TriggerTimeTypeEnum triggerTimeType;
        public TriggerTimeTypeEnum TriggerTimeType
        {
            get
            {
                if (this.triggerTimeType != null)
                {
                    return this.triggerTimeType; 
                }
                else if (this.triggerTimeTypeIDRef != null)
                {
                    triggerTimeType = IDManager.getID(triggerTimeTypeIDRef) as TriggerTimeTypeEnum;
                    return this.triggerTimeType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.triggerTimeType != value)
                {
                    this.triggerTimeType = value;
                }
            }
        }
        #endregion
        
        public string TriggerTimeTypeEnumIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}


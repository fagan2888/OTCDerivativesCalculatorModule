using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Knock
    {
        public Knock(XmlNode xmlNode)
        {
            XmlNodeList knockInNodeList = xmlNode.SelectNodes("knockIn");
            if (knockInNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in knockInNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        knockInIDRef = item.Attributes["id"].Name;
                        TriggerEvent ob = TriggerEvent();
                        IDManager.SetID(knockInIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        knockInIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        knockIn = new TriggerEvent(item);
                    }
                }
            }
            
        
            XmlNodeList knockOutNodeList = xmlNode.SelectNodes("knockOut");
            if (knockOutNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in knockOutNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        knockOutIDRef = item.Attributes["id"].Name;
                        TriggerEvent ob = TriggerEvent();
                        IDManager.SetID(knockOutIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        knockOutIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        knockOut = new TriggerEvent(item);
                    }
                }
            }
            
        
        }
        
    
        #region KnockIn
        private TriggerEvent knockIn;
        public TriggerEvent KnockIn
        {
            get
            {
                if (this.knockIn != null)
                {
                    return this.knockIn; 
                }
                else if (this.knockInIDRef != null)
                {
                    knockIn = IDManager.getID(knockInIDRef) as TriggerEvent;
                    return this.knockIn; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.knockIn != value)
                {
                    this.knockIn = value;
                }
            }
        }
        #endregion
        
        public string TriggerEventIDRef { get; set; }
        #region KnockOut
        private TriggerEvent knockOut;
        public TriggerEvent KnockOut
        {
            get
            {
                if (this.knockOut != null)
                {
                    return this.knockOut; 
                }
                else if (this.knockOutIDRef != null)
                {
                    knockOut = IDManager.getID(knockOutIDRef) as TriggerEvent;
                    return this.knockOut; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.knockOut != value)
                {
                    this.knockOut = value;
                }
            }
        }
        #endregion
        
        public string TriggerEventIDRef { get; set; }
        
    
        
    
    }
    
}


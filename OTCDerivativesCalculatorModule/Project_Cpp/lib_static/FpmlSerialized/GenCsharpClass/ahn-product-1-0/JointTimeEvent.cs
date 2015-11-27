using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class JointTimeEvent
    {
        public JointTimeEvent(XmlNode xmlNode)
        {
            XmlNodeList triggerAtleastNodeList = xmlNode.SelectNodes("triggerAtleast");
            if (triggerAtleastNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerAtleastNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerAtleastIDRef = item.Attributes["id"].Name;
                        TriggerAtleast ob = TriggerAtleast();
                        IDManager.SetID(triggerAtleastIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerAtleastIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        triggerAtleast = new TriggerAtleast(item);
                    }
                }
            }
            
        
        }
        
    
        #region TriggerAtleast
        private TriggerAtleast triggerAtleast;
        public TriggerAtleast TriggerAtleast
        {
            get
            {
                if (this.triggerAtleast != null)
                {
                    return this.triggerAtleast; 
                }
                else if (this.triggerAtleastIDRef != null)
                {
                    triggerAtleast = IDManager.getID(triggerAtleastIDRef) as TriggerAtleast;
                    return this.triggerAtleast; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.triggerAtleast != value)
                {
                    this.triggerAtleast = value;
                }
            }
        }
        #endregion
        
        public string TriggerAtleastIDRef { get; set; }
        
    
        
    
    }
    
}


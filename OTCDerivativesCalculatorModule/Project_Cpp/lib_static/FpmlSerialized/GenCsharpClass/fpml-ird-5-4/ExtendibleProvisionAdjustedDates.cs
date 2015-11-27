using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExtendibleProvisionAdjustedDates
    {
        public ExtendibleProvisionAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList extensionEventNodeList = xmlNode.SelectNodes("extensionEvent");
            
            foreach (XmlNode item in extensionEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extensionEventIDRef = item.Attributes["id"].Name;
                        List<ExtensionEvent> ob = new List<ExtensionEvent>();
                        ob.Add(new ExtensionEvent(item));
                        IDManager.SetID(extensionEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extensionEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    extensionEvent.Add(new ExtensionEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region ExtensionEvent
        private List<ExtensionEvent> extensionEvent;
        public List<ExtensionEvent> ExtensionEvent
        {
            get
            {
                if (this.extensionEvent != null)
                {
                    return this.extensionEvent; 
                }
                else if (this.extensionEventIDRef != null)
                {
                    extensionEvent = IDManager.getID(extensionEventIDRef) as List<ExtensionEvent>;
                    return this.extensionEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extensionEvent != value)
                {
                    this.extensionEvent = value;
                }
            }
        }
        #endregion
        
        public string ExtensionEventIDRef { get; set; }
        
    
        
    
    }
    
}


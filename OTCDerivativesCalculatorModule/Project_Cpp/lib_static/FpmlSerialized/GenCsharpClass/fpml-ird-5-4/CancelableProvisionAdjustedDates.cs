using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CancelableProvisionAdjustedDates
    {
        public CancelableProvisionAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList cancellationEventNodeList = xmlNode.SelectNodes("cancellationEvent");
            
            foreach (XmlNode item in cancellationEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cancellationEventIDRef = item.Attributes["id"].Name;
                        List<CancellationEvent> ob = new List<CancellationEvent>();
                        ob.Add(new CancellationEvent(item));
                        IDManager.SetID(cancellationEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cancellationEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    cancellationEvent.Add(new CancellationEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region CancellationEvent
        private List<CancellationEvent> cancellationEvent;
        public List<CancellationEvent> CancellationEvent
        {
            get
            {
                if (this.cancellationEvent != null)
                {
                    return this.cancellationEvent; 
                }
                else if (this.cancellationEventIDRef != null)
                {
                    cancellationEvent = IDManager.getID(cancellationEventIDRef) as List<CancellationEvent>;
                    return this.cancellationEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cancellationEvent != value)
                {
                    this.cancellationEvent = value;
                }
            }
        }
        #endregion
        
        public string CancellationEventIDRef { get; set; }
        
    
        
    
    }
    
}


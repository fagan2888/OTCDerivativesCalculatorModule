using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CancelableProvisionAdjustedDates : ISerialized
    {
        public CancelableProvisionAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList cancellationEventNodeList = xmlNode.SelectNodes("cancellationEvent");
            
            if (cancellationEventNodeList != null)
            {
                this.cancellationEvent_ = new List<CancellationEvent>();
                foreach (XmlNode item in cancellationEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            cancellationEventIDRef_ = item.Attributes["id"].Value;
                            cancellationEvent_.Add(new CancellationEvent(item));
                            IDManager.SetID(cancellationEventIDRef_, cancellationEvent_[cancellationEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            cancellationEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        cancellationEvent_.Add(new CancellationEvent(item));
                        }
                    }
                    else
                    {
                        cancellationEvent_.Add(new CancellationEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region CancellationEvent_
        private List<CancellationEvent> cancellationEvent_;
        public List<CancellationEvent> CancellationEvent_
        {
            get
            {
                if (this.cancellationEvent_ != null)
                {
                    return this.cancellationEvent_; 
                }
                else if (this.cancellationEventIDRef_ != null)
                {
                    return this.cancellationEvent_; 
                }
                else
                {
                      return this.cancellationEvent_; 
                }
            }
            set
            {
                if (this.cancellationEvent_ != value)
                {
                    this.cancellationEvent_ = value;
                }
            }
        }
        #endregion
        
        public string cancellationEventIDRef_ { get; set; }
        
    
        
    
    }
    
}


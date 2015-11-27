using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionalEarlyTerminationAdjustedDates : ISerialized
    {
        public OptionalEarlyTerminationAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList earlyTerminationEventNodeList = xmlNode.SelectNodes("earlyTerminationEvent");
            
            if (earlyTerminationEventNodeList != null)
            {
                this.earlyTerminationEvent_ = new List<EarlyTerminationEvent>();
                foreach (XmlNode item in earlyTerminationEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            earlyTerminationEventIDRef_ = item.Attributes["id"].Value;
                            earlyTerminationEvent_.Add(new EarlyTerminationEvent(item));
                            IDManager.SetID(earlyTerminationEventIDRef_, earlyTerminationEvent_[earlyTerminationEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            earlyTerminationEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        earlyTerminationEvent_.Add(new EarlyTerminationEvent(item));
                        }
                    }
                    else
                    {
                        earlyTerminationEvent_.Add(new EarlyTerminationEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region EarlyTerminationEvent_
        private List<EarlyTerminationEvent> earlyTerminationEvent_;
        public List<EarlyTerminationEvent> EarlyTerminationEvent_
        {
            get
            {
                if (this.earlyTerminationEvent_ != null)
                {
                    return this.earlyTerminationEvent_; 
                }
                else if (this.earlyTerminationEventIDRef_ != null)
                {
                    return this.earlyTerminationEvent_; 
                }
                else
                {
                      return this.earlyTerminationEvent_; 
                }
            }
            set
            {
                if (this.earlyTerminationEvent_ != value)
                {
                    this.earlyTerminationEvent_ = value;
                }
            }
        }
        #endregion
        
        public string earlyTerminationEventIDRef_ { get; set; }
        
    
        
    
    }
    
}


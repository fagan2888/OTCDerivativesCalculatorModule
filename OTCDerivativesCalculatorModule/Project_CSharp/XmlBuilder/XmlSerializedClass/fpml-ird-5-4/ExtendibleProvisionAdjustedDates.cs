using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExtendibleProvisionAdjustedDates : ISerialized
    {
        public ExtendibleProvisionAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList extensionEventNodeList = xmlNode.SelectNodes("extensionEvent");
            
            if (extensionEventNodeList != null)
            {
                this.extensionEvent_ = new List<ExtensionEvent>();
                foreach (XmlNode item in extensionEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            extensionEventIDRef_ = item.Attributes["id"].Value;
                            extensionEvent_.Add(new ExtensionEvent(item));
                            IDManager.SetID(extensionEventIDRef_, extensionEvent_[extensionEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            extensionEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        extensionEvent_.Add(new ExtensionEvent(item));
                        }
                    }
                    else
                    {
                        extensionEvent_.Add(new ExtensionEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region ExtensionEvent_
        private List<ExtensionEvent> extensionEvent_;
        public List<ExtensionEvent> ExtensionEvent_
        {
            get
            {
                if (this.extensionEvent_ != null)
                {
                    return this.extensionEvent_; 
                }
                else if (this.extensionEventIDRef_ != null)
                {
                    return this.extensionEvent_; 
                }
                else
                {
                      return this.extensionEvent_; 
                }
            }
            set
            {
                if (this.extensionEvent_ != value)
                {
                    this.extensionEvent_ = value;
                }
            }
        }
        #endregion
        
        public string extensionEventIDRef_ { get; set; }
        
    
        
    
    }
    
}


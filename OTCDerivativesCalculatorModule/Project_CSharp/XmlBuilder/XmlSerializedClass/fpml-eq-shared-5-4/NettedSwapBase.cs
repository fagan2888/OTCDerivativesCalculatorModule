using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NettedSwapBase : Product
    {
        public NettedSwapBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList additionalPaymentNodeList = xmlNode.SelectNodes("additionalPayment");
            
            if (additionalPaymentNodeList != null)
            {
                this.additionalPayment_ = new List<ClassifiedPayment>();
                foreach (XmlNode item in additionalPaymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            additionalPaymentIDRef_ = item.Attributes["id"].Value;
                            additionalPayment_.Add(new ClassifiedPayment(item));
                            IDManager.SetID(additionalPaymentIDRef_, additionalPayment_[additionalPayment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            additionalPaymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        additionalPayment_.Add(new ClassifiedPayment(item));
                        }
                    }
                    else
                    {
                        additionalPayment_.Add(new ClassifiedPayment(item));
                    }
                }
            }
            
        
            XmlNode extraordinaryEventsNode = xmlNode.SelectSingleNode("extraordinaryEvents");
            
            if (extraordinaryEventsNode != null)
            {
                if (extraordinaryEventsNode.Attributes["href"] != null || extraordinaryEventsNode.Attributes["id"] != null) 
                {
                    if (extraordinaryEventsNode.Attributes["id"] != null) 
                    {
                        extraordinaryEventsIDRef_ = extraordinaryEventsNode.Attributes["id"].Value;
                        ExtraordinaryEvents ob = new ExtraordinaryEvents(extraordinaryEventsNode);
                        IDManager.SetID(extraordinaryEventsIDRef_, ob);
                    }
                    else if (extraordinaryEventsNode.Attributes["href"] != null)
                    {
                        extraordinaryEventsIDRef_ = extraordinaryEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extraordinaryEvents_ = new ExtraordinaryEvents(extraordinaryEventsNode);
                    }
                }
                else
                {
                    extraordinaryEvents_ = new ExtraordinaryEvents(extraordinaryEventsNode);
                }
            }
            
        
        }
        
    
        #region AdditionalPayment_
        private List<ClassifiedPayment> additionalPayment_;
        public List<ClassifiedPayment> AdditionalPayment_
        {
            get
            {
                if (this.additionalPayment_ != null)
                {
                    return this.additionalPayment_; 
                }
                else if (this.additionalPaymentIDRef_ != null)
                {
                    return this.additionalPayment_; 
                }
                else
                {
                      return this.additionalPayment_; 
                }
            }
            set
            {
                if (this.additionalPayment_ != value)
                {
                    this.additionalPayment_ = value;
                }
            }
        }
        #endregion
        
        public string additionalPaymentIDRef_ { get; set; }
        #region ExtraordinaryEvents_
        private ExtraordinaryEvents extraordinaryEvents_;
        public ExtraordinaryEvents ExtraordinaryEvents_
        {
            get
            {
                if (this.extraordinaryEvents_ != null)
                {
                    return this.extraordinaryEvents_; 
                }
                else if (this.extraordinaryEventsIDRef_ != null)
                {
                    extraordinaryEvents_ = IDManager.getID(extraordinaryEventsIDRef_) as ExtraordinaryEvents;
                    return this.extraordinaryEvents_; 
                }
                else
                {
                      return this.extraordinaryEvents_; 
                }
            }
            set
            {
                if (this.extraordinaryEvents_ != value)
                {
                    this.extraordinaryEvents_ = value;
                }
            }
        }
        #endregion
        
        public string extraordinaryEventsIDRef_ { get; set; }
        
    
        
    
    }
    
}


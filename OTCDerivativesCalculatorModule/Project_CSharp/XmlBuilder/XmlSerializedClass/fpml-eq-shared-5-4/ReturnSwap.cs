using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwap : ReturnSwapBase
    {
        public ReturnSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList additionalPaymentNodeList = xmlNode.SelectNodes("additionalPayment");
            
            if (additionalPaymentNodeList != null)
            {
                this.additionalPayment_ = new List<ReturnSwapAdditionalPayment>();
                foreach (XmlNode item in additionalPaymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            additionalPaymentIDRef_ = item.Attributes["id"].Value;
                            additionalPayment_.Add(new ReturnSwapAdditionalPayment(item));
                            IDManager.SetID(additionalPaymentIDRef_, additionalPayment_[additionalPayment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            additionalPaymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        additionalPayment_.Add(new ReturnSwapAdditionalPayment(item));
                        }
                    }
                    else
                    {
                        additionalPayment_.Add(new ReturnSwapAdditionalPayment(item));
                    }
                }
            }
            
        
            XmlNodeList earlyTerminationNodeList = xmlNode.SelectNodes("earlyTermination");
            
            if (earlyTerminationNodeList != null)
            {
                this.earlyTermination_ = new List<ReturnSwapEarlyTermination>();
                foreach (XmlNode item in earlyTerminationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            earlyTerminationIDRef_ = item.Attributes["id"].Value;
                            earlyTermination_.Add(new ReturnSwapEarlyTermination(item));
                            IDManager.SetID(earlyTerminationIDRef_, earlyTermination_[earlyTermination_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            earlyTerminationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        earlyTermination_.Add(new ReturnSwapEarlyTermination(item));
                        }
                    }
                    else
                    {
                        earlyTermination_.Add(new ReturnSwapEarlyTermination(item));
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
        private List<ReturnSwapAdditionalPayment> additionalPayment_;
        public List<ReturnSwapAdditionalPayment> AdditionalPayment_
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
        #region EarlyTermination_
        private List<ReturnSwapEarlyTermination> earlyTermination_;
        public List<ReturnSwapEarlyTermination> EarlyTermination_
        {
            get
            {
                if (this.earlyTermination_ != null)
                {
                    return this.earlyTermination_; 
                }
                else if (this.earlyTerminationIDRef_ != null)
                {
                    return this.earlyTermination_; 
                }
                else
                {
                      return this.earlyTermination_; 
                }
            }
            set
            {
                if (this.earlyTermination_ != value)
                {
                    this.earlyTermination_ = value;
                }
            }
        }
        #endregion
        
        public string earlyTerminationIDRef_ { get; set; }
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


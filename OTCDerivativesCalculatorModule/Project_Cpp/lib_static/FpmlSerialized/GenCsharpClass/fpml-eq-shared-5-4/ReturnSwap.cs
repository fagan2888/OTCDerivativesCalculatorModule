using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwap
    {
        public ReturnSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList additionalPaymentNodeList = xmlNode.SelectNodes("additionalPayment");
            
            foreach (XmlNode item in additionalPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalPaymentIDRef = item.Attributes["id"].Name;
                        List<ReturnSwapAdditionalPayment> ob = new List<ReturnSwapAdditionalPayment>();
                        ob.Add(new ReturnSwapAdditionalPayment(item));
                        IDManager.SetID(additionalPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalPayment.Add(new ReturnSwapAdditionalPayment(item));
                    }
                }
            }
            
        
            XmlNodeList earlyTerminationNodeList = xmlNode.SelectNodes("earlyTermination");
            
            foreach (XmlNode item in earlyTerminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earlyTerminationIDRef = item.Attributes["id"].Name;
                        List<ReturnSwapEarlyTermination> ob = new List<ReturnSwapEarlyTermination>();
                        ob.Add(new ReturnSwapEarlyTermination(item));
                        IDManager.SetID(earlyTerminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earlyTerminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    earlyTermination.Add(new ReturnSwapEarlyTermination(item));
                    }
                }
            }
            
        
            XmlNodeList extraordinaryEventsNodeList = xmlNode.SelectNodes("extraordinaryEvents");
            if (extraordinaryEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extraordinaryEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extraordinaryEventsIDRef = item.Attributes["id"].Name;
                        ExtraordinaryEvents ob = ExtraordinaryEvents();
                        IDManager.SetID(extraordinaryEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extraordinaryEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extraordinaryEvents = new ExtraordinaryEvents(item);
                    }
                }
            }
            
        
        }
        
    
        #region AdditionalPayment
        private List<ReturnSwapAdditionalPayment> additionalPayment;
        public List<ReturnSwapAdditionalPayment> AdditionalPayment
        {
            get
            {
                if (this.additionalPayment != null)
                {
                    return this.additionalPayment; 
                }
                else if (this.additionalPaymentIDRef != null)
                {
                    additionalPayment = IDManager.getID(additionalPaymentIDRef) as List<ReturnSwapAdditionalPayment>;
                    return this.additionalPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalPayment != value)
                {
                    this.additionalPayment = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapAdditionalPaymentIDRef { get; set; }
        #region EarlyTermination
        private List<ReturnSwapEarlyTermination> earlyTermination;
        public List<ReturnSwapEarlyTermination> EarlyTermination
        {
            get
            {
                if (this.earlyTermination != null)
                {
                    return this.earlyTermination; 
                }
                else if (this.earlyTerminationIDRef != null)
                {
                    earlyTermination = IDManager.getID(earlyTerminationIDRef) as List<ReturnSwapEarlyTermination>;
                    return this.earlyTermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earlyTermination != value)
                {
                    this.earlyTermination = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapEarlyTerminationIDRef { get; set; }
        #region ExtraordinaryEvents
        private ExtraordinaryEvents extraordinaryEvents;
        public ExtraordinaryEvents ExtraordinaryEvents
        {
            get
            {
                if (this.extraordinaryEvents != null)
                {
                    return this.extraordinaryEvents; 
                }
                else if (this.extraordinaryEventsIDRef != null)
                {
                    extraordinaryEvents = IDManager.getID(extraordinaryEventsIDRef) as ExtraordinaryEvents;
                    return this.extraordinaryEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extraordinaryEvents != value)
                {
                    this.extraordinaryEvents = value;
                }
            }
        }
        #endregion
        
        public string ExtraordinaryEventsIDRef { get; set; }
        
    
        
    
    }
    
}


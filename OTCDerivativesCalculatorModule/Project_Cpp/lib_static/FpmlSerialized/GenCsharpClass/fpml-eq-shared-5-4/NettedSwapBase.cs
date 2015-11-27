using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NettedSwapBase
    {
        public NettedSwapBase(XmlNode xmlNode)
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
                        List<ClassifiedPayment> ob = new List<ClassifiedPayment>();
                        ob.Add(new ClassifiedPayment(item));
                        IDManager.SetID(additionalPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalPayment.Add(new ClassifiedPayment(item));
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
        private List<ClassifiedPayment> additionalPayment;
        public List<ClassifiedPayment> AdditionalPayment
        {
            get
            {
                if (this.additionalPayment != null)
                {
                    return this.additionalPayment; 
                }
                else if (this.additionalPaymentIDRef != null)
                {
                    additionalPayment = IDManager.getID(additionalPaymentIDRef) as List<ClassifiedPayment>;
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
        
        public string ClassifiedPaymentIDRef { get; set; }
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


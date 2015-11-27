using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CapFloor
    {
        public CapFloor(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList capFloorStreamNodeList = xmlNode.SelectNodes("capFloorStream");
            if (capFloorStreamNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in capFloorStreamNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        capFloorStreamIDRef = item.Attributes["id"].Name;
                        InterestRateStream ob = InterestRateStream();
                        IDManager.SetID(capFloorStreamIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        capFloorStreamIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        capFloorStream = new InterestRateStream(item);
                    }
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            foreach (XmlNode item in premiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumIDRef = item.Attributes["id"].Name;
                        List<Payment> ob = new List<Payment>();
                        ob.Add(new Payment(item));
                        IDManager.SetID(premiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    premium.Add(new Payment(item));
                    }
                }
            }
            
        
            XmlNodeList additionalPaymentNodeList = xmlNode.SelectNodes("additionalPayment");
            
            foreach (XmlNode item in additionalPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalPaymentIDRef = item.Attributes["id"].Name;
                        List<Payment> ob = new List<Payment>();
                        ob.Add(new Payment(item));
                        IDManager.SetID(additionalPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalPayment.Add(new Payment(item));
                    }
                }
            }
            
        
            XmlNodeList earlyTerminationProvisionNodeList = xmlNode.SelectNodes("earlyTerminationProvision");
            if (earlyTerminationProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in earlyTerminationProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earlyTerminationProvisionIDRef = item.Attributes["id"].Name;
                        EarlyTerminationProvision ob = EarlyTerminationProvision();
                        IDManager.SetID(earlyTerminationProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earlyTerminationProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        earlyTerminationProvision = new EarlyTerminationProvision(item);
                    }
                }
            }
            
        
        }
        
    
        #region CapFloorStream
        private InterestRateStream capFloorStream;
        public InterestRateStream CapFloorStream
        {
            get
            {
                if (this.capFloorStream != null)
                {
                    return this.capFloorStream; 
                }
                else if (this.capFloorStreamIDRef != null)
                {
                    capFloorStream = IDManager.getID(capFloorStreamIDRef) as InterestRateStream;
                    return this.capFloorStream; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.capFloorStream != value)
                {
                    this.capFloorStream = value;
                }
            }
        }
        #endregion
        
        public string InterestRateStreamIDRef { get; set; }
        #region Premium
        private List<Payment> premium;
        public List<Payment> Premium
        {
            get
            {
                if (this.premium != null)
                {
                    return this.premium; 
                }
                else if (this.premiumIDRef != null)
                {
                    premium = IDManager.getID(premiumIDRef) as List<Payment>;
                    return this.premium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premium != value)
                {
                    this.premium = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        #region AdditionalPayment
        private List<Payment> additionalPayment;
        public List<Payment> AdditionalPayment
        {
            get
            {
                if (this.additionalPayment != null)
                {
                    return this.additionalPayment; 
                }
                else if (this.additionalPaymentIDRef != null)
                {
                    additionalPayment = IDManager.getID(additionalPaymentIDRef) as List<Payment>;
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
        
        public string PaymentIDRef { get; set; }
        #region EarlyTerminationProvision
        private EarlyTerminationProvision earlyTerminationProvision;
        public EarlyTerminationProvision EarlyTerminationProvision
        {
            get
            {
                if (this.earlyTerminationProvision != null)
                {
                    return this.earlyTerminationProvision; 
                }
                else if (this.earlyTerminationProvisionIDRef != null)
                {
                    earlyTerminationProvision = IDManager.getID(earlyTerminationProvisionIDRef) as EarlyTerminationProvision;
                    return this.earlyTerminationProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earlyTerminationProvision != value)
                {
                    this.earlyTerminationProvision = value;
                }
            }
        }
        #endregion
        
        public string EarlyTerminationProvisionIDRef { get; set; }
        
    
        
    
    }
    
}


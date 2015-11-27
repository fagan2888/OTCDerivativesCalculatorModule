using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BrokerConfirmation
    {
        public BrokerConfirmation(XmlNode xmlNode)
        {
            XmlNodeList brokerConfirmationTypeNodeList = xmlNode.SelectNodes("brokerConfirmationType");
            if (brokerConfirmationTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in brokerConfirmationTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brokerConfirmationTypeIDRef = item.Attributes["id"].Name;
                        BrokerConfirmationType ob = BrokerConfirmationType();
                        IDManager.SetID(brokerConfirmationTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brokerConfirmationTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        brokerConfirmationType = new BrokerConfirmationType(item);
                    }
                }
            }
            
        
        }
        
    
        #region BrokerConfirmationType
        private BrokerConfirmationType brokerConfirmationType;
        public BrokerConfirmationType BrokerConfirmationType
        {
            get
            {
                if (this.brokerConfirmationType != null)
                {
                    return this.brokerConfirmationType; 
                }
                else if (this.brokerConfirmationTypeIDRef != null)
                {
                    brokerConfirmationType = IDManager.getID(brokerConfirmationTypeIDRef) as BrokerConfirmationType;
                    return this.brokerConfirmationType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brokerConfirmationType != value)
                {
                    this.brokerConfirmationType = value;
                }
            }
        }
        #endregion
        
        public string BrokerConfirmationTypeIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FailureToPay
    {
        public FailureToPay(XmlNode xmlNode)
        {
            XmlNodeList applicableNodeList = xmlNode.SelectNodes("applicable");
            if (applicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(applicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList gracePeriodExtensionNodeList = xmlNode.SelectNodes("gracePeriodExtension");
            if (gracePeriodExtensionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in gracePeriodExtensionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        gracePeriodExtensionIDRef = item.Attributes["id"].Name;
                        GracePeriodExtension ob = GracePeriodExtension();
                        IDManager.SetID(gracePeriodExtensionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        gracePeriodExtensionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        gracePeriodExtension = new GracePeriodExtension(item);
                    }
                }
            }
            
        
            XmlNodeList paymentRequirementNodeList = xmlNode.SelectNodes("paymentRequirement");
            if (paymentRequirementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentRequirementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentRequirementIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(paymentRequirementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentRequirementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentRequirement = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region Applicable
        private XsdTypeBoolean applicable;
        public XsdTypeBoolean Applicable
        {
            get
            {
                if (this.applicable != null)
                {
                    return this.applicable; 
                }
                else if (this.applicableIDRef != null)
                {
                    applicable = IDManager.getID(applicableIDRef) as XsdTypeBoolean;
                    return this.applicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicable != value)
                {
                    this.applicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region GracePeriodExtension
        private GracePeriodExtension gracePeriodExtension;
        public GracePeriodExtension GracePeriodExtension
        {
            get
            {
                if (this.gracePeriodExtension != null)
                {
                    return this.gracePeriodExtension; 
                }
                else if (this.gracePeriodExtensionIDRef != null)
                {
                    gracePeriodExtension = IDManager.getID(gracePeriodExtensionIDRef) as GracePeriodExtension;
                    return this.gracePeriodExtension; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.gracePeriodExtension != value)
                {
                    this.gracePeriodExtension = value;
                }
            }
        }
        #endregion
        
        public string GracePeriodExtensionIDRef { get; set; }
        #region PaymentRequirement
        private Money paymentRequirement;
        public Money PaymentRequirement
        {
            get
            {
                if (this.paymentRequirement != null)
                {
                    return this.paymentRequirement; 
                }
                else if (this.paymentRequirementIDRef != null)
                {
                    paymentRequirement = IDManager.getID(paymentRequirementIDRef) as Money;
                    return this.paymentRequirement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentRequirement != value)
                {
                    this.paymentRequirement = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}


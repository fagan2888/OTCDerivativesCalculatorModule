using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FloatingAmountEvents
    {
        public FloatingAmountEvents(XmlNode xmlNode)
        {
            XmlNodeList failureToPayPrincipalNodeList = xmlNode.SelectNodes("failureToPayPrincipal");
            if (failureToPayPrincipalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToPayPrincipalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToPayPrincipalIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(failureToPayPrincipalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToPayPrincipalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToPayPrincipal = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList interestShortfallNodeList = xmlNode.SelectNodes("interestShortfall");
            if (interestShortfallNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestShortfallNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestShortfallIDRef = item.Attributes["id"].Name;
                        InterestShortFall ob = InterestShortFall();
                        IDManager.SetID(interestShortfallIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestShortfallIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestShortfall = new InterestShortFall(item);
                    }
                }
            }
            
        
            XmlNodeList writedownNodeList = xmlNode.SelectNodes("writedown");
            if (writedownNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in writedownNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        writedownIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(writedownIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        writedownIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        writedown = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList impliedWritedownNodeList = xmlNode.SelectNodes("impliedWritedown");
            if (impliedWritedownNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in impliedWritedownNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        impliedWritedownIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(impliedWritedownIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        impliedWritedownIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        impliedWritedown = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList floatingAmountProvisionsNodeList = xmlNode.SelectNodes("floatingAmountProvisions");
            if (floatingAmountProvisionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingAmountProvisionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingAmountProvisionsIDRef = item.Attributes["id"].Name;
                        FloatingAmountProvisions ob = FloatingAmountProvisions();
                        IDManager.SetID(floatingAmountProvisionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingAmountProvisionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingAmountProvisions = new FloatingAmountProvisions(item);
                    }
                }
            }
            
        
            XmlNodeList additionalFixedPaymentsNodeList = xmlNode.SelectNodes("additionalFixedPayments");
            if (additionalFixedPaymentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalFixedPaymentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalFixedPaymentsIDRef = item.Attributes["id"].Name;
                        AdditionalFixedPayments ob = AdditionalFixedPayments();
                        IDManager.SetID(additionalFixedPaymentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalFixedPaymentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalFixedPayments = new AdditionalFixedPayments(item);
                    }
                }
            }
            
        
        }
        
    
        #region FailureToPayPrincipal
        private XsdTypeBoolean failureToPayPrincipal;
        public XsdTypeBoolean FailureToPayPrincipal
        {
            get
            {
                if (this.failureToPayPrincipal != null)
                {
                    return this.failureToPayPrincipal; 
                }
                else if (this.failureToPayPrincipalIDRef != null)
                {
                    failureToPayPrincipal = IDManager.getID(failureToPayPrincipalIDRef) as XsdTypeBoolean;
                    return this.failureToPayPrincipal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToPayPrincipal != value)
                {
                    this.failureToPayPrincipal = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region InterestShortfall
        private InterestShortFall interestShortfall;
        public InterestShortFall InterestShortfall
        {
            get
            {
                if (this.interestShortfall != null)
                {
                    return this.interestShortfall; 
                }
                else if (this.interestShortfallIDRef != null)
                {
                    interestShortfall = IDManager.getID(interestShortfallIDRef) as InterestShortFall;
                    return this.interestShortfall; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestShortfall != value)
                {
                    this.interestShortfall = value;
                }
            }
        }
        #endregion
        
        public string InterestShortFallIDRef { get; set; }
        #region Writedown
        private XsdTypeBoolean writedown;
        public XsdTypeBoolean Writedown
        {
            get
            {
                if (this.writedown != null)
                {
                    return this.writedown; 
                }
                else if (this.writedownIDRef != null)
                {
                    writedown = IDManager.getID(writedownIDRef) as XsdTypeBoolean;
                    return this.writedown; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.writedown != value)
                {
                    this.writedown = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ImpliedWritedown
        private XsdTypeBoolean impliedWritedown;
        public XsdTypeBoolean ImpliedWritedown
        {
            get
            {
                if (this.impliedWritedown != null)
                {
                    return this.impliedWritedown; 
                }
                else if (this.impliedWritedownIDRef != null)
                {
                    impliedWritedown = IDManager.getID(impliedWritedownIDRef) as XsdTypeBoolean;
                    return this.impliedWritedown; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.impliedWritedown != value)
                {
                    this.impliedWritedown = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FloatingAmountProvisions
        private FloatingAmountProvisions floatingAmountProvisions;
        public FloatingAmountProvisions FloatingAmountProvisions
        {
            get
            {
                if (this.floatingAmountProvisions != null)
                {
                    return this.floatingAmountProvisions; 
                }
                else if (this.floatingAmountProvisionsIDRef != null)
                {
                    floatingAmountProvisions = IDManager.getID(floatingAmountProvisionsIDRef) as FloatingAmountProvisions;
                    return this.floatingAmountProvisions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingAmountProvisions != value)
                {
                    this.floatingAmountProvisions = value;
                }
            }
        }
        #endregion
        
        public string FloatingAmountProvisionsIDRef { get; set; }
        #region AdditionalFixedPayments
        private AdditionalFixedPayments additionalFixedPayments;
        public AdditionalFixedPayments AdditionalFixedPayments
        {
            get
            {
                if (this.additionalFixedPayments != null)
                {
                    return this.additionalFixedPayments; 
                }
                else if (this.additionalFixedPaymentsIDRef != null)
                {
                    additionalFixedPayments = IDManager.getID(additionalFixedPaymentsIDRef) as AdditionalFixedPayments;
                    return this.additionalFixedPayments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalFixedPayments != value)
                {
                    this.additionalFixedPayments = value;
                }
            }
        }
        #endregion
        
        public string AdditionalFixedPaymentsIDRef { get; set; }
        
    
        
    
    }
    
}


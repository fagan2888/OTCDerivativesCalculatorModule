using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PercentageRule
    {
        public PercentageRule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList paymentPercentNodeList = xmlNode.SelectNodes("paymentPercent");
            if (paymentPercentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentPercentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentPercentIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(paymentPercentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentPercentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentPercent = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList notionalAmountReferenceNodeList = xmlNode.SelectNodes("notionalAmountReference");
            if (notionalAmountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountReferenceIDRef = item.Attributes["id"].Name;
                        NotionalAmountReference ob = NotionalAmountReference();
                        IDManager.SetID(notionalAmountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmountReference = new NotionalAmountReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentPercent
        private XsdTypeDecimal paymentPercent;
        public XsdTypeDecimal PaymentPercent
        {
            get
            {
                if (this.paymentPercent != null)
                {
                    return this.paymentPercent; 
                }
                else if (this.paymentPercentIDRef != null)
                {
                    paymentPercent = IDManager.getID(paymentPercentIDRef) as XsdTypeDecimal;
                    return this.paymentPercent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentPercent != value)
                {
                    this.paymentPercent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region NotionalAmountReference
        private NotionalAmountReference notionalAmountReference;
        public NotionalAmountReference NotionalAmountReference
        {
            get
            {
                if (this.notionalAmountReference != null)
                {
                    return this.notionalAmountReference; 
                }
                else if (this.notionalAmountReferenceIDRef != null)
                {
                    notionalAmountReference = IDManager.getID(notionalAmountReferenceIDRef) as NotionalAmountReference;
                    return this.notionalAmountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmountReference != value)
                {
                    this.notionalAmountReference = value;
                }
            }
        }
        #endregion
        
        public string NotionalAmountReferenceIDRef { get; set; }
        
    
        
    
    }
    
}


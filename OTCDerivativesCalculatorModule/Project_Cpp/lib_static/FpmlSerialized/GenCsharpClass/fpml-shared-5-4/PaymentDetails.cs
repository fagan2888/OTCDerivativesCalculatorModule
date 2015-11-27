using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PaymentDetails
    {
        public PaymentDetails(XmlNode xmlNode)
        {
            XmlNodeList paymentReferenceNodeList = xmlNode.SelectNodes("paymentReference");
            if (paymentReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentReferenceIDRef = item.Attributes["id"].Name;
                        PaymentReference ob = PaymentReference();
                        IDManager.SetID(paymentReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentReference = new PaymentReference(item);
                    }
                }
            }
            
        
            XmlNodeList grossCashflowNodeList = xmlNode.SelectNodes("grossCashflow");
            
            foreach (XmlNode item in grossCashflowNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        grossCashflowIDRef = item.Attributes["id"].Name;
                        List<GrossCashflow> ob = new List<GrossCashflow>();
                        ob.Add(new GrossCashflow(item));
                        IDManager.SetID(grossCashflowIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        grossCashflowIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    grossCashflow.Add(new GrossCashflow(item));
                    }
                }
            }
            
        
            XmlNodeList settlementInformationNodeList = xmlNode.SelectNodes("settlementInformation");
            if (settlementInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef = item.Attributes["id"].Name;
                        SettlementInformation ob = SettlementInformation();
                        IDManager.SetID(settlementInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementInformation = new SettlementInformation(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentReference
        private PaymentReference paymentReference;
        public PaymentReference PaymentReference
        {
            get
            {
                if (this.paymentReference != null)
                {
                    return this.paymentReference; 
                }
                else if (this.paymentReferenceIDRef != null)
                {
                    paymentReference = IDManager.getID(paymentReferenceIDRef) as PaymentReference;
                    return this.paymentReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentReference != value)
                {
                    this.paymentReference = value;
                }
            }
        }
        #endregion
        
        public string PaymentReferenceIDRef { get; set; }
        #region GrossCashflow
        private List<GrossCashflow> grossCashflow;
        public List<GrossCashflow> GrossCashflow
        {
            get
            {
                if (this.grossCashflow != null)
                {
                    return this.grossCashflow; 
                }
                else if (this.grossCashflowIDRef != null)
                {
                    grossCashflow = IDManager.getID(grossCashflowIDRef) as List<GrossCashflow>;
                    return this.grossCashflow; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.grossCashflow != value)
                {
                    this.grossCashflow = value;
                }
            }
        }
        #endregion
        
        public string GrossCashflowIDRef { get; set; }
        #region SettlementInformation
        private SettlementInformation settlementInformation;
        public SettlementInformation SettlementInformation
        {
            get
            {
                if (this.settlementInformation != null)
                {
                    return this.settlementInformation; 
                }
                else if (this.settlementInformationIDRef != null)
                {
                    settlementInformation = IDManager.getID(settlementInformationIDRef) as SettlementInformation;
                    return this.settlementInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementInformation != value)
                {
                    this.settlementInformation = value;
                }
            }
        }
        #endregion
        
        public string SettlementInformationIDRef { get; set; }
        
    
        
    
    }
    
}


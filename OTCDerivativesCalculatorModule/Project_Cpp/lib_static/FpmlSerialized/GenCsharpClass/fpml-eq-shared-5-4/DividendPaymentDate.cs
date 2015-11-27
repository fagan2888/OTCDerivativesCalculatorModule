using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendPaymentDate
    {
        public DividendPaymentDate(XmlNode xmlNode)
        {
            XmlNodeList dividendDateReferenceNodeList = xmlNode.SelectNodes("dividendDateReference");
            if (dividendDateReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendDateReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendDateReferenceIDRef = item.Attributes["id"].Name;
                        DividendDateReferenceEnum ob = DividendDateReferenceEnum();
                        IDManager.SetID(dividendDateReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendDateReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendDateReference = new DividendDateReferenceEnum(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDateOffsetNodeList = xmlNode.SelectNodes("paymentDateOffset");
            if (paymentDateOffsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateOffsetIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(paymentDateOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDateOffset = new Offset(item);
                    }
                }
            }
            
        
            XmlNodeList adjustableDateNodeList = xmlNode.SelectNodes("adjustableDate");
            if (adjustableDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustableDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustableDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(adjustableDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustableDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustableDate = new AdjustableDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region DividendDateReference
        private DividendDateReferenceEnum dividendDateReference;
        public DividendDateReferenceEnum DividendDateReference
        {
            get
            {
                if (this.dividendDateReference != null)
                {
                    return this.dividendDateReference; 
                }
                else if (this.dividendDateReferenceIDRef != null)
                {
                    dividendDateReference = IDManager.getID(dividendDateReferenceIDRef) as DividendDateReferenceEnum;
                    return this.dividendDateReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendDateReference != value)
                {
                    this.dividendDateReference = value;
                }
            }
        }
        #endregion
        
        public string DividendDateReferenceEnumIDRef { get; set; }
        #region PaymentDateOffset
        private Offset paymentDateOffset;
        public Offset PaymentDateOffset
        {
            get
            {
                if (this.paymentDateOffset != null)
                {
                    return this.paymentDateOffset; 
                }
                else if (this.paymentDateOffsetIDRef != null)
                {
                    paymentDateOffset = IDManager.getID(paymentDateOffsetIDRef) as Offset;
                    return this.paymentDateOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDateOffset != value)
                {
                    this.paymentDateOffset = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        #region AdjustableDate
        private AdjustableDate adjustableDate;
        public AdjustableDate AdjustableDate
        {
            get
            {
                if (this.adjustableDate != null)
                {
                    return this.adjustableDate; 
                }
                else if (this.adjustableDateIDRef != null)
                {
                    adjustableDate = IDManager.getID(adjustableDateIDRef) as AdjustableDate;
                    return this.adjustableDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustableDate != value)
                {
                    this.adjustableDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


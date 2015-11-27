using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapPaymentDates
    {
        public ReturnSwapPaymentDates(XmlNode xmlNode)
        {
            XmlNodeList paymentDatesInterimNodeList = xmlNode.SelectNodes("paymentDatesInterim");
            if (paymentDatesInterimNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesInterimNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesInterimIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDates ob = AdjustableOrRelativeDates();
                        IDManager.SetID(paymentDatesInterimIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesInterimIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDatesInterim = new AdjustableOrRelativeDates(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDateFinalNodeList = xmlNode.SelectNodes("paymentDateFinal");
            if (paymentDateFinalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateFinalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateFinalIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(paymentDateFinalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateFinalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDateFinal = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentDatesInterim
        private AdjustableOrRelativeDates paymentDatesInterim;
        public AdjustableOrRelativeDates PaymentDatesInterim
        {
            get
            {
                if (this.paymentDatesInterim != null)
                {
                    return this.paymentDatesInterim; 
                }
                else if (this.paymentDatesInterimIDRef != null)
                {
                    paymentDatesInterim = IDManager.getID(paymentDatesInterimIDRef) as AdjustableOrRelativeDates;
                    return this.paymentDatesInterim; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDatesInterim != value)
                {
                    this.paymentDatesInterim = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDatesIDRef { get; set; }
        #region PaymentDateFinal
        private AdjustableOrRelativeDate paymentDateFinal;
        public AdjustableOrRelativeDate PaymentDateFinal
        {
            get
            {
                if (this.paymentDateFinal != null)
                {
                    return this.paymentDateFinal; 
                }
                else if (this.paymentDateFinalIDRef != null)
                {
                    paymentDateFinal = IDManager.getID(paymentDateFinalIDRef) as AdjustableOrRelativeDate;
                    return this.paymentDateFinal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDateFinal != value)
                {
                    this.paymentDateFinal = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        
    
        
    
    }
    
}


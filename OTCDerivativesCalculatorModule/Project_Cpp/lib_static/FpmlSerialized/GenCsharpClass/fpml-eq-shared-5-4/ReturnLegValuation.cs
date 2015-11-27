using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnLegValuation
    {
        public ReturnLegValuation(XmlNode xmlNode)
        {
            XmlNodeList initialPriceNodeList = xmlNode.SelectNodes("initialPrice");
            if (initialPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialPriceIDRef = item.Attributes["id"].Name;
                        ReturnLegValuationPrice ob = ReturnLegValuationPrice();
                        IDManager.SetID(initialPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialPrice = new ReturnLegValuationPrice(item);
                    }
                }
            }
            
        
            XmlNodeList notionalResetNodeList = xmlNode.SelectNodes("notionalReset");
            if (notionalResetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalResetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalResetIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notionalResetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalResetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalReset = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList valuationPriceInterimNodeList = xmlNode.SelectNodes("valuationPriceInterim");
            if (valuationPriceInterimNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationPriceInterimNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationPriceInterimIDRef = item.Attributes["id"].Name;
                        ReturnLegValuationPrice ob = ReturnLegValuationPrice();
                        IDManager.SetID(valuationPriceInterimIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationPriceInterimIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationPriceInterim = new ReturnLegValuationPrice(item);
                    }
                }
            }
            
        
            XmlNodeList valuationPriceFinalNodeList = xmlNode.SelectNodes("valuationPriceFinal");
            if (valuationPriceFinalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationPriceFinalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationPriceFinalIDRef = item.Attributes["id"].Name;
                        ReturnLegValuationPrice ob = ReturnLegValuationPrice();
                        IDManager.SetID(valuationPriceFinalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationPriceFinalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationPriceFinal = new ReturnLegValuationPrice(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesNodeList = xmlNode.SelectNodes("paymentDates");
            if (paymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef = item.Attributes["id"].Name;
                        ReturnSwapPaymentDates ob = ReturnSwapPaymentDates();
                        IDManager.SetID(paymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDates = new ReturnSwapPaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeTradedContractNearestNodeList = xmlNode.SelectNodes("exchangeTradedContractNearest");
            if (exchangeTradedContractNearestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeTradedContractNearestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeTradedContractNearestIDRef = item.Attributes["id"].Name;
                        ExchangeTradedContract ob = ExchangeTradedContract();
                        IDManager.SetID(exchangeTradedContractNearestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeTradedContractNearestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeTradedContractNearest = new ExchangeTradedContract(item);
                    }
                }
            }
            
        
        }
        
    
        #region InitialPrice
        private ReturnLegValuationPrice initialPrice;
        public ReturnLegValuationPrice InitialPrice
        {
            get
            {
                if (this.initialPrice != null)
                {
                    return this.initialPrice; 
                }
                else if (this.initialPriceIDRef != null)
                {
                    initialPrice = IDManager.getID(initialPriceIDRef) as ReturnLegValuationPrice;
                    return this.initialPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialPrice != value)
                {
                    this.initialPrice = value;
                }
            }
        }
        #endregion
        
        public string ReturnLegValuationPriceIDRef { get; set; }
        #region NotionalReset
        private XsdTypeBoolean notionalReset;
        public XsdTypeBoolean NotionalReset
        {
            get
            {
                if (this.notionalReset != null)
                {
                    return this.notionalReset; 
                }
                else if (this.notionalResetIDRef != null)
                {
                    notionalReset = IDManager.getID(notionalResetIDRef) as XsdTypeBoolean;
                    return this.notionalReset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalReset != value)
                {
                    this.notionalReset = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ValuationPriceInterim
        private ReturnLegValuationPrice valuationPriceInterim;
        public ReturnLegValuationPrice ValuationPriceInterim
        {
            get
            {
                if (this.valuationPriceInterim != null)
                {
                    return this.valuationPriceInterim; 
                }
                else if (this.valuationPriceInterimIDRef != null)
                {
                    valuationPriceInterim = IDManager.getID(valuationPriceInterimIDRef) as ReturnLegValuationPrice;
                    return this.valuationPriceInterim; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationPriceInterim != value)
                {
                    this.valuationPriceInterim = value;
                }
            }
        }
        #endregion
        
        public string ReturnLegValuationPriceIDRef { get; set; }
        #region ValuationPriceFinal
        private ReturnLegValuationPrice valuationPriceFinal;
        public ReturnLegValuationPrice ValuationPriceFinal
        {
            get
            {
                if (this.valuationPriceFinal != null)
                {
                    return this.valuationPriceFinal; 
                }
                else if (this.valuationPriceFinalIDRef != null)
                {
                    valuationPriceFinal = IDManager.getID(valuationPriceFinalIDRef) as ReturnLegValuationPrice;
                    return this.valuationPriceFinal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationPriceFinal != value)
                {
                    this.valuationPriceFinal = value;
                }
            }
        }
        #endregion
        
        public string ReturnLegValuationPriceIDRef { get; set; }
        #region PaymentDates
        private ReturnSwapPaymentDates paymentDates;
        public ReturnSwapPaymentDates PaymentDates
        {
            get
            {
                if (this.paymentDates != null)
                {
                    return this.paymentDates; 
                }
                else if (this.paymentDatesIDRef != null)
                {
                    paymentDates = IDManager.getID(paymentDatesIDRef) as ReturnSwapPaymentDates;
                    return this.paymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDates != value)
                {
                    this.paymentDates = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapPaymentDatesIDRef { get; set; }
        #region ExchangeTradedContractNearest
        private ExchangeTradedContract exchangeTradedContractNearest;
        public ExchangeTradedContract ExchangeTradedContractNearest
        {
            get
            {
                if (this.exchangeTradedContractNearest != null)
                {
                    return this.exchangeTradedContractNearest; 
                }
                else if (this.exchangeTradedContractNearestIDRef != null)
                {
                    exchangeTradedContractNearest = IDManager.getID(exchangeTradedContractNearestIDRef) as ExchangeTradedContract;
                    return this.exchangeTradedContractNearest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeTradedContractNearest != value)
                {
                    this.exchangeTradedContractNearest = value;
                }
            }
        }
        #endregion
        
        public string ExchangeTradedContractIDRef { get; set; }
        
    
        
    
    }
    
}


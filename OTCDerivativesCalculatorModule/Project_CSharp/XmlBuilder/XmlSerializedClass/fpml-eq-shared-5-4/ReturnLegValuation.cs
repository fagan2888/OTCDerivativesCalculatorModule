using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnLegValuation : ISerialized
    {
        public ReturnLegValuation(XmlNode xmlNode)
        {
            XmlNode initialPriceNode = xmlNode.SelectSingleNode("initialPrice");
            
            if (initialPriceNode != null)
            {
                if (initialPriceNode.Attributes["href"] != null || initialPriceNode.Attributes["id"] != null) 
                {
                    if (initialPriceNode.Attributes["id"] != null) 
                    {
                        initialPriceIDRef_ = initialPriceNode.Attributes["id"].Value;
                        ReturnLegValuationPrice ob = new ReturnLegValuationPrice(initialPriceNode);
                        IDManager.SetID(initialPriceIDRef_, ob);
                    }
                    else if (initialPriceNode.Attributes["href"] != null)
                    {
                        initialPriceIDRef_ = initialPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialPrice_ = new ReturnLegValuationPrice(initialPriceNode);
                    }
                }
                else
                {
                    initialPrice_ = new ReturnLegValuationPrice(initialPriceNode);
                }
            }
            
        
            XmlNode notionalResetNode = xmlNode.SelectSingleNode("notionalReset");
            
            if (notionalResetNode != null)
            {
                if (notionalResetNode.Attributes["href"] != null || notionalResetNode.Attributes["id"] != null) 
                {
                    if (notionalResetNode.Attributes["id"] != null) 
                    {
                        notionalResetIDRef_ = notionalResetNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(notionalResetNode);
                        IDManager.SetID(notionalResetIDRef_, ob);
                    }
                    else if (notionalResetNode.Attributes["href"] != null)
                    {
                        notionalResetIDRef_ = notionalResetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalReset_ = new XsdTypeBoolean(notionalResetNode);
                    }
                }
                else
                {
                    notionalReset_ = new XsdTypeBoolean(notionalResetNode);
                }
            }
            
        
            XmlNode valuationPriceInterimNode = xmlNode.SelectSingleNode("valuationPriceInterim");
            
            if (valuationPriceInterimNode != null)
            {
                if (valuationPriceInterimNode.Attributes["href"] != null || valuationPriceInterimNode.Attributes["id"] != null) 
                {
                    if (valuationPriceInterimNode.Attributes["id"] != null) 
                    {
                        valuationPriceInterimIDRef_ = valuationPriceInterimNode.Attributes["id"].Value;
                        ReturnLegValuationPrice ob = new ReturnLegValuationPrice(valuationPriceInterimNode);
                        IDManager.SetID(valuationPriceInterimIDRef_, ob);
                    }
                    else if (valuationPriceInterimNode.Attributes["href"] != null)
                    {
                        valuationPriceInterimIDRef_ = valuationPriceInterimNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationPriceInterim_ = new ReturnLegValuationPrice(valuationPriceInterimNode);
                    }
                }
                else
                {
                    valuationPriceInterim_ = new ReturnLegValuationPrice(valuationPriceInterimNode);
                }
            }
            
        
            XmlNode valuationPriceFinalNode = xmlNode.SelectSingleNode("valuationPriceFinal");
            
            if (valuationPriceFinalNode != null)
            {
                if (valuationPriceFinalNode.Attributes["href"] != null || valuationPriceFinalNode.Attributes["id"] != null) 
                {
                    if (valuationPriceFinalNode.Attributes["id"] != null) 
                    {
                        valuationPriceFinalIDRef_ = valuationPriceFinalNode.Attributes["id"].Value;
                        ReturnLegValuationPrice ob = new ReturnLegValuationPrice(valuationPriceFinalNode);
                        IDManager.SetID(valuationPriceFinalIDRef_, ob);
                    }
                    else if (valuationPriceFinalNode.Attributes["href"] != null)
                    {
                        valuationPriceFinalIDRef_ = valuationPriceFinalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationPriceFinal_ = new ReturnLegValuationPrice(valuationPriceFinalNode);
                    }
                }
                else
                {
                    valuationPriceFinal_ = new ReturnLegValuationPrice(valuationPriceFinalNode);
                }
            }
            
        
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        ReturnSwapPaymentDates ob = new ReturnSwapPaymentDates(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new ReturnSwapPaymentDates(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new ReturnSwapPaymentDates(paymentDatesNode);
                }
            }
            
        
            XmlNode exchangeTradedContractNearestNode = xmlNode.SelectSingleNode("exchangeTradedContractNearest");
            
            if (exchangeTradedContractNearestNode != null)
            {
                if (exchangeTradedContractNearestNode.Attributes["href"] != null || exchangeTradedContractNearestNode.Attributes["id"] != null) 
                {
                    if (exchangeTradedContractNearestNode.Attributes["id"] != null) 
                    {
                        exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode.Attributes["id"].Value;
                        ExchangeTradedContract ob = new ExchangeTradedContract(exchangeTradedContractNearestNode);
                        IDManager.SetID(exchangeTradedContractNearestIDRef_, ob);
                    }
                    else if (exchangeTradedContractNearestNode.Attributes["href"] != null)
                    {
                        exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeTradedContractNearest_ = new ExchangeTradedContract(exchangeTradedContractNearestNode);
                    }
                }
                else
                {
                    exchangeTradedContractNearest_ = new ExchangeTradedContract(exchangeTradedContractNearestNode);
                }
            }
            
        
        }
        
    
        #region InitialPrice_
        private ReturnLegValuationPrice initialPrice_;
        public ReturnLegValuationPrice InitialPrice_
        {
            get
            {
                if (this.initialPrice_ != null)
                {
                    return this.initialPrice_; 
                }
                else if (this.initialPriceIDRef_ != null)
                {
                    initialPrice_ = IDManager.getID(initialPriceIDRef_) as ReturnLegValuationPrice;
                    return this.initialPrice_; 
                }
                else
                {
                      return this.initialPrice_; 
                }
            }
            set
            {
                if (this.initialPrice_ != value)
                {
                    this.initialPrice_ = value;
                }
            }
        }
        #endregion
        
        public string initialPriceIDRef_ { get; set; }
        #region NotionalReset_
        private XsdTypeBoolean notionalReset_;
        public XsdTypeBoolean NotionalReset_
        {
            get
            {
                if (this.notionalReset_ != null)
                {
                    return this.notionalReset_; 
                }
                else if (this.notionalResetIDRef_ != null)
                {
                    notionalReset_ = IDManager.getID(notionalResetIDRef_) as XsdTypeBoolean;
                    return this.notionalReset_; 
                }
                else
                {
                      return this.notionalReset_; 
                }
            }
            set
            {
                if (this.notionalReset_ != value)
                {
                    this.notionalReset_ = value;
                }
            }
        }
        #endregion
        
        public string notionalResetIDRef_ { get; set; }
        #region ValuationPriceInterim_
        private ReturnLegValuationPrice valuationPriceInterim_;
        public ReturnLegValuationPrice ValuationPriceInterim_
        {
            get
            {
                if (this.valuationPriceInterim_ != null)
                {
                    return this.valuationPriceInterim_; 
                }
                else if (this.valuationPriceInterimIDRef_ != null)
                {
                    valuationPriceInterim_ = IDManager.getID(valuationPriceInterimIDRef_) as ReturnLegValuationPrice;
                    return this.valuationPriceInterim_; 
                }
                else
                {
                      return this.valuationPriceInterim_; 
                }
            }
            set
            {
                if (this.valuationPriceInterim_ != value)
                {
                    this.valuationPriceInterim_ = value;
                }
            }
        }
        #endregion
        
        public string valuationPriceInterimIDRef_ { get; set; }
        #region ValuationPriceFinal_
        private ReturnLegValuationPrice valuationPriceFinal_;
        public ReturnLegValuationPrice ValuationPriceFinal_
        {
            get
            {
                if (this.valuationPriceFinal_ != null)
                {
                    return this.valuationPriceFinal_; 
                }
                else if (this.valuationPriceFinalIDRef_ != null)
                {
                    valuationPriceFinal_ = IDManager.getID(valuationPriceFinalIDRef_) as ReturnLegValuationPrice;
                    return this.valuationPriceFinal_; 
                }
                else
                {
                      return this.valuationPriceFinal_; 
                }
            }
            set
            {
                if (this.valuationPriceFinal_ != value)
                {
                    this.valuationPriceFinal_ = value;
                }
            }
        }
        #endregion
        
        public string valuationPriceFinalIDRef_ { get; set; }
        #region PaymentDates_
        private ReturnSwapPaymentDates paymentDates_;
        public ReturnSwapPaymentDates PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as ReturnSwapPaymentDates;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region ExchangeTradedContractNearest_
        private ExchangeTradedContract exchangeTradedContractNearest_;
        public ExchangeTradedContract ExchangeTradedContractNearest_
        {
            get
            {
                if (this.exchangeTradedContractNearest_ != null)
                {
                    return this.exchangeTradedContractNearest_; 
                }
                else if (this.exchangeTradedContractNearestIDRef_ != null)
                {
                    exchangeTradedContractNearest_ = IDManager.getID(exchangeTradedContractNearestIDRef_) as ExchangeTradedContract;
                    return this.exchangeTradedContractNearest_; 
                }
                else
                {
                      return this.exchangeTradedContractNearest_; 
                }
            }
            set
            {
                if (this.exchangeTradedContractNearest_ != value)
                {
                    this.exchangeTradedContractNearest_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeTradedContractNearestIDRef_ { get; set; }
        
    
        
    
    }
    
}


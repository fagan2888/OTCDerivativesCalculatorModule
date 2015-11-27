using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FeeLeg : Leg
    {
        public FeeLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode initialPaymentNode = xmlNode.SelectSingleNode("initialPayment");
            
            if (initialPaymentNode != null)
            {
                if (initialPaymentNode.Attributes["href"] != null || initialPaymentNode.Attributes["id"] != null) 
                {
                    if (initialPaymentNode.Attributes["id"] != null) 
                    {
                        initialPaymentIDRef_ = initialPaymentNode.Attributes["id"].Value;
                        InitialPayment ob = new InitialPayment(initialPaymentNode);
                        IDManager.SetID(initialPaymentIDRef_, ob);
                    }
                    else if (initialPaymentNode.Attributes["href"] != null)
                    {
                        initialPaymentIDRef_ = initialPaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialPayment_ = new InitialPayment(initialPaymentNode);
                    }
                }
                else
                {
                    initialPayment_ = new InitialPayment(initialPaymentNode);
                }
            }
            
        
            XmlNodeList singlePaymentNodeList = xmlNode.SelectNodes("singlePayment");
            
            if (singlePaymentNodeList != null)
            {
                this.singlePayment_ = new List<SinglePayment>();
                foreach (XmlNode item in singlePaymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            singlePaymentIDRef_ = item.Attributes["id"].Value;
                            singlePayment_.Add(new SinglePayment(item));
                            IDManager.SetID(singlePaymentIDRef_, singlePayment_[singlePayment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            singlePaymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        singlePayment_.Add(new SinglePayment(item));
                        }
                    }
                    else
                    {
                        singlePayment_.Add(new SinglePayment(item));
                    }
                }
            }
            
        
            XmlNode periodicPaymentNode = xmlNode.SelectSingleNode("periodicPayment");
            
            if (periodicPaymentNode != null)
            {
                if (periodicPaymentNode.Attributes["href"] != null || periodicPaymentNode.Attributes["id"] != null) 
                {
                    if (periodicPaymentNode.Attributes["id"] != null) 
                    {
                        periodicPaymentIDRef_ = periodicPaymentNode.Attributes["id"].Value;
                        PeriodicPayment ob = new PeriodicPayment(periodicPaymentNode);
                        IDManager.SetID(periodicPaymentIDRef_, ob);
                    }
                    else if (periodicPaymentNode.Attributes["href"] != null)
                    {
                        periodicPaymentIDRef_ = periodicPaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodicPayment_ = new PeriodicPayment(periodicPaymentNode);
                    }
                }
                else
                {
                    periodicPayment_ = new PeriodicPayment(periodicPaymentNode);
                }
            }
            
        
            XmlNode marketFixedRateNode = xmlNode.SelectSingleNode("marketFixedRate");
            
            if (marketFixedRateNode != null)
            {
                if (marketFixedRateNode.Attributes["href"] != null || marketFixedRateNode.Attributes["id"] != null) 
                {
                    if (marketFixedRateNode.Attributes["id"] != null) 
                    {
                        marketFixedRateIDRef_ = marketFixedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(marketFixedRateNode);
                        IDManager.SetID(marketFixedRateIDRef_, ob);
                    }
                    else if (marketFixedRateNode.Attributes["href"] != null)
                    {
                        marketFixedRateIDRef_ = marketFixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketFixedRate_ = new XsdTypeDecimal(marketFixedRateNode);
                    }
                }
                else
                {
                    marketFixedRate_ = new XsdTypeDecimal(marketFixedRateNode);
                }
            }
            
        
            XmlNode paymentDelayNode = xmlNode.SelectSingleNode("paymentDelay");
            
            if (paymentDelayNode != null)
            {
                if (paymentDelayNode.Attributes["href"] != null || paymentDelayNode.Attributes["id"] != null) 
                {
                    if (paymentDelayNode.Attributes["id"] != null) 
                    {
                        paymentDelayIDRef_ = paymentDelayNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(paymentDelayNode);
                        IDManager.SetID(paymentDelayIDRef_, ob);
                    }
                    else if (paymentDelayNode.Attributes["href"] != null)
                    {
                        paymentDelayIDRef_ = paymentDelayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDelay_ = new XsdTypeBoolean(paymentDelayNode);
                    }
                }
                else
                {
                    paymentDelay_ = new XsdTypeBoolean(paymentDelayNode);
                }
            }
            
        
            XmlNode initialPointsNode = xmlNode.SelectSingleNode("initialPoints");
            
            if (initialPointsNode != null)
            {
                if (initialPointsNode.Attributes["href"] != null || initialPointsNode.Attributes["id"] != null) 
                {
                    if (initialPointsNode.Attributes["id"] != null) 
                    {
                        initialPointsIDRef_ = initialPointsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(initialPointsNode);
                        IDManager.SetID(initialPointsIDRef_, ob);
                    }
                    else if (initialPointsNode.Attributes["href"] != null)
                    {
                        initialPointsIDRef_ = initialPointsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialPoints_ = new XsdTypeDecimal(initialPointsNode);
                    }
                }
                else
                {
                    initialPoints_ = new XsdTypeDecimal(initialPointsNode);
                }
            }
            
        
            XmlNode quotationStyleNode = xmlNode.SelectSingleNode("quotationStyle");
            
            if (quotationStyleNode != null)
            {
                if (quotationStyleNode.Attributes["href"] != null || quotationStyleNode.Attributes["id"] != null) 
                {
                    if (quotationStyleNode.Attributes["id"] != null) 
                    {
                        quotationStyleIDRef_ = quotationStyleNode.Attributes["id"].Value;
                        QuotationStyleEnum ob = new QuotationStyleEnum(quotationStyleNode);
                        IDManager.SetID(quotationStyleIDRef_, ob);
                    }
                    else if (quotationStyleNode.Attributes["href"] != null)
                    {
                        quotationStyleIDRef_ = quotationStyleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotationStyle_ = new QuotationStyleEnum(quotationStyleNode);
                    }
                }
                else
                {
                    quotationStyle_ = new QuotationStyleEnum(quotationStyleNode);
                }
            }
            
        
        }
        
    
        #region InitialPayment_
        private InitialPayment initialPayment_;
        public InitialPayment InitialPayment_
        {
            get
            {
                if (this.initialPayment_ != null)
                {
                    return this.initialPayment_; 
                }
                else if (this.initialPaymentIDRef_ != null)
                {
                    initialPayment_ = IDManager.getID(initialPaymentIDRef_) as InitialPayment;
                    return this.initialPayment_; 
                }
                else
                {
                      return this.initialPayment_; 
                }
            }
            set
            {
                if (this.initialPayment_ != value)
                {
                    this.initialPayment_ = value;
                }
            }
        }
        #endregion
        
        public string initialPaymentIDRef_ { get; set; }
        #region SinglePayment_
        private List<SinglePayment> singlePayment_;
        public List<SinglePayment> SinglePayment_
        {
            get
            {
                if (this.singlePayment_ != null)
                {
                    return this.singlePayment_; 
                }
                else if (this.singlePaymentIDRef_ != null)
                {
                    return this.singlePayment_; 
                }
                else
                {
                      return this.singlePayment_; 
                }
            }
            set
            {
                if (this.singlePayment_ != value)
                {
                    this.singlePayment_ = value;
                }
            }
        }
        #endregion
        
        public string singlePaymentIDRef_ { get; set; }
        #region PeriodicPayment_
        private PeriodicPayment periodicPayment_;
        public PeriodicPayment PeriodicPayment_
        {
            get
            {
                if (this.periodicPayment_ != null)
                {
                    return this.periodicPayment_; 
                }
                else if (this.periodicPaymentIDRef_ != null)
                {
                    periodicPayment_ = IDManager.getID(periodicPaymentIDRef_) as PeriodicPayment;
                    return this.periodicPayment_; 
                }
                else
                {
                      return this.periodicPayment_; 
                }
            }
            set
            {
                if (this.periodicPayment_ != value)
                {
                    this.periodicPayment_ = value;
                }
            }
        }
        #endregion
        
        public string periodicPaymentIDRef_ { get; set; }
        #region MarketFixedRate_
        private XsdTypeDecimal marketFixedRate_;
        public XsdTypeDecimal MarketFixedRate_
        {
            get
            {
                if (this.marketFixedRate_ != null)
                {
                    return this.marketFixedRate_; 
                }
                else if (this.marketFixedRateIDRef_ != null)
                {
                    marketFixedRate_ = IDManager.getID(marketFixedRateIDRef_) as XsdTypeDecimal;
                    return this.marketFixedRate_; 
                }
                else
                {
                      return this.marketFixedRate_; 
                }
            }
            set
            {
                if (this.marketFixedRate_ != value)
                {
                    this.marketFixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string marketFixedRateIDRef_ { get; set; }
        #region PaymentDelay_
        private XsdTypeBoolean paymentDelay_;
        public XsdTypeBoolean PaymentDelay_
        {
            get
            {
                if (this.paymentDelay_ != null)
                {
                    return this.paymentDelay_; 
                }
                else if (this.paymentDelayIDRef_ != null)
                {
                    paymentDelay_ = IDManager.getID(paymentDelayIDRef_) as XsdTypeBoolean;
                    return this.paymentDelay_; 
                }
                else
                {
                      return this.paymentDelay_; 
                }
            }
            set
            {
                if (this.paymentDelay_ != value)
                {
                    this.paymentDelay_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDelayIDRef_ { get; set; }
        #region InitialPoints_
        private XsdTypeDecimal initialPoints_;
        public XsdTypeDecimal InitialPoints_
        {
            get
            {
                if (this.initialPoints_ != null)
                {
                    return this.initialPoints_; 
                }
                else if (this.initialPointsIDRef_ != null)
                {
                    initialPoints_ = IDManager.getID(initialPointsIDRef_) as XsdTypeDecimal;
                    return this.initialPoints_; 
                }
                else
                {
                      return this.initialPoints_; 
                }
            }
            set
            {
                if (this.initialPoints_ != value)
                {
                    this.initialPoints_ = value;
                }
            }
        }
        #endregion
        
        public string initialPointsIDRef_ { get; set; }
        #region QuotationStyle_
        private QuotationStyleEnum quotationStyle_;
        public QuotationStyleEnum QuotationStyle_
        {
            get
            {
                if (this.quotationStyle_ != null)
                {
                    return this.quotationStyle_; 
                }
                else if (this.quotationStyleIDRef_ != null)
                {
                    quotationStyle_ = IDManager.getID(quotationStyleIDRef_) as QuotationStyleEnum;
                    return this.quotationStyle_; 
                }
                else
                {
                      return this.quotationStyle_; 
                }
            }
            set
            {
                if (this.quotationStyle_ != value)
                {
                    this.quotationStyle_ = value;
                }
            }
        }
        #endregion
        
        public string quotationStyleIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FeeLeg
    {
        public FeeLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList initialPaymentNodeList = xmlNode.SelectNodes("initialPayment");
            if (initialPaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialPaymentIDRef = item.Attributes["id"].Name;
                        InitialPayment ob = InitialPayment();
                        IDManager.SetID(initialPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialPayment = new InitialPayment(item);
                    }
                }
            }
            
        
            XmlNodeList singlePaymentNodeList = xmlNode.SelectNodes("singlePayment");
            
            foreach (XmlNode item in singlePaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        singlePaymentIDRef = item.Attributes["id"].Name;
                        List<SinglePayment> ob = new List<SinglePayment>();
                        ob.Add(new SinglePayment(item));
                        IDManager.SetID(singlePaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        singlePaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    singlePayment.Add(new SinglePayment(item));
                    }
                }
            }
            
        
            XmlNodeList periodicPaymentNodeList = xmlNode.SelectNodes("periodicPayment");
            if (periodicPaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodicPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodicPaymentIDRef = item.Attributes["id"].Name;
                        PeriodicPayment ob = PeriodicPayment();
                        IDManager.SetID(periodicPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodicPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodicPayment = new PeriodicPayment(item);
                    }
                }
            }
            
        
            XmlNodeList marketFixedRateNodeList = xmlNode.SelectNodes("marketFixedRate");
            if (marketFixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketFixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketFixedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(marketFixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketFixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketFixedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDelayNodeList = xmlNode.SelectNodes("paymentDelay");
            if (paymentDelayNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDelayNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDelayIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(paymentDelayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDelayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDelay = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList initialPointsNodeList = xmlNode.SelectNodes("initialPoints");
            if (initialPointsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialPointsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialPointsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialPointsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialPointsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialPoints = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList quotationStyleNodeList = xmlNode.SelectNodes("quotationStyle");
            if (quotationStyleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotationStyleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotationStyleIDRef = item.Attributes["id"].Name;
                        QuotationStyleEnum ob = QuotationStyleEnum();
                        IDManager.SetID(quotationStyleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotationStyleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotationStyle = new QuotationStyleEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region InitialPayment
        private InitialPayment initialPayment;
        public InitialPayment InitialPayment
        {
            get
            {
                if (this.initialPayment != null)
                {
                    return this.initialPayment; 
                }
                else if (this.initialPaymentIDRef != null)
                {
                    initialPayment = IDManager.getID(initialPaymentIDRef) as InitialPayment;
                    return this.initialPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialPayment != value)
                {
                    this.initialPayment = value;
                }
            }
        }
        #endregion
        
        public string InitialPaymentIDRef { get; set; }
        #region SinglePayment
        private List<SinglePayment> singlePayment;
        public List<SinglePayment> SinglePayment
        {
            get
            {
                if (this.singlePayment != null)
                {
                    return this.singlePayment; 
                }
                else if (this.singlePaymentIDRef != null)
                {
                    singlePayment = IDManager.getID(singlePaymentIDRef) as List<SinglePayment>;
                    return this.singlePayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.singlePayment != value)
                {
                    this.singlePayment = value;
                }
            }
        }
        #endregion
        
        public string SinglePaymentIDRef { get; set; }
        #region PeriodicPayment
        private PeriodicPayment periodicPayment;
        public PeriodicPayment PeriodicPayment
        {
            get
            {
                if (this.periodicPayment != null)
                {
                    return this.periodicPayment; 
                }
                else if (this.periodicPaymentIDRef != null)
                {
                    periodicPayment = IDManager.getID(periodicPaymentIDRef) as PeriodicPayment;
                    return this.periodicPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periodicPayment != value)
                {
                    this.periodicPayment = value;
                }
            }
        }
        #endregion
        
        public string PeriodicPaymentIDRef { get; set; }
        #region MarketFixedRate
        private XsdTypeDecimal marketFixedRate;
        public XsdTypeDecimal MarketFixedRate
        {
            get
            {
                if (this.marketFixedRate != null)
                {
                    return this.marketFixedRate; 
                }
                else if (this.marketFixedRateIDRef != null)
                {
                    marketFixedRate = IDManager.getID(marketFixedRateIDRef) as XsdTypeDecimal;
                    return this.marketFixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketFixedRate != value)
                {
                    this.marketFixedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PaymentDelay
        private XsdTypeBoolean paymentDelay;
        public XsdTypeBoolean PaymentDelay
        {
            get
            {
                if (this.paymentDelay != null)
                {
                    return this.paymentDelay; 
                }
                else if (this.paymentDelayIDRef != null)
                {
                    paymentDelay = IDManager.getID(paymentDelayIDRef) as XsdTypeBoolean;
                    return this.paymentDelay; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDelay != value)
                {
                    this.paymentDelay = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region InitialPoints
        private XsdTypeDecimal initialPoints;
        public XsdTypeDecimal InitialPoints
        {
            get
            {
                if (this.initialPoints != null)
                {
                    return this.initialPoints; 
                }
                else if (this.initialPointsIDRef != null)
                {
                    initialPoints = IDManager.getID(initialPointsIDRef) as XsdTypeDecimal;
                    return this.initialPoints; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialPoints != value)
                {
                    this.initialPoints = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region QuotationStyle
        private QuotationStyleEnum quotationStyle;
        public QuotationStyleEnum QuotationStyle
        {
            get
            {
                if (this.quotationStyle != null)
                {
                    return this.quotationStyle; 
                }
                else if (this.quotationStyleIDRef != null)
                {
                    quotationStyle = IDManager.getID(quotationStyleIDRef) as QuotationStyleEnum;
                    return this.quotationStyle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotationStyle != value)
                {
                    this.quotationStyle = value;
                }
            }
        }
        #endregion
        
        public string QuotationStyleEnumIDRef { get; set; }
        
    
        
    
    }
    
}


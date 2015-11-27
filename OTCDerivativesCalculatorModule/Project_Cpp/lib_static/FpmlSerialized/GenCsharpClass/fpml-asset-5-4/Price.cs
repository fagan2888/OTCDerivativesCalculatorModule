using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Price
    {
        public Price(XmlNode xmlNode)
        {
            XmlNodeList commissionNodeList = xmlNode.SelectNodes("commission");
            if (commissionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commissionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commissionIDRef = item.Attributes["id"].Name;
                        Commission ob = Commission();
                        IDManager.SetID(commissionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commissionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commission = new Commission(item);
                    }
                }
            }
            
        
            XmlNodeList determinationMethodNodeList = xmlNode.SelectNodes("determinationMethod");
            if (determinationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determinationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(determinationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determinationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determinationMethod = new DeterminationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList grossPriceNodeList = xmlNode.SelectNodes("grossPrice");
            if (grossPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in grossPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        grossPriceIDRef = item.Attributes["id"].Name;
                        ActualPrice ob = ActualPrice();
                        IDManager.SetID(grossPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        grossPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        grossPrice = new ActualPrice(item);
                    }
                }
            }
            
        
            XmlNodeList netPriceNodeList = xmlNode.SelectNodes("netPrice");
            if (netPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in netPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        netPriceIDRef = item.Attributes["id"].Name;
                        ActualPrice ob = ActualPrice();
                        IDManager.SetID(netPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        netPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        netPrice = new ActualPrice(item);
                    }
                }
            }
            
        
            XmlNodeList accruedInterestPriceNodeList = xmlNode.SelectNodes("accruedInterestPrice");
            if (accruedInterestPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accruedInterestPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accruedInterestPriceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(accruedInterestPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accruedInterestPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accruedInterestPrice = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fxConversionNodeList = xmlNode.SelectNodes("fxConversion");
            if (fxConversionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxConversionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxConversionIDRef = item.Attributes["id"].Name;
                        FxConversion ob = FxConversion();
                        IDManager.SetID(fxConversionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxConversionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxConversion = new FxConversion(item);
                    }
                }
            }
            
        
            XmlNodeList amountRelativeToNodeList = xmlNode.SelectNodes("amountRelativeTo");
            if (amountRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountRelativeToIDRef = item.Attributes["id"].Name;
                        AmountReference ob = AmountReference();
                        IDManager.SetID(amountRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amountRelativeTo = new AmountReference(item);
                    }
                }
            }
            
        
            XmlNodeList cleanNetPriceNodeList = xmlNode.SelectNodes("cleanNetPrice");
            if (cleanNetPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cleanNetPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cleanNetPriceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(cleanNetPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cleanNetPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cleanNetPrice = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList quotationCharacteristicsNodeList = xmlNode.SelectNodes("quotationCharacteristics");
            if (quotationCharacteristicsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotationCharacteristicsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotationCharacteristicsIDRef = item.Attributes["id"].Name;
                        QuotationCharacteristics ob = QuotationCharacteristics();
                        IDManager.SetID(quotationCharacteristicsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotationCharacteristicsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotationCharacteristics = new QuotationCharacteristics(item);
                    }
                }
            }
            
        
        }
        
    
        #region Commission
        private Commission commission;
        public Commission Commission
        {
            get
            {
                if (this.commission != null)
                {
                    return this.commission; 
                }
                else if (this.commissionIDRef != null)
                {
                    commission = IDManager.getID(commissionIDRef) as Commission;
                    return this.commission; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commission != value)
                {
                    this.commission = value;
                }
            }
        }
        #endregion
        
        public string CommissionIDRef { get; set; }
        #region DeterminationMethod
        private DeterminationMethod determinationMethod;
        public DeterminationMethod DeterminationMethod
        {
            get
            {
                if (this.determinationMethod != null)
                {
                    return this.determinationMethod; 
                }
                else if (this.determinationMethodIDRef != null)
                {
                    determinationMethod = IDManager.getID(determinationMethodIDRef) as DeterminationMethod;
                    return this.determinationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determinationMethod != value)
                {
                    this.determinationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        #region GrossPrice
        private ActualPrice grossPrice;
        public ActualPrice GrossPrice
        {
            get
            {
                if (this.grossPrice != null)
                {
                    return this.grossPrice; 
                }
                else if (this.grossPriceIDRef != null)
                {
                    grossPrice = IDManager.getID(grossPriceIDRef) as ActualPrice;
                    return this.grossPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.grossPrice != value)
                {
                    this.grossPrice = value;
                }
            }
        }
        #endregion
        
        public string ActualPriceIDRef { get; set; }
        #region NetPrice
        private ActualPrice netPrice;
        public ActualPrice NetPrice
        {
            get
            {
                if (this.netPrice != null)
                {
                    return this.netPrice; 
                }
                else if (this.netPriceIDRef != null)
                {
                    netPrice = IDManager.getID(netPriceIDRef) as ActualPrice;
                    return this.netPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.netPrice != value)
                {
                    this.netPrice = value;
                }
            }
        }
        #endregion
        
        public string ActualPriceIDRef { get; set; }
        #region AccruedInterestPrice
        private XsdTypeDecimal accruedInterestPrice;
        public XsdTypeDecimal AccruedInterestPrice
        {
            get
            {
                if (this.accruedInterestPrice != null)
                {
                    return this.accruedInterestPrice; 
                }
                else if (this.accruedInterestPriceIDRef != null)
                {
                    accruedInterestPrice = IDManager.getID(accruedInterestPriceIDRef) as XsdTypeDecimal;
                    return this.accruedInterestPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accruedInterestPrice != value)
                {
                    this.accruedInterestPrice = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FxConversion
        private FxConversion fxConversion;
        public FxConversion FxConversion
        {
            get
            {
                if (this.fxConversion != null)
                {
                    return this.fxConversion; 
                }
                else if (this.fxConversionIDRef != null)
                {
                    fxConversion = IDManager.getID(fxConversionIDRef) as FxConversion;
                    return this.fxConversion; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxConversion != value)
                {
                    this.fxConversion = value;
                }
            }
        }
        #endregion
        
        public string FxConversionIDRef { get; set; }
        #region AmountRelativeTo
        private AmountReference amountRelativeTo;
        public AmountReference AmountRelativeTo
        {
            get
            {
                if (this.amountRelativeTo != null)
                {
                    return this.amountRelativeTo; 
                }
                else if (this.amountRelativeToIDRef != null)
                {
                    amountRelativeTo = IDManager.getID(amountRelativeToIDRef) as AmountReference;
                    return this.amountRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amountRelativeTo != value)
                {
                    this.amountRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string AmountReferenceIDRef { get; set; }
        #region CleanNetPrice
        private XsdTypeDecimal cleanNetPrice;
        public XsdTypeDecimal CleanNetPrice
        {
            get
            {
                if (this.cleanNetPrice != null)
                {
                    return this.cleanNetPrice; 
                }
                else if (this.cleanNetPriceIDRef != null)
                {
                    cleanNetPrice = IDManager.getID(cleanNetPriceIDRef) as XsdTypeDecimal;
                    return this.cleanNetPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cleanNetPrice != value)
                {
                    this.cleanNetPrice = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region QuotationCharacteristics
        private QuotationCharacteristics quotationCharacteristics;
        public QuotationCharacteristics QuotationCharacteristics
        {
            get
            {
                if (this.quotationCharacteristics != null)
                {
                    return this.quotationCharacteristics; 
                }
                else if (this.quotationCharacteristicsIDRef != null)
                {
                    quotationCharacteristics = IDManager.getID(quotationCharacteristicsIDRef) as QuotationCharacteristics;
                    return this.quotationCharacteristics; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotationCharacteristics != value)
                {
                    this.quotationCharacteristics = value;
                }
            }
        }
        #endregion
        
        public string QuotationCharacteristicsIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


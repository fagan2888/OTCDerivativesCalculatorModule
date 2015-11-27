using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Price : ISerialized
    {
        public Price(XmlNode xmlNode)
        {
            XmlNode commissionNode = xmlNode.SelectSingleNode("commission");
            
            if (commissionNode != null)
            {
                if (commissionNode.Attributes["href"] != null || commissionNode.Attributes["id"] != null) 
                {
                    if (commissionNode.Attributes["id"] != null) 
                    {
                        commissionIDRef_ = commissionNode.Attributes["id"].Value;
                        Commission ob = new Commission(commissionNode);
                        IDManager.SetID(commissionIDRef_, ob);
                    }
                    else if (commissionNode.Attributes["href"] != null)
                    {
                        commissionIDRef_ = commissionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commission_ = new Commission(commissionNode);
                    }
                }
                else
                {
                    commission_ = new Commission(commissionNode);
                }
            }
            
        
            XmlNode determinationMethodNode = xmlNode.SelectSingleNode("determinationMethod");
            
            if (determinationMethodNode != null)
            {
                if (determinationMethodNode.Attributes["href"] != null || determinationMethodNode.Attributes["id"] != null) 
                {
                    if (determinationMethodNode.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(determinationMethodNode);
                        IDManager.SetID(determinationMethodIDRef_, ob);
                    }
                    else if (determinationMethodNode.Attributes["href"] != null)
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                    }
                }
                else
                {
                    determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                }
            }
            
        
            XmlNode grossPriceNode = xmlNode.SelectSingleNode("grossPrice");
            
            if (grossPriceNode != null)
            {
                if (grossPriceNode.Attributes["href"] != null || grossPriceNode.Attributes["id"] != null) 
                {
                    if (grossPriceNode.Attributes["id"] != null) 
                    {
                        grossPriceIDRef_ = grossPriceNode.Attributes["id"].Value;
                        ActualPrice ob = new ActualPrice(grossPriceNode);
                        IDManager.SetID(grossPriceIDRef_, ob);
                    }
                    else if (grossPriceNode.Attributes["href"] != null)
                    {
                        grossPriceIDRef_ = grossPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        grossPrice_ = new ActualPrice(grossPriceNode);
                    }
                }
                else
                {
                    grossPrice_ = new ActualPrice(grossPriceNode);
                }
            }
            
        
            XmlNode netPriceNode = xmlNode.SelectSingleNode("netPrice");
            
            if (netPriceNode != null)
            {
                if (netPriceNode.Attributes["href"] != null || netPriceNode.Attributes["id"] != null) 
                {
                    if (netPriceNode.Attributes["id"] != null) 
                    {
                        netPriceIDRef_ = netPriceNode.Attributes["id"].Value;
                        ActualPrice ob = new ActualPrice(netPriceNode);
                        IDManager.SetID(netPriceIDRef_, ob);
                    }
                    else if (netPriceNode.Attributes["href"] != null)
                    {
                        netPriceIDRef_ = netPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        netPrice_ = new ActualPrice(netPriceNode);
                    }
                }
                else
                {
                    netPrice_ = new ActualPrice(netPriceNode);
                }
            }
            
        
            XmlNode accruedInterestPriceNode = xmlNode.SelectSingleNode("accruedInterestPrice");
            
            if (accruedInterestPriceNode != null)
            {
                if (accruedInterestPriceNode.Attributes["href"] != null || accruedInterestPriceNode.Attributes["id"] != null) 
                {
                    if (accruedInterestPriceNode.Attributes["id"] != null) 
                    {
                        accruedInterestPriceIDRef_ = accruedInterestPriceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(accruedInterestPriceNode);
                        IDManager.SetID(accruedInterestPriceIDRef_, ob);
                    }
                    else if (accruedInterestPriceNode.Attributes["href"] != null)
                    {
                        accruedInterestPriceIDRef_ = accruedInterestPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accruedInterestPrice_ = new XsdTypeDecimal(accruedInterestPriceNode);
                    }
                }
                else
                {
                    accruedInterestPrice_ = new XsdTypeDecimal(accruedInterestPriceNode);
                }
            }
            
        
            XmlNode fxConversionNode = xmlNode.SelectSingleNode("fxConversion");
            
            if (fxConversionNode != null)
            {
                if (fxConversionNode.Attributes["href"] != null || fxConversionNode.Attributes["id"] != null) 
                {
                    if (fxConversionNode.Attributes["id"] != null) 
                    {
                        fxConversionIDRef_ = fxConversionNode.Attributes["id"].Value;
                        FxConversion ob = new FxConversion(fxConversionNode);
                        IDManager.SetID(fxConversionIDRef_, ob);
                    }
                    else if (fxConversionNode.Attributes["href"] != null)
                    {
                        fxConversionIDRef_ = fxConversionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxConversion_ = new FxConversion(fxConversionNode);
                    }
                }
                else
                {
                    fxConversion_ = new FxConversion(fxConversionNode);
                }
            }
            
        
            XmlNode amountRelativeToNode = xmlNode.SelectSingleNode("amountRelativeTo");
            
            if (amountRelativeToNode != null)
            {
                if (amountRelativeToNode.Attributes["href"] != null || amountRelativeToNode.Attributes["id"] != null) 
                {
                    if (amountRelativeToNode.Attributes["id"] != null) 
                    {
                        amountRelativeToIDRef_ = amountRelativeToNode.Attributes["id"].Value;
                        AmountReference ob = new AmountReference(amountRelativeToNode);
                        IDManager.SetID(amountRelativeToIDRef_, ob);
                    }
                    else if (amountRelativeToNode.Attributes["href"] != null)
                    {
                        amountRelativeToIDRef_ = amountRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amountRelativeTo_ = new AmountReference(amountRelativeToNode);
                    }
                }
                else
                {
                    amountRelativeTo_ = new AmountReference(amountRelativeToNode);
                }
            }
            
        
            XmlNode cleanNetPriceNode = xmlNode.SelectSingleNode("cleanNetPrice");
            
            if (cleanNetPriceNode != null)
            {
                if (cleanNetPriceNode.Attributes["href"] != null || cleanNetPriceNode.Attributes["id"] != null) 
                {
                    if (cleanNetPriceNode.Attributes["id"] != null) 
                    {
                        cleanNetPriceIDRef_ = cleanNetPriceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(cleanNetPriceNode);
                        IDManager.SetID(cleanNetPriceIDRef_, ob);
                    }
                    else if (cleanNetPriceNode.Attributes["href"] != null)
                    {
                        cleanNetPriceIDRef_ = cleanNetPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cleanNetPrice_ = new XsdTypeDecimal(cleanNetPriceNode);
                    }
                }
                else
                {
                    cleanNetPrice_ = new XsdTypeDecimal(cleanNetPriceNode);
                }
            }
            
        
            XmlNode quotationCharacteristicsNode = xmlNode.SelectSingleNode("quotationCharacteristics");
            
            if (quotationCharacteristicsNode != null)
            {
                if (quotationCharacteristicsNode.Attributes["href"] != null || quotationCharacteristicsNode.Attributes["id"] != null) 
                {
                    if (quotationCharacteristicsNode.Attributes["id"] != null) 
                    {
                        quotationCharacteristicsIDRef_ = quotationCharacteristicsNode.Attributes["id"].Value;
                        QuotationCharacteristics ob = new QuotationCharacteristics(quotationCharacteristicsNode);
                        IDManager.SetID(quotationCharacteristicsIDRef_, ob);
                    }
                    else if (quotationCharacteristicsNode.Attributes["href"] != null)
                    {
                        quotationCharacteristicsIDRef_ = quotationCharacteristicsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotationCharacteristics_ = new QuotationCharacteristics(quotationCharacteristicsNode);
                    }
                }
                else
                {
                    quotationCharacteristics_ = new QuotationCharacteristics(quotationCharacteristicsNode);
                }
            }
            
        
        }
        
    
        #region Commission_
        private Commission commission_;
        public Commission Commission_
        {
            get
            {
                if (this.commission_ != null)
                {
                    return this.commission_; 
                }
                else if (this.commissionIDRef_ != null)
                {
                    commission_ = IDManager.getID(commissionIDRef_) as Commission;
                    return this.commission_; 
                }
                else
                {
                      return this.commission_; 
                }
            }
            set
            {
                if (this.commission_ != value)
                {
                    this.commission_ = value;
                }
            }
        }
        #endregion
        
        public string commissionIDRef_ { get; set; }
        #region DeterminationMethod_
        private DeterminationMethod determinationMethod_;
        public DeterminationMethod DeterminationMethod_
        {
            get
            {
                if (this.determinationMethod_ != null)
                {
                    return this.determinationMethod_; 
                }
                else if (this.determinationMethodIDRef_ != null)
                {
                    determinationMethod_ = IDManager.getID(determinationMethodIDRef_) as DeterminationMethod;
                    return this.determinationMethod_; 
                }
                else
                {
                      return this.determinationMethod_; 
                }
            }
            set
            {
                if (this.determinationMethod_ != value)
                {
                    this.determinationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string determinationMethodIDRef_ { get; set; }
        #region GrossPrice_
        private ActualPrice grossPrice_;
        public ActualPrice GrossPrice_
        {
            get
            {
                if (this.grossPrice_ != null)
                {
                    return this.grossPrice_; 
                }
                else if (this.grossPriceIDRef_ != null)
                {
                    grossPrice_ = IDManager.getID(grossPriceIDRef_) as ActualPrice;
                    return this.grossPrice_; 
                }
                else
                {
                      return this.grossPrice_; 
                }
            }
            set
            {
                if (this.grossPrice_ != value)
                {
                    this.grossPrice_ = value;
                }
            }
        }
        #endregion
        
        public string grossPriceIDRef_ { get; set; }
        #region NetPrice_
        private ActualPrice netPrice_;
        public ActualPrice NetPrice_
        {
            get
            {
                if (this.netPrice_ != null)
                {
                    return this.netPrice_; 
                }
                else if (this.netPriceIDRef_ != null)
                {
                    netPrice_ = IDManager.getID(netPriceIDRef_) as ActualPrice;
                    return this.netPrice_; 
                }
                else
                {
                      return this.netPrice_; 
                }
            }
            set
            {
                if (this.netPrice_ != value)
                {
                    this.netPrice_ = value;
                }
            }
        }
        #endregion
        
        public string netPriceIDRef_ { get; set; }
        #region AccruedInterestPrice_
        private XsdTypeDecimal accruedInterestPrice_;
        public XsdTypeDecimal AccruedInterestPrice_
        {
            get
            {
                if (this.accruedInterestPrice_ != null)
                {
                    return this.accruedInterestPrice_; 
                }
                else if (this.accruedInterestPriceIDRef_ != null)
                {
                    accruedInterestPrice_ = IDManager.getID(accruedInterestPriceIDRef_) as XsdTypeDecimal;
                    return this.accruedInterestPrice_; 
                }
                else
                {
                      return this.accruedInterestPrice_; 
                }
            }
            set
            {
                if (this.accruedInterestPrice_ != value)
                {
                    this.accruedInterestPrice_ = value;
                }
            }
        }
        #endregion
        
        public string accruedInterestPriceIDRef_ { get; set; }
        #region FxConversion_
        private FxConversion fxConversion_;
        public FxConversion FxConversion_
        {
            get
            {
                if (this.fxConversion_ != null)
                {
                    return this.fxConversion_; 
                }
                else if (this.fxConversionIDRef_ != null)
                {
                    fxConversion_ = IDManager.getID(fxConversionIDRef_) as FxConversion;
                    return this.fxConversion_; 
                }
                else
                {
                      return this.fxConversion_; 
                }
            }
            set
            {
                if (this.fxConversion_ != value)
                {
                    this.fxConversion_ = value;
                }
            }
        }
        #endregion
        
        public string fxConversionIDRef_ { get; set; }
        #region AmountRelativeTo_
        private AmountReference amountRelativeTo_;
        public AmountReference AmountRelativeTo_
        {
            get
            {
                if (this.amountRelativeTo_ != null)
                {
                    return this.amountRelativeTo_; 
                }
                else if (this.amountRelativeToIDRef_ != null)
                {
                    amountRelativeTo_ = IDManager.getID(amountRelativeToIDRef_) as AmountReference;
                    return this.amountRelativeTo_; 
                }
                else
                {
                      return this.amountRelativeTo_; 
                }
            }
            set
            {
                if (this.amountRelativeTo_ != value)
                {
                    this.amountRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string amountRelativeToIDRef_ { get; set; }
        #region CleanNetPrice_
        private XsdTypeDecimal cleanNetPrice_;
        public XsdTypeDecimal CleanNetPrice_
        {
            get
            {
                if (this.cleanNetPrice_ != null)
                {
                    return this.cleanNetPrice_; 
                }
                else if (this.cleanNetPriceIDRef_ != null)
                {
                    cleanNetPrice_ = IDManager.getID(cleanNetPriceIDRef_) as XsdTypeDecimal;
                    return this.cleanNetPrice_; 
                }
                else
                {
                      return this.cleanNetPrice_; 
                }
            }
            set
            {
                if (this.cleanNetPrice_ != value)
                {
                    this.cleanNetPrice_ = value;
                }
            }
        }
        #endregion
        
        public string cleanNetPriceIDRef_ { get; set; }
        #region QuotationCharacteristics_
        private QuotationCharacteristics quotationCharacteristics_;
        public QuotationCharacteristics QuotationCharacteristics_
        {
            get
            {
                if (this.quotationCharacteristics_ != null)
                {
                    return this.quotationCharacteristics_; 
                }
                else if (this.quotationCharacteristicsIDRef_ != null)
                {
                    quotationCharacteristics_ = IDManager.getID(quotationCharacteristicsIDRef_) as QuotationCharacteristics;
                    return this.quotationCharacteristics_; 
                }
                else
                {
                      return this.quotationCharacteristics_; 
                }
            }
            set
            {
                if (this.quotationCharacteristics_ != value)
                {
                    this.quotationCharacteristics_ = value;
                }
            }
        }
        #endregion
        
        public string quotationCharacteristicsIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


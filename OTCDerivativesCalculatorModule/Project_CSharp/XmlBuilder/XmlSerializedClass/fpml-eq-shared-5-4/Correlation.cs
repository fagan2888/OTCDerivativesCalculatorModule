using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Correlation : CalculationFromObservation
    {
        public Correlation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode notionalAmountNode = xmlNode.SelectSingleNode("notionalAmount");
            
            if (notionalAmountNode != null)
            {
                if (notionalAmountNode.Attributes["href"] != null || notionalAmountNode.Attributes["id"] != null) 
                {
                    if (notionalAmountNode.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(notionalAmountNode);
                        IDManager.SetID(notionalAmountIDRef_, ob);
                    }
                    else if (notionalAmountNode.Attributes["href"] != null)
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmount_ = new NonNegativeMoney(notionalAmountNode);
                    }
                }
                else
                {
                    notionalAmount_ = new NonNegativeMoney(notionalAmountNode);
                }
            }
            
        
            XmlNode correlationStrikePriceNode = xmlNode.SelectSingleNode("correlationStrikePrice");
            
            if (correlationStrikePriceNode != null)
            {
                if (correlationStrikePriceNode.Attributes["href"] != null || correlationStrikePriceNode.Attributes["id"] != null) 
                {
                    if (correlationStrikePriceNode.Attributes["id"] != null) 
                    {
                        correlationStrikePriceIDRef_ = correlationStrikePriceNode.Attributes["id"].Value;
                        CorrelationValue ob = new CorrelationValue(correlationStrikePriceNode);
                        IDManager.SetID(correlationStrikePriceIDRef_, ob);
                    }
                    else if (correlationStrikePriceNode.Attributes["href"] != null)
                    {
                        correlationStrikePriceIDRef_ = correlationStrikePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationStrikePrice_ = new CorrelationValue(correlationStrikePriceNode);
                    }
                }
                else
                {
                    correlationStrikePrice_ = new CorrelationValue(correlationStrikePriceNode);
                }
            }
            
        
            XmlNode boundedCorrelationNode = xmlNode.SelectSingleNode("boundedCorrelation");
            
            if (boundedCorrelationNode != null)
            {
                if (boundedCorrelationNode.Attributes["href"] != null || boundedCorrelationNode.Attributes["id"] != null) 
                {
                    if (boundedCorrelationNode.Attributes["id"] != null) 
                    {
                        boundedCorrelationIDRef_ = boundedCorrelationNode.Attributes["id"].Value;
                        BoundedCorrelation ob = new BoundedCorrelation(boundedCorrelationNode);
                        IDManager.SetID(boundedCorrelationIDRef_, ob);
                    }
                    else if (boundedCorrelationNode.Attributes["href"] != null)
                    {
                        boundedCorrelationIDRef_ = boundedCorrelationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        boundedCorrelation_ = new BoundedCorrelation(boundedCorrelationNode);
                    }
                }
                else
                {
                    boundedCorrelation_ = new BoundedCorrelation(boundedCorrelationNode);
                }
            }
            
        
            XmlNode numberOfDataSeriesNode = xmlNode.SelectSingleNode("numberOfDataSeries");
            
            if (numberOfDataSeriesNode != null)
            {
                if (numberOfDataSeriesNode.Attributes["href"] != null || numberOfDataSeriesNode.Attributes["id"] != null) 
                {
                    if (numberOfDataSeriesNode.Attributes["id"] != null) 
                    {
                        numberOfDataSeriesIDRef_ = numberOfDataSeriesNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(numberOfDataSeriesNode);
                        IDManager.SetID(numberOfDataSeriesIDRef_, ob);
                    }
                    else if (numberOfDataSeriesNode.Attributes["href"] != null)
                    {
                        numberOfDataSeriesIDRef_ = numberOfDataSeriesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfDataSeries_ = new XsdTypePositiveInteger(numberOfDataSeriesNode);
                    }
                }
                else
                {
                    numberOfDataSeries_ = new XsdTypePositiveInteger(numberOfDataSeriesNode);
                }
            }
            
        
        }
        
    
        #region NotionalAmount_
        private NonNegativeMoney notionalAmount_;
        public NonNegativeMoney NotionalAmount_
        {
            get
            {
                if (this.notionalAmount_ != null)
                {
                    return this.notionalAmount_; 
                }
                else if (this.notionalAmountIDRef_ != null)
                {
                    notionalAmount_ = IDManager.getID(notionalAmountIDRef_) as NonNegativeMoney;
                    return this.notionalAmount_; 
                }
                else
                {
                      return this.notionalAmount_; 
                }
            }
            set
            {
                if (this.notionalAmount_ != value)
                {
                    this.notionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountIDRef_ { get; set; }
        #region CorrelationStrikePrice_
        private CorrelationValue correlationStrikePrice_;
        public CorrelationValue CorrelationStrikePrice_
        {
            get
            {
                if (this.correlationStrikePrice_ != null)
                {
                    return this.correlationStrikePrice_; 
                }
                else if (this.correlationStrikePriceIDRef_ != null)
                {
                    correlationStrikePrice_ = IDManager.getID(correlationStrikePriceIDRef_) as CorrelationValue;
                    return this.correlationStrikePrice_; 
                }
                else
                {
                      return this.correlationStrikePrice_; 
                }
            }
            set
            {
                if (this.correlationStrikePrice_ != value)
                {
                    this.correlationStrikePrice_ = value;
                }
            }
        }
        #endregion
        
        public string correlationStrikePriceIDRef_ { get; set; }
        #region BoundedCorrelation_
        private BoundedCorrelation boundedCorrelation_;
        public BoundedCorrelation BoundedCorrelation_
        {
            get
            {
                if (this.boundedCorrelation_ != null)
                {
                    return this.boundedCorrelation_; 
                }
                else if (this.boundedCorrelationIDRef_ != null)
                {
                    boundedCorrelation_ = IDManager.getID(boundedCorrelationIDRef_) as BoundedCorrelation;
                    return this.boundedCorrelation_; 
                }
                else
                {
                      return this.boundedCorrelation_; 
                }
            }
            set
            {
                if (this.boundedCorrelation_ != value)
                {
                    this.boundedCorrelation_ = value;
                }
            }
        }
        #endregion
        
        public string boundedCorrelationIDRef_ { get; set; }
        #region NumberOfDataSeries_
        private XsdTypePositiveInteger numberOfDataSeries_;
        public XsdTypePositiveInteger NumberOfDataSeries_
        {
            get
            {
                if (this.numberOfDataSeries_ != null)
                {
                    return this.numberOfDataSeries_; 
                }
                else if (this.numberOfDataSeriesIDRef_ != null)
                {
                    numberOfDataSeries_ = IDManager.getID(numberOfDataSeriesIDRef_) as XsdTypePositiveInteger;
                    return this.numberOfDataSeries_; 
                }
                else
                {
                      return this.numberOfDataSeries_; 
                }
            }
            set
            {
                if (this.numberOfDataSeries_ != value)
                {
                    this.numberOfDataSeries_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfDataSeriesIDRef_ { get; set; }
        
    
        
    
    }
    
}


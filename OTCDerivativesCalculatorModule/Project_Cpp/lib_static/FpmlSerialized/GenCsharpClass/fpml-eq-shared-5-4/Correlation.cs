using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Correlation
    {
        public Correlation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList notionalAmountNodeList = xmlNode.SelectNodes("notionalAmount");
            if (notionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(notionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList correlationStrikePriceNodeList = xmlNode.SelectNodes("correlationStrikePrice");
            if (correlationStrikePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correlationStrikePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correlationStrikePriceIDRef = item.Attributes["id"].Name;
                        CorrelationValue ob = CorrelationValue();
                        IDManager.SetID(correlationStrikePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correlationStrikePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correlationStrikePrice = new CorrelationValue(item);
                    }
                }
            }
            
        
            XmlNodeList boundedCorrelationNodeList = xmlNode.SelectNodes("boundedCorrelation");
            if (boundedCorrelationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in boundedCorrelationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        boundedCorrelationIDRef = item.Attributes["id"].Name;
                        BoundedCorrelation ob = BoundedCorrelation();
                        IDManager.SetID(boundedCorrelationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        boundedCorrelationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        boundedCorrelation = new BoundedCorrelation(item);
                    }
                }
            }
            
        
            XmlNodeList numberOfDataSeriesNodeList = xmlNode.SelectNodes("numberOfDataSeries");
            if (numberOfDataSeriesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfDataSeriesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfDataSeriesIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(numberOfDataSeriesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfDataSeriesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfDataSeries = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region NotionalAmount
        private NonNegativeMoney notionalAmount;
        public NonNegativeMoney NotionalAmount
        {
            get
            {
                if (this.notionalAmount != null)
                {
                    return this.notionalAmount; 
                }
                else if (this.notionalAmountIDRef != null)
                {
                    notionalAmount = IDManager.getID(notionalAmountIDRef) as NonNegativeMoney;
                    return this.notionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmount != value)
                {
                    this.notionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region CorrelationStrikePrice
        private CorrelationValue correlationStrikePrice;
        public CorrelationValue CorrelationStrikePrice
        {
            get
            {
                if (this.correlationStrikePrice != null)
                {
                    return this.correlationStrikePrice; 
                }
                else if (this.correlationStrikePriceIDRef != null)
                {
                    correlationStrikePrice = IDManager.getID(correlationStrikePriceIDRef) as CorrelationValue;
                    return this.correlationStrikePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correlationStrikePrice != value)
                {
                    this.correlationStrikePrice = value;
                }
            }
        }
        #endregion
        
        public string CorrelationValueIDRef { get; set; }
        #region BoundedCorrelation
        private BoundedCorrelation boundedCorrelation;
        public BoundedCorrelation BoundedCorrelation
        {
            get
            {
                if (this.boundedCorrelation != null)
                {
                    return this.boundedCorrelation; 
                }
                else if (this.boundedCorrelationIDRef != null)
                {
                    boundedCorrelation = IDManager.getID(boundedCorrelationIDRef) as BoundedCorrelation;
                    return this.boundedCorrelation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.boundedCorrelation != value)
                {
                    this.boundedCorrelation = value;
                }
            }
        }
        #endregion
        
        public string BoundedCorrelationIDRef { get; set; }
        #region NumberOfDataSeries
        private XsdTypePositiveInteger numberOfDataSeries;
        public XsdTypePositiveInteger NumberOfDataSeries
        {
            get
            {
                if (this.numberOfDataSeries != null)
                {
                    return this.numberOfDataSeries; 
                }
                else if (this.numberOfDataSeriesIDRef != null)
                {
                    numberOfDataSeries = IDManager.getID(numberOfDataSeriesIDRef) as XsdTypePositiveInteger;
                    return this.numberOfDataSeries; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfDataSeries != value)
                {
                    this.numberOfDataSeries = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}


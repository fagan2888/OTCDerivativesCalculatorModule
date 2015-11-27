using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnLeg
    {
        public ReturnLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList rateOfReturnNodeList = xmlNode.SelectNodes("rateOfReturn");
            if (rateOfReturnNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateOfReturnNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateOfReturnIDRef = item.Attributes["id"].Name;
                        ReturnLegValuation ob = ReturnLegValuation();
                        IDManager.SetID(rateOfReturnIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateOfReturnIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateOfReturn = new ReturnLegValuation(item);
                    }
                }
            }
            
        
            XmlNodeList notionalNodeList = xmlNode.SelectNodes("notional");
            if (notionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalIDRef = item.Attributes["id"].Name;
                        ReturnSwapNotional ob = ReturnSwapNotional();
                        IDManager.SetID(notionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notional = new ReturnSwapNotional(item);
                    }
                }
            }
            
        
            XmlNodeList amountNodeList = xmlNode.SelectNodes("amount");
            if (amountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountIDRef = item.Attributes["id"].Name;
                        ReturnSwapAmount ob = ReturnSwapAmount();
                        IDManager.SetID(amountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amount = new ReturnSwapAmount(item);
                    }
                }
            }
            
        
            XmlNodeList returnNodeList = xmlNode.SelectNodes("return");
            if (returnNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnIDRef = item.Attributes["id"].Name;
                        Return ob = Return();
                        IDManager.SetID(returnIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        return = new Return(item);
                    }
                }
            }
            
        
            XmlNodeList notionalAdjustmentsNodeList = xmlNode.SelectNodes("notionalAdjustments");
            if (notionalAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAdjustmentsIDRef = item.Attributes["id"].Name;
                        NotionalAdjustmentEnum ob = NotionalAdjustmentEnum();
                        IDManager.SetID(notionalAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAdjustments = new NotionalAdjustmentEnum(item);
                    }
                }
            }
            
        
            XmlNodeList fxFeatureNodeList = xmlNode.SelectNodes("fxFeature");
            if (fxFeatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxFeatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxFeatureIDRef = item.Attributes["id"].Name;
                        FxFeature ob = FxFeature();
                        IDManager.SetID(fxFeatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxFeatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxFeature = new FxFeature(item);
                    }
                }
            }
            
        
            XmlNodeList averagingDatesNodeList = xmlNode.SelectNodes("averagingDates");
            if (averagingDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingDatesIDRef = item.Attributes["id"].Name;
                        AveragingPeriod ob = AveragingPeriod();
                        IDManager.SetID(averagingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingDates = new AveragingPeriod(item);
                    }
                }
            }
            
        
        }
        
    
        #region RateOfReturn
        private ReturnLegValuation rateOfReturn;
        public ReturnLegValuation RateOfReturn
        {
            get
            {
                if (this.rateOfReturn != null)
                {
                    return this.rateOfReturn; 
                }
                else if (this.rateOfReturnIDRef != null)
                {
                    rateOfReturn = IDManager.getID(rateOfReturnIDRef) as ReturnLegValuation;
                    return this.rateOfReturn; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateOfReturn != value)
                {
                    this.rateOfReturn = value;
                }
            }
        }
        #endregion
        
        public string ReturnLegValuationIDRef { get; set; }
        #region Notional
        private ReturnSwapNotional notional;
        public ReturnSwapNotional Notional
        {
            get
            {
                if (this.notional != null)
                {
                    return this.notional; 
                }
                else if (this.notionalIDRef != null)
                {
                    notional = IDManager.getID(notionalIDRef) as ReturnSwapNotional;
                    return this.notional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notional != value)
                {
                    this.notional = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapNotionalIDRef { get; set; }
        #region Amount
        private ReturnSwapAmount amount;
        public ReturnSwapAmount Amount
        {
            get
            {
                if (this.amount != null)
                {
                    return this.amount; 
                }
                else if (this.amountIDRef != null)
                {
                    amount = IDManager.getID(amountIDRef) as ReturnSwapAmount;
                    return this.amount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapAmountIDRef { get; set; }
        #region Return
        private Return return;
        public Return Return
        {
            get
            {
                if (this.return != null)
                {
                    return this.return; 
                }
                else if (this.returnIDRef != null)
                {
                    return = IDManager.getID(returnIDRef) as Return;
                    return this.return; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.return != value)
                {
                    this.return = value;
                }
            }
        }
        #endregion
        
        public string ReturnIDRef { get; set; }
        #region NotionalAdjustments
        private NotionalAdjustmentEnum notionalAdjustments;
        public NotionalAdjustmentEnum NotionalAdjustments
        {
            get
            {
                if (this.notionalAdjustments != null)
                {
                    return this.notionalAdjustments; 
                }
                else if (this.notionalAdjustmentsIDRef != null)
                {
                    notionalAdjustments = IDManager.getID(notionalAdjustmentsIDRef) as NotionalAdjustmentEnum;
                    return this.notionalAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAdjustments != value)
                {
                    this.notionalAdjustments = value;
                }
            }
        }
        #endregion
        
        public string NotionalAdjustmentEnumIDRef { get; set; }
        #region FxFeature
        private FxFeature fxFeature;
        public FxFeature FxFeature
        {
            get
            {
                if (this.fxFeature != null)
                {
                    return this.fxFeature; 
                }
                else if (this.fxFeatureIDRef != null)
                {
                    fxFeature = IDManager.getID(fxFeatureIDRef) as FxFeature;
                    return this.fxFeature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxFeature != value)
                {
                    this.fxFeature = value;
                }
            }
        }
        #endregion
        
        public string FxFeatureIDRef { get; set; }
        #region AveragingDates
        private AveragingPeriod averagingDates;
        public AveragingPeriod AveragingDates
        {
            get
            {
                if (this.averagingDates != null)
                {
                    return this.averagingDates; 
                }
                else if (this.averagingDatesIDRef != null)
                {
                    averagingDates = IDManager.getID(averagingDatesIDRef) as AveragingPeriod;
                    return this.averagingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingDates != value)
                {
                    this.averagingDates = value;
                }
            }
        }
        #endregion
        
        public string AveragingPeriodIDRef { get; set; }
        
    
        
    
    }
    
}


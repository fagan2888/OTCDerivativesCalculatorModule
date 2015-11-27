using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnLeg : ReturnSwapLegUnderlyer
    {
        public ReturnLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode rateOfReturnNode = xmlNode.SelectSingleNode("rateOfReturn");
            
            if (rateOfReturnNode != null)
            {
                if (rateOfReturnNode.Attributes["href"] != null || rateOfReturnNode.Attributes["id"] != null) 
                {
                    if (rateOfReturnNode.Attributes["id"] != null) 
                    {
                        rateOfReturnIDRef_ = rateOfReturnNode.Attributes["id"].Value;
                        ReturnLegValuation ob = new ReturnLegValuation(rateOfReturnNode);
                        IDManager.SetID(rateOfReturnIDRef_, ob);
                    }
                    else if (rateOfReturnNode.Attributes["href"] != null)
                    {
                        rateOfReturnIDRef_ = rateOfReturnNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateOfReturn_ = new ReturnLegValuation(rateOfReturnNode);
                    }
                }
                else
                {
                    rateOfReturn_ = new ReturnLegValuation(rateOfReturnNode);
                }
            }
            
        
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        ReturnSwapNotional ob = new ReturnSwapNotional(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new ReturnSwapNotional(notionalNode);
                    }
                }
                else
                {
                    notional_ = new ReturnSwapNotional(notionalNode);
                }
            }
            
        
            XmlNode amountNode = xmlNode.SelectSingleNode("amount");
            
            if (amountNode != null)
            {
                if (amountNode.Attributes["href"] != null || amountNode.Attributes["id"] != null) 
                {
                    if (amountNode.Attributes["id"] != null) 
                    {
                        amountIDRef_ = amountNode.Attributes["id"].Value;
                        ReturnSwapAmount ob = new ReturnSwapAmount(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new ReturnSwapAmount(amountNode);
                    }
                }
                else
                {
                    amount_ = new ReturnSwapAmount(amountNode);
                }
            }
            
        
            XmlNode returnNode = xmlNode.SelectSingleNode("return");
            
            if (returnNode != null)
            {
                if (returnNode.Attributes["href"] != null || returnNode.Attributes["id"] != null) 
                {
                    if (returnNode.Attributes["id"] != null) 
                    {
                        returnIDRef_ = returnNode.Attributes["id"].Value;
                        Return ob = new Return(returnNode);
                        IDManager.SetID(returnIDRef_, ob);
                    }
                    else if (returnNode.Attributes["href"] != null)
                    {
                        returnIDRef_ = returnNode.Attributes["href"].Value;
                    }
                    else
                    {
                        return_ = new Return(returnNode);
                    }
                }
                else
                {
                    return_ = new Return(returnNode);
                }
            }
            
        
            XmlNode notionalAdjustmentsNode = xmlNode.SelectSingleNode("notionalAdjustments");
            
            if (notionalAdjustmentsNode != null)
            {
                if (notionalAdjustmentsNode.Attributes["href"] != null || notionalAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (notionalAdjustmentsNode.Attributes["id"] != null) 
                    {
                        notionalAdjustmentsIDRef_ = notionalAdjustmentsNode.Attributes["id"].Value;
                        NotionalAdjustmentEnum ob = new NotionalAdjustmentEnum(notionalAdjustmentsNode);
                        IDManager.SetID(notionalAdjustmentsIDRef_, ob);
                    }
                    else if (notionalAdjustmentsNode.Attributes["href"] != null)
                    {
                        notionalAdjustmentsIDRef_ = notionalAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAdjustments_ = new NotionalAdjustmentEnum(notionalAdjustmentsNode);
                    }
                }
                else
                {
                    notionalAdjustments_ = new NotionalAdjustmentEnum(notionalAdjustmentsNode);
                }
            }
            
        
            XmlNode fxFeatureNode = xmlNode.SelectSingleNode("fxFeature");
            
            if (fxFeatureNode != null)
            {
                if (fxFeatureNode.Attributes["href"] != null || fxFeatureNode.Attributes["id"] != null) 
                {
                    if (fxFeatureNode.Attributes["id"] != null) 
                    {
                        fxFeatureIDRef_ = fxFeatureNode.Attributes["id"].Value;
                        FxFeature ob = new FxFeature(fxFeatureNode);
                        IDManager.SetID(fxFeatureIDRef_, ob);
                    }
                    else if (fxFeatureNode.Attributes["href"] != null)
                    {
                        fxFeatureIDRef_ = fxFeatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxFeature_ = new FxFeature(fxFeatureNode);
                    }
                }
                else
                {
                    fxFeature_ = new FxFeature(fxFeatureNode);
                }
            }
            
        
            XmlNode averagingDatesNode = xmlNode.SelectSingleNode("averagingDates");
            
            if (averagingDatesNode != null)
            {
                if (averagingDatesNode.Attributes["href"] != null || averagingDatesNode.Attributes["id"] != null) 
                {
                    if (averagingDatesNode.Attributes["id"] != null) 
                    {
                        averagingDatesIDRef_ = averagingDatesNode.Attributes["id"].Value;
                        AveragingPeriod ob = new AveragingPeriod(averagingDatesNode);
                        IDManager.SetID(averagingDatesIDRef_, ob);
                    }
                    else if (averagingDatesNode.Attributes["href"] != null)
                    {
                        averagingDatesIDRef_ = averagingDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingDates_ = new AveragingPeriod(averagingDatesNode);
                    }
                }
                else
                {
                    averagingDates_ = new AveragingPeriod(averagingDatesNode);
                }
            }
            
        
        }
        
    
        #region RateOfReturn_
        private ReturnLegValuation rateOfReturn_;
        public ReturnLegValuation RateOfReturn_
        {
            get
            {
                if (this.rateOfReturn_ != null)
                {
                    return this.rateOfReturn_; 
                }
                else if (this.rateOfReturnIDRef_ != null)
                {
                    rateOfReturn_ = IDManager.getID(rateOfReturnIDRef_) as ReturnLegValuation;
                    return this.rateOfReturn_; 
                }
                else
                {
                      return this.rateOfReturn_; 
                }
            }
            set
            {
                if (this.rateOfReturn_ != value)
                {
                    this.rateOfReturn_ = value;
                }
            }
        }
        #endregion
        
        public string rateOfReturnIDRef_ { get; set; }
        #region Notional_
        private ReturnSwapNotional notional_;
        public ReturnSwapNotional Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as ReturnSwapNotional;
                    return this.notional_; 
                }
                else
                {
                      return this.notional_; 
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region Amount_
        private ReturnSwapAmount amount_;
        public ReturnSwapAmount Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as ReturnSwapAmount;
                    return this.amount_; 
                }
                else
                {
                      return this.amount_; 
                }
            }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                }
            }
        }
        #endregion
        
        public string amountIDRef_ { get; set; }
        #region Return_
        private Return return_;
        public Return Return_
        {
            get
            {
                if (this.return_ != null)
                {
                    return this.return_; 
                }
                else if (this.returnIDRef_ != null)
                {
                    return_ = IDManager.getID(returnIDRef_) as Return;
                    return this.return_; 
                }
                else
                {
                      return this.return_; 
                }
            }
            set
            {
                if (this.return_ != value)
                {
                    this.return_ = value;
                }
            }
        }
        #endregion
        
        public string returnIDRef_ { get; set; }
        #region NotionalAdjustments_
        private NotionalAdjustmentEnum notionalAdjustments_;
        public NotionalAdjustmentEnum NotionalAdjustments_
        {
            get
            {
                if (this.notionalAdjustments_ != null)
                {
                    return this.notionalAdjustments_; 
                }
                else if (this.notionalAdjustmentsIDRef_ != null)
                {
                    notionalAdjustments_ = IDManager.getID(notionalAdjustmentsIDRef_) as NotionalAdjustmentEnum;
                    return this.notionalAdjustments_; 
                }
                else
                {
                      return this.notionalAdjustments_; 
                }
            }
            set
            {
                if (this.notionalAdjustments_ != value)
                {
                    this.notionalAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAdjustmentsIDRef_ { get; set; }
        #region FxFeature_
        private FxFeature fxFeature_;
        public FxFeature FxFeature_
        {
            get
            {
                if (this.fxFeature_ != null)
                {
                    return this.fxFeature_; 
                }
                else if (this.fxFeatureIDRef_ != null)
                {
                    fxFeature_ = IDManager.getID(fxFeatureIDRef_) as FxFeature;
                    return this.fxFeature_; 
                }
                else
                {
                      return this.fxFeature_; 
                }
            }
            set
            {
                if (this.fxFeature_ != value)
                {
                    this.fxFeature_ = value;
                }
            }
        }
        #endregion
        
        public string fxFeatureIDRef_ { get; set; }
        #region AveragingDates_
        private AveragingPeriod averagingDates_;
        public AveragingPeriod AveragingDates_
        {
            get
            {
                if (this.averagingDates_ != null)
                {
                    return this.averagingDates_; 
                }
                else if (this.averagingDatesIDRef_ != null)
                {
                    averagingDates_ = IDManager.getID(averagingDatesIDRef_) as AveragingPeriod;
                    return this.averagingDates_; 
                }
                else
                {
                      return this.averagingDates_; 
                }
            }
            set
            {
                if (this.averagingDates_ != value)
                {
                    this.averagingDates_ = value;
                }
            }
        }
        #endregion
        
        public string averagingDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}


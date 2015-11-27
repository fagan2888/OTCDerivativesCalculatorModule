using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestLeg : DirectionalLeg
    {
        public InterestLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode interestLegCalculationPeriodDatesNode = xmlNode.SelectSingleNode("interestLegCalculationPeriodDates");
            
            if (interestLegCalculationPeriodDatesNode != null)
            {
                if (interestLegCalculationPeriodDatesNode.Attributes["href"] != null || interestLegCalculationPeriodDatesNode.Attributes["id"] != null) 
                {
                    if (interestLegCalculationPeriodDatesNode.Attributes["id"] != null) 
                    {
                        interestLegCalculationPeriodDatesIDRef_ = interestLegCalculationPeriodDatesNode.Attributes["id"].Value;
                        InterestLegCalculationPeriodDates ob = new InterestLegCalculationPeriodDates(interestLegCalculationPeriodDatesNode);
                        IDManager.SetID(interestLegCalculationPeriodDatesIDRef_, ob);
                    }
                    else if (interestLegCalculationPeriodDatesNode.Attributes["href"] != null)
                    {
                        interestLegCalculationPeriodDatesIDRef_ = interestLegCalculationPeriodDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestLegCalculationPeriodDates_ = new InterestLegCalculationPeriodDates(interestLegCalculationPeriodDatesNode);
                    }
                }
                else
                {
                    interestLegCalculationPeriodDates_ = new InterestLegCalculationPeriodDates(interestLegCalculationPeriodDatesNode);
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
            
        
            XmlNode interestAmountNode = xmlNode.SelectSingleNode("interestAmount");
            
            if (interestAmountNode != null)
            {
                if (interestAmountNode.Attributes["href"] != null || interestAmountNode.Attributes["id"] != null) 
                {
                    if (interestAmountNode.Attributes["id"] != null) 
                    {
                        interestAmountIDRef_ = interestAmountNode.Attributes["id"].Value;
                        LegAmount ob = new LegAmount(interestAmountNode);
                        IDManager.SetID(interestAmountIDRef_, ob);
                    }
                    else if (interestAmountNode.Attributes["href"] != null)
                    {
                        interestAmountIDRef_ = interestAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestAmount_ = new LegAmount(interestAmountNode);
                    }
                }
                else
                {
                    interestAmount_ = new LegAmount(interestAmountNode);
                }
            }
            
        
            XmlNode interestCalculationNode = xmlNode.SelectSingleNode("interestCalculation");
            
            if (interestCalculationNode != null)
            {
                if (interestCalculationNode.Attributes["href"] != null || interestCalculationNode.Attributes["id"] != null) 
                {
                    if (interestCalculationNode.Attributes["id"] != null) 
                    {
                        interestCalculationIDRef_ = interestCalculationNode.Attributes["id"].Value;
                        InterestCalculation ob = new InterestCalculation(interestCalculationNode);
                        IDManager.SetID(interestCalculationIDRef_, ob);
                    }
                    else if (interestCalculationNode.Attributes["href"] != null)
                    {
                        interestCalculationIDRef_ = interestCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestCalculation_ = new InterestCalculation(interestCalculationNode);
                    }
                }
                else
                {
                    interestCalculation_ = new InterestCalculation(interestCalculationNode);
                }
            }
            
        
            XmlNode stubCalculationPeriodNode = xmlNode.SelectSingleNode("stubCalculationPeriod");
            
            if (stubCalculationPeriodNode != null)
            {
                if (stubCalculationPeriodNode.Attributes["href"] != null || stubCalculationPeriodNode.Attributes["id"] != null) 
                {
                    if (stubCalculationPeriodNode.Attributes["id"] != null) 
                    {
                        stubCalculationPeriodIDRef_ = stubCalculationPeriodNode.Attributes["id"].Value;
                        StubCalculationPeriod ob = new StubCalculationPeriod(stubCalculationPeriodNode);
                        IDManager.SetID(stubCalculationPeriodIDRef_, ob);
                    }
                    else if (stubCalculationPeriodNode.Attributes["href"] != null)
                    {
                        stubCalculationPeriodIDRef_ = stubCalculationPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubCalculationPeriod_ = new StubCalculationPeriod(stubCalculationPeriodNode);
                    }
                }
                else
                {
                    stubCalculationPeriod_ = new StubCalculationPeriod(stubCalculationPeriodNode);
                }
            }
            
        
        }
        
    
        #region InterestLegCalculationPeriodDates_
        private InterestLegCalculationPeriodDates interestLegCalculationPeriodDates_;
        public InterestLegCalculationPeriodDates InterestLegCalculationPeriodDates_
        {
            get
            {
                if (this.interestLegCalculationPeriodDates_ != null)
                {
                    return this.interestLegCalculationPeriodDates_; 
                }
                else if (this.interestLegCalculationPeriodDatesIDRef_ != null)
                {
                    interestLegCalculationPeriodDates_ = IDManager.getID(interestLegCalculationPeriodDatesIDRef_) as InterestLegCalculationPeriodDates;
                    return this.interestLegCalculationPeriodDates_; 
                }
                else
                {
                      return this.interestLegCalculationPeriodDates_; 
                }
            }
            set
            {
                if (this.interestLegCalculationPeriodDates_ != value)
                {
                    this.interestLegCalculationPeriodDates_ = value;
                }
            }
        }
        #endregion
        
        public string interestLegCalculationPeriodDatesIDRef_ { get; set; }
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
        #region InterestAmount_
        private LegAmount interestAmount_;
        public LegAmount InterestAmount_
        {
            get
            {
                if (this.interestAmount_ != null)
                {
                    return this.interestAmount_; 
                }
                else if (this.interestAmountIDRef_ != null)
                {
                    interestAmount_ = IDManager.getID(interestAmountIDRef_) as LegAmount;
                    return this.interestAmount_; 
                }
                else
                {
                      return this.interestAmount_; 
                }
            }
            set
            {
                if (this.interestAmount_ != value)
                {
                    this.interestAmount_ = value;
                }
            }
        }
        #endregion
        
        public string interestAmountIDRef_ { get; set; }
        #region InterestCalculation_
        private InterestCalculation interestCalculation_;
        public InterestCalculation InterestCalculation_
        {
            get
            {
                if (this.interestCalculation_ != null)
                {
                    return this.interestCalculation_; 
                }
                else if (this.interestCalculationIDRef_ != null)
                {
                    interestCalculation_ = IDManager.getID(interestCalculationIDRef_) as InterestCalculation;
                    return this.interestCalculation_; 
                }
                else
                {
                      return this.interestCalculation_; 
                }
            }
            set
            {
                if (this.interestCalculation_ != value)
                {
                    this.interestCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string interestCalculationIDRef_ { get; set; }
        #region StubCalculationPeriod_
        private StubCalculationPeriod stubCalculationPeriod_;
        public StubCalculationPeriod StubCalculationPeriod_
        {
            get
            {
                if (this.stubCalculationPeriod_ != null)
                {
                    return this.stubCalculationPeriod_; 
                }
                else if (this.stubCalculationPeriodIDRef_ != null)
                {
                    stubCalculationPeriod_ = IDManager.getID(stubCalculationPeriodIDRef_) as StubCalculationPeriod;
                    return this.stubCalculationPeriod_; 
                }
                else
                {
                      return this.stubCalculationPeriod_; 
                }
            }
            set
            {
                if (this.stubCalculationPeriod_ != value)
                {
                    this.stubCalculationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string stubCalculationPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}


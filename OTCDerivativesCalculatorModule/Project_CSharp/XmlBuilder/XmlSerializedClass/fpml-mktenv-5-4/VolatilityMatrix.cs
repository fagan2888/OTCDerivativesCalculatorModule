using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VolatilityMatrix : PricingStructureValuation
    {
        public VolatilityMatrix(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dataPointsNode = xmlNode.SelectSingleNode("dataPoints");
            
            if (dataPointsNode != null)
            {
                if (dataPointsNode.Attributes["href"] != null || dataPointsNode.Attributes["id"] != null) 
                {
                    if (dataPointsNode.Attributes["id"] != null) 
                    {
                        dataPointsIDRef_ = dataPointsNode.Attributes["id"].Value;
                        MultiDimensionalPricingData ob = new MultiDimensionalPricingData(dataPointsNode);
                        IDManager.SetID(dataPointsIDRef_, ob);
                    }
                    else if (dataPointsNode.Attributes["href"] != null)
                    {
                        dataPointsIDRef_ = dataPointsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dataPoints_ = new MultiDimensionalPricingData(dataPointsNode);
                    }
                }
                else
                {
                    dataPoints_ = new MultiDimensionalPricingData(dataPointsNode);
                }
            }
            
        
            XmlNodeList adjustmentNodeList = xmlNode.SelectNodes("adjustment");
            
            if (adjustmentNodeList != null)
            {
                this.adjustment_ = new List<ParametricAdjustment>();
                foreach (XmlNode item in adjustmentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            adjustmentIDRef_ = item.Attributes["id"].Value;
                            adjustment_.Add(new ParametricAdjustment(item));
                            IDManager.SetID(adjustmentIDRef_, adjustment_[adjustment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            adjustmentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        adjustment_.Add(new ParametricAdjustment(item));
                        }
                    }
                    else
                    {
                        adjustment_.Add(new ParametricAdjustment(item));
                    }
                }
            }
            
        
        }
        
    
        #region DataPoints_
        private MultiDimensionalPricingData dataPoints_;
        public MultiDimensionalPricingData DataPoints_
        {
            get
            {
                if (this.dataPoints_ != null)
                {
                    return this.dataPoints_; 
                }
                else if (this.dataPointsIDRef_ != null)
                {
                    dataPoints_ = IDManager.getID(dataPointsIDRef_) as MultiDimensionalPricingData;
                    return this.dataPoints_; 
                }
                else
                {
                      return this.dataPoints_; 
                }
            }
            set
            {
                if (this.dataPoints_ != value)
                {
                    this.dataPoints_ = value;
                }
            }
        }
        #endregion
        
        public string dataPointsIDRef_ { get; set; }
        #region Adjustment_
        private List<ParametricAdjustment> adjustment_;
        public List<ParametricAdjustment> Adjustment_
        {
            get
            {
                if (this.adjustment_ != null)
                {
                    return this.adjustment_; 
                }
                else if (this.adjustmentIDRef_ != null)
                {
                    return this.adjustment_; 
                }
                else
                {
                      return this.adjustment_; 
                }
            }
            set
            {
                if (this.adjustment_ != value)
                {
                    this.adjustment_ = value;
                }
            }
        }
        #endregion
        
        public string adjustmentIDRef_ { get; set; }
        
    
        
    
    }
    
}


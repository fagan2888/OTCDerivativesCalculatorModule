using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VolatilityMatrix
    {
        public VolatilityMatrix(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dataPointsNodeList = xmlNode.SelectNodes("dataPoints");
            if (dataPointsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dataPointsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dataPointsIDRef = item.Attributes["id"].Name;
                        MultiDimensionalPricingData ob = MultiDimensionalPricingData();
                        IDManager.SetID(dataPointsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dataPointsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dataPoints = new MultiDimensionalPricingData(item);
                    }
                }
            }
            
        
            XmlNodeList adjustmentNodeList = xmlNode.SelectNodes("adjustment");
            
            foreach (XmlNode item in adjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustmentIDRef = item.Attributes["id"].Name;
                        List<ParametricAdjustment> ob = new List<ParametricAdjustment>();
                        ob.Add(new ParametricAdjustment(item));
                        IDManager.SetID(adjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    adjustment.Add(new ParametricAdjustment(item));
                    }
                }
            }
            
        
        }
        
    
        #region DataPoints
        private MultiDimensionalPricingData dataPoints;
        public MultiDimensionalPricingData DataPoints
        {
            get
            {
                if (this.dataPoints != null)
                {
                    return this.dataPoints; 
                }
                else if (this.dataPointsIDRef != null)
                {
                    dataPoints = IDManager.getID(dataPointsIDRef) as MultiDimensionalPricingData;
                    return this.dataPoints; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dataPoints != value)
                {
                    this.dataPoints = value;
                }
            }
        }
        #endregion
        
        public string MultiDimensionalPricingDataIDRef { get; set; }
        #region Adjustment
        private List<ParametricAdjustment> adjustment;
        public List<ParametricAdjustment> Adjustment
        {
            get
            {
                if (this.adjustment != null)
                {
                    return this.adjustment; 
                }
                else if (this.adjustmentIDRef != null)
                {
                    adjustment = IDManager.getID(adjustmentIDRef) as List<ParametricAdjustment>;
                    return this.adjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustment != value)
                {
                    this.adjustment = value;
                }
            }
        }
        #endregion
        
        public string ParametricAdjustmentIDRef { get; set; }
        
    
        
    
    }
    
}


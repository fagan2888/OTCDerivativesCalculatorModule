using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConditionOperator : ISerialized
    {
        public ConditionOperator() { }
        public ConditionOperator(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList rangeCondition1DNodeList = xmlNode.SelectNodes("rangeCondition1D");
            
            if (rangeCondition1DNodeList != null)
            {
                this.rangeCondition1D_ = new List<RangeCondition1D>();
                foreach (XmlNode item in rangeCondition1DNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            rangeCondition1DIDRef_ = item.Attributes["id"].Value;
                            rangeCondition1D_.Add(new RangeCondition1D(item));
                            IDManager.SetID(rangeCondition1DIDRef_, rangeCondition1D_[rangeCondition1D_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            rangeCondition1DIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        rangeCondition1D_.Add(new RangeCondition1D(item));
                        }
                    }
                    else
                    {
                        rangeCondition1D_.Add(new RangeCondition1D(item));
                    }
                }
            }
            
        
        }
        
    
        #region RangeCondition1D_
        private List<RangeCondition1D> rangeCondition1D_;
        public List<RangeCondition1D> RangeCondition1D_
        {
            get
            {
                if (this.rangeCondition1D_ != null)
                {
                    return this.rangeCondition1D_; 
                }
                else if (this.rangeCondition1DIDRef_ != null)
                {
                    return this.rangeCondition1D_; 
                }
                else
                {
                    throw new Exception( "rangeCondition1D_Node no exist!");
                }
            }
            set
            {
                if (this.rangeCondition1D_ != value)
                {
                    this.rangeCondition1D_ = value;
                }
            }
        }
        #endregion
        
        public string rangeCondition1DIDRef_ { get; set; }
        
    
        
    
    }
    
}


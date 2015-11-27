using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AutomaticExercise : ISerialized
    {
        public AutomaticExercise(XmlNode xmlNode)
        {
            XmlNode thresholdRateNode = xmlNode.SelectSingleNode("thresholdRate");
            
            if (thresholdRateNode != null)
            {
                if (thresholdRateNode.Attributes["href"] != null || thresholdRateNode.Attributes["id"] != null) 
                {
                    if (thresholdRateNode.Attributes["id"] != null) 
                    {
                        thresholdRateIDRef_ = thresholdRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(thresholdRateNode);
                        IDManager.SetID(thresholdRateIDRef_, ob);
                    }
                    else if (thresholdRateNode.Attributes["href"] != null)
                    {
                        thresholdRateIDRef_ = thresholdRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        thresholdRate_ = new XsdTypeDecimal(thresholdRateNode);
                    }
                }
                else
                {
                    thresholdRate_ = new XsdTypeDecimal(thresholdRateNode);
                }
            }
            
        
        }
        
    
        #region ThresholdRate_
        private XsdTypeDecimal thresholdRate_;
        public XsdTypeDecimal ThresholdRate_
        {
            get
            {
                if (this.thresholdRate_ != null)
                {
                    return this.thresholdRate_; 
                }
                else if (this.thresholdRateIDRef_ != null)
                {
                    thresholdRate_ = IDManager.getID(thresholdRateIDRef_) as XsdTypeDecimal;
                    return this.thresholdRate_; 
                }
                else
                {
                      return this.thresholdRate_; 
                }
            }
            set
            {
                if (this.thresholdRate_ != value)
                {
                    this.thresholdRate_ = value;
                }
            }
        }
        #endregion
        
        public string thresholdRateIDRef_ { get; set; }
        
    
        
    
    }
    
}


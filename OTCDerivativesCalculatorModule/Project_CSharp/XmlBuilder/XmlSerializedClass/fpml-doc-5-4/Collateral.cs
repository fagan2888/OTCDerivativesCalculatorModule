using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Collateral : ISerialized
    {
        public Collateral(XmlNode xmlNode)
        {
            XmlNode independentAmountNode = xmlNode.SelectSingleNode("independentAmount");
            
            if (independentAmountNode != null)
            {
                if (independentAmountNode.Attributes["href"] != null || independentAmountNode.Attributes["id"] != null) 
                {
                    if (independentAmountNode.Attributes["id"] != null) 
                    {
                        independentAmountIDRef_ = independentAmountNode.Attributes["id"].Value;
                        IndependentAmount ob = new IndependentAmount(independentAmountNode);
                        IDManager.SetID(independentAmountIDRef_, ob);
                    }
                    else if (independentAmountNode.Attributes["href"] != null)
                    {
                        independentAmountIDRef_ = independentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        independentAmount_ = new IndependentAmount(independentAmountNode);
                    }
                }
                else
                {
                    independentAmount_ = new IndependentAmount(independentAmountNode);
                }
            }
            
        
        }
        
    
        #region IndependentAmount_
        private IndependentAmount independentAmount_;
        public IndependentAmount IndependentAmount_
        {
            get
            {
                if (this.independentAmount_ != null)
                {
                    return this.independentAmount_; 
                }
                else if (this.independentAmountIDRef_ != null)
                {
                    independentAmount_ = IDManager.getID(independentAmountIDRef_) as IndependentAmount;
                    return this.independentAmount_; 
                }
                else
                {
                      return this.independentAmount_; 
                }
            }
            set
            {
                if (this.independentAmount_ != value)
                {
                    this.independentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string independentAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}


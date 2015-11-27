using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxMultipleExercise : ISerialized
    {
        public FxMultipleExercise(XmlNode xmlNode)
        {
            XmlNode minimumNotionalAmountNode = xmlNode.SelectSingleNode("minimumNotionalAmount");
            
            if (minimumNotionalAmountNode != null)
            {
                if (minimumNotionalAmountNode.Attributes["href"] != null || minimumNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (minimumNotionalAmountNode.Attributes["id"] != null) 
                    {
                        minimumNotionalAmountIDRef_ = minimumNotionalAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(minimumNotionalAmountNode);
                        IDManager.SetID(minimumNotionalAmountIDRef_, ob);
                    }
                    else if (minimumNotionalAmountNode.Attributes["href"] != null)
                    {
                        minimumNotionalAmountIDRef_ = minimumNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumNotionalAmount_ = new NonNegativeMoney(minimumNotionalAmountNode);
                    }
                }
                else
                {
                    minimumNotionalAmount_ = new NonNegativeMoney(minimumNotionalAmountNode);
                }
            }
            
        
            XmlNode maximumNotionalAmountNode = xmlNode.SelectSingleNode("maximumNotionalAmount");
            
            if (maximumNotionalAmountNode != null)
            {
                if (maximumNotionalAmountNode.Attributes["href"] != null || maximumNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (maximumNotionalAmountNode.Attributes["id"] != null) 
                    {
                        maximumNotionalAmountIDRef_ = maximumNotionalAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(maximumNotionalAmountNode);
                        IDManager.SetID(maximumNotionalAmountIDRef_, ob);
                    }
                    else if (maximumNotionalAmountNode.Attributes["href"] != null)
                    {
                        maximumNotionalAmountIDRef_ = maximumNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumNotionalAmount_ = new NonNegativeMoney(maximumNotionalAmountNode);
                    }
                }
                else
                {
                    maximumNotionalAmount_ = new NonNegativeMoney(maximumNotionalAmountNode);
                }
            }
            
        
        }
        
    
        #region MinimumNotionalAmount_
        private NonNegativeMoney minimumNotionalAmount_;
        public NonNegativeMoney MinimumNotionalAmount_
        {
            get
            {
                if (this.minimumNotionalAmount_ != null)
                {
                    return this.minimumNotionalAmount_; 
                }
                else if (this.minimumNotionalAmountIDRef_ != null)
                {
                    minimumNotionalAmount_ = IDManager.getID(minimumNotionalAmountIDRef_) as NonNegativeMoney;
                    return this.minimumNotionalAmount_; 
                }
                else
                {
                      return this.minimumNotionalAmount_; 
                }
            }
            set
            {
                if (this.minimumNotionalAmount_ != value)
                {
                    this.minimumNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string minimumNotionalAmountIDRef_ { get; set; }
        #region MaximumNotionalAmount_
        private NonNegativeMoney maximumNotionalAmount_;
        public NonNegativeMoney MaximumNotionalAmount_
        {
            get
            {
                if (this.maximumNotionalAmount_ != null)
                {
                    return this.maximumNotionalAmount_; 
                }
                else if (this.maximumNotionalAmountIDRef_ != null)
                {
                    maximumNotionalAmount_ = IDManager.getID(maximumNotionalAmountIDRef_) as NonNegativeMoney;
                    return this.maximumNotionalAmount_; 
                }
                else
                {
                      return this.maximumNotionalAmount_; 
                }
            }
            set
            {
                if (this.maximumNotionalAmount_ != value)
                {
                    this.maximumNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string maximumNotionalAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}


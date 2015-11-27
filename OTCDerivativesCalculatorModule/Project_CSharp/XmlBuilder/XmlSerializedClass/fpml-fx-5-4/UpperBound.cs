using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UpperBound : ISerialized
    {
        public UpperBound(XmlNode xmlNode)
        {
            XmlNode maximumInclusiveNode = xmlNode.SelectSingleNode("maximumInclusive");
            
            if (maximumInclusiveNode != null)
            {
                if (maximumInclusiveNode.Attributes["href"] != null || maximumInclusiveNode.Attributes["id"] != null) 
                {
                    if (maximumInclusiveNode.Attributes["id"] != null) 
                    {
                        maximumInclusiveIDRef_ = maximumInclusiveNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(maximumInclusiveNode);
                        IDManager.SetID(maximumInclusiveIDRef_, ob);
                    }
                    else if (maximumInclusiveNode.Attributes["href"] != null)
                    {
                        maximumInclusiveIDRef_ = maximumInclusiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumInclusive_ = new PositiveDecimal(maximumInclusiveNode);
                    }
                }
                else
                {
                    maximumInclusive_ = new PositiveDecimal(maximumInclusiveNode);
                }
            }
            
        
            XmlNode maximumExclusiveNode = xmlNode.SelectSingleNode("maximumExclusive");
            
            if (maximumExclusiveNode != null)
            {
                if (maximumExclusiveNode.Attributes["href"] != null || maximumExclusiveNode.Attributes["id"] != null) 
                {
                    if (maximumExclusiveNode.Attributes["id"] != null) 
                    {
                        maximumExclusiveIDRef_ = maximumExclusiveNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(maximumExclusiveNode);
                        IDManager.SetID(maximumExclusiveIDRef_, ob);
                    }
                    else if (maximumExclusiveNode.Attributes["href"] != null)
                    {
                        maximumExclusiveIDRef_ = maximumExclusiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumExclusive_ = new PositiveDecimal(maximumExclusiveNode);
                    }
                }
                else
                {
                    maximumExclusive_ = new PositiveDecimal(maximumExclusiveNode);
                }
            }
            
        
        }
        
    
        #region MaximumInclusive_
        private PositiveDecimal maximumInclusive_;
        public PositiveDecimal MaximumInclusive_
        {
            get
            {
                if (this.maximumInclusive_ != null)
                {
                    return this.maximumInclusive_; 
                }
                else if (this.maximumInclusiveIDRef_ != null)
                {
                    maximumInclusive_ = IDManager.getID(maximumInclusiveIDRef_) as PositiveDecimal;
                    return this.maximumInclusive_; 
                }
                else
                {
                      return this.maximumInclusive_; 
                }
            }
            set
            {
                if (this.maximumInclusive_ != value)
                {
                    this.maximumInclusive_ = value;
                }
            }
        }
        #endregion
        
        public string maximumInclusiveIDRef_ { get; set; }
        #region MaximumExclusive_
        private PositiveDecimal maximumExclusive_;
        public PositiveDecimal MaximumExclusive_
        {
            get
            {
                if (this.maximumExclusive_ != null)
                {
                    return this.maximumExclusive_; 
                }
                else if (this.maximumExclusiveIDRef_ != null)
                {
                    maximumExclusive_ = IDManager.getID(maximumExclusiveIDRef_) as PositiveDecimal;
                    return this.maximumExclusive_; 
                }
                else
                {
                      return this.maximumExclusive_; 
                }
            }
            set
            {
                if (this.maximumExclusive_ != value)
                {
                    this.maximumExclusive_ = value;
                }
            }
        }
        #endregion
        
        public string maximumExclusiveIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


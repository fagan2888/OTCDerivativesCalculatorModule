using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LowerBound : ISerialized
    {
        public LowerBound(XmlNode xmlNode)
        {
            XmlNode minimumInclusiveNode = xmlNode.SelectSingleNode("minimumInclusive");
            
            if (minimumInclusiveNode != null)
            {
                if (minimumInclusiveNode.Attributes["href"] != null || minimumInclusiveNode.Attributes["id"] != null) 
                {
                    if (minimumInclusiveNode.Attributes["id"] != null) 
                    {
                        minimumInclusiveIDRef_ = minimumInclusiveNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(minimumInclusiveNode);
                        IDManager.SetID(minimumInclusiveIDRef_, ob);
                    }
                    else if (minimumInclusiveNode.Attributes["href"] != null)
                    {
                        minimumInclusiveIDRef_ = minimumInclusiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumInclusive_ = new PositiveDecimal(minimumInclusiveNode);
                    }
                }
                else
                {
                    minimumInclusive_ = new PositiveDecimal(minimumInclusiveNode);
                }
            }
            
        
            XmlNode minimumExclusiveNode = xmlNode.SelectSingleNode("minimumExclusive");
            
            if (minimumExclusiveNode != null)
            {
                if (minimumExclusiveNode.Attributes["href"] != null || minimumExclusiveNode.Attributes["id"] != null) 
                {
                    if (minimumExclusiveNode.Attributes["id"] != null) 
                    {
                        minimumExclusiveIDRef_ = minimumExclusiveNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(minimumExclusiveNode);
                        IDManager.SetID(minimumExclusiveIDRef_, ob);
                    }
                    else if (minimumExclusiveNode.Attributes["href"] != null)
                    {
                        minimumExclusiveIDRef_ = minimumExclusiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumExclusive_ = new PositiveDecimal(minimumExclusiveNode);
                    }
                }
                else
                {
                    minimumExclusive_ = new PositiveDecimal(minimumExclusiveNode);
                }
            }
            
        
        }
        
    
        #region MinimumInclusive_
        private PositiveDecimal minimumInclusive_;
        public PositiveDecimal MinimumInclusive_
        {
            get
            {
                if (this.minimumInclusive_ != null)
                {
                    return this.minimumInclusive_; 
                }
                else if (this.minimumInclusiveIDRef_ != null)
                {
                    minimumInclusive_ = IDManager.getID(minimumInclusiveIDRef_) as PositiveDecimal;
                    return this.minimumInclusive_; 
                }
                else
                {
                      return this.minimumInclusive_; 
                }
            }
            set
            {
                if (this.minimumInclusive_ != value)
                {
                    this.minimumInclusive_ = value;
                }
            }
        }
        #endregion
        
        public string minimumInclusiveIDRef_ { get; set; }
        #region MinimumExclusive_
        private PositiveDecimal minimumExclusive_;
        public PositiveDecimal MinimumExclusive_
        {
            get
            {
                if (this.minimumExclusive_ != null)
                {
                    return this.minimumExclusive_; 
                }
                else if (this.minimumExclusiveIDRef_ != null)
                {
                    minimumExclusive_ = IDManager.getID(minimumExclusiveIDRef_) as PositiveDecimal;
                    return this.minimumExclusive_; 
                }
                else
                {
                      return this.minimumExclusive_; 
                }
            }
            set
            {
                if (this.minimumExclusive_ != value)
                {
                    this.minimumExclusive_ = value;
                }
            }
        }
        #endregion
        
        public string minimumExclusiveIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


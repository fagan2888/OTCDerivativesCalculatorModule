using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StrikeSpread : ISerialized
    {
        public StrikeSpread(XmlNode xmlNode)
        {
            XmlNode upperStrikeNode = xmlNode.SelectSingleNode("upperStrike");
            
            if (upperStrikeNode != null)
            {
                if (upperStrikeNode.Attributes["href"] != null || upperStrikeNode.Attributes["id"] != null) 
                {
                    if (upperStrikeNode.Attributes["id"] != null) 
                    {
                        upperStrikeIDRef_ = upperStrikeNode.Attributes["id"].Value;
                        OptionStrike ob = new OptionStrike(upperStrikeNode);
                        IDManager.SetID(upperStrikeIDRef_, ob);
                    }
                    else if (upperStrikeNode.Attributes["href"] != null)
                    {
                        upperStrikeIDRef_ = upperStrikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperStrike_ = new OptionStrike(upperStrikeNode);
                    }
                }
                else
                {
                    upperStrike_ = new OptionStrike(upperStrikeNode);
                }
            }
            
        
            XmlNode upperStrikeNumberOfOptionsNode = xmlNode.SelectSingleNode("upperStrikeNumberOfOptions");
            
            if (upperStrikeNumberOfOptionsNode != null)
            {
                if (upperStrikeNumberOfOptionsNode.Attributes["href"] != null || upperStrikeNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (upperStrikeNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        upperStrikeNumberOfOptionsIDRef_ = upperStrikeNumberOfOptionsNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(upperStrikeNumberOfOptionsNode);
                        IDManager.SetID(upperStrikeNumberOfOptionsIDRef_, ob);
                    }
                    else if (upperStrikeNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        upperStrikeNumberOfOptionsIDRef_ = upperStrikeNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperStrikeNumberOfOptions_ = new PositiveDecimal(upperStrikeNumberOfOptionsNode);
                    }
                }
                else
                {
                    upperStrikeNumberOfOptions_ = new PositiveDecimal(upperStrikeNumberOfOptionsNode);
                }
            }
            
        
        }
        
    
        #region UpperStrike_
        private OptionStrike upperStrike_;
        public OptionStrike UpperStrike_
        {
            get
            {
                if (this.upperStrike_ != null)
                {
                    return this.upperStrike_; 
                }
                else if (this.upperStrikeIDRef_ != null)
                {
                    upperStrike_ = IDManager.getID(upperStrikeIDRef_) as OptionStrike;
                    return this.upperStrike_; 
                }
                else
                {
                      return this.upperStrike_; 
                }
            }
            set
            {
                if (this.upperStrike_ != value)
                {
                    this.upperStrike_ = value;
                }
            }
        }
        #endregion
        
        public string upperStrikeIDRef_ { get; set; }
        #region UpperStrikeNumberOfOptions_
        private PositiveDecimal upperStrikeNumberOfOptions_;
        public PositiveDecimal UpperStrikeNumberOfOptions_
        {
            get
            {
                if (this.upperStrikeNumberOfOptions_ != null)
                {
                    return this.upperStrikeNumberOfOptions_; 
                }
                else if (this.upperStrikeNumberOfOptionsIDRef_ != null)
                {
                    upperStrikeNumberOfOptions_ = IDManager.getID(upperStrikeNumberOfOptionsIDRef_) as PositiveDecimal;
                    return this.upperStrikeNumberOfOptions_; 
                }
                else
                {
                      return this.upperStrikeNumberOfOptions_; 
                }
            }
            set
            {
                if (this.upperStrikeNumberOfOptions_ != value)
                {
                    this.upperStrikeNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string upperStrikeNumberOfOptionsIDRef_ { get; set; }
        
    
        
    
    }
    
}


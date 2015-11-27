using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapLegUnderlyer : DirectionalLeg
    {
        public ReturnSwapLegUnderlyer(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode strikeDateNode = xmlNode.SelectSingleNode("strikeDate");
            
            if (strikeDateNode != null)
            {
                if (strikeDateNode.Attributes["href"] != null || strikeDateNode.Attributes["id"] != null) 
                {
                    if (strikeDateNode.Attributes["id"] != null) 
                    {
                        strikeDateIDRef_ = strikeDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(strikeDateNode);
                        IDManager.SetID(strikeDateIDRef_, ob);
                    }
                    else if (strikeDateNode.Attributes["href"] != null)
                    {
                        strikeDateIDRef_ = strikeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeDate_ = new AdjustableOrRelativeDate(strikeDateNode);
                    }
                }
                else
                {
                    strikeDate_ = new AdjustableOrRelativeDate(strikeDateNode);
                }
            }
            
        
            XmlNode underlyerNode = xmlNode.SelectSingleNode("underlyer");
            
            if (underlyerNode != null)
            {
                if (underlyerNode.Attributes["href"] != null || underlyerNode.Attributes["id"] != null) 
                {
                    if (underlyerNode.Attributes["id"] != null) 
                    {
                        underlyerIDRef_ = underlyerNode.Attributes["id"].Value;
                        Underlyer ob = new Underlyer(underlyerNode);
                        IDManager.SetID(underlyerIDRef_, ob);
                    }
                    else if (underlyerNode.Attributes["href"] != null)
                    {
                        underlyerIDRef_ = underlyerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyer_ = new Underlyer(underlyerNode);
                    }
                }
                else
                {
                    underlyer_ = new Underlyer(underlyerNode);
                }
            }
            
        
        }
        
    
        #region StrikeDate_
        private AdjustableOrRelativeDate strikeDate_;
        public AdjustableOrRelativeDate StrikeDate_
        {
            get
            {
                if (this.strikeDate_ != null)
                {
                    return this.strikeDate_; 
                }
                else if (this.strikeDateIDRef_ != null)
                {
                    strikeDate_ = IDManager.getID(strikeDateIDRef_) as AdjustableOrRelativeDate;
                    return this.strikeDate_; 
                }
                else
                {
                      return this.strikeDate_; 
                }
            }
            set
            {
                if (this.strikeDate_ != value)
                {
                    this.strikeDate_ = value;
                }
            }
        }
        #endregion
        
        public string strikeDateIDRef_ { get; set; }
        #region Underlyer_
        private Underlyer underlyer_;
        public Underlyer Underlyer_
        {
            get
            {
                if (this.underlyer_ != null)
                {
                    return this.underlyer_; 
                }
                else if (this.underlyerIDRef_ != null)
                {
                    underlyer_ = IDManager.getID(underlyerIDRef_) as Underlyer;
                    return this.underlyer_; 
                }
                else
                {
                      return this.underlyer_; 
                }
            }
            set
            {
                if (this.underlyer_ != value)
                {
                    this.underlyer_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerIDRef_ { get; set; }
        
    
        
    
    }
    
}


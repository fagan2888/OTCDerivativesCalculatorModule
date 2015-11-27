using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxStrikePrice : ISerialized
    {
        public FxStrikePrice(XmlNode xmlNode)
        {
            XmlNode rateNode = xmlNode.SelectSingleNode("rate");
            
            if (rateNode != null)
            {
                if (rateNode.Attributes["href"] != null || rateNode.Attributes["id"] != null) 
                {
                    if (rateNode.Attributes["id"] != null) 
                    {
                        rateIDRef_ = rateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(rateNode);
                        IDManager.SetID(rateIDRef_, ob);
                    }
                    else if (rateNode.Attributes["href"] != null)
                    {
                        rateIDRef_ = rateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rate_ = new PositiveDecimal(rateNode);
                    }
                }
                else
                {
                    rate_ = new PositiveDecimal(rateNode);
                }
            }
            
        
            XmlNode strikeQuoteBasisNode = xmlNode.SelectSingleNode("strikeQuoteBasis");
            
            if (strikeQuoteBasisNode != null)
            {
                if (strikeQuoteBasisNode.Attributes["href"] != null || strikeQuoteBasisNode.Attributes["id"] != null) 
                {
                    if (strikeQuoteBasisNode.Attributes["id"] != null) 
                    {
                        strikeQuoteBasisIDRef_ = strikeQuoteBasisNode.Attributes["id"].Value;
                        StrikeQuoteBasisEnum ob = new StrikeQuoteBasisEnum(strikeQuoteBasisNode);
                        IDManager.SetID(strikeQuoteBasisIDRef_, ob);
                    }
                    else if (strikeQuoteBasisNode.Attributes["href"] != null)
                    {
                        strikeQuoteBasisIDRef_ = strikeQuoteBasisNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeQuoteBasis_ = new StrikeQuoteBasisEnum(strikeQuoteBasisNode);
                    }
                }
                else
                {
                    strikeQuoteBasis_ = new StrikeQuoteBasisEnum(strikeQuoteBasisNode);
                }
            }
            
        
        }
        
    
        #region Rate_
        private PositiveDecimal rate_;
        public PositiveDecimal Rate_
        {
            get
            {
                if (this.rate_ != null)
                {
                    return this.rate_; 
                }
                else if (this.rateIDRef_ != null)
                {
                    rate_ = IDManager.getID(rateIDRef_) as PositiveDecimal;
                    return this.rate_; 
                }
                else
                {
                      return this.rate_; 
                }
            }
            set
            {
                if (this.rate_ != value)
                {
                    this.rate_ = value;
                }
            }
        }
        #endregion
        
        public string rateIDRef_ { get; set; }
        #region StrikeQuoteBasis_
        private StrikeQuoteBasisEnum strikeQuoteBasis_;
        public StrikeQuoteBasisEnum StrikeQuoteBasis_
        {
            get
            {
                if (this.strikeQuoteBasis_ != null)
                {
                    return this.strikeQuoteBasis_; 
                }
                else if (this.strikeQuoteBasisIDRef_ != null)
                {
                    strikeQuoteBasis_ = IDManager.getID(strikeQuoteBasisIDRef_) as StrikeQuoteBasisEnum;
                    return this.strikeQuoteBasis_; 
                }
                else
                {
                      return this.strikeQuoteBasis_; 
                }
            }
            set
            {
                if (this.strikeQuoteBasis_ != value)
                {
                    this.strikeQuoteBasis_ = value;
                }
            }
        }
        #endregion
        
        public string strikeQuoteBasisIDRef_ { get; set; }
        
    
        
    
    }
    
}


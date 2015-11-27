using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityExercisePeriods : ISerialized
    {
        public CommodityExercisePeriods(XmlNode xmlNode)
        {
            XmlNode commencementDateNode = xmlNode.SelectSingleNode("commencementDate");
            
            if (commencementDateNode != null)
            {
                if (commencementDateNode.Attributes["href"] != null || commencementDateNode.Attributes["id"] != null) 
                {
                    if (commencementDateNode.Attributes["id"] != null) 
                    {
                        commencementDateIDRef_ = commencementDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(commencementDateNode);
                        IDManager.SetID(commencementDateIDRef_, ob);
                    }
                    else if (commencementDateNode.Attributes["href"] != null)
                    {
                        commencementDateIDRef_ = commencementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commencementDate_ = new AdjustableOrRelativeDate(commencementDateNode);
                    }
                }
                else
                {
                    commencementDate_ = new AdjustableOrRelativeDate(commencementDateNode);
                }
            }
            
        
            XmlNode expirationDateNode = xmlNode.SelectSingleNode("expirationDate");
            
            if (expirationDateNode != null)
            {
                if (expirationDateNode.Attributes["href"] != null || expirationDateNode.Attributes["id"] != null) 
                {
                    if (expirationDateNode.Attributes["id"] != null) 
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(expirationDateNode);
                        IDManager.SetID(expirationDateIDRef_, ob);
                    }
                    else if (expirationDateNode.Attributes["href"] != null)
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                    }
                }
                else
                {
                    expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                }
            }
            
        
        }
        
    
        #region CommencementDate_
        private AdjustableOrRelativeDate commencementDate_;
        public AdjustableOrRelativeDate CommencementDate_
        {
            get
            {
                if (this.commencementDate_ != null)
                {
                    return this.commencementDate_; 
                }
                else if (this.commencementDateIDRef_ != null)
                {
                    commencementDate_ = IDManager.getID(commencementDateIDRef_) as AdjustableOrRelativeDate;
                    return this.commencementDate_; 
                }
                else
                {
                      return this.commencementDate_; 
                }
            }
            set
            {
                if (this.commencementDate_ != value)
                {
                    this.commencementDate_ = value;
                }
            }
        }
        #endregion
        
        public string commencementDateIDRef_ { get; set; }
        #region ExpirationDate_
        private AdjustableOrRelativeDate expirationDate_;
        public AdjustableOrRelativeDate ExpirationDate_
        {
            get
            {
                if (this.expirationDate_ != null)
                {
                    return this.expirationDate_; 
                }
                else if (this.expirationDateIDRef_ != null)
                {
                    expirationDate_ = IDManager.getID(expirationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.expirationDate_; 
                }
                else
                {
                      return this.expirationDate_; 
                }
            }
            set
            {
                if (this.expirationDate_ != value)
                {
                    this.expirationDate_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


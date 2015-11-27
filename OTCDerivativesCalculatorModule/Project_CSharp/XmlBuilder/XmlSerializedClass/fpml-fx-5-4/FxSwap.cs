using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxSwap : Product
    {
        public FxSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode nearLegNode = xmlNode.SelectSingleNode("nearLeg");
            
            if (nearLegNode != null)
            {
                if (nearLegNode.Attributes["href"] != null || nearLegNode.Attributes["id"] != null) 
                {
                    if (nearLegNode.Attributes["id"] != null) 
                    {
                        nearLegIDRef_ = nearLegNode.Attributes["id"].Value;
                        FxSwapLeg ob = new FxSwapLeg(nearLegNode);
                        IDManager.SetID(nearLegIDRef_, ob);
                    }
                    else if (nearLegNode.Attributes["href"] != null)
                    {
                        nearLegIDRef_ = nearLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nearLeg_ = new FxSwapLeg(nearLegNode);
                    }
                }
                else
                {
                    nearLeg_ = new FxSwapLeg(nearLegNode);
                }
            }
            
        
            XmlNode farLegNode = xmlNode.SelectSingleNode("farLeg");
            
            if (farLegNode != null)
            {
                if (farLegNode.Attributes["href"] != null || farLegNode.Attributes["id"] != null) 
                {
                    if (farLegNode.Attributes["id"] != null) 
                    {
                        farLegIDRef_ = farLegNode.Attributes["id"].Value;
                        FxSwapLeg ob = new FxSwapLeg(farLegNode);
                        IDManager.SetID(farLegIDRef_, ob);
                    }
                    else if (farLegNode.Attributes["href"] != null)
                    {
                        farLegIDRef_ = farLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        farLeg_ = new FxSwapLeg(farLegNode);
                    }
                }
                else
                {
                    farLeg_ = new FxSwapLeg(farLegNode);
                }
            }
            
        
        }
        
    
        #region NearLeg_
        private FxSwapLeg nearLeg_;
        public FxSwapLeg NearLeg_
        {
            get
            {
                if (this.nearLeg_ != null)
                {
                    return this.nearLeg_; 
                }
                else if (this.nearLegIDRef_ != null)
                {
                    nearLeg_ = IDManager.getID(nearLegIDRef_) as FxSwapLeg;
                    return this.nearLeg_; 
                }
                else
                {
                      return this.nearLeg_; 
                }
            }
            set
            {
                if (this.nearLeg_ != value)
                {
                    this.nearLeg_ = value;
                }
            }
        }
        #endregion
        
        public string nearLegIDRef_ { get; set; }
        #region FarLeg_
        private FxSwapLeg farLeg_;
        public FxSwapLeg FarLeg_
        {
            get
            {
                if (this.farLeg_ != null)
                {
                    return this.farLeg_; 
                }
                else if (this.farLegIDRef_ != null)
                {
                    farLeg_ = IDManager.getID(farLegIDRef_) as FxSwapLeg;
                    return this.farLeg_; 
                }
                else
                {
                      return this.farLeg_; 
                }
            }
            set
            {
                if (this.farLeg_ != value)
                {
                    this.farLeg_ = value;
                }
            }
        }
        #endregion
        
        public string farLegIDRef_ { get; set; }
        
    
        
    
    }
    
}


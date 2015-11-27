using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MakeWholeAmount : SwapCurveValuation
    {
        public MakeWholeAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode interpolationMethodNode = xmlNode.SelectSingleNode("interpolationMethod");
            
            if (interpolationMethodNode != null)
            {
                if (interpolationMethodNode.Attributes["href"] != null || interpolationMethodNode.Attributes["id"] != null) 
                {
                    if (interpolationMethodNode.Attributes["id"] != null) 
                    {
                        interpolationMethodIDRef_ = interpolationMethodNode.Attributes["id"].Value;
                        InterpolationMethod ob = new InterpolationMethod(interpolationMethodNode);
                        IDManager.SetID(interpolationMethodIDRef_, ob);
                    }
                    else if (interpolationMethodNode.Attributes["href"] != null)
                    {
                        interpolationMethodIDRef_ = interpolationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interpolationMethod_ = new InterpolationMethod(interpolationMethodNode);
                    }
                }
                else
                {
                    interpolationMethod_ = new InterpolationMethod(interpolationMethodNode);
                }
            }
            
        
            XmlNode earlyCallDateNode = xmlNode.SelectSingleNode("earlyCallDate");
            
            if (earlyCallDateNode != null)
            {
                if (earlyCallDateNode.Attributes["href"] != null || earlyCallDateNode.Attributes["id"] != null) 
                {
                    if (earlyCallDateNode.Attributes["id"] != null) 
                    {
                        earlyCallDateIDRef_ = earlyCallDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(earlyCallDateNode);
                        IDManager.SetID(earlyCallDateIDRef_, ob);
                    }
                    else if (earlyCallDateNode.Attributes["href"] != null)
                    {
                        earlyCallDateIDRef_ = earlyCallDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        earlyCallDate_ = new IdentifiedDate(earlyCallDateNode);
                    }
                }
                else
                {
                    earlyCallDate_ = new IdentifiedDate(earlyCallDateNode);
                }
            }
            
        
        }
        
    
        #region InterpolationMethod_
        private InterpolationMethod interpolationMethod_;
        public InterpolationMethod InterpolationMethod_
        {
            get
            {
                if (this.interpolationMethod_ != null)
                {
                    return this.interpolationMethod_; 
                }
                else if (this.interpolationMethodIDRef_ != null)
                {
                    interpolationMethod_ = IDManager.getID(interpolationMethodIDRef_) as InterpolationMethod;
                    return this.interpolationMethod_; 
                }
                else
                {
                      return this.interpolationMethod_; 
                }
            }
            set
            {
                if (this.interpolationMethod_ != value)
                {
                    this.interpolationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string interpolationMethodIDRef_ { get; set; }
        #region EarlyCallDate_
        private IdentifiedDate earlyCallDate_;
        public IdentifiedDate EarlyCallDate_
        {
            get
            {
                if (this.earlyCallDate_ != null)
                {
                    return this.earlyCallDate_; 
                }
                else if (this.earlyCallDateIDRef_ != null)
                {
                    earlyCallDate_ = IDManager.getID(earlyCallDateIDRef_) as IdentifiedDate;
                    return this.earlyCallDate_; 
                }
                else
                {
                      return this.earlyCallDate_; 
                }
            }
            set
            {
                if (this.earlyCallDate_ != value)
                {
                    this.earlyCallDate_ = value;
                }
            }
        }
        #endregion
        
        public string earlyCallDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


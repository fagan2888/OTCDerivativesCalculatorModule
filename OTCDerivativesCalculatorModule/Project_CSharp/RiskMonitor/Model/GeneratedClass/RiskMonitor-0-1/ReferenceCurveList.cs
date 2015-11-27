using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceCurveList : ISerialized
    {
        public ReferenceCurveList() { }
        public ReferenceCurveList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList referenceCurveNodeList = xmlNode.SelectNodes("referenceCurve");
            
            if (referenceCurveNodeList != null)
            {
                this.referenceCurve_ = new List<ReferenceCurve>();
                foreach (XmlNode item in referenceCurveNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceCurveIDRef_ = item.Attributes["id"].Value;
                            referenceCurve_.Add(new ReferenceCurve(item));
                            IDManager.SetID(referenceCurveIDRef_, referenceCurve_[referenceCurve_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceCurveIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceCurve_.Add(new ReferenceCurve(item));
                        }
                    }
                    else
                    {
                        referenceCurve_.Add(new ReferenceCurve(item));
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceCurve_
        private List<ReferenceCurve> referenceCurve_;
        public List<ReferenceCurve> ReferenceCurve_
        {
            get
            {
                if (this.referenceCurve_ != null)
                {
                    return this.referenceCurve_; 
                }
                else if (this.referenceCurveIDRef_ != null)
                {
                    return this.referenceCurve_; 
                }
                else
                {
                    throw new Exception( "referenceCurve_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCurve_ != value)
                {
                    this.referenceCurve_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}


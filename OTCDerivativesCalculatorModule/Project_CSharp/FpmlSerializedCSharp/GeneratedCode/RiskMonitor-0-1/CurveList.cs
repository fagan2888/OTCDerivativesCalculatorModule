using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class CurveList : ISerialized
    {
        public CurveList() { }
        public CurveList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList curveNodeList = xmlNode.SelectNodes("curve");
            
            if (curveNodeList != null)
            {
                this.curve_ = new List<Curve>();
                foreach (XmlNode item in curveNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            curveIDRef_ = item.Attributes["id"].Value;
                            curve_.Add(new Curve(item));
                            IDManager.SetID(curveIDRef_, curve_[curve_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            curveIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        curve_.Add(new Curve(item));
                        }
                    }
                    else
                    {
                        curve_.Add(new Curve(item));
                    }
                }
            }
            
        
        }
        
    
        #region Curve_
        private List<Curve> curve_;
        public List<Curve> Curve_
        {
            get
            {
                if (this.curve_ != null)
                {
                    return this.curve_; 
                }
                else if (this.curveIDRef_ != null)
                {
                    return this.curve_; 
                }
                else
                {
                      return this.curve_; 
                }
            }
            set
            {
                if (this.curve_ != value)
                {
                    this.curve_ = value;
                }
            }
        }
        #endregion
        
        public string curveIDRef_ { get; set; }
        
    
        
    
    }
    
}


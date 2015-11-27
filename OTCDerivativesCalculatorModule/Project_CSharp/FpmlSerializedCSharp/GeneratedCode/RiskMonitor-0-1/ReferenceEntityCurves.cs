using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class ReferenceEntityCurves : ISerialized
    {
        public ReferenceEntityCurves() { }
        public ReferenceEntityCurves(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList curvesNodeList = xmlNode.SelectNodes("curves");
            
            if (curvesNodeList != null)
            {
                this.curves_ = new List<Curve>();
                foreach (XmlNode item in curvesNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            curvesIDRef_ = item.Attributes["id"].Value;
                            curves_.Add(new Curve(item));
                            IDManager.SetID(curvesIDRef_, curves_[curves_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            curvesIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        curves_.Add(new Curve(item));
                        }
                    }
                    else
                    {
                        curves_.Add(new Curve(item));
                    }
                }
            }
            
        
        }
        
    
        #region Curves_
        private List<Curve> curves_;
        public List<Curve> Curves_
        {
            get
            {
                if (this.curves_ != null)
                {
                    return this.curves_; 
                }
                else if (this.curvesIDRef_ != null)
                {
                    return this.curves_; 
                }
                else
                {
                      return this.curves_; 
                }
            }
            set
            {
                if (this.curves_ != value)
                {
                    this.curves_ = value;
                }
            }
        }
        #endregion
        
        public string curvesIDRef_ { get; set; }
        
    
        
    
    }
    
}


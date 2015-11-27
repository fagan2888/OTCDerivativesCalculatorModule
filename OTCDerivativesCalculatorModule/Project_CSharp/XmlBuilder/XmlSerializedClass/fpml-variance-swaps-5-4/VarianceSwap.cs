using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VarianceSwap : NettedSwapBase
    {
        public VarianceSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList varianceLegNodeList = xmlNode.SelectNodes("varianceLeg");
            
            if (varianceLegNodeList != null)
            {
                this.varianceLeg_ = new List<VarianceLeg>();
                foreach (XmlNode item in varianceLegNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            varianceLegIDRef_ = item.Attributes["id"].Value;
                            varianceLeg_.Add(new VarianceLeg(item));
                            IDManager.SetID(varianceLegIDRef_, varianceLeg_[varianceLeg_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            varianceLegIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        varianceLeg_.Add(new VarianceLeg(item));
                        }
                    }
                    else
                    {
                        varianceLeg_.Add(new VarianceLeg(item));
                    }
                }
            }
            
        
        }
        
    
        #region VarianceLeg_
        private List<VarianceLeg> varianceLeg_;
        public List<VarianceLeg> VarianceLeg_
        {
            get
            {
                if (this.varianceLeg_ != null)
                {
                    return this.varianceLeg_; 
                }
                else if (this.varianceLegIDRef_ != null)
                {
                    return this.varianceLeg_; 
                }
                else
                {
                      return this.varianceLeg_; 
                }
            }
            set
            {
                if (this.varianceLeg_ != value)
                {
                    this.varianceLeg_ = value;
                }
            }
        }
        #endregion
        
        public string varianceLegIDRef_ { get; set; }
        
    
        
    
    }
    
}


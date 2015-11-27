using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxOptionFeatures : ISerialized
    {
        public FxOptionFeatures(XmlNode xmlNode)
        {
            XmlNode asianNode = xmlNode.SelectSingleNode("asian");
            
            if (asianNode != null)
            {
                if (asianNode.Attributes["href"] != null || asianNode.Attributes["id"] != null) 
                {
                    if (asianNode.Attributes["id"] != null) 
                    {
                        asianIDRef_ = asianNode.Attributes["id"].Value;
                        FxAsianFeature ob = new FxAsianFeature(asianNode);
                        IDManager.SetID(asianIDRef_, ob);
                    }
                    else if (asianNode.Attributes["href"] != null)
                    {
                        asianIDRef_ = asianNode.Attributes["href"].Value;
                    }
                    else
                    {
                        asian_ = new FxAsianFeature(asianNode);
                    }
                }
                else
                {
                    asian_ = new FxAsianFeature(asianNode);
                }
            }
            
        
            XmlNodeList barrierNodeList = xmlNode.SelectNodes("barrier");
            
            if (barrierNodeList != null)
            {
                this.barrier_ = new List<FxBarrierFeature>();
                foreach (XmlNode item in barrierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            barrierIDRef_ = item.Attributes["id"].Value;
                            barrier_.Add(new FxBarrierFeature(item));
                            IDManager.SetID(barrierIDRef_, barrier_[barrier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            barrierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        barrier_.Add(new FxBarrierFeature(item));
                        }
                    }
                    else
                    {
                        barrier_.Add(new FxBarrierFeature(item));
                    }
                }
            }
            
        
        }
        
    
        #region Asian_
        private FxAsianFeature asian_;
        public FxAsianFeature Asian_
        {
            get
            {
                if (this.asian_ != null)
                {
                    return this.asian_; 
                }
                else if (this.asianIDRef_ != null)
                {
                    asian_ = IDManager.getID(asianIDRef_) as FxAsianFeature;
                    return this.asian_; 
                }
                else
                {
                      return this.asian_; 
                }
            }
            set
            {
                if (this.asian_ != value)
                {
                    this.asian_ = value;
                }
            }
        }
        #endregion
        
        public string asianIDRef_ { get; set; }
        #region Barrier_
        private List<FxBarrierFeature> barrier_;
        public List<FxBarrierFeature> Barrier_
        {
            get
            {
                if (this.barrier_ != null)
                {
                    return this.barrier_; 
                }
                else if (this.barrierIDRef_ != null)
                {
                    return this.barrier_; 
                }
                else
                {
                      return this.barrier_; 
                }
            }
            set
            {
                if (this.barrier_ != value)
                {
                    this.barrier_ = value;
                }
            }
        }
        #endregion
        
        public string barrierIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


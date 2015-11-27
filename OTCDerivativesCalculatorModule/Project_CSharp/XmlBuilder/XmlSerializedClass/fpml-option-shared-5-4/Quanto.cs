using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Quanto : ISerialized
    {
        public Quanto(XmlNode xmlNode)
        {
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            if (fxRateNodeList != null)
            {
                this.fxRate_ = new List<FxRate>();
                foreach (XmlNode item in fxRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fxRateIDRef_ = item.Attributes["id"].Value;
                            fxRate_.Add(new FxRate(item));
                            IDManager.SetID(fxRateIDRef_, fxRate_[fxRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fxRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fxRate_.Add(new FxRate(item));
                        }
                    }
                    else
                    {
                        fxRate_.Add(new FxRate(item));
                    }
                }
            }
            
        
            XmlNode fxSpotRateSourceNode = xmlNode.SelectSingleNode("fxSpotRateSource");
            
            if (fxSpotRateSourceNode != null)
            {
                if (fxSpotRateSourceNode.Attributes["href"] != null || fxSpotRateSourceNode.Attributes["id"] != null) 
                {
                    if (fxSpotRateSourceNode.Attributes["id"] != null) 
                    {
                        fxSpotRateSourceIDRef_ = fxSpotRateSourceNode.Attributes["id"].Value;
                        FxSpotRateSource ob = new FxSpotRateSource(fxSpotRateSourceNode);
                        IDManager.SetID(fxSpotRateSourceIDRef_, ob);
                    }
                    else if (fxSpotRateSourceNode.Attributes["href"] != null)
                    {
                        fxSpotRateSourceIDRef_ = fxSpotRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxSpotRateSource_ = new FxSpotRateSource(fxSpotRateSourceNode);
                    }
                }
                else
                {
                    fxSpotRateSource_ = new FxSpotRateSource(fxSpotRateSourceNode);
                }
            }
            
        
        }
        
    
        #region FxRate_
        private List<FxRate> fxRate_;
        public List<FxRate> FxRate_
        {
            get
            {
                if (this.fxRate_ != null)
                {
                    return this.fxRate_; 
                }
                else if (this.fxRateIDRef_ != null)
                {
                    return this.fxRate_; 
                }
                else
                {
                      return this.fxRate_; 
                }
            }
            set
            {
                if (this.fxRate_ != value)
                {
                    this.fxRate_ = value;
                }
            }
        }
        #endregion
        
        public string fxRateIDRef_ { get; set; }
        #region FxSpotRateSource_
        private FxSpotRateSource fxSpotRateSource_;
        public FxSpotRateSource FxSpotRateSource_
        {
            get
            {
                if (this.fxSpotRateSource_ != null)
                {
                    return this.fxSpotRateSource_; 
                }
                else if (this.fxSpotRateSourceIDRef_ != null)
                {
                    fxSpotRateSource_ = IDManager.getID(fxSpotRateSourceIDRef_) as FxSpotRateSource;
                    return this.fxSpotRateSource_; 
                }
                else
                {
                      return this.fxSpotRateSource_; 
                }
            }
            set
            {
                if (this.fxSpotRateSource_ != value)
                {
                    this.fxSpotRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string fxSpotRateSourceIDRef_ { get; set; }
        
    
        
    
    }
    
}


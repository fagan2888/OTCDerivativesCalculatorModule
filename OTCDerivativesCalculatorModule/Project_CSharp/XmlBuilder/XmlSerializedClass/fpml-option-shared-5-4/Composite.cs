using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Composite : ISerialized
    {
        public Composite(XmlNode xmlNode)
        {
            XmlNode determinationMethodNode = xmlNode.SelectSingleNode("determinationMethod");
            
            if (determinationMethodNode != null)
            {
                if (determinationMethodNode.Attributes["href"] != null || determinationMethodNode.Attributes["id"] != null) 
                {
                    if (determinationMethodNode.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(determinationMethodNode);
                        IDManager.SetID(determinationMethodIDRef_, ob);
                    }
                    else if (determinationMethodNode.Attributes["href"] != null)
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                    }
                }
                else
                {
                    determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                }
            }
            
        
            XmlNode relativeDateNode = xmlNode.SelectSingleNode("relativeDate");
            
            if (relativeDateNode != null)
            {
                if (relativeDateNode.Attributes["href"] != null || relativeDateNode.Attributes["id"] != null) 
                {
                    if (relativeDateNode.Attributes["id"] != null) 
                    {
                        relativeDateIDRef_ = relativeDateNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(relativeDateNode);
                        IDManager.SetID(relativeDateIDRef_, ob);
                    }
                    else if (relativeDateNode.Attributes["href"] != null)
                    {
                        relativeDateIDRef_ = relativeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeDate_ = new RelativeDateOffset(relativeDateNode);
                    }
                }
                else
                {
                    relativeDate_ = new RelativeDateOffset(relativeDateNode);
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
        
    
        #region DeterminationMethod_
        private DeterminationMethod determinationMethod_;
        public DeterminationMethod DeterminationMethod_
        {
            get
            {
                if (this.determinationMethod_ != null)
                {
                    return this.determinationMethod_; 
                }
                else if (this.determinationMethodIDRef_ != null)
                {
                    determinationMethod_ = IDManager.getID(determinationMethodIDRef_) as DeterminationMethod;
                    return this.determinationMethod_; 
                }
                else
                {
                      return this.determinationMethod_; 
                }
            }
            set
            {
                if (this.determinationMethod_ != value)
                {
                    this.determinationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string determinationMethodIDRef_ { get; set; }
        #region RelativeDate_
        private RelativeDateOffset relativeDate_;
        public RelativeDateOffset RelativeDate_
        {
            get
            {
                if (this.relativeDate_ != null)
                {
                    return this.relativeDate_; 
                }
                else if (this.relativeDateIDRef_ != null)
                {
                    relativeDate_ = IDManager.getID(relativeDateIDRef_) as RelativeDateOffset;
                    return this.relativeDate_; 
                }
                else
                {
                      return this.relativeDate_; 
                }
            }
            set
            {
                if (this.relativeDate_ != value)
                {
                    this.relativeDate_ = value;
                }
            }
        }
        #endregion
        
        public string relativeDateIDRef_ { get; set; }
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


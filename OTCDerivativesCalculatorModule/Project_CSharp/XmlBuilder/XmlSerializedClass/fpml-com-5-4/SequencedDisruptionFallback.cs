using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SequencedDisruptionFallback : ISerialized
    {
        public SequencedDisruptionFallback(XmlNode xmlNode)
        {
            XmlNode fallbackNode = xmlNode.SelectSingleNode("fallback");
            
            if (fallbackNode != null)
            {
                if (fallbackNode.Attributes["href"] != null || fallbackNode.Attributes["id"] != null) 
                {
                    if (fallbackNode.Attributes["id"] != null) 
                    {
                        fallbackIDRef_ = fallbackNode.Attributes["id"].Value;
                        DisruptionFallback ob = new DisruptionFallback(fallbackNode);
                        IDManager.SetID(fallbackIDRef_, ob);
                    }
                    else if (fallbackNode.Attributes["href"] != null)
                    {
                        fallbackIDRef_ = fallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fallback_ = new DisruptionFallback(fallbackNode);
                    }
                }
                else
                {
                    fallback_ = new DisruptionFallback(fallbackNode);
                }
            }
            
        
            XmlNode sequenceNode = xmlNode.SelectSingleNode("sequence");
            
            if (sequenceNode != null)
            {
                if (sequenceNode.Attributes["href"] != null || sequenceNode.Attributes["id"] != null) 
                {
                    if (sequenceNode.Attributes["id"] != null) 
                    {
                        sequenceIDRef_ = sequenceNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(sequenceNode);
                        IDManager.SetID(sequenceIDRef_, ob);
                    }
                    else if (sequenceNode.Attributes["href"] != null)
                    {
                        sequenceIDRef_ = sequenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sequence_ = new XsdTypePositiveInteger(sequenceNode);
                    }
                }
                else
                {
                    sequence_ = new XsdTypePositiveInteger(sequenceNode);
                }
            }
            
        
        }
        
    
        #region Fallback_
        private DisruptionFallback fallback_;
        public DisruptionFallback Fallback_
        {
            get
            {
                if (this.fallback_ != null)
                {
                    return this.fallback_; 
                }
                else if (this.fallbackIDRef_ != null)
                {
                    fallback_ = IDManager.getID(fallbackIDRef_) as DisruptionFallback;
                    return this.fallback_; 
                }
                else
                {
                      return this.fallback_; 
                }
            }
            set
            {
                if (this.fallback_ != value)
                {
                    this.fallback_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackIDRef_ { get; set; }
        #region Sequence_
        private XsdTypePositiveInteger sequence_;
        public XsdTypePositiveInteger Sequence_
        {
            get
            {
                if (this.sequence_ != null)
                {
                    return this.sequence_; 
                }
                else if (this.sequenceIDRef_ != null)
                {
                    sequence_ = IDManager.getID(sequenceIDRef_) as XsdTypePositiveInteger;
                    return this.sequence_; 
                }
                else
                {
                      return this.sequence_; 
                }
            }
            set
            {
                if (this.sequence_ != value)
                {
                    this.sequence_ = value;
                }
            }
        }
        #endregion
        
        public string sequenceIDRef_ { get; set; }
        
    
        
    
    }
    
}


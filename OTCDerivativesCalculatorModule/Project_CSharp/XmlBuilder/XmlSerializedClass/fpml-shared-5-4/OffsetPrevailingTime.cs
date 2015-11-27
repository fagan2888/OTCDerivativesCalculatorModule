using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OffsetPrevailingTime : ISerialized
    {
        public OffsetPrevailingTime(XmlNode xmlNode)
        {
            XmlNode timeNode = xmlNode.SelectSingleNode("time");
            
            if (timeNode != null)
            {
                if (timeNode.Attributes["href"] != null || timeNode.Attributes["id"] != null) 
                {
                    if (timeNode.Attributes["id"] != null) 
                    {
                        timeIDRef_ = timeNode.Attributes["id"].Value;
                        PrevailingTime ob = new PrevailingTime(timeNode);
                        IDManager.SetID(timeIDRef_, ob);
                    }
                    else if (timeNode.Attributes["href"] != null)
                    {
                        timeIDRef_ = timeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        time_ = new PrevailingTime(timeNode);
                    }
                }
                else
                {
                    time_ = new PrevailingTime(timeNode);
                }
            }
            
        
            XmlNode offsetNode = xmlNode.SelectSingleNode("offset");
            
            if (offsetNode != null)
            {
                if (offsetNode.Attributes["href"] != null || offsetNode.Attributes["id"] != null) 
                {
                    if (offsetNode.Attributes["id"] != null) 
                    {
                        offsetIDRef_ = offsetNode.Attributes["id"].Value;
                        Offset ob = new Offset(offsetNode);
                        IDManager.SetID(offsetIDRef_, ob);
                    }
                    else if (offsetNode.Attributes["href"] != null)
                    {
                        offsetIDRef_ = offsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        offset_ = new Offset(offsetNode);
                    }
                }
                else
                {
                    offset_ = new Offset(offsetNode);
                }
            }
            
        
        }
        
    
        #region Time_
        private PrevailingTime time_;
        public PrevailingTime Time_
        {
            get
            {
                if (this.time_ != null)
                {
                    return this.time_; 
                }
                else if (this.timeIDRef_ != null)
                {
                    time_ = IDManager.getID(timeIDRef_) as PrevailingTime;
                    return this.time_; 
                }
                else
                {
                      return this.time_; 
                }
            }
            set
            {
                if (this.time_ != value)
                {
                    this.time_ = value;
                }
            }
        }
        #endregion
        
        public string timeIDRef_ { get; set; }
        #region Offset_
        private Offset offset_;
        public Offset Offset_
        {
            get
            {
                if (this.offset_ != null)
                {
                    return this.offset_; 
                }
                else if (this.offsetIDRef_ != null)
                {
                    offset_ = IDManager.getID(offsetIDRef_) as Offset;
                    return this.offset_; 
                }
                else
                {
                      return this.offset_; 
                }
            }
            set
            {
                if (this.offset_ != value)
                {
                    this.offset_ = value;
                }
            }
        }
        #endregion
        
        public string offsetIDRef_ { get; set; }
        
    
        
    
    }
    
}


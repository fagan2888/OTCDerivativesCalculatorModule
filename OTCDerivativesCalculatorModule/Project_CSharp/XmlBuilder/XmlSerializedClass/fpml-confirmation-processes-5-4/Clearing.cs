using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Clearing : ISerialized
    {
        public Clearing(XmlNode xmlNode)
        {
            XmlNode submittedNode = xmlNode.SelectSingleNode("submitted");
            
            if (submittedNode != null)
            {
                if (submittedNode.Attributes["href"] != null || submittedNode.Attributes["id"] != null) 
                {
                    if (submittedNode.Attributes["id"] != null) 
                    {
                        submittedIDRef_ = submittedNode.Attributes["id"].Value;
                        TradeWrapper ob = new TradeWrapper(submittedNode);
                        IDManager.SetID(submittedIDRef_, ob);
                    }
                    else if (submittedNode.Attributes["href"] != null)
                    {
                        submittedIDRef_ = submittedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        submitted_ = new TradeWrapper(submittedNode);
                    }
                }
                else
                {
                    submitted_ = new TradeWrapper(submittedNode);
                }
            }
            
        
            XmlNodeList clearedNodeList = xmlNode.SelectNodes("cleared");
            
            if (clearedNodeList != null)
            {
                this.cleared_ = new List<TradeWrapper>();
                foreach (XmlNode item in clearedNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            clearedIDRef_ = item.Attributes["id"].Value;
                            cleared_.Add(new TradeWrapper(item));
                            IDManager.SetID(clearedIDRef_, cleared_[cleared_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            clearedIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        cleared_.Add(new TradeWrapper(item));
                        }
                    }
                    else
                    {
                        cleared_.Add(new TradeWrapper(item));
                    }
                }
            }
            
        
        }
        
    
        #region Submitted_
        private TradeWrapper submitted_;
        public TradeWrapper Submitted_
        {
            get
            {
                if (this.submitted_ != null)
                {
                    return this.submitted_; 
                }
                else if (this.submittedIDRef_ != null)
                {
                    submitted_ = IDManager.getID(submittedIDRef_) as TradeWrapper;
                    return this.submitted_; 
                }
                else
                {
                      return this.submitted_; 
                }
            }
            set
            {
                if (this.submitted_ != value)
                {
                    this.submitted_ = value;
                }
            }
        }
        #endregion
        
        public string submittedIDRef_ { get; set; }
        #region Cleared_
        private List<TradeWrapper> cleared_;
        public List<TradeWrapper> Cleared_
        {
            get
            {
                if (this.cleared_ != null)
                {
                    return this.cleared_; 
                }
                else if (this.clearedIDRef_ != null)
                {
                    return this.cleared_; 
                }
                else
                {
                      return this.cleared_; 
                }
            }
            set
            {
                if (this.cleared_ != value)
                {
                    this.cleared_ = value;
                }
            }
        }
        #endregion
        
        public string clearedIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Stub : StubValue
    {
        public Stub(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode stubStartDateNode = xmlNode.SelectSingleNode("stubStartDate");
            
            if (stubStartDateNode != null)
            {
                if (stubStartDateNode.Attributes["href"] != null || stubStartDateNode.Attributes["id"] != null) 
                {
                    if (stubStartDateNode.Attributes["id"] != null) 
                    {
                        stubStartDateIDRef_ = stubStartDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(stubStartDateNode);
                        IDManager.SetID(stubStartDateIDRef_, ob);
                    }
                    else if (stubStartDateNode.Attributes["href"] != null)
                    {
                        stubStartDateIDRef_ = stubStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubStartDate_ = new AdjustableOrRelativeDate(stubStartDateNode);
                    }
                }
                else
                {
                    stubStartDate_ = new AdjustableOrRelativeDate(stubStartDateNode);
                }
            }
            
        
            XmlNode stubEndDateNode = xmlNode.SelectSingleNode("stubEndDate");
            
            if (stubEndDateNode != null)
            {
                if (stubEndDateNode.Attributes["href"] != null || stubEndDateNode.Attributes["id"] != null) 
                {
                    if (stubEndDateNode.Attributes["id"] != null) 
                    {
                        stubEndDateIDRef_ = stubEndDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(stubEndDateNode);
                        IDManager.SetID(stubEndDateIDRef_, ob);
                    }
                    else if (stubEndDateNode.Attributes["href"] != null)
                    {
                        stubEndDateIDRef_ = stubEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubEndDate_ = new AdjustableOrRelativeDate(stubEndDateNode);
                    }
                }
                else
                {
                    stubEndDate_ = new AdjustableOrRelativeDate(stubEndDateNode);
                }
            }
            
        
        }
        
    
        #region StubStartDate_
        private AdjustableOrRelativeDate stubStartDate_;
        public AdjustableOrRelativeDate StubStartDate_
        {
            get
            {
                if (this.stubStartDate_ != null)
                {
                    return this.stubStartDate_; 
                }
                else if (this.stubStartDateIDRef_ != null)
                {
                    stubStartDate_ = IDManager.getID(stubStartDateIDRef_) as AdjustableOrRelativeDate;
                    return this.stubStartDate_; 
                }
                else
                {
                      return this.stubStartDate_; 
                }
            }
            set
            {
                if (this.stubStartDate_ != value)
                {
                    this.stubStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string stubStartDateIDRef_ { get; set; }
        #region StubEndDate_
        private AdjustableOrRelativeDate stubEndDate_;
        public AdjustableOrRelativeDate StubEndDate_
        {
            get
            {
                if (this.stubEndDate_ != null)
                {
                    return this.stubEndDate_; 
                }
                else if (this.stubEndDateIDRef_ != null)
                {
                    stubEndDate_ = IDManager.getID(stubEndDateIDRef_) as AdjustableOrRelativeDate;
                    return this.stubEndDate_; 
                }
                else
                {
                      return this.stubEndDate_; 
                }
            }
            set
            {
                if (this.stubEndDate_ != value)
                {
                    this.stubEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string stubEndDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


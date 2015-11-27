using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Asian : ISerialized
    {
        public Asian(XmlNode xmlNode)
        {
            XmlNode averagingInOutNode = xmlNode.SelectSingleNode("averagingInOut");
            
            if (averagingInOutNode != null)
            {
                if (averagingInOutNode.Attributes["href"] != null || averagingInOutNode.Attributes["id"] != null) 
                {
                    if (averagingInOutNode.Attributes["id"] != null) 
                    {
                        averagingInOutIDRef_ = averagingInOutNode.Attributes["id"].Value;
                        AveragingInOutEnum ob = new AveragingInOutEnum(averagingInOutNode);
                        IDManager.SetID(averagingInOutIDRef_, ob);
                    }
                    else if (averagingInOutNode.Attributes["href"] != null)
                    {
                        averagingInOutIDRef_ = averagingInOutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingInOut_ = new AveragingInOutEnum(averagingInOutNode);
                    }
                }
                else
                {
                    averagingInOut_ = new AveragingInOutEnum(averagingInOutNode);
                }
            }
            
        
            XmlNode strikeFactorNode = xmlNode.SelectSingleNode("strikeFactor");
            
            if (strikeFactorNode != null)
            {
                if (strikeFactorNode.Attributes["href"] != null || strikeFactorNode.Attributes["id"] != null) 
                {
                    if (strikeFactorNode.Attributes["id"] != null) 
                    {
                        strikeFactorIDRef_ = strikeFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(strikeFactorNode);
                        IDManager.SetID(strikeFactorIDRef_, ob);
                    }
                    else if (strikeFactorNode.Attributes["href"] != null)
                    {
                        strikeFactorIDRef_ = strikeFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeFactor_ = new XsdTypeDecimal(strikeFactorNode);
                    }
                }
                else
                {
                    strikeFactor_ = new XsdTypeDecimal(strikeFactorNode);
                }
            }
            
        
            XmlNode averagingPeriodInNode = xmlNode.SelectSingleNode("averagingPeriodIn");
            
            if (averagingPeriodInNode != null)
            {
                if (averagingPeriodInNode.Attributes["href"] != null || averagingPeriodInNode.Attributes["id"] != null) 
                {
                    if (averagingPeriodInNode.Attributes["id"] != null) 
                    {
                        averagingPeriodInIDRef_ = averagingPeriodInNode.Attributes["id"].Value;
                        AveragingPeriod ob = new AveragingPeriod(averagingPeriodInNode);
                        IDManager.SetID(averagingPeriodInIDRef_, ob);
                    }
                    else if (averagingPeriodInNode.Attributes["href"] != null)
                    {
                        averagingPeriodInIDRef_ = averagingPeriodInNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingPeriodIn_ = new AveragingPeriod(averagingPeriodInNode);
                    }
                }
                else
                {
                    averagingPeriodIn_ = new AveragingPeriod(averagingPeriodInNode);
                }
            }
            
        
            XmlNode averagingPeriodOutNode = xmlNode.SelectSingleNode("averagingPeriodOut");
            
            if (averagingPeriodOutNode != null)
            {
                if (averagingPeriodOutNode.Attributes["href"] != null || averagingPeriodOutNode.Attributes["id"] != null) 
                {
                    if (averagingPeriodOutNode.Attributes["id"] != null) 
                    {
                        averagingPeriodOutIDRef_ = averagingPeriodOutNode.Attributes["id"].Value;
                        AveragingPeriod ob = new AveragingPeriod(averagingPeriodOutNode);
                        IDManager.SetID(averagingPeriodOutIDRef_, ob);
                    }
                    else if (averagingPeriodOutNode.Attributes["href"] != null)
                    {
                        averagingPeriodOutIDRef_ = averagingPeriodOutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingPeriodOut_ = new AveragingPeriod(averagingPeriodOutNode);
                    }
                }
                else
                {
                    averagingPeriodOut_ = new AveragingPeriod(averagingPeriodOutNode);
                }
            }
            
        
        }
        
    
        #region AveragingInOut_
        private AveragingInOutEnum averagingInOut_;
        public AveragingInOutEnum AveragingInOut_
        {
            get
            {
                if (this.averagingInOut_ != null)
                {
                    return this.averagingInOut_; 
                }
                else if (this.averagingInOutIDRef_ != null)
                {
                    averagingInOut_ = IDManager.getID(averagingInOutIDRef_) as AveragingInOutEnum;
                    return this.averagingInOut_; 
                }
                else
                {
                      return this.averagingInOut_; 
                }
            }
            set
            {
                if (this.averagingInOut_ != value)
                {
                    this.averagingInOut_ = value;
                }
            }
        }
        #endregion
        
        public string averagingInOutIDRef_ { get; set; }
        #region StrikeFactor_
        private XsdTypeDecimal strikeFactor_;
        public XsdTypeDecimal StrikeFactor_
        {
            get
            {
                if (this.strikeFactor_ != null)
                {
                    return this.strikeFactor_; 
                }
                else if (this.strikeFactorIDRef_ != null)
                {
                    strikeFactor_ = IDManager.getID(strikeFactorIDRef_) as XsdTypeDecimal;
                    return this.strikeFactor_; 
                }
                else
                {
                      return this.strikeFactor_; 
                }
            }
            set
            {
                if (this.strikeFactor_ != value)
                {
                    this.strikeFactor_ = value;
                }
            }
        }
        #endregion
        
        public string strikeFactorIDRef_ { get; set; }
        #region AveragingPeriodIn_
        private AveragingPeriod averagingPeriodIn_;
        public AveragingPeriod AveragingPeriodIn_
        {
            get
            {
                if (this.averagingPeriodIn_ != null)
                {
                    return this.averagingPeriodIn_; 
                }
                else if (this.averagingPeriodInIDRef_ != null)
                {
                    averagingPeriodIn_ = IDManager.getID(averagingPeriodInIDRef_) as AveragingPeriod;
                    return this.averagingPeriodIn_; 
                }
                else
                {
                      return this.averagingPeriodIn_; 
                }
            }
            set
            {
                if (this.averagingPeriodIn_ != value)
                {
                    this.averagingPeriodIn_ = value;
                }
            }
        }
        #endregion
        
        public string averagingPeriodInIDRef_ { get; set; }
        #region AveragingPeriodOut_
        private AveragingPeriod averagingPeriodOut_;
        public AveragingPeriod AveragingPeriodOut_
        {
            get
            {
                if (this.averagingPeriodOut_ != null)
                {
                    return this.averagingPeriodOut_; 
                }
                else if (this.averagingPeriodOutIDRef_ != null)
                {
                    averagingPeriodOut_ = IDManager.getID(averagingPeriodOutIDRef_) as AveragingPeriod;
                    return this.averagingPeriodOut_; 
                }
                else
                {
                      return this.averagingPeriodOut_; 
                }
            }
            set
            {
                if (this.averagingPeriodOut_ != value)
                {
                    this.averagingPeriodOut_ = value;
                }
            }
        }
        #endregion
        
        public string averagingPeriodOutIDRef_ { get; set; }
        
    
        
    
    }
    
}


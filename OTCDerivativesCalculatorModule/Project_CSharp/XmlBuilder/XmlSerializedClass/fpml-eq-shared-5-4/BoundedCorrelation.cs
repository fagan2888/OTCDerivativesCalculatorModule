using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BoundedCorrelation : ISerialized
    {
        public BoundedCorrelation(XmlNode xmlNode)
        {
            XmlNode minimumBoundaryPercentNode = xmlNode.SelectSingleNode("minimumBoundaryPercent");
            
            if (minimumBoundaryPercentNode != null)
            {
                if (minimumBoundaryPercentNode.Attributes["href"] != null || minimumBoundaryPercentNode.Attributes["id"] != null) 
                {
                    if (minimumBoundaryPercentNode.Attributes["id"] != null) 
                    {
                        minimumBoundaryPercentIDRef_ = minimumBoundaryPercentNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(minimumBoundaryPercentNode);
                        IDManager.SetID(minimumBoundaryPercentIDRef_, ob);
                    }
                    else if (minimumBoundaryPercentNode.Attributes["href"] != null)
                    {
                        minimumBoundaryPercentIDRef_ = minimumBoundaryPercentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumBoundaryPercent_ = new XsdTypeDecimal(minimumBoundaryPercentNode);
                    }
                }
                else
                {
                    minimumBoundaryPercent_ = new XsdTypeDecimal(minimumBoundaryPercentNode);
                }
            }
            
        
            XmlNode maximumBoundaryPercentNode = xmlNode.SelectSingleNode("maximumBoundaryPercent");
            
            if (maximumBoundaryPercentNode != null)
            {
                if (maximumBoundaryPercentNode.Attributes["href"] != null || maximumBoundaryPercentNode.Attributes["id"] != null) 
                {
                    if (maximumBoundaryPercentNode.Attributes["id"] != null) 
                    {
                        maximumBoundaryPercentIDRef_ = maximumBoundaryPercentNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(maximumBoundaryPercentNode);
                        IDManager.SetID(maximumBoundaryPercentIDRef_, ob);
                    }
                    else if (maximumBoundaryPercentNode.Attributes["href"] != null)
                    {
                        maximumBoundaryPercentIDRef_ = maximumBoundaryPercentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumBoundaryPercent_ = new XsdTypeDecimal(maximumBoundaryPercentNode);
                    }
                }
                else
                {
                    maximumBoundaryPercent_ = new XsdTypeDecimal(maximumBoundaryPercentNode);
                }
            }
            
        
        }
        
    
        #region MinimumBoundaryPercent_
        private XsdTypeDecimal minimumBoundaryPercent_;
        public XsdTypeDecimal MinimumBoundaryPercent_
        {
            get
            {
                if (this.minimumBoundaryPercent_ != null)
                {
                    return this.minimumBoundaryPercent_; 
                }
                else if (this.minimumBoundaryPercentIDRef_ != null)
                {
                    minimumBoundaryPercent_ = IDManager.getID(minimumBoundaryPercentIDRef_) as XsdTypeDecimal;
                    return this.minimumBoundaryPercent_; 
                }
                else
                {
                      return this.minimumBoundaryPercent_; 
                }
            }
            set
            {
                if (this.minimumBoundaryPercent_ != value)
                {
                    this.minimumBoundaryPercent_ = value;
                }
            }
        }
        #endregion
        
        public string minimumBoundaryPercentIDRef_ { get; set; }
        #region MaximumBoundaryPercent_
        private XsdTypeDecimal maximumBoundaryPercent_;
        public XsdTypeDecimal MaximumBoundaryPercent_
        {
            get
            {
                if (this.maximumBoundaryPercent_ != null)
                {
                    return this.maximumBoundaryPercent_; 
                }
                else if (this.maximumBoundaryPercentIDRef_ != null)
                {
                    maximumBoundaryPercent_ = IDManager.getID(maximumBoundaryPercentIDRef_) as XsdTypeDecimal;
                    return this.maximumBoundaryPercent_; 
                }
                else
                {
                      return this.maximumBoundaryPercent_; 
                }
            }
            set
            {
                if (this.maximumBoundaryPercent_ != value)
                {
                    this.maximumBoundaryPercent_ = value;
                }
            }
        }
        #endregion
        
        public string maximumBoundaryPercentIDRef_ { get; set; }
        
    
        
    
    }
    
}


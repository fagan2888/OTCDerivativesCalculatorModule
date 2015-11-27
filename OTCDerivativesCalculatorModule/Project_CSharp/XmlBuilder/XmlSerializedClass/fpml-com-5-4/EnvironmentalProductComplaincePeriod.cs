using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EnvironmentalProductComplaincePeriod : ISerialized
    {
        public EnvironmentalProductComplaincePeriod(XmlNode xmlNode)
        {
            XmlNode startYearNode = xmlNode.SelectSingleNode("startYear");
            
            if (startYearNode != null)
            {
                if (startYearNode.Attributes["href"] != null || startYearNode.Attributes["id"] != null) 
                {
                    if (startYearNode.Attributes["id"] != null) 
                    {
                        startYearIDRef_ = startYearNode.Attributes["id"].Value;
                        XsdTypeGYear ob = new XsdTypeGYear(startYearNode);
                        IDManager.SetID(startYearIDRef_, ob);
                    }
                    else if (startYearNode.Attributes["href"] != null)
                    {
                        startYearIDRef_ = startYearNode.Attributes["href"].Value;
                    }
                    else
                    {
                        startYear_ = new XsdTypeGYear(startYearNode);
                    }
                }
                else
                {
                    startYear_ = new XsdTypeGYear(startYearNode);
                }
            }
            
        
            XmlNode endYearNode = xmlNode.SelectSingleNode("endYear");
            
            if (endYearNode != null)
            {
                if (endYearNode.Attributes["href"] != null || endYearNode.Attributes["id"] != null) 
                {
                    if (endYearNode.Attributes["id"] != null) 
                    {
                        endYearIDRef_ = endYearNode.Attributes["id"].Value;
                        XsdTypeGYear ob = new XsdTypeGYear(endYearNode);
                        IDManager.SetID(endYearIDRef_, ob);
                    }
                    else if (endYearNode.Attributes["href"] != null)
                    {
                        endYearIDRef_ = endYearNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endYear_ = new XsdTypeGYear(endYearNode);
                    }
                }
                else
                {
                    endYear_ = new XsdTypeGYear(endYearNode);
                }
            }
            
        
        }
        
    
        #region StartYear_
        private XsdTypeGYear startYear_;
        public XsdTypeGYear StartYear_
        {
            get
            {
                if (this.startYear_ != null)
                {
                    return this.startYear_; 
                }
                else if (this.startYearIDRef_ != null)
                {
                    startYear_ = IDManager.getID(startYearIDRef_) as XsdTypeGYear;
                    return this.startYear_; 
                }
                else
                {
                      return this.startYear_; 
                }
            }
            set
            {
                if (this.startYear_ != value)
                {
                    this.startYear_ = value;
                }
            }
        }
        #endregion
        
        public string startYearIDRef_ { get; set; }
        #region EndYear_
        private XsdTypeGYear endYear_;
        public XsdTypeGYear EndYear_
        {
            get
            {
                if (this.endYear_ != null)
                {
                    return this.endYear_; 
                }
                else if (this.endYearIDRef_ != null)
                {
                    endYear_ = IDManager.getID(endYearIDRef_) as XsdTypeGYear;
                    return this.endYear_; 
                }
                else
                {
                      return this.endYear_; 
                }
            }
            set
            {
                if (this.endYear_ != value)
                {
                    this.endYear_ = value;
                }
            }
        }
        #endregion
        
        public string endYearIDRef_ { get; set; }
        
    
        
    
    }
    
}


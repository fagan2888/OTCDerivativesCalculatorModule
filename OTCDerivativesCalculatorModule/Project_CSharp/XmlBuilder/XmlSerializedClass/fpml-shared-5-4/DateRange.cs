using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DateRange : ISerialized
    {
        public DateRange(XmlNode xmlNode)
        {
            XmlNode unadjustedFirstDateNode = xmlNode.SelectSingleNode("unadjustedFirstDate");
            
            if (unadjustedFirstDateNode != null)
            {
                if (unadjustedFirstDateNode.Attributes["href"] != null || unadjustedFirstDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedFirstDateNode.Attributes["id"] != null) 
                    {
                        unadjustedFirstDateIDRef_ = unadjustedFirstDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedFirstDateNode);
                        IDManager.SetID(unadjustedFirstDateIDRef_, ob);
                    }
                    else if (unadjustedFirstDateNode.Attributes["href"] != null)
                    {
                        unadjustedFirstDateIDRef_ = unadjustedFirstDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedFirstDate_ = new XsdTypeDate(unadjustedFirstDateNode);
                    }
                }
                else
                {
                    unadjustedFirstDate_ = new XsdTypeDate(unadjustedFirstDateNode);
                }
            }
            
        
            XmlNode unadjustedLastDateNode = xmlNode.SelectSingleNode("unadjustedLastDate");
            
            if (unadjustedLastDateNode != null)
            {
                if (unadjustedLastDateNode.Attributes["href"] != null || unadjustedLastDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedLastDateNode.Attributes["id"] != null) 
                    {
                        unadjustedLastDateIDRef_ = unadjustedLastDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedLastDateNode);
                        IDManager.SetID(unadjustedLastDateIDRef_, ob);
                    }
                    else if (unadjustedLastDateNode.Attributes["href"] != null)
                    {
                        unadjustedLastDateIDRef_ = unadjustedLastDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedLastDate_ = new XsdTypeDate(unadjustedLastDateNode);
                    }
                }
                else
                {
                    unadjustedLastDate_ = new XsdTypeDate(unadjustedLastDateNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedFirstDate_
        private XsdTypeDate unadjustedFirstDate_;
        public XsdTypeDate UnadjustedFirstDate_
        {
            get
            {
                if (this.unadjustedFirstDate_ != null)
                {
                    return this.unadjustedFirstDate_; 
                }
                else if (this.unadjustedFirstDateIDRef_ != null)
                {
                    unadjustedFirstDate_ = IDManager.getID(unadjustedFirstDateIDRef_) as XsdTypeDate;
                    return this.unadjustedFirstDate_; 
                }
                else
                {
                      return this.unadjustedFirstDate_; 
                }
            }
            set
            {
                if (this.unadjustedFirstDate_ != value)
                {
                    this.unadjustedFirstDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedFirstDateIDRef_ { get; set; }
        #region UnadjustedLastDate_
        private XsdTypeDate unadjustedLastDate_;
        public XsdTypeDate UnadjustedLastDate_
        {
            get
            {
                if (this.unadjustedLastDate_ != null)
                {
                    return this.unadjustedLastDate_; 
                }
                else if (this.unadjustedLastDateIDRef_ != null)
                {
                    unadjustedLastDate_ = IDManager.getID(unadjustedLastDateIDRef_) as XsdTypeDate;
                    return this.unadjustedLastDate_; 
                }
                else
                {
                      return this.unadjustedLastDate_; 
                }
            }
            set
            {
                if (this.unadjustedLastDate_ != value)
                {
                    this.unadjustedLastDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedLastDateIDRef_ { get; set; }
        
    
        
    
    }
    
}


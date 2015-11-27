using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixingDays : ISerialized
    {
        public FixingDays(XmlNode xmlNode)
        {
            XmlNode daysNode = xmlNode.SelectSingleNode("days");
            
            if (daysNode != null)
            {
                if (daysNode.Attributes["href"] != null || daysNode.Attributes["id"] != null) 
                {
                    if (daysNode.Attributes["id"] != null) 
                    {
                        daysIDRef_ = daysNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(daysNode);
                        IDManager.SetID(daysIDRef_, ob);
                    }
                    else if (daysNode.Attributes["href"] != null)
                    {
                        daysIDRef_ = daysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        days_ = new XsdTypeInteger(daysNode);
                    }
                }
                else
                {
                    days_ = new XsdTypeInteger(daysNode);
                }
            }
            
        
            XmlNode monthsNode = xmlNode.SelectSingleNode("months");
            
            if (monthsNode != null)
            {
                if (monthsNode.Attributes["href"] != null || monthsNode.Attributes["id"] != null) 
                {
                    if (monthsNode.Attributes["id"] != null) 
                    {
                        monthsIDRef_ = monthsNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(monthsNode);
                        IDManager.SetID(monthsIDRef_, ob);
                    }
                    else if (monthsNode.Attributes["href"] != null)
                    {
                        monthsIDRef_ = monthsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        months_ = new XsdTypeInteger(monthsNode);
                    }
                }
                else
                {
                    months_ = new XsdTypeInteger(monthsNode);
                }
            }
            
        
            XmlNode yearsNode = xmlNode.SelectSingleNode("years");
            
            if (yearsNode != null)
            {
                if (yearsNode.Attributes["href"] != null || yearsNode.Attributes["id"] != null) 
                {
                    if (yearsNode.Attributes["id"] != null) 
                    {
                        yearsIDRef_ = yearsNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(yearsNode);
                        IDManager.SetID(yearsIDRef_, ob);
                    }
                    else if (yearsNode.Attributes["href"] != null)
                    {
                        yearsIDRef_ = yearsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        years_ = new XsdTypeInteger(yearsNode);
                    }
                }
                else
                {
                    years_ = new XsdTypeInteger(yearsNode);
                }
            }
            
        
        }
        
    
        #region Days_
        private XsdTypeInteger days_;
        public XsdTypeInteger Days_
        {
            get
            {
                if (this.days_ != null)
                {
                    return this.days_; 
                }
                else if (this.daysIDRef_ != null)
                {
                    days_ = IDManager.getID(daysIDRef_) as XsdTypeInteger;
                    return this.days_; 
                }
                else
                {
                      return this.days_; 
                }
            }
            set
            {
                if (this.days_ != value)
                {
                    this.days_ = value;
                }
            }
        }
        #endregion
        
        public string daysIDRef_ { get; set; }
        #region Months_
        private XsdTypeInteger months_;
        public XsdTypeInteger Months_
        {
            get
            {
                if (this.months_ != null)
                {
                    return this.months_; 
                }
                else if (this.monthsIDRef_ != null)
                {
                    months_ = IDManager.getID(monthsIDRef_) as XsdTypeInteger;
                    return this.months_; 
                }
                else
                {
                      return this.months_; 
                }
            }
            set
            {
                if (this.months_ != value)
                {
                    this.months_ = value;
                }
            }
        }
        #endregion
        
        public string monthsIDRef_ { get; set; }
        #region Years_
        private XsdTypeInteger years_;
        public XsdTypeInteger Years_
        {
            get
            {
                if (this.years_ != null)
                {
                    return this.years_; 
                }
                else if (this.yearsIDRef_ != null)
                {
                    years_ = IDManager.getID(yearsIDRef_) as XsdTypeInteger;
                    return this.years_; 
                }
                else
                {
                      return this.years_; 
                }
            }
            set
            {
                if (this.years_ != value)
                {
                    this.years_ = value;
                }
            }
        }
        #endregion
        
        public string yearsIDRef_ { get; set; }
        public string choiceStr_fixingType;
        
    
        
    
    }
    
}


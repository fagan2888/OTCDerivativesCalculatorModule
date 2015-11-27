using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fixedCouponScheduleList : ISerialized
    {
        public Excel_fixedCouponScheduleList() { }
        public Excel_fixedCouponScheduleList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeToken(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeToken(fixedRateNode);
                }
            }
            
        
            XmlNode dayCounterNode = xmlNode.SelectSingleNode("dayCounter");
            
            if (dayCounterNode != null)
            {
                if (dayCounterNode.Attributes["href"] != null || dayCounterNode.Attributes["id"] != null) 
                {
                    if (dayCounterNode.Attributes["id"] != null) 
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dayCounterNode);
                        IDManager.SetID(dayCounterIDRef_, ob);
                    }
                    else if (dayCounterNode.Attributes["href"] != null)
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCounter_ = new XsdTypeToken(dayCounterNode);
                    }
                }
                else
                {
                    dayCounter_ = new XsdTypeToken(dayCounterNode);
                }
            }
            
        
            XmlNodeList excel_couponScheduleNodeList = xmlNode.SelectNodes("excel_couponSchedule");
            
            if (excel_couponScheduleNodeList != null)
            {
                this.excel_couponSchedule_ = new List<Excel_couponSchedule>();
                foreach (XmlNode item in excel_couponScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_couponScheduleIDRef_ = item.Attributes["id"].Value;
                            excel_couponSchedule_.Add(new Excel_couponSchedule(item));
                            IDManager.SetID(excel_couponScheduleIDRef_, excel_couponSchedule_[excel_couponSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_couponScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_couponSchedule_.Add(new Excel_couponSchedule(item));
                        }
                    }
                    else
                    {
                        excel_couponSchedule_.Add(new Excel_couponSchedule(item));
                    }
                }
            }
            
        
        }
        
    
        #region FixedRate_
        private XsdTypeToken fixedRate_;
        public XsdTypeToken FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeToken;
                    return this.fixedRate_; 
                }
                else
                {
                    throw new Exception( "fixedRate_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
        #region DayCounter_
        private XsdTypeToken dayCounter_;
        public XsdTypeToken DayCounter_
        {
            get
            {
                if (this.dayCounter_ != null)
                {
                    return this.dayCounter_; 
                }
                else if (this.dayCounterIDRef_ != null)
                {
                    dayCounter_ = IDManager.getID(dayCounterIDRef_) as XsdTypeToken;
                    return this.dayCounter_; 
                }
                else
                {
                    throw new Exception( "dayCounter_Node no exist!");
                }
            }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                }
            }
        }
        #endregion
        
        public string dayCounterIDRef_ { get; set; }
        #region Excel_couponSchedule_
        private List<Excel_couponSchedule> excel_couponSchedule_;
        public List<Excel_couponSchedule> Excel_couponSchedule_
        {
            get
            {
                if (this.excel_couponSchedule_ != null)
                {
                    return this.excel_couponSchedule_; 
                }
                else if (this.excel_couponScheduleIDRef_ != null)
                {
                    return this.excel_couponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_couponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_couponSchedule_ != value)
                {
                    this.excel_couponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_couponScheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaFloatingCouponScheduleList : ISerialized
    {
        public Excel_vanillaFloatingCouponScheduleList() { }
        public Excel_vanillaFloatingCouponScheduleList(XmlNode xmlNode)
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
            
        
            XmlNodeList excel_vanillaFloatingCouponScheduleNodeList = xmlNode.SelectNodes("excel_vanillaFloatingCouponSchedule");
            
            if (excel_vanillaFloatingCouponScheduleNodeList != null)
            {
                this.excel_vanillaFloatingCouponSchedule_ = new List<Excel_vanillaFloatingCouponSchedule>();
                foreach (XmlNode item in excel_vanillaFloatingCouponScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_vanillaFloatingCouponScheduleIDRef_ = item.Attributes["id"].Value;
                            excel_vanillaFloatingCouponSchedule_.Add(new Excel_vanillaFloatingCouponSchedule(item));
                            IDManager.SetID(excel_vanillaFloatingCouponScheduleIDRef_, excel_vanillaFloatingCouponSchedule_[excel_vanillaFloatingCouponSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_vanillaFloatingCouponScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_vanillaFloatingCouponSchedule_.Add(new Excel_vanillaFloatingCouponSchedule(item));
                        }
                    }
                    else
                    {
                        excel_vanillaFloatingCouponSchedule_.Add(new Excel_vanillaFloatingCouponSchedule(item));
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
        #region Excel_vanillaFloatingCouponSchedule_
        private List<Excel_vanillaFloatingCouponSchedule> excel_vanillaFloatingCouponSchedule_;
        public List<Excel_vanillaFloatingCouponSchedule> Excel_vanillaFloatingCouponSchedule_
        {
            get
            {
                if (this.excel_vanillaFloatingCouponSchedule_ != null)
                {
                    return this.excel_vanillaFloatingCouponSchedule_; 
                }
                else if (this.excel_vanillaFloatingCouponScheduleIDRef_ != null)
                {
                    return this.excel_vanillaFloatingCouponSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingCouponSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingCouponSchedule_ != value)
                {
                    this.excel_vanillaFloatingCouponSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingCouponScheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_couponScheduleList : ISerialized
    {
        public Excel_couponScheduleList() { }
        public Excel_couponScheduleList(XmlNode xmlNode)
        : base(xmlNode)
        {
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


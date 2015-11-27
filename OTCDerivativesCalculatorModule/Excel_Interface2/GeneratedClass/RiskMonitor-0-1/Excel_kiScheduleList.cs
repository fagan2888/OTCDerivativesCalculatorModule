using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_kiScheduleList : ISerialized
    {
        public Excel_kiScheduleList() { }
        public Excel_kiScheduleList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_scheduleNodeList = xmlNode.SelectNodes("excel_schedule");
            
            if (excel_scheduleNodeList != null)
            {
                this.excel_schedule_ = new List<Excel_schedule>();
                foreach (XmlNode item in excel_scheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_scheduleIDRef_ = item.Attributes["id"].Value;
                            excel_schedule_.Add(new Excel_schedule(item));
                            IDManager.SetID(excel_scheduleIDRef_, excel_schedule_[excel_schedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_scheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_schedule_.Add(new Excel_schedule(item));
                        }
                    }
                    else
                    {
                        excel_schedule_.Add(new Excel_schedule(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_schedule_
        private List<Excel_schedule> excel_schedule_;
        public List<Excel_schedule> Excel_schedule_
        {
            get
            {
                if (this.excel_schedule_ != null)
                {
                    return this.excel_schedule_; 
                }
                else if (this.excel_scheduleIDRef_ != null)
                {
                    return this.excel_schedule_; 
                }
                else
                {
                    throw new Exception( "excel_schedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_schedule_ != value)
                {
                    this.excel_schedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_scheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}


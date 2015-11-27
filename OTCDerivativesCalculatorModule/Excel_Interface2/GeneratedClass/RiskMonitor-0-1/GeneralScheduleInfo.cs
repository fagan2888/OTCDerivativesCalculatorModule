using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeneralScheduleInfo : ISerialized
    {
        public GeneralScheduleInfo() { }
        public GeneralScheduleInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList generalScheduleNodeList = xmlNode.SelectNodes("generalSchedule");
            
            if (generalScheduleNodeList != null)
            {
                this.generalSchedule_ = new List<GeneralSchedule>();
                foreach (XmlNode item in generalScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            generalScheduleIDRef_ = item.Attributes["id"].Value;
                            generalSchedule_.Add(new GeneralSchedule(item));
                            IDManager.SetID(generalScheduleIDRef_, generalSchedule_[generalSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            generalScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        generalSchedule_.Add(new GeneralSchedule(item));
                        }
                    }
                    else
                    {
                        generalSchedule_.Add(new GeneralSchedule(item));
                    }
                }
            }
            
        
        }
        
    
        #region GeneralSchedule_
        private List<GeneralSchedule> generalSchedule_;
        public List<GeneralSchedule> GeneralSchedule_
        {
            get
            {
                if (this.generalSchedule_ != null)
                {
                    return this.generalSchedule_; 
                }
                else if (this.generalScheduleIDRef_ != null)
                {
                    return this.generalSchedule_; 
                }
                else
                {
                    throw new Exception( "generalSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.generalSchedule_ != value)
                {
                    this.generalSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string generalScheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_general : ISerialized
    {
        public Excel_general() { }
        public Excel_general(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_issueInfoNode = xmlNode.SelectSingleNode("excel_issueInfo");
            
            if (excel_issueInfoNode != null)
            {
                if (excel_issueInfoNode.Attributes["href"] != null || excel_issueInfoNode.Attributes["id"] != null) 
                {
                    if (excel_issueInfoNode.Attributes["id"] != null) 
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["id"].Value;
                        Excel_issueInfo ob = new Excel_issueInfo(excel_issueInfoNode);
                        IDManager.SetID(excel_issueInfoIDRef_, ob);
                    }
                    else if (excel_issueInfoNode.Attributes["href"] != null)
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                    }
                }
                else
                {
                    excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                }
            }
            
        
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
            
        
            XmlNodeList generalTerminationEventNodeList = xmlNode.SelectNodes("generalTerminationEvent");
            
            if (generalTerminationEventNodeList != null)
            {
                this.generalTerminationEvent_ = new List<GeneralTerminationEvent>();
                foreach (XmlNode item in generalTerminationEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            generalTerminationEventIDRef_ = item.Attributes["id"].Value;
                            generalTerminationEvent_.Add(new GeneralTerminationEvent(item));
                            IDManager.SetID(generalTerminationEventIDRef_, generalTerminationEvent_[generalTerminationEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            generalTerminationEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        generalTerminationEvent_.Add(new GeneralTerminationEvent(item));
                        }
                    }
                    else
                    {
                        generalTerminationEvent_.Add(new GeneralTerminationEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region Excel_issueInfo_
        private Excel_issueInfo excel_issueInfo_;
        public Excel_issueInfo Excel_issueInfo_
        {
            get
            {
                if (this.excel_issueInfo_ != null)
                {
                    return this.excel_issueInfo_; 
                }
                else if (this.excel_issueInfoIDRef_ != null)
                {
                    excel_issueInfo_ = IDManager.getID(excel_issueInfoIDRef_) as Excel_issueInfo;
                    return this.excel_issueInfo_; 
                }
                else
                {
                    throw new Exception( "excel_issueInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_issueInfo_ != value)
                {
                    this.excel_issueInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_issueInfoIDRef_ { get; set; }
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
        #region GeneralTerminationEvent_
        private List<GeneralTerminationEvent> generalTerminationEvent_;
        public List<GeneralTerminationEvent> GeneralTerminationEvent_
        {
            get
            {
                if (this.generalTerminationEvent_ != null)
                {
                    return this.generalTerminationEvent_; 
                }
                else if (this.generalTerminationEventIDRef_ != null)
                {
                    return this.generalTerminationEvent_; 
                }
                else
                {
                    throw new Exception( "generalTerminationEvent_Node no exist!");
                }
            }
            set
            {
                if (this.generalTerminationEvent_ != value)
                {
                    this.generalTerminationEvent_ = value;
                }
            }
        }
        #endregion
        
        public string generalTerminationEventIDRef_ { get; set; }
        
    
        
    
    }
    
}


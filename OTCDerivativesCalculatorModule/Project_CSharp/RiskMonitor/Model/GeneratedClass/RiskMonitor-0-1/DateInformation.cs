using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DateInformation : ISerialized
    {
        public DateInformation() { }
        public DateInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode dailyIntervalNode = xmlNode.SelectSingleNode("dailyInterval");
            
            if (dailyIntervalNode != null)
            {
                if (dailyIntervalNode.Attributes["href"] != null || dailyIntervalNode.Attributes["id"] != null) 
                {
                    if (dailyIntervalNode.Attributes["id"] != null) 
                    {
                        dailyIntervalIDRef_ = dailyIntervalNode.Attributes["id"].Value;
                        DailyInterval ob = new DailyInterval(dailyIntervalNode);
                        IDManager.SetID(dailyIntervalIDRef_, ob);
                    }
                    else if (dailyIntervalNode.Attributes["href"] != null)
                    {
                        dailyIntervalIDRef_ = dailyIntervalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dailyInterval_ = new DailyInterval(dailyIntervalNode);
                    }
                }
                else
                {
                    dailyInterval_ = new DailyInterval(dailyIntervalNode);
                }
            }
            
        
            XmlNode dateListNode = xmlNode.SelectSingleNode("dateList");
            
            if (dateListNode != null)
            {
                if (dateListNode.Attributes["href"] != null || dateListNode.Attributes["id"] != null) 
                {
                    if (dateListNode.Attributes["id"] != null) 
                    {
                        dateListIDRef_ = dateListNode.Attributes["id"].Value;
                        DateList ob = new DateList(dateListNode);
                        IDManager.SetID(dateListIDRef_, ob);
                    }
                    else if (dateListNode.Attributes["href"] != null)
                    {
                        dateListIDRef_ = dateListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateList_ = new DateList(dateListNode);
                    }
                }
                else
                {
                    dateList_ = new DateList(dateListNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region DailyInterval_
        private DailyInterval dailyInterval_;
        public DailyInterval DailyInterval_
        {
            get
            {
                if (this.dailyInterval_ != null)
                {
                    return this.dailyInterval_; 
                }
                else if (this.dailyIntervalIDRef_ != null)
                {
                    dailyInterval_ = IDManager.getID(dailyIntervalIDRef_) as DailyInterval;
                    return this.dailyInterval_; 
                }
                else
                {
                    throw new Exception( "dailyInterval_Node no exist!");
                }
            }
            set
            {
                if (this.dailyInterval_ != value)
                {
                    this.dailyInterval_ = value;
                }
            }
        }
        #endregion
        
        public string dailyIntervalIDRef_ { get; set; }
        #region DateList_
        private DateList dateList_;
        public DateList DateList_
        {
            get
            {
                if (this.dateList_ != null)
                {
                    return this.dateList_; 
                }
                else if (this.dateListIDRef_ != null)
                {
                    dateList_ = IDManager.getID(dateListIDRef_) as DateList;
                    return this.dateList_; 
                }
                else
                {
                    throw new Exception( "dateList_Node no exist!");
                }
            }
            set
            {
                if (this.dateList_ != value)
                {
                    this.dateList_ = value;
                }
            }
        }
        #endregion
        
        public string dateListIDRef_ { get; set; }
        public string choiceStr_barrierDateType;
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_choiceUnderlyingCalcID : ISerialized
    {
        public Excel_choiceUnderlyingCalcID() { }
        public Excel_choiceUnderlyingCalcID(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_selectedUnderlyingNodeList = xmlNode.SelectNodes("excel_selectedUnderlying");
            
            if (excel_selectedUnderlyingNodeList != null)
            {
                this.excel_selectedUnderlying_ = new List<Excel_selectedUnderlying>();
                foreach (XmlNode item in excel_selectedUnderlyingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_selectedUnderlyingIDRef_ = item.Attributes["id"].Value;
                            excel_selectedUnderlying_.Add(new Excel_selectedUnderlying(item));
                            IDManager.SetID(excel_selectedUnderlyingIDRef_, excel_selectedUnderlying_[excel_selectedUnderlying_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_selectedUnderlyingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_selectedUnderlying_.Add(new Excel_selectedUnderlying(item));
                        }
                    }
                    else
                    {
                        excel_selectedUnderlying_.Add(new Excel_selectedUnderlying(item));
                    }
                }
            }
            
        
            XmlNode eventDateNode = xmlNode.SelectSingleNode("eventDate");
            
            if (eventDateNode != null)
            {
                if (eventDateNode.Attributes["href"] != null || eventDateNode.Attributes["id"] != null) 
                {
                    if (eventDateNode.Attributes["id"] != null) 
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(eventDateNode);
                        IDManager.SetID(eventDateIDRef_, ob);
                    }
                    else if (eventDateNode.Attributes["href"] != null)
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDate_ = new XsdTypeToken(eventDateNode);
                    }
                }
                else
                {
                    eventDate_ = new XsdTypeToken(eventDateNode);
                }
            }
            
        
            XmlNode averageDaysNode = xmlNode.SelectSingleNode("averageDays");
            
            if (averageDaysNode != null)
            {
                if (averageDaysNode.Attributes["href"] != null || averageDaysNode.Attributes["id"] != null) 
                {
                    if (averageDaysNode.Attributes["id"] != null) 
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(averageDaysNode);
                        IDManager.SetID(averageDaysIDRef_, ob);
                    }
                    else if (averageDaysNode.Attributes["href"] != null)
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averageDays_ = new XsdTypeToken(averageDaysNode);
                    }
                }
                else
                {
                    averageDays_ = new XsdTypeToken(averageDaysNode);
                }
            }
            
        
        }
        
    
        #region Excel_selectedUnderlying_
        private List<Excel_selectedUnderlying> excel_selectedUnderlying_;
        public List<Excel_selectedUnderlying> Excel_selectedUnderlying_
        {
            get
            {
                if (this.excel_selectedUnderlying_ != null)
                {
                    return this.excel_selectedUnderlying_; 
                }
                else if (this.excel_selectedUnderlyingIDRef_ != null)
                {
                    return this.excel_selectedUnderlying_; 
                }
                else
                {
                    throw new Exception( "excel_selectedUnderlying_Node no exist!");
                }
            }
            set
            {
                if (this.excel_selectedUnderlying_ != value)
                {
                    this.excel_selectedUnderlying_ = value;
                }
            }
        }
        #endregion
        
        public string excel_selectedUnderlyingIDRef_ { get; set; }
        #region EventDate_
        private XsdTypeToken eventDate_;
        public XsdTypeToken EventDate_
        {
            get
            {
                if (this.eventDate_ != null)
                {
                    return this.eventDate_; 
                }
                else if (this.eventDateIDRef_ != null)
                {
                    eventDate_ = IDManager.getID(eventDateIDRef_) as XsdTypeToken;
                    return this.eventDate_; 
                }
                else
                {
                    throw new Exception( "eventDate_Node no exist!");
                }
            }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateIDRef_ { get; set; }
        #region AverageDays_
        private XsdTypeToken averageDays_;
        public XsdTypeToken AverageDays_
        {
            get
            {
                if (this.averageDays_ != null)
                {
                    return this.averageDays_; 
                }
                else if (this.averageDaysIDRef_ != null)
                {
                    averageDays_ = IDManager.getID(averageDaysIDRef_) as XsdTypeToken;
                    return this.averageDays_; 
                }
                else
                {
                    throw new Exception( "averageDays_Node no exist!");
                }
            }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                }
            }
        }
        #endregion
        
        public string averageDaysIDRef_ { get; set; }
        
    
        
    
    }
    
}


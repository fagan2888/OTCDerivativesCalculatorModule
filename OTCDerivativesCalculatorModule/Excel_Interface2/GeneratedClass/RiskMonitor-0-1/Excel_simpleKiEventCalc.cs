using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_simpleKiEventCalc : ISerialized
    {
        public Excel_simpleKiEventCalc() { }
        public Excel_simpleKiEventCalc(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode payoffDateNode = xmlNode.SelectSingleNode("payoffDate");
            
            if (payoffDateNode != null)
            {
                if (payoffDateNode.Attributes["href"] != null || payoffDateNode.Attributes["id"] != null) 
                {
                    if (payoffDateNode.Attributes["id"] != null) 
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffDateNode);
                        IDManager.SetID(payoffDateIDRef_, ob);
                    }
                    else if (payoffDateNode.Attributes["href"] != null)
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDate_ = new XsdTypeToken(payoffDateNode);
                    }
                }
                else
                {
                    payoffDate_ = new XsdTypeToken(payoffDateNode);
                }
            }
            
        
            XmlNode vba_descriptionNode = xmlNode.SelectSingleNode("vba_description");
            
            if (vba_descriptionNode != null)
            {
                if (vba_descriptionNode.Attributes["href"] != null || vba_descriptionNode.Attributes["id"] != null) 
                {
                    if (vba_descriptionNode.Attributes["id"] != null) 
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(vba_descriptionNode);
                        IDManager.SetID(vba_descriptionIDRef_, ob);
                    }
                    else if (vba_descriptionNode.Attributes["href"] != null)
                    {
                        vba_descriptionIDRef_ = vba_descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vba_description_ = new XsdTypeToken(vba_descriptionNode);
                    }
                }
                else
                {
                    vba_description_ = new XsdTypeToken(vba_descriptionNode);
                }
            }
            
        
            XmlNode excel_eventCalcInfoNode = xmlNode.SelectSingleNode("excel_eventCalcInfo");
            
            if (excel_eventCalcInfoNode != null)
            {
                if (excel_eventCalcInfoNode.Attributes["href"] != null || excel_eventCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_eventCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_eventCalcInfoIDRef_ = excel_eventCalcInfoNode.Attributes["id"].Value;
                        Excel_eventCalcInfo ob = new Excel_eventCalcInfo(excel_eventCalcInfoNode);
                        IDManager.SetID(excel_eventCalcInfoIDRef_, ob);
                    }
                    else if (excel_eventCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_eventCalcInfoIDRef_ = excel_eventCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_eventCalcInfo_ = new Excel_eventCalcInfo(excel_eventCalcInfoNode);
                    }
                }
                else
                {
                    excel_eventCalcInfo_ = new Excel_eventCalcInfo(excel_eventCalcInfoNode);
                }
            }
            
        
            XmlNode excel_occReturnCalcInfoNode = xmlNode.SelectSingleNode("excel_occReturnCalcInfo");
            
            if (excel_occReturnCalcInfoNode != null)
            {
                if (excel_occReturnCalcInfoNode.Attributes["href"] != null || excel_occReturnCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_occReturnCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_occReturnCalcInfoIDRef_ = excel_occReturnCalcInfoNode.Attributes["id"].Value;
                        Excel_occReturnCalcInfo ob = new Excel_occReturnCalcInfo(excel_occReturnCalcInfoNode);
                        IDManager.SetID(excel_occReturnCalcInfoIDRef_, ob);
                    }
                    else if (excel_occReturnCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_occReturnCalcInfoIDRef_ = excel_occReturnCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_occReturnCalcInfo_ = new Excel_occReturnCalcInfo(excel_occReturnCalcInfoNode);
                    }
                }
                else
                {
                    excel_occReturnCalcInfo_ = new Excel_occReturnCalcInfo(excel_occReturnCalcInfoNode);
                }
            }
            
        
            XmlNode excel_noOccReturnCalcInfoNode = xmlNode.SelectSingleNode("excel_noOccReturnCalcInfo");
            
            if (excel_noOccReturnCalcInfoNode != null)
            {
                if (excel_noOccReturnCalcInfoNode.Attributes["href"] != null || excel_noOccReturnCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_noOccReturnCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_noOccReturnCalcInfoIDRef_ = excel_noOccReturnCalcInfoNode.Attributes["id"].Value;
                        Excel_noOccReturnCalcInfo ob = new Excel_noOccReturnCalcInfo(excel_noOccReturnCalcInfoNode);
                        IDManager.SetID(excel_noOccReturnCalcInfoIDRef_, ob);
                    }
                    else if (excel_noOccReturnCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_noOccReturnCalcInfoIDRef_ = excel_noOccReturnCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_noOccReturnCalcInfo_ = new Excel_noOccReturnCalcInfo(excel_noOccReturnCalcInfoNode);
                    }
                }
                else
                {
                    excel_noOccReturnCalcInfo_ = new Excel_noOccReturnCalcInfo(excel_noOccReturnCalcInfoNode);
                }
            }
            
        
        }
        
    
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
        #region PayoffDate_
        private XsdTypeToken payoffDate_;
        public XsdTypeToken PayoffDate_
        {
            get
            {
                if (this.payoffDate_ != null)
                {
                    return this.payoffDate_; 
                }
                else if (this.payoffDateIDRef_ != null)
                {
                    payoffDate_ = IDManager.getID(payoffDateIDRef_) as XsdTypeToken;
                    return this.payoffDate_; 
                }
                else
                {
                    throw new Exception( "payoffDate_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateIDRef_ { get; set; }
        #region Vba_description_
        private XsdTypeToken vba_description_;
        public XsdTypeToken Vba_description_
        {
            get
            {
                if (this.vba_description_ != null)
                {
                    return this.vba_description_; 
                }
                else if (this.vba_descriptionIDRef_ != null)
                {
                    vba_description_ = IDManager.getID(vba_descriptionIDRef_) as XsdTypeToken;
                    return this.vba_description_; 
                }
                else
                {
                    throw new Exception( "vba_description_Node no exist!");
                }
            }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                }
            }
        }
        #endregion
        
        public string vba_descriptionIDRef_ { get; set; }
        #region Excel_eventCalcInfo_
        private Excel_eventCalcInfo excel_eventCalcInfo_;
        public Excel_eventCalcInfo Excel_eventCalcInfo_
        {
            get
            {
                if (this.excel_eventCalcInfo_ != null)
                {
                    return this.excel_eventCalcInfo_; 
                }
                else if (this.excel_eventCalcInfoIDRef_ != null)
                {
                    excel_eventCalcInfo_ = IDManager.getID(excel_eventCalcInfoIDRef_) as Excel_eventCalcInfo;
                    return this.excel_eventCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_eventCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_eventCalcInfo_ != value)
                {
                    this.excel_eventCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_eventCalcInfoIDRef_ { get; set; }
        #region Excel_occReturnCalcInfo_
        private Excel_occReturnCalcInfo excel_occReturnCalcInfo_;
        public Excel_occReturnCalcInfo Excel_occReturnCalcInfo_
        {
            get
            {
                if (this.excel_occReturnCalcInfo_ != null)
                {
                    return this.excel_occReturnCalcInfo_; 
                }
                else if (this.excel_occReturnCalcInfoIDRef_ != null)
                {
                    excel_occReturnCalcInfo_ = IDManager.getID(excel_occReturnCalcInfoIDRef_) as Excel_occReturnCalcInfo;
                    return this.excel_occReturnCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_occReturnCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_occReturnCalcInfo_ != value)
                {
                    this.excel_occReturnCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_occReturnCalcInfoIDRef_ { get; set; }
        #region Excel_noOccReturnCalcInfo_
        private Excel_noOccReturnCalcInfo excel_noOccReturnCalcInfo_;
        public Excel_noOccReturnCalcInfo Excel_noOccReturnCalcInfo_
        {
            get
            {
                if (this.excel_noOccReturnCalcInfo_ != null)
                {
                    return this.excel_noOccReturnCalcInfo_; 
                }
                else if (this.excel_noOccReturnCalcInfoIDRef_ != null)
                {
                    excel_noOccReturnCalcInfo_ = IDManager.getID(excel_noOccReturnCalcInfoIDRef_) as Excel_noOccReturnCalcInfo;
                    return this.excel_noOccReturnCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_noOccReturnCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_noOccReturnCalcInfo_ != value)
                {
                    this.excel_noOccReturnCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_noOccReturnCalcInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}


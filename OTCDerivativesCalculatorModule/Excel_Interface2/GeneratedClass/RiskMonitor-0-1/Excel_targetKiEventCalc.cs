using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_targetKiEventCalc : ISerialized
    {
        public Excel_targetKiEventCalc() { }
        public Excel_targetKiEventCalc(XmlNode xmlNode)
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
            
        
            XmlNode targetCountNode = xmlNode.SelectSingleNode("targetCount");
            
            if (targetCountNode != null)
            {
                if (targetCountNode.Attributes["href"] != null || targetCountNode.Attributes["id"] != null) 
                {
                    if (targetCountNode.Attributes["id"] != null) 
                    {
                        targetCountIDRef_ = targetCountNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(targetCountNode);
                        IDManager.SetID(targetCountIDRef_, ob);
                    }
                    else if (targetCountNode.Attributes["href"] != null)
                    {
                        targetCountIDRef_ = targetCountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        targetCount_ = new XsdTypeToken(targetCountNode);
                    }
                }
                else
                {
                    targetCount_ = new XsdTypeToken(targetCountNode);
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
        #region TargetCount_
        private XsdTypeToken targetCount_;
        public XsdTypeToken TargetCount_
        {
            get
            {
                if (this.targetCount_ != null)
                {
                    return this.targetCount_; 
                }
                else if (this.targetCountIDRef_ != null)
                {
                    targetCount_ = IDManager.getID(targetCountIDRef_) as XsdTypeToken;
                    return this.targetCount_; 
                }
                else
                {
                    throw new Exception( "targetCount_Node no exist!");
                }
            }
            set
            {
                if (this.targetCount_ != value)
                {
                    this.targetCount_ = value;
                }
            }
        }
        #endregion
        
        public string targetCountIDRef_ { get; set; }
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
        
    
        
    
    }
    
}


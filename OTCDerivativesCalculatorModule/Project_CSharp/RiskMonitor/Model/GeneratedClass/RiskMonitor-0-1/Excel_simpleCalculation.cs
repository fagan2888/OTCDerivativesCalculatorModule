using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_simpleCalculation : ISerialized
    {
        public Excel_simpleCalculation() { }
        public Excel_simpleCalculation(XmlNode xmlNode)
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
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeToken(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeToken(descriptionNode);
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
            
        
            XmlNode excel_returnCalcInfoNode = xmlNode.SelectSingleNode("excel_returnCalcInfo");
            
            if (excel_returnCalcInfoNode != null)
            {
                if (excel_returnCalcInfoNode.Attributes["href"] != null || excel_returnCalcInfoNode.Attributes["id"] != null) 
                {
                    if (excel_returnCalcInfoNode.Attributes["id"] != null) 
                    {
                        excel_returnCalcInfoIDRef_ = excel_returnCalcInfoNode.Attributes["id"].Value;
                        Excel_returnCalcInfo ob = new Excel_returnCalcInfo(excel_returnCalcInfoNode);
                        IDManager.SetID(excel_returnCalcInfoIDRef_, ob);
                    }
                    else if (excel_returnCalcInfoNode.Attributes["href"] != null)
                    {
                        excel_returnCalcInfoIDRef_ = excel_returnCalcInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_returnCalcInfo_ = new Excel_returnCalcInfo(excel_returnCalcInfoNode);
                    }
                }
                else
                {
                    excel_returnCalcInfo_ = new Excel_returnCalcInfo(excel_returnCalcInfoNode);
                }
            }
            
        
            XmlNode excel_complementReturnCalcNode = xmlNode.SelectSingleNode("excel_complementReturnCalc");
            
            if (excel_complementReturnCalcNode != null)
            {
                if (excel_complementReturnCalcNode.Attributes["href"] != null || excel_complementReturnCalcNode.Attributes["id"] != null) 
                {
                    if (excel_complementReturnCalcNode.Attributes["id"] != null) 
                    {
                        excel_complementReturnCalcIDRef_ = excel_complementReturnCalcNode.Attributes["id"].Value;
                        Excel_complementReturnCalc ob = new Excel_complementReturnCalc(excel_complementReturnCalcNode);
                        IDManager.SetID(excel_complementReturnCalcIDRef_, ob);
                    }
                    else if (excel_complementReturnCalcNode.Attributes["href"] != null)
                    {
                        excel_complementReturnCalcIDRef_ = excel_complementReturnCalcNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_complementReturnCalc_ = new Excel_complementReturnCalc(excel_complementReturnCalcNode);
                    }
                }
                else
                {
                    excel_complementReturnCalc_ = new Excel_complementReturnCalc(excel_complementReturnCalcNode);
                }
            }
            
        
            XmlNode excel_eventCalcInfo_CallNode = xmlNode.SelectSingleNode("excel_eventCalcInfo_Call");
            
            if (excel_eventCalcInfo_CallNode != null)
            {
                if (excel_eventCalcInfo_CallNode.Attributes["href"] != null || excel_eventCalcInfo_CallNode.Attributes["id"] != null) 
                {
                    if (excel_eventCalcInfo_CallNode.Attributes["id"] != null) 
                    {
                        excel_eventCalcInfo_CallIDRef_ = excel_eventCalcInfo_CallNode.Attributes["id"].Value;
                        Excel_eventCalcInfo_Call ob = new Excel_eventCalcInfo_Call(excel_eventCalcInfo_CallNode);
                        IDManager.SetID(excel_eventCalcInfo_CallIDRef_, ob);
                    }
                    else if (excel_eventCalcInfo_CallNode.Attributes["href"] != null)
                    {
                        excel_eventCalcInfo_CallIDRef_ = excel_eventCalcInfo_CallNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_eventCalcInfo_Call_ = new Excel_eventCalcInfo_Call(excel_eventCalcInfo_CallNode);
                    }
                }
                else
                {
                    excel_eventCalcInfo_Call_ = new Excel_eventCalcInfo_Call(excel_eventCalcInfo_CallNode);
                }
            }
            
        
            XmlNode excel_returnCalcInfo_CallNode = xmlNode.SelectSingleNode("excel_returnCalcInfo_Call");
            
            if (excel_returnCalcInfo_CallNode != null)
            {
                if (excel_returnCalcInfo_CallNode.Attributes["href"] != null || excel_returnCalcInfo_CallNode.Attributes["id"] != null) 
                {
                    if (excel_returnCalcInfo_CallNode.Attributes["id"] != null) 
                    {
                        excel_returnCalcInfo_CallIDRef_ = excel_returnCalcInfo_CallNode.Attributes["id"].Value;
                        Excel_returnCalcInfo_Call ob = new Excel_returnCalcInfo_Call(excel_returnCalcInfo_CallNode);
                        IDManager.SetID(excel_returnCalcInfo_CallIDRef_, ob);
                    }
                    else if (excel_returnCalcInfo_CallNode.Attributes["href"] != null)
                    {
                        excel_returnCalcInfo_CallIDRef_ = excel_returnCalcInfo_CallNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_returnCalcInfo_Call_ = new Excel_returnCalcInfo_Call(excel_returnCalcInfo_CallNode);
                    }
                }
                else
                {
                    excel_returnCalcInfo_Call_ = new Excel_returnCalcInfo_Call(excel_returnCalcInfo_CallNode);
                }
            }
            
        
            XmlNode excel_complementReturnCalc_CallNode = xmlNode.SelectSingleNode("excel_complementReturnCalc_Call");
            
            if (excel_complementReturnCalc_CallNode != null)
            {
                if (excel_complementReturnCalc_CallNode.Attributes["href"] != null || excel_complementReturnCalc_CallNode.Attributes["id"] != null) 
                {
                    if (excel_complementReturnCalc_CallNode.Attributes["id"] != null) 
                    {
                        excel_complementReturnCalc_CallIDRef_ = excel_complementReturnCalc_CallNode.Attributes["id"].Value;
                        Excel_complementReturnCalc_Call ob = new Excel_complementReturnCalc_Call(excel_complementReturnCalc_CallNode);
                        IDManager.SetID(excel_complementReturnCalc_CallIDRef_, ob);
                    }
                    else if (excel_complementReturnCalc_CallNode.Attributes["href"] != null)
                    {
                        excel_complementReturnCalc_CallIDRef_ = excel_complementReturnCalc_CallNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_complementReturnCalc_Call_ = new Excel_complementReturnCalc_Call(excel_complementReturnCalc_CallNode);
                    }
                }
                else
                {
                    excel_complementReturnCalc_Call_ = new Excel_complementReturnCalc_Call(excel_complementReturnCalc_CallNode);
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
        #region Description_
        private XsdTypeToken description_;
        public XsdTypeToken Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeToken;
                    return this.description_; 
                }
                else
                {
                    throw new Exception( "description_Node no exist!");
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
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
        #region Excel_returnCalcInfo_
        private Excel_returnCalcInfo excel_returnCalcInfo_;
        public Excel_returnCalcInfo Excel_returnCalcInfo_
        {
            get
            {
                if (this.excel_returnCalcInfo_ != null)
                {
                    return this.excel_returnCalcInfo_; 
                }
                else if (this.excel_returnCalcInfoIDRef_ != null)
                {
                    excel_returnCalcInfo_ = IDManager.getID(excel_returnCalcInfoIDRef_) as Excel_returnCalcInfo;
                    return this.excel_returnCalcInfo_; 
                }
                else
                {
                    throw new Exception( "excel_returnCalcInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_returnCalcInfo_ != value)
                {
                    this.excel_returnCalcInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_returnCalcInfoIDRef_ { get; set; }
        #region Excel_complementReturnCalc_
        private Excel_complementReturnCalc excel_complementReturnCalc_;
        public Excel_complementReturnCalc Excel_complementReturnCalc_
        {
            get
            {
                if (this.excel_complementReturnCalc_ != null)
                {
                    return this.excel_complementReturnCalc_; 
                }
                else if (this.excel_complementReturnCalcIDRef_ != null)
                {
                    excel_complementReturnCalc_ = IDManager.getID(excel_complementReturnCalcIDRef_) as Excel_complementReturnCalc;
                    return this.excel_complementReturnCalc_; 
                }
                else
                {
                    throw new Exception( "excel_complementReturnCalc_Node no exist!");
                }
            }
            set
            {
                if (this.excel_complementReturnCalc_ != value)
                {
                    this.excel_complementReturnCalc_ = value;
                }
            }
        }
        #endregion
        
        public string excel_complementReturnCalcIDRef_ { get; set; }
        #region Excel_eventCalcInfo_Call_
        private Excel_eventCalcInfo_Call excel_eventCalcInfo_Call_;
        public Excel_eventCalcInfo_Call Excel_eventCalcInfo_Call_
        {
            get
            {
                if (this.excel_eventCalcInfo_Call_ != null)
                {
                    return this.excel_eventCalcInfo_Call_; 
                }
                else if (this.excel_eventCalcInfo_CallIDRef_ != null)
                {
                    excel_eventCalcInfo_Call_ = IDManager.getID(excel_eventCalcInfo_CallIDRef_) as Excel_eventCalcInfo_Call;
                    return this.excel_eventCalcInfo_Call_; 
                }
                else
                {
                    throw new Exception( "excel_eventCalcInfo_Call_Node no exist!");
                }
            }
            set
            {
                if (this.excel_eventCalcInfo_Call_ != value)
                {
                    this.excel_eventCalcInfo_Call_ = value;
                }
            }
        }
        #endregion
        
        public string excel_eventCalcInfo_CallIDRef_ { get; set; }
        #region Excel_returnCalcInfo_Call_
        private Excel_returnCalcInfo_Call excel_returnCalcInfo_Call_;
        public Excel_returnCalcInfo_Call Excel_returnCalcInfo_Call_
        {
            get
            {
                if (this.excel_returnCalcInfo_Call_ != null)
                {
                    return this.excel_returnCalcInfo_Call_; 
                }
                else if (this.excel_returnCalcInfo_CallIDRef_ != null)
                {
                    excel_returnCalcInfo_Call_ = IDManager.getID(excel_returnCalcInfo_CallIDRef_) as Excel_returnCalcInfo_Call;
                    return this.excel_returnCalcInfo_Call_; 
                }
                else
                {
                    throw new Exception( "excel_returnCalcInfo_Call_Node no exist!");
                }
            }
            set
            {
                if (this.excel_returnCalcInfo_Call_ != value)
                {
                    this.excel_returnCalcInfo_Call_ = value;
                }
            }
        }
        #endregion
        
        public string excel_returnCalcInfo_CallIDRef_ { get; set; }
        #region Excel_complementReturnCalc_Call_
        private Excel_complementReturnCalc_Call excel_complementReturnCalc_Call_;
        public Excel_complementReturnCalc_Call Excel_complementReturnCalc_Call_
        {
            get
            {
                if (this.excel_complementReturnCalc_Call_ != null)
                {
                    return this.excel_complementReturnCalc_Call_; 
                }
                else if (this.excel_complementReturnCalc_CallIDRef_ != null)
                {
                    excel_complementReturnCalc_Call_ = IDManager.getID(excel_complementReturnCalc_CallIDRef_) as Excel_complementReturnCalc_Call;
                    return this.excel_complementReturnCalc_Call_; 
                }
                else
                {
                    throw new Exception( "excel_complementReturnCalc_Call_Node no exist!");
                }
            }
            set
            {
                if (this.excel_complementReturnCalc_Call_ != value)
                {
                    this.excel_complementReturnCalc_Call_ = value;
                }
            }
        }
        #endregion
        
        public string excel_complementReturnCalc_CallIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_floatingCouponSchedule : ISerialized
    {
        public Excel_floatingCouponSchedule() { }
        public Excel_floatingCouponSchedule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode gearingNode = xmlNode.SelectSingleNode("gearing");
            
            if (gearingNode != null)
            {
                if (gearingNode.Attributes["href"] != null || gearingNode.Attributes["id"] != null) 
                {
                    if (gearingNode.Attributes["id"] != null) 
                    {
                        gearingIDRef_ = gearingNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(gearingNode);
                        IDManager.SetID(gearingIDRef_, ob);
                    }
                    else if (gearingNode.Attributes["href"] != null)
                    {
                        gearingIDRef_ = gearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gearing_ = new XsdTypeToken(gearingNode);
                    }
                }
                else
                {
                    gearing_ = new XsdTypeToken(gearingNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeToken(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeToken(spreadNode);
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
            
        
        }
        
    
        #region Gearing_
        private XsdTypeToken gearing_;
        public XsdTypeToken Gearing_
        {
            get
            {
                if (this.gearing_ != null)
                {
                    return this.gearing_; 
                }
                else if (this.gearingIDRef_ != null)
                {
                    gearing_ = IDManager.getID(gearingIDRef_) as XsdTypeToken;
                    return this.gearing_; 
                }
                else
                {
                    throw new Exception( "gearing_Node no exist!");
                }
            }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                }
            }
        }
        #endregion
        
        public string gearingIDRef_ { get; set; }
        #region Spread_
        private XsdTypeToken spread_;
        public XsdTypeToken Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeToken;
                    return this.spread_; 
                }
                else
                {
                    throw new Exception( "spread_Node no exist!");
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
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
        
    
        
    
    }
    
}


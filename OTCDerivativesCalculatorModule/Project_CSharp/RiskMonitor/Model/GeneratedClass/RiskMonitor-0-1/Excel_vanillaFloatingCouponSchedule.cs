using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaFloatingCouponSchedule : ISerialized
    {
        public Excel_vanillaFloatingCouponSchedule() { }
        public Excel_vanillaFloatingCouponSchedule(XmlNode xmlNode)
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
            
        
            XmlNode excel_underlyingCalcIDNode = xmlNode.SelectSingleNode("excel_underlyingCalcID");
            
            if (excel_underlyingCalcIDNode != null)
            {
                if (excel_underlyingCalcIDNode.Attributes["href"] != null || excel_underlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["id"].Value;
                        Excel_underlyingCalcID ob = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                        IDManager.SetID(excel_underlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_underlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
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
        #region Excel_underlyingCalcID_
        private Excel_underlyingCalcID excel_underlyingCalcID_;
        public Excel_underlyingCalcID Excel_underlyingCalcID_
        {
            get
            {
                if (this.excel_underlyingCalcID_ != null)
                {
                    return this.excel_underlyingCalcID_; 
                }
                else if (this.excel_underlyingCalcIDIDRef_ != null)
                {
                    excel_underlyingCalcID_ = IDManager.getID(excel_underlyingCalcIDIDRef_) as Excel_underlyingCalcID;
                    return this.excel_underlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcID_ != value)
                {
                    this.excel_underlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcIDIDRef_ { get; set; }
        
    
        
    
    }
    
}


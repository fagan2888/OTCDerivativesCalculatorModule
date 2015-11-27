using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_protectionTerms : ISerialized
    {
        public Excel_protectionTerms() { }
        public Excel_protectionTerms(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_creditEventsNode = xmlNode.SelectSingleNode("excel_creditEvents");
            
            if (excel_creditEventsNode != null)
            {
                if (excel_creditEventsNode.Attributes["href"] != null || excel_creditEventsNode.Attributes["id"] != null) 
                {
                    if (excel_creditEventsNode.Attributes["id"] != null) 
                    {
                        excel_creditEventsIDRef_ = excel_creditEventsNode.Attributes["id"].Value;
                        Excel_creditEvents ob = new Excel_creditEvents(excel_creditEventsNode);
                        IDManager.SetID(excel_creditEventsIDRef_, ob);
                    }
                    else if (excel_creditEventsNode.Attributes["href"] != null)
                    {
                        excel_creditEventsIDRef_ = excel_creditEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_creditEvents_ = new Excel_creditEvents(excel_creditEventsNode);
                    }
                }
                else
                {
                    excel_creditEvents_ = new Excel_creditEvents(excel_creditEventsNode);
                }
            }
            
        
            XmlNode excel_obligationsNode = xmlNode.SelectSingleNode("excel_obligations");
            
            if (excel_obligationsNode != null)
            {
                if (excel_obligationsNode.Attributes["href"] != null || excel_obligationsNode.Attributes["id"] != null) 
                {
                    if (excel_obligationsNode.Attributes["id"] != null) 
                    {
                        excel_obligationsIDRef_ = excel_obligationsNode.Attributes["id"].Value;
                        Excel_obligations ob = new Excel_obligations(excel_obligationsNode);
                        IDManager.SetID(excel_obligationsIDRef_, ob);
                    }
                    else if (excel_obligationsNode.Attributes["href"] != null)
                    {
                        excel_obligationsIDRef_ = excel_obligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_obligations_ = new Excel_obligations(excel_obligationsNode);
                    }
                }
                else
                {
                    excel_obligations_ = new Excel_obligations(excel_obligationsNode);
                }
            }
            
        
            XmlNode accrualCouponNode = xmlNode.SelectSingleNode("accrualCoupon");
            
            if (accrualCouponNode != null)
            {
                if (accrualCouponNode.Attributes["href"] != null || accrualCouponNode.Attributes["id"] != null) 
                {
                    if (accrualCouponNode.Attributes["id"] != null) 
                    {
                        accrualCouponIDRef_ = accrualCouponNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(accrualCouponNode);
                        IDManager.SetID(accrualCouponIDRef_, ob);
                    }
                    else if (accrualCouponNode.Attributes["href"] != null)
                    {
                        accrualCouponIDRef_ = accrualCouponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accrualCoupon_ = new XsdTypeBoolean(accrualCouponNode);
                    }
                }
                else
                {
                    accrualCoupon_ = new XsdTypeBoolean(accrualCouponNode);
                }
            }
            
        
        }
        
    
        #region Excel_creditEvents_
        private Excel_creditEvents excel_creditEvents_;
        public Excel_creditEvents Excel_creditEvents_
        {
            get
            {
                if (this.excel_creditEvents_ != null)
                {
                    return this.excel_creditEvents_; 
                }
                else if (this.excel_creditEventsIDRef_ != null)
                {
                    excel_creditEvents_ = IDManager.getID(excel_creditEventsIDRef_) as Excel_creditEvents;
                    return this.excel_creditEvents_; 
                }
                else
                {
                    throw new Exception( "excel_creditEvents_Node no exist!");
                }
            }
            set
            {
                if (this.excel_creditEvents_ != value)
                {
                    this.excel_creditEvents_ = value;
                }
            }
        }
        #endregion
        
        public string excel_creditEventsIDRef_ { get; set; }
        #region Excel_obligations_
        private Excel_obligations excel_obligations_;
        public Excel_obligations Excel_obligations_
        {
            get
            {
                if (this.excel_obligations_ != null)
                {
                    return this.excel_obligations_; 
                }
                else if (this.excel_obligationsIDRef_ != null)
                {
                    excel_obligations_ = IDManager.getID(excel_obligationsIDRef_) as Excel_obligations;
                    return this.excel_obligations_; 
                }
                else
                {
                    throw new Exception( "excel_obligations_Node no exist!");
                }
            }
            set
            {
                if (this.excel_obligations_ != value)
                {
                    this.excel_obligations_ = value;
                }
            }
        }
        #endregion
        
        public string excel_obligationsIDRef_ { get; set; }
        #region AccrualCoupon_
        private XsdTypeBoolean accrualCoupon_;
        public XsdTypeBoolean AccrualCoupon_
        {
            get
            {
                if (this.accrualCoupon_ != null)
                {
                    return this.accrualCoupon_; 
                }
                else if (this.accrualCouponIDRef_ != null)
                {
                    accrualCoupon_ = IDManager.getID(accrualCouponIDRef_) as XsdTypeBoolean;
                    return this.accrualCoupon_; 
                }
                else
                {
                    throw new Exception( "accrualCoupon_Node no exist!");
                }
            }
            set
            {
                if (this.accrualCoupon_ != value)
                {
                    this.accrualCoupon_ = value;
                }
            }
        }
        #endregion
        
        public string accrualCouponIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwapStreamPara : ISerialized
    {
        public SwapStreamPara() { }
        public SwapStreamPara(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeDouble(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeDouble(notionalNode);
                }
            }
            
        
            XmlNode discountCurve_paraNode = xmlNode.SelectSingleNode("discountCurve_para");
            
            if (discountCurve_paraNode != null)
            {
                if (discountCurve_paraNode.Attributes["href"] != null || discountCurve_paraNode.Attributes["id"] != null) 
                {
                    if (discountCurve_paraNode.Attributes["id"] != null) 
                    {
                        discountCurve_paraIDRef_ = discountCurve_paraNode.Attributes["id"].Value;
                        DiscountCurve_para ob = new DiscountCurve_para(discountCurve_paraNode);
                        IDManager.SetID(discountCurve_paraIDRef_, ob);
                    }
                    else if (discountCurve_paraNode.Attributes["href"] != null)
                    {
                        discountCurve_paraIDRef_ = discountCurve_paraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountCurve_para_ = new DiscountCurve_para(discountCurve_paraNode);
                    }
                }
                else
                {
                    discountCurve_para_ = new DiscountCurve_para(discountCurve_paraNode);
                }
            }
            
        
        }
        
    
        #region Notional_
        private XsdTypeDouble notional_;
        public XsdTypeDouble Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeDouble;
                    return this.notional_; 
                }
                else
                {
                    throw new Exception( "notional_Node no exist!");
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region DiscountCurve_para_
        private DiscountCurve_para discountCurve_para_;
        public DiscountCurve_para DiscountCurve_para_
        {
            get
            {
                if (this.discountCurve_para_ != null)
                {
                    return this.discountCurve_para_; 
                }
                else if (this.discountCurve_paraIDRef_ != null)
                {
                    discountCurve_para_ = IDManager.getID(discountCurve_paraIDRef_) as DiscountCurve_para;
                    return this.discountCurve_para_; 
                }
                else
                {
                    throw new Exception( "discountCurve_para_Node no exist!");
                }
            }
            set
            {
                if (this.discountCurve_para_ != value)
                {
                    this.discountCurve_para_ = value;
                }
            }
        }
        #endregion
        
        public string discountCurve_paraIDRef_ { get; set; }
        
    
        
    
    }
    
}


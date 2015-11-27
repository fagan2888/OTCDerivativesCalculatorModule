using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PaySwapPart : ISerialized
    {
        public PaySwapPart() { }
        public PaySwapPart(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payoffInfoNode = xmlNode.SelectSingleNode("payoffInfo");
            
            if (payoffInfoNode != null)
            {
                if (payoffInfoNode.Attributes["href"] != null || payoffInfoNode.Attributes["id"] != null) 
                {
                    if (payoffInfoNode.Attributes["id"] != null) 
                    {
                        payoffInfoIDRef_ = payoffInfoNode.Attributes["id"].Value;
                        PayoffInfo ob = new PayoffInfo(payoffInfoNode);
                        IDManager.SetID(payoffInfoIDRef_, ob);
                    }
                    else if (payoffInfoNode.Attributes["href"] != null)
                    {
                        payoffInfoIDRef_ = payoffInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffInfo_ = new PayoffInfo(payoffInfoNode);
                    }
                }
                else
                {
                    payoffInfo_ = new PayoffInfo(payoffInfoNode);
                }
            }
            
        
        }
        
    
        #region PayoffInfo_
        private PayoffInfo payoffInfo_;
        public PayoffInfo PayoffInfo_
        {
            get
            {
                if (this.payoffInfo_ != null)
                {
                    return this.payoffInfo_; 
                }
                else if (this.payoffInfoIDRef_ != null)
                {
                    payoffInfo_ = IDManager.getID(payoffInfoIDRef_) as PayoffInfo;
                    return this.payoffInfo_; 
                }
                else
                {
                    throw new Exception( "payoffInfo_Node no exist!");
                }
            }
            set
            {
                if (this.payoffInfo_ != value)
                {
                    this.payoffInfo_ = value;
                }
            }
        }
        #endregion
        
        public string payoffInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedPaymentLeg : DirectionalLeg
    {
        public FixedPaymentLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList fixedPaymentNodeList = xmlNode.SelectNodes("fixedPayment");
            
            if (fixedPaymentNodeList != null)
            {
                this.fixedPayment_ = new List<FixedPaymentAmount>();
                foreach (XmlNode item in fixedPaymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fixedPaymentIDRef_ = item.Attributes["id"].Value;
                            fixedPayment_.Add(new FixedPaymentAmount(item));
                            IDManager.SetID(fixedPaymentIDRef_, fixedPayment_[fixedPayment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fixedPaymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fixedPayment_.Add(new FixedPaymentAmount(item));
                        }
                    }
                    else
                    {
                        fixedPayment_.Add(new FixedPaymentAmount(item));
                    }
                }
            }
            
        
        }
        
    
        #region FixedPayment_
        private List<FixedPaymentAmount> fixedPayment_;
        public List<FixedPaymentAmount> FixedPayment_
        {
            get
            {
                if (this.fixedPayment_ != null)
                {
                    return this.fixedPayment_; 
                }
                else if (this.fixedPaymentIDRef_ != null)
                {
                    return this.fixedPayment_; 
                }
                else
                {
                      return this.fixedPayment_; 
                }
            }
            set
            {
                if (this.fixedPayment_ != value)
                {
                    this.fixedPayment_ = value;
                }
            }
        }
        #endregion
        
        public string fixedPaymentIDRef_ { get; set; }
        
    
        
    
    }
    
}


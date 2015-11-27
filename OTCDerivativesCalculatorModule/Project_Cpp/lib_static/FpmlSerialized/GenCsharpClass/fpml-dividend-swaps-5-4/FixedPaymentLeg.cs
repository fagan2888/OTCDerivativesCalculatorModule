using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FixedPaymentLeg
    {
        public FixedPaymentLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList fixedPaymentNodeList = xmlNode.SelectNodes("fixedPayment");
            
            foreach (XmlNode item in fixedPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedPaymentIDRef = item.Attributes["id"].Name;
                        List<FixedPaymentAmount> ob = new List<FixedPaymentAmount>();
                        ob.Add(new FixedPaymentAmount(item));
                        IDManager.SetID(fixedPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fixedPayment.Add(new FixedPaymentAmount(item));
                    }
                }
            }
            
        
        }
        
    
        #region FixedPayment
        private List<FixedPaymentAmount> fixedPayment;
        public List<FixedPaymentAmount> FixedPayment
        {
            get
            {
                if (this.fixedPayment != null)
                {
                    return this.fixedPayment; 
                }
                else if (this.fixedPaymentIDRef != null)
                {
                    fixedPayment = IDManager.getID(fixedPaymentIDRef) as List<FixedPaymentAmount>;
                    return this.fixedPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedPayment != value)
                {
                    this.fixedPayment = value;
                }
            }
        }
        #endregion
        
        public string FixedPaymentAmountIDRef { get; set; }
        
    
        
    
    }
    
}


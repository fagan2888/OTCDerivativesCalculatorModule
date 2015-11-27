using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdditionalPaymentAmount
    {
        public AdditionalPaymentAmount(XmlNode xmlNode)
        {
            XmlNodeList paymentAmountNodeList = xmlNode.SelectNodes("paymentAmount");
            if (paymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(paymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList formulaNodeList = xmlNode.SelectNodes("formula");
            if (formulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in formulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaIDRef = item.Attributes["id"].Name;
                        Formula ob = Formula();
                        IDManager.SetID(formulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        formula = new Formula(item);
                    }
                }
            }
            
        
        }
        
    
        #region PaymentAmount
        private NonNegativeMoney paymentAmount;
        public NonNegativeMoney PaymentAmount
        {
            get
            {
                if (this.paymentAmount != null)
                {
                    return this.paymentAmount; 
                }
                else if (this.paymentAmountIDRef != null)
                {
                    paymentAmount = IDManager.getID(paymentAmountIDRef) as NonNegativeMoney;
                    return this.paymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentAmount != value)
                {
                    this.paymentAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region Formula
        private Formula formula;
        public Formula Formula
        {
            get
            {
                if (this.formula != null)
                {
                    return this.formula; 
                }
                else if (this.formulaIDRef != null)
                {
                    formula = IDManager.getID(formulaIDRef) as Formula;
                    return this.formula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formula != value)
                {
                    this.formula = value;
                }
            }
        }
        #endregion
        
        public string FormulaIDRef { get; set; }
        
    
        
    
    }
    
}


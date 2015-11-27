using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referSimpleCalculation : ISerialized
    {
        public Excel_referSimpleCalculation() { }
        public Excel_referSimpleCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationIDNode = xmlNode.SelectSingleNode("calculationID");
            
            if (calculationIDNode != null)
            {
                if (calculationIDNode.Attributes["href"] != null || calculationIDNode.Attributes["id"] != null) 
                {
                    if (calculationIDNode.Attributes["id"] != null) 
                    {
                        calculationIDIDRef_ = calculationIDNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calculationIDNode);
                        IDManager.SetID(calculationIDIDRef_, ob);
                    }
                    else if (calculationIDNode.Attributes["href"] != null)
                    {
                        calculationIDIDRef_ = calculationIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationID_ = new XsdTypeToken(calculationIDNode);
                    }
                }
                else
                {
                    calculationID_ = new XsdTypeToken(calculationIDNode);
                }
            }
            
        
            XmlNode referenceTypeNode = xmlNode.SelectSingleNode("referenceType");
            
            if (referenceTypeNode != null)
            {
                if (referenceTypeNode.Attributes["href"] != null || referenceTypeNode.Attributes["id"] != null) 
                {
                    if (referenceTypeNode.Attributes["id"] != null) 
                    {
                        referenceTypeIDRef_ = referenceTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(referenceTypeNode);
                        IDManager.SetID(referenceTypeIDRef_, ob);
                    }
                    else if (referenceTypeNode.Attributes["href"] != null)
                    {
                        referenceTypeIDRef_ = referenceTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceType_ = new XsdTypeToken(referenceTypeNode);
                    }
                }
                else
                {
                    referenceType_ = new XsdTypeToken(referenceTypeNode);
                }
            }
            
        
            XmlNode referenceSetNode = xmlNode.SelectSingleNode("referenceSet");
            
            if (referenceSetNode != null)
            {
                if (referenceSetNode.Attributes["href"] != null || referenceSetNode.Attributes["id"] != null) 
                {
                    if (referenceSetNode.Attributes["id"] != null) 
                    {
                        referenceSetIDRef_ = referenceSetNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(referenceSetNode);
                        IDManager.SetID(referenceSetIDRef_, ob);
                    }
                    else if (referenceSetNode.Attributes["href"] != null)
                    {
                        referenceSetIDRef_ = referenceSetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceSet_ = new XsdTypeToken(referenceSetNode);
                    }
                }
                else
                {
                    referenceSet_ = new XsdTypeToken(referenceSetNode);
                }
            }
            
        
            XmlNode nthNode = xmlNode.SelectSingleNode("nth");
            
            if (nthNode != null)
            {
                if (nthNode.Attributes["href"] != null || nthNode.Attributes["id"] != null) 
                {
                    if (nthNode.Attributes["id"] != null) 
                    {
                        nthIDRef_ = nthNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nthNode);
                        IDManager.SetID(nthIDRef_, ob);
                    }
                    else if (nthNode.Attributes["href"] != null)
                    {
                        nthIDRef_ = nthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nth_ = new XsdTypeToken(nthNode);
                    }
                }
                else
                {
                    nth_ = new XsdTypeToken(nthNode);
                }
            }
            
        
            XmlNode averageDaysNode = xmlNode.SelectSingleNode("averageDays");
            
            if (averageDaysNode != null)
            {
                if (averageDaysNode.Attributes["href"] != null || averageDaysNode.Attributes["id"] != null) 
                {
                    if (averageDaysNode.Attributes["id"] != null) 
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(averageDaysNode);
                        IDManager.SetID(averageDaysIDRef_, ob);
                    }
                    else if (averageDaysNode.Attributes["href"] != null)
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averageDays_ = new XsdTypeToken(averageDaysNode);
                    }
                }
                else
                {
                    averageDays_ = new XsdTypeToken(averageDaysNode);
                }
            }
            
        
        }
        
    
        #region CalculationID_
        private XsdTypeToken calculationID_;
        public XsdTypeToken CalculationID_
        {
            get
            {
                if (this.calculationID_ != null)
                {
                    return this.calculationID_; 
                }
                else if (this.calculationIDIDRef_ != null)
                {
                    calculationID_ = IDManager.getID(calculationIDIDRef_) as XsdTypeToken;
                    return this.calculationID_; 
                }
                else
                {
                    throw new Exception( "calculationID_Node no exist!");
                }
            }
            set
            {
                if (this.calculationID_ != value)
                {
                    this.calculationID_ = value;
                }
            }
        }
        #endregion
        
        public string calculationIDIDRef_ { get; set; }
        #region ReferenceType_
        private XsdTypeToken referenceType_;
        public XsdTypeToken ReferenceType_
        {
            get
            {
                if (this.referenceType_ != null)
                {
                    return this.referenceType_; 
                }
                else if (this.referenceTypeIDRef_ != null)
                {
                    referenceType_ = IDManager.getID(referenceTypeIDRef_) as XsdTypeToken;
                    return this.referenceType_; 
                }
                else
                {
                    throw new Exception( "referenceType_Node no exist!");
                }
            }
            set
            {
                if (this.referenceType_ != value)
                {
                    this.referenceType_ = value;
                }
            }
        }
        #endregion
        
        public string referenceTypeIDRef_ { get; set; }
        #region ReferenceSet_
        private XsdTypeToken referenceSet_;
        public XsdTypeToken ReferenceSet_
        {
            get
            {
                if (this.referenceSet_ != null)
                {
                    return this.referenceSet_; 
                }
                else if (this.referenceSetIDRef_ != null)
                {
                    referenceSet_ = IDManager.getID(referenceSetIDRef_) as XsdTypeToken;
                    return this.referenceSet_; 
                }
                else
                {
                    throw new Exception( "referenceSet_Node no exist!");
                }
            }
            set
            {
                if (this.referenceSet_ != value)
                {
                    this.referenceSet_ = value;
                }
            }
        }
        #endregion
        
        public string referenceSetIDRef_ { get; set; }
        #region Nth_
        private XsdTypeToken nth_;
        public XsdTypeToken Nth_
        {
            get
            {
                if (this.nth_ != null)
                {
                    return this.nth_; 
                }
                else if (this.nthIDRef_ != null)
                {
                    nth_ = IDManager.getID(nthIDRef_) as XsdTypeToken;
                    return this.nth_; 
                }
                else
                {
                    throw new Exception( "nth_Node no exist!");
                }
            }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                }
            }
        }
        #endregion
        
        public string nthIDRef_ { get; set; }
        #region AverageDays_
        private XsdTypeToken averageDays_;
        public XsdTypeToken AverageDays_
        {
            get
            {
                if (this.averageDays_ != null)
                {
                    return this.averageDays_; 
                }
                else if (this.averageDaysIDRef_ != null)
                {
                    averageDays_ = IDManager.getID(averageDaysIDRef_) as XsdTypeToken;
                    return this.averageDays_; 
                }
                else
                {
                    throw new Exception( "averageDays_Node no exist!");
                }
            }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                }
            }
        }
        #endregion
        
        public string averageDaysIDRef_ { get; set; }
        
    
        
    
    }
    
}


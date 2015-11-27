using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StubValue : ISerialized
    {
        public StubValue(XmlNode xmlNode)
        {
            XmlNodeList floatingRateNodeList = xmlNode.SelectNodes("floatingRate");
            
            if (floatingRateNodeList != null)
            {
                this.floatingRate_ = new List<FloatingRate>();
                foreach (XmlNode item in floatingRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            floatingRateIDRef_ = item.Attributes["id"].Value;
                            floatingRate_.Add(new FloatingRate(item));
                            IDManager.SetID(floatingRateIDRef_, floatingRate_[floatingRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            floatingRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        floatingRate_.Add(new FloatingRate(item));
                        }
                    }
                    else
                    {
                        floatingRate_.Add(new FloatingRate(item));
                    }
                }
            }
            
        
            XmlNode stubRateNode = xmlNode.SelectSingleNode("stubRate");
            
            if (stubRateNode != null)
            {
                if (stubRateNode.Attributes["href"] != null || stubRateNode.Attributes["id"] != null) 
                {
                    if (stubRateNode.Attributes["id"] != null) 
                    {
                        stubRateIDRef_ = stubRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(stubRateNode);
                        IDManager.SetID(stubRateIDRef_, ob);
                    }
                    else if (stubRateNode.Attributes["href"] != null)
                    {
                        stubRateIDRef_ = stubRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubRate_ = new XsdTypeDecimal(stubRateNode);
                    }
                }
                else
                {
                    stubRate_ = new XsdTypeDecimal(stubRateNode);
                }
            }
            
        
            XmlNode stubAmountNode = xmlNode.SelectSingleNode("stubAmount");
            
            if (stubAmountNode != null)
            {
                if (stubAmountNode.Attributes["href"] != null || stubAmountNode.Attributes["id"] != null) 
                {
                    if (stubAmountNode.Attributes["id"] != null) 
                    {
                        stubAmountIDRef_ = stubAmountNode.Attributes["id"].Value;
                        Money ob = new Money(stubAmountNode);
                        IDManager.SetID(stubAmountIDRef_, ob);
                    }
                    else if (stubAmountNode.Attributes["href"] != null)
                    {
                        stubAmountIDRef_ = stubAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubAmount_ = new Money(stubAmountNode);
                    }
                }
                else
                {
                    stubAmount_ = new Money(stubAmountNode);
                }
            }
            
        
        }
        
    
        #region FloatingRate_
        private List<FloatingRate> floatingRate_;
        public List<FloatingRate> FloatingRate_
        {
            get
            {
                if (this.floatingRate_ != null)
                {
                    return this.floatingRate_; 
                }
                else if (this.floatingRateIDRef_ != null)
                {
                    return this.floatingRate_; 
                }
                else
                {
                      return this.floatingRate_; 
                }
            }
            set
            {
                if (this.floatingRate_ != value)
                {
                    this.floatingRate_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateIDRef_ { get; set; }
        #region StubRate_
        private XsdTypeDecimal stubRate_;
        public XsdTypeDecimal StubRate_
        {
            get
            {
                if (this.stubRate_ != null)
                {
                    return this.stubRate_; 
                }
                else if (this.stubRateIDRef_ != null)
                {
                    stubRate_ = IDManager.getID(stubRateIDRef_) as XsdTypeDecimal;
                    return this.stubRate_; 
                }
                else
                {
                      return this.stubRate_; 
                }
            }
            set
            {
                if (this.stubRate_ != value)
                {
                    this.stubRate_ = value;
                }
            }
        }
        #endregion
        
        public string stubRateIDRef_ { get; set; }
        #region StubAmount_
        private Money stubAmount_;
        public Money StubAmount_
        {
            get
            {
                if (this.stubAmount_ != null)
                {
                    return this.stubAmount_; 
                }
                else if (this.stubAmountIDRef_ != null)
                {
                    stubAmount_ = IDManager.getID(stubAmountIDRef_) as Money;
                    return this.stubAmount_; 
                }
                else
                {
                      return this.stubAmount_; 
                }
            }
            set
            {
                if (this.stubAmount_ != value)
                {
                    this.stubAmount_ = value;
                }
            }
        }
        #endregion
        
        public string stubAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


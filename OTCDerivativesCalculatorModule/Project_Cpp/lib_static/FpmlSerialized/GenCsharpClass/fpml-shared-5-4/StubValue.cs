using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StubValue
    {
        public StubValue(XmlNode xmlNode)
        {
            XmlNodeList floatingRateNodeList = xmlNode.SelectNodes("floatingRate");
            
            foreach (XmlNode item in floatingRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateIDRef = item.Attributes["id"].Name;
                        List<FloatingRate> ob = new List<FloatingRate>();
                        ob.Add(new FloatingRate(item));
                        IDManager.SetID(floatingRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    floatingRate.Add(new FloatingRate(item));
                    }
                }
            }
            
        
            XmlNodeList stubRateNodeList = xmlNode.SelectNodes("stubRate");
            if (stubRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(stubRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList stubAmountNodeList = xmlNode.SelectNodes("stubAmount");
            if (stubAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(stubAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region FloatingRate
        private List<FloatingRate> floatingRate;
        public List<FloatingRate> FloatingRate
        {
            get
            {
                if (this.floatingRate != null)
                {
                    return this.floatingRate; 
                }
                else if (this.floatingRateIDRef != null)
                {
                    floatingRate = IDManager.getID(floatingRateIDRef) as List<FloatingRate>;
                    return this.floatingRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRate != value)
                {
                    this.floatingRate = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIDRef { get; set; }
        #region StubRate
        private XsdTypeDecimal stubRate;
        public XsdTypeDecimal StubRate
        {
            get
            {
                if (this.stubRate != null)
                {
                    return this.stubRate; 
                }
                else if (this.stubRateIDRef != null)
                {
                    stubRate = IDManager.getID(stubRateIDRef) as XsdTypeDecimal;
                    return this.stubRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubRate != value)
                {
                    this.stubRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region StubAmount
        private Money stubAmount;
        public Money StubAmount
        {
            get
            {
                if (this.stubAmount != null)
                {
                    return this.stubAmount; 
                }
                else if (this.stubAmountIDRef != null)
                {
                    stubAmount = IDManager.getID(stubAmountIDRef) as Money;
                    return this.stubAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubAmount != value)
                {
                    this.stubAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


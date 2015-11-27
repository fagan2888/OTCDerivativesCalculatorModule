using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ValuationScenario
    {
        public ValuationScenario(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList valuationDateNodeList = xmlNode.SelectNodes("valuationDate");
            if (valuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(valuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList marketReferenceNodeList = xmlNode.SelectNodes("marketReference");
            if (marketReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketReferenceIDRef = item.Attributes["id"].Name;
                        MarketReference ob = MarketReference();
                        IDManager.SetID(marketReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketReference = new MarketReference(item);
                    }
                }
            }
            
        
            XmlNodeList shiftNodeList = xmlNode.SelectNodes("shift");
            
            foreach (XmlNode item in shiftNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        shiftIDRef = item.Attributes["id"].Name;
                        List<PricingParameterShift> ob = new List<PricingParameterShift>();
                        ob.Add(new PricingParameterShift(item));
                        IDManager.SetID(shiftIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        shiftIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    shift.Add(new PricingParameterShift(item));
                    }
                }
            }
            
        
            XmlNodeList replacementNodeList = xmlNode.SelectNodes("replacement");
            
            foreach (XmlNode item in replacementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        replacementIDRef = item.Attributes["id"].Name;
                        List<PricingInputReplacement> ob = new List<PricingInputReplacement>();
                        ob.Add(new PricingInputReplacement(item));
                        IDManager.SetID(replacementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        replacementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    replacement.Add(new PricingInputReplacement(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeString name;
        public XsdTypeString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeString;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ValuationDate
        private IdentifiedDate valuationDate;
        public IdentifiedDate ValuationDate
        {
            get
            {
                if (this.valuationDate != null)
                {
                    return this.valuationDate; 
                }
                else if (this.valuationDateIDRef != null)
                {
                    valuationDate = IDManager.getID(valuationDateIDRef) as IdentifiedDate;
                    return this.valuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDate != value)
                {
                    this.valuationDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region MarketReference
        private MarketReference marketReference;
        public MarketReference MarketReference
        {
            get
            {
                if (this.marketReference != null)
                {
                    return this.marketReference; 
                }
                else if (this.marketReferenceIDRef != null)
                {
                    marketReference = IDManager.getID(marketReferenceIDRef) as MarketReference;
                    return this.marketReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketReference != value)
                {
                    this.marketReference = value;
                }
            }
        }
        #endregion
        
        public string MarketReferenceIDRef { get; set; }
        #region Shift
        private List<PricingParameterShift> shift;
        public List<PricingParameterShift> Shift
        {
            get
            {
                if (this.shift != null)
                {
                    return this.shift; 
                }
                else if (this.shiftIDRef != null)
                {
                    shift = IDManager.getID(shiftIDRef) as List<PricingParameterShift>;
                    return this.shift; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.shift != value)
                {
                    this.shift = value;
                }
            }
        }
        #endregion
        
        public string PricingParameterShiftIDRef { get; set; }
        #region Replacement
        private List<PricingInputReplacement> replacement;
        public List<PricingInputReplacement> Replacement
        {
            get
            {
                if (this.replacement != null)
                {
                    return this.replacement; 
                }
                else if (this.replacementIDRef != null)
                {
                    replacement = IDManager.getID(replacementIDRef) as List<PricingInputReplacement>;
                    return this.replacement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.replacement != value)
                {
                    this.replacement = value;
                }
            }
        }
        #endregion
        
        public string PricingInputReplacementIDRef { get; set; }
        
    
        
    
    }
    
}


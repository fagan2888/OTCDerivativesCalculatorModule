using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AbsoluteTolerance
    {
        public AbsoluteTolerance(XmlNode xmlNode)
        {
            XmlNodeList positiveNodeList = xmlNode.SelectNodes("positive");
            if (positiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in positiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        positiveIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(positiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        positiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        positive = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList negativeNodeList = xmlNode.SelectNodes("negative");
            if (negativeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in negativeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        negativeIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(negativeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        negativeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        negative = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList unitNodeList = xmlNode.SelectNodes("unit");
            if (unitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unitIDRef = item.Attributes["id"].Name;
                        QuantityUnit ob = QuantityUnit();
                        IDManager.SetID(unitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unit = new QuantityUnit(item);
                    }
                }
            }
            
        
            XmlNodeList optionOwnerPartyReferenceNodeList = xmlNode.SelectNodes("optionOwnerPartyReference");
            if (optionOwnerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionOwnerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionOwnerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(optionOwnerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionOwnerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionOwnerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Positive
        private XsdTypeDecimal positive;
        public XsdTypeDecimal Positive
        {
            get
            {
                if (this.positive != null)
                {
                    return this.positive; 
                }
                else if (this.positiveIDRef != null)
                {
                    positive = IDManager.getID(positiveIDRef) as XsdTypeDecimal;
                    return this.positive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.positive != value)
                {
                    this.positive = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Negative
        private XsdTypeDecimal negative;
        public XsdTypeDecimal Negative
        {
            get
            {
                if (this.negative != null)
                {
                    return this.negative; 
                }
                else if (this.negativeIDRef != null)
                {
                    negative = IDManager.getID(negativeIDRef) as XsdTypeDecimal;
                    return this.negative; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.negative != value)
                {
                    this.negative = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Unit
        private QuantityUnit unit;
        public QuantityUnit Unit
        {
            get
            {
                if (this.unit != null)
                {
                    return this.unit; 
                }
                else if (this.unitIDRef != null)
                {
                    unit = IDManager.getID(unitIDRef) as QuantityUnit;
                    return this.unit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unit != value)
                {
                    this.unit = value;
                }
            }
        }
        #endregion
        
        public string QuantityUnitIDRef { get; set; }
        #region OptionOwnerPartyReference
        private PartyReference optionOwnerPartyReference;
        public PartyReference OptionOwnerPartyReference
        {
            get
            {
                if (this.optionOwnerPartyReference != null)
                {
                    return this.optionOwnerPartyReference; 
                }
                else if (this.optionOwnerPartyReferenceIDRef != null)
                {
                    optionOwnerPartyReference = IDManager.getID(optionOwnerPartyReferenceIDRef) as PartyReference;
                    return this.optionOwnerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionOwnerPartyReference != value)
                {
                    this.optionOwnerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        
    
        
    
    }
    
}


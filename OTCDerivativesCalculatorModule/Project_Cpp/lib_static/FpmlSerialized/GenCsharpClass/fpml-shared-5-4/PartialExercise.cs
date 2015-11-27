using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartialExercise
    {
        public PartialExercise(XmlNode xmlNode)
        {
            XmlNodeList notionalReferenceNodeList = xmlNode.SelectNodes("notionalReference");
            
            foreach (XmlNode item in notionalReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalReferenceIDRef = item.Attributes["id"].Name;
                        List<NotionalReference> ob = new List<NotionalReference>();
                        ob.Add(new NotionalReference(item));
                        IDManager.SetID(notionalReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    notionalReference.Add(new NotionalReference(item));
                    }
                }
            }
            
        
            XmlNodeList integralMultipleAmountNodeList = xmlNode.SelectNodes("integralMultipleAmount");
            if (integralMultipleAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in integralMultipleAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        integralMultipleAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(integralMultipleAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        integralMultipleAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        integralMultipleAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList minimumNotionalAmountNodeList = xmlNode.SelectNodes("minimumNotionalAmount");
            if (minimumNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumNotionalAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(minimumNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumNotionalAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList minimumNumberOfOptionsNodeList = xmlNode.SelectNodes("minimumNumberOfOptions");
            if (minimumNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(minimumNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumNumberOfOptions = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region NotionalReference
        private List<NotionalReference> notionalReference;
        public List<NotionalReference> NotionalReference
        {
            get
            {
                if (this.notionalReference != null)
                {
                    return this.notionalReference; 
                }
                else if (this.notionalReferenceIDRef != null)
                {
                    notionalReference = IDManager.getID(notionalReferenceIDRef) as List<NotionalReference>;
                    return this.notionalReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalReference != value)
                {
                    this.notionalReference = value;
                }
            }
        }
        #endregion
        
        public string NotionalReferenceIDRef { get; set; }
        #region IntegralMultipleAmount
        private XsdTypeDecimal integralMultipleAmount;
        public XsdTypeDecimal IntegralMultipleAmount
        {
            get
            {
                if (this.integralMultipleAmount != null)
                {
                    return this.integralMultipleAmount; 
                }
                else if (this.integralMultipleAmountIDRef != null)
                {
                    integralMultipleAmount = IDManager.getID(integralMultipleAmountIDRef) as XsdTypeDecimal;
                    return this.integralMultipleAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.integralMultipleAmount != value)
                {
                    this.integralMultipleAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region MinimumNotionalAmount
        private XsdTypeDecimal minimumNotionalAmount;
        public XsdTypeDecimal MinimumNotionalAmount
        {
            get
            {
                if (this.minimumNotionalAmount != null)
                {
                    return this.minimumNotionalAmount; 
                }
                else if (this.minimumNotionalAmountIDRef != null)
                {
                    minimumNotionalAmount = IDManager.getID(minimumNotionalAmountIDRef) as XsdTypeDecimal;
                    return this.minimumNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumNotionalAmount != value)
                {
                    this.minimumNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region MinimumNumberOfOptions
        private XsdTypeNonNegativeInteger minimumNumberOfOptions;
        public XsdTypeNonNegativeInteger MinimumNumberOfOptions
        {
            get
            {
                if (this.minimumNumberOfOptions != null)
                {
                    return this.minimumNumberOfOptions; 
                }
                else if (this.minimumNumberOfOptionsIDRef != null)
                {
                    minimumNumberOfOptions = IDManager.getID(minimumNumberOfOptionsIDRef) as XsdTypeNonNegativeInteger;
                    return this.minimumNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumNumberOfOptions != value)
                {
                    this.minimumNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}


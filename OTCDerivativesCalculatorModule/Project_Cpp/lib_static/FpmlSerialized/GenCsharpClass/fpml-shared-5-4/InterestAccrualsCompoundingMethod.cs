using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestAccrualsCompoundingMethod
    {
        public InterestAccrualsCompoundingMethod(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList compoundingMethodNodeList = xmlNode.SelectNodes("compoundingMethod");
            if (compoundingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingMethodIDRef = item.Attributes["id"].Name;
                        CompoundingMethodEnum ob = CompoundingMethodEnum();
                        IDManager.SetID(compoundingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingMethod = new CompoundingMethodEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region CompoundingMethod
        private CompoundingMethodEnum compoundingMethod;
        public CompoundingMethodEnum CompoundingMethod
        {
            get
            {
                if (this.compoundingMethod != null)
                {
                    return this.compoundingMethod; 
                }
                else if (this.compoundingMethodIDRef != null)
                {
                    compoundingMethod = IDManager.getID(compoundingMethodIDRef) as CompoundingMethodEnum;
                    return this.compoundingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingMethod != value)
                {
                    this.compoundingMethod = value;
                }
            }
        }
        #endregion
        
        public string CompoundingMethodEnumIDRef { get; set; }
        
    
        
    
    }
    
}


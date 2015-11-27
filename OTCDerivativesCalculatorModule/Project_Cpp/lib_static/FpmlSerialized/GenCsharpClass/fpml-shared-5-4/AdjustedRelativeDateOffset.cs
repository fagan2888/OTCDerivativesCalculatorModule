using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdjustedRelativeDateOffset
    {
        public AdjustedRelativeDateOffset(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList relativeDateAdjustmentsNodeList = xmlNode.SelectNodes("relativeDateAdjustments");
            if (relativeDateAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeDateAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeDateAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(relativeDateAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeDateAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeDateAdjustments = new BusinessDayAdjustments(item);
                    }
                }
            }
            
        
        }
        
    
        #region RelativeDateAdjustments
        private BusinessDayAdjustments relativeDateAdjustments;
        public BusinessDayAdjustments RelativeDateAdjustments
        {
            get
            {
                if (this.relativeDateAdjustments != null)
                {
                    return this.relativeDateAdjustments; 
                }
                else if (this.relativeDateAdjustmentsIDRef != null)
                {
                    relativeDateAdjustments = IDManager.getID(relativeDateAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.relativeDateAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeDateAdjustments != value)
                {
                    this.relativeDateAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        
    
        
    
    }
    
}


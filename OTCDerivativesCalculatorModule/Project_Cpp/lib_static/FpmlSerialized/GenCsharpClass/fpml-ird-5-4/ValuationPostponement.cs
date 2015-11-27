using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ValuationPostponement
    {
        public ValuationPostponement(XmlNode xmlNode)
        {
            XmlNodeList maximumDaysOfPostponementNodeList = xmlNode.SelectNodes("maximumDaysOfPostponement");
            if (maximumDaysOfPostponementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumDaysOfPostponementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumDaysOfPostponementIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(maximumDaysOfPostponementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumDaysOfPostponementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumDaysOfPostponement = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region MaximumDaysOfPostponement
        private XsdTypePositiveInteger maximumDaysOfPostponement;
        public XsdTypePositiveInteger MaximumDaysOfPostponement
        {
            get
            {
                if (this.maximumDaysOfPostponement != null)
                {
                    return this.maximumDaysOfPostponement; 
                }
                else if (this.maximumDaysOfPostponementIDRef != null)
                {
                    maximumDaysOfPostponement = IDManager.getID(maximumDaysOfPostponementIDRef) as XsdTypePositiveInteger;
                    return this.maximumDaysOfPostponement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumDaysOfPostponement != value)
                {
                    this.maximumDaysOfPostponement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}


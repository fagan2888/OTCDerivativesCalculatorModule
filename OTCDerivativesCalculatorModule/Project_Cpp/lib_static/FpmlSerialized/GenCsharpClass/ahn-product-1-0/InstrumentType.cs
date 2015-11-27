using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InstrumentType
    {
        public InstrumentType(XmlNode xmlNode)
        {
            XmlNodeList classificationNodeList = xmlNode.SelectNodes("classification");
            if (classificationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in classificationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        classificationIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(classificationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        classificationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        classification = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region Classification
        private XsdTypeToken classification;
        public XsdTypeToken Classification
        {
            get
            {
                if (this.classification != null)
                {
                    return this.classification; 
                }
                else if (this.classificationIDRef != null)
                {
                    classification = IDManager.getID(classificationIDRef) as XsdTypeToken;
                    return this.classification; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.classification != value)
                {
                    this.classification = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        
    
        
    
    }
    
}


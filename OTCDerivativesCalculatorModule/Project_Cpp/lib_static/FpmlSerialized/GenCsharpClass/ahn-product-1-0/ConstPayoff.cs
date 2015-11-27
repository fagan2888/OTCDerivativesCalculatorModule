using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ConstPayoff
    {
        public ConstPayoff(XmlNode xmlNode)
        {
            XmlNodeList constValueNodeList = xmlNode.SelectNodes("constValue");
            if (constValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDouble ob = XsdTypeDouble();
                        IDManager.SetID(constValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constValue = new XsdTypeDouble(item);
                    }
                }
            }
            
        
        }
        
    
        #region ConstValue
        private XsdTypeDouble constValue;
        public XsdTypeDouble ConstValue
        {
            get
            {
                if (this.constValue != null)
                {
                    return this.constValue; 
                }
                else if (this.constValueIDRef != null)
                {
                    constValue = IDManager.getID(constValueIDRef) as XsdTypeDouble;
                    return this.constValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constValue != value)
                {
                    this.constValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDoubleIDRef { get; set; }
        
    
        
    
    }
    
}


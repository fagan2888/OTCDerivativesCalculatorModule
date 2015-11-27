using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ParametricAdjustmentPoint
    {
        public ParametricAdjustmentPoint(XmlNode xmlNode)
        {
            XmlNodeList parameterValueNodeList = xmlNode.SelectNodes("parameterValue");
            if (parameterValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parameterValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parameterValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(parameterValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parameterValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parameterValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList adjustmentValueNodeList = xmlNode.SelectNodes("adjustmentValue");
            if (adjustmentValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustmentValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustmentValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(adjustmentValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustmentValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustmentValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region ParameterValue
        private XsdTypeDecimal parameterValue;
        public XsdTypeDecimal ParameterValue
        {
            get
            {
                if (this.parameterValue != null)
                {
                    return this.parameterValue; 
                }
                else if (this.parameterValueIDRef != null)
                {
                    parameterValue = IDManager.getID(parameterValueIDRef) as XsdTypeDecimal;
                    return this.parameterValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parameterValue != value)
                {
                    this.parameterValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region AdjustmentValue
        private XsdTypeDecimal adjustmentValue;
        public XsdTypeDecimal AdjustmentValue
        {
            get
            {
                if (this.adjustmentValue != null)
                {
                    return this.adjustmentValue; 
                }
                else if (this.adjustmentValueIDRef != null)
                {
                    adjustmentValue = IDManager.getID(adjustmentValueIDRef) as XsdTypeDecimal;
                    return this.adjustmentValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustmentValue != value)
                {
                    this.adjustmentValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}


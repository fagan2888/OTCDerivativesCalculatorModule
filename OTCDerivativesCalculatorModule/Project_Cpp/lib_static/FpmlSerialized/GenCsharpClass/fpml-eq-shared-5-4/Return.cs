using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Return
    {
        public Return(XmlNode xmlNode)
        {
            XmlNodeList returnTypeNodeList = xmlNode.SelectNodes("returnType");
            if (returnTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnTypeIDRef = item.Attributes["id"].Name;
                        ReturnTypeEnum ob = ReturnTypeEnum();
                        IDManager.SetID(returnTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        returnType = new ReturnTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList dividendConditionsNodeList = xmlNode.SelectNodes("dividendConditions");
            if (dividendConditionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendConditionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendConditionsIDRef = item.Attributes["id"].Name;
                        DividendConditions ob = DividendConditions();
                        IDManager.SetID(dividendConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendConditions = new DividendConditions(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReturnType
        private ReturnTypeEnum returnType;
        public ReturnTypeEnum ReturnType
        {
            get
            {
                if (this.returnType != null)
                {
                    return this.returnType; 
                }
                else if (this.returnTypeIDRef != null)
                {
                    returnType = IDManager.getID(returnTypeIDRef) as ReturnTypeEnum;
                    return this.returnType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.returnType != value)
                {
                    this.returnType = value;
                }
            }
        }
        #endregion
        
        public string ReturnTypeEnumIDRef { get; set; }
        #region DividendConditions
        private DividendConditions dividendConditions;
        public DividendConditions DividendConditions
        {
            get
            {
                if (this.dividendConditions != null)
                {
                    return this.dividendConditions; 
                }
                else if (this.dividendConditionsIDRef != null)
                {
                    dividendConditions = IDManager.getID(dividendConditionsIDRef) as DividendConditions;
                    return this.dividendConditions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendConditions != value)
                {
                    this.dividendConditions = value;
                }
            }
        }
        #endregion
        
        public string DividendConditionsIDRef { get; set; }
        
    
        
    
    }
    
}


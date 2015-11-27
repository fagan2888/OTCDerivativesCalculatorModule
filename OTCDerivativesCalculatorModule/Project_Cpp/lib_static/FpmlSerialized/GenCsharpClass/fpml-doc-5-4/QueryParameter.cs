using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class QueryParameter
    {
        public QueryParameter(XmlNode xmlNode)
        {
            XmlNodeList queryParameterIdNodeList = xmlNode.SelectNodes("queryParameterId");
            if (queryParameterIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in queryParameterIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        queryParameterIdIDRef = item.Attributes["id"].Name;
                        QueryParameterId ob = QueryParameterId();
                        IDManager.SetID(queryParameterIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        queryParameterIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        queryParameterId = new QueryParameterId(item);
                    }
                }
            }
            
        
            XmlNodeList queryParameterValueNodeList = xmlNode.SelectNodes("queryParameterValue");
            if (queryParameterValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in queryParameterValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        queryParameterValueIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(queryParameterValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        queryParameterValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        queryParameterValue = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList queryParameterOperatorNodeList = xmlNode.SelectNodes("queryParameterOperator");
            if (queryParameterOperatorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in queryParameterOperatorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        queryParameterOperatorIDRef = item.Attributes["id"].Name;
                        QueryParameterOperator ob = QueryParameterOperator();
                        IDManager.SetID(queryParameterOperatorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        queryParameterOperatorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        queryParameterOperator = new QueryParameterOperator(item);
                    }
                }
            }
            
        
        }
        
    
        #region QueryParameterId
        private QueryParameterId queryParameterId;
        public QueryParameterId QueryParameterId
        {
            get
            {
                if (this.queryParameterId != null)
                {
                    return this.queryParameterId; 
                }
                else if (this.queryParameterIdIDRef != null)
                {
                    queryParameterId = IDManager.getID(queryParameterIdIDRef) as QueryParameterId;
                    return this.queryParameterId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.queryParameterId != value)
                {
                    this.queryParameterId = value;
                }
            }
        }
        #endregion
        
        public string QueryParameterIdIDRef { get; set; }
        #region QueryParameterValue
        private XsdTypeNormalizedString queryParameterValue;
        public XsdTypeNormalizedString QueryParameterValue
        {
            get
            {
                if (this.queryParameterValue != null)
                {
                    return this.queryParameterValue; 
                }
                else if (this.queryParameterValueIDRef != null)
                {
                    queryParameterValue = IDManager.getID(queryParameterValueIDRef) as XsdTypeNormalizedString;
                    return this.queryParameterValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.queryParameterValue != value)
                {
                    this.queryParameterValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region QueryParameterOperator
        private QueryParameterOperator queryParameterOperator;
        public QueryParameterOperator QueryParameterOperator
        {
            get
            {
                if (this.queryParameterOperator != null)
                {
                    return this.queryParameterOperator; 
                }
                else if (this.queryParameterOperatorIDRef != null)
                {
                    queryParameterOperator = IDManager.getID(queryParameterOperatorIDRef) as QueryParameterOperator;
                    return this.queryParameterOperator; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.queryParameterOperator != value)
                {
                    this.queryParameterOperator = value;
                }
            }
        }
        #endregion
        
        public string QueryParameterOperatorIDRef { get; set; }
        
    
        
    
    }
    
}


using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class QueryPortfolio
    {
        public QueryPortfolio(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList queryParameterNodeList = xmlNode.SelectNodes("queryParameter");
            
            foreach (XmlNode item in queryParameterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        queryParameterIDRef = item.Attributes["id"].Name;
                        List<QueryParameter> ob = new List<QueryParameter>();
                        ob.Add(new QueryParameter(item));
                        IDManager.SetID(queryParameterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        queryParameterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    queryParameter.Add(new QueryParameter(item));
                    }
                }
            }
            
        
        }
        
    
        #region QueryParameter
        private List<QueryParameter> queryParameter;
        public List<QueryParameter> QueryParameter
        {
            get
            {
                if (this.queryParameter != null)
                {
                    return this.queryParameter; 
                }
                else if (this.queryParameterIDRef != null)
                {
                    queryParameter = IDManager.getID(queryParameterIDRef) as List<QueryParameter>;
                    return this.queryParameter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.queryParameter != value)
                {
                    this.queryParameter = value;
                }
            }
        }
        #endregion
        
        public string QueryParameterIDRef { get; set; }
        
    
        
    
    }
    
}


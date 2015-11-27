using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class QueryPortfolio : Portfolio
    {
        public QueryPortfolio(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList queryParameterNodeList = xmlNode.SelectNodes("queryParameter");
            
            if (queryParameterNodeList != null)
            {
                this.queryParameter_ = new List<QueryParameter>();
                foreach (XmlNode item in queryParameterNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            queryParameterIDRef_ = item.Attributes["id"].Value;
                            queryParameter_.Add(new QueryParameter(item));
                            IDManager.SetID(queryParameterIDRef_, queryParameter_[queryParameter_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            queryParameterIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        queryParameter_.Add(new QueryParameter(item));
                        }
                    }
                    else
                    {
                        queryParameter_.Add(new QueryParameter(item));
                    }
                }
            }
            
        
        }
        
    
        #region QueryParameter_
        private List<QueryParameter> queryParameter_;
        public List<QueryParameter> QueryParameter_
        {
            get
            {
                if (this.queryParameter_ != null)
                {
                    return this.queryParameter_; 
                }
                else if (this.queryParameterIDRef_ != null)
                {
                    return this.queryParameter_; 
                }
                else
                {
                      return this.queryParameter_; 
                }
            }
            set
            {
                if (this.queryParameter_ != value)
                {
                    this.queryParameter_ = value;
                }
            }
        }
        #endregion
        
        public string queryParameterIDRef_ { get; set; }
        
    
        
    
    }
    
}


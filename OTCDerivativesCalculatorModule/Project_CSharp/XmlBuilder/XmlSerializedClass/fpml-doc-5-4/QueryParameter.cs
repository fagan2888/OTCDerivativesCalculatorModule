using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class QueryParameter : ISerialized
    {
        public QueryParameter(XmlNode xmlNode)
        {
            XmlNode queryParameterIdNode = xmlNode.SelectSingleNode("queryParameterId");
            
            if (queryParameterIdNode != null)
            {
                if (queryParameterIdNode.Attributes["href"] != null || queryParameterIdNode.Attributes["id"] != null) 
                {
                    if (queryParameterIdNode.Attributes["id"] != null) 
                    {
                        queryParameterIdIDRef_ = queryParameterIdNode.Attributes["id"].Value;
                        QueryParameterId ob = new QueryParameterId(queryParameterIdNode);
                        IDManager.SetID(queryParameterIdIDRef_, ob);
                    }
                    else if (queryParameterIdNode.Attributes["href"] != null)
                    {
                        queryParameterIdIDRef_ = queryParameterIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        queryParameterId_ = new QueryParameterId(queryParameterIdNode);
                    }
                }
                else
                {
                    queryParameterId_ = new QueryParameterId(queryParameterIdNode);
                }
            }
            
        
            XmlNode queryParameterValueNode = xmlNode.SelectSingleNode("queryParameterValue");
            
            if (queryParameterValueNode != null)
            {
                if (queryParameterValueNode.Attributes["href"] != null || queryParameterValueNode.Attributes["id"] != null) 
                {
                    if (queryParameterValueNode.Attributes["id"] != null) 
                    {
                        queryParameterValueIDRef_ = queryParameterValueNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(queryParameterValueNode);
                        IDManager.SetID(queryParameterValueIDRef_, ob);
                    }
                    else if (queryParameterValueNode.Attributes["href"] != null)
                    {
                        queryParameterValueIDRef_ = queryParameterValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        queryParameterValue_ = new XsdTypeNormalizedString(queryParameterValueNode);
                    }
                }
                else
                {
                    queryParameterValue_ = new XsdTypeNormalizedString(queryParameterValueNode);
                }
            }
            
        
            XmlNode queryParameterOperatorNode = xmlNode.SelectSingleNode("queryParameterOperator");
            
            if (queryParameterOperatorNode != null)
            {
                if (queryParameterOperatorNode.Attributes["href"] != null || queryParameterOperatorNode.Attributes["id"] != null) 
                {
                    if (queryParameterOperatorNode.Attributes["id"] != null) 
                    {
                        queryParameterOperatorIDRef_ = queryParameterOperatorNode.Attributes["id"].Value;
                        QueryParameterOperator ob = new QueryParameterOperator(queryParameterOperatorNode);
                        IDManager.SetID(queryParameterOperatorIDRef_, ob);
                    }
                    else if (queryParameterOperatorNode.Attributes["href"] != null)
                    {
                        queryParameterOperatorIDRef_ = queryParameterOperatorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        queryParameterOperator_ = new QueryParameterOperator(queryParameterOperatorNode);
                    }
                }
                else
                {
                    queryParameterOperator_ = new QueryParameterOperator(queryParameterOperatorNode);
                }
            }
            
        
        }
        
    
        #region QueryParameterId_
        private QueryParameterId queryParameterId_;
        public QueryParameterId QueryParameterId_
        {
            get
            {
                if (this.queryParameterId_ != null)
                {
                    return this.queryParameterId_; 
                }
                else if (this.queryParameterIdIDRef_ != null)
                {
                    queryParameterId_ = IDManager.getID(queryParameterIdIDRef_) as QueryParameterId;
                    return this.queryParameterId_; 
                }
                else
                {
                      return this.queryParameterId_; 
                }
            }
            set
            {
                if (this.queryParameterId_ != value)
                {
                    this.queryParameterId_ = value;
                }
            }
        }
        #endregion
        
        public string queryParameterIdIDRef_ { get; set; }
        #region QueryParameterValue_
        private XsdTypeNormalizedString queryParameterValue_;
        public XsdTypeNormalizedString QueryParameterValue_
        {
            get
            {
                if (this.queryParameterValue_ != null)
                {
                    return this.queryParameterValue_; 
                }
                else if (this.queryParameterValueIDRef_ != null)
                {
                    queryParameterValue_ = IDManager.getID(queryParameterValueIDRef_) as XsdTypeNormalizedString;
                    return this.queryParameterValue_; 
                }
                else
                {
                      return this.queryParameterValue_; 
                }
            }
            set
            {
                if (this.queryParameterValue_ != value)
                {
                    this.queryParameterValue_ = value;
                }
            }
        }
        #endregion
        
        public string queryParameterValueIDRef_ { get; set; }
        #region QueryParameterOperator_
        private QueryParameterOperator queryParameterOperator_;
        public QueryParameterOperator QueryParameterOperator_
        {
            get
            {
                if (this.queryParameterOperator_ != null)
                {
                    return this.queryParameterOperator_; 
                }
                else if (this.queryParameterOperatorIDRef_ != null)
                {
                    queryParameterOperator_ = IDManager.getID(queryParameterOperatorIDRef_) as QueryParameterOperator;
                    return this.queryParameterOperator_; 
                }
                else
                {
                      return this.queryParameterOperator_; 
                }
            }
            set
            {
                if (this.queryParameterOperator_ != value)
                {
                    this.queryParameterOperator_ = value;
                }
            }
        }
        #endregion
        
        public string queryParameterOperatorIDRef_ { get; set; }
        
    
        
    
    }
    
}


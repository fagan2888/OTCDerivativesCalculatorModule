// QueryParameter.hpp 
#ifndef FpmlSerialized_QueryParameter_hpp
#define FpmlSerialized_QueryParameter_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/QueryParameterId.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-doc-5-4/QueryParameterOperator.hpp>

namespace FpmlSerialized {

class QueryParameter : public ISerialized { 
   public: 
       QueryParameter(TiXmlNode* xmlNode);

       bool isQueryParameterId(){return this->queryParameterIdIsNull_;}
       boost::shared_ptr<QueryParameterId> getQueryParameterId();
      std::string getQueryParameterIdIDRef(){return queryParameterIdIDRef_;}

       bool isQueryParameterValue(){return this->queryParameterValueIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getQueryParameterValue();
      std::string getQueryParameterValueIDRef(){return queryParameterValueIDRef_;}

       bool isQueryParameterOperator(){return this->queryParameterOperatorIsNull_;}
       boost::shared_ptr<QueryParameterOperator> getQueryParameterOperator();
      std::string getQueryParameterOperatorIDRef(){return queryParameterOperatorIDRef_;}

   protected: 
       boost::shared_ptr<QueryParameterId> queryParameterId_;
       std::string queryParameterIdIDRef_;
       bool queryParameterIdIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> queryParameterValue_;
       std::string queryParameterValueIDRef_;
       bool queryParameterValueIsNull_;
       boost::shared_ptr<QueryParameterOperator> queryParameterOperator_;
       std::string queryParameterOperatorIDRef_;
       bool queryParameterOperatorIsNull_;

};

} //namespaceFpmlSerialized end
#endif


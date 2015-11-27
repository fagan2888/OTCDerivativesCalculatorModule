// QueryPortfolio.hpp 
#ifndef FpmlSerialized_QueryPortfolio_hpp
#define FpmlSerialized_QueryPortfolio_hpp

#include <fpml-doc-5-4/Portfolio.hpp>
#include <fpml-doc-5-4/QueryParameter.hpp>

namespace FpmlSerialized {

class QueryPortfolio : public Portfolio { 
   public: 
       QueryPortfolio(TiXmlNode* xmlNode);

       bool isQueryParameter(){return this->queryParameterIsNull_;}
       std::vector<boost::shared_ptr<QueryParameter>> getQueryParameter();
      std::string getQueryParameterIDRef(){return queryParameterIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<QueryParameter>> queryParameter_;
       std::string queryParameterIDRef_;
       bool queryParameterIsNull_;

};

} //namespaceFpmlSerialized end
#endif


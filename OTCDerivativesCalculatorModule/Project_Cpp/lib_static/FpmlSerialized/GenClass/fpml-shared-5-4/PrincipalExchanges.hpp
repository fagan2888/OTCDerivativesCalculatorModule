// PrincipalExchanges.hpp 
#ifndef FpmlSerialized_PrincipalExchanges_hpp
#define FpmlSerialized_PrincipalExchanges_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class PrincipalExchanges : public ISerialized { 
   public: 
       PrincipalExchanges(TiXmlNode* xmlNode);

       bool isInitialExchange(){return this->initialExchangeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getInitialExchange();
      std::string getInitialExchangeIDRef(){return initialExchangeIDRef_;}

       bool isFinalExchange(){return this->finalExchangeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFinalExchange();
      std::string getFinalExchangeIDRef(){return finalExchangeIDRef_;}

       bool isIntermediateExchange(){return this->intermediateExchangeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIntermediateExchange();
      std::string getIntermediateExchangeIDRef(){return intermediateExchangeIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> initialExchange_;
       std::string initialExchangeIDRef_;
       bool initialExchangeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> finalExchange_;
       std::string finalExchangeIDRef_;
       bool finalExchangeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> intermediateExchange_;
       std::string intermediateExchangeIDRef_;
       bool intermediateExchangeIsNull_;

};

} //namespaceFpmlSerialized end
#endif


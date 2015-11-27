// PrincipalExchangeFeatures.hpp 
#ifndef FpmlSerialized_PrincipalExchangeFeatures_hpp
#define FpmlSerialized_PrincipalExchangeFeatures_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PrincipalExchanges.hpp>
#include <fpml-eq-shared-5-4/PrincipalExchangeDescriptions.hpp>

namespace FpmlSerialized {

class PrincipalExchangeFeatures : public ISerialized { 
   public: 
       PrincipalExchangeFeatures(TiXmlNode* xmlNode);

       bool isPrincipalExchanges(){return this->principalExchangesIsNull_;}
       boost::shared_ptr<PrincipalExchanges> getPrincipalExchanges();
      std::string getPrincipalExchangesIDRef(){return principalExchangesIDRef_;}

       bool isPrincipalExchangeDescriptions(){return this->principalExchangeDescriptionsIsNull_;}
       std::vector<boost::shared_ptr<PrincipalExchangeDescriptions>> getPrincipalExchangeDescriptions();
      std::string getPrincipalExchangeDescriptionsIDRef(){return principalExchangeDescriptionsIDRef_;}

   protected: 
       boost::shared_ptr<PrincipalExchanges> principalExchanges_;
       std::string principalExchangesIDRef_;
       bool principalExchangesIsNull_;
       std::vector<boost::shared_ptr<PrincipalExchangeDescriptions>> principalExchangeDescriptions_;
       std::string principalExchangeDescriptionsIDRef_;
       bool principalExchangeDescriptionsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


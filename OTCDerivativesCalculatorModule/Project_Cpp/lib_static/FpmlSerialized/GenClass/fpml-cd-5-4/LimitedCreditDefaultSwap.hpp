// LimitedCreditDefaultSwap.hpp 
#ifndef FpmlSerialized_LimitedCreditDefaultSwap_hpp
#define FpmlSerialized_LimitedCreditDefaultSwap_hpp

#include <ISerialized.hpp>
#include <fpml-cd-5-4/GeneralTerms.hpp>
#include <fpml-cd-5-4/FeeLeg.hpp>
#include <fpml-cd-5-4/ProtectionTerms.hpp>

namespace FpmlSerialized {

class LimitedCreditDefaultSwap : public ISerialized { 
   public: 
       LimitedCreditDefaultSwap(TiXmlNode* xmlNode);

       bool isGeneralTerms(){return this->generalTermsIsNull_;}
       boost::shared_ptr<GeneralTerms> getGeneralTerms();
      std::string getGeneralTermsIDRef(){return generalTermsIDRef_;}

       bool isFeeLeg(){return this->feeLegIsNull_;}
       boost::shared_ptr<FeeLeg> getFeeLeg();
      std::string getFeeLegIDRef(){return feeLegIDRef_;}

       bool isProtectionTerms(){return this->protectionTermsIsNull_;}
       std::vector<boost::shared_ptr<ProtectionTerms>> getProtectionTerms();
      std::string getProtectionTermsIDRef(){return protectionTermsIDRef_;}

   protected: 
       boost::shared_ptr<GeneralTerms> generalTerms_;
       std::string generalTermsIDRef_;
       bool generalTermsIsNull_;
       boost::shared_ptr<FeeLeg> feeLeg_;
       std::string feeLegIDRef_;
       bool feeLegIsNull_;
       std::vector<boost::shared_ptr<ProtectionTerms>> protectionTerms_;
       std::string protectionTermsIDRef_;
       bool protectionTermsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


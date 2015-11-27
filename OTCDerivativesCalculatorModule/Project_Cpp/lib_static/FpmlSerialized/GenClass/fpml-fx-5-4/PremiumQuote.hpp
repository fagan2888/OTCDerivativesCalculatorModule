// PremiumQuote.hpp 
#ifndef FpmlSerialized_PremiumQuote_hpp
#define FpmlSerialized_PremiumQuote_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-enum-5-4/PremiumQuoteBasisEnum.hpp>

namespace FpmlSerialized {

class PremiumQuote : public ISerialized { 
   public: 
       PremiumQuote(TiXmlNode* xmlNode);

       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getValue();
      std::string getValueIDRef(){return valueIDRef_;}

       bool isQuoteBasis(){return this->quoteBasisIsNull_;}
       boost::shared_ptr<PremiumQuoteBasisEnum> getQuoteBasis();
      std::string getQuoteBasisIDRef(){return quoteBasisIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> value_;
       std::string valueIDRef_;
       bool valueIsNull_;
       boost::shared_ptr<PremiumQuoteBasisEnum> quoteBasis_;
       std::string quoteBasisIDRef_;
       bool quoteBasisIsNull_;

};

} //namespaceFpmlSerialized end
#endif


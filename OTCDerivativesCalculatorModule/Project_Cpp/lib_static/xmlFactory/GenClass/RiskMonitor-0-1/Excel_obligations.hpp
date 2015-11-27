// Excel_obligations.hpp 
#ifndef FpmlSerialized_Excel_obligations_hpp
#define FpmlSerialized_Excel_obligations_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_obligations : public ISerialized { 
   public: 
       Excel_obligations(TiXmlNode* xmlNode);

       bool isCategory(){return this->categoryIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCategory();


       bool isNotSubordinated(){return this->notSubordinatedIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotSubordinated();


       bool isNotDomesticCurrency(){return this->notDomesticCurrencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotDomesticCurrency();


       bool isNotDomesticLaw(){return this->notDomesticLawIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotDomesticLaw();


       bool isNotDomesticIssuance(){return this->notDomesticIssuanceIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotDomesticIssuance();


   protected: 
       boost::shared_ptr<XsdTypeToken> category_;
       
       bool categoryIsNull_;
       boost::shared_ptr<XsdTypeToken> notSubordinated_;
       
       bool notSubordinatedIsNull_;
       boost::shared_ptr<XsdTypeToken> notDomesticCurrency_;
       
       bool notDomesticCurrencyIsNull_;
       boost::shared_ptr<XsdTypeToken> notDomesticLaw_;
       
       bool notDomesticLawIsNull_;
       boost::shared_ptr<XsdTypeToken> notDomesticIssuance_;
       
       bool notDomesticIssuanceIsNull_;

};

} //namespaceFpmlSerialized end
#endif


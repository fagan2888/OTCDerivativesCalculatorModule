// PrincipalExchange.hpp 
#ifndef FpmlSerialized_PrincipalExchange_hpp
#define FpmlSerialized_PrincipalExchange_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class PrincipalExchange : public ISerialized { 
   public: 
       PrincipalExchange(TiXmlNode* xmlNode);

       bool isUnadjustedPrincipalExchangeDate(){return this->unadjustedPrincipalExchangeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedPrincipalExchangeDate();
      std::string getUnadjustedPrincipalExchangeDateIDRef(){return unadjustedPrincipalExchangeDateIDRef_;}

       bool isAdjustedPrincipalExchangeDate(){return this->adjustedPrincipalExchangeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedPrincipalExchangeDate();
      std::string getAdjustedPrincipalExchangeDateIDRef(){return adjustedPrincipalExchangeDateIDRef_;}

       bool isPrincipalExchangeAmount(){return this->principalExchangeAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPrincipalExchangeAmount();
      std::string getPrincipalExchangeAmountIDRef(){return principalExchangeAmountIDRef_;}

       bool isDiscountFactor(){return this->discountFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDiscountFactor();
      std::string getDiscountFactorIDRef(){return discountFactorIDRef_;}

       bool isPresentValuePrincipalExchangeAmount(){return this->presentValuePrincipalExchangeAmountIsNull_;}
       boost::shared_ptr<Money> getPresentValuePrincipalExchangeAmount();
      std::string getPresentValuePrincipalExchangeAmountIDRef(){return presentValuePrincipalExchangeAmountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> unadjustedPrincipalExchangeDate_;
       std::string unadjustedPrincipalExchangeDateIDRef_;
       bool unadjustedPrincipalExchangeDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedPrincipalExchangeDate_;
       std::string adjustedPrincipalExchangeDateIDRef_;
       bool adjustedPrincipalExchangeDateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> principalExchangeAmount_;
       std::string principalExchangeAmountIDRef_;
       bool principalExchangeAmountIsNull_;
       boost::shared_ptr<XsdTypeDecimal> discountFactor_;
       std::string discountFactorIDRef_;
       bool discountFactorIsNull_;
       boost::shared_ptr<Money> presentValuePrincipalExchangeAmount_;
       std::string presentValuePrincipalExchangeAmountIDRef_;
       bool presentValuePrincipalExchangeAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


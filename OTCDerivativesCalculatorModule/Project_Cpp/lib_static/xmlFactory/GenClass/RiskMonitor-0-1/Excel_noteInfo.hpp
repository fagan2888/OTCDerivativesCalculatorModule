// Excel_noteInfo.hpp 
#ifndef FpmlSerialized_Excel_noteInfo_hpp
#define FpmlSerialized_Excel_noteInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_noteInfo : public ISerialized { 
   public: 
       Excel_noteInfo(TiXmlNode* xmlNode);

       bool isTradeDate(){return this->tradeDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTradeDate();


       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEffectiveDate();


       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityDate();


       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotional();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isPremium(){return this->premiumIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPremium();


       bool isIncludeNotionalPayment(){return this->includeNotionalPaymentIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIncludeNotionalPayment();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> tradeDate_;
       
       bool tradeDateIsNull_;
       boost::shared_ptr<XsdTypeToken> effectiveDate_;
       
       bool effectiveDateIsNull_;
       boost::shared_ptr<XsdTypeToken> maturityDate_;
       
       bool maturityDateIsNull_;
       boost::shared_ptr<XsdTypeToken> notional_;
       
       bool notionalIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> premium_;
       
       bool premiumIsNull_;
       boost::shared_ptr<XsdTypeToken> includeNotionalPayment_;
       
       bool includeNotionalPaymentIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif


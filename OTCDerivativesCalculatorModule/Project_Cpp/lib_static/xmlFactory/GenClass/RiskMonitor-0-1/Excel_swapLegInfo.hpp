// Excel_swapLegInfo.hpp 
#ifndef FpmlSerialized_Excel_swapLegInfo_hpp
#define FpmlSerialized_Excel_swapLegInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_swapLegInfo : public ISerialized { 
   public: 
       Excel_swapLegInfo(TiXmlNode* xmlNode);

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotional();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isPremium(){return this->premiumIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPremium();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> notional_;
       
       bool notionalIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> premium_;
       
       bool premiumIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif


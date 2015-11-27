// FxLinkedNotionalAmount.hpp 
#ifndef FpmlSerialized_FxLinkedNotionalAmount_hpp
#define FpmlSerialized_FxLinkedNotionalAmount_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class FxLinkedNotionalAmount : public ISerialized { 
   public: 
       FxLinkedNotionalAmount(TiXmlNode* xmlNode);

       bool isResetDate(){return this->resetDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getResetDate();
      std::string getResetDateIDRef(){return resetDateIDRef_;}

       bool isAdjustedFxSpotFixingDate(){return this->adjustedFxSpotFixingDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedFxSpotFixingDate();
      std::string getAdjustedFxSpotFixingDateIDRef(){return adjustedFxSpotFixingDateIDRef_;}

       bool isObservedFxSpotRate(){return this->observedFxSpotRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getObservedFxSpotRate();
      std::string getObservedFxSpotRateIDRef(){return observedFxSpotRateIDRef_;}

       bool isNotionalAmount(){return this->notionalAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNotionalAmount();
      std::string getNotionalAmountIDRef(){return notionalAmountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> resetDate_;
       std::string resetDateIDRef_;
       bool resetDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedFxSpotFixingDate_;
       std::string adjustedFxSpotFixingDateIDRef_;
       bool adjustedFxSpotFixingDateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> observedFxSpotRate_;
       std::string observedFxSpotRateIDRef_;
       bool observedFxSpotRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> notionalAmount_;
       std::string notionalAmountIDRef_;
       bool notionalAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


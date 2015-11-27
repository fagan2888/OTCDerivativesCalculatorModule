// ProtectionTerms.hpp 
#ifndef FpmlSerialized_ProtectionTerms_hpp
#define FpmlSerialized_ProtectionTerms_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-option-shared-5-4/CreditEvents.hpp>
#include <fpml-cd-5-4/Obligations.hpp>
#include <fpml-cd-5-4/FloatingAmountEvents.hpp>

namespace FpmlSerialized {

class ProtectionTerms : public ISerialized { 
   public: 
       ProtectionTerms(TiXmlNode* xmlNode);

       bool isCalculationAmount(){return this->calculationAmountIsNull_;}
       boost::shared_ptr<Money> getCalculationAmount();
      std::string getCalculationAmountIDRef(){return calculationAmountIDRef_;}

       bool isCreditEvents(){return this->creditEventsIsNull_;}
       boost::shared_ptr<CreditEvents> getCreditEvents();
      std::string getCreditEventsIDRef(){return creditEventsIDRef_;}

       bool isObligations(){return this->obligationsIsNull_;}
       boost::shared_ptr<Obligations> getObligations();
      std::string getObligationsIDRef(){return obligationsIDRef_;}

       bool isFloatingAmountEvents(){return this->floatingAmountEventsIsNull_;}
       boost::shared_ptr<FloatingAmountEvents> getFloatingAmountEvents();
      std::string getFloatingAmountEventsIDRef(){return floatingAmountEventsIDRef_;}

   protected: 
       boost::shared_ptr<Money> calculationAmount_;
       std::string calculationAmountIDRef_;
       bool calculationAmountIsNull_;
       boost::shared_ptr<CreditEvents> creditEvents_;
       std::string creditEventsIDRef_;
       bool creditEventsIsNull_;
       boost::shared_ptr<Obligations> obligations_;
       std::string obligationsIDRef_;
       bool obligationsIsNull_;
       boost::shared_ptr<FloatingAmountEvents> floatingAmountEvents_;
       std::string floatingAmountEventsIDRef_;
       bool floatingAmountEventsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


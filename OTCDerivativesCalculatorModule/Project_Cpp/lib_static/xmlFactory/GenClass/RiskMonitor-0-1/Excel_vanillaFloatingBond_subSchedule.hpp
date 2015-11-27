// Excel_vanillaFloatingBond_subSchedule.hpp 
#ifndef FpmlSerialized_Excel_vanillaFloatingBond_subSchedule_hpp
#define FpmlSerialized_Excel_vanillaFloatingBond_subSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_vanillaFloatingBond_subSchedule : public ISerialized { 
   public: 
       Excel_vanillaFloatingBond_subSchedule(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isFixingDate(){return this->fixingDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixingDate();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationEndDate();


       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPaymentDate();


       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSpread();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> fixingDate_;
       
       bool fixingDateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeToken> paymentDate_;
       
       bool paymentDateIsNull_;
       boost::shared_ptr<XsdTypeToken> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeToken> spread_;
       
       bool spreadIsNull_;

};

} //namespaceFpmlSerialized end
#endif


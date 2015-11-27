// EquityDerivativeLongFormBase.hpp 
#ifndef FpmlSerialized_EquityDerivativeLongFormBase_hpp
#define FpmlSerialized_EquityDerivativeLongFormBase_hpp

#include <fpml-eqd-5-4/EquityDerivativeBase.hpp>
#include <fpml-eq-shared-5-4/DividendConditions.hpp>
#include <fpml-enum-5-4/MethodOfAdjustmentEnum.hpp>
#include <fpml-eq-shared-5-4/ExtraordinaryEvents.hpp>

namespace FpmlSerialized {

class EquityDerivativeLongFormBase : public EquityDerivativeBase { 
   public: 
       EquityDerivativeLongFormBase(TiXmlNode* xmlNode);

       bool isDividendConditions(){return this->dividendConditionsIsNull_;}
       boost::shared_ptr<DividendConditions> getDividendConditions();
      std::string getDividendConditionsIDRef(){return dividendConditionsIDRef_;}

       bool isMethodOfAdjustment(){return this->methodOfAdjustmentIsNull_;}
       boost::shared_ptr<MethodOfAdjustmentEnum> getMethodOfAdjustment();
      std::string getMethodOfAdjustmentIDRef(){return methodOfAdjustmentIDRef_;}

       bool isExtraordinaryEvents(){return this->extraordinaryEventsIsNull_;}
       boost::shared_ptr<ExtraordinaryEvents> getExtraordinaryEvents();
      std::string getExtraordinaryEventsIDRef(){return extraordinaryEventsIDRef_;}

   protected: 
       boost::shared_ptr<DividendConditions> dividendConditions_;
       std::string dividendConditionsIDRef_;
       bool dividendConditionsIsNull_;
       boost::shared_ptr<MethodOfAdjustmentEnum> methodOfAdjustment_;
       std::string methodOfAdjustmentIDRef_;
       bool methodOfAdjustmentIsNull_;
       boost::shared_ptr<ExtraordinaryEvents> extraordinaryEvents_;
       std::string extraordinaryEventsIDRef_;
       bool extraordinaryEventsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


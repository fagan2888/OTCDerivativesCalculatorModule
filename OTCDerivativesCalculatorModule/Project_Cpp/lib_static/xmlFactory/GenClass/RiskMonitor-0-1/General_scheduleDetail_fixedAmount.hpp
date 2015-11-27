// General_scheduleDetail_fixedAmount.hpp 
#ifndef FpmlSerialized_General_scheduleDetail_fixedAmount_hpp
#define FpmlSerialized_General_scheduleDetail_fixedAmount_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class General_scheduleDetail_fixedAmount : public ISerialized { 
   public: 
       General_scheduleDetail_fixedAmount(TiXmlNode* xmlNode);

       bool isFixedAmount(){return this->fixedAmountIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedAmount();


   protected: 
       boost::shared_ptr<XsdTypeToken> fixedAmount_;
       
       bool fixedAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


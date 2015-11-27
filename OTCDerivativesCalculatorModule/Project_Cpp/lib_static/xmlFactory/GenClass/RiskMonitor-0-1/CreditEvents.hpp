// CreditEvents.hpp 
#ifndef FpmlSerialized_CreditEvents_hpp
#define FpmlSerialized_CreditEvents_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CreditEvents : public ISerialized { 
   public: 
       CreditEvents(TiXmlNode* xmlNode);

       bool isFailureToPay(){return this->failureToPayIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFailureToPay();


       bool isObligationAcceleration(){return this->obligationAccelerationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getObligationAcceleration();


       bool isRepudiationMoratorium(){return this->repudiationMoratoriumIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRepudiationMoratorium();


       bool isRestructuring(){return this->restructuringIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRestructuring();


       bool isDefaultRequirement(){return this->defaultRequirementIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDefaultRequirement();


   protected: 
       boost::shared_ptr<XsdTypeToken> failureToPay_;
       
       bool failureToPayIsNull_;
       boost::shared_ptr<XsdTypeToken> obligationAcceleration_;
       
       bool obligationAccelerationIsNull_;
       boost::shared_ptr<XsdTypeToken> repudiationMoratorium_;
       
       bool repudiationMoratoriumIsNull_;
       boost::shared_ptr<XsdTypeToken> restructuring_;
       
       bool restructuringIsNull_;
       boost::shared_ptr<XsdTypeToken> defaultRequirement_;
       
       bool defaultRequirementIsNull_;

};

} //namespaceFpmlSerialized end
#endif


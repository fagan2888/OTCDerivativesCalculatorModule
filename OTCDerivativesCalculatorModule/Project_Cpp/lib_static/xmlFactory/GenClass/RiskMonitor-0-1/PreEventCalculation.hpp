// PreEventCalculation.hpp 
#ifndef FpmlSerialized_PreEventCalculation_hpp
#define FpmlSerialized_PreEventCalculation_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventCalculationList.hpp>
#include <RiskMonitor-0-1/JointEventCalculation.hpp>

namespace FpmlSerialized {

class PreEventCalculation : public ISerialized { 
   public: 
       PreEventCalculation(TiXmlNode* xmlNode);

       bool isEventCalculationList(){return this->eventCalculationListIsNull_;}
       std::vector<boost::shared_ptr<EventCalculationList>> getEventCalculationList();


       bool isJointEventCalculation(){return this->jointEventCalculationIsNull_;}
       std::vector<boost::shared_ptr<JointEventCalculation>> getJointEventCalculation();


   protected: 
       std::vector<boost::shared_ptr<EventCalculationList>> eventCalculationList_;
       
       bool eventCalculationListIsNull_;
       std::vector<boost::shared_ptr<JointEventCalculation>> jointEventCalculation_;
       
       bool jointEventCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif


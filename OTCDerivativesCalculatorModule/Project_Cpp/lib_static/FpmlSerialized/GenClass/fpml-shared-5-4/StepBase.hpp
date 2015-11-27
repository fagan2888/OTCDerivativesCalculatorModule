// StepBase.hpp 
#ifndef FpmlSerialized_StepBase_hpp
#define FpmlSerialized_StepBase_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class StepBase : public ISerialized { 
   public: 
       StepBase(TiXmlNode* xmlNode);

       bool isStepDate(){return this->stepDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getStepDate();
      std::string getStepDateIDRef(){return stepDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> stepDate_;
       std::string stepDateIDRef_;
       bool stepDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif


// InterestAccrualsCompoundingMethod.hpp 
#ifndef FpmlSerialized_InterestAccrualsCompoundingMethod_hpp
#define FpmlSerialized_InterestAccrualsCompoundingMethod_hpp

#include <fpml-shared-5-4/InterestAccrualsMethod.hpp>
#include <fpml-enum-5-4/CompoundingMethodEnum.hpp>

namespace FpmlSerialized {

class InterestAccrualsCompoundingMethod : public InterestAccrualsMethod { 
   public: 
       InterestAccrualsCompoundingMethod(TiXmlNode* xmlNode);

       bool isCompoundingMethod(){return this->compoundingMethodIsNull_;}
       boost::shared_ptr<CompoundingMethodEnum> getCompoundingMethod();
      std::string getCompoundingMethodIDRef(){return compoundingMethodIDRef_;}

   protected: 
       boost::shared_ptr<CompoundingMethodEnum> compoundingMethod_;
       std::string compoundingMethodIDRef_;
       bool compoundingMethodIsNull_;

};

} //namespaceFpmlSerialized end
#endif


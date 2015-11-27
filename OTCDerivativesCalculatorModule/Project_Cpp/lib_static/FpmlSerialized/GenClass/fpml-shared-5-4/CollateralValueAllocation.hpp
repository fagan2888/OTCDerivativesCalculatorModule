// CollateralValueAllocation.hpp 
#ifndef FpmlSerialized_CollateralValueAllocation_hpp
#define FpmlSerialized_CollateralValueAllocation_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/CollateralValueAllocationEnum.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class CollateralValueAllocation : public ISerialized { 
   public: 
       CollateralValueAllocation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<CollateralValueAllocationEnum> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isValue(){return this->valueIsNull_;}
       std::vector<boost::shared_ptr<Money>> getValue();
      std::string getValueIDRef(){return valueIDRef_;}

   protected: 
       boost::shared_ptr<CollateralValueAllocationEnum> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       std::vector<boost::shared_ptr<Money>> value_;
       std::string valueIDRef_;
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif


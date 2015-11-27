// Allocations.hpp 
#ifndef FpmlSerialized_Allocations_hpp
#define FpmlSerialized_Allocations_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/Allocation.hpp>

namespace FpmlSerialized {

class Allocations : public ISerialized { 
   public: 
       Allocations(TiXmlNode* xmlNode);

       bool isAllocation(){return this->allocationIsNull_;}
       std::vector<boost::shared_ptr<Allocation>> getAllocation();
      std::string getAllocationIDRef(){return allocationIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<Allocation>> allocation_;
       std::string allocationIDRef_;
       bool allocationIsNull_;

};

} //namespaceFpmlSerialized end
#endif


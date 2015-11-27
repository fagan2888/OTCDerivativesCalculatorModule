// RelatedBusinessUnit.hpp 
#ifndef FpmlSerialized_RelatedBusinessUnit_hpp
#define FpmlSerialized_RelatedBusinessUnit_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/BusinessUnitReference.hpp>
#include <fpml-shared-5-4/BusinessUnitRole.hpp>

namespace FpmlSerialized {

class RelatedBusinessUnit : public ISerialized { 
   public: 
       RelatedBusinessUnit(TiXmlNode* xmlNode);

       bool isBusinessUnitReference(){return this->businessUnitReferenceIsNull_;}
       boost::shared_ptr<BusinessUnitReference> getBusinessUnitReference();
      std::string getBusinessUnitReferenceIDRef(){return businessUnitReferenceIDRef_;}

       bool isRole(){return this->roleIsNull_;}
       boost::shared_ptr<BusinessUnitRole> getRole();
      std::string getRoleIDRef(){return roleIDRef_;}

   protected: 
       boost::shared_ptr<BusinessUnitReference> businessUnitReference_;
       std::string businessUnitReferenceIDRef_;
       bool businessUnitReferenceIsNull_;
       boost::shared_ptr<BusinessUnitRole> role_;
       std::string roleIDRef_;
       bool roleIsNull_;

};

} //namespaceFpmlSerialized end
#endif


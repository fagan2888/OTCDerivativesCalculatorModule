// RelatedPerson.hpp 
#ifndef FpmlSerialized_RelatedPerson_hpp
#define FpmlSerialized_RelatedPerson_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PersonReference.hpp>
#include <fpml-shared-5-4/PersonRole.hpp>

namespace FpmlSerialized {

class RelatedPerson : public ISerialized { 
   public: 
       RelatedPerson(TiXmlNode* xmlNode);

       bool isPersonReference(){return this->personReferenceIsNull_;}
       boost::shared_ptr<PersonReference> getPersonReference();
      std::string getPersonReferenceIDRef(){return personReferenceIDRef_;}

       bool isRole(){return this->roleIsNull_;}
       boost::shared_ptr<PersonRole> getRole();
      std::string getRoleIDRef(){return roleIDRef_;}

   protected: 
       boost::shared_ptr<PersonReference> personReference_;
       std::string personReferenceIDRef_;
       bool personReferenceIsNull_;
       boost::shared_ptr<PersonRole> role_;
       std::string roleIDRef_;
       bool roleIsNull_;

};

} //namespaceFpmlSerialized end
#endif


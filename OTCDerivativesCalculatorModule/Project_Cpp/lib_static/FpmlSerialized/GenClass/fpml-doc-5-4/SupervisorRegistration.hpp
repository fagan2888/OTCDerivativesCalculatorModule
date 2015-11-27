// SupervisorRegistration.hpp 
#ifndef FpmlSerialized_SupervisorRegistration_hpp
#define FpmlSerialized_SupervisorRegistration_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/SupervisoryBody.hpp>
#include <fpml-doc-5-4/RegulatorId.hpp>

namespace FpmlSerialized {

class SupervisorRegistration : public ISerialized { 
   public: 
       SupervisorRegistration(TiXmlNode* xmlNode);

       bool isSupervisoryBody(){return this->supervisoryBodyIsNull_;}
       boost::shared_ptr<SupervisoryBody> getSupervisoryBody();
      std::string getSupervisoryBodyIDRef(){return supervisoryBodyIDRef_;}

       bool isRegistrationNumber(){return this->registrationNumberIsNull_;}
       boost::shared_ptr<RegulatorId> getRegistrationNumber();
      std::string getRegistrationNumberIDRef(){return registrationNumberIDRef_;}

   protected: 
       boost::shared_ptr<SupervisoryBody> supervisoryBody_;
       std::string supervisoryBodyIDRef_;
       bool supervisoryBodyIsNull_;
       boost::shared_ptr<RegulatorId> registrationNumber_;
       std::string registrationNumberIDRef_;
       bool registrationNumberIsNull_;

};

} //namespaceFpmlSerialized end
#endif


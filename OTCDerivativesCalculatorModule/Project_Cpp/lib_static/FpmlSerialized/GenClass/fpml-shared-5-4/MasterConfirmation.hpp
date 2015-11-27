// MasterConfirmation.hpp 
#ifndef FpmlSerialized_MasterConfirmation_hpp
#define FpmlSerialized_MasterConfirmation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MasterConfirmationType.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/MasterConfirmationAnnexType.hpp>

namespace FpmlSerialized {

class MasterConfirmation : public ISerialized { 
   public: 
       MasterConfirmation(TiXmlNode* xmlNode);

       bool isMasterConfirmationType(){return this->masterConfirmationTypeIsNull_;}
       boost::shared_ptr<MasterConfirmationType> getMasterConfirmationType();
      std::string getMasterConfirmationTypeIDRef(){return masterConfirmationTypeIDRef_;}

       bool isMasterConfirmationDate(){return this->masterConfirmationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMasterConfirmationDate();
      std::string getMasterConfirmationDateIDRef(){return masterConfirmationDateIDRef_;}

       bool isMasterConfirmationAnnexDate(){return this->masterConfirmationAnnexDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMasterConfirmationAnnexDate();
      std::string getMasterConfirmationAnnexDateIDRef(){return masterConfirmationAnnexDateIDRef_;}

       bool isMasterConfirmationAnnexType(){return this->masterConfirmationAnnexTypeIsNull_;}
       boost::shared_ptr<MasterConfirmationAnnexType> getMasterConfirmationAnnexType();
      std::string getMasterConfirmationAnnexTypeIDRef(){return masterConfirmationAnnexTypeIDRef_;}

   protected: 
       boost::shared_ptr<MasterConfirmationType> masterConfirmationType_;
       std::string masterConfirmationTypeIDRef_;
       bool masterConfirmationTypeIsNull_;
       boost::shared_ptr<XsdTypeDate> masterConfirmationDate_;
       std::string masterConfirmationDateIDRef_;
       bool masterConfirmationDateIsNull_;
       boost::shared_ptr<XsdTypeDate> masterConfirmationAnnexDate_;
       std::string masterConfirmationAnnexDateIDRef_;
       bool masterConfirmationAnnexDateIsNull_;
       boost::shared_ptr<MasterConfirmationAnnexType> masterConfirmationAnnexType_;
       std::string masterConfirmationAnnexTypeIDRef_;
       bool masterConfirmationAnnexTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif


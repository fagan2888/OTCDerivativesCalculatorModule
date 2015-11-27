// ExerciseNotice.hpp 
#ifndef FpmlSerialized_ExerciseNotice_hpp
#define FpmlSerialized_ExerciseNotice_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>

namespace FpmlSerialized {

class ExerciseNotice : public ISerialized { 
   public: 
       ExerciseNotice(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isExerciseNoticePartyReference(){return this->exerciseNoticePartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getExerciseNoticePartyReference();
      std::string getExerciseNoticePartyReferenceIDRef(){return exerciseNoticePartyReferenceIDRef_;}

       bool isBusinessCenter(){return this->businessCenterIsNull_;}
       boost::shared_ptr<BusinessCenter> getBusinessCenter();
      std::string getBusinessCenterIDRef(){return businessCenterIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<PartyReference> exerciseNoticePartyReference_;
       std::string exerciseNoticePartyReferenceIDRef_;
       bool exerciseNoticePartyReferenceIsNull_;
       boost::shared_ptr<BusinessCenter> businessCenter_;
       std::string businessCenterIDRef_;
       bool businessCenterIsNull_;

};

} //namespaceFpmlSerialized end
#endif


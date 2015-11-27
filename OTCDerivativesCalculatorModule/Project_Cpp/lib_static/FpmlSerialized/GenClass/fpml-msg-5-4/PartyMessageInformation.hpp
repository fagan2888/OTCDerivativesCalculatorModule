// PartyMessageInformation.hpp 
#ifndef FpmlSerialized_PartyMessageInformation_hpp
#define FpmlSerialized_PartyMessageInformation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class PartyMessageInformation : public ISerialized { 
   public: 
       PartyMessageInformation(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif


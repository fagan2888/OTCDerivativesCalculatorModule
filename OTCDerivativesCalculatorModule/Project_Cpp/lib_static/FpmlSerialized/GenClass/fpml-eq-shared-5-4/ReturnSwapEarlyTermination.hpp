// ReturnSwapEarlyTermination.hpp 
#ifndef FpmlSerialized_ReturnSwapEarlyTermination_hpp
#define FpmlSerialized_ReturnSwapEarlyTermination_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-eq-shared-5-4/StartingDate.hpp>

namespace FpmlSerialized {

class ReturnSwapEarlyTermination : public ISerialized { 
   public: 
       ReturnSwapEarlyTermination(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isStartingDate(){return this->startingDateIsNull_;}
       boost::shared_ptr<StartingDate> getStartingDate();
      std::string getStartingDateIDRef(){return startingDateIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<StartingDate> startingDate_;
       std::string startingDateIDRef_;
       bool startingDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif


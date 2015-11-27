// ElectricityTransmissionContingency.hpp 
#ifndef FpmlSerialized_ElectricityTransmissionContingency_hpp
#define FpmlSerialized_ElectricityTransmissionContingency_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/ElectricityTransmissionContingencyType.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class ElectricityTransmissionContingency : public ISerialized { 
   public: 
       ElectricityTransmissionContingency(TiXmlNode* xmlNode);

       bool isContingency(){return this->contingencyIsNull_;}
       boost::shared_ptr<ElectricityTransmissionContingencyType> getContingency();
      std::string getContingencyIDRef(){return contingencyIDRef_;}

       bool isContingentParty(){return this->contingentPartyIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getContingentParty();
      std::string getContingentPartyIDRef(){return contingentPartyIDRef_;}

   protected: 
       boost::shared_ptr<ElectricityTransmissionContingencyType> contingency_;
       std::string contingencyIDRef_;
       bool contingencyIsNull_;
       std::vector<boost::shared_ptr<PartyReference>> contingentParty_;
       std::string contingentPartyIDRef_;
       bool contingentPartyIsNull_;

};

} //namespaceFpmlSerialized end
#endif


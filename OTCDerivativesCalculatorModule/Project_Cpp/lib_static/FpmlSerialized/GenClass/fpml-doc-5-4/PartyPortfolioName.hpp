// PartyPortfolioName.hpp 
#ifndef FpmlSerialized_PartyPortfolioName_hpp
#define FpmlSerialized_PartyPortfolioName_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-doc-5-4/PortfolioName.hpp>

namespace FpmlSerialized {

class PartyPortfolioName : public ISerialized { 
   public: 
       PartyPortfolioName(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isPortfolioName(){return this->portfolioNameIsNull_;}
       std::vector<boost::shared_ptr<PortfolioName>> getPortfolioName();
      std::string getPortfolioNameIDRef(){return portfolioNameIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       std::vector<boost::shared_ptr<PortfolioName>> portfolioName_;
       std::string portfolioNameIDRef_;
       bool portfolioNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif


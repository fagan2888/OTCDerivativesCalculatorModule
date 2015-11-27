// SwapAdditionalTerms.hpp 
#ifndef FpmlSerialized_SwapAdditionalTerms_hpp
#define FpmlSerialized_SwapAdditionalTerms_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/BondReference.hpp>

namespace FpmlSerialized {

class SwapAdditionalTerms : public ISerialized { 
   public: 
       SwapAdditionalTerms(TiXmlNode* xmlNode);

       bool isBondReference(){return this->bondReferenceIsNull_;}
       boost::shared_ptr<BondReference> getBondReference();
      std::string getBondReferenceIDRef(){return bondReferenceIDRef_;}

   protected: 
       boost::shared_ptr<BondReference> bondReference_;
       std::string bondReferenceIDRef_;
       bool bondReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif


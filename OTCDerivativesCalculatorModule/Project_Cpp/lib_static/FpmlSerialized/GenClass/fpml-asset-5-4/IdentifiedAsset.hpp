// IdentifiedAsset.hpp 
#ifndef FpmlSerialized_IdentifiedAsset_hpp
#define FpmlSerialized_IdentifiedAsset_hpp

#include <fpml-asset-5-4/Asset.hpp>
#include <fpml-shared-5-4/InstrumentId.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class IdentifiedAsset : public Asset { 
   public: 
       IdentifiedAsset(TiXmlNode* xmlNode);

       bool isInstrumentId(){return this->instrumentIdIsNull_;}
       std::vector<boost::shared_ptr<InstrumentId>> getInstrumentId();
      std::string getInstrumentIdIDRef(){return instrumentIdIDRef_;}

       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getDescription();
      std::string getDescriptionIDRef(){return descriptionIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<InstrumentId>> instrumentId_;
       std::string instrumentIdIDRef_;
       bool instrumentIdIsNull_;
       boost::shared_ptr<XsdTypeString> description_;
       std::string descriptionIDRef_;
       bool descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif


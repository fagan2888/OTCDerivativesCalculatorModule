// TermPoint.hpp 
#ifndef FpmlSerialized_TermPoint_hpp
#define FpmlSerialized_TermPoint_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/TimeDimension.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/AssetReference.hpp>

namespace FpmlSerialized {

class TermPoint : public ISerialized { 
   public: 
       TermPoint(TiXmlNode* xmlNode);

       bool isTerm(){return this->termIsNull_;}
       boost::shared_ptr<TimeDimension> getTerm();
      std::string getTermIDRef(){return termIDRef_;}

       bool isBid(){return this->bidIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getBid();
      std::string getBidIDRef(){return bidIDRef_;}

       bool isMid(){return this->midIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getMid();
      std::string getMidIDRef(){return midIDRef_;}

       bool isAsk(){return this->askIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAsk();
      std::string getAskIDRef(){return askIDRef_;}

       bool isSpreadValue(){return this->spreadValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpreadValue();
      std::string getSpreadValueIDRef(){return spreadValueIDRef_;}

       bool isDefinition(){return this->definitionIsNull_;}
       boost::shared_ptr<AssetReference> getDefinition();
      std::string getDefinitionIDRef(){return definitionIDRef_;}

   protected: 
       boost::shared_ptr<TimeDimension> term_;
       std::string termIDRef_;
       bool termIsNull_;
       boost::shared_ptr<XsdTypeDecimal> bid_;
       std::string bidIDRef_;
       bool bidIsNull_;
       boost::shared_ptr<XsdTypeDecimal> mid_;
       std::string midIDRef_;
       bool midIsNull_;
       boost::shared_ptr<XsdTypeDecimal> ask_;
       std::string askIDRef_;
       bool askIsNull_;
       boost::shared_ptr<XsdTypeDecimal> spreadValue_;
       std::string spreadValueIDRef_;
       bool spreadValueIsNull_;
       boost::shared_ptr<AssetReference> definition_;
       std::string definitionIDRef_;
       bool definitionIsNull_;

};

} //namespaceFpmlSerialized end
#endif


// ReferenceLevel.hpp 
#ifndef FpmlSerialized_ReferenceLevel_hpp
#define FpmlSerialized_ReferenceLevel_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-com-5-4/ReferenceLevelUnit.hpp>

namespace FpmlSerialized {

class ReferenceLevel : public ISerialized { 
   public: 
       ReferenceLevel(TiXmlNode* xmlNode);

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       bool isReferenceLevelUnit(){return this->referenceLevelUnitIsNull_;}
       boost::shared_ptr<ReferenceLevelUnit> getReferenceLevelUnit();
      std::string getReferenceLevelUnitIDRef(){return referenceLevelUnitIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;
       boost::shared_ptr<ReferenceLevelUnit> referenceLevelUnit_;
       std::string referenceLevelUnitIDRef_;
       bool referenceLevelUnitIsNull_;

};

} //namespaceFpmlSerialized end
#endif


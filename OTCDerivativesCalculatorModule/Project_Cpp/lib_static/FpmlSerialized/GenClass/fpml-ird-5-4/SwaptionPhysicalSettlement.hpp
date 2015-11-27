// SwaptionPhysicalSettlement.hpp 
#ifndef FpmlSerialized_SwaptionPhysicalSettlement_hpp
#define FpmlSerialized_SwaptionPhysicalSettlement_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class SwaptionPhysicalSettlement : public ISerialized { 
   public: 
       SwaptionPhysicalSettlement(TiXmlNode* xmlNode);

       bool isClearedPhysicalSettlement(){return this->clearedPhysicalSettlementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getClearedPhysicalSettlement();
      std::string getClearedPhysicalSettlementIDRef(){return clearedPhysicalSettlementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> clearedPhysicalSettlement_;
       std::string clearedPhysicalSettlementIDRef_;
       bool clearedPhysicalSettlementIsNull_;

};

} //namespaceFpmlSerialized end
#endif


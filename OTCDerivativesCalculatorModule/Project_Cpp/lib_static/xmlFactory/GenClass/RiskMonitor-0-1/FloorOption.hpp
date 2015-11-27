// FloorOption.hpp 
#ifndef FpmlSerialized_FloorOption_hpp
#define FpmlSerialized_FloorOption_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class FloorOption : public ISerialized { 
   public: 
       FloorOption(TiXmlNode* xmlNode);

       bool isReferenceStr(){return this->referenceStrIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceStr();


       bool isFloorRate(){return this->floorRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFloorRate();


       bool isVol(){return this->volIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVol();


   protected: 
       boost::shared_ptr<XsdTypeToken> referenceStr_;
       
       bool referenceStrIsNull_;
       boost::shared_ptr<XsdTypeToken> floorRate_;
       
       bool floorRateIsNull_;
       boost::shared_ptr<XsdTypeToken> vol_;
       
       bool volIsNull_;

};

} //namespaceFpmlSerialized end
#endif


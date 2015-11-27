// Excel_dualBarrierEventCal.hpp 
#ifndef FpmlSerialized_Excel_dualBarrierEventCal_hpp
#define FpmlSerialized_Excel_dualBarrierEventCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_dualBarrierEventCal : public ISerialized { 
   public: 
       Excel_dualBarrierEventCal(TiXmlNode* xmlNode);

       bool isLowerRng(){return this->lowerRngIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLowerRng();


       bool isUpperRng(){return this->upperRngIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUpperRng();


   protected: 
       boost::shared_ptr<XsdTypeToken> lowerRng_;
       
       bool lowerRngIsNull_;
       boost::shared_ptr<XsdTypeToken> upperRng_;
       
       bool upperRngIsNull_;

};

} //namespaceFpmlSerialized end
#endif


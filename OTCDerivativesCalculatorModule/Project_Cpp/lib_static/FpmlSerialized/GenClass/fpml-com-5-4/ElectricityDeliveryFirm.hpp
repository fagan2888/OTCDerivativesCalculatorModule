// ElectricityDeliveryFirm.hpp 
#ifndef FpmlSerialized_ElectricityDeliveryFirm_hpp
#define FpmlSerialized_ElectricityDeliveryFirm_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ElectricityDeliveryFirm : public ISerialized { 
   public: 
       ElectricityDeliveryFirm(TiXmlNode* xmlNode);

       bool isForceMajeure(){return this->forceMajeureIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getForceMajeure();
      std::string getForceMajeureIDRef(){return forceMajeureIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> forceMajeure_;
       std::string forceMajeureIDRef_;
       bool forceMajeureIsNull_;

};

} //namespaceFpmlSerialized end
#endif


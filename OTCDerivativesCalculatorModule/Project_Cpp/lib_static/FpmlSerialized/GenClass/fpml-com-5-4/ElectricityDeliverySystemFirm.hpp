// ElectricityDeliverySystemFirm.hpp 
#ifndef FpmlSerialized_ElectricityDeliverySystemFirm_hpp
#define FpmlSerialized_ElectricityDeliverySystemFirm_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>

namespace FpmlSerialized {

class ElectricityDeliverySystemFirm : public ISerialized { 
   public: 
       ElectricityDeliverySystemFirm(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isSystem(){return this->systemIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getSystem();
      std::string getSystemIDRef(){return systemIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<CommodityDeliveryPoint> system_;
       std::string systemIDRef_;
       bool systemIsNull_;

};

} //namespaceFpmlSerialized end
#endif


// ElectricityDeliveryType.hpp 
#ifndef FpmlSerialized_ElectricityDeliveryType_hpp
#define FpmlSerialized_ElectricityDeliveryType_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/ElectricityDeliveryFirm.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/ElectricityDeliverySystemFirm.hpp>
#include <fpml-com-5-4/ElectricityDeliveryUnitFirm.hpp>

namespace FpmlSerialized {

class ElectricityDeliveryType : public ISerialized { 
   public: 
       ElectricityDeliveryType(TiXmlNode* xmlNode);

       bool isFirm(){return this->firmIsNull_;}
       boost::shared_ptr<ElectricityDeliveryFirm> getFirm();
      std::string getFirmIDRef(){return firmIDRef_;}

       bool isNonFirm(){return this->nonFirmIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNonFirm();
      std::string getNonFirmIDRef(){return nonFirmIDRef_;}

       bool isSystemFirm(){return this->systemFirmIsNull_;}
       boost::shared_ptr<ElectricityDeliverySystemFirm> getSystemFirm();
      std::string getSystemFirmIDRef(){return systemFirmIDRef_;}

       bool isUnitFirm(){return this->unitFirmIsNull_;}
       boost::shared_ptr<ElectricityDeliveryUnitFirm> getUnitFirm();
      std::string getUnitFirmIDRef(){return unitFirmIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!firmIsNull_){
                count += 1;
                str = "firm" ;
           }
           if(!nonFirmIsNull_){
                count += 1;
                str = "nonFirm" ;
           }
           if(!systemFirmIsNull_){
                count += 1;
                str = "systemFirm" ;
           }
           if(!unitFirmIsNull_){
                count += 1;
                str = "unitFirm" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<ElectricityDeliveryFirm> firm_;     //choice
       std::string firmIDRef_;
       bool firmIsNull_;
         boost::shared_ptr<XsdTypeBoolean> nonFirm_;     //choice
       std::string nonFirmIDRef_;
       bool nonFirmIsNull_;
         boost::shared_ptr<ElectricityDeliverySystemFirm> systemFirm_;     //choice
       std::string systemFirmIDRef_;
       bool systemFirmIsNull_;
         boost::shared_ptr<ElectricityDeliveryUnitFirm> unitFirm_;     //choice
       std::string unitFirmIDRef_;
       bool unitFirmIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif


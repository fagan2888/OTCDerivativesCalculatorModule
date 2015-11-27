// GasPhysicalQuantity.hpp 
#ifndef FpmlSerialized_GasPhysicalQuantity_hpp
#define FpmlSerialized_GasPhysicalQuantity_hpp

#include <fpml-com-5-4/CommodityPhysicalQuantityBase.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommodityPhysicalQuantitySchedule.hpp>
#include <fpml-com-5-4/UnitQuantity.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class GasPhysicalQuantity : public CommodityPhysicalQuantityBase { 
   public: 
       GasPhysicalQuantity(TiXmlNode* xmlNode);

       bool isPhysicalQuantity(){return this->physicalQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getPhysicalQuantity();
      std::string getPhysicalQuantityIDRef(){return physicalQuantityIDRef_;}

       bool isPhysicalQuantitySchedule(){return this->physicalQuantityScheduleIsNull_;}
       boost::shared_ptr<CommodityPhysicalQuantitySchedule> getPhysicalQuantitySchedule();
      std::string getPhysicalQuantityScheduleIDRef(){return physicalQuantityScheduleIDRef_;}

       bool isTotalPhysicalQuantity(){return this->totalPhysicalQuantityIsNull_;}
       boost::shared_ptr<UnitQuantity> getTotalPhysicalQuantity();
      std::string getTotalPhysicalQuantityIDRef(){return totalPhysicalQuantityIDRef_;}

       bool isMinPhysicalQuantity(){return this->minPhysicalQuantityIsNull_;}
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> getMinPhysicalQuantity();
      std::string getMinPhysicalQuantityIDRef(){return minPhysicalQuantityIDRef_;}

       bool isMaxPhysicalQuantity(){return this->maxPhysicalQuantityIsNull_;}
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> getMaxPhysicalQuantity();
      std::string getMaxPhysicalQuantityIDRef(){return maxPhysicalQuantityIDRef_;}

       bool isElectingParty(){return this->electingPartyIsNull_;}
       boost::shared_ptr<PartyReference> getElectingParty();
      std::string getElectingPartyIDRef(){return electingPartyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!totalPhysicalQuantityIsNull_){
                count += 1;
                str = "totalPhysicalQuantity" ;
           }
           if(!minPhysicalQuantityIsNull_){
                count += 1;
                str = "minPhysicalQuantity" ;
           }
           if(!maxPhysicalQuantityIsNull_){
                count += 1;
                str = "maxPhysicalQuantity" ;
           }
           if(!electingPartyIsNull_){
                count += 1;
                str = "electingParty" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!physicalQuantityIsNull_){
                count += 1;
                str = "physicalQuantity" ;
           }
           if(!physicalQuantityScheduleIsNull_){
                count += 1;
                str = "physicalQuantitySchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<CommodityNotionalQuantity> physicalQuantity_;     //choice
       std::string physicalQuantityIDRef_;
       bool physicalQuantityIsNull_;
         boost::shared_ptr<CommodityPhysicalQuantitySchedule> physicalQuantitySchedule_;     //choice
       std::string physicalQuantityScheduleIDRef_;
       bool physicalQuantityScheduleIsNull_;
         boost::shared_ptr<UnitQuantity> totalPhysicalQuantity_;     //choice
       std::string totalPhysicalQuantityIDRef_;
       bool totalPhysicalQuantityIsNull_;
         std::vector<boost::shared_ptr<CommodityNotionalQuantity>> minPhysicalQuantity_;     //choice
       std::string minPhysicalQuantityIDRef_;
       bool minPhysicalQuantityIsNull_;
         std::vector<boost::shared_ptr<CommodityNotionalQuantity>> maxPhysicalQuantity_;     //choice
       std::string maxPhysicalQuantityIDRef_;
       bool maxPhysicalQuantityIsNull_;
         boost::shared_ptr<PartyReference> electingParty_;     //choice
       std::string electingPartyIDRef_;
       bool electingPartyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif


// SettlementRateSource.hpp 
#ifndef FpmlSerialized_SettlementRateSource_hpp
#define FpmlSerialized_SettlementRateSource_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>
#include <fpml-shared-5-4/CashSettlementReferenceBanks.hpp>

namespace FpmlSerialized {

class SettlementRateSource : public ISerialized { 
   public: 
       SettlementRateSource(TiXmlNode* xmlNode);

       bool isInformationSource(){return this->informationSourceIsNull_;}
       boost::shared_ptr<InformationSource> getInformationSource();
      std::string getInformationSourceIDRef(){return informationSourceIDRef_;}

       bool isCashSettlementReferenceBanks(){return this->cashSettlementReferenceBanksIsNull_;}
       boost::shared_ptr<CashSettlementReferenceBanks> getCashSettlementReferenceBanks();
      std::string getCashSettlementReferenceBanksIDRef(){return cashSettlementReferenceBanksIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!informationSourceIsNull_){
                count += 1;
                str = "informationSource" ;
           }
           if(!cashSettlementReferenceBanksIsNull_){
                count += 1;
                str = "cashSettlementReferenceBanks" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<InformationSource> informationSource_;     //choice
       std::string informationSourceIDRef_;
       bool informationSourceIsNull_;
         boost::shared_ptr<CashSettlementReferenceBanks> cashSettlementReferenceBanks_;     //choice
       std::string cashSettlementReferenceBanksIDRef_;
       bool cashSettlementReferenceBanksIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif


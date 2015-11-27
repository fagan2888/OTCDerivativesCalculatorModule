// OilDelivery.hpp 
#ifndef FpmlSerialized_OilDelivery_hpp
#define FpmlSerialized_OilDelivery_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/OilPipelineDelivery.hpp>
#include <fpml-com-5-4/OilTransferDelivery.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-com-5-4/AbsoluteTolerance.hpp>
#include <fpml-com-5-4/PercentageTolerance.hpp>

namespace FpmlSerialized {

class OilDelivery : public ISerialized { 
   public: 
       OilDelivery(TiXmlNode* xmlNode);

       bool isPipeline(){return this->pipelineIsNull_;}
       boost::shared_ptr<OilPipelineDelivery> getPipeline();
      std::string getPipelineIDRef(){return pipelineIDRef_;}

       bool isTransfer(){return this->transferIsNull_;}
       boost::shared_ptr<OilTransferDelivery> getTransfer();
      std::string getTransferIDRef(){return transferIDRef_;}

       bool isImporterOfRecord(){return this->importerOfRecordIsNull_;}
       boost::shared_ptr<PartyReference> getImporterOfRecord();
      std::string getImporterOfRecordIDRef(){return importerOfRecordIDRef_;}

       bool isAbsoluteTolerance(){return this->absoluteToleranceIsNull_;}
       boost::shared_ptr<AbsoluteTolerance> getAbsoluteTolerance();
      std::string getAbsoluteToleranceIDRef(){return absoluteToleranceIDRef_;}

       bool isPercentageTolerance(){return this->percentageToleranceIsNull_;}
       boost::shared_ptr<PercentageTolerance> getPercentageTolerance();
      std::string getPercentageToleranceIDRef(){return percentageToleranceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!pipelineIsNull_){
                count += 1;
                str = "pipeline" ;
           }
           if(!transferIsNull_){
                count += 1;
                str = "transfer" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!absoluteToleranceIsNull_){
                count += 1;
                str = "absoluteTolerance" ;
           }
           if(!percentageToleranceIsNull_){
                count += 1;
                str = "percentageTolerance" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<OilPipelineDelivery> pipeline_;     //choice
       std::string pipelineIDRef_;
       bool pipelineIsNull_;
         boost::shared_ptr<OilTransferDelivery> transfer_;     //choice
       std::string transferIDRef_;
       bool transferIsNull_;
       boost::shared_ptr<PartyReference> importerOfRecord_;
       std::string importerOfRecordIDRef_;
       bool importerOfRecordIsNull_;
         boost::shared_ptr<AbsoluteTolerance> absoluteTolerance_;     //choice
       std::string absoluteToleranceIDRef_;
       bool absoluteToleranceIsNull_;
         boost::shared_ptr<PercentageTolerance> percentageTolerance_;     //choice
       std::string percentageToleranceIDRef_;
       bool percentageToleranceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif


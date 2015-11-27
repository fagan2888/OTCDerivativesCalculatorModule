// OilPipelineDelivery.hpp 
#ifndef FpmlSerialized_OilPipelineDelivery_hpp
#define FpmlSerialized_OilPipelineDelivery_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityPipeline.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityDeliveryRisk.hpp>
#include <fpml-com-5-4/CommodityPipelineCycle.hpp>

namespace FpmlSerialized {

class OilPipelineDelivery : public ISerialized { 
   public: 
       OilPipelineDelivery(TiXmlNode* xmlNode);

       bool isPipelineName(){return this->pipelineNameIsNull_;}
       boost::shared_ptr<CommodityPipeline> getPipelineName();
      std::string getPipelineNameIDRef(){return pipelineNameIDRef_;}

       bool isWithdrawalPoint(){return this->withdrawalPointIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getWithdrawalPoint();
      std::string getWithdrawalPointIDRef(){return withdrawalPointIDRef_;}

       bool isEntryPoint(){return this->entryPointIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getEntryPoint();
      std::string getEntryPointIDRef(){return entryPointIDRef_;}

       bool isDeliverableByBarge(){return this->deliverableByBargeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDeliverableByBarge();
      std::string getDeliverableByBargeIDRef(){return deliverableByBargeIDRef_;}

       bool isRisk(){return this->riskIsNull_;}
       boost::shared_ptr<CommodityDeliveryRisk> getRisk();
      std::string getRiskIDRef(){return riskIDRef_;}

       bool isCycle(){return this->cycleIsNull_;}
       std::vector<boost::shared_ptr<CommodityPipelineCycle>> getCycle();
      std::string getCycleIDRef(){return cycleIDRef_;}

   protected: 
       boost::shared_ptr<CommodityPipeline> pipelineName_;
       std::string pipelineNameIDRef_;
       bool pipelineNameIsNull_;
       boost::shared_ptr<CommodityDeliveryPoint> withdrawalPoint_;
       std::string withdrawalPointIDRef_;
       bool withdrawalPointIsNull_;
       boost::shared_ptr<CommodityDeliveryPoint> entryPoint_;
       std::string entryPointIDRef_;
       bool entryPointIsNull_;
       boost::shared_ptr<XsdTypeBoolean> deliverableByBarge_;
       std::string deliverableByBargeIDRef_;
       bool deliverableByBargeIsNull_;
       boost::shared_ptr<CommodityDeliveryRisk> risk_;
       std::string riskIDRef_;
       bool riskIsNull_;
       std::vector<boost::shared_ptr<CommodityPipelineCycle>> cycle_;
       std::string cycleIDRef_;
       bool cycleIsNull_;

};

} //namespaceFpmlSerialized end
#endif


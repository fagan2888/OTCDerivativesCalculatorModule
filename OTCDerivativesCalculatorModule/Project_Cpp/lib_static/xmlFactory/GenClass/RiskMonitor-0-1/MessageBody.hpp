// MessageBody.hpp 
#ifndef FpmlSerialized_MessageBody_hpp
#define FpmlSerialized_MessageBody_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/MaturityNotification.hpp>
#include <RiskMonitor-0-1/GridCalculation.hpp>
#include <RiskMonitor-0-1/ClearQueue.hpp>
#include <RiskMonitor-0-1/GridCalculationStart.hpp>
#include <RiskMonitor-0-1/CalculationServerInfo.hpp>

namespace FpmlSerialized {

class MessageBody : public ISerialized { 
   public: 
       MessageBody(TiXmlNode* xmlNode);

       bool isMsg_type(){return this->msg_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMsg_type();


       bool isMaturityNotification(){return this->maturityNotificationIsNull_;}
       boost::shared_ptr<MaturityNotification> getMaturityNotification();


       bool isGridCalculation(){return this->gridCalculationIsNull_;}
       boost::shared_ptr<GridCalculation> getGridCalculation();


       bool isClearQueue(){return this->clearQueueIsNull_;}
       boost::shared_ptr<ClearQueue> getClearQueue();


       bool isGridCalculationStart(){return this->gridCalculationStartIsNull_;}
       boost::shared_ptr<GridCalculationStart> getGridCalculationStart();


       bool isCalculationServerInfo(){return this->calculationServerInfoIsNull_;}
       boost::shared_ptr<CalculationServerInfo> getCalculationServerInfo();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!maturityNotificationIsNull_){
                count += 1;
                str = "maturityNotification" ;
           }
           if(!gridCalculationIsNull_){
                count += 1;
                str = "gridCalculation" ;
           }
           if(!clearQueueIsNull_){
                count += 1;
                str = "clearQueue" ;
           }
           if(!gridCalculationStartIsNull_){
                count += 1;
                str = "gridCalculationStart" ;
           }
           if(!calculationServerInfoIsNull_){
                count += 1;
                str = "calculationServerInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> msg_type_;
       
       bool msg_typeIsNull_;
         boost::shared_ptr<MaturityNotification> maturityNotification_;     //choice
       
       bool maturityNotificationIsNull_;
         boost::shared_ptr<GridCalculation> gridCalculation_;     //choice
       
       bool gridCalculationIsNull_;
         boost::shared_ptr<ClearQueue> clearQueue_;     //choice
       
       bool clearQueueIsNull_;
         boost::shared_ptr<GridCalculationStart> gridCalculationStart_;     //choice
       
       bool gridCalculationStartIsNull_;
         boost::shared_ptr<CalculationServerInfo> calculationServerInfo_;     //choice
       
       bool calculationServerInfoIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif


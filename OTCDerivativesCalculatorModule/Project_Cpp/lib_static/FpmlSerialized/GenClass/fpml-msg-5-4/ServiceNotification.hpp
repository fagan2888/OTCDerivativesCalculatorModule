// ServiceNotification.hpp 
#ifndef FpmlSerialized_ServiceNotification_hpp
#define FpmlSerialized_ServiceNotification_hpp

#include <fpml-msg-5-4/NotificationMessage.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-msg-5-4/ServiceStatus.hpp>
#include <fpml-msg-5-4/ServiceProcessingStatus.hpp>
#include <fpml-msg-5-4/ServiceAdvisory.hpp>

namespace FpmlSerialized {

class ServiceNotification : public NotificationMessage { 
   public: 
       ServiceNotification(TiXmlNode* xmlNode);

       bool isServiceName(){return this->serviceNameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getServiceName();
      std::string getServiceNameIDRef(){return serviceNameIDRef_;}

       bool isStatus(){return this->statusIsNull_;}
       boost::shared_ptr<ServiceStatus> getStatus();
      std::string getStatusIDRef(){return statusIDRef_;}

       bool isProcessingStatus(){return this->processingStatusIsNull_;}
       boost::shared_ptr<ServiceProcessingStatus> getProcessingStatus();
      std::string getProcessingStatusIDRef(){return processingStatusIDRef_;}

       bool isAdvisory(){return this->advisoryIsNull_;}
       boost::shared_ptr<ServiceAdvisory> getAdvisory();
      std::string getAdvisoryIDRef(){return advisoryIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!statusIsNull_){
                count += 1;
                str = "status" ;
           }
           if(!processingStatusIsNull_){
                count += 1;
                str = "processingStatus" ;
           }
           if(!advisoryIsNull_){
                count += 1;
                str = "advisory" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> serviceName_;
       std::string serviceNameIDRef_;
       bool serviceNameIsNull_;
         boost::shared_ptr<ServiceStatus> status_;     //choice
       std::string statusIDRef_;
       bool statusIsNull_;
         boost::shared_ptr<ServiceProcessingStatus> processingStatus_;     //choice
       std::string processingStatusIDRef_;
       bool processingStatusIsNull_;
         boost::shared_ptr<ServiceAdvisory> advisory_;     //choice
       std::string advisoryIDRef_;
       bool advisoryIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif


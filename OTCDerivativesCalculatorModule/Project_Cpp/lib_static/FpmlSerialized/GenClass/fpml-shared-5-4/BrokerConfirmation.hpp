// BrokerConfirmation.hpp 
#ifndef FpmlSerialized_BrokerConfirmation_hpp
#define FpmlSerialized_BrokerConfirmation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/BrokerConfirmationType.hpp>

namespace FpmlSerialized {

class BrokerConfirmation : public ISerialized { 
   public: 
       BrokerConfirmation(TiXmlNode* xmlNode);

       bool isBrokerConfirmationType(){return this->brokerConfirmationTypeIsNull_;}
       boost::shared_ptr<BrokerConfirmationType> getBrokerConfirmationType();
      std::string getBrokerConfirmationTypeIDRef(){return brokerConfirmationTypeIDRef_;}

   protected: 
       boost::shared_ptr<BrokerConfirmationType> brokerConfirmationType_;
       std::string brokerConfirmationTypeIDRef_;
       bool brokerConfirmationTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif


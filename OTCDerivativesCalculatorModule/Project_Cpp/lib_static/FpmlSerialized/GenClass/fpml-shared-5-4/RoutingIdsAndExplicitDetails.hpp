// RoutingIdsAndExplicitDetails.hpp 
#ifndef FpmlSerialized_RoutingIdsAndExplicitDetails_hpp
#define FpmlSerialized_RoutingIdsAndExplicitDetails_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/RoutingIds.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/Address.hpp>

namespace FpmlSerialized {

class RoutingIdsAndExplicitDetails : public ISerialized { 
   public: 
       RoutingIdsAndExplicitDetails(TiXmlNode* xmlNode);

       bool isRoutingIds(){return this->routingIdsIsNull_;}
       std::vector<boost::shared_ptr<RoutingIds>> getRoutingIds();
      std::string getRoutingIdsIDRef(){return routingIdsIDRef_;}

       bool isRoutingName(){return this->routingNameIsNull_;}
       boost::shared_ptr<XsdTypeString> getRoutingName();
      std::string getRoutingNameIDRef(){return routingNameIDRef_;}

       bool isRoutingAddress(){return this->routingAddressIsNull_;}
       boost::shared_ptr<Address> getRoutingAddress();
      std::string getRoutingAddressIDRef(){return routingAddressIDRef_;}

       bool isRoutingAccountNumber(){return this->routingAccountNumberIsNull_;}
       boost::shared_ptr<XsdTypeString> getRoutingAccountNumber();
      std::string getRoutingAccountNumberIDRef(){return routingAccountNumberIDRef_;}

       bool isRoutingReferenceText(){return this->routingReferenceTextIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeString>> getRoutingReferenceText();
      std::string getRoutingReferenceTextIDRef(){return routingReferenceTextIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<RoutingIds>> routingIds_;
       std::string routingIdsIDRef_;
       bool routingIdsIsNull_;
       boost::shared_ptr<XsdTypeString> routingName_;
       std::string routingNameIDRef_;
       bool routingNameIsNull_;
       boost::shared_ptr<Address> routingAddress_;
       std::string routingAddressIDRef_;
       bool routingAddressIsNull_;
       boost::shared_ptr<XsdTypeString> routingAccountNumber_;
       std::string routingAccountNumberIDRef_;
       bool routingAccountNumberIsNull_;
       std::vector<boost::shared_ptr<XsdTypeString>> routingReferenceText_;
       std::string routingReferenceTextIDRef_;
       bool routingReferenceTextIsNull_;

};

} //namespaceFpmlSerialized end
#endif


// RoutingIds.hpp 
#ifndef FpmlSerialized_RoutingIds_hpp
#define FpmlSerialized_RoutingIds_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/RoutingId.hpp>

namespace FpmlSerialized {

class RoutingIds : public ISerialized { 
   public: 
       RoutingIds(TiXmlNode* xmlNode);

       bool isRoutingId(){return this->routingIdIsNull_;}
       std::vector<boost::shared_ptr<RoutingId>> getRoutingId();
      std::string getRoutingIdIDRef(){return routingIdIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<RoutingId>> routingId_;
       std::string routingIdIDRef_;
       bool routingIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif


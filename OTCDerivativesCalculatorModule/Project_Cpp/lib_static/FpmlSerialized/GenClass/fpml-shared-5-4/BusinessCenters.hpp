// BusinessCenters.hpp 
#ifndef FpmlSerialized_BusinessCenters_hpp
#define FpmlSerialized_BusinessCenters_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>

namespace FpmlSerialized {

class BusinessCenters : public ISerialized { 
   public: 
       BusinessCenters(TiXmlNode* xmlNode);

       bool isBusinessCenter(){return this->businessCenterIsNull_;}
       std::vector<boost::shared_ptr<BusinessCenter>> getBusinessCenter();
      std::string getBusinessCenterIDRef(){return businessCenterIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<BusinessCenter>> businessCenter_;
       std::string businessCenterIDRef_;
       bool businessCenterIsNull_;

};

} //namespaceFpmlSerialized end
#endif


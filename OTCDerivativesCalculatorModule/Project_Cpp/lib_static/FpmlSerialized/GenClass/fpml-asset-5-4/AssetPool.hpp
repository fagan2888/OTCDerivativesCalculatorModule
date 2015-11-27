// AssetPool.hpp 
#ifndef FpmlSerialized_AssetPool_hpp
#define FpmlSerialized_AssetPool_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class AssetPool : public ISerialized { 
   public: 
       AssetPool(TiXmlNode* xmlNode);

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isInitialFactor(){return this->initialFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialFactor();
      std::string getInitialFactorIDRef(){return initialFactorIDRef_;}

       bool isCurrentFactor(){return this->currentFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCurrentFactor();
      std::string getCurrentFactorIDRef(){return currentFactorIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNonNegativeInteger> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<IdentifiedDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> initialFactor_;
       std::string initialFactorIDRef_;
       bool initialFactorIsNull_;
       boost::shared_ptr<XsdTypeDecimal> currentFactor_;
       std::string currentFactorIDRef_;
       bool currentFactorIsNull_;

};

} //namespaceFpmlSerialized end
#endif


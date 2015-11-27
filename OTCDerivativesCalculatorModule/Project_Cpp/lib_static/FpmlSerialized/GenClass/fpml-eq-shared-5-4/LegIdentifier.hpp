// LegIdentifier.hpp 
#ifndef FpmlSerialized_LegIdentifier_hpp
#define FpmlSerialized_LegIdentifier_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/LegId.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>

namespace FpmlSerialized {

class LegIdentifier : public ISerialized { 
   public: 
       LegIdentifier(TiXmlNode* xmlNode);

       bool isLegId(){return this->legIdIsNull_;}
       boost::shared_ptr<LegId> getLegId();
      std::string getLegIdIDRef(){return legIdIDRef_;}

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

   protected: 
       boost::shared_ptr<LegId> legId_;
       std::string legIdIDRef_;
       bool legIdIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<IdentifiedDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif


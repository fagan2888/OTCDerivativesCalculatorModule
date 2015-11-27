// ExtendibleProvisionAdjustedDates.hpp 
#ifndef FpmlSerialized_ExtendibleProvisionAdjustedDates_hpp
#define FpmlSerialized_ExtendibleProvisionAdjustedDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/ExtensionEvent.hpp>

namespace FpmlSerialized {

class ExtendibleProvisionAdjustedDates : public ISerialized { 
   public: 
       ExtendibleProvisionAdjustedDates(TiXmlNode* xmlNode);

       bool isExtensionEvent(){return this->extensionEventIsNull_;}
       std::vector<boost::shared_ptr<ExtensionEvent>> getExtensionEvent();
      std::string getExtensionEventIDRef(){return extensionEventIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ExtensionEvent>> extensionEvent_;
       std::string extensionEventIDRef_;
       bool extensionEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif


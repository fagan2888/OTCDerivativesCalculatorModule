// FxSpotRateSource.hpp 
#ifndef FpmlSerialized_FxSpotRateSource_hpp
#define FpmlSerialized_FxSpotRateSource_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>

namespace FpmlSerialized {

class FxSpotRateSource : public ISerialized { 
   public: 
       FxSpotRateSource(TiXmlNode* xmlNode);

       bool isPrimaryRateSource(){return this->primaryRateSourceIsNull_;}
       boost::shared_ptr<InformationSource> getPrimaryRateSource();
      std::string getPrimaryRateSourceIDRef(){return primaryRateSourceIDRef_;}

       bool isSecondaryRateSource(){return this->secondaryRateSourceIsNull_;}
       boost::shared_ptr<InformationSource> getSecondaryRateSource();
      std::string getSecondaryRateSourceIDRef(){return secondaryRateSourceIDRef_;}

       bool isFixingTime(){return this->fixingTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getFixingTime();
      std::string getFixingTimeIDRef(){return fixingTimeIDRef_;}

   protected: 
       boost::shared_ptr<InformationSource> primaryRateSource_;
       std::string primaryRateSourceIDRef_;
       bool primaryRateSourceIsNull_;
       boost::shared_ptr<InformationSource> secondaryRateSource_;
       std::string secondaryRateSourceIDRef_;
       bool secondaryRateSourceIsNull_;
       boost::shared_ptr<BusinessCenterTime> fixingTime_;
       std::string fixingTimeIDRef_;
       bool fixingTimeIsNull_;

};

} //namespaceFpmlSerialized end
#endif


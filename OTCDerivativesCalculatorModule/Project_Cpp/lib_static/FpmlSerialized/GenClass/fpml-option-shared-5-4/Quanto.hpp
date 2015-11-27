// Quanto.hpp 
#ifndef FpmlSerialized_Quanto_hpp
#define FpmlSerialized_Quanto_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/FxRate.hpp>
#include <fpml-shared-5-4/FxSpotRateSource.hpp>

namespace FpmlSerialized {

class Quanto : public ISerialized { 
   public: 
       Quanto(TiXmlNode* xmlNode);

       bool isFxRate(){return this->fxRateIsNull_;}
       std::vector<boost::shared_ptr<FxRate>> getFxRate();
      std::string getFxRateIDRef(){return fxRateIDRef_;}

       bool isFxSpotRateSource(){return this->fxSpotRateSourceIsNull_;}
       boost::shared_ptr<FxSpotRateSource> getFxSpotRateSource();
      std::string getFxSpotRateSourceIDRef(){return fxSpotRateSourceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<FxRate>> fxRate_;
       std::string fxRateIDRef_;
       bool fxRateIsNull_;
       boost::shared_ptr<FxSpotRateSource> fxSpotRateSource_;
       std::string fxSpotRateSourceIDRef_;
       bool fxSpotRateSourceIsNull_;

};

} //namespaceFpmlSerialized end
#endif


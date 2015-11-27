// Composite.hpp 
#ifndef FpmlSerialized_Composite_hpp
#define FpmlSerialized_Composite_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/FxSpotRateSource.hpp>

namespace FpmlSerialized {

class Composite : public ISerialized { 
   public: 
       Composite(TiXmlNode* xmlNode);

       bool isDeterminationMethod(){return this->determinationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethod> getDeterminationMethod();
      std::string getDeterminationMethodIDRef(){return determinationMethodIDRef_;}

       bool isRelativeDate(){return this->relativeDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getRelativeDate();
      std::string getRelativeDateIDRef(){return relativeDateIDRef_;}

       bool isFxSpotRateSource(){return this->fxSpotRateSourceIsNull_;}
       boost::shared_ptr<FxSpotRateSource> getFxSpotRateSource();
      std::string getFxSpotRateSourceIDRef(){return fxSpotRateSourceIDRef_;}

   protected: 
       boost::shared_ptr<DeterminationMethod> determinationMethod_;
       std::string determinationMethodIDRef_;
       bool determinationMethodIsNull_;
       boost::shared_ptr<RelativeDateOffset> relativeDate_;
       std::string relativeDateIDRef_;
       bool relativeDateIsNull_;
       boost::shared_ptr<FxSpotRateSource> fxSpotRateSource_;
       std::string fxSpotRateSourceIDRef_;
       bool fxSpotRateSourceIsNull_;

};

} //namespaceFpmlSerialized end
#endif


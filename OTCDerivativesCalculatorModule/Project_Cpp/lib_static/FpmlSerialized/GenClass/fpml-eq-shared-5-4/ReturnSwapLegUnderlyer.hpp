// ReturnSwapLegUnderlyer.hpp 
#ifndef FpmlSerialized_ReturnSwapLegUnderlyer_hpp
#define FpmlSerialized_ReturnSwapLegUnderlyer_hpp

#include <fpml-eq-shared-5-4/DirectionalLeg.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-asset-5-4/Underlyer.hpp>

namespace FpmlSerialized {

class ReturnSwapLegUnderlyer : public DirectionalLeg { 
   public: 
       ReturnSwapLegUnderlyer(TiXmlNode* xmlNode);

       bool isStrikeDate(){return this->strikeDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getStrikeDate();
      std::string getStrikeDateIDRef(){return strikeDateIDRef_;}

       bool isUnderlyer(){return this->underlyerIsNull_;}
       boost::shared_ptr<Underlyer> getUnderlyer();
      std::string getUnderlyerIDRef(){return underlyerIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> strikeDate_;
       std::string strikeDateIDRef_;
       bool strikeDateIsNull_;
       boost::shared_ptr<Underlyer> underlyer_;
       std::string underlyerIDRef_;
       bool underlyerIsNull_;

};

} //namespaceFpmlSerialized end
#endif


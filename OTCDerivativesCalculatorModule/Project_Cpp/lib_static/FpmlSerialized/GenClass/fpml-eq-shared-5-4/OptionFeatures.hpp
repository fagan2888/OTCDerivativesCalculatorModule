// OptionFeatures.hpp 
#ifndef FpmlSerialized_OptionFeatures_hpp
#define FpmlSerialized_OptionFeatures_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/Asian.hpp>
#include <fpml-option-shared-5-4/Barrier.hpp>
#include <fpml-option-shared-5-4/Knock.hpp>
#include <fpml-option-shared-5-4/PassThrough.hpp>
#include <fpml-eq-shared-5-4/DividendAdjustment.hpp>

namespace FpmlSerialized {

class OptionFeatures : public ISerialized { 
   public: 
       OptionFeatures(TiXmlNode* xmlNode);

       bool isAsian(){return this->asianIsNull_;}
       boost::shared_ptr<Asian> getAsian();
      std::string getAsianIDRef(){return asianIDRef_;}

       bool isBarrier(){return this->barrierIsNull_;}
       boost::shared_ptr<Barrier> getBarrier();
      std::string getBarrierIDRef(){return barrierIDRef_;}

       bool isKnock(){return this->knockIsNull_;}
       boost::shared_ptr<Knock> getKnock();
      std::string getKnockIDRef(){return knockIDRef_;}

       bool isPassThrough(){return this->passThroughIsNull_;}
       boost::shared_ptr<PassThrough> getPassThrough();
      std::string getPassThroughIDRef(){return passThroughIDRef_;}

       bool isDividendAdjustment(){return this->dividendAdjustmentIsNull_;}
       boost::shared_ptr<DividendAdjustment> getDividendAdjustment();
      std::string getDividendAdjustmentIDRef(){return dividendAdjustmentIDRef_;}

   protected: 
       boost::shared_ptr<Asian> asian_;
       std::string asianIDRef_;
       bool asianIsNull_;
       boost::shared_ptr<Barrier> barrier_;
       std::string barrierIDRef_;
       bool barrierIsNull_;
       boost::shared_ptr<Knock> knock_;
       std::string knockIDRef_;
       bool knockIsNull_;
       boost::shared_ptr<PassThrough> passThrough_;
       std::string passThroughIDRef_;
       bool passThroughIsNull_;
       boost::shared_ptr<DividendAdjustment> dividendAdjustment_;
       std::string dividendAdjustmentIDRef_;
       bool dividendAdjustmentIsNull_;

};

} //namespaceFpmlSerialized end
#endif


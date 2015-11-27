// ReferenceSwapCurve.hpp 
#ifndef FpmlSerialized_ReferenceSwapCurve_hpp
#define FpmlSerialized_ReferenceSwapCurve_hpp

#include <ISerialized.hpp>
#include <fpml-bond-option-5-4/SwapCurveValuation.hpp>
#include <fpml-bond-option-5-4/MakeWholeAmount.hpp>

namespace FpmlSerialized {

class ReferenceSwapCurve : public ISerialized { 
   public: 
       ReferenceSwapCurve(TiXmlNode* xmlNode);

       bool isSwapUnwindValue(){return this->swapUnwindValueIsNull_;}
       boost::shared_ptr<SwapCurveValuation> getSwapUnwindValue();
      std::string getSwapUnwindValueIDRef(){return swapUnwindValueIDRef_;}

       bool isMakeWholeAmount(){return this->makeWholeAmountIsNull_;}
       boost::shared_ptr<MakeWholeAmount> getMakeWholeAmount();
      std::string getMakeWholeAmountIDRef(){return makeWholeAmountIDRef_;}

   protected: 
       boost::shared_ptr<SwapCurveValuation> swapUnwindValue_;
       std::string swapUnwindValueIDRef_;
       bool swapUnwindValueIsNull_;
       boost::shared_ptr<MakeWholeAmount> makeWholeAmount_;
       std::string makeWholeAmountIDRef_;
       bool makeWholeAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


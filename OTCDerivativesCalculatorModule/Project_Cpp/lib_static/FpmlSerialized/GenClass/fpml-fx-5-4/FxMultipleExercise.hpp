// FxMultipleExercise.hpp 
#ifndef FpmlSerialized_FxMultipleExercise_hpp
#define FpmlSerialized_FxMultipleExercise_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class FxMultipleExercise : public ISerialized { 
   public: 
       FxMultipleExercise(TiXmlNode* xmlNode);

       bool isMinimumNotionalAmount(){return this->minimumNotionalAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getMinimumNotionalAmount();
      std::string getMinimumNotionalAmountIDRef(){return minimumNotionalAmountIDRef_;}

       bool isMaximumNotionalAmount(){return this->maximumNotionalAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getMaximumNotionalAmount();
      std::string getMaximumNotionalAmountIDRef(){return maximumNotionalAmountIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> minimumNotionalAmount_;
       std::string minimumNotionalAmountIDRef_;
       bool minimumNotionalAmountIsNull_;
       boost::shared_ptr<NonNegativeMoney> maximumNotionalAmount_;
       std::string maximumNotionalAmountIDRef_;
       bool maximumNotionalAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


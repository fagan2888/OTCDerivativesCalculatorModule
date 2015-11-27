// Collateral.hpp 
#ifndef FpmlSerialized_Collateral_hpp
#define FpmlSerialized_Collateral_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/IndependentAmount.hpp>

namespace FpmlSerialized {

class Collateral : public ISerialized { 
   public: 
       Collateral(TiXmlNode* xmlNode);

       bool isIndependentAmount(){return this->independentAmountIsNull_;}
       boost::shared_ptr<IndependentAmount> getIndependentAmount();
      std::string getIndependentAmountIDRef(){return independentAmountIDRef_;}

   protected: 
       boost::shared_ptr<IndependentAmount> independentAmount_;
       std::string independentAmountIDRef_;
       bool independentAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


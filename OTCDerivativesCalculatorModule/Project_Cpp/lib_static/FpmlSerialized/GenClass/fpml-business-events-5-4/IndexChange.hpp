// IndexChange.hpp 
#ifndef FpmlSerialized_IndexChange_hpp
#define FpmlSerialized_IndexChange_hpp

#include <fpml-business-events-5-4/ChangeEvent.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class IndexChange : public ChangeEvent { 
   public: 
       IndexChange(TiXmlNode* xmlNode);

       bool isIndexFactor(){return this->indexFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getIndexFactor();
      std::string getIndexFactorIDRef(){return indexFactorIDRef_;}

       bool isFactoredCalculationAmount(){return this->factoredCalculationAmountIsNull_;}
       boost::shared_ptr<Money> getFactoredCalculationAmount();
      std::string getFactoredCalculationAmountIDRef(){return factoredCalculationAmountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> indexFactor_;
       std::string indexFactorIDRef_;
       bool indexFactorIsNull_;
       boost::shared_ptr<Money> factoredCalculationAmount_;
       std::string factoredCalculationAmountIDRef_;
       bool factoredCalculationAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif


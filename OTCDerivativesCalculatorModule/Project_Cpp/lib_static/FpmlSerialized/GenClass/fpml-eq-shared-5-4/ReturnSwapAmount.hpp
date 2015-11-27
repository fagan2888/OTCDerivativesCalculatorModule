// ReturnSwapAmount.hpp 
#ifndef FpmlSerialized_ReturnSwapAmount_hpp
#define FpmlSerialized_ReturnSwapAmount_hpp

#include <fpml-eq-shared-5-4/LegAmount.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ReturnSwapAmount : public LegAmount { 
   public: 
       ReturnSwapAmount(TiXmlNode* xmlNode);

       bool isCashSettlement(){return this->cashSettlementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCashSettlement();
      std::string getCashSettlementIDRef(){return cashSettlementIDRef_;}

       bool isOptionsExchangeDividends(){return this->optionsExchangeDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOptionsExchangeDividends();
      std::string getOptionsExchangeDividendsIDRef(){return optionsExchangeDividendsIDRef_;}

       bool isAdditionalDividends(){return this->additionalDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAdditionalDividends();
      std::string getAdditionalDividendsIDRef(){return additionalDividendsIDRef_;}

       bool isAllDividends(){return this->allDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAllDividends();
      std::string getAllDividendsIDRef(){return allDividendsIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> cashSettlement_;
       std::string cashSettlementIDRef_;
       bool cashSettlementIsNull_;
       boost::shared_ptr<XsdTypeBoolean> optionsExchangeDividends_;
       std::string optionsExchangeDividendsIDRef_;
       bool optionsExchangeDividendsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> additionalDividends_;
       std::string additionalDividendsIDRef_;
       bool additionalDividendsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> allDividends_;
       std::string allDividendsIDRef_;
       bool allDividendsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


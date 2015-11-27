// CreditDefaultSwapOption.hpp 
#ifndef FpmlSerialized_CreditDefaultSwapOption_hpp
#define FpmlSerialized_CreditDefaultSwapOption_hpp

#include <fpml-option-shared-5-4/OptionBaseExtended.hpp>
#include <fpml-cd-5-4/CreditOptionStrike.hpp>
#include <fpml-cd-5-4/CreditDefaultSwap.hpp>

namespace FpmlSerialized {

class CreditDefaultSwapOption : public OptionBaseExtended { 
   public: 
       CreditDefaultSwapOption(TiXmlNode* xmlNode);

       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<CreditOptionStrike> getStrike();
      std::string getStrikeIDRef(){return strikeIDRef_;}

       bool isCreditDefaultSwap(){return this->creditDefaultSwapIsNull_;}
       boost::shared_ptr<CreditDefaultSwap> getCreditDefaultSwap();
      std::string getCreditDefaultSwapIDRef(){return creditDefaultSwapIDRef_;}

   protected: 
       boost::shared_ptr<CreditOptionStrike> strike_;
       std::string strikeIDRef_;
       bool strikeIsNull_;
       boost::shared_ptr<CreditDefaultSwap> creditDefaultSwap_;
       std::string creditDefaultSwapIDRef_;
       bool creditDefaultSwapIsNull_;

};

} //namespaceFpmlSerialized end
#endif


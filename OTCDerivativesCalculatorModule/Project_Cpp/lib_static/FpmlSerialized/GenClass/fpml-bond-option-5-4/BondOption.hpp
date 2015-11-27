// BondOption.hpp 
#ifndef FpmlSerialized_BondOption_hpp
#define FpmlSerialized_BondOption_hpp

#include <fpml-option-shared-5-4/OptionBaseExtended.hpp>
#include <fpml-bond-option-5-4/BondOptionStrike.hpp>
#include <fpml-asset-5-4/Bond.hpp>
#include <fpml-asset-5-4/ConvertibleBond.hpp>

namespace FpmlSerialized {

class BondOption : public OptionBaseExtended { 
   public: 
       BondOption(TiXmlNode* xmlNode);

       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<BondOptionStrike> getStrike();
      std::string getStrikeIDRef(){return strikeIDRef_;}

       bool isBond(){return this->bondIsNull_;}
       boost::shared_ptr<Bond> getBond();
      std::string getBondIDRef(){return bondIDRef_;}

       bool isConvertibleBond(){return this->convertibleBondIsNull_;}
       boost::shared_ptr<ConvertibleBond> getConvertibleBond();
      std::string getConvertibleBondIDRef(){return convertibleBondIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!bondIsNull_){
                count += 1;
                str = "bond" ;
           }
           if(!convertibleBondIsNull_){
                count += 1;
                str = "convertibleBond" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<BondOptionStrike> strike_;
       std::string strikeIDRef_;
       bool strikeIsNull_;
         boost::shared_ptr<Bond> bond_;     //choice
       std::string bondIDRef_;
       bool bondIsNull_;
         boost::shared_ptr<ConvertibleBond> convertibleBond_;     //choice
       std::string convertibleBondIDRef_;
       bool convertibleBondIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif


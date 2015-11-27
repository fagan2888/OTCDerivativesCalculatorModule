// StrikeSpread.hpp 
#ifndef FpmlSerialized_StrikeSpread_hpp
#define FpmlSerialized_StrikeSpread_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/OptionStrike.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class StrikeSpread : public ISerialized { 
   public: 
       StrikeSpread(TiXmlNode* xmlNode);

       bool isUpperStrike(){return this->upperStrikeIsNull_;}
       boost::shared_ptr<OptionStrike> getUpperStrike();
      std::string getUpperStrikeIDRef(){return upperStrikeIDRef_;}

       bool isUpperStrikeNumberOfOptions(){return this->upperStrikeNumberOfOptionsIsNull_;}
       boost::shared_ptr<PositiveDecimal> getUpperStrikeNumberOfOptions();
      std::string getUpperStrikeNumberOfOptionsIDRef(){return upperStrikeNumberOfOptionsIDRef_;}

   protected: 
       boost::shared_ptr<OptionStrike> upperStrike_;
       std::string upperStrikeIDRef_;
       bool upperStrikeIsNull_;
       boost::shared_ptr<PositiveDecimal> upperStrikeNumberOfOptions_;
       std::string upperStrikeNumberOfOptionsIDRef_;
       bool upperStrikeNumberOfOptionsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


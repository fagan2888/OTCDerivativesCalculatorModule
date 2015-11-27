// PercentageTolerance.hpp 
#ifndef FpmlSerialized_PercentageTolerance_hpp
#define FpmlSerialized_PercentageTolerance_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/RestrictedPercentage.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class PercentageTolerance : public ISerialized { 
   public: 
       PercentageTolerance(TiXmlNode* xmlNode);

       bool isPostitive(){return this->postitiveIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getPostitive();
      std::string getPostitiveIDRef(){return postitiveIDRef_;}

       bool isNegative(){return this->negativeIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getNegative();
      std::string getNegativeIDRef(){return negativeIDRef_;}

       bool isOption(){return this->optionIsNull_;}
       boost::shared_ptr<PartyReference> getOption();
      std::string getOptionIDRef(){return optionIDRef_;}

   protected: 
       boost::shared_ptr<RestrictedPercentage> postitive_;
       std::string postitiveIDRef_;
       bool postitiveIsNull_;
       boost::shared_ptr<RestrictedPercentage> negative_;
       std::string negativeIDRef_;
       bool negativeIsNull_;
       boost::shared_ptr<PartyReference> option_;
       std::string optionIDRef_;
       bool optionIsNull_;

};

} //namespaceFpmlSerialized end
#endif


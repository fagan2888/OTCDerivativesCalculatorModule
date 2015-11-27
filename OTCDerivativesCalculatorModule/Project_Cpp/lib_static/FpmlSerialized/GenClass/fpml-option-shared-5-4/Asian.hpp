// Asian.hpp 
#ifndef FpmlSerialized_Asian_hpp
#define FpmlSerialized_Asian_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/AveragingInOutEnum.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-option-shared-5-4/AveragingPeriod.hpp>

namespace FpmlSerialized {

class Asian : public ISerialized { 
   public: 
       Asian(TiXmlNode* xmlNode);

       bool isAveragingInOut(){return this->averagingInOutIsNull_;}
       boost::shared_ptr<AveragingInOutEnum> getAveragingInOut();
      std::string getAveragingInOutIDRef(){return averagingInOutIDRef_;}

       bool isStrikeFactor(){return this->strikeFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrikeFactor();
      std::string getStrikeFactorIDRef(){return strikeFactorIDRef_;}

       bool isAveragingPeriodIn(){return this->averagingPeriodInIsNull_;}
       boost::shared_ptr<AveragingPeriod> getAveragingPeriodIn();
      std::string getAveragingPeriodInIDRef(){return averagingPeriodInIDRef_;}

       bool isAveragingPeriodOut(){return this->averagingPeriodOutIsNull_;}
       boost::shared_ptr<AveragingPeriod> getAveragingPeriodOut();
      std::string getAveragingPeriodOutIDRef(){return averagingPeriodOutIDRef_;}

   protected: 
       boost::shared_ptr<AveragingInOutEnum> averagingInOut_;
       std::string averagingInOutIDRef_;
       bool averagingInOutIsNull_;
       boost::shared_ptr<XsdTypeDecimal> strikeFactor_;
       std::string strikeFactorIDRef_;
       bool strikeFactorIsNull_;
       boost::shared_ptr<AveragingPeriod> averagingPeriodIn_;
       std::string averagingPeriodInIDRef_;
       bool averagingPeriodInIsNull_;
       boost::shared_ptr<AveragingPeriod> averagingPeriodOut_;
       std::string averagingPeriodOutIDRef_;
       bool averagingPeriodOutIsNull_;

};

} //namespaceFpmlSerialized end
#endif


// SimpleFra.hpp 
#ifndef FpmlSerialized_SimpleFra_hpp
#define FpmlSerialized_SimpleFra_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>

namespace FpmlSerialized {

class SimpleFra : public UnderlyingAsset { 
   public: 
       SimpleFra(TiXmlNode* xmlNode);

       bool isStartTerm(){return this->startTermIsNull_;}
       boost::shared_ptr<Period> getStartTerm();
      std::string getStartTermIDRef(){return startTermIDRef_;}

       bool isEndTerm(){return this->endTermIsNull_;}
       boost::shared_ptr<Period> getEndTerm();
      std::string getEndTermIDRef(){return endTermIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

   protected: 
       boost::shared_ptr<Period> startTerm_;
       std::string startTermIDRef_;
       bool startTermIsNull_;
       boost::shared_ptr<Period> endTerm_;
       std::string endTermIDRef_;
       bool endTermIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;

};

} //namespaceFpmlSerialized end
#endif


// RelativeDates.hpp 
#ifndef FpmlSerialized_RelativeDates_hpp
#define FpmlSerialized_RelativeDates_hpp

#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/DateRange.hpp>

namespace FpmlSerialized {

class RelativeDates : public RelativeDateOffset { 
   public: 
       RelativeDates(TiXmlNode* xmlNode);

       bool isPeriodSkip(){return this->periodSkipIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getPeriodSkip();
      std::string getPeriodSkipIDRef(){return periodSkipIDRef_;}

       bool isScheduleBounds(){return this->scheduleBoundsIsNull_;}
       boost::shared_ptr<DateRange> getScheduleBounds();
      std::string getScheduleBoundsIDRef(){return scheduleBoundsIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> periodSkip_;
       std::string periodSkipIDRef_;
       bool periodSkipIsNull_;
       boost::shared_ptr<DateRange> scheduleBounds_;
       std::string scheduleBoundsIDRef_;
       bool scheduleBoundsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


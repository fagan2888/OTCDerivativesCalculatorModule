// ValuationPostponement.hpp 
#ifndef FpmlSerialized_ValuationPostponement_hpp
#define FpmlSerialized_ValuationPostponement_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class ValuationPostponement : public ISerialized { 
   public: 
       ValuationPostponement(TiXmlNode* xmlNode);

       bool isMaximumDaysOfPostponement(){return this->maximumDaysOfPostponementIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getMaximumDaysOfPostponement();
      std::string getMaximumDaysOfPostponementIDRef(){return maximumDaysOfPostponementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> maximumDaysOfPostponement_;
       std::string maximumDaysOfPostponementIDRef_;
       bool maximumDaysOfPostponementIsNull_;

};

} //namespaceFpmlSerialized end
#endif


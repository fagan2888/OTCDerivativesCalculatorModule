// BoundedCorrelation.hpp 
#ifndef FpmlSerialized_BoundedCorrelation_hpp
#define FpmlSerialized_BoundedCorrelation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class BoundedCorrelation : public ISerialized { 
   public: 
       BoundedCorrelation(TiXmlNode* xmlNode);

       bool isMinimumBoundaryPercent(){return this->minimumBoundaryPercentIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getMinimumBoundaryPercent();
      std::string getMinimumBoundaryPercentIDRef(){return minimumBoundaryPercentIDRef_;}

       bool isMaximumBoundaryPercent(){return this->maximumBoundaryPercentIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getMaximumBoundaryPercent();
      std::string getMaximumBoundaryPercentIDRef(){return maximumBoundaryPercentIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> minimumBoundaryPercent_;
       std::string minimumBoundaryPercentIDRef_;
       bool minimumBoundaryPercentIsNull_;
       boost::shared_ptr<XsdTypeDecimal> maximumBoundaryPercent_;
       std::string maximumBoundaryPercentIDRef_;
       bool maximumBoundaryPercentIsNull_;

};

} //namespaceFpmlSerialized end
#endif


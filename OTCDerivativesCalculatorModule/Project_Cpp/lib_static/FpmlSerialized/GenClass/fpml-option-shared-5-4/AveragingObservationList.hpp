// AveragingObservationList.hpp 
#ifndef FpmlSerialized_AveragingObservationList_hpp
#define FpmlSerialized_AveragingObservationList_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/WeightedAveragingObservation.hpp>

namespace FpmlSerialized {

class AveragingObservationList : public ISerialized { 
   public: 
       AveragingObservationList(TiXmlNode* xmlNode);

       bool isAveragingObservation(){return this->averagingObservationIsNull_;}
       std::vector<boost::shared_ptr<WeightedAveragingObservation>> getAveragingObservation();
      std::string getAveragingObservationIDRef(){return averagingObservationIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<WeightedAveragingObservation>> averagingObservation_;
       std::string averagingObservationIDRef_;
       bool averagingObservationIsNull_;

};

} //namespaceFpmlSerialized end
#endif


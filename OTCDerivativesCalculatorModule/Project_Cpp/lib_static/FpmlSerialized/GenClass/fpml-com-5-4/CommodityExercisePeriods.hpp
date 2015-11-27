// CommodityExercisePeriods.hpp 
#ifndef FpmlSerialized_CommodityExercisePeriods_hpp
#define FpmlSerialized_CommodityExercisePeriods_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class CommodityExercisePeriods : public ISerialized { 
   public: 
       CommodityExercisePeriods(TiXmlNode* xmlNode);

       bool isCommencementDate(){return this->commencementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getCommencementDate();
      std::string getCommencementDateIDRef(){return commencementDateIDRef_;}

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> commencementDate_;
       std::string commencementDateIDRef_;
       bool commencementDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif


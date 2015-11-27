// AdjustedRelativeDateOffset.hpp 
#ifndef FpmlSerialized_AdjustedRelativeDateOffset_hpp
#define FpmlSerialized_AdjustedRelativeDateOffset_hpp

#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>

namespace FpmlSerialized {

class AdjustedRelativeDateOffset : public RelativeDateOffset { 
   public: 
       AdjustedRelativeDateOffset(TiXmlNode* xmlNode);

       bool isRelativeDateAdjustments(){return this->relativeDateAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getRelativeDateAdjustments();
      std::string getRelativeDateAdjustmentsIDRef(){return relativeDateAdjustmentsIDRef_;}

   protected: 
       boost::shared_ptr<BusinessDayAdjustments> relativeDateAdjustments_;
       std::string relativeDateAdjustmentsIDRef_;
       bool relativeDateAdjustmentsIsNull_;

};

} //namespaceFpmlSerialized end
#endif


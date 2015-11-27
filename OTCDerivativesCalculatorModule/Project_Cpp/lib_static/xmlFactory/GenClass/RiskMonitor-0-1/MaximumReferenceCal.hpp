// MaximumReferenceCal.hpp 
#ifndef FpmlSerialized_MaximumReferenceCal_hpp
#define FpmlSerialized_MaximumReferenceCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixingDateInfo.hpp>

namespace FpmlSerialized {

class MaximumReferenceCal : public ISerialized { 
   public: 
       MaximumReferenceCal(TiXmlNode* xmlNode);

       bool isNth(){return this->nthIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getNth();


       bool isSelectedUnderName(){return this->selectedUnderNameIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getSelectedUnderName();


       bool isFixingDateInfo(){return this->fixingDateInfoIsNull_;}
       boost::shared_ptr<FixingDateInfo> getFixingDateInfo();


   protected: 
       boost::shared_ptr<XsdTypeDouble> nth_;
       
       bool nthIsNull_;
       std::vector<boost::shared_ptr<XsdTypeToken>> selectedUnderName_;
       
       bool selectedUnderNameIsNull_;
       boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
       
       bool fixingDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif


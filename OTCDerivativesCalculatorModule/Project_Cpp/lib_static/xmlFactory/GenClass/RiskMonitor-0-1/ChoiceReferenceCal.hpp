// ChoiceReferenceCal.hpp 
#ifndef FpmlSerialized_ChoiceReferenceCal_hpp
#define FpmlSerialized_ChoiceReferenceCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixingDateInfo.hpp>

namespace FpmlSerialized {

class ChoiceReferenceCal : public ISerialized { 
   public: 
       ChoiceReferenceCal(TiXmlNode* xmlNode);

       bool isSelectedUnderName(){return this->selectedUnderNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSelectedUnderName();


       bool isFixingDateInfo(){return this->fixingDateInfoIsNull_;}
       boost::shared_ptr<FixingDateInfo> getFixingDateInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> selectedUnderName_;
       
       bool selectedUnderNameIsNull_;
       boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
       
       bool fixingDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif


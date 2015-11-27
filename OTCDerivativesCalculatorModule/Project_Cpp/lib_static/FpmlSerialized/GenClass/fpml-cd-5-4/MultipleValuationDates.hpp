// MultipleValuationDates.hpp 
#ifndef FpmlSerialized_MultipleValuationDates_hpp
#define FpmlSerialized_MultipleValuationDates_hpp

#include <fpml-cd-5-4/SingleValuationDate.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class MultipleValuationDates : public SingleValuationDate { 
   public: 
       MultipleValuationDates(TiXmlNode* xmlNode);

       bool isBusinessDaysThereafter(){return this->businessDaysThereafterIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getBusinessDaysThereafter();
      std::string getBusinessDaysThereafterIDRef(){return businessDaysThereafterIDRef_;}

       bool isNumberValuationDates(){return this->numberValuationDatesIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getNumberValuationDates();
      std::string getNumberValuationDatesIDRef(){return numberValuationDatesIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> businessDaysThereafter_;
       std::string businessDaysThereafterIDRef_;
       bool businessDaysThereafterIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> numberValuationDates_;
       std::string numberValuationDatesIDRef_;
       bool numberValuationDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif


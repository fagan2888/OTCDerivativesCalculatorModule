// StockIndex.hpp 
#ifndef FpmlSerialized_StockIndex_hpp
#define FpmlSerialized_StockIndex_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <fpml-enum-5-4/BusinessDayConventionEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class StockIndex : public ISerialized { 
   public: 
       StockIndex(TiXmlNode* xmlNode);

       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();
      std::string getCodeIDRef(){return codeIDRef_;}

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isIndexType(){return this->indexTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIndexType();
      std::string getIndexTypeIDRef(){return indexTypeIDRef_;}

       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<BusinessDayConventionEnum> getBusinessDayConvention();
      std::string getBusinessDayConventionIDRef(){return businessDayConventionIDRef_;}

       bool isEndOfMonth(){return this->endOfMonthIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getEndOfMonth();
      std::string getEndOfMonthIDRef(){return endOfMonthIDRef_;}

       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();
      std::string getDayCounterIDRef(){return dayCounterIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> code_;
       std::string codeIDRef_;
       bool codeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> indexType_;
       std::string indexTypeIDRef_;
       bool indexTypeIsNull_;
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention_;
       std::string businessDayConventionIDRef_;
       bool businessDayConventionIsNull_;
       boost::shared_ptr<XsdTypeBoolean> endOfMonth_;
       std::string endOfMonthIDRef_;
       bool endOfMonthIsNull_;
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       std::string dayCounterIDRef_;
       bool dayCounterIsNull_;

};

} //namespaceFpmlSerialized end
#endif


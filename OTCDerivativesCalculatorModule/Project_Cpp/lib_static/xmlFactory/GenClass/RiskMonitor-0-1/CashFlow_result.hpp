// CashFlow_result.hpp 
#ifndef FpmlSerialized_CashFlow_result_hpp
#define FpmlSerialized_CashFlow_result_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CashFlow_result : public ISerialized { 
   public: 
       CashFlow_result(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getValue();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeToken> value_;
       
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif


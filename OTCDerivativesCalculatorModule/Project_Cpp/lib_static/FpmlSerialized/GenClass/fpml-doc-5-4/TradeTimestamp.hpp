// TradeTimestamp.hpp 
#ifndef FpmlSerialized_TradeTimestamp_hpp
#define FpmlSerialized_TradeTimestamp_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/TimestampTypeScheme.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>

namespace FpmlSerialized {

class TradeTimestamp : public ISerialized { 
   public: 
       TradeTimestamp(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<TimestampTypeScheme> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getValue();
      std::string getValueIDRef(){return valueIDRef_;}

   protected: 
       boost::shared_ptr<TimestampTypeScheme> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeDateTime> value_;
       std::string valueIDRef_;
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif


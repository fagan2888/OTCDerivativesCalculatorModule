// OptionExpiryBase.hpp 
#ifndef FpmlSerialized_OptionExpiryBase_hpp
#define FpmlSerialized_OptionExpiryBase_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeTime.hpp>

namespace FpmlSerialized {

class OptionExpiryBase : public ISerialized { 
   public: 
       OptionExpiryBase(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       bool isTime(){return this->timeIsNull_;}
       boost::shared_ptr<XsdTypeTime> getTime();
      std::string getTimeIDRef(){return timeIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;
       boost::shared_ptr<XsdTypeTime> time_;
       std::string timeIDRef_;
       bool timeIsNull_;

};

} //namespaceFpmlSerialized end
#endif


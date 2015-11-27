// MakeWholeProvisions.hpp 
#ifndef FpmlSerialized_MakeWholeProvisions_hpp
#define FpmlSerialized_MakeWholeProvisions_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class MakeWholeProvisions : public ISerialized { 
   public: 
       MakeWholeProvisions(TiXmlNode* xmlNode);

       bool isMakeWholeDate(){return this->makeWholeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMakeWholeDate();
      std::string getMakeWholeDateIDRef(){return makeWholeDateIDRef_;}

       bool isRecallSpread(){return this->recallSpreadIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getRecallSpread();
      std::string getRecallSpreadIDRef(){return recallSpreadIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> makeWholeDate_;
       std::string makeWholeDateIDRef_;
       bool makeWholeDateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> recallSpread_;
       std::string recallSpreadIDRef_;
       bool recallSpreadIsNull_;

};

} //namespaceFpmlSerialized end
#endif


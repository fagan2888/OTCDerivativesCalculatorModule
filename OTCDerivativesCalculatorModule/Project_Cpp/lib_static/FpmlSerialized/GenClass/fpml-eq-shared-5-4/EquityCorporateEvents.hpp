// EquityCorporateEvents.hpp 
#ifndef FpmlSerialized_EquityCorporateEvents_hpp
#define FpmlSerialized_EquityCorporateEvents_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/ShareExtraordinaryEventEnum.hpp>

namespace FpmlSerialized {

class EquityCorporateEvents : public ISerialized { 
   public: 
       EquityCorporateEvents(TiXmlNode* xmlNode);

       bool isShareForShare(){return this->shareForShareIsNull_;}
       boost::shared_ptr<ShareExtraordinaryEventEnum> getShareForShare();
      std::string getShareForShareIDRef(){return shareForShareIDRef_;}

       bool isShareForOther(){return this->shareForOtherIsNull_;}
       boost::shared_ptr<ShareExtraordinaryEventEnum> getShareForOther();
      std::string getShareForOtherIDRef(){return shareForOtherIDRef_;}

       bool isShareForCombined(){return this->shareForCombinedIsNull_;}
       boost::shared_ptr<ShareExtraordinaryEventEnum> getShareForCombined();
      std::string getShareForCombinedIDRef(){return shareForCombinedIDRef_;}

   protected: 
       boost::shared_ptr<ShareExtraordinaryEventEnum> shareForShare_;
       std::string shareForShareIDRef_;
       bool shareForShareIsNull_;
       boost::shared_ptr<ShareExtraordinaryEventEnum> shareForOther_;
       std::string shareForOtherIDRef_;
       bool shareForOtherIsNull_;
       boost::shared_ptr<ShareExtraordinaryEventEnum> shareForCombined_;
       std::string shareForCombinedIDRef_;
       bool shareForCombinedIsNull_;

};

} //namespaceFpmlSerialized end
#endif


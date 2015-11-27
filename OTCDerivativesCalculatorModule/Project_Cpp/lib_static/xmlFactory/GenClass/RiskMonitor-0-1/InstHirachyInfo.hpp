// InstHirachyInfo.hpp 
#ifndef FpmlSerialized_InstHirachyInfo_hpp
#define FpmlSerialized_InstHirachyInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/InstHirachyInfo.hpp>

namespace FpmlSerialized {

class InstHirachyInfo : public ISerialized { 
   public: 
       InstHirachyInfo(TiXmlNode* xmlNode);

       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();


       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isInstHirachyInfo(){return this->instHirachyInfoIsNull_;}
       std::vector<boost::shared_ptr<InstHirachyInfo>> getInstHirachyInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> code_;
       
       bool codeIsNull_;
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       std::vector<boost::shared_ptr<InstHirachyInfo>> instHirachyInfo_;
       
       bool instHirachyInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif


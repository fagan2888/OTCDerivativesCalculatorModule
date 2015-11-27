// PathInfo.hpp 
#ifndef FpmlSerialized_PathInfo_hpp
#define FpmlSerialized_PathInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class PathInfo : public ISerialized { 
   public: 
       PathInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isUrl(){return this->urlIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUrl();


   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeToken> url_;
       
       bool urlIsNull_;

};

} //namespaceFpmlSerialized end
#endif


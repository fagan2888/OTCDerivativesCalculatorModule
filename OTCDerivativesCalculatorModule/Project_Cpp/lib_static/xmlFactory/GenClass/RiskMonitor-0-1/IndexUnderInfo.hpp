// IndexUnderInfo.hpp 
#ifndef FpmlSerialized_IndexUnderInfo_hpp
#define FpmlSerialized_IndexUnderInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Index.hpp>

namespace FpmlSerialized {

class IndexUnderInfo : public ISerialized { 
   public: 
       IndexUnderInfo(TiXmlNode* xmlNode);

       bool isIndex(){return this->indexIsNull_;}
       std::vector<boost::shared_ptr<Index>> getIndex();


   protected: 
       std::vector<boost::shared_ptr<Index>> index_;
       
       bool indexIsNull_;

};

} //namespaceFpmlSerialized end
#endif


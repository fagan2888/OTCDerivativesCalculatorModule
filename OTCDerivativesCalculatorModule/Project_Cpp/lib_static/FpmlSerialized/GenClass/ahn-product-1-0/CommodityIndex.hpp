// CommodityIndex.hpp 
#ifndef FpmlSerialized_CommodityIndex_hpp
#define FpmlSerialized_CommodityIndex_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CommodityIndex : public ISerialized { 
   public: 
       CommodityIndex(TiXmlNode* xmlNode);

       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();
      std::string getCodeIDRef(){return codeIDRef_;}

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isIndexType(){return this->indexTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIndexType();
      std::string getIndexTypeIDRef(){return indexTypeIDRef_;}

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

};

} //namespaceFpmlSerialized end
#endif


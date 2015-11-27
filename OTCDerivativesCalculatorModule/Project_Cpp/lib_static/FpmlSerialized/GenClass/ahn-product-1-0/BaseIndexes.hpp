// BaseIndexes.hpp 
#ifndef FpmlSerialized_BaseIndexes_hpp
#define FpmlSerialized_BaseIndexes_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/UnderlyingIndex.hpp>

namespace FpmlSerialized {

class BaseIndexes : public ISerialized { 
   public: 
       BaseIndexes(TiXmlNode* xmlNode);

       bool isUnderlyingIndex(){return this->underlyingIndexIsNull_;}
       std::vector<boost::shared_ptr<UnderlyingIndex>> getUnderlyingIndex();
      std::string getUnderlyingIndexIDRef(){return underlyingIndexIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<UnderlyingIndex>> underlyingIndex_;
       std::string underlyingIndexIDRef_;
       bool underlyingIndexIsNull_;

};

} //namespaceFpmlSerialized end
#endif

